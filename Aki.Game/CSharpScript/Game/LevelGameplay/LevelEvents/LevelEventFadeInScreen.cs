using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.Guarantee;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.Plot;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CA2 RID: 23714
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventFadeInScreen : LevelEventBase
	{
		// Token: 0x0603A259 RID: 238169 RVA: 0x01065C38 File Offset: 0x01063E38
		public LevelEventFadeInScreen(int id) : base(id)
		{
		}

		// Token: 0x0603A25A RID: 238170 RVA: 0x01065C44 File Offset: 0x01063E44
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				return;
			}
			int? num = null;
			FadeInScreen fadeInScreen = inParams as FadeInScreen;
			if (fadeInScreen.KeepFadeAfterTreeEnd.GetValueOrDefault())
			{
				this.KeepFadeAfterTreeEnd = fadeInScreen.KeepFadeAfterTreeEnd.Value;
			}
			if (!this.KeepFadeAfterTreeEnd && context != null && context.Type.GetValueOrDefault() == EGeneralContextType.GeneralLogicTree)
			{
				GeneralLogicTreeContext generalLogicTreeContext = context as GeneralLogicTreeContext;
				if (generalLogicTreeContext != null && generalLogicTreeContext.BtType == BtType.LevelPlay)
				{
					num = new int?(generalLogicTreeContext.TreeConfigId);
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.BlackScreen;
					ELogAuthor author = ELogAuthor.JYS;
					string message = "玩法内开启黑幕：";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("treeId", generalLogicTreeContext.TreeConfigId);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
			}
			PlotModel.Instance.IsFadeIn = true;
			CameraModel instance2 = CameraModel.Instance;
			if (instance2 != null)
			{
				FightCamera fightCamera = instance2.MainModel.FightCamera;
				if (fightCamera != null)
				{
					FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
					if (logicComponent != null)
					{
						logicComponent.ExitCameraHook(false);
					}
				}
			}
			if (fadeInScreen.FadeBackground != null)
			{
				PlotModel.Instance.BlackScreenType = new EBlackScreenType?(EBlackScreenType.Ui);
				FadeBackgroundController.Instance.OpenFadeBackground(fadeInScreen.FadeBackground);
				base.FinishExecute(true, false, true);
				return;
			}
			if (PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.LevelC && fadeInScreen.TypeOverride != null)
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
				EFadeInScreenShowType? screenType = fadeInScreen.ScreenType;
				if (screenType != null)
				{
					EFadeInScreenShowType valueOrDefault = screenType.GetValueOrDefault();
					if (valueOrDefault != EFadeInScreenShowType.White)
					{
						if (valueOrDefault == EFadeInScreenShowType.Black)
						{
							LoadingModel.Instance.ScreenEffect = new EScreenEffectType?(EScreenEffectType.ScreenEffectBlack);
						}
					}
					else
					{
						LoadingModel.Instance.ScreenEffect = new EScreenEffectType?(EScreenEffectType.ScreenEffectWhite);
					}
				}
				LevelLoadingController instance3 = LevelLoadingController.Instance;
				ELoadingReason reason = ELoadingReason.Common;
				ELoadingPerform perform = ELoadingPerform.CameraFade;
				string context2 = null;
				Action callback = delegate()
				{
					base.FinishExecute(true, false, true);
				};
				object[] array = new object[5];
				int num2 = 0;
				float? num3;
				if (fadeInScreen == null)
				{
					num3 = null;
				}
				else
				{
					IEaseData ease = fadeInScreen.Ease;
					num3 = ((ease != null) ? new float?(ease.Duration) : null);
				}
				array[num2] = num3;
				array[1] = fadeInScreen.ScreenType;
				array[2] = true;
				array[3] = true;
				array[4] = num;
				instance3.OpenLoading<ELoadingPerform>(reason, perform, context2, callback, array);
				return;
			}
			EventSystem.Instance.Emit<bool, Action>(EEventName.PlotViewBgFadeBlackScreen, true, new Action(this.OnFadeComplete));
		}

		// Token: 0x0603A25B RID: 238171 RVA: 0x01065EB8 File Offset: 0x010640B8
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0603A25C RID: 238172 RVA: 0x01065EC3 File Offset: 0x010640C3
		private void OnFadeComplete()
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0603A25D RID: 238173 RVA: 0x01065ED0 File Offset: 0x010640D0
		protected override void OnUpdateGuarantee()
		{
			if (!this.KeepFadeAfterTreeEnd)
			{
				GuaranteeActionInfo p = new GuaranteeActionInfo
				{
					Name = EGuaranteeAction.ActionBlackScreenFadeOut
				};
				EventSystem.Instance.Emit<string, GeneralContext, GuaranteeActionInfo, bool?>(EEventName.AddGuaranteeAction, this.Type, this.BaseContext, p, null);
				return;
			}
			GuaranteeActionInfo p2 = new GuaranteeActionInfo
			{
				Name = EGuaranteeAction.ActionBlackScreenFadeOut
			};
			EventSystem.Instance.Emit<string, GeneralContext, GuaranteeActionInfo, bool?>(EEventName.RemGuaranteeAction, this.Type, this.BaseContext, p2, null);
		}

		// Token: 0x0603A25E RID: 238174 RVA: 0x01065F4C File Offset: 0x0106414C
		protected override void OnReset()
		{
			this.KeepFadeAfterTreeEnd = false;
		}

		// Token: 0x0401EB9D RID: 125853
		private bool KeepFadeAfterTreeEnd;
	}
}
