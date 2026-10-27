using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BBE RID: 19390
	public class SkipToBuildingView : SkipToMoonChasingBase
	{
		// Token: 0x0603230B RID: 205579 RVA: 0x00BA9A90 File Offset: 0x00BA7C90
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			string s = (string)data[0];
			string text = (string)data[1];
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
					goto IL_56;
				}
			}
			moonChasingMainViewModel2 = new MoonChasingMainViewModel();
			IL_56:
			moonChasingMainViewModel2.SkipTarget = EMoonChasingSkipDefine.Build;
			if (UiManager.Instance.IsViewOpen(EUiViewName.RewardMainView))
			{
				if (text != "0")
				{
					MoonChasingController.Instance.OpenBuildingTipsInfoView(int.Parse(text));
				}
				UiManager.Instance.CloseView(EUiViewName.RewardMainView, null);
			}
		}

		// Token: 0x0401AB8F RID: 109455
		[Nullable(1)]
		private const string ZERO_STRING = "0";
	}
}
