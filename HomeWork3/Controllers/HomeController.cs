using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(int id)
        {
            return File($@"C:\Users\шипиловд\source\repos\HomeWork3\HomeWork3\{id}.mp3", "audio/mpeg", $"result{id}.mp3");
        }

        public ActionResult All()
        {
            return File(@"C:\Users\шипиловд\source\repos\HomeWork3\HomeWork3\All.rar", "application/zip", $"result.zip");
        }
    }
}