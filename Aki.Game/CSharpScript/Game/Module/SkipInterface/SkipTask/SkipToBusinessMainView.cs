using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BBF RID: 19391
	public class SkipToBusinessMainView : SkipToMoonChasingBase
	{
		// Token: 0x0603230D RID: 205581 RVA: 0x00BA9B40 File Offset: 0x00BA7D40
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
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.MoonChasingMainView);
			MoonChasingMainViewModel moonChasingMainViewModel2;
			if (viewByName != null)
			{
				MoonChasingMainViewModel moonChasingMainViewModel = viewByName.OpenParam as MoonChasingMainViewModel;
				if (moonChasingMainViewModel != null)
				{
					moonChasingMainViewModel2 = moonChasingMainViewModel;
					goto IL_4A;
				}
			}
			moonChasingMainViewModel2 = new MoonChasingMainViewModel();
			IL_4A:
			moonChasingMainViewModel2.SkipTarget = EMoonChasingSkipDefine.Business;
			if (UiManager.Instance.IsViewOpen(EUiViewName.RewardMainView))
			{
				UiManager.Instance.CloseView(EUiViewName.RewardMainView, null);
			}
		}
	}
}
