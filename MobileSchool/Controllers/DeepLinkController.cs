using System.Web.Mvc;

namespace MobileSchool.Controllers
{
	public class DeepLinkController : Controller
    {
		public ActionResult DeepLink()
		{
			return Redirect("tomerdl://");
		}


		public ActionResult Intent()
		{
			return Redirect("intent://open?link_click_id=123456#Intent;scheme=tomerdl;package=com.link.deeplink.deeplinking;end");
		}

		public ActionResult DLView()
		{
			return View();
		}

		public ActionResult DLIntent()
		{
			return View();
		}
	}
}