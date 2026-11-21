using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.Plot.Flow;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x02004087 RID: 16519
	public class FlowActionFadeInScreen : FlowActionBase
	{
		// Token: 0x06029DC6 RID: 171462 RVA: 0x00BD66A8 File Offset: 0x00BD48A8
		protected override void OnExecute()
		{
			FlowController.Instance.EnableSkip(false);
			FadeInScreen fadeInScreen = this.ActionInfo.Params as FadeInScreen;
			PlotModel.Instance.IsFadeIn = true;
			PlotModel.Instance.BlackScreenType = new EBlackScreenType?(EBlackScreenType.Plot);
			if (((fadeInScreen != null) ? fadeInScreen.FadeBackground : null) != null)
			{
				PlotModel.Instance.BlackScreenType = new EBlackScreenType?(EBlackScreenType.Ui);
				FadeBackgroundController.Instance.OpenFadeBackground(fadeInScreen.FadeBackground);
				base.RecordAction(null);
				this.OnFadeComplete();
				return;
			}
			if (PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.LevelC && fadeInScreen != null && fadeInScreen.TypeOverride != null)
			{
				PlotModel.Instance.BlackScreenType = new EBlackScreenType?(EBlackScreenType.Plot);
			}
			else
			{
				PlotModel.Instance.BlackScreenType = new EBlackScreenType?(EBlackScreenType.Ui);
			}
			EBlackScreenType? blackScreenType = PlotModel.Instance.BlackScreenType;
			EBlackScreenType eblackScreenType = EBlackScreenType.Ui;
			if (blackScreenType.GetValueOrDefault() == eblackScreenType & blackScreenType != null)
			{
				LevelLoadingController instance = LevelLoadingController.Instance;
				ELoadingReason reason = ELoadingReason.Common;
				ELoadingPerform perform = ELoadingPerform.CameraFade;
				string context = "FlowActionFadeInScreen";
				Action callback = new Action(this.OnFadeComplete);
				object[] array = new object[2];
				int num = 0;
				float? num2;
				if (fadeInScreen == null)
				{
					num2 = null;
				}
				else
				{
					IEaseData ease = fadeInScreen.Ease;
					num2 = ((ease != null) ? new float?(ease.Duration) : null);
				}
				array[num] = num2;
				array[1] = (((fadeInScreen != null) ? fadeInScreen.ScreenType : null) ?? LevelLoadingController.Instance.CameraFade.ColorSearch());
				instance.OpenLoading<ELoadingPerform>(reason, perform, context, callback, array);
			}
			else
			{
				PlotController.Instance.PlotViewManager.PlotViewBgFadeBlackScreen(true, new Action(this.OnFadeComplete));
			}
			base.RecordAction(null);
		}

		// Token: 0x06029DC7 RID: 171463 RVA: 0x00BD6857 File Offset: 0x00BD4A57
		protected override void OnBackgroundExecute()
		{
			PlotModel.Instance.IsFadeIn = true;
			base.FinishExecute(true, true);
		}

		// Token: 0x06029DC8 RID: 171464 RVA: 0x00BD686C File Offset: 0x00BD4A6C
		private void OnFadeComplete()
		{
			base.FinishExecute(true, true);
		}

		// Token: 0x06029DC9 RID: 171465 RVA: 0x00BD6878 File Offset: 0x00BD4A78
		[NullableContext(1)]
		protected override void OnRollback(ActionRecord actionInfo, FlowContext context)
		{
			FadeBackgroundController.Instance.CloseFadeBackground();
			LevelLoadingController.Instance.CloseLoading(ELoadingReason.Common, "FlowActionFadeInScreen_Rollback", null, null);
		}
	}
}
