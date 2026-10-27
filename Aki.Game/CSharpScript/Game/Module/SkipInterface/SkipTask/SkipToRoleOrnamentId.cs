using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BD7 RID: 19415
	public class SkipToRoleOrnamentId : SkipTask
	{
		// Token: 0x0603233F RID: 205631 RVA: 0x00BAA7F8 File Offset: 0x00BA89F8
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			if (UiManager.Instance.IsViewShow(EUiViewName.ItemTipsView))
			{
				UiManager.Instance.CloseView(EUiViewName.ItemTipsView, null);
			}
			int ornamentId = Convert.ToInt32(data[0]);
			RoleController.Instance.OpenOrnamentPreviewView(ornamentId, null);
			base.Finish();
		}
	}
}
