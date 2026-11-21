using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B81 RID: 15233
	public class SkipToRoleOrnamentId : SkipTask
	{
		// Token: 0x060270D0 RID: 159952 RVA: 0x00AEEAB0 File Offset: 0x00AECCB0
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
