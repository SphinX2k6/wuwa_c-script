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
	// Token: 0x02004699 RID: 18073
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	[TickController(0)]
	public class LevelLoadingController : ControllerBase
	{
		// Token: 0x17005B5C RID: 23388
		// (get) Token: 0x0602D6E1 RID: 186081 RVA: 0x00CB93AD File Offset: 0x00CB75AD
		protected override bool IsTickEvenPausedInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0602D6E2 RID: 186082 RVA: 0x00CB93B0 File Offset: 0x00CB75B0
		protected override bool OnInit()
		{
			this.CameraFade = new CameraFadeLoading();
			this.ProcessList = new List<object>();
			Net.Instance.Register(ENotifyMessageId.ActionOperationScreenNotify, new Action<IMessage, Net.CallbackStatus>(this.OnOperationScreenNotify));
			return true;
		}

		// Token: 0x0602D6E3 RID: 186083 RVA: 0x00CB93E5 File Offset: 0x00CB75E5
		protected override bool OnClear()
		{
			this.ResetMute("ControllerClear");
			this.CameraFade = null;
			this.ProcessList = null;
			Net.Instance.UnRegister(ENotifyMessageId.ActionOperationScreenNotify);
			return true;
		}

		// Token: 0x0602D6E4 RID: 186084 RVA: 0x00CB9414 File Offset: 0x00CB7614
		private unsafe bool GetMuteRequest(ELoadingReason reason, object[] parameters)
		{
			if (parameters.Length <= 6 || parameters[6] == null)
			{
				return false;
			}
			object obj = parameters[6];
			if (obj is bool)
			{
				return (bool)obj;
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Loading;
			ELogAuthor author = ELogAuthor.YZH;
			string message = "LevelLoading:CameraFade静音参数类型错误";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("parameter", parameters[6]);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}

		// Token: 0x0602D6E5 RID: 186085 RVA: 0x00CB949D File Offset: 0x00CB769D
		private void AddMuteRequest(ELoadingReason reason, bool requestMute, bool startNewCycle)
		{
			this.MuteRequests[reason] = requestMute;
			if (startNewCycle)
			{
				this.IsFadeActive = true;
			}
			if (requestMute)
			{
				this.MuteLatched = true;
				this.SetMusicMute(true);
			}
		}

		// Token: 0x0602D6E6 RID: 186086 RVA: 0x00CB94C8 File Offset: 0x00CB76C8
		private unsafe void CheckRepeatedMuteRequest(ELoadingReason reason, bool requestMute)
		{
			bool flag;
			if (!this.MuteRequests.TryGetValue(reason, out flag))
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Loading;
				ELogAuthor author = ELogAuthor.YZH;
				string message = "LevelLoading:重复CameraFade缺少静音请求记录";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("reason", reason);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("requestMute", requestMute);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			if (flag != requestMute)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.Loading;
				ELogAuthor author2 = ELogAuthor.YZH;
				string message2 = "LevelLoading:重复CameraFade静音参数不一致，保持首次配置";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("reason", reason);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("originalRequest", flag);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("requestMute", requestMute);
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			}
		}

		// Token: 0x0602D6E7 RID: 186087 RVA: 0x00CB95BF File Offset: 0x00CB77BF
		private void FinishFadeMute()
		{
			this.IsFadeActive = false;
			this.TryUnmute();
		}

		// Token: 0x0602D6E8 RID: 186088 RVA: 0x00CB95CE File Offset: 0x00CB77CE
		private void TryUnmute()
		{
			if (this.IsFadeActive || this.HasHandoff)
			{
				return;
			}
			if (this.MuteLatched)
			{
				this.MuteLatched = false;
				this.SetMusicMute(false);
			}
		}

		// Token: 0x0602D6E9 RID: 186089 RVA: 0x00CB95F8 File Offset: 0x00CB77F8
		private unsafe void SetMusicMute(bool muted)
		{
			if (this.MusicMuted == muted)
			{
				return;
			}
			this.MusicMuted = muted;
			AudioSystem.Instance.SetState("mute_scene_music", muted ? "mute" : "none", true);
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Loading;
			ELogAuthor author = ELogAuthor.YZH;
			string message = "LevelLoading:更新场景音乐静音State";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("muted", muted);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("cameraFadeActive", this.IsFadeActive);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("leaveSceneHandoff", this.HasHandoff);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}

		// Token: 0x0602D6EA RID: 186090 RVA: 0x00CB96B8 File Offset: 0x00CB78B8
		private unsafe void ResetMute(string reason)
		{
			if (this.IsFadeActive || this.HasHandoff || this.MuteLatched)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Loading;
				ELogAuthor author = ELogAuthor.YZH;
				string message = "LevelLoading:清理时存在CameraFade场景音乐静音状态";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("reason", reason);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("requestCount", this.MuteRequests.Count);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("cameraFadeActive", this.IsFadeActive);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("leaveSceneHandoff", this.HasHandoff);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("muteLatched", this.MuteLatched);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			}
			this.MuteRequests.Clear();
			this.IsFadeActive = false;
			this.HasHandoff = false;
			this.MuteLatched = false;
			this.SetMusicMute(false);
		}

		// Token: 0x0602D6EB RID: 186091 RVA: 0x00CB97D0 File Offset: 0x00CB79D0
		public void HoldMuteForLeaveScene()
		{
			if (!this.MuteLatched)
			{
				return;
			}
			if (this.HasHandoff)
			{
				global::Log.Instance.Warn(ELogModule.Loading, ELogAuthor.YZH, "LevelLoading:重复登记LeaveScene静音接管", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.HasHandoff = true;
			global::Log.Instance.Info(ELogModule.Loading, ELogAuthor.YZH, "LevelLoading:登记LeaveScene静音接管", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0602D6EC RID: 186092 RVA: 0x00CB982C File Offset: 0x00CB7A2C
		public void ReleaseMuteForLeaveScene()
		{
			if (!this.HasHandoff)
			{
				return;
			}
			this.HasHandoff = false;
			global::Log.Instance.Info(ELogModule.Loading, ELogAuthor.YZH, "LevelLoading:释放LeaveScene静音接管", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.TryUnmute();
		}

		// Token: 0x0602D6ED RID: 186093 RVA: 0x00CB986C File Offset: 0x00CB7A6C
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

		// Token: 0x0602D6EE RID: 186094 RVA: 0x00CB996A File Offset: 0x00CB7B6A
		private void FinishCallback()
		{
			this.ProcessList.RemoveAt(0);
			this.CurProcess = null;
		}

		// Token: 0x0602D6EF RID: 186095 RVA: 0x00CB9980 File Offset: 0x00CB7B80
		[NullableContext(2)]
		private unsafe void OnOperationScreenNotify(IMessage __msg, Net.CallbackStatus _)
		{
			LevelLoadingController.<>c__DisplayClass30_0 CS$<>8__locals1 = new LevelLoadingController.<>c__DisplayClass30_0();
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

		// Token: 0x0602D6F0 RID: 186096 RVA: 0x00CB9EF8 File Offset: 0x00CB80F8
		[NullableContext(2)]
		public void OpenLoading<T>(ELoadingReason reason, [Nullable(1)] T perform, string context = null, Action callback = null, [Nullable(1)] params object[] parameters)
		{
			LevelLoadingController.<>c__DisplayClass31_0<T> CS$<>8__locals1 = new LevelLoadingController.<>c__DisplayClass31_0<T>();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.callback = callback;
			this.ProcessList.Add(new OpenLoadingProcess<T>(reason, perform, new Action(CS$<>8__locals1.<OpenLoading>g__TempCallback|0), context, parameters));
		}

		// Token: 0x0602D6F1 RID: 186097 RVA: 0x00CB9F3C File Offset: 0x00CB813C
		[NullableContext(2)]
		public void CloseLoading(ELoadingReason reason, string context = null, Action callback = null, float? duration = null)
		{
			LevelLoadingController.<>c__DisplayClass32_0 CS$<>8__locals1 = new LevelLoadingController.<>c__DisplayClass32_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.callback = callback;
			this.ProcessList.Add(new CloseLoadingProcess(reason, new Action(CS$<>8__locals1.<CloseLoading>g__TempCallback|0), duration, context));
		}

		// Token: 0x0602D6F2 RID: 186098 RVA: 0x00CB9F80 File Offset: 0x00CB8180
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

		// Token: 0x0602D6F3 RID: 186099 RVA: 0x00CB9FE8 File Offset: 0x00CB81E8
		public UniTask WaitOpenLoading<[Nullable(2)] T>(ELoadingReason reason, T perform, [Nullable(2)] string context = null, params object[] parameters)
		{
			LevelLoadingController.<WaitOpenLoading>d__34<T> <WaitOpenLoading>d__;
			<WaitOpenLoading>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitOpenLoading>d__.<>4__this = this;
			<WaitOpenLoading>d__.reason = reason;
			<WaitOpenLoading>d__.perform = perform;
			<WaitOpenLoading>d__.context = context;
			<WaitOpenLoading>d__.parameters = parameters;
			<WaitOpenLoading>d__.<>1__state = -1;
			<WaitOpenLoading>d__.<>t__builder.Start<LevelLoadingController.<WaitOpenLoading>d__34<T>>(ref <WaitOpenLoading>d__);
			return <WaitOpenLoading>d__.<>t__builder.Task;
		}

		// Token: 0x0602D6F4 RID: 186100 RVA: 0x00CBA04C File Offset: 0x00CB824C
		[NullableContext(2)]
		public UniTask WaitCloseLoading(ELoadingReason reason, string context = null, float? duration = null)
		{
			LevelLoadingController.<WaitCloseLoading>d__35 <WaitCloseLoading>d__;
			<WaitCloseLoading>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitCloseLoading>d__.<>4__this = this;
			<WaitCloseLoading>d__.reason = reason;
			<WaitCloseLoading>d__.context = context;
			<WaitCloseLoading>d__.duration = duration;
			<WaitCloseLoading>d__.<>1__state = -1;
			<WaitCloseLoading>d__.<>t__builder.Start<LevelLoadingController.<WaitCloseLoading>d__35>(ref <WaitCloseLoading>d__);
			return <WaitCloseLoading>d__.<>t__builder.Task;
		}

		// Token: 0x0602D6F5 RID: 186101 RVA: 0x00CBA0A8 File Offset: 0x00CB82A8
		[NullableContext(0)]
		private UniTask<bool> OpenLoadingImp(ELoadingReason reason, ELoadingPerform perform, [Nullable(2)] string context, [Nullable(1)] params object[] parameters)
		{
			LevelLoadingController.<OpenLoadingImp>d__36 <OpenLoadingImp>d__;
			<OpenLoadingImp>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenLoadingImp>d__.<>4__this = this;
			<OpenLoadingImp>d__.reason = reason;
			<OpenLoadingImp>d__.perform = perform;
			<OpenLoadingImp>d__.context = context;
			<OpenLoadingImp>d__.parameters = parameters;
			<OpenLoadingImp>d__.<>1__state = -1;
			<OpenLoadingImp>d__.<>t__builder.Start<LevelLoadingController.<OpenLoadingImp>d__36>(ref <OpenLoadingImp>d__);
			return <OpenLoadingImp>d__.<>t__builder.Task;
		}

		// Token: 0x0602D6F6 RID: 186102 RVA: 0x00CBA10C File Offset: 0x00CB830C
		private UniTask PrePerformLoadingMode()
		{
			LevelLoadingController.<PrePerformLoadingMode>d__37 <PrePerformLoadingMode>d__;
			<PrePerformLoadingMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PrePerformLoadingMode>d__.<>1__state = -1;
			<PrePerformLoadingMode>d__.<>t__builder.Start<LevelLoadingController.<PrePerformLoadingMode>d__37>(ref <PrePerformLoadingMode>d__);
			return <PrePerformLoadingMode>d__.<>t__builder.Task;
		}

		// Token: 0x0602D6F7 RID: 186103 RVA: 0x00CBA148 File Offset: 0x00CB8348
		private UniTask PrePerformFadeLoadingMode()
		{
			LevelLoadingController.<PrePerformFadeLoadingMode>d__38 <PrePerformFadeLoadingMode>d__;
			<PrePerformFadeLoadingMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PrePerformFadeLoadingMode>d__.<>1__state = -1;
			<PrePerformFadeLoadingMode>d__.<>t__builder.Start<LevelLoadingController.<PrePerformFadeLoadingMode>d__38>(ref <PrePerformFadeLoadingMode>d__);
			return <PrePerformFadeLoadingMode>d__.<>t__builder.Task;
		}

		// Token: 0x0602D6F8 RID: 186104 RVA: 0x00CBA184 File Offset: 0x00CB8384
		private UniTask PrePerformCameraFadeMode(float? duration, EFadeInScreenShowType screenType, bool needBackToFight, bool? needCheckOpenView, int? treeId, bool stillNeedChangeColor)
		{
			LevelLoadingController.<PrePerformCameraFadeMode>d__39 <PrePerformCameraFadeMode>d__;
			<PrePerformCameraFadeMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PrePerformCameraFadeMode>d__.<>4__this = this;
			<PrePerformCameraFadeMode>d__.duration = duration;
			<PrePerformCameraFadeMode>d__.screenType = screenType;
			<PrePerformCameraFadeMode>d__.needBackToFight = needBackToFight;
			<PrePerformCameraFadeMode>d__.needCheckOpenView = needCheckOpenView;
			<PrePerformCameraFadeMode>d__.treeId = treeId;
			<PrePerformCameraFadeMode>d__.<>1__state = -1;
			<PrePerformCameraFadeMode>d__.<>t__builder.Start<LevelLoadingController.<PrePerformCameraFadeMode>d__39>(ref <PrePerformCameraFadeMode>d__);
			return <PrePerformCameraFadeMode>d__.<>t__builder.Task;
		}

		// Token: 0x0602D6F9 RID: 186105 RVA: 0x00CBA1F4 File Offset: 0x00CB83F4
		[NullableContext(2)]
		private UniTask PrePerformVideoCenterLoadingMode(string textKey)
		{
			LevelLoadingController.<PrePerformVideoCenterLoadingMode>d__40 <PrePerformVideoCenterLoadingMode>d__;
			<PrePerformVideoCenterLoadingMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PrePerformVideoCenterLoadingMode>d__.textKey = textKey;
			<PrePerformVideoCenterLoadingMode>d__.<>1__state = -1;
			<PrePerformVideoCenterLoadingMode>d__.<>t__builder.Start<LevelLoadingController.<PrePerformVideoCenterLoadingMode>d__40>(ref <PrePerformVideoCenterLoadingMode>d__);
			return <PrePerformVideoCenterLoadingMode>d__.<>t__builder.Task;
		}

		// Token: 0x0602D6FA RID: 186106 RVA: 0x00CBA238 File Offset: 0x00CB8438
		private UniTask PrePerformCgMode(string movieName, Action callback, bool inPlot = false)
		{
			LevelLoadingController.<PrePerformCgMode>d__41 <PrePerformCgMode>d__;
			<PrePerformCgMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PrePerformCgMode>d__.movieName = movieName;
			<PrePerformCgMode>d__.callback = callback;
			<PrePerformCgMode>d__.inPlot = inPlot;
			<PrePerformCgMode>d__.<>1__state = -1;
			<PrePerformCgMode>d__.<>t__builder.Start<LevelLoadingController.<PrePerformCgMode>d__41>(ref <PrePerformCgMode>d__);
			return <PrePerformCgMode>d__.<>t__builder.Task;
		}

		// Token: 0x0602D6FB RID: 186107 RVA: 0x00CBA28C File Offset: 0x00CB848C
		private UniTask PrePerformSpecialTransitionMode(ISpecialTransitionParams parameters)
		{
			LevelLoadingController.<PrePerformSpecialTransitionMode>d__42 <PrePerformSpecialTransitionMode>d__;
			<PrePerformSpecialTransitionMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PrePerformSpecialTransitionMode>d__.parameters = parameters;
			<PrePerformSpecialTransitionMode>d__.<>1__state = -1;
			<PrePerformSpecialTransitionMode>d__.<>t__builder.Start<LevelLoadingController.<PrePerformSpecialTransitionMode>d__42>(ref <PrePerformSpecialTransitionMode>d__);
			return <PrePerformSpecialTransitionMode>d__.<>t__builder.Task;
		}

		// Token: 0x0602D6FC RID: 186108 RVA: 0x00CBA2D0 File Offset: 0x00CB84D0
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

		// Token: 0x0602D6FD RID: 186109 RVA: 0x00CBA37C File Offset: 0x00CB857C
		[NullableContext(2)]
		private UniTask CloseLoadingImp(ELoadingReason reason, float duration, string context = null)
		{
			LevelLoadingController.<CloseLoadingImp>d__44 <CloseLoadingImp>d__;
			<CloseLoadingImp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseLoadingImp>d__.<>4__this = this;
			<CloseLoadingImp>d__.reason = reason;
			<CloseLoadingImp>d__.duration = duration;
			<CloseLoadingImp>d__.context = context;
			<CloseLoadingImp>d__.<>1__state = -1;
			<CloseLoadingImp>d__.<>t__builder.Start<LevelLoadingController.<CloseLoadingImp>d__44>(ref <CloseLoadingImp>d__);
			return <CloseLoadingImp>d__.<>t__builder.Task;
		}

		// Token: 0x0602D6FE RID: 186110 RVA: 0x00CBA3D8 File Offset: 0x00CB85D8
		[NullableContext(2)]
		private UniTask CloseViewInternal(ELoadingPerform? perform, float duration, string context = null)
		{
			LevelLoadingController.<CloseViewInternal>d__45 <CloseViewInternal>d__;
			<CloseViewInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseViewInternal>d__.<>4__this = this;
			<CloseViewInternal>d__.perform = perform;
			<CloseViewInternal>d__.duration = duration;
			<CloseViewInternal>d__.context = context;
			<CloseViewInternal>d__.<>1__state = -1;
			<CloseViewInternal>d__.<>t__builder.Start<LevelLoadingController.<CloseViewInternal>d__45>(ref <CloseViewInternal>d__);
			return <CloseViewInternal>d__.<>t__builder.Task;
		}

		// Token: 0x0602D6FF RID: 186111 RVA: 0x00CBA434 File Offset: 0x00CB8634
		private UniTask PostPerformLoadingMode()
		{
			LevelLoadingController.<PostPerformLoadingMode>d__46 <PostPerformLoadingMode>d__;
			<PostPerformLoadingMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PostPerformLoadingMode>d__.<>1__state = -1;
			<PostPerformLoadingMode>d__.<>t__builder.Start<LevelLoadingController.<PostPerformLoadingMode>d__46>(ref <PostPerformLoadingMode>d__);
			return <PostPerformLoadingMode>d__.<>t__builder.Task;
		}

		// Token: 0x0602D700 RID: 186112 RVA: 0x00CBA470 File Offset: 0x00CB8670
		private UniTask PostPerformFadeLoadingMode()
		{
			LevelLoadingController.<PostPerformFadeLoadingMode>d__47 <PostPerformFadeLoadingMode>d__;
			<PostPerformFadeLoadingMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PostPerformFadeLoadingMode>d__.<>1__state = -1;
			<PostPerformFadeLoadingMode>d__.<>t__builder.Start<LevelLoadingController.<PostPerformFadeLoadingMode>d__47>(ref <PostPerformFadeLoadingMode>d__);
			return <PostPerformFadeLoadingMode>d__.<>t__builder.Task;
		}

		// Token: 0x0602D701 RID: 186113 RVA: 0x00CBA4AC File Offset: 0x00CB86AC
		private UniTask PostPerformCameraFadeMode(float duration)
		{
			LevelLoadingController.<PostPerformCameraFadeMode>d__48 <PostPerformCameraFadeMode>d__;
			<PostPerformCameraFadeMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PostPerformCameraFadeMode>d__.<>4__this = this;
			<PostPerformCameraFadeMode>d__.duration = duration;
			<PostPerformCameraFadeMode>d__.<>1__state = -1;
			<PostPerformCameraFadeMode>d__.<>t__builder.Start<LevelLoadingController.<PostPerformCameraFadeMode>d__48>(ref <PostPerformCameraFadeMode>d__);
			return <PostPerformCameraFadeMode>d__.<>t__builder.Task;
		}

		// Token: 0x0602D702 RID: 186114 RVA: 0x00CBA4F8 File Offset: 0x00CB86F8
		private UniTask PostPerformVideoCenterLoadingMode()
		{
			LevelLoadingController.<PostPerformVideoCenterLoadingMode>d__49 <PostPerformVideoCenterLoadingMode>d__;
			<PostPerformVideoCenterLoadingMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PostPerformVideoCenterLoadingMode>d__.<>1__state = -1;
			<PostPerformVideoCenterLoadingMode>d__.<>t__builder.Start<LevelLoadingController.<PostPerformVideoCenterLoadingMode>d__49>(ref <PostPerformVideoCenterLoadingMode>d__);
			return <PostPerformVideoCenterLoadingMode>d__.<>t__builder.Task;
		}

		// Token: 0x0602D703 RID: 186115 RVA: 0x00CBA534 File Offset: 0x00CB8734
		private UniTask PostPerformSpecialTransitionMode()
		{
			LevelLoadingController.<PostPerformSpecialTransitionMode>d__50 <PostPerformSpecialTransitionMode>d__;
			<PostPerformSpecialTransitionMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PostPerformSpecialTransitionMode>d__.<>1__state = -1;
			<PostPerformSpecialTransitionMode>d__.<>t__builder.Start<LevelLoadingController.<PostPerformSpecialTransitionMode>d__50>(ref <PostPerformSpecialTransitionMode>d__);
			return <PostPerformSpecialTransitionMode>d__.<>t__builder.Task;
		}

		// Token: 0x0602D704 RID: 186116 RVA: 0x00CBA570 File Offset: 0x00CB8770
		public void CloseAllBlackScreenLoading()
		{
			FadeBackgroundController.Instance.CloseFadeBackground();
			this.CloseLoading(ELoadingReason.Common, null, null, null);
			this.CloseLoading(ELoadingReason.BehaviorTreeRollback, null, null, null);
			this.CloseLoading(ELoadingReason.SimpleLevelSequence, null, null, null);
			LevelLoadingModel.Instance.FinishCameraShowPromise();
		}

		// Token: 0x0602D705 RID: 186117 RVA: 0x00CBA5C8 File Offset: 0x00CB87C8
		[NullableContext(2)]
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

		// Token: 0x17005B5D RID: 23389
		// (get) Token: 0x0602D706 RID: 186118 RVA: 0x00CBA664 File Offset: 0x00CB8864
		public static LevelLoadingController Instance
		{
			get
			{
				return LevelLoadingController._Instance;
			}
		}

		// Token: 0x0602D707 RID: 186119 RVA: 0x00CBA66B File Offset: 0x00CB886B
		public static LevelLoadingController GetOrCreateInstance()
		{
			if (LevelLoadingController._Instance == null)
			{
				LevelLoadingController.CreateInstance();
			}
			return LevelLoadingController._Instance;
		}

		// Token: 0x0602D708 RID: 186120 RVA: 0x00CBA67F File Offset: 0x00CB887F
		public static bool CreateInstance()
		{
			if (LevelLoadingController._Instance != null)
			{
				return true;
			}
			LevelLoadingController._Instance = new LevelLoadingController();
			return true;
		}

		// Token: 0x0602D709 RID: 186121 RVA: 0x00CBA695 File Offset: 0x00CB8895
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602D70A RID: 186122 RVA: 0x00CBA697 File Offset: 0x00CB8897
		public static void ResetStaticDefaultValue()
		{
			LevelLoadingController._Instance = null;
		}

		// Token: 0x0602D70B RID: 186123 RVA: 0x00CBA69F File Offset: 0x00CB889F
		static LevelLoadingController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelLoadingController.CreateStaticDefaultValue), new Action(LevelLoadingController.ResetStaticDefaultValue));
		}

		// Token: 0x04018546 RID: 99654
		private const float UI_TRANSITION_BLACK_SCREEN_KEEP_TIME = 1500f;

		// Token: 0x04018547 RID: 99655
		private const float UI_TRANSITION_BLACK_SCREEN_FADE_IN_TIME = 0.5f;

		// Token: 0x04018548 RID: 99656
		private const int MUTE_PARAM_INDEX = 6;

		// Token: 0x04018549 RID: 99657
		private const string SCENE_MUSIC_GROUP = "mute_scene_music";

		// Token: 0x0401854A RID: 99658
		private const string MUTE_STATE = "mute";

		// Token: 0x0401854B RID: 99659
		private const string NONE_STATE = "none";

		// Token: 0x0401854C RID: 99660
		[Nullable(2)]
		public CameraFadeLoading CameraFade;

		// Token: 0x0401854D RID: 99661
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<object> ProcessList;

		// Token: 0x0401854E RID: 99662
		[Nullable(2)]
		private object CurProcess;

		// Token: 0x0401854F RID: 99663
		private bool IsLockUiTimeDilation;

		// Token: 0x04018550 RID: 99664
		private readonly Dictionary<ELoadingReason, bool> MuteRequests = new Dictionary<ELoadingReason, bool>();

		// Token: 0x04018551 RID: 99665
		private bool IsFadeActive;

		// Token: 0x04018552 RID: 99666
		private bool HasHandoff;

		// Token: 0x04018553 RID: 99667
		private bool MuteLatched;

		// Token: 0x04018554 RID: 99668
		private bool MusicMuted;

		// Token: 0x04018555 RID: 99669
		[Nullable(2)]
		private static LevelLoadingController _Instance;
	}
}
