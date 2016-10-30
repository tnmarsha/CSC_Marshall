using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DimondDating.Controllers
{
    public class QuickSearchController : Controller
    {
        // GET: QuickSearch
        public ActionResult Index()
        {
            return View();
            //return "this is my <b>default</b> action";
        }

        public string Welcome(string name, int numTimes =1)
        {
            return HttpUtility.HtmlEncode("Hello" + name + ", NumTimes is: " + numTimes);
        }
    }
}