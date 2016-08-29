// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

namespace Sylapse.AccessoryTextInput
{
    [Register("InputView")]
    public class InputView : UIView
    {
        public InputView(IntPtr handle) : base(handle)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            TextField.TranslatesAutoresizingMaskIntoConstraints = true; // No constraints for the TextField, will update its frame manually
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            TextField.Frame = TextView.Frame;
        }

        [Outlet]
        public UIButton DoneButton { get; set; }

        [Outlet]
        public UITextView TextView { get; set; }

        [Outlet]
        public UITextField TextField { get; set; }

        void ReleaseDesignerOutlets()
        {
            if (TextField != null)
            {
                TextField.Dispose();
                TextField = null;
            }

            if (TextView != null)
            {
                TextView.Dispose();
                TextView = null;
            }

            if (DoneButton != null)
            {
                DoneButton.Dispose();
                DoneButton = null;
            }
        }
    }
}
