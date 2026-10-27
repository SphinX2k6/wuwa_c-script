using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.Guarantee;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.Plot;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B2B RID: 27435
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventFadeOutScreen : LevelEventBase
	{
		// Token: 0x0604410E RID: 278798 RVA: 0x010BC6D4 File Offset: 0x010BA8D4
		public LevelEventFadeOutScreen(int id) : base(id)
		{
		}

		// Token: 0x0604410F RID: 278799 RVA: 0x010BC6E0 File Offset: 0x010BA8E0
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

		// Token: 0x06044110 RID: 278800 RVA: 0x010BC7A8 File Offset: 0x010BA9A8
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			FadeBackgroundController.Instance.CloseFadeBackground();
			LevelLoadingController.Instance.CloseLoading(ELoadingReason.Common, null, delegate
			{
				base.FinishExecute(true, false, true);
				LoadingModel.Instance.ScreenEffect = new EScreenEffectType?(EScreenEffectType.ScreenEffectNone);
			}, new float?(0f));
		}

		// Token: 0x06044111 RID: 278801 RVA: 0x010BC7D6 File Offset: 0x010BA9D6
		private void OnFadeComplete()
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x06044112 RID: 278802 RVA: 0x010BC7E4 File Offset: 0x010BA9E4
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
