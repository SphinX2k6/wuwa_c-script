using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.Plot;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006F89 RID: 28553
	public class LevelFlowFadeOutScreen : LevelFlowActionBase
	{
		// Token: 0x0604570A RID: 284426 RVA: 0x01138221 File Offset: 0x01136421
		[NullableContext(1)]
		public LevelFlowFadeOutScreen Init(FadeOutScreen inParams)
		{
			this.InParams = inParams;
			return this;
		}

		// Token: 0x0604570B RID: 284427 RVA: 0x0113822C File Offset: 0x0113642C
		protected override void OnExecute()
		{
			FadeBackgroundController.Instance.CloseFadeBackground();
			if (this.InParams == null)
			{
				base.FinishExecute(false);
				return;
			}
			FadeOutScreen inParams = this.InParams;
			PlotModel.Instance.IsFadeIn = false;
			if (PlotModel.Instance.BlackScreenType.GetValueOrDefault() == EBlackScreenType.Plot && PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.LevelC)
			{
				EventSystem.Instance.Emit<bool, Action>(EEventName.PlotViewBgFadeBlackScreen, false, new Action(this.OnFadeComplete));
				return;
			}
			Global.CharacterCameraManager.FadeAmount = 0f;
			LevelLoadingController instance = LevelLoadingController.Instance;
			ELoadingReason reason = ELoadingReason.Common;
			string context = "LevelFlowFadeOutScreen";
			Action callback = delegate()
			{
				base.FinishExecute(true);
				LoadingModel.Instance.ScreenEffect = new EScreenEffectType?(EScreenEffectType.ScreenEffectNone);
				PlotModel.Instance.LastPlotAspect = -1f;
				PlotModel.Instance.LastPlotColor = -1;
			};
			IEaseData ease = inParams.Ease;
			instance.CloseLoading(reason, context, callback, (ease != null) ? new float?(ease.Duration) : null);
		}

		// Token: 0x0604570C RID: 284428 RVA: 0x011382F6 File Offset: 0x011364F6
		private void OnFadeComplete()
		{
			base.FinishExecute(true);
		}

		// Token: 0x040243BB RID: 148411
		[Nullable(2)]
		private FadeOutScreen InParams;
	}
}
