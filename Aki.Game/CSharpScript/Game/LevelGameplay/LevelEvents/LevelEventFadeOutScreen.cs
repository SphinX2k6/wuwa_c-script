using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.Guarantee;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.Plot;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CA3 RID: 23715
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventFadeOutScreen : LevelEventBase
	{
		// Token: 0x0603A260 RID: 238176 RVA: 0x01065F60 File Offset: 0x01064160
		public LevelEventFadeOutScreen(int id) : base(id)
		{
		}

		// Token: 0x0603A261 RID: 238177 RVA: 0x01065F6C File Offset: 0x0106416C
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			FadeBackgroundController.Instance.CloseFadeBackground();
			if (inParams == null)
			{
				return;
			}
			FadeOutScreen fadeOutScreen = inParams as FadeOutScreen;
			PlotModel.Instance.IsFadeIn = false;
			if (PlotModel.Instance.BlackScreenType.GetValueOrDefault() == EBlackScreenType.Plot && PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.LevelC)
			{
				EventSystem.Instance.Emit<bool, Action>(EEventName.PlotViewBgFadeBlackScreen, false, new Action(this.OnFadeComplete));
				return;
			}
			Global.CharacterCameraManager.FadeAmount = 0f;
			LevelLoadingController instance = LevelLoadingController.Instance;
			ELoadingReason reason = ELoadingReason.Common;
			string context2 = null;
			Action callback = delegate()
			{
				base.FinishExecute(true, false, true);
				LoadingModel.Instance.ScreenEffect = new EScreenEffectType?(EScreenEffectType.ScreenEffectNone);
				PlotModel.Instance.LastPlotAspect = -1f;
				PlotModel.Instance.LastPlotColor = -1;
			};
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
			instance.CloseLoading(reason, context2, callback, duration);
		}

		// Token: 0x0603A262 RID: 238178 RVA: 0x01066034 File Offset: 0x01064234
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			FadeBackgroundController.Instance.CloseFadeBackground();
			LevelLoadingController.Instance.CloseLoading(ELoadingReason.Common, null, delegate
			{
				base.FinishExecute(true, false, true);
				LoadingModel.Instance.ScreenEffect = new EScreenEffectType?(EScreenEffectType.ScreenEffectNone);
			}, new float?(0f));
		}

		// Token: 0x0603A263 RID: 238179 RVA: 0x01066062 File Offset: 0x01064262
		private void OnFadeComplete()
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0603A264 RID: 238180 RVA: 0x01066070 File Offset: 0x01064270
		protected override void OnUpdateGuarantee()
		{
			GuaranteeActionInfo p = new GuaranteeActionInfo
			{
				Name = EGuaranteeAction.ActionBlackScreenFadeOut
			};
			EventSystem.Instance.Emit<string, GeneralContext, GuaranteeActionInfo, bool?>(EEventName.RemGuaranteeAction, this.Type, this.BaseContext, p, null);
		}
	}
}
