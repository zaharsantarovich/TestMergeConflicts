using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			// Admin-005 feature.
			// Admin-007 feature.
			// Admin-009 feature.
			// Admin-011 feature.
			// Admin-013 feature.
			return View();
		}

		public ActionResult About()
		{
			// Admin-004 feature.
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult Help()
		{
			// Fix for critical bug Admin-001.
			// Fix for critical bug Admin-002.
			return Json(new { value = 4 });
		}
	}
}