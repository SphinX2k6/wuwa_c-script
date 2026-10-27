using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.Plot;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006F88 RID: 28552
	public class LevelFlowFadeInScreen : LevelFlowActionBase
	{
		// Token: 0x06045705 RID: 284421 RVA: 0x01138025 File Offset: 0x01136225
		[NullableContext(1)]
		public LevelFlowFadeInScreen Init(FadeInScreen inParams)
		{
			this.InParams = inParams;
			return this;
		}

		// Token: 0x06045706 RID: 284422 RVA: 0x01138030 File Offset: 0x01136230
		protected override void OnExecute()
		{
			if (this.InParams == null)
			{
				return;
			}
			PlotModel.Instance.IsFadeIn = true;
			CameraModel instance = CameraModel.Instance;
			if (instance != null)
			{
				FightCamera fightCamera = instance.MainModel.FightCamera;
				if (fightCamera != null)
				{
					FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
					if (logicComponent != null)
					{
						logicComponent.ExitCameraHook(false);
					}
				}
			}
			if (this.InParams.FadeBackground != null)
			{
				PlotModel.Instance.BlackScreenType = new EBlackScreenType?(EBlackScreenType.Ui);
				FadeBackgroundController.Instance.OpenFadeBackground(this.InParams.FadeBackground);
				base.FinishExecute(true);
				return;
			}
			if (PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.LevelC && this.InParams.TypeOverride != null)
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
				EFadeInScreenShowType? screenType = this.InParams.ScreenType;
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
				LevelLoadingController instance2 = LevelLoadingController.Instance;
				ELoadingReason reason = ELoadingReason.Common;
				ELoadingPerform perform = ELoadingPerform.CameraFade;
				string context = "LevelFlowFadeInScreen";
				Action callback = delegate()
				{
					base.FinishExecute(true);
				};
				object[] array = new object[4];
				int num = 0;
				IEaseData ease = this.InParams.Ease;
				array[num] = ((ease != null) ? new float?(ease.Duration) : null);
				array[1] = this.InParams.ScreenType;
				array[2] = true;
				array[3] = true;
				instance2.OpenLoading<ELoadingPerform>(reason, perform, context, callback, array);
				return;
			}
			EventSystem.Instance.Emit<bool, Action>(EEventName.PlotViewBgFadeBlackScreen, true, new Action(this.OnFadeComplete));
		}

		// Token: 0x06045707 RID: 284423 RVA: 0x01138207 File Offset: 0x01136407
		private void OnFadeComplete()
		{
			base.FinishExecute(true);
		}

		// Token: 0x040243BA RID: 148410
		[Nullable(2)]
		private FadeInScreen InParams;
	}
}
