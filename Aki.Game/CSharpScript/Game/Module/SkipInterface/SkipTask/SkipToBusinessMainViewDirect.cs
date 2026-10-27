using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BC0 RID: 19392
	public class SkipToBusinessMainViewDirect : SkipToMoonChasingBase
	{
		// Token: 0x0603230F RID: 205583 RVA: 0x00BA9BC8 File Offset: 0x00BA7DC8
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
