using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.Plot.Flow;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050B8 RID: 20664
	public class FlowActionFadeOutScreen : FlowActionBase
	{
		// Token: 0x06034ED2 RID: 216786 RVA: 0x00C895CC File Offset: 0x00C877CC
		protected override void OnExecute()
		{
			FadeBackgroundController.Instance.CloseFadeBackground();
			FlowController.Instance.EnableSkip(true);
			FadeOutScreen fadeOutScreen = this.ActionInfo.Params as FadeOutScreen;
			PlotModel.Instance.IsFadeIn = false;
			PlotModel.Instance.LastPlotAspect = -1f;
			if (PlotModel.Instance.BlackScreenType.GetValueOrDefault() == EBlackScreenType.Plot && PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.LevelC)
			{
				PlotController.Instance.PlotViewManager.PlotViewBgFadeBlackScreen(false, new Action(this.OnFadeComplete));
				return;
			}
			Global.CharacterCameraManager.FadeAmount = 0f;
			LevelLoadingController instance = LevelLoadingController.Instance;
			ELoadingReason reason = ELoadingReason.Common;
			string context = "FlowActionFadeOutScreen";
			Action callback = new Action(this.OnFadeComplete);
			float? duration;
			if (fadeOutScreen == null)
			{
				duration = null;
			}
			else
			{
				IEaseData ease = fadeOutScreen.Ease;
				duration = ((ease != null) ? new float?(ease.Duration) : null);
			}
			instance.CloseLoading(reason, context, callback, duration);
		}

		// Token: 0x06034ED3 RID: 216787 RVA: 0x00C896B7 File Offset: 0x00C878B7
		protected override void OnBackgroundExecute()
		{
			FadeBackgroundController.Instance.CloseFadeBackground();
			PlotModel.Instance.IsFadeIn = false;
			base.FinishExecute(true, true);
		}

		// Token: 0x06034ED4 RID: 216788 RVA: 0x00C896D6 File Offset: 0x00C878D6
		private void OnFadeComplete()
		{
			base.FinishExecute(true, true);
		}
	}
}
