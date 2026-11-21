using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Platform.PlatformSdk;
using CSharpScript.Typing;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x02000295 RID: 661
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class KuroSdkController : ControllerBase
{
	// Token: 0x06002920 RID: 10528 RVA: 0x000FDD54 File Offset: 0x000FBF54
	protected override bool OnInit()
	{
		if (this.CanUseSdk())
		{
			this.ReadIfGlobalSdk();
			this.InitPlatformSdkInstance();
			PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
			if (platformSdkBase != null)
			{
				platformSdkBase.Init();
			}
			this.KuroSdkKickBindFunction();
			this.KuroSdkLogoutBindFunction(LoginController.Instance.OnLogoutAccount);
			this.KuroSdkLoginBindFunction(delegate(FLoginStruct result)
			{
				this.OnLogin(result);
			});
			Action<string, string> callback;
			if ((callback = KuroSdkController.<>O.<0>__OnThirdPartyJoinSessionEvent) == null)
			{
				callback = (KuroSdkController.<>O.<0>__OnThirdPartyJoinSessionEvent = new Action<string, string>(OnlineController.OnThirdPartyJoinSessionEvent));
			}
			this.JoinSessionBindFunction(callback);
		}
		this.AddEvent();
		this.InitListener();
		this.OnRegisterNetEvent();
		this.InitTick();
		this.BindWebViewCloseDelegate();
		this.AndroidScreenChangeDelegate = DelegateUtils.ToManualReleaseDelegate<FAndroidScreenChangeHandler>(new Action(this.AndroidScreenChangeCallBack));
		UKuroStaticAndroidLibrary.AddAndroidScreenChangeDelegate(this.AndroidScreenChangeDelegate);
		this.ShowKeyboardDelegate = DelegateUtils.ToManualReleaseDelegate<FLGUIShowVirtualKeyboard>(new Action<bool>(this.ShowKeyboardCallBack));
		UUITextInputComponent.SetShowKeyboardDelegate(this.ShowKeyboardDelegate);
		this.TryInitPostWebView();
		return true;
	}

	// Token: 0x06002921 RID: 10529 RVA: 0x000FDE38 File Offset: 0x000FC038
	public void CloseWebView(string identifier = "Default")
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			PlatformSdkManagerNew.Instance.GetPlatformSdk().CloseWebView();
		}
		if (this.CanUseSdk() && this.PlatformSdkBase != null)
		{
			this.PlatformSdkBase.CloseWebView(identifier);
		}
	}

	// Token: 0x06002922 RID: 10530 RVA: 0x000FDE74 File Offset: 0x000FC074
	private void InitTick()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			this.TickId = TimerSystem.Instance.Forever(new TTimerAction(this.SdkCheckTimer), 1000f, 1f, null, null, true);
			PlatformSdkManagerNew.Instance.GetPlatformSdk().SetTickInnerState(false);
		}
	}

	// Token: 0x06002923 RID: 10531 RVA: 0x000FDEC6 File Offset: 0x000FC0C6
	private void SdkCheckTimer(float delta)
	{
		this.OnTimer(delta * (float)TimeUtil.Instance.Millisecond);
	}

	// Token: 0x06002924 RID: 10532 RVA: 0x000FDEDB File Offset: 0x000FC0DB
	private void EndTick()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			PlatformSdkManagerNew.Instance.GetPlatformSdk().SetTickInnerState(true);
		}
		if (this.TickId != null)
		{
			TimerSystem.Instance.Remove(this.TickId);
		}
	}

	// Token: 0x06002925 RID: 10533 RVA: 0x000FDF12 File Offset: 0x000FC112
	private void OnTimer(float delta)
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			PlatformSdkManagerNew.Instance.GetPlatformSdk().Tick((double)delta);
		}
	}

	// Token: 0x06002926 RID: 10534 RVA: 0x000FDF31 File Offset: 0x000FC131
	private void InitListener()
	{
		if (!this.ListenerState)
		{
			Application.Instance.AddApplicationHandler(EApplicationLifetimeDelegate.ApplicationHasReactivatedDelegate, new Action(this.ApplicationHasReactivatedDelegate));
		}
		this.ListenerState = true;
	}

	// Token: 0x06002927 RID: 10535 RVA: 0x000FDF5C File Offset: 0x000FC15C
	private void ApplicationHasReactivatedDelegate()
	{
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "ApplicationHasReactivatedDelegate", default(ReadOnlySpan<ValueTuple<string, object>>));
		PayItemController.Instance.RequestSdkCheckout(ECheckoutReason.StopGame);
		PlatformReportTerminateGame eventData = new PlatformReportTerminateGame();
		PlatformSdkManagerNew.Instance.GetPlatformSdk().ReportToThirdParty(eventData);
	}

	// Token: 0x06002928 RID: 10536 RVA: 0x000FDFA8 File Offset: 0x000FC1A8
	protected override bool OnClear()
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase != null)
		{
			platformSdkBase.OnClear();
		}
		this.RemoveEvent();
		this.RemoveListener();
		this.OnUnRegisterNetEvent();
		this.CancelCurrentWaitPayItemTimer(true);
		if (this.AndroidScreenChangeDelegate != null)
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action(this.AndroidScreenChangeCallBack));
			this.AndroidScreenChangeDelegate = null;
		}
		if (this.ShowKeyboardDelegate != null)
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<bool>(this.ShowKeyboardCallBack));
			this.ShowKeyboardDelegate = null;
		}
		this.EndTick();
		this.RemoveNoticeCheckTimer();
		UKuroStaticAndroidLibrary.ClearAndroidScreenChangeDelegate();
		return true;
	}

	// Token: 0x06002929 RID: 10537 RVA: 0x000FE031 File Offset: 0x000FC231
	private void RemoveListener()
	{
		if (this.ListenerState)
		{
			Application.Instance.RemoveApplicationHandler(EApplicationLifetimeDelegate.ApplicationHasReactivatedDelegate, new Action(this.ApplicationHasReactivatedDelegate));
		}
		this.ListenerState = false;
	}

	// Token: 0x0600292A RID: 10538 RVA: 0x000FE05C File Offset: 0x000FC25C
	private unsafe void AndroidScreenChangeCallBack()
	{
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "AndroidScreenChangeCallBack", default(ReadOnlySpan<ValueTuple<string, object>>));
		EventSystem.Instance.Emit(EEventName.OnAndroidConfigurationChange);
		UUIItem uiRootItem = UiLayer.Instance.UiRootItem;
		ULGUICanvas ulguicanvas = (uiRootItem != null) ? uiRootItem.GetRenderCanvas() : null;
		if (ulguicanvas != null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.KuroSdk;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "旋转后LguiCanvasViewPort";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("viewPortX", ulguicanvas.GetViewportSize().X);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("viewPortY", ulguicanvas.GetViewportSize().Y);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
	}

	// Token: 0x0600292B RID: 10539 RVA: 0x000FE120 File Offset: 0x000FC320
	private void ShowKeyboardCallBack(bool state)
	{
		if (this.CanUseSdk())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.KuroSdk;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "ShowVirtualKeyboard";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("state", state);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (Info.Instance.IsWinGDKPlatform())
			{
				if (state)
				{
					UKuroStaticXSXLibrary.ShowKeyBoard(state);
					return;
				}
			}
			else
			{
				UKuroSDKStaticLibrary.ShowVirtualKeyboard(state);
			}
		}
	}

	// Token: 0x0600292C RID: 10540 RVA: 0x000FE180 File Offset: 0x000FC380
	private void AddEvent()
	{
		EventSystem.Instance.Add(EEventName.OnSetLoginServerId, new Action(this.OnSetLoginServerId));
		EventSystem.Instance.Add<string>(EEventName.LoginSuccess, new Action<string>(this.OnLoginSuccess));
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
		EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
		EventSystem.Instance.Add(EEventName.SdkRefreshNoticeRedDot, new Action(this.OnSdkRefreshNoticeRedDot));
		if (Platform.Instance.IsPs5Platform())
		{
			EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
			EventSystem.Instance.Add(EEventName.OnQuestFinishListNotify, new Action(this.OnQuestFinishListNotify));
		}
		EventSystem.Instance.Add(EEventName.OnRefreshOnlineTeamList, new Action(this.RefreshMultiPlayerActivity));
		EventSystem.Instance.Add(EEventName.ChangeModeFinish, new Action(this.RefreshMultiPlayerActivity));
	}

	// Token: 0x0600292D RID: 10541 RVA: 0x000FE2AC File Offset: 0x000FC4AC
	private void RemoveEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnSetLoginServerId, new Action(this.OnSetLoginServerId));
		EventSystem.Instance.Remove(EEventName.LoginSuccess, new Action<string>(this.OnLoginSuccess));
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
		EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
		EventSystem.Instance.Remove(EEventName.SdkRefreshNoticeRedDot, new Action(this.OnSdkRefreshNoticeRedDot));
		if (Platform.Instance.IsPs5Platform())
		{
			EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
			EventSystem.Instance.Remove(EEventName.OnQuestFinishListNotify, new Action(this.OnQuestFinishListNotify));
		}
		EventSystem.Instance.Remove(EEventName.OnRefreshOnlineTeamList, new Action(this.RefreshMultiPlayerActivity));
		EventSystem.Instance.Remove(EEventName.ChangeModeFinish, new Action(this.RefreshMultiPlayerActivity));
	}

	// Token: 0x0600292E RID: 10542 RVA: 0x000FE3D7 File Offset: 0x000FC5D7
	private void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.AppGradeNotify, new Action<IMessage, Net.CallbackStatus>(this.OnAppGradeNotify));
	}

	// Token: 0x0600292F RID: 10543 RVA: 0x000FE3F5 File Offset: 0x000FC5F5
	private void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.AppGradeNotify);
	}

	// Token: 0x06002930 RID: 10544 RVA: 0x000FE407 File Offset: 0x000FC607
	private void OnQuestFinishListNotify()
	{
		KuroSdkModel instance = KuroSdkModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.UpdateActivityProgress(0);
	}

	// Token: 0x06002931 RID: 10545 RVA: 0x000FE41C File Offset: 0x000FC61C
	public void RefreshMultiPlayerActivity()
	{
		if (!Info.Instance.IsXboxPlatform())
		{
			return;
		}
		int? id = PlayerInfoModel.Instance.GetId();
		string playerIdByPlayerSessionId = OnlineController.Instance.GetPlayerIdByPlayerSessionId(id.ToString());
		EXboxMultiplayerActivityJoinRestriction roomRestriction = KuroSdkModel.Instance.GetRoomRestriction();
		if (OnlineModel.Instance.GetIsMyTeam() && GameModeModel.Instance.IsMulti)
		{
			this.SetMultiPlayerActivity(OnlineModel.Instance.GetCurrentTeamSize(), OnlineModel.Instance.TeamMaxSize, playerIdByPlayerSessionId, roomRestriction);
		}
	}

	// Token: 0x06002932 RID: 10546 RVA: 0x000FE498 File Offset: 0x000FC698
	public void RefreshOnlineHallActivity()
	{
		if (!Info.Instance.IsXboxPlatform())
		{
			return;
		}
		int? id = PlayerInfoModel.Instance.GetId();
		string playerIdByPlayerSessionId = OnlineController.Instance.GetPlayerIdByPlayerSessionId(id.ToString());
		EXboxMultiplayerActivityJoinRestriction roomRestriction = KuroSdkModel.Instance.GetRoomRestriction();
		this.SetMultiPlayerActivity(1, OnlineModel.Instance.TeamMaxSize, playerIdByPlayerSessionId, roomRestriction);
	}

	// Token: 0x06002933 RID: 10547 RVA: 0x000FE4F3 File Offset: 0x000FC6F3
	private void OnQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason reason)
	{
		if (!Platform.Instance.IsPs5Platform())
		{
			return;
		}
		KuroSdkModel instance = KuroSdkModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.UpdateActivityProgress(questId);
	}

	// Token: 0x06002934 RID: 10548 RVA: 0x000FE512 File Offset: 0x000FC712
	private void OnWorldDoneAndCloseLoading()
	{
		this.CheckNoticeRedDot(0f);
	}

	// Token: 0x06002935 RID: 10549 RVA: 0x000FE51F File Offset: 0x000FC71F
	private void OnLoadingNetDataDone()
	{
		this.RequestServerPlayOnlyState();
		this.RequestUpdatePlatformBlockAccount();
		this.RequestWebSign();
		this.RefreshXboxPlayOnlyState();
		this.TryInitIntroductionParam();
		this.RequestGameStatsShow();
	}

	// Token: 0x06002936 RID: 10550 RVA: 0x000FE546 File Offset: 0x000FC746
	private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
	{
		if (this.PlatformSdkBase != null)
		{
			this.PlatformSdkBase.SetGamePadMode(Info.Instance.IsInGamepad());
		}
	}

	// Token: 0x06002937 RID: 10551 RVA: 0x000FE565 File Offset: 0x000FC765
	private void OnSdkRefreshNoticeRedDot()
	{
		this.CheckNoticeRedDot(0f);
	}

	// Token: 0x06002938 RID: 10552 RVA: 0x000FE574 File Offset: 0x000FC774
	private void OnLoginSuccess(string account)
	{
		IReadOnlyList<Pay> currentRegionPayConfigList = PayItemConfig.Instance.GetCurrentRegionPayConfigList();
		List<string> list = new List<string>();
		if (currentRegionPayConfigList != null)
		{
			foreach (Pay pay in currentRegionPayConfigList)
			{
				list.Add(pay.ProductId);
			}
		}
		PayItemController.Instance.QueryProductInfoAsync(list);
		this.InitNoticeCheckTimer();
	}

	// Token: 0x06002939 RID: 10553 RVA: 0x000FE5E8 File Offset: 0x000FC7E8
	public void RequestGameStatsShow()
	{
		if (!this.CanUseSdk() || !Platform.Instance.IsAndroidPlatform() || !this.GetIfGlobalSdk() || this.PlatformSdkBase == null)
		{
			return;
		}
		Net.Instance.Call(ERequestMessageId.GameStatsShowRequest, GameStatsShowRequest.Create(), delegate(IMessage msg, Net.CallbackStatus _)
		{
			GameStatsShowResponse gameStatsShowResponse = msg as GameStatsShowResponse;
			GoogleGameStatsShow googleGameStatsShow = (gameStatsShowResponse != null) ? gameStatsShowResponse.GoogleGameStatsShow : null;
			if (googleGameStatsShow == null)
			{
				Log.Instance.Warn(ELogModule.KuroSdk, ELogAuthor.YZY, "获取游戏统计信息失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.ReportGameStatistics(googleGameStatsShow);
		}, 0);
	}

	// Token: 0x0600293A RID: 10554 RVA: 0x000FE63C File Offset: 0x000FC83C
	private void ReportGameStatistics(GoogleGameStatsShow statistics)
	{
		ValueTuple<EGameStatisticId, int>[] array = new ValueTuple<EGameStatisticId, int>[]
		{
			new ValueTuple<EGameStatisticId, int>(EGameStatisticId.TeleportActivated, statistics.TeleportNumber),
			new ValueTuple<EGameStatisticId, int>(EGameStatisticId.BoxOpened, statistics.BoxOpenNumber),
			new ValueTuple<EGameStatisticId, int>(EGameStatisticId.RoleUnlocked, statistics.ActiveRoleNumber),
			new ValueTuple<EGameStatisticId, int>(EGameStatisticId.ActiveDays, statistics.ActiveDays),
			new ValueTuple<EGameStatisticId, int>(EGameStatisticId.FetterMonsterUnlocked, statistics.FetterUnLockMonsters)
		};
		List<SdkEventData> list = new List<SdkEventData>(array.Length);
		foreach (ValueTuple<EGameStatisticId, int> valueTuple in array)
		{
			EGameStatisticId item = valueTuple.Item1;
			int item2 = valueTuple.Item2;
			GameStatistic? config = ConfigGameStatisticById.GetConfig((int)item, true);
			if (config == null || string.IsNullOrWhiteSpace(config.Value.GoogleGameKey) || string.IsNullOrWhiteSpace(config.Value.GooglePropertyName) || item2 < 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.KuroSdk;
				ELogAuthor author = ELogAuthor.YZY;
				string message = "游戏统计配置或数值无效，取消整批上报";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("id", item);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			List<SdkEventData> list2 = list;
			SdkEventData sdkEventData = new SdkEventData();
			sdkEventData.EventName = config.Value.GoogleGameKey;
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			string googlePropertyName = config.Value.GooglePropertyName;
			dictionary[googlePropertyName] = item2;
			sdkEventData.Properties = dictionary;
			list2.Add(sdkEventData);
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.RecordEvents(list);
	}

	// Token: 0x0600293B RID: 10555 RVA: 0x000FE7B0 File Offset: 0x000FC9B0
	private void InitNoticeCheckTimer()
	{
		bool flag = this.IfNeedPostWebViewOnClient();
		if (this.CheckNoticeRedDotTimerId == null && flag)
		{
			this.CheckNoticeRedDotTimerId = TimerSystem.Instance.Forever(new TTimerAction(this.CheckNoticeRedDot), 600000f, 1f, null, null, false);
			this.CheckNoticeRedDot(0f);
		}
	}

	// Token: 0x0600293C RID: 10556 RVA: 0x000FE805 File Offset: 0x000FCA05
	private void RemoveNoticeCheckTimer()
	{
		if (this.CheckNoticeRedDotTimerId != null)
		{
			TimerSystem.Instance.Remove(this.CheckNoticeRedDotTimerId);
			this.CheckNoticeRedDotTimerId = null;
		}
	}

	// Token: 0x0600293D RID: 10557 RVA: 0x000FE827 File Offset: 0x000FCA27
	private void OnSetLoginServerId()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn || (this.CanUseSdk() && this.IfGlobalSdk))
		{
			this.PostKuroSdkEvent(EKuroSdkEventKey.KUROINITIALIZEPOSTWEBVIEW);
		}
	}

	// Token: 0x0600293E RID: 10558 RVA: 0x000FE850 File Offset: 0x000FCA50
	private void InitPlatformSdkInstance()
	{
		if (this.PlatformSdkBase == null)
		{
			if (Platform.Instance.IsAndroidPlatform() && !this.GetIfGlobalSdk())
			{
				this.PlatformSdkBase = new PlatformSdkAndroid();
				return;
			}
			if (Platform.Instance.IsAndroidPlatform() && this.GetIfGlobalSdk())
			{
				this.PlatformSdkBase = new PlatformSdkAndroidGlobal();
				return;
			}
			if (Platform.Instance.IsIOSPlatform() && this.GetIfGlobalSdk())
			{
				this.PlatformSdkBase = new PlatformSdkIosGlobal();
				return;
			}
			if (Platform.Instance.IsIOSPlatform() && !this.GetIfGlobalSdk())
			{
				this.PlatformSdkBase = new PlatformSdkIos();
				return;
			}
			if (Platform.Instance.IsWindowsOnlyPlatform() && !this.GetIfGlobalSdk())
			{
				if (!Platform.Instance.IsCloudGame())
				{
					this.PlatformSdkBase = new PlatformSdkWindows();
					return;
				}
				if (CloudGameManager.Instance.IsWebPlatform)
				{
					Log.Instance.Info(ELogModule.CloudGame, ELogAuthor.BB, "云游戏Web SDK初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
					this.PlatformSdkBase = new PlatformCloudSdkWeb();
					return;
				}
				if (Platform.Instance.CloudGamePlatform == "Android")
				{
					Log.Instance.Info(ELogModule.CloudGame, ELogAuthor.BB, "云游戏Android SDK初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
					this.PlatformSdkBase = new PlatformCloudSdkAndroid();
					return;
				}
				if (Platform.Instance.CloudGamePlatform == "IOS" || Platform.Instance.CloudGamePlatform == "Mac")
				{
					Log.Instance.Info(ELogModule.CloudGame, ELogAuthor.BB, "云游戏Ios SDK初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
					this.PlatformSdkBase = new PlatformCloudSdkIos();
					return;
				}
				this.PlatformSdkBase = new PlatformSdkWindows();
				return;
			}
			else
			{
				if (Platform.Instance.IsWindowsOnlyPlatform() && this.GetIfGlobalSdk())
				{
					this.PlatformSdkBase = new PlatformSdkWindowsGlobal();
					return;
				}
				if (Platform.Instance.IsMacPlatform() && !this.GetIfGlobalSdk())
				{
					this.PlatformSdkBase = new PlatformSdkMac();
					return;
				}
				if (Platform.Instance.IsMacPlatform() && this.GetIfGlobalSdk())
				{
					this.PlatformSdkBase = new PlatformSdkMacGlobal();
					return;
				}
				if ((Platform.Instance.IsXSXPlatform() || Platform.Instance.IsWinGDKPlatform()) && this.GetIfGlobalSdk())
				{
					this.PlatformSdkBase = new PlatformXSXGlobal();
					return;
				}
				if (Platform.Instance.IsOpenHarmonyPlatform())
				{
					this.PlatformSdkBase = new PlatformSdkOpenHarmony();
					return;
				}
				Log.Instance.Error(ELogModule.KuroSdk, ELogAuthor.YZY, "未找到合适的PlatformSdk实例", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}
	}

	// Token: 0x0600293F RID: 10559 RVA: 0x000FEABB File Offset: 0x000FCCBB
	public bool GetIfGlobalSdk()
	{
		return this.IfGlobalSdk || (PlatformSdkManagerNew.Instance.IsSdkOn && PlatformSdkConfig.Instance.IsGlobal);
	}

	// Token: 0x06002940 RID: 10560 RVA: 0x000FEADF File Offset: 0x000FCCDF
	public string GetChannelId()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			return PlatformSdkManagerNew.Instance.GetPlatformSdk().GetChannelId();
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		return ((platformSdkBase != null) ? platformSdkBase.GetChannelId() : null) ?? "";
	}

	// Token: 0x06002941 RID: 10561 RVA: 0x000FEB18 File Offset: 0x000FCD18
	public string GetDeviceDid()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			return PlatformSdkManagerNew.Instance.GetPlatformSdk().GetDeviceId();
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		return ((platformSdkBase != null) ? platformSdkBase.GetDeviceDid() : null) ?? "";
	}

	// Token: 0x06002942 RID: 10562 RVA: 0x000FEB51 File Offset: 0x000FCD51
	[NullableContext(2)]
	public string GetPackageId()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			return PlatformSdkManagerNew.Instance.GetPlatformSdk().GetPackageId();
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return null;
		}
		return platformSdkBase.GetPackageId();
	}

	// Token: 0x06002943 RID: 10563 RVA: 0x000FEB80 File Offset: 0x000FCD80
	public bool CheckIfSdkLogin()
	{
		return this.CanUseSdk() && this.GetCurrentLoginInfo().Uid != "0";
	}

	// Token: 0x06002944 RID: 10564 RVA: 0x000FEBA1 File Offset: 0x000FCDA1
	public FLoginStruct GetCurrentLoginInfo()
	{
		return UKuroSDKManager.GetCurrentLoginInfo();
	}

	// Token: 0x06002945 RID: 10565 RVA: 0x000FEBA8 File Offset: 0x000FCDA8
	private void ReadIfGlobalSdk()
	{
		this.IfGlobalSdk = PublicUtil.Instance.GetIfGlobalSdk();
	}

	// Token: 0x06002946 RID: 10566 RVA: 0x000FEBBA File Offset: 0x000FCDBA
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public SdkAgreementLinkData[] GetAgreement()
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return null;
		}
		return platformSdkBase.GetAgreement();
	}

	// Token: 0x06002947 RID: 10567 RVA: 0x000FEBCD File Offset: 0x000FCDCD
	public void TestOpenWnd()
	{
		this.SdkOpenUrlWnd("用户协议", "https://wutheringwaves.kurogame.com/p/agreement_public.html", true, true, true);
	}

	// Token: 0x06002948 RID: 10568 RVA: 0x000FEBE2 File Offset: 0x000FCDE2
	public bool CanUseSdk()
	{
		return !PlatformSdkManagerNew.Instance.IsSdkOn && UKuroStaticLibrary.IsModuleLoaded("KuroSDK") && BaseConfigController.Instance.GetPublicValue("UseSDK") == "1";
	}

	// Token: 0x06002949 RID: 10569 RVA: 0x000FEC18 File Offset: 0x000FCE18
	public void PostKuroSdkEvent(EKuroSdkEventKey eventKey)
	{
		if (this.PlatformSdkBase == null && !PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			if (eventKey == EKuroSdkEventKey.KUROSDKEXIT)
			{
				this.ExitGame();
			}
			return;
		}
		switch (eventKey)
		{
		case EKuroSdkEventKey.KUROSDKLOGIN:
		{
			PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
			if (platformSdkBase == null)
			{
				return;
			}
			platformSdkBase.SdkLogin();
			return;
		}
		case EKuroSdkEventKey.KUROSDKKICK:
		{
			PlatformSdkBase platformSdkBase2 = this.PlatformSdkBase;
			if (platformSdkBase2 == null)
			{
				return;
			}
			platformSdkBase2.SdkKick();
			return;
		}
		case EKuroSdkEventKey.KUROSDKSELECTROLE:
			this.ReportSelectRole();
			return;
		case EKuroSdkEventKey.KUROSDKCREATEROLE:
			this.ReportCreateRole();
			return;
		case EKuroSdkEventKey.KUROSDKLEVEUPROLE:
			this.ReportLevelUpRole();
			return;
		case EKuroSdkEventKey.KUROSDKEXIT:
		{
			PlatformSdkBase platformSdkBase3 = this.PlatformSdkBase;
			if (platformSdkBase3 == null)
			{
				return;
			}
			platformSdkBase3.SdkExit();
			return;
		}
		case EKuroSdkEventKey.KUROSDKLOGOUT:
		{
			PlatformSdkBase platformSdkBase4 = this.PlatformSdkBase;
			if (platformSdkBase4 == null)
			{
				return;
			}
			platformSdkBase4.SdkLogout();
			return;
		}
		case EKuroSdkEventKey.KUROSDKOPENLOGINWND:
			this.SdkOpenLoginWnd();
			return;
		case EKuroSdkEventKey.KUROSDKPAY:
		case EKuroSdkEventKey.KUROSDKOPENSDKWND:
		case EKuroSdkEventKey.KuroDoInit:
			break;
		case EKuroSdkEventKey.KUROINITIALIZEPOSTWEBVIEW:
			this.InitPostWebView();
			return;
		case EKuroSdkEventKey.KUROOPENPOSTWEBVIEW:
			this.OpenPostWebView(EOpenNoticeStage.Normal);
			return;
		case EKuroSdkEventKey.KuroOpenPrivacyClauseWnd:
		{
			PlatformSdkBase platformSdkBase5 = this.PlatformSdkBase;
			if (platformSdkBase5 == null)
			{
				return;
			}
			platformSdkBase5.KuroOpenPrivacyClauseWnd();
			return;
		}
		case EKuroSdkEventKey.KuroOpenUserCenter:
			this.OpenUserCenter();
			return;
		case EKuroSdkEventKey.KuroReadProductInfo:
		{
			PlatformSdkBase platformSdkBase6 = this.PlatformSdkBase;
			if (platformSdkBase6 == null)
			{
				return;
			}
			platformSdkBase6.ReadProductInfo();
			return;
		}
		case EKuroSdkEventKey.KuroShowAgreement:
		{
			PlatformSdkBase platformSdkBase7 = this.PlatformSdkBase;
			if (platformSdkBase7 == null)
			{
				return;
			}
			platformSdkBase7.ShowAgreement();
			break;
		}
		case EKuroSdkEventKey.KuroNotiLanguage:
			this.NotifyLanguage();
			return;
		default:
			return;
		}
	}

	// Token: 0x0600294A RID: 10570 RVA: 0x000FED44 File Offset: 0x000FCF44
	private void NotifyLanguage()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			string packageLanguage = LanguageSystem.Instance.PackageLanguage;
			PlatformSdkManagerNew.Instance.GetPlatformSdk().NotifyCurrentLanguage(packageLanguage);
			return;
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.NotifyLanguage();
	}

	// Token: 0x0600294B RID: 10571 RVA: 0x000FED89 File Offset: 0x000FCF89
	private void SdkOpenLoginWnd()
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.SdkOpenLoginWnd();
	}

	// Token: 0x0600294C RID: 10572 RVA: 0x000FED9C File Offset: 0x000FCF9C
	public void OpenUserCenter()
	{
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "OpenUserCenter", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			SdkLoginConfig sdkLoginConfig = LoginModel.Instance.GetSdkLoginConfig();
			string text = (sdkLoginConfig != null) ? sdkLoginConfig.Uid : null;
			if (text != null)
			{
				PlatformSdkManagerNew.Instance.GetPlatformSdk().OpenUserCenter(text, delegate
				{
					EventSystem.Instance.Emit(EEventName.SdkRefreshAccessToken);
				});
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.KuroSdk;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "OpenUserCenter";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("userId", text);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			PlatformSdkManagerNew.Instance.GetPlatformSdk().OpenUserCenter("test", delegate
			{
				EventSystem.Instance.Emit(EEventName.SdkRefreshAccessToken);
			});
			return;
		}
		else
		{
			PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
			if (platformSdkBase == null)
			{
				return;
			}
			platformSdkBase.OpenUserCenter();
			return;
		}
	}

	// Token: 0x0600294D RID: 10573 RVA: 0x000FEE89 File Offset: 0x000FD089
	private void ExitGame()
	{
		if (GlobalData.IsPlayInEditor)
		{
			UKismetSystemLibrary.QuitGame(GlobalData.World, null, EQuitPreference.Quit, false);
			return;
		}
		if (!this.CanUseSdk())
		{
			KuroApplication.ExitWithReason(false, "SDK");
		}
	}

	// Token: 0x0600294E RID: 10574 RVA: 0x000FEEB4 File Offset: 0x000FD0B4
	public void SdkPay(int payId, string orderId, string name, string desc, string callBackUrl)
	{
		ISDKPayment sdkPayProduct = KuroSdkControllerTool.GetSdkPayProduct(payId, orderId, name, desc, callBackUrl);
		this.SdkPay(sdkPayProduct);
	}

	// Token: 0x0600294F RID: 10575 RVA: 0x000FEED8 File Offset: 0x000FD0D8
	public void SdkPay(ISDKPayment paymentInfo)
	{
		if (this.CanUseSdk())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.KuroSdk;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "SdkPay";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SdkPay", paymentInfo);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			StartSdkPayEvent startSdkPayEvent = new StartSdkPayEvent();
			startSdkPayEvent.s_sdk_pay_order = paymentInfo.cpOrderId;
			startSdkPayEvent.s_sdk_callback_url = (paymentInfo.callbackUrl ?? "");
			LogReportController.Instance.LogReport(startSdkPayEvent);
			KuroSdkModel.Instance.CurrentPayingOrderId = paymentInfo.cpOrderId;
			PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
			if (platformSdkBase != null)
			{
				platformSdkBase.SdkPay(paymentInfo);
			}
			KuroSdkModel.Instance.CurrentPayItemName = paymentInfo.goodsName;
			this.KuroSdkPaymentBindFunction(new Action<bool, string>(this.OnSdkPayEnd));
		}
	}

	// Token: 0x06002950 RID: 10576 RVA: 0x000FEF8D File Offset: 0x000FD18D
	public void OnSdkPayEnd(bool payResult, string str)
	{
		if (payResult && KuroSdkModel.Instance.CurrentPayItemName != "")
		{
			this.StartWaitPayItemTimer();
		}
		EventSystem.Instance.Emit<ESdkDialogResult>(EEventName.SdkPayEnd, payResult ? ESdkDialogResult.Yes : ESdkDialogResult.No);
	}

	// Token: 0x06002951 RID: 10577 RVA: 0x000FEFC2 File Offset: 0x000FD1C2
	public void OpenNotice(EOpenNoticeStage stage = EOpenNoticeStage.Normal)
	{
		this.OpenPostWebView(stage);
	}

	// Token: 0x06002952 RID: 10578 RVA: 0x000FEFCB File Offset: 0x000FD1CB
	public void OpenFeedback()
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.OpenFeedback();
	}

	// Token: 0x06002953 RID: 10579 RVA: 0x000FEFDD File Offset: 0x000FD1DD
	public void SdkOpenUrlWnd(string title, string url, bool isLandscape = true, bool transparent = true, bool webAccelerated = true)
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			PlatformSdkManagerNew.Instance.GetPlatformSdk().OpenWebView(url, null);
			return;
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.SdkOpenUrlWnd(title, url, isLandscape, transparent, webAccelerated);
	}

	// Token: 0x06002954 RID: 10580 RVA: 0x000FF014 File Offset: 0x000FD214
	public void OpenExternalUrl(string url)
	{
		PlatformSdkManagerNew.Instance.GetPlatformSdk().OpenExternalUrl(url);
	}

	// Token: 0x06002955 RID: 10581 RVA: 0x000FF028 File Offset: 0x000FD228
	[NullableContext(0)]
	public UniTask<bool> QueryProductByProductId([Nullable(1)] string[] productList)
	{
		KuroSdkController.<QueryProductByProductId>d__69 <QueryProductByProductId>d__;
		<QueryProductByProductId>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<QueryProductByProductId>d__.<>4__this = this;
		<QueryProductByProductId>d__.productList = productList;
		<QueryProductByProductId>d__.<>1__state = -1;
		<QueryProductByProductId>d__.<>t__builder.Start<KuroSdkController.<QueryProductByProductId>d__69>(ref <QueryProductByProductId>d__);
		return <QueryProductByProductId>d__.<>t__builder.Task;
	}

	// Token: 0x06002956 RID: 10582 RVA: 0x000FF073 File Offset: 0x000FD273
	public void ShareByteData(ShareData shareData, TArray<byte> data)
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.ShareByteData(shareData, data);
	}

	// Token: 0x06002957 RID: 10583 RVA: 0x000FF087 File Offset: 0x000FD287
	public void Share(ShareData shareData, string imagePath)
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.Share(shareData, imagePath);
	}

	// Token: 0x06002958 RID: 10584 RVA: 0x000FF09B File Offset: 0x000FD29B
	public void ShareTexture(ShareData shareData, string texturePath)
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.ShareTexture(shareData, texturePath);
	}

	// Token: 0x06002959 RID: 10585 RVA: 0x000FF0AF File Offset: 0x000FD2AF
	private string GetCurrentQueryChannel()
	{
		return "";
	}

	// Token: 0x0600295A RID: 10586 RVA: 0x000FF0B6 File Offset: 0x000FD2B6
	public void OpenWebView(string title, string url, bool isLandscape, bool transparent, bool webAccelerated = true, string identifier = "Default")
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			PlatformSdkManagerNew.Instance.GetPlatformSdk().OpenWebView(url, null);
			return;
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.OpenWebView(title, url, isLandscape, transparent, webAccelerated, identifier);
	}

	// Token: 0x0600295B RID: 10587 RVA: 0x000FF0EF File Offset: 0x000FD2EF
	public void KuroSdkLoginBindFunction(Action<FLoginStruct> loginFunction)
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.KuroSdkLoginBindFunction(loginFunction);
	}

	// Token: 0x0600295C RID: 10588 RVA: 0x000FF102 File Offset: 0x000FD302
	public void KuroSdkLoginBindFunction(Action<ILoginInfo> loginFunction)
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.KuroSdkLoginBindFunction(loginFunction);
	}

	// Token: 0x0600295D RID: 10589 RVA: 0x000FF115 File Offset: 0x000FD315
	public void KuroSdkKickBindFunction()
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.KuroSdkKickBindFunction();
	}

	// Token: 0x0600295E RID: 10590 RVA: 0x000FF127 File Offset: 0x000FD327
	public void KuroSdkLogoutBindFunction(Action callback)
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.KuroSdkLogoutBindFunction(callback);
	}

	// Token: 0x0600295F RID: 10591 RVA: 0x000FF13A File Offset: 0x000FD33A
	public void KuroSdkPaymentBindFunction(Action<bool, string> paymentFunction)
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.KuroSdkPaymentBindFunction(paymentFunction);
	}

	// Token: 0x06002960 RID: 10592 RVA: 0x000FF14D File Offset: 0x000FD34D
	public void JoinSessionBindFunction(Action<string, string> callback)
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.JoinSessionBindFunction(callback);
	}

	// Token: 0x06002961 RID: 10593 RVA: 0x000FF160 File Offset: 0x000FD360
	public void SetPostWebViewRedPointState(bool state)
	{
		this.CurrentPostViewRedPointState = state;
	}

	// Token: 0x06002962 RID: 10594 RVA: 0x000FF169 File Offset: 0x000FD369
	public void SetCustomerServiceRedPointState(bool state)
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.SetCustomerServiceShowState(state);
	}

	// Token: 0x06002963 RID: 10595 RVA: 0x000FF17C File Offset: 0x000FD37C
	public bool GetPostWebViewRedPointState()
	{
		if (this.IfNeedPostWebViewOnClient())
		{
			return KuroSdkModel.Instance.NoticeRedDotState;
		}
		return this.CurrentPostViewRedPointState;
	}

	// Token: 0x06002964 RID: 10596 RVA: 0x000FF197 File Offset: 0x000FD397
	public bool NeedShowCustomerService()
	{
		return ChannelController.Instance.CheckCustomerServiceOpen();
	}

	// Token: 0x06002965 RID: 10597 RVA: 0x000FF1A3 File Offset: 0x000FD3A3
	public bool GetCustomerServiceRedPointState()
	{
		return this.PlatformSdkBase != null && this.PlatformSdkBase.GetCustomerServiceShowState();
	}

	// Token: 0x06002966 RID: 10598 RVA: 0x000FF1BA File Offset: 0x000FD3BA
	public void OpenCustomerService(EKuroSdkOpenCustomerServerType fromType)
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			PlatformSdkManagerNew.Instance.GetPlatformSdk().OpenCustomerService();
			return;
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase != null)
		{
			platformSdkBase.ResetCustomServerRedDot();
		}
		PlatformSdkBase platformSdkBase2 = this.PlatformSdkBase;
		if (platformSdkBase2 == null)
		{
			return;
		}
		platformSdkBase2.OpenCustomerService(fromType);
	}

	// Token: 0x06002967 RID: 10599 RVA: 0x000FF1FA File Offset: 0x000FD3FA
	public bool GetIfCanQRCodeLogin()
	{
		if (!this.CanUseSdk())
		{
			return false;
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		return platformSdkBase != null && platformSdkBase.GetIsQRCodeLogin();
	}

	// Token: 0x06002968 RID: 10600 RVA: 0x000FF217 File Offset: 0x000FD417
	public void DoQRCodeLogin()
	{
		if (!this.CanUseSdk())
		{
			return;
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.QRCodeLogin();
	}

	// Token: 0x06002969 RID: 10601 RVA: 0x000FF232 File Offset: 0x000FD432
	public bool CheckPhotoPermission()
	{
		if (!this.CanUseSdk() || this.PlatformSdkBase == null)
		{
			return true;
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		return platformSdkBase == null || platformSdkBase.CheckPhotoPermission();
	}

	// Token: 0x0600296A RID: 10602 RVA: 0x000FF257 File Offset: 0x000FD457
	public void RequestPhotoPermission(Action<bool> callBack)
	{
		if (!this.CanUseSdk())
		{
			return;
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.RequestPhotoPermission(callBack);
	}

	// Token: 0x0600296B RID: 10603 RVA: 0x000FF274 File Offset: 0x000FD474
	public void CancelCurrentWaitPayItemTimer(bool clearPayItem = true)
	{
		if (clearPayItem)
		{
			KuroSdkModel.Instance.CurrentPayItemName = "";
			Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "CancelCurrentWaitPayItemTimer clearPayItem", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		if (this.WaitPayResponseTimerId != null)
		{
			TimerSystem.Instance.Remove(this.WaitPayResponseTimerId);
			this.WaitPayResponseTimerId = null;
		}
	}

	// Token: 0x0600296C RID: 10604 RVA: 0x000FF2CF File Offset: 0x000FD4CF
	public void CancelQueryProductTimer()
	{
		if (this.CheckQueryProductTimerId != null)
		{
			TimerSystem.Instance.Remove(this.CheckQueryProductTimerId);
			this.CheckQueryProductTimerId = null;
		}
	}

	// Token: 0x0600296D RID: 10605 RVA: 0x000FF2F1 File Offset: 0x000FD4F1
	private void StartQueryProductTimer()
	{
		this.CancelQueryProductTimer();
		this.CheckQueryProductTimerId = TimerSystem.Instance.Delay(delegate(float _)
		{
			CustomPromise<bool> queryPromise = KuroSdkModel.Instance.QueryPromise;
			if (queryPromise != null && queryPromise.IsPending)
			{
				KuroSdkModel.Instance.QueryPromise.SetResult(false);
			}
			this.CheckQueryProductTimerId = null;
		}, 10000f, null, null, true, 1f);
	}

	// Token: 0x0600296E RID: 10606 RVA: 0x000FF324 File Offset: 0x000FD524
	public void StartWaitPayItemTimer()
	{
		this.CancelCurrentWaitPayItemTimer(false);
		int? waitPaySuccessTime = PayItemConfig.Instance.GetWaitPaySuccessTime();
		this.WaitPayResponseTimerId = TimerSystem.Instance.Delay(delegate(float _)
		{
			string currentPayItemName = KuroSdkModel.Instance.CurrentPayItemName;
			if (StringUtils.IsBlank(currentPayItemName))
			{
				this.WaitPayResponseTimerId = null;
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PayResTimeOut);
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				currentPayItemName
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			this.WaitPayResponseTimerId = null;
		}, (float)waitPaySuccessTime.Value, null, null, true, 1f);
	}

	// Token: 0x0600296F RID: 10607 RVA: 0x000FF370 File Offset: 0x000FD570
	public void RequestServerPlayOnlyState()
	{
		PsnSettingRequest message = PsnSettingRequest.Create();
		Net.Instance.Call(ERequestMessageId.PsnSettingRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PsnSettingResponse psnSettingResponse = (PsnSettingResponse)msg;
			KuroSdkModel.Instance.SetPlayStationPlayOnlyState(psnSettingResponse.MatchPsnUser);
		}, 0);
		XboxSettingRequest message2 = XboxSettingRequest.Create();
		Net.Instance.Call(ERequestMessageId.XboxSettingRequest, message2, delegate(IMessage msg, Net.CallbackStatus _)
		{
			XboxSettingResponse xboxSettingResponse = (XboxSettingResponse)msg;
			KuroSdkModel.Instance.SetXboxPlayOnlyState(xboxSettingResponse.MatchXboxUser);
		}, 0);
	}

	// Token: 0x06002970 RID: 10608 RVA: 0x000FF3EC File Offset: 0x000FD5EC
	public void RequestWebSign()
	{
		PlayerGameTokenRequest message = PlayerGameTokenRequest.Create();
		Net.Instance.Call(ERequestMessageId.PlayerGameTokenRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PlayerGameTokenResponse playerGameTokenResponse = (PlayerGameTokenResponse)msg;
			KuroSdkModel.Instance.NoticeSign = (((playerGameTokenResponse != null) ? playerGameTokenResponse.GameToken : null) ?? "");
			this.CheckNoticeRedDot(0f);
		}, 0);
	}

	// Token: 0x06002971 RID: 10609 RVA: 0x000FF41C File Offset: 0x000FD61C
	public UniTask RequestUpdatePlatformBlockAccount()
	{
		KuroSdkController.<RequestUpdatePlatformBlockAccount>d__97 <RequestUpdatePlatformBlockAccount>d__;
		<RequestUpdatePlatformBlockAccount>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestUpdatePlatformBlockAccount>d__.<>4__this = this;
		<RequestUpdatePlatformBlockAccount>d__.<>1__state = -1;
		<RequestUpdatePlatformBlockAccount>d__.<>t__builder.Start<KuroSdkController.<RequestUpdatePlatformBlockAccount>d__97>(ref <RequestUpdatePlatformBlockAccount>d__);
		return <RequestUpdatePlatformBlockAccount>d__.<>t__builder.Task;
	}

	// Token: 0x06002972 RID: 10610 RVA: 0x000FF460 File Offset: 0x000FD660
	public void RequestChangeServerPlayStationPlayOnlyState(bool state)
	{
		PsnSettingUpdateRequest psnSettingUpdateRequest = PsnSettingUpdateRequest.Create();
		psnSettingUpdateRequest.MatchPsnUser = state;
		Net.Instance.Call(ERequestMessageId.PsnSettingUpdateRequest, psnSettingUpdateRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PsnSettingUpdateResponse psnSettingUpdateResponse = (PsnSettingUpdateResponse)msg;
			if (psnSettingUpdateResponse == null || psnSettingUpdateResponse.ErrorCode > Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(psnSettingUpdateResponse.ErrorCode, 20925, null, true, true);
				return;
			}
			KuroSdkModel.Instance.SetPlayStationPlayOnlyState(state);
		}, 0);
	}

	// Token: 0x06002973 RID: 10611 RVA: 0x000FF4AC File Offset: 0x000FD6AC
	public void RequestChangeServerXboxPlayOnlyState(bool state)
	{
		XboxSettingUpdateRequest xboxSettingUpdateRequest = XboxSettingUpdateRequest.Create();
		xboxSettingUpdateRequest.MatchXboxUser = state;
		xboxSettingUpdateRequest.XboxBlockUserCreatedContentViewing = !this.CheckPrivilege(ESdkPrivilege.UserGeneratedContent);
		Net.Instance.Call(ERequestMessageId.XboxSettingUpdateRequest, xboxSettingUpdateRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			XboxSettingUpdateResponse xboxSettingUpdateResponse = (XboxSettingUpdateResponse)msg;
			if (xboxSettingUpdateResponse == null || xboxSettingUpdateResponse.ErrorCode > Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(xboxSettingUpdateResponse.ErrorCode, 20925, null, true, true);
			}
			KuroSdkModel.Instance.SetXboxPlayOnlyState(state);
		}, 0);
	}

	// Token: 0x06002974 RID: 10612 RVA: 0x000FF505 File Offset: 0x000FD705
	private bool CheckIfCanOpenReviewView()
	{
		return KuroSdkModel.Instance.NeedOpenReviewState;
	}

	// Token: 0x06002975 RID: 10613 RVA: 0x000FF516 File Offset: 0x000FD716
	public void TryOpenReview()
	{
		if (!this.CheckIfCanOpenReviewView())
		{
			return;
		}
		TimerSystem.Instance.Delay(delegate(float _)
		{
			double global = LocalStorage.GetGlobal<double>(ELocalStorageGlobalKey.LastReviewTime, 0.0);
			int valueOrDefault = CommonConfig.Instance.GetReviewCd().GetValueOrDefault();
			double serverTime = TimeUtil.Instance.GetServerTime();
			if (serverTime - global > (double)valueOrDefault)
			{
				LocalStorage.SetGlobal<double>(ELocalStorageGlobalKey.LastReviewTime, serverTime);
				this.OpenReview();
				return;
			}
			KuroSdkModel.Instance.NeedOpenReviewState = false;
		}, (float)KuroSdkModel.Instance.ReviewDelay, null, null, true, 1f);
	}

	// Token: 0x06002976 RID: 10614 RVA: 0x000FF54C File Offset: 0x000FD74C
	private void OpenReview()
	{
		if (KuroSdkModel.Instance.NeedReviewConfirmBox)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ShowReviewConfirm);
			confirmBoxDataNew.SetCloseFunction(delegate
			{
				if (this.PlatformSdkBase != null)
				{
					this.PlatformSdkBase.OpenReview(KuroSdkModel.Instance.CurrentReviewId);
					KuroSdkModel.Instance.NeedOpenReviewState = false;
				}
			});
			ConfirmBoxController.Instance.ShowNetWorkConfirmBoxView(confirmBoxDataNew, null);
			return;
		}
		if (this.PlatformSdkBase != null)
		{
			this.PlatformSdkBase.OpenReview(KuroSdkModel.Instance.CurrentReviewId);
			KuroSdkModel.Instance.NeedOpenReviewState = false;
		}
	}

	// Token: 0x06002977 RID: 10615 RVA: 0x000FF5B8 File Offset: 0x000FD7B8
	[NullableContext(2)]
	private void OnAppGradeNotify(IMessage msg, Net.CallbackStatus status)
	{
		AppGradeNotify appGradeNotify = (AppGradeNotify)msg;
		KuroSdkModel.Instance.NeedOpenReviewState = true;
		KuroSdkModel.Instance.ReviewDelay = appGradeNotify.Delay;
		KuroSdkModel.Instance.CurrentReviewId = appGradeNotify.Id;
		if (appGradeNotify.Type != 1)
		{
			this.TryOpenReview();
		}
	}

	// Token: 0x06002978 RID: 10616 RVA: 0x000FF606 File Offset: 0x000FD806
	public void ClientOpenReview()
	{
		KuroSdkModel.Instance.NeedOpenReviewState = true;
		KuroSdkModel.Instance.ReviewDelay = 1000;
		this.TryOpenReview();
	}

	// Token: 0x06002979 RID: 10617 RVA: 0x000FF628 File Offset: 0x000FD828
	public void SetCursor(string path)
	{
		if (this.PlatformSdkBase != null)
		{
			this.PlatformSdkBase.SetCursor(path);
		}
	}

	// Token: 0x0600297A RID: 10618 RVA: 0x000FF63E File Offset: 0x000FD83E
	private void ReportSelectRole()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			PlatformSdkManagerNew.Instance.GetPlatformSdk().ReportToServer(EReportRoleDataType.Select, this.ConvertRoleInfoData(KuroSdkControllerTool.GetRoleInfoData()));
			return;
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.SdkSelectRole();
	}

	// Token: 0x0600297B RID: 10619 RVA: 0x000FF678 File Offset: 0x000FD878
	private void ReportCreateRole()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			PlatformSdkManagerNew.Instance.GetPlatformSdk().ReportToServer(EReportRoleDataType.Create, this.ConvertRoleInfoData(KuroSdkControllerTool.GetCreateRoleInfoData()));
			return;
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.SdkCreateRole();
	}

	// Token: 0x0600297C RID: 10620 RVA: 0x000FF6B2 File Offset: 0x000FD8B2
	private void ReportLevelUpRole()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			PlatformSdkManagerNew.Instance.GetPlatformSdk().ReportToServer(EReportRoleDataType.LevelUp, this.ConvertRoleInfoData(KuroSdkControllerTool.GetRoleInfoData()));
			return;
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.SdkLevelUpRole();
	}

	// Token: 0x0600297D RID: 10621 RVA: 0x000FF6EC File Offset: 0x000FD8EC
	private ReportRoleData ConvertRoleInfoData(RoleInfoSdk roleInfoData)
	{
		return new ReportRoleData
		{
			roleId = roleInfoData.RoleId,
			roleLevel = roleInfoData.RoleLevel,
			roleName = roleInfoData.RoleName,
			serverId = roleInfoData.ServerId,
			serverName = roleInfoData.ServerName
		};
	}

	// Token: 0x0600297E RID: 10622 RVA: 0x000FF73C File Offset: 0x000FD93C
	private void BindWebViewCloseDelegate()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			PlatformSdkManagerNew.Instance.GetPlatformSdk().BindOnWebViewCloseCallBack(delegate
			{
				EventSystem.Instance.Emit(EEventName.SdkRefreshNoticeRedDot);
			});
			return;
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.BindWebViewCloseDelegate(delegate
		{
			EventSystem.Instance.Emit(EEventName.SdkRefreshNoticeRedDot);
		});
	}

	// Token: 0x0600297F RID: 10623 RVA: 0x000FF7B3 File Offset: 0x000FD9B3
	private bool IfNeedPostWebViewOnClient()
	{
		return true;
	}

	// Token: 0x06002980 RID: 10624 RVA: 0x000FF7B6 File Offset: 0x000FD9B6
	private void InitPostWebView()
	{
		if (this.IfNeedPostWebViewOnClient())
		{
			this.TryInitPostWebView();
			return;
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.InitializePostWebView();
	}

	// Token: 0x06002981 RID: 10625 RVA: 0x000FF7D8 File Offset: 0x000FD9D8
	private void OpenPostWebView(EOpenNoticeStage stage = EOpenNoticeStage.Normal)
	{
		NoticeClickLogEvent logData = new NoticeClickLogEvent();
		LogReportController.Instance.LogReport(logData);
		if (this.IfNeedPostWebViewOnClient())
		{
			this.OpenPostWebViewOnClient(stage);
			return;
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.OpenPostWebView();
	}

	// Token: 0x06002982 RID: 10626 RVA: 0x000FF818 File Offset: 0x000FDA18
	private unsafe void OpenPostWebViewOnClient(EOpenNoticeStage stage = EOpenNoticeStage.Normal)
	{
		this.HttpGetNoticeH5Data(delegate(bool state, int urlIndex)
		{
			if (state)
			{
				string noticeUrl = KuroSdkModel.Instance.GetNoticeUrl(urlIndex, stage);
				this.OpenWebView("", noticeUrl, true, true, true, "Default");
				Log instance = Log.Instance;
				ELogModule module = ELogModule.KuroSdk;
				ELogAuthor author = ELogAuthor.YZY;
				string message = "OpenPostWebViewOnClient";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("urlIndex", urlIndex);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.KuroSdk;
			ELogAuthor author2 = ELogAuthor.YZY;
			string message2 = "OpenPostWebViewOnClientFail";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("state", state);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("urlIndex", urlIndex);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}, 0);
	}

	// Token: 0x06002983 RID: 10627 RVA: 0x000FF84C File Offset: 0x000FDA4C
	private void HttpGetNoticeH5Data(Action<bool, int> callBack, int currentIndex = 0)
	{
		if (KuroSdkModel.Instance.GetEntryPointData() == null)
		{
			callBack(false, currentIndex);
			return;
		}
		if (currentIndex >= KuroSdkModel.Instance.GetEntryPointData().h5AppUrl.Length)
		{
			callBack(false, currentIndex);
			return;
		}
		Http.Get(KuroSdkModel.Instance.GetNoticeUrl(currentIndex, EOpenNoticeStage.Normal), null, delegate(bool success, int code, string data)
		{
			if (!success || code != 200)
			{
				this.HttpGetNoticeH5Data(callBack, currentIndex + 1);
				return;
			}
			callBack(true, currentIndex);
		}, null);
	}

	// Token: 0x06002984 RID: 10628 RVA: 0x000FF8EC File Offset: 0x000FDAEC
	private void HttpGetInfo(string url, Action<bool, int, string> callBack, int currentTryCount = 0)
	{
		Http.Get(url, null, delegate(bool success, int code, string data)
		{
			if (success && code == 200)
			{
				callBack(true, code, data);
				return;
			}
			int num = currentTryCount + 1;
			if (num < 3)
			{
				this.HttpGetInfo(url, callBack, num);
				return;
			}
			callBack(false, code, data);
		}, null);
	}

	// Token: 0x06002985 RID: 10629 RVA: 0x000FF93C File Offset: 0x000FDB3C
	public unsafe void TryInitIntroductionParam()
	{
		if (this.TryInitIntroductionParamState)
		{
			return;
		}
		string introductionVersionUrl = KuroSdkModel.Instance.GetIntroductionVersionUrl();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "TryInitIntroductionParam";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("url", introductionVersionUrl);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.HttpGetInfo(introductionVersionUrl, delegate(bool state, int code, string data)
		{
			if (!state)
			{
				string introductionVersionUrl2 = KuroSdkModel.Instance.GetIntroductionVersionUrl();
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.KuroSdk;
				ELogAuthor author2 = ELogAuthor.YZY;
				string message2 = "TryInitIntroductionParam fail";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("state", state);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("code", code);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("url", introductionVersionUrl2);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
			else
			{
				IntroductionData introductionData = Json.Decode<IntroductionData>(data, null);
				KuroSdkModel.Instance.SetIntroductionData(introductionData);
			}
			this.TryInitIntroductionParamState = false;
		}, 0);
	}

	// Token: 0x06002986 RID: 10630 RVA: 0x000FF998 File Offset: 0x000FDB98
	private unsafe void TryInitPostWebView()
	{
		if (!this.IfNeedPostWebViewOnClient())
		{
			return;
		}
		string currentLoginServerId = LoginServerModel.Instance.GetCurrentLoginServerId();
		if (currentLoginServerId == "" || currentLoginServerId == "0")
		{
			return;
		}
		if (this.TryInitPostWebViewState)
		{
			return;
		}
		this.TryInitPostWebViewState = true;
		string entryPointUrl = KuroSdkModel.Instance.GetEntryPointUrl();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "TryInitPostWebView";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("url", entryPointUrl);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.HttpGetInfo(entryPointUrl, delegate(bool state, int code, string data)
		{
			if (!state)
			{
				string entryPointUrl2 = KuroSdkModel.Instance.GetEntryPointUrl();
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.KuroSdk;
				ELogAuthor author2 = ELogAuthor.YZY;
				string message2 = "TryInitPostWebView fail";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("state", state);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("code", code);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("url", entryPointUrl2);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
			else
			{
				PostWebViewEntryPointData entryPointData = Json.Decode<PostWebViewEntryPointData>(data, null);
				KuroSdkModel.Instance.SetEntryPointData(entryPointData);
			}
			this.TryInitPostWebViewState = false;
		}, 0);
	}

	// Token: 0x06002987 RID: 10631 RVA: 0x000FFA2C File Offset: 0x000FDC2C
	private void CheckNoticeRedDot(float delta)
	{
		GameModeModel instance = GameModeModel.Instance;
		if (instance == null || instance.LoadingPhase != ELoadingPhase.Finished || KuroSdkModel.Instance.NoticeSign == "")
		{
			return;
		}
		this.HttpGetNoticeRedDotState(delegate(bool state, int code, string data)
		{
			if (state)
			{
				NoticeRedDotData noticeRedDotData = Json.Decode<NoticeRedDotData>(data, null);
				KuroSdkModel.Instance.NoticeRedDotState = noticeRedDotData.data;
				EventSystem.Instance.Emit(EEventName.SdkPostWebViewRedPointRefresh);
				return;
			}
			KuroSdkModel.Instance.NoticeRedDotState = false;
			EventSystem.Instance.Emit(EEventName.SdkPostWebViewRedPointRefresh);
		}, 0);
	}

	// Token: 0x06002988 RID: 10632 RVA: 0x000FFA90 File Offset: 0x000FDC90
	private void HttpGetNoticeRedDotState(Action<bool, int, string> callBack, int currentIndex = 0)
	{
		if (KuroSdkModel.Instance.GetEntryPointData() == null)
		{
			callBack(false, 0, "");
			return;
		}
		if (currentIndex >= KuroSdkModel.Instance.GetEntryPointData().apiUrls.Length)
		{
			callBack(false, 0, "");
			return;
		}
		Http.Get(KuroSdkModel.Instance.GetQueryNoticeRedDotStateUrl(currentIndex), null, delegate(bool success, int code, string data)
		{
			if (!success || code != 200)
			{
				this.HttpGetNoticeRedDotState(callBack, currentIndex + 1);
				return;
			}
			callBack(success, code, data);
		}, null);
	}

	// Token: 0x06002989 RID: 10633 RVA: 0x000FFB30 File Offset: 0x000FDD30
	private void HttpGetNoticeContentData(Action<bool, int, string> callBack, int currentIndex = 0)
	{
		if (KuroSdkModel.Instance.GetEntryPointData() == null)
		{
			callBack(false, 0, "");
			return;
		}
		if (currentIndex >= KuroSdkModel.Instance.GetEntryPointData().contentUrl.Length)
		{
			callBack(false, 0, "");
			return;
		}
		Http.Get(KuroSdkModel.Instance.GetNoticeContentUrl(currentIndex), null, delegate(bool success, int code, string data)
		{
			if (!success || code != 200)
			{
				this.HttpGetNoticeContentData(callBack, currentIndex + 1);
				return;
			}
			callBack(success, code, data);
		}, null);
	}

	// Token: 0x0600298A RID: 10634 RVA: 0x000FFBCE File Offset: 0x000FDDCE
	public void RecoverSdkData()
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.RecoverSdkData();
	}

	// Token: 0x0600298B RID: 10635 RVA: 0x000FFBE0 File Offset: 0x000FDDE0
	public void ShowExternalLogin()
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.ShowExternalLogin();
	}

	// Token: 0x0600298C RID: 10636 RVA: 0x000FFBF2 File Offset: 0x000FDDF2
	public void UnlockSdkTrophy(string id)
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			PlatformSdkManagerNew.Instance.GetPlatformSdk().UnlockSdkTrophy(int.Parse(id));
			return;
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.UnlockSdkTrophy(id);
	}

	// Token: 0x0600298D RID: 10637 RVA: 0x000FFC28 File Offset: 0x000FDE28
	public bool CheckIfPioneer()
	{
		string packageId = this.GetPackageId();
		if (packageId == null || packageId == "")
		{
			return false;
		}
		IReadOnlyList<string> pioneerPkgIdList = CommonConfig.Instance.GetPioneerPkgIdList();
		for (int i = 0; i < pioneerPkgIdList.Count; i++)
		{
			if (pioneerPkgIdList[i] == packageId)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600298E RID: 10638 RVA: 0x000FFC7C File Offset: 0x000FDE7C
	[NullableContext(0)]
	public UniTask<ESdkCommunicationRestricted> GetCommunicationRestrictedAsync([Nullable(2)] string accountId)
	{
		KuroSdkController.<GetCommunicationRestrictedAsync>d__127 <GetCommunicationRestrictedAsync>d__;
		<GetCommunicationRestrictedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<ESdkCommunicationRestricted>.Create();
		<GetCommunicationRestrictedAsync>d__.<>4__this = this;
		<GetCommunicationRestrictedAsync>d__.accountId = accountId;
		<GetCommunicationRestrictedAsync>d__.<>1__state = -1;
		<GetCommunicationRestrictedAsync>d__.<>t__builder.Start<KuroSdkController.<GetCommunicationRestrictedAsync>d__127>(ref <GetCommunicationRestrictedAsync>d__);
		return <GetCommunicationRestrictedAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600298F RID: 10639 RVA: 0x000FFCC8 File Offset: 0x000FDEC8
	[NullableContext(0)]
	public UniTask<bool> OpenMessageBox([Nullable(1)] string accountId, ESdkMessageBoxMode dialogMode, ESdkMessageBoxType msgType, ESdkPrivilege sdkPrivilege = ESdkPrivilege.Invalid)
	{
		KuroSdkController.<OpenMessageBox>d__128 <OpenMessageBox>d__;
		<OpenMessageBox>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenMessageBox>d__.<>4__this = this;
		<OpenMessageBox>d__.accountId = accountId;
		<OpenMessageBox>d__.dialogMode = dialogMode;
		<OpenMessageBox>d__.msgType = msgType;
		<OpenMessageBox>d__.sdkPrivilege = sdkPrivilege;
		<OpenMessageBox>d__.<>1__state = -1;
		<OpenMessageBox>d__.<>t__builder.Start<KuroSdkController.<OpenMessageBox>d__128>(ref <OpenMessageBox>d__);
		return <OpenMessageBox>d__.<>t__builder.Task;
	}

	// Token: 0x06002990 RID: 10640 RVA: 0x000FFD2C File Offset: 0x000FDF2C
	[return: Nullable(new byte[]
	{
		0,
		0,
		1,
		1,
		1
	})]
	public UniTask<ValueTuple<string, string, string>> GetThirdPartyLoginInfoAsync()
	{
		KuroSdkController.<GetThirdPartyLoginInfoAsync>d__129 <GetThirdPartyLoginInfoAsync>d__;
		<GetThirdPartyLoginInfoAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<ValueTuple<string, string, string>>.Create();
		<GetThirdPartyLoginInfoAsync>d__.<>4__this = this;
		<GetThirdPartyLoginInfoAsync>d__.<>1__state = -1;
		<GetThirdPartyLoginInfoAsync>d__.<>t__builder.Start<KuroSdkController.<GetThirdPartyLoginInfoAsync>d__129>(ref <GetThirdPartyLoginInfoAsync>d__);
		return <GetThirdPartyLoginInfoAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06002991 RID: 10641 RVA: 0x000FFD70 File Offset: 0x000FDF70
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public UniTask<Dictionary<string, bool>> GetSdkBlockingUser()
	{
		KuroSdkController.<GetSdkBlockingUser>d__130 <GetSdkBlockingUser>d__;
		<GetSdkBlockingUser>d__.<>t__builder = AsyncUniTaskMethodBuilder<Dictionary<string, bool>>.Create();
		<GetSdkBlockingUser>d__.<>4__this = this;
		<GetSdkBlockingUser>d__.<>1__state = -1;
		<GetSdkBlockingUser>d__.<>t__builder.Start<KuroSdkController.<GetSdkBlockingUser>d__130>(ref <GetSdkBlockingUser>d__);
		return <GetSdkBlockingUser>d__.<>t__builder.Task;
	}

	// Token: 0x06002992 RID: 10642 RVA: 0x000FFDB3 File Offset: 0x000FDFB3
	public void SetPlayOnly(bool state)
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			PlatformSdkManagerNew.Instance.GetPlatformSdk().SetPlayOnly(state);
			return;
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.SetPlayOnly(state);
	}

	// Token: 0x06002993 RID: 10643 RVA: 0x000FFDE3 File Offset: 0x000FDFE3
	public bool NeedCheckPlayOnly()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			return PlatformSdkManagerNew.Instance.GetPlatformSdk().NeedCheckPlayOnly();
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		return platformSdkBase != null && platformSdkBase.NeedCheckPlayOnly();
	}

	// Token: 0x06002994 RID: 10644 RVA: 0x000FFE12 File Offset: 0x000FE012
	public bool GetSdkFriendOnlyState()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			return PlatformSdkManagerNew.Instance.GetPlatformSdk().GetSdkFriendOnlyState();
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		return platformSdkBase != null && platformSdkBase.GetSdkFriendOnlyState();
	}

	// Token: 0x06002995 RID: 10645 RVA: 0x000FFE41 File Offset: 0x000FE041
	public bool PlayOnly()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			return PlatformSdkManagerNew.Instance.GetPlatformSdk().PlayOnly();
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		return platformSdkBase != null && platformSdkBase.PlayOnly();
	}

	// Token: 0x06002996 RID: 10646 RVA: 0x000FFE70 File Offset: 0x000FE070
	public void SaveSdkFriendOnlyState(bool state)
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			PlatformSdkManagerNew.Instance.GetPlatformSdk().SaveSdkFriendOnlyState(state);
			return;
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.SaveSdkFriendOnlyState(state);
	}

	// Token: 0x06002997 RID: 10647 RVA: 0x000FFEA0 File Offset: 0x000FE0A0
	public bool SupportSwitchFriendShowType()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			return PlatformSdkManagerNew.Instance.GetPlatformSdk().SupportSwitchFriendShowType();
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		return platformSdkBase != null && platformSdkBase.SupportSwitchFriendShowType();
	}

	// Token: 0x06002998 RID: 10648 RVA: 0x000FFECF File Offset: 0x000FE0CF
	public bool NeedShowThirdPartyId()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			return PlatformSdkManagerNew.Instance.GetPlatformSdk().NeedShowThirdPartyId();
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		return platformSdkBase != null && platformSdkBase.NeedShowThirdPartyId();
	}

	// Token: 0x06002999 RID: 10649 RVA: 0x000FFF00 File Offset: 0x000FE100
	public string CreatePlayerSession(int? id)
	{
		if (!PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			return "-1";
		}
		EPlayStationJoinAble gameJoinTypeToPlayStationJoinType = OnlineModel.Instance.GetGameJoinTypeToPlayStationJoinType();
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		if (platformSdk == null)
		{
			return null;
		}
		return platformSdk.CreatePlayerSession((int)gameJoinTypeToPlayStationJoinType, id.GetValueOrDefault());
	}

	// Token: 0x0600299A RID: 10650 RVA: 0x000FFF47 File Offset: 0x000FE147
	public void JoinPlayerSession(string playerSession)
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
			if (platformSdk == null)
			{
				return;
			}
			platformSdk.JoinPlayerSession(playerSession);
		}
	}

	// Token: 0x0600299B RID: 10651 RVA: 0x000FFF6A File Offset: 0x000FE16A
	public void SetMultiPlayerActivity(int currentPlayerCount, int maxPlayerCount, string playerSession, EXboxMultiplayerActivityJoinRestriction restriction)
	{
		if (!PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
			if (platformSdkBase == null)
			{
				return;
			}
			platformSdkBase.SetMultiPlayerActivity(currentPlayerCount, maxPlayerCount, playerSession, restriction);
		}
	}

	// Token: 0x0600299C RID: 10652 RVA: 0x000FFF8D File Offset: 0x000FE18D
	public void LeavePlayerSession()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
			if (platformSdk == null)
			{
				return;
			}
			platformSdk.LeavePlayerSession();
		}
	}

	// Token: 0x0600299D RID: 10653 RVA: 0x000FFFAF File Offset: 0x000FE1AF
	public void LeaveMultiPlayerActivity()
	{
		if (!PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
			if (platformSdkBase == null)
			{
				return;
			}
			platformSdkBase.LeaveMultiPlayerActivity();
		}
	}

	// Token: 0x0600299E RID: 10654 RVA: 0x000FFFD0 File Offset: 0x000FE1D0
	public void GetCommunicationRestricted([Nullable(2)] string accountId, Action<ESdkCommunicationRestricted> callBack)
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			PlatformSdkManagerNew.Instance.GetPlatformSdk().GetCommunicationRestricted(accountId, callBack);
			return;
		}
		if (this.PlatformSdkBase == null)
		{
			callBack(ESdkCommunicationRestricted.No);
			return;
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		callBack((platformSdkBase == null || platformSdkBase.CheckPrivilege(ESdkPrivilege.Communications)) ? ESdkCommunicationRestricted.No : ESdkCommunicationRestricted.Yes);
	}

	// Token: 0x0600299F RID: 10655 RVA: 0x0010002C File Offset: 0x000FE22C
	public bool CheckPrivilege(ESdkPrivilege privilege)
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			return true;
		}
		if (this.PlatformSdkBase == null)
		{
			return true;
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		return platformSdkBase == null || platformSdkBase.CheckPrivilege(privilege);
	}

	// Token: 0x060029A0 RID: 10656 RVA: 0x00100058 File Offset: 0x000FE258
	public string GetPlayerIdByPlayerSessionId(string playerSession)
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			return PlatformSdkManagerNew.Instance.GetPlatformSdk().GetPlayerIdByPlayerSessionId(playerSession);
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		return ((platformSdkBase != null) ? platformSdkBase.GetSessionId(playerSession) : null) ?? "-1";
	}

	// Token: 0x060029A1 RID: 10657 RVA: 0x00100093 File Offset: 0x000FE293
	public void OpenProfileCard(string id)
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.OpenProfileCard(id);
	}

	// Token: 0x060029A2 RID: 10658 RVA: 0x001000A6 File Offset: 0x000FE2A6
	public bool SupportSwitchFriendSearchByThirdPartyId()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			return PlatformSdkManagerNew.Instance.GetPlatformSdk().SupportSwitchFriendSearchByThirdPartyId();
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		return platformSdkBase != null && platformSdkBase.SupportSwitchFriendSearchByThirdPartyId();
	}

	// Token: 0x060029A3 RID: 10659 RVA: 0x001000D5 File Offset: 0x000FE2D5
	public void UpdateRecentPlayer(string[] ids)
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.UpdateRecentPlayer(ids);
	}

	// Token: 0x060029A4 RID: 10660 RVA: 0x001000E8 File Offset: 0x000FE2E8
	public bool CheckIfSingleServerAfterSelect()
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		return platformSdkBase != null && platformSdkBase.CheckIfSingleServerAfterSelect();
	}

	// Token: 0x060029A5 RID: 10661 RVA: 0x001000FC File Offset: 0x000FE2FC
	[return: Nullable(0)]
	public UniTask<bool> SaveSingleServerRegion(int loginType, string region, string userId, string userName, string token)
	{
		KuroSdkController.<SaveSingleServerRegion>d__150 <SaveSingleServerRegion>d__;
		<SaveSingleServerRegion>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<SaveSingleServerRegion>d__.<>4__this = this;
		<SaveSingleServerRegion>d__.loginType = loginType;
		<SaveSingleServerRegion>d__.region = region;
		<SaveSingleServerRegion>d__.userId = userId;
		<SaveSingleServerRegion>d__.userName = userName;
		<SaveSingleServerRegion>d__.token = token;
		<SaveSingleServerRegion>d__.<>1__state = -1;
		<SaveSingleServerRegion>d__.<>t__builder.Start<KuroSdkController.<SaveSingleServerRegion>d__150>(ref <SaveSingleServerRegion>d__);
		return <SaveSingleServerRegion>d__.<>t__builder.Task;
	}

	// Token: 0x060029A6 RID: 10662 RVA: 0x0010016C File Offset: 0x000FE36C
	private UniTask OnLogin(FLoginStruct result)
	{
		KuroSdkController.<OnLogin>d__151 <OnLogin>d__;
		<OnLogin>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnLogin>d__.<>4__this = this;
		<OnLogin>d__.result = result;
		<OnLogin>d__.<>1__state = -1;
		<OnLogin>d__.<>t__builder.Start<KuroSdkController.<OnLogin>d__151>(ref <OnLogin>d__);
		return <OnLogin>d__.<>t__builder.Task;
	}

	// Token: 0x060029A7 RID: 10663 RVA: 0x001001B8 File Offset: 0x000FE3B8
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public UniTask<string> QuerySingleServerRegion(ILoginInfo result)
	{
		KuroSdkController.<QuerySingleServerRegion>d__152 <QuerySingleServerRegion>d__;
		<QuerySingleServerRegion>d__.<>t__builder = AsyncUniTaskMethodBuilder<string>.Create();
		<QuerySingleServerRegion>d__.<>4__this = this;
		<QuerySingleServerRegion>d__.result = result;
		<QuerySingleServerRegion>d__.<>1__state = -1;
		<QuerySingleServerRegion>d__.<>t__builder.Start<KuroSdkController.<QuerySingleServerRegion>d__152>(ref <QuerySingleServerRegion>d__);
		return <QuerySingleServerRegion>d__.<>t__builder.Task;
	}

	// Token: 0x060029A8 RID: 10664 RVA: 0x00100204 File Offset: 0x000FE404
	[NullableContext(0)]
	public UniTask<ESdkCommunicationRestricted> GetUserGeneratedContentRestricted([Nullable(2)] string accountId)
	{
		KuroSdkController.<GetUserGeneratedContentRestricted>d__153 <GetUserGeneratedContentRestricted>d__;
		<GetUserGeneratedContentRestricted>d__.<>t__builder = AsyncUniTaskMethodBuilder<ESdkCommunicationRestricted>.Create();
		<GetUserGeneratedContentRestricted>d__.<>4__this = this;
		<GetUserGeneratedContentRestricted>d__.accountId = accountId;
		<GetUserGeneratedContentRestricted>d__.<>1__state = -1;
		<GetUserGeneratedContentRestricted>d__.<>t__builder.Start<KuroSdkController.<GetUserGeneratedContentRestricted>d__153>(ref <GetUserGeneratedContentRestricted>d__);
		return <GetUserGeneratedContentRestricted>d__.<>t__builder.Task;
	}

	// Token: 0x060029A9 RID: 10665 RVA: 0x0010024F File Offset: 0x000FE44F
	public void CheckPermission(string id, ESdkPermission permission, Action<bool> callback)
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.CheckPermission(id, permission, callback);
	}

	// Token: 0x060029AA RID: 10666 RVA: 0x00100264 File Offset: 0x000FE464
	public string GetExternalToken()
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		return ((platformSdkBase != null) ? platformSdkBase.GetExternalToken() : null) ?? "";
	}

	// Token: 0x060029AB RID: 10667 RVA: 0x00100284 File Offset: 0x000FE484
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public UniTask<string> GetExternalCollectionId()
	{
		KuroSdkController.<GetExternalCollectionId>d__156 <GetExternalCollectionId>d__;
		<GetExternalCollectionId>d__.<>t__builder = AsyncUniTaskMethodBuilder<string>.Create();
		<GetExternalCollectionId>d__.<>4__this = this;
		<GetExternalCollectionId>d__.<>1__state = -1;
		<GetExternalCollectionId>d__.<>t__builder.Start<KuroSdkController.<GetExternalCollectionId>d__156>(ref <GetExternalCollectionId>d__);
		return <GetExternalCollectionId>d__.<>t__builder.Task;
	}

	// Token: 0x060029AC RID: 10668 RVA: 0x001002C8 File Offset: 0x000FE4C8
	private void RefreshXboxPlayOnlyState()
	{
		if (Info.Instance.IsXboxPlatform())
		{
			bool flag = this.CheckPrivilege(ESdkPrivilege.CrossPlay);
			this.RequestChangeServerXboxPlayOnlyState(!flag);
		}
	}

	// Token: 0x17000620 RID: 1568
	// (get) Token: 0x060029AD RID: 10669 RVA: 0x001002F3 File Offset: 0x000FE4F3
	public static KuroSdkController Instance
	{
		get
		{
			return KuroSdkController._Instance;
		}
	}

	// Token: 0x060029AE RID: 10670 RVA: 0x001002FA File Offset: 0x000FE4FA
	public static KuroSdkController GetOrCreateInstance()
	{
		if (KuroSdkController._Instance == null)
		{
			KuroSdkController.CreateInstance();
		}
		return KuroSdkController._Instance;
	}

	// Token: 0x060029AF RID: 10671 RVA: 0x0010030E File Offset: 0x000FE50E
	public static bool CreateInstance()
	{
		if (KuroSdkController._Instance != null)
		{
			return true;
		}
		KuroSdkController._Instance = new KuroSdkController();
		return true;
	}

	// Token: 0x060029B0 RID: 10672 RVA: 0x00100324 File Offset: 0x000FE524
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060029B1 RID: 10673 RVA: 0x00100326 File Offset: 0x000FE526
	public static void ResetStaticDefaultValue()
	{
		KuroSdkController._Instance = null;
	}

	// Token: 0x060029B2 RID: 10674 RVA: 0x0010032E File Offset: 0x000FE52E
	static KuroSdkController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(KuroSdkController.CreateStaticDefaultValue), new Action(KuroSdkController.ResetStaticDefaultValue));
	}

	// Token: 0x04002751 RID: 10065
	private const int GACHATYPE = 1;

	// Token: 0x04002752 RID: 10066
	private const int PAYDELAY = 10000;

	// Token: 0x04002753 RID: 10067
	private const int TIMERDELAY = 1000;

	// Token: 0x04002754 RID: 10068
	private const int CHECKNOTCEREDDOTGAP = 600000;

	// Token: 0x04002755 RID: 10069
	[Nullable(2)]
	private PlatformSdkBase PlatformSdkBase;

	// Token: 0x04002756 RID: 10070
	private bool IfGlobalSdk;

	// Token: 0x04002757 RID: 10071
	private bool CurrentPostViewRedPointState;

	// Token: 0x04002758 RID: 10072
	public bool IsKick;

	// Token: 0x04002759 RID: 10073
	[Nullable(2)]
	private FAndroidScreenChangeHandler AndroidScreenChangeDelegate;

	// Token: 0x0400275A RID: 10074
	[Nullable(2)]
	private FLGUIShowVirtualKeyboard ShowKeyboardDelegate;

	// Token: 0x0400275B RID: 10075
	[Nullable(2)]
	private TimerHandle WaitPayResponseTimerId;

	// Token: 0x0400275C RID: 10076
	[Nullable(2)]
	private TimerHandle CheckQueryProductTimerId;

	// Token: 0x0400275D RID: 10077
	private bool ListenerState;

	// Token: 0x0400275E RID: 10078
	[Nullable(2)]
	private TimerHandle TickId;

	// Token: 0x0400275F RID: 10079
	[Nullable(2)]
	private TimerHandle CheckNoticeRedDotTimerId;

	// Token: 0x04002760 RID: 10080
	private bool TryInitPostWebViewState;

	// Token: 0x04002761 RID: 10081
	private bool TryInitIntroductionParamState;

	// Token: 0x04002762 RID: 10082
	[Nullable(2)]
	private static KuroSdkController _Instance;

	// Token: 0x0200662E RID: 26158
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04021DE5 RID: 138725
		[Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public static Action<string, string> <0>__OnThirdPartyJoinSessionEvent;
	}
}
