using System;

using UIKit;

namespace XamariniOSAlert
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			btnAlert.TouchUpInside += ((sender, e) =>
			{

				//Create Alert
				var okCancelAlertController = UIAlertController.Create("Xamarin Alert", "Do You Love Xamarin", UIAlertControllerStyle.Alert);

				//Add Actions
				okCancelAlertController.AddAction(UIAlertAction.Create("Yes", UIAlertActionStyle.Default, alert => lblDisplay.Text=("Yes I Love Xamarin")));
				okCancelAlertController.AddAction(UIAlertAction.Create("No", UIAlertActionStyle.Cancel, alert => lblDisplay.Text=("No I Don't Love Xamarin")));

				//Present Alert
				PresentViewController(okCancelAlertController, true, null);
			});
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
