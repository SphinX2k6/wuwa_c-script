using System;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000E0 RID: 224
	public class HotFixPopupRepairView : HotFixPopupUiView
	{
		// Token: 0x06000759 RID: 1881 RVA: 0x0003B510 File Offset: 0x00039710
		protected override void OnStart()
		{
			base.OnStart();
			base.SetConfirmationTitle("PatchClearTitle");
			base.SetConfirmationContent("PatchClear", Array.Empty<string>());
			base.SetConfirmationLeftButtonText(EHotFixTextId.HotFixCancel.ToString());
			base.SetConfirmationRightButtonText("ConfirmText");
			base.SetConfirmationCloseButtonActive(true);
			base.SetConfirmationLeftButtonActive(true);
			base.SetConfirmationRightButtonActive(true);
			base.SetConfirmationMiddleButtonActive(false);
			base.SetConfirmationCloseButtonCallBack(delegate
			{
				base.SetActive(false);
			});
			base.SetConfirmationLeftButtonCallBack(delegate
			{
				base.SetActive(false);
			});
			base.SetConfirmationRightButtonCallBack(delegate
			{
				HotPatch.Instance.ClearPatch();
				base.SetActive(false);
			});
		}
	}
}
