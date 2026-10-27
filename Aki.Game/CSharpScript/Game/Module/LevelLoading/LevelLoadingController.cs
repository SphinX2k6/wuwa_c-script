using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Common;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.LevelGamePlay.Guarantee;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.LevelLoading
{
	// Token: 0x020056C2 RID: 22210
	[NullableContext(2)]
	[Nullable(0)]
	[Controller(0)]
	[TickController(0)]
	public class LevelLoadingController : ControllerBase
	{
		// Token: 0x17008794 RID: 34708
		// (get) Token: 0x060387DA RID: 231386 RVA: 0x00D6B265 File Offset: 0x00D69465
		protected override bool IsTickEvenPausedInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060387DB RID: 231387 RVA: 0x00D6B268 File Offset: 0x00D69468
		protected override bool OnInit()
		{
			this.CameraFade = new CameraFadeLoading();
			this.ProcessList = new List<object>();
			Net.Instance.Register(ENotifyMessageId.ActionOperationScreenNotify, new Action<IMessage, Net.CallbackStatus>(this.OnOperationScreenNotify));
			return true;
		}

		// Token: 0x060387DC RID: 231388 RVA: 0x00D6B29D File Offset: 0x00D6949D
		protected override bool OnClear()
		{
			this.CameraFade = null;
			this.ProcessList = null;
			Net.Instance.UnRegister(ENotifyMessageId.ActionOperationScreenNotify);
			return true;
		}

		// Token: 0x060387DD RID: 231389 RVA: 0x00D6B2C0 File Offset: 0x00D694C0
		protected override void OnTick(float delta)
		{
			if (this.ProcessList == null || this.ProcessList.Count == 0)
			{
				return;
			}
			if (this.CurProcess != null)
			{
				return;
			}
			this.CurProcess = this.ProcessList[0];
			object curProcess = this.CurProcess;
			OpenLoadingProcess<ELoadingPerform> openProcess = curProcess as OpenLoadingProcess<ELoadingPerform>;
			if (openProcess != null)
			{
				this.OpenLoadingImp(openProcess.Reason, openProcess.Perform, openProcess.Context, openProcess.Params).ContinueWith(delegate(bool _)
				{
					Action callback = openProcess.Callback;
					if (callback == null)
					{
						return;
					}
					callback();
				});
				return;
			}
			curProcess = this.CurProcess;
			CloseLoadingProcess closeProcess = curProcess as CloseLoadingProcess;
			if (closeProcess != null)
			{
				this.CloseLoadingImp(closeProcess.Reason, closeProcess.Duration, closeProcess.Context).ContinueWith(delegate()
				{
					Action callback = closeProcess.Callback;
					if (callback == null)
					{
						return;
					}
					callback();
				});
			}
		}

		// Token: 0x060387DE RID: 231390 RVA: 0x00D6B3BE File Offset: 0x00D695BE
		private void FinishCallback()
		{
			this.ProcessList.RemoveAt(0);
			this.CurProcess = null;
		}

		// Token: 0x060387DF RID: 231391 RVA: 0x00D6B3D4 File Offset: 0x00D695D4
		private unsafe void OnOperationScreenNotify(IMessage __msg, Net.CallbackStatus _)
		{
			LevelLoadingController.<>c__DisplayClass12_0 CS$<>8__locals1 = new LevelLoadingController.<>c__DisplayClass12_0();
			ActionOperationScreenNotify actionOperationScreenNotify = (ActionOperationScreenNotify)__msg;
			CS$<>8__locals1.playerId = actionOperationScreenNotify.PlayerId;
			CS$<>8__locals1.incId = actionOperationScreenNotify.IncId;
			CS$<>8__locals1.type = actionOperationScreenNotify.Type;
			string @params = actionOperationScreenNotify.Params;
			GeneralContext generalContext = LevelGeneralContextUtil.CreateByServerContext(actionOperationScreenNotify.GameCtx);
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.BlackScreen;
			ELogAuthor author = ELogAuthor.JYS;
			string message = "[黑幕]ActionOperationScreenNotify 服务端下发黑幕操作";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("playerId:", CS$<>8__locals1.playerId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("incId:", CS$<>8__locals1.incId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("type:", CS$<>8__locals1.type);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("inParam:", @params);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			if (AutoRunModel.Instance.IsInLogicTreeGmMode())
			{
				CS$<>8__locals1.<OnOperationScreenNotify>g__RequestFunc|0();
				return;
			}
			ActionScreenOperationType type = CS$<>8__locals1.type;
			if (type != ActionScreenOperationType.Close)
			{
				if (type != ActionScreenOperationType.Open)
				{
					return;
				}
				FadeInScreen fadeInScreen = Json.Parse<FadeInScreen>(@params, null);
				LoadingModel.Instance.ScreenEffect = new EScreenEffectType?(EScreenEffectType.ScreenEffectBlack);
				PlotModel.Instance.IsFadeIn = true;
				if (fadeInScreen == null)
				{
					global::Log.Instance.Error(ELogModule.BlackScreen, ELogAuthor.JYS, "[黑幕]Params 为空", default(ReadOnlySpan<ValueTuple<string, object>>));
					this.OpenLoading<ELoadingPerform>(ELoadingReason.Common, ELoadingPerform.CameraFade, null, new Action(CS$<>8__locals1.<OnOperationScreenNotify>g__RequestFunc|0), new object[]
					{
						1f,
						EFadeInScreenShowType.Black,
						true,
						true
					});
					return;
				}
				int? num = null;
				bool flag = !(fadeInScreen.KeepFadeAfterTreeEnd ?? false);
				if (flag)
				{
					GeneralLogicTreeContext generalLogicTreeContext = generalContext as GeneralLogicTreeContext;
					if (generalLogicTreeContext != null && generalLogicTreeContext.BtType == BtType.LevelPlay)
					{
						num = new int?(generalLogicTreeContext.TreeConfigId);
						global::Log instance2 = global::Log.Instance;
						ELogModule module2 = ELogModule.BlackScreen;
						ELogAuthor author2 = ELogAuthor.JYS;
						string message2 = "玩法内开启黑幕：";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("treeId", generalLogicTreeContext.TreeConfigId);
						instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
				}
				CameraModel instance3 = CameraModel.Instance;
				if (instance3 != null)
				{
					FightCamera fightCamera = instance3.MainModel.FightCamera;
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
					CS$<>8__locals1.<OnOperationScreenNotify>g__RequestFunc|0();
				}
				else
				{
					if (fadeInScreen.TypeOverride != null)
					{
						EFadeUiOverride? typeOverride = fadeInScreen.TypeOverride;
						EFadeUiOverride efadeUiOverride = EFadeUiOverride.ShowTalkDialog;
						if (!(typeOverride.GetValueOrDefault() == efadeUiOverride & typeOverride != null))
						{
							PlotModel.Instance.BlackScreenType = new EBlackScreenType?(EBlackScreenType.Plot);
							EventSystem.Instance.Emit<bool, Action>(EEventName.PlotViewBgFadeBlackScreen, true, new Action(CS$<>8__locals1.<OnOperationScreenNotify>g__RequestFunc|0));
							goto IL_4C6;
						}
					}
					PlotModel.Instance.BlackScreenType = new EBlackScreenType?(EBlackScreenType.Ui);
					EFadeInScreenShowType? screenType = fadeInScreen.ScreenType;
					if (screenType != null)
					{
						EFadeInScreenShowType valueOrDefault = screenType.GetValueOrDefault();
						if (valueOrDefault == EFadeInScreenShowType.White)
						{
							LoadingModel.Instance.ScreenEffect = new EScreenEffectType?(EScreenEffectType.ScreenEffectWhite);
							goto IL_428;
						}
						if (valueOrDefault != EFadeInScreenShowType.Black)
						{
						}
					}
					LoadingModel.Instance.ScreenEffect = new EScreenEffectType?(EScreenEffectType.ScreenEffectBlack);
					IL_428:
					ELoadingReason reason = ELoadingReason.Common;
					ELoadingPerform perform = ELoadingPerform.CameraFade;
					string context = null;
					Action callback = new Action(CS$<>8__locals1.<OnOperationScreenNotify>g__RequestFunc|0);
					object[] array = new object[5];
					int num2 = 0;
					IEaseData ease = fadeInScreen.Ease;
					array[num2] = ((ease != null) ? new float?(ease.Duration) : null);
					array[1] = fadeInScreen.ScreenType;
					array[2] = true;
					array[3] = true;
					array[4] = num;
					this.OpenLoading<ELoadingPerform>(reason, perform, context, callback, array);
				}
				IL_4C6:
				GuaranteeActionInfo p = new GuaranteeActionInfo
				{
					Name = EGuaranteeAction.ActionBlackScreenFadeOut,
					Params = new GuaranteeFadeInParams
					{
						KeepFadeAfterTreeRollBack = fadeInScreen.KeepFadeAfterTreeRollBack
					}
				};
				flag = !(fadeInScreen.KeepFadeAfterTreeEnd ?? false);
				if (flag || (generalContext != null && generalContext.Type.GetValueOrDefault() == EGeneralContextType.DynamicInteract))
				{
					EventSystem.Instance.Emit<string, GeneralContext, GuaranteeActionInfo, bool?>(EEventName.AddGuaranteeAction, "LevelEventFadeInScreen", generalContext, p, null);
					return;
				}
				EventSystem.Instance.Emit<string, GeneralContext, GuaranteeActionInfo, bool?>(EEventName.RemGuaranteeAction, "LevelEventFadeInScreen", generalContext, p, null);
				return;
			}
			else
			{
				FadeBackgroundController.Instance.CloseFadeBackground();
				FadeOutScreen fadeOutScreen = Json.Parse<FadeOutScreen>(@params, null);
				PlotModel.Instance.IsFadeIn = false;
				if (fadeOutScreen == null)
				{
					global::Log.Instance.Error(ELogModule.BlackScreen, ELogAuthor.JYS, "[黑幕]Params 为空", default(ReadOnlySpan<ValueTuple<string, object>>));
					Global.CharacterCameraManager.FadeAmount = 0f;
					this.CloseLoading(ELoadingReason.Common, null, delegate
					{
						base.<OnOperationScreenNotify>g__RequestFunc|0();
						LoadingModel.Instance.ScreenEffect = new EScreenEffectType?(EScreenEffectType.ScreenEffectNone);
						PlotModel.Instance.LastPlotAspect = -1f;
						PlotModel.Instance.LastPlotColor = -1;
					}, new float?(1f));
					return;
				}
				if (PlotModel.Instance.BlackScreenType.GetValueOrDefault() == EBlackScreenType.Plot)
				{
					EventSystem.Instance.Emit<bool, Action>(EEventName.PlotViewBgFadeBlackScreen, false, new Action(CS$<>8__locals1.<OnOperationScreenNotify>g__RequestFunc|0));
					return;
				}
				Global.CharacterCameraManager.FadeAmount = 0f;
				ELoadingReason reason2 = ELoadingReason.Common;
				string context2 = null;
				Action callback2 = delegate()
				{
					base.<OnOperationScreenNotify>g__RequestFunc|0();
					LoadingModel.Instance.ScreenEffect = new EScreenEffectType?(EScreenEffectType.ScreenEffectNone);
					PlotModel.Instance.LastPlotAspect = -1f;
					PlotModel.Instance.LastPlotColor = -1;
				};
				IEaseData ease2 = fadeOutScreen.Ease;
				this.CloseLoading(reason2, context2, callback2, (ease2 != null) ? new float?(ease2.Duration) : null);
				GuaranteeActionInfo p2 = new GuaranteeActionInfo
				{
					Name = EGuaranteeAction.ActionBlackScreenFadeOut
				};
				EventSystem.Instance.Emit<string, GeneralContext, GuaranteeActionInfo, bool?>(EEventName.RemGuaranteeAction, "LevelEventFadeInScreen", generalContext, p2, null);
				return;
			}
		}

		// Token: 0x060387E0 RID: 231392 RVA: 0x00D6B94C File Offset: 0x00D69B4C
		public void OpenLoading<T>(ELoadingReason reason, [Nullable(1)] T perform, string context = null, Action callback = null, [Nullable(1)] params object[] parameters)
		{
			LevelLoadingController.<>c__DisplayClass13_0<T> CS$<>8__locals1 = new LevelLoadingController.<>c__DisplayClass13_0<T>();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.callback = callback;
			this.ProcessList.Add(new OpenLoadingProcess<T>(reason, perform, new Action(CS$<>8__locals1.<OpenLoading>g__TempCallback|0), context, parameters));
		}

		// Token: 0x060387E1 RID: 231393 RVA: 0x00D6B990 File Offset: 0x00D69B90
		public void CloseLoading(ELoadingReason reason, string context = null, Action callback = null, float? duration = null)
		{
			LevelLoadingController.<>c__DisplayClass14_0 CS$<>8__locals1 = new LevelLoadingController.<>c__DisplayClass14_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.callback = callback;
			this.ProcessList.Add(new CloseLoadingProcess(reason, new Action(CS$<>8__locals1.<CloseLoading>g__TempCallback|0), duration, context));
		}

		// Token: 0x060387E2 RID: 231394 RVA: 0x00D6B9D4 File Offset: 0x00D69BD4
		[NullableContext(1)]
		public void OpenUiTransitionBlackScreen(string context, float keepTime = 1500f, float fadeInTime = 0.5f)
		{
			this.OpenLoading<ELoadingPerform>(ELoadingReason.UiTransition, ELoadingPerform.CameraFade, context, null, new object[]
			{
				fadeInTime
			});
			TimerSystem.RealTimeInstance.Delay(delegate(float delta)
			{
				this.CloseLoading(ELoadingReason.UiTransition, context, null, new float?(0f));
			}, keepTime, null, context, true, 1f);
		}

		// Token: 0x060387E3 RID: 231395 RVA: 0x00D6BA3C File Offset: 0x00D69C3C
		[NullableContext(1)]
		public UniTask WaitOpenLoading<[Nullable(2)] T>(ELoadingReason reason, T perform, [Nullable(2)] string context = null, params object[] parameters)
		{
			LevelLoadingController.<WaitOpenLoading>d__16<T> <WaitOpenLoading>d__;
			<WaitOpenLoading>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitOpenLoading>d__.<>4__this = this;
			<WaitOpenLoading>d__.reason = reason;
			<WaitOpenLoading>d__.perform = perform;
			<WaitOpenLoading>d__.context = context;
			<WaitOpenLoading>d__.parameters = parameters;
			<WaitOpenLoading>d__.<>1__state = -1;
			<WaitOpenLoading>d__.<>t__builder.Start<LevelLoadingController.<WaitOpenLoading>d__16<T>>(ref <WaitOpenLoading>d__);
			return <WaitOpenLoading>d__.<>t__builder.Task;
		}

		// Token: 0x060387E4 RID: 231396 RVA: 0x00D6BAA0 File Offset: 0x00D69CA0
		public UniTask WaitCloseLoading(ELoadingReason reason, string context = null, float? duration = null)
		{
			LevelLoadingController.<WaitCloseLoading>d__17 <WaitCloseLoading>d__;
			<WaitCloseLoading>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitCloseLoading>d__.<>4__this = this;
			<WaitCloseLoading>d__.reason = reason;
			<WaitCloseLoading>d__.context = context;
			<WaitCloseLoading>d__.duration = duration;
			<WaitCloseLoading>d__.<>1__state = -1;
			<WaitCloseLoading>d__.<>t__builder.Start<LevelLoadingController.<WaitCloseLoading>d__17>(ref <WaitCloseLoading>d__);
			return <WaitCloseLoading>d__.<>t__builder.Task;
		}

		// Token: 0x060387E5 RID: 231397 RVA: 0x00D6BAFC File Offset: 0x00D69CFC
		[NullableContext(0)]
		private UniTask<bool> OpenLoadingImp(ELoadingReason reason, ELoadingPerform perform, [Nullable(2)] string context, [Nullable(1)] params object[] parameters)
		{
			LevelLoadingController.<OpenLoadingImp>d__18 <OpenLoadingImp>d__;
			<OpenLoadingImp>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenLoadingImp>d__.<>4__this = this;
			<OpenLoadingImp>d__.reason = reason;
			<OpenLoadingImp>d__.perform = perform;
			<OpenLoadingImp>d__.context = context;
			<OpenLoadingImp>d__.parameters = parameters;
			<OpenLoadingImp>d__.<>1__state = -1;
			<OpenLoadingImp>d__.<>t__builder.Start<LevelLoadingController.<OpenLoadingImp>d__18>(ref <OpenLoadingImp>d__);
			return <OpenLoadingImp>d__.<>t__builder.Task;
		}

		// Token: 0x060387E6 RID: 231398 RVA: 0x00D6BB60 File Offset: 0x00D69D60
		private UniTask PrePerformLoadingMode()
		{
			LevelLoadingController.<PrePerformLoadingMode>d__19 <PrePerformLoadingMode>d__;
			<PrePerformLoadingMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PrePerformLoadingMode>d__.<>1__state = -1;
			<PrePerformLoadingMode>d__.<>t__builder.Start<LevelLoadingController.<PrePerformLoadingMode>d__19>(ref <PrePerformLoadingMode>d__);
			return <PrePerformLoadingMode>d__.<>t__builder.Task;
		}

		// Token: 0x060387E7 RID: 231399 RVA: 0x00D6BB9C File Offset: 0x00D69D9C
		private UniTask PrePerformFadeLoadingMode()
		{
			LevelLoadingController.<PrePerformFadeLoadingMode>d__20 <PrePerformFadeLoadingMode>d__;
			<PrePerformFadeLoadingMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PrePerformFadeLoadingMode>d__.<>1__state = -1;
			<PrePerformFadeLoadingMode>d__.<>t__builder.Start<LevelLoadingController.<PrePerformFadeLoadingMode>d__20>(ref <PrePerformFadeLoadingMode>d__);
			return <PrePerformFadeLoadingMode>d__.<>t__builder.Task;
		}

		// Token: 0x060387E8 RID: 231400 RVA: 0x00D6BBD8 File Offset: 0x00D69DD8
		private UniTask PrePerformCameraFadeMode(float? duration, EFadeInScreenShowType screenType, bool needBackToFight, bool? needCheckOpenView, int? treeId, bool stillNeedChangeColor)
		{
			LevelLoadingController.<PrePerformCameraFadeMode>d__21 <PrePerformCameraFadeMode>d__;
			<PrePerformCameraFadeMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PrePerformCameraFadeMode>d__.<>4__this = this;
			<PrePerformCameraFadeMode>d__.duration = duration;
			<PrePerformCameraFadeMode>d__.screenType = screenType;
			<PrePerformCameraFadeMode>d__.needBackToFight = needBackToFight;
			<PrePerformCameraFadeMode>d__.needCheckOpenView = needCheckOpenView;
			<PrePerformCameraFadeMode>d__.treeId = treeId;
			<PrePerformCameraFadeMode>d__.<>1__state = -1;
			<PrePerformCameraFadeMode>d__.<>t__builder.Start<LevelLoadingController.<PrePerformCameraFadeMode>d__21>(ref <PrePerformCameraFadeMode>d__);
			return <PrePerformCameraFadeMode>d__.<>t__builder.Task;
		}

		// Token: 0x060387E9 RID: 231401 RVA: 0x00D6BC48 File Offset: 0x00D69E48
		private UniTask PrePerformVideoCenterLoadingMode(string textKey)
		{
			LevelLoadingController.<PrePerformVideoCenterLoadingMode>d__22 <PrePerformVideoCenterLoadingMode>d__;
			<PrePerformVideoCenterLoadingMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PrePerformVideoCenterLoadingMode>d__.textKey = textKey;
			<PrePerformVideoCenterLoadingMode>d__.<>1__state = -1;
			<PrePerformVideoCenterLoadingMode>d__.<>t__builder.Start<LevelLoadingController.<PrePerformVideoCenterLoadingMode>d__22>(ref <PrePerformVideoCenterLoadingMode>d__);
			return <PrePerformVideoCenterLoadingMode>d__.<>t__builder.Task;
		}

		// Token: 0x060387EA RID: 231402 RVA: 0x00D6BC8C File Offset: 0x00D69E8C
		[NullableContext(1)]
		private UniTask PrePerformCgMode(string movieName, Action callback, bool inPlot = false)
		{
			LevelLoadingController.<PrePerformCgMode>d__23 <PrePerformCgMode>d__;
			<PrePerformCgMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PrePerformCgMode>d__.movieName = movieName;
			<PrePerformCgMode>d__.callback = callback;
			<PrePerformCgMode>d__.inPlot = inPlot;
			<PrePerformCgMode>d__.<>1__state = -1;
			<PrePerformCgMode>d__.<>t__builder.Start<LevelLoadingController.<PrePerformCgMode>d__23>(ref <PrePerformCgMode>d__);
			return <PrePerformCgMode>d__.<>t__builder.Task;
		}

		// Token: 0x060387EB RID: 231403 RVA: 0x00D6BCE0 File Offset: 0x00D69EE0
		[NullableContext(1)]
		private UniTask PrePerformSpecialTransitionMode(ISpecialTransitionParams parameters)
		{
			LevelLoadingController.<PrePerformSpecialTransitionMode>d__24 <PrePerformSpecialTransitionMode>d__;
			<PrePerformSpecialTransitionMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PrePerformSpecialTransitionMode>d__.parameters = parameters;
			<PrePerformSpecialTransitionMode>d__.<>1__state = -1;
			<PrePerformSpecialTransitionMode>d__.<>t__builder.Start<LevelLoadingController.<PrePerformSpecialTransitionMode>d__24>(ref <PrePerformSpecialTransitionMode>d__);
			return <PrePerformSpecialTransitionMode>d__.<>t__builder.Task;
		}

		// Token: 0x060387EC RID: 231404 RVA: 0x00D6BD24 File Offset: 0x00D69F24
		public bool CheckIsOpen(ELoadingPerform? perform)
		{
			bool result = false;
			if (perform != null)
			{
				switch (perform.GetValueOrDefault())
				{
				case ELoadingPerform.VideoCenter:
					result = UiManager.Instance.IsViewOpen(EUiViewName.PlotTransitionView);
					break;
				case ELoadingPerform.Loading:
					result = LoadingModel.Instance.IsLoadingView;
					break;
				case ELoadingPerform.FadeLoading:
					result = UiManager.Instance.IsViewOpen(EUiViewName.FadeLoadingView);
					break;
				case ELoadingPerform.CameraFade:
					result = this.CameraFade.IsInFade();
					break;
				case ELoadingPerform.CG:
					result = UiManager.Instance.IsViewOpen(EUiViewName.VideoView);
					break;
				case ELoadingPerform.SpecialTransition:
					result = UiManager.Instance.IsViewOpen(EUiViewName.SpecialTransitionView);
					break;
				}
			}
			return result;
		}

		// Token: 0x060387ED RID: 231405 RVA: 0x00D6BDD0 File Offset: 0x00D69FD0
		private UniTask CloseLoadingImp(ELoadingReason reason, float duration, string context = null)
		{
			LevelLoadingController.<CloseLoadingImp>d__26 <CloseLoadingImp>d__;
			<CloseLoadingImp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseLoadingImp>d__.<>4__this = this;
			<CloseLoadingImp>d__.reason = reason;
			<CloseLoadingImp>d__.duration = duration;
			<CloseLoadingImp>d__.context = context;
			<CloseLoadingImp>d__.<>1__state = -1;
			<CloseLoadingImp>d__.<>t__builder.Start<LevelLoadingController.<CloseLoadingImp>d__26>(ref <CloseLoadingImp>d__);
			return <CloseLoadingImp>d__.<>t__builder.Task;
		}

		// Token: 0x060387EE RID: 231406 RVA: 0x00D6BE2C File Offset: 0x00D6A02C
		private UniTask CloseViewInternal(ELoadingPerform? perform, float duration, string context = null)
		{
			LevelLoadingController.<CloseViewInternal>d__27 <CloseViewInternal>d__;
			<CloseViewInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseViewInternal>d__.<>4__this = this;
			<CloseViewInternal>d__.perform = perform;
			<CloseViewInternal>d__.duration = duration;
			<CloseViewInternal>d__.context = context;
			<CloseViewInternal>d__.<>1__state = -1;
			<CloseViewInternal>d__.<>t__builder.Start<LevelLoadingController.<CloseViewInternal>d__27>(ref <CloseViewInternal>d__);
			return <CloseViewInternal>d__.<>t__builder.Task;
		}

		// Token: 0x060387EF RID: 231407 RVA: 0x00D6BE88 File Offset: 0x00D6A088
		private UniTask PostPerformLoadingMode()
		{
			LevelLoadingController.<PostPerformLoadingMode>d__28 <PostPerformLoadingMode>d__;
			<PostPerformLoadingMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PostPerformLoadingMode>d__.<>1__state = -1;
			<PostPerformLoadingMode>d__.<>t__builder.Start<LevelLoadingController.<PostPerformLoadingMode>d__28>(ref <PostPerformLoadingMode>d__);
			return <PostPerformLoadingMode>d__.<>t__builder.Task;
		}

		// Token: 0x060387F0 RID: 231408 RVA: 0x00D6BEC4 File Offset: 0x00D6A0C4
		private UniTask PostPerformFadeLoadingMode()
		{
			LevelLoadingController.<PostPerformFadeLoadingMode>d__29 <PostPerformFadeLoadingMode>d__;
			<PostPerformFadeLoadingMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PostPerformFadeLoadingMode>d__.<>1__state = -1;
			<PostPerformFadeLoadingMode>d__.<>t__builder.Start<LevelLoadingController.<PostPerformFadeLoadingMode>d__29>(ref <PostPerformFadeLoadingMode>d__);
			return <PostPerformFadeLoadingMode>d__.<>t__builder.Task;
		}

		// Token: 0x060387F1 RID: 231409 RVA: 0x00D6BF00 File Offset: 0x00D6A100
		private UniTask PostPerformCameraFadeMode(float duration)
		{
			LevelLoadingController.<PostPerformCameraFadeMode>d__30 <PostPerformCameraFadeMode>d__;
			<PostPerformCameraFadeMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PostPerformCameraFadeMode>d__.<>4__this = this;
			<PostPerformCameraFadeMode>d__.duration = duration;
			<PostPerformCameraFadeMode>d__.<>1__state = -1;
			<PostPerformCameraFadeMode>d__.<>t__builder.Start<LevelLoadingController.<PostPerformCameraFadeMode>d__30>(ref <PostPerformCameraFadeMode>d__);
			return <PostPerformCameraFadeMode>d__.<>t__builder.Task;
		}

		// Token: 0x060387F2 RID: 231410 RVA: 0x00D6BF4C File Offset: 0x00D6A14C
		private UniTask PostPerformVideoCenterLoadingMode()
		{
			LevelLoadingController.<PostPerformVideoCenterLoadingMode>d__31 <PostPerformVideoCenterLoadingMode>d__;
			<PostPerformVideoCenterLoadingMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PostPerformVideoCenterLoadingMode>d__.<>1__state = -1;
			<PostPerformVideoCenterLoadingMode>d__.<>t__builder.Start<LevelLoadingController.<PostPerformVideoCenterLoadingMode>d__31>(ref <PostPerformVideoCenterLoadingMode>d__);
			return <PostPerformVideoCenterLoadingMode>d__.<>t__builder.Task;
		}

		// Token: 0x060387F3 RID: 231411 RVA: 0x00D6BF88 File Offset: 0x00D6A188
		private UniTask PostPerformSpecialTransitionMode()
		{
			LevelLoadingController.<PostPerformSpecialTransitionMode>d__32 <PostPerformSpecialTransitionMode>d__;
			<PostPerformSpecialTransitionMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PostPerformSpecialTransitionMode>d__.<>1__state = -1;
			<PostPerformSpecialTransitionMode>d__.<>t__builder.Start<LevelLoadingController.<PostPerformSpecialTransitionMode>d__32>(ref <PostPerformSpecialTransitionMode>d__);
			return <PostPerformSpecialTransitionMode>d__.<>t__builder.Task;
		}

		// Token: 0x060387F4 RID: 231412 RVA: 0x00D6BFC4 File Offset: 0x00D6A1C4
		public void CloseAllBlackScreenLoading()
		{
			FadeBackgroundController.Instance.CloseFadeBackground();
			this.CloseLoading(ELoadingReason.Common, null, null, null);
			this.CloseLoading(ELoadingReason.BehaviorTreeRollback, null, null, null);
			this.CloseLoading(ELoadingReason.SimpleLevelSequence, null, null, null);
			LevelLoadingModel.Instance.FinishCameraShowPromise();
		}

		// Token: 0x060387F5 RID: 231413 RVA: 0x00D6C01C File Offset: 0x00D6A21C
		private unsafe void PushBlackScreenStateAndReasonToServer(bool isOpen, string reason)
		{
			if (string.IsNullOrEmpty(reason))
			{
				return;
			}
			BlackScreenStatePush blackScreenStatePush = BlackScreenStatePush.Create();
			blackScreenStatePush.IsOpen = isOpen;
			blackScreenStatePush.Source = BlackScreenSourceType.ClientAuto;
			blackScreenStatePush.BlackScreenReason = reason;
			Net.Instance.Send(EPushMessageId.BlackScreenStatePush, blackScreenStatePush);
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.BlackScreen;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "推送客户端黑幕状态";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("isOpen", isOpen);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("reason", reason);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x17008795 RID: 34709
		// (get) Token: 0x060387F6 RID: 231414 RVA: 0x00D6C0B8 File Offset: 0x00D6A2B8
		[Nullable(1)]
		public static LevelLoadingController Instance
		{
			[NullableContext(1)]
			get
			{
				return LevelLoadingController._Instance;
			}
		}

		// Token: 0x060387F7 RID: 231415 RVA: 0x00D6C0BF File Offset: 0x00D6A2BF
		[NullableContext(1)]
		public static LevelLoadingController GetOrCreateInstance()
		{
			if (LevelLoadingController._Instance == null)
			{
				LevelLoadingController.CreateInstance();
			}
			return LevelLoadingController._Instance;
		}

		// Token: 0x060387F8 RID: 231416 RVA: 0x00D6C0D3 File Offset: 0x00D6A2D3
		public static bool CreateInstance()
		{
			if (LevelLoadingController._Instance != null)
			{
				return true;
			}
			LevelLoadingController._Instance = new LevelLoadingController();
			return true;
		}

		// Token: 0x060387F9 RID: 231417 RVA: 0x00D6C0E9 File Offset: 0x00D6A2E9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060387FA RID: 231418 RVA: 0x00D6C0EB File Offset: 0x00D6A2EB
		public static void ResetStaticDefaultValue()
		{
			LevelLoadingController._Instance = null;
		}

		// Token: 0x060387FB RID: 231419 RVA: 0x00D6C0F3 File Offset: 0x00D6A2F3
		static LevelLoadingController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelLoadingController.CreateStaticDefaultValue), new Action(LevelLoadingController.ResetStaticDefaultValue));
		}

		// Token: 0x0401DAB9 RID: 121529
		private const float UI_TRANSITION_BLACK_SCREEN_KEEP_TIME = 1500f;

		// Token: 0x0401DABA RID: 121530
		private const float UI_TRANSITION_BLACK_SCREEN_FADE_IN_TIME = 0.5f;

		// Token: 0x0401DABB RID: 121531
		public CameraFadeLoading CameraFade;

		// Token: 0x0401DABC RID: 121532
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<object> ProcessList;

		// Token: 0x0401DABD RID: 121533
		private object CurProcess;

		// Token: 0x0401DABE RID: 121534
		private bool IsLockUiTimeDilation;

		// Token: 0x0401DABF RID: 121535
		private static LevelLoadingController _Instance;
	}
}
