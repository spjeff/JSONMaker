using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JSONMaker.Controllers
{
    public class jsonTo
    {
        public string to;
        public string[] array;
    }
    public class ParseController : ApiController
    {
        // GET: api/Parse
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Parse/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Parse
        public jsonTo Post([FromBody]jsonTo value)
        {
            //delimiter
            char[] c = ",;".ToCharArray();
            string[] arr = value.to.Split(c, StringSplitOptions.RemoveEmptyEntries);

            //trim
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i].Trim();
            }

            //json
            jsonTo to = new jsonTo();
            to.array = arr;
            return to;
        }

        // PUT: api/Parse/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Parse/5
        public void Delete(int id)
        {
        }
    }
}
