using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.Plot;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x0200610A RID: 24842
	public class LevelFlowFadeOutScreen : LevelFlowActionBase
	{
		// Token: 0x0603B8B8 RID: 243896 RVA: 0x010E2025 File Offset: 0x010E0225
		[NullableContext(1)]
		public LevelFlowFadeOutScreen Init(FadeOutScreen inParams)
		{
			this.InParams = inParams;
			return this;
		}

		// Token: 0x0603B8B9 RID: 243897 RVA: 0x010E2030 File Offset: 0x010E0230
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

		// Token: 0x0603B8BA RID: 243898 RVA: 0x010E20FA File Offset: 0x010E02FA
		private void OnFadeComplete()
		{
			base.FinishExecute(true);
		}

		// Token: 0x0401F670 RID: 128624
		[Nullable(2)]
		private FadeOutScreen InParams;
	}
}
