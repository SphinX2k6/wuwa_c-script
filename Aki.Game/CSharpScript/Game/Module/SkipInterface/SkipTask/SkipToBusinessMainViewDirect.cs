using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B6A RID: 15210
	public class SkipToBusinessMainViewDirect : SkipToMoonChasingBase
	{
		// Token: 0x060270A0 RID: 159904 RVA: 0x00AEDE74 File Offset: 0x00AEC074
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			string s = (string)data[0];
			if (!base.CheckMainViewOpen())
			{
				base.SkipToMap(int.Parse(s));
				return;
			}
			if (UiManager.Instance.IsViewShow(EUiViewName.ItemTipsView))
			{
				UiManager.Instance.CloseView(EUiViewName.ItemTipsView, null);
			}
			if (!UiManager.Instance.IsViewOpen(EUiViewName.BusinessMainView))
			{
				MoonChasingController.Instance.OpenBusinessMainView();
			}
		}
	}
}
