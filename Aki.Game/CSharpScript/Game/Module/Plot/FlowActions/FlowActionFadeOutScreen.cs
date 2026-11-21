using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.Plot.Flow;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x02004088 RID: 16520
	public class FlowActionFadeOutScreen : FlowActionBase
	{
		// Token: 0x06029DCB RID: 171467 RVA: 0x00BD68B4 File Offset: 0x00BD4AB4
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

		// Token: 0x06029DCC RID: 171468 RVA: 0x00BD699F File Offset: 0x00BD4B9F
		protected override void OnBackgroundExecute()
		{
			FadeBackgroundController.Instance.CloseFadeBackground();
			PlotModel.Instance.IsFadeIn = false;
			base.FinishExecute(true, true);
		}

		// Token: 0x06029DCD RID: 171469 RVA: 0x00BD69BE File Offset: 0x00BD4BBE
		private void OnFadeComplete()
		{
			base.FinishExecute(true, true);
		}
	}
}
