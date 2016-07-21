using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Search;


namespace DbSearch
{
    public class SearchDb:ISearch
    {
        /// <summary>
        /// Search in Db
        /// </summary>
        /// <param name="str">What to search</param>
        /// <param name="param">Param if needed (Connection string)</param>
        /// <returns></returns>
        public string Search(string str, string param = null)
        {
            return String.Empty;
        }
    }
}
