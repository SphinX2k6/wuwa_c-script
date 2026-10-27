using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02000DE3 RID: 3555
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class KuroSdkController : ControllerBase
{
	// Token: 0x06005596 RID: 21910 RVA: 0x000F685C File Offset: 0x000F4A5C
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

	// Token: 0x06005597 RID: 21911 RVA: 0x000F6940 File Offset: 0x000F4B40
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

	// Token: 0x06005598 RID: 21912 RVA: 0x000F697C File Offset: 0x000F4B7C
	private void InitTick()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			this.TickId = TimerSystem.Instance.Forever(new TTimerAction(this.SdkCheckTimer), 1000f, 1f, null, null, true);
			PlatformSdkManagerNew.Instance.GetPlatformSdk().SetTickInnerState(false);
		}
	}

	// Token: 0x06005599 RID: 21913 RVA: 0x000F69CE File Offset: 0x000F4BCE
	private void SdkCheckTimer(float delta)
	{
		this.OnTimer(delta * (float)TimeUtil.Instance.Millisecond);
	}

	// Token: 0x0600559A RID: 21914 RVA: 0x000F69E3 File Offset: 0x000F4BE3
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

	// Token: 0x0600559B RID: 21915 RVA: 0x000F6A1A File Offset: 0x000F4C1A
	private void OnTimer(float delta)
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			PlatformSdkManagerNew.Instance.GetPlatformSdk().Tick((double)delta);
		}
	}

	// Token: 0x0600559C RID: 21916 RVA: 0x000F6A39 File Offset: 0x000F4C39
	private void InitListener()
	{
		if (!this.ListenerState)
		{
			Application.Instance.AddApplicationHandler(EApplicationLifetimeDelegate.ApplicationHasReactivatedDelegate, new Action(this.ApplicationHasReactivatedDelegate));
		}
		this.ListenerState = true;
	}

	// Token: 0x0600559D RID: 21917 RVA: 0x000F6A64 File Offset: 0x000F4C64
	private void ApplicationHasReactivatedDelegate()
	{
		Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "ApplicationHasReactivatedDelegate", default(ReadOnlySpan<ValueTuple<string, object>>));
		PayItemController.Instance.RequestSdkCheckout(ECheckoutReason.StopGame);
		PlatformReportTerminateGame eventData = new PlatformReportTerminateGame();
		PlatformSdkManagerNew.Instance.GetPlatformSdk().ReportToThirdParty(eventData);
	}

	// Token: 0x0600559E RID: 21918 RVA: 0x000F6AB0 File Offset: 0x000F4CB0
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

	// Token: 0x0600559F RID: 21919 RVA: 0x000F6B39 File Offset: 0x000F4D39
	private void RemoveListener()
	{
		if (this.ListenerState)
		{
			Application.Instance.RemoveApplicationHandler(EApplicationLifetimeDelegate.ApplicationHasReactivatedDelegate, new Action(this.ApplicationHasReactivatedDelegate));
		}
		this.ListenerState = false;
	}

	// Token: 0x060055A0 RID: 21920 RVA: 0x000F6B64 File Offset: 0x000F4D64
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

	// Token: 0x060055A1 RID: 21921 RVA: 0x000F6C28 File Offset: 0x000F4E28
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

	// Token: 0x060055A2 RID: 21922 RVA: 0x000F6C88 File Offset: 0x000F4E88
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

	// Token: 0x060055A3 RID: 21923 RVA: 0x000F6DB4 File Offset: 0x000F4FB4
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

	// Token: 0x060055A4 RID: 21924 RVA: 0x000F6EDF File Offset: 0x000F50DF
	private void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.AppGradeNotify, new Action<IMessage, Net.CallbackStatus>(this.OnAppGradeNotify));
	}

	// Token: 0x060055A5 RID: 21925 RVA: 0x000F6EFD File Offset: 0x000F50FD
	private void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.AppGradeNotify);
	}

	// Token: 0x060055A6 RID: 21926 RVA: 0x000F6F0F File Offset: 0x000F510F
	private void OnQuestFinishListNotify()
	{
		KuroSdkModel instance = KuroSdkModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.UpdateActivityProgress(0);
	}

	// Token: 0x060055A7 RID: 21927 RVA: 0x000F6F24 File Offset: 0x000F5124
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

	// Token: 0x060055A8 RID: 21928 RVA: 0x000F6FA0 File Offset: 0x000F51A0
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

	// Token: 0x060055A9 RID: 21929 RVA: 0x000F6FFB File Offset: 0x000F51FB
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

	// Token: 0x060055AA RID: 21930 RVA: 0x000F701A File Offset: 0x000F521A
	private void OnWorldDoneAndCloseLoading()
	{
		this.CheckNoticeRedDot(0f);
	}

	// Token: 0x060055AB RID: 21931 RVA: 0x000F7027 File Offset: 0x000F5227
	private void OnLoadingNetDataDone()
	{
		this.RequestServerPlayOnlyState();
		this.RequestUpdatePlatformBlockAccount();
		this.RequestWebSign();
		this.RefreshXboxPlayOnlyState();
		this.TryInitIntroductionParam();
	}

	// Token: 0x060055AC RID: 21932 RVA: 0x000F7048 File Offset: 0x000F5248
	private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
	{
		if (this.PlatformSdkBase != null)
		{
			this.PlatformSdkBase.SetGamePadMode(Info.Instance.IsInGamepad());
		}
	}

	// Token: 0x060055AD RID: 21933 RVA: 0x000F7067 File Offset: 0x000F5267
	private void OnSdkRefreshNoticeRedDot()
	{
		this.CheckNoticeRedDot(0f);
	}

	// Token: 0x060055AE RID: 21934 RVA: 0x000F7074 File Offset: 0x000F5274
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

	// Token: 0x060055AF RID: 21935 RVA: 0x000F70E8 File Offset: 0x000F52E8
	private void InitNoticeCheckTimer()
	{
		bool flag = this.IfNeedPostWebViewOnClient();
		if (this.CheckNoticeRedDotTimerId == null && flag)
		{
			this.CheckNoticeRedDotTimerId = TimerSystem.Instance.Forever(new TTimerAction(this.CheckNoticeRedDot), 600000f, 1f, null, null, false);
			this.CheckNoticeRedDot(0f);
		}
	}

	// Token: 0x060055B0 RID: 21936 RVA: 0x000F713D File Offset: 0x000F533D
	private void RemoveNoticeCheckTimer()
	{
		if (this.CheckNoticeRedDotTimerId != null)
		{
			TimerSystem.Instance.Remove(this.CheckNoticeRedDotTimerId);
			this.CheckNoticeRedDotTimerId = null;
		}
	}

	// Token: 0x060055B1 RID: 21937 RVA: 0x000F715F File Offset: 0x000F535F
	private void OnSetLoginServerId()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn || (this.CanUseSdk() && this.IfGlobalSdk))
		{
			this.PostKuroSdkEvent(EKuroSdkEventKey.KUROINITIALIZEPOSTWEBVIEW);
		}
	}

	// Token: 0x060055B2 RID: 21938 RVA: 0x000F7188 File Offset: 0x000F5388
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

	// Token: 0x060055B3 RID: 21939 RVA: 0x000F73F3 File Offset: 0x000F55F3
	public bool GetIfGlobalSdk()
	{
		return this.IfGlobalSdk || (PlatformSdkManagerNew.Instance.IsSdkOn && PlatformSdkConfig.Instance.IsGlobal);
	}

	// Token: 0x060055B4 RID: 21940 RVA: 0x000F7417 File Offset: 0x000F5617
	public string GetChannelId()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			return PlatformSdkManagerNew.Instance.GetPlatformSdk().GetChannelId();
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		return ((platformSdkBase != null) ? platformSdkBase.GetChannelId() : null) ?? "";
	}

	// Token: 0x060055B5 RID: 21941 RVA: 0x000F7450 File Offset: 0x000F5650
	public string GetDeviceDid()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			return PlatformSdkManagerNew.Instance.GetPlatformSdk().GetDeviceId();
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		return ((platformSdkBase != null) ? platformSdkBase.GetDeviceDid() : null) ?? "";
	}

	// Token: 0x060055B6 RID: 21942 RVA: 0x000F7489 File Offset: 0x000F5689
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

	// Token: 0x060055B7 RID: 21943 RVA: 0x000F74B8 File Offset: 0x000F56B8
	public bool CheckIfSdkLogin()
	{
		return this.CanUseSdk() && this.GetCurrentLoginInfo().Uid != "0";
	}

	// Token: 0x060055B8 RID: 21944 RVA: 0x000F74D9 File Offset: 0x000F56D9
	public FLoginStruct GetCurrentLoginInfo()
	{
		return UKuroSDKManager.GetCurrentLoginInfo();
	}

	// Token: 0x060055B9 RID: 21945 RVA: 0x000F74E0 File Offset: 0x000F56E0
	private void ReadIfGlobalSdk()
	{
		this.IfGlobalSdk = PublicUtil.Instance.GetIfGlobalSdk();
	}

	// Token: 0x060055BA RID: 21946 RVA: 0x000F74F2 File Offset: 0x000F56F2
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

	// Token: 0x060055BB RID: 21947 RVA: 0x000F7505 File Offset: 0x000F5705
	public void TestOpenWnd()
	{
		this.SdkOpenUrlWnd("用户协议", "https://wutheringwaves.kurogame.com/p/agreement_public.html", true, true, true);
	}

	// Token: 0x060055BC RID: 21948 RVA: 0x000F751A File Offset: 0x000F571A
	public bool CanUseSdk()
	{
		return !PlatformSdkManagerNew.Instance.IsSdkOn && UKuroStaticLibrary.IsModuleLoaded("KuroSDK") && BaseConfigController.Instance.GetPublicValue("UseSDK") == "1";
	}

	// Token: 0x060055BD RID: 21949 RVA: 0x000F7550 File Offset: 0x000F5750
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

	// Token: 0x060055BE RID: 21950 RVA: 0x000F767C File Offset: 0x000F587C
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

	// Token: 0x060055BF RID: 21951 RVA: 0x000F76C1 File Offset: 0x000F58C1
	private void SdkOpenLoginWnd()
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.SdkOpenLoginWnd();
	}

	// Token: 0x060055C0 RID: 21952 RVA: 0x000F76D4 File Offset: 0x000F58D4
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

	// Token: 0x060055C1 RID: 21953 RVA: 0x000F77C1 File Offset: 0x000F59C1
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

	// Token: 0x060055C2 RID: 21954 RVA: 0x000F77EC File Offset: 0x000F59EC
	public void SdkPay(int payId, string orderId, string name, string desc, string callBackUrl)
	{
		ISDKPayment sdkPayProduct = KuroSdkControllerTool.GetSdkPayProduct(payId, orderId, name, desc, callBackUrl);
		this.SdkPay(sdkPayProduct);
	}

	// Token: 0x060055C3 RID: 21955 RVA: 0x000F7810 File Offset: 0x000F5A10
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

	// Token: 0x060055C4 RID: 21956 RVA: 0x000F78C5 File Offset: 0x000F5AC5
	public void OnSdkPayEnd(bool payResult, string str)
	{
		if (payResult && KuroSdkModel.Instance.CurrentPayItemName != "")
		{
			this.StartWaitPayItemTimer();
		}
		EventSystem.Instance.Emit<ESdkDialogResult>(EEventName.SdkPayEnd, payResult ? ESdkDialogResult.Yes : ESdkDialogResult.No);
	}

	// Token: 0x060055C5 RID: 21957 RVA: 0x000F78FA File Offset: 0x000F5AFA
	public void OpenNotice(EOpenNoticeStage stage = EOpenNoticeStage.Normal)
	{
		this.OpenPostWebView(stage);
	}

	// Token: 0x060055C6 RID: 21958 RVA: 0x000F7903 File Offset: 0x000F5B03
	public void OpenFeedback()
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.OpenFeedback();
	}

	// Token: 0x060055C7 RID: 21959 RVA: 0x000F7915 File Offset: 0x000F5B15
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

	// Token: 0x060055C8 RID: 21960 RVA: 0x000F794C File Offset: 0x000F5B4C
	public void OpenExternalUrl(string url)
	{
		PlatformSdkManagerNew.Instance.GetPlatformSdk().OpenExternalUrl(url);
	}

	// Token: 0x060055C9 RID: 21961 RVA: 0x000F7960 File Offset: 0x000F5B60
	[NullableContext(0)]
	public UniTask<bool> QueryProductByProductId([Nullable(1)] string[] productList)
	{
		KuroSdkController.<QueryProductByProductId>d__67 <QueryProductByProductId>d__;
		<QueryProductByProductId>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<QueryProductByProductId>d__.<>4__this = this;
		<QueryProductByProductId>d__.productList = productList;
		<QueryProductByProductId>d__.<>1__state = -1;
		<QueryProductByProductId>d__.<>t__builder.Start<KuroSdkController.<QueryProductByProductId>d__67>(ref <QueryProductByProductId>d__);
		return <QueryProductByProductId>d__.<>t__builder.Task;
	}

	// Token: 0x060055CA RID: 21962 RVA: 0x000F79AB File Offset: 0x000F5BAB
	public void ShareByteData(ShareData shareData, TArray<byte> data)
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.ShareByteData(shareData, data);
	}

	// Token: 0x060055CB RID: 21963 RVA: 0x000F79BF File Offset: 0x000F5BBF
	public void Share(ShareData shareData, string imagePath)
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.Share(shareData, imagePath);
	}

	// Token: 0x060055CC RID: 21964 RVA: 0x000F79D3 File Offset: 0x000F5BD3
	public void ShareTexture(ShareData shareData, string texturePath)
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.ShareTexture(shareData, texturePath);
	}

	// Token: 0x060055CD RID: 21965 RVA: 0x000F79E7 File Offset: 0x000F5BE7
	private string GetCurrentQueryChannel()
	{
		return "";
	}

	// Token: 0x060055CE RID: 21966 RVA: 0x000F79EE File Offset: 0x000F5BEE
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

	// Token: 0x060055CF RID: 21967 RVA: 0x000F7A27 File Offset: 0x000F5C27
	public void KuroSdkLoginBindFunction(Action<FLoginStruct> loginFunction)
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.KuroSdkLoginBindFunction(loginFunction);
	}

	// Token: 0x060055D0 RID: 21968 RVA: 0x000F7A3A File Offset: 0x000F5C3A
	public void KuroSdkLoginBindFunction(Action<ILoginInfo> loginFunction)
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.KuroSdkLoginBindFunction(loginFunction);
	}

	// Token: 0x060055D1 RID: 21969 RVA: 0x000F7A4D File Offset: 0x000F5C4D
	public void KuroSdkKickBindFunction()
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.KuroSdkKickBindFunction();
	}

	// Token: 0x060055D2 RID: 21970 RVA: 0x000F7A5F File Offset: 0x000F5C5F
	public void KuroSdkLogoutBindFunction(Action callback)
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.KuroSdkLogoutBindFunction(callback);
	}

	// Token: 0x060055D3 RID: 21971 RVA: 0x000F7A72 File Offset: 0x000F5C72
	public void KuroSdkPaymentBindFunction(Action<bool, string> paymentFunction)
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.KuroSdkPaymentBindFunction(paymentFunction);
	}

	// Token: 0x060055D4 RID: 21972 RVA: 0x000F7A85 File Offset: 0x000F5C85
	public void JoinSessionBindFunction(Action<string, string> callback)
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.JoinSessionBindFunction(callback);
	}

	// Token: 0x060055D5 RID: 21973 RVA: 0x000F7A98 File Offset: 0x000F5C98
	public void SetPostWebViewRedPointState(bool state)
	{
		this.CurrentPostViewRedPointState = state;
	}

	// Token: 0x060055D6 RID: 21974 RVA: 0x000F7AA1 File Offset: 0x000F5CA1
	public bool GetPostWebViewRedPointState()
	{
		if (this.IfNeedPostWebViewOnClient())
		{
			return KuroSdkModel.Instance.NoticeRedDotState;
		}
		return this.CurrentPostViewRedPointState;
	}

	// Token: 0x060055D7 RID: 21975 RVA: 0x000F7ABC File Offset: 0x000F5CBC
	public bool NeedShowCustomerService()
	{
		return ChannelController.Instance.CheckCustomerServiceOpen();
	}

	// Token: 0x060055D8 RID: 21976 RVA: 0x000F7AC8 File Offset: 0x000F5CC8
	public bool GetCustomerServiceRedPointState()
	{
		return this.PlatformSdkBase != null && this.PlatformSdkBase.GetCustomerServiceShowState();
	}

	// Token: 0x060055D9 RID: 21977 RVA: 0x000F7ADF File Offset: 0x000F5CDF
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

	// Token: 0x060055DA RID: 21978 RVA: 0x000F7B1F File Offset: 0x000F5D1F
	public bool GetIfCanQRCodeLogin()
	{
		if (!this.CanUseSdk())
		{
			return false;
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		return platformSdkBase != null && platformSdkBase.GetIsQRCodeLogin();
	}

	// Token: 0x060055DB RID: 21979 RVA: 0x000F7B3C File Offset: 0x000F5D3C
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

	// Token: 0x060055DC RID: 21980 RVA: 0x000F7B57 File Offset: 0x000F5D57
	public bool CheckPhotoPermission()
	{
		if (!this.CanUseSdk() || this.PlatformSdkBase == null)
		{
			return true;
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		return platformSdkBase == null || platformSdkBase.CheckPhotoPermission();
	}

	// Token: 0x060055DD RID: 21981 RVA: 0x000F7B7C File Offset: 0x000F5D7C
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

	// Token: 0x060055DE RID: 21982 RVA: 0x000F7B98 File Offset: 0x000F5D98
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

	// Token: 0x060055DF RID: 21983 RVA: 0x000F7BF3 File Offset: 0x000F5DF3
	public void CancelQueryProductTimer()
	{
		if (this.CheckQueryProductTimerId != null)
		{
			TimerSystem.Instance.Remove(this.CheckQueryProductTimerId);
			this.CheckQueryProductTimerId = null;
		}
	}

	// Token: 0x060055E0 RID: 21984 RVA: 0x000F7C15 File Offset: 0x000F5E15
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

	// Token: 0x060055E1 RID: 21985 RVA: 0x000F7C48 File Offset: 0x000F5E48
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

	// Token: 0x060055E2 RID: 21986 RVA: 0x000F7C94 File Offset: 0x000F5E94
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

	// Token: 0x060055E3 RID: 21987 RVA: 0x000F7D10 File Offset: 0x000F5F10
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

	// Token: 0x060055E4 RID: 21988 RVA: 0x000F7D40 File Offset: 0x000F5F40
	public UniTask RequestUpdatePlatformBlockAccount()
	{
		KuroSdkController.<RequestUpdatePlatformBlockAccount>d__94 <RequestUpdatePlatformBlockAccount>d__;
		<RequestUpdatePlatformBlockAccount>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestUpdatePlatformBlockAccount>d__.<>4__this = this;
		<RequestUpdatePlatformBlockAccount>d__.<>1__state = -1;
		<RequestUpdatePlatformBlockAccount>d__.<>t__builder.Start<KuroSdkController.<RequestUpdatePlatformBlockAccount>d__94>(ref <RequestUpdatePlatformBlockAccount>d__);
		return <RequestUpdatePlatformBlockAccount>d__.<>t__builder.Task;
	}

	// Token: 0x060055E5 RID: 21989 RVA: 0x000F7D84 File Offset: 0x000F5F84
	public void RequestChangeServerPlayStationPlayOnlyState(bool state)
	{
		PsnSettingUpdateRequest psnSettingUpdateRequest = PsnSettingUpdateRequest.Create();
		psnSettingUpdateRequest.MatchPsnUser = state;
		Net.Instance.Call(ERequestMessageId.PsnSettingUpdateRequest, psnSettingUpdateRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PsnSettingUpdateResponse psnSettingUpdateResponse = (PsnSettingUpdateResponse)msg;
			if (psnSettingUpdateResponse == null || psnSettingUpdateResponse.ErrorCode > Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(psnSettingUpdateResponse.ErrorCode, 27439, null, true, true);
				return;
			}
			KuroSdkModel.Instance.SetPlayStationPlayOnlyState(state);
		}, 0);
	}

	// Token: 0x060055E6 RID: 21990 RVA: 0x000F7DD0 File Offset: 0x000F5FD0
	public void RequestChangeServerXboxPlayOnlyState(bool state)
	{
		XboxSettingUpdateRequest xboxSettingUpdateRequest = XboxSettingUpdateRequest.Create();
		xboxSettingUpdateRequest.MatchXboxUser = state;
		Net.Instance.Call(ERequestMessageId.XboxSettingUpdateRequest, xboxSettingUpdateRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			XboxSettingUpdateResponse xboxSettingUpdateResponse = (XboxSettingUpdateResponse)msg;
			if (xboxSettingUpdateResponse == null || xboxSettingUpdateResponse.ErrorCode > Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(xboxSettingUpdateResponse.ErrorCode, 27439, null, true, true);
			}
			KuroSdkModel.Instance.SetXboxPlayOnlyState(state);
		}, 0);
	}

	// Token: 0x060055E7 RID: 21991 RVA: 0x000F7E19 File Offset: 0x000F6019
	private bool CheckIfCanOpenReviewView()
	{
		return KuroSdkModel.Instance.NeedOpenReviewState;
	}

	// Token: 0x060055E8 RID: 21992 RVA: 0x000F7E2A File Offset: 0x000F602A
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

	// Token: 0x060055E9 RID: 21993 RVA: 0x000F7E60 File Offset: 0x000F6060
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

	// Token: 0x060055EA RID: 21994 RVA: 0x000F7ECC File Offset: 0x000F60CC
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

	// Token: 0x060055EB RID: 21995 RVA: 0x000F7F1A File Offset: 0x000F611A
	public void ClientOpenReview()
	{
		KuroSdkModel.Instance.NeedOpenReviewState = true;
		KuroSdkModel.Instance.ReviewDelay = 1000;
		this.TryOpenReview();
	}

	// Token: 0x060055EC RID: 21996 RVA: 0x000F7F3C File Offset: 0x000F613C
	public void SetCursor(string path)
	{
		if (this.PlatformSdkBase != null)
		{
			this.PlatformSdkBase.SetCursor(path);
		}
	}

	// Token: 0x060055ED RID: 21997 RVA: 0x000F7F52 File Offset: 0x000F6152
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

	// Token: 0x060055EE RID: 21998 RVA: 0x000F7F8C File Offset: 0x000F618C
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

	// Token: 0x060055EF RID: 21999 RVA: 0x000F7FC6 File Offset: 0x000F61C6
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

	// Token: 0x060055F0 RID: 22000 RVA: 0x000F8000 File Offset: 0x000F6200
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

	// Token: 0x060055F1 RID: 22001 RVA: 0x000F8050 File Offset: 0x000F6250
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

	// Token: 0x060055F2 RID: 22002 RVA: 0x000F80C7 File Offset: 0x000F62C7
	private bool IfNeedPostWebViewOnClient()
	{
		return true;
	}

	// Token: 0x060055F3 RID: 22003 RVA: 0x000F80CA File Offset: 0x000F62CA
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

	// Token: 0x060055F4 RID: 22004 RVA: 0x000F80EC File Offset: 0x000F62EC
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

	// Token: 0x060055F5 RID: 22005 RVA: 0x000F812C File Offset: 0x000F632C
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

	// Token: 0x060055F6 RID: 22006 RVA: 0x000F8160 File Offset: 0x000F6360
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

	// Token: 0x060055F7 RID: 22007 RVA: 0x000F8200 File Offset: 0x000F6400
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

	// Token: 0x060055F8 RID: 22008 RVA: 0x000F8250 File Offset: 0x000F6450
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

	// Token: 0x060055F9 RID: 22009 RVA: 0x000F82AC File Offset: 0x000F64AC
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

	// Token: 0x060055FA RID: 22010 RVA: 0x000F8340 File Offset: 0x000F6540
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

	// Token: 0x060055FB RID: 22011 RVA: 0x000F83A4 File Offset: 0x000F65A4
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

	// Token: 0x060055FC RID: 22012 RVA: 0x000F8444 File Offset: 0x000F6644
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

	// Token: 0x060055FD RID: 22013 RVA: 0x000F84E2 File Offset: 0x000F66E2
	public void RecoverSdkData()
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.RecoverSdkData();
	}

	// Token: 0x060055FE RID: 22014 RVA: 0x000F84F4 File Offset: 0x000F66F4
	public void ShowExternalLogin()
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.ShowExternalLogin();
	}

	// Token: 0x060055FF RID: 22015 RVA: 0x000F8506 File Offset: 0x000F6706
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

	// Token: 0x06005600 RID: 22016 RVA: 0x000F853C File Offset: 0x000F673C
	public bool CheckIfPioneer()
	{
		string packageId = this.GetPackageId();
		return packageId != null && !(packageId == "") && CommonConfig.Instance.GetPioneerPkgIdList().Contains(packageId);
	}

	// Token: 0x06005601 RID: 22017 RVA: 0x000F8574 File Offset: 0x000F6774
	[NullableContext(0)]
	public UniTask<ESdkCommunicationRestricted> GetCommunicationRestrictedAsync([Nullable(2)] string accountId)
	{
		KuroSdkController.<GetCommunicationRestrictedAsync>d__124 <GetCommunicationRestrictedAsync>d__;
		<GetCommunicationRestrictedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<ESdkCommunicationRestricted>.Create();
		<GetCommunicationRestrictedAsync>d__.<>4__this = this;
		<GetCommunicationRestrictedAsync>d__.accountId = accountId;
		<GetCommunicationRestrictedAsync>d__.<>1__state = -1;
		<GetCommunicationRestrictedAsync>d__.<>t__builder.Start<KuroSdkController.<GetCommunicationRestrictedAsync>d__124>(ref <GetCommunicationRestrictedAsync>d__);
		return <GetCommunicationRestrictedAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005602 RID: 22018 RVA: 0x000F85C0 File Offset: 0x000F67C0
	[NullableContext(0)]
	public UniTask<bool> OpenMessageBox([Nullable(1)] string accountId, ESdkMessageBoxMode dialogMode, ESdkMessageBoxType msgType, ESdkPrivilege sdkPrivilege = ESdkPrivilege.Invalid)
	{
		KuroSdkController.<OpenMessageBox>d__125 <OpenMessageBox>d__;
		<OpenMessageBox>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenMessageBox>d__.<>4__this = this;
		<OpenMessageBox>d__.accountId = accountId;
		<OpenMessageBox>d__.dialogMode = dialogMode;
		<OpenMessageBox>d__.msgType = msgType;
		<OpenMessageBox>d__.sdkPrivilege = sdkPrivilege;
		<OpenMessageBox>d__.<>1__state = -1;
		<OpenMessageBox>d__.<>t__builder.Start<KuroSdkController.<OpenMessageBox>d__125>(ref <OpenMessageBox>d__);
		return <OpenMessageBox>d__.<>t__builder.Task;
	}

	// Token: 0x06005603 RID: 22019 RVA: 0x000F8624 File Offset: 0x000F6824
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
		KuroSdkController.<GetThirdPartyLoginInfoAsync>d__126 <GetThirdPartyLoginInfoAsync>d__;
		<GetThirdPartyLoginInfoAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<ValueTuple<string, string, string>>.Create();
		<GetThirdPartyLoginInfoAsync>d__.<>4__this = this;
		<GetThirdPartyLoginInfoAsync>d__.<>1__state = -1;
		<GetThirdPartyLoginInfoAsync>d__.<>t__builder.Start<KuroSdkController.<GetThirdPartyLoginInfoAsync>d__126>(ref <GetThirdPartyLoginInfoAsync>d__);
		return <GetThirdPartyLoginInfoAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005604 RID: 22020 RVA: 0x000F8668 File Offset: 0x000F6868
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public UniTask<Dictionary<string, bool>> GetSdkBlockingUser()
	{
		KuroSdkController.<GetSdkBlockingUser>d__127 <GetSdkBlockingUser>d__;
		<GetSdkBlockingUser>d__.<>t__builder = AsyncUniTaskMethodBuilder<Dictionary<string, bool>>.Create();
		<GetSdkBlockingUser>d__.<>4__this = this;
		<GetSdkBlockingUser>d__.<>1__state = -1;
		<GetSdkBlockingUser>d__.<>t__builder.Start<KuroSdkController.<GetSdkBlockingUser>d__127>(ref <GetSdkBlockingUser>d__);
		return <GetSdkBlockingUser>d__.<>t__builder.Task;
	}

	// Token: 0x06005605 RID: 22021 RVA: 0x000F86AB File Offset: 0x000F68AB
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

	// Token: 0x06005606 RID: 22022 RVA: 0x000F86DB File Offset: 0x000F68DB
	public bool NeedCheckPlayOnly()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			return PlatformSdkManagerNew.Instance.GetPlatformSdk().NeedCheckPlayOnly();
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		return platformSdkBase != null && platformSdkBase.NeedCheckPlayOnly();
	}

	// Token: 0x06005607 RID: 22023 RVA: 0x000F870A File Offset: 0x000F690A
	public bool GetSdkFriendOnlyState()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			return PlatformSdkManagerNew.Instance.GetPlatformSdk().GetSdkFriendOnlyState();
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		return platformSdkBase != null && platformSdkBase.GetSdkFriendOnlyState();
	}

	// Token: 0x06005608 RID: 22024 RVA: 0x000F8739 File Offset: 0x000F6939
	public bool PlayOnly()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			return PlatformSdkManagerNew.Instance.GetPlatformSdk().PlayOnly();
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		return platformSdkBase != null && platformSdkBase.PlayOnly();
	}

	// Token: 0x06005609 RID: 22025 RVA: 0x000F8768 File Offset: 0x000F6968
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

	// Token: 0x0600560A RID: 22026 RVA: 0x000F8798 File Offset: 0x000F6998
	public bool SupportSwitchFriendShowType()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			return PlatformSdkManagerNew.Instance.GetPlatformSdk().SupportSwitchFriendShowType();
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		return platformSdkBase != null && platformSdkBase.SupportSwitchFriendShowType();
	}

	// Token: 0x0600560B RID: 22027 RVA: 0x000F87C7 File Offset: 0x000F69C7
	public bool NeedShowThirdPartyId()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			return PlatformSdkManagerNew.Instance.GetPlatformSdk().NeedShowThirdPartyId();
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		return platformSdkBase != null && platformSdkBase.NeedShowThirdPartyId();
	}

	// Token: 0x0600560C RID: 22028 RVA: 0x000F87F8 File Offset: 0x000F69F8
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

	// Token: 0x0600560D RID: 22029 RVA: 0x000F883F File Offset: 0x000F6A3F
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

	// Token: 0x0600560E RID: 22030 RVA: 0x000F8862 File Offset: 0x000F6A62
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

	// Token: 0x0600560F RID: 22031 RVA: 0x000F8885 File Offset: 0x000F6A85
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

	// Token: 0x06005610 RID: 22032 RVA: 0x000F88A7 File Offset: 0x000F6AA7
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

	// Token: 0x06005611 RID: 22033 RVA: 0x000F88C8 File Offset: 0x000F6AC8
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

	// Token: 0x06005612 RID: 22034 RVA: 0x000F8924 File Offset: 0x000F6B24
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

	// Token: 0x06005613 RID: 22035 RVA: 0x000F8950 File Offset: 0x000F6B50
	public string GetPlayerIdByPlayerSessionId(string playerSession)
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			return PlatformSdkManagerNew.Instance.GetPlatformSdk().GetPlayerIdByPlayerSessionId(playerSession);
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		return ((platformSdkBase != null) ? platformSdkBase.GetSessionId(playerSession) : null) ?? "-1";
	}

	// Token: 0x06005614 RID: 22036 RVA: 0x000F898B File Offset: 0x000F6B8B
	public void OpenProfileCard(string id)
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.OpenProfileCard(id);
	}

	// Token: 0x06005615 RID: 22037 RVA: 0x000F899E File Offset: 0x000F6B9E
	public bool SupportSwitchFriendSearchByThirdPartyId()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			return PlatformSdkManagerNew.Instance.GetPlatformSdk().SupportSwitchFriendSearchByThirdPartyId();
		}
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		return platformSdkBase != null && platformSdkBase.SupportSwitchFriendSearchByThirdPartyId();
	}

	// Token: 0x06005616 RID: 22038 RVA: 0x000F89CD File Offset: 0x000F6BCD
	public void UpdateRecentPlayer(string[] ids)
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.UpdateRecentPlayer(ids);
	}

	// Token: 0x06005617 RID: 22039 RVA: 0x000F89E0 File Offset: 0x000F6BE0
	public bool CheckIfSingleServerAfterSelect()
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		return platformSdkBase != null && platformSdkBase.CheckIfSingleServerAfterSelect();
	}

	// Token: 0x06005618 RID: 22040 RVA: 0x000F89F4 File Offset: 0x000F6BF4
	[return: Nullable(0)]
	public UniTask<bool> SaveSingleServerRegion(int loginType, string region, string userId, string userName, string token)
	{
		KuroSdkController.<SaveSingleServerRegion>d__147 <SaveSingleServerRegion>d__;
		<SaveSingleServerRegion>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<SaveSingleServerRegion>d__.<>4__this = this;
		<SaveSingleServerRegion>d__.loginType = loginType;
		<SaveSingleServerRegion>d__.region = region;
		<SaveSingleServerRegion>d__.userId = userId;
		<SaveSingleServerRegion>d__.userName = userName;
		<SaveSingleServerRegion>d__.token = token;
		<SaveSingleServerRegion>d__.<>1__state = -1;
		<SaveSingleServerRegion>d__.<>t__builder.Start<KuroSdkController.<SaveSingleServerRegion>d__147>(ref <SaveSingleServerRegion>d__);
		return <SaveSingleServerRegion>d__.<>t__builder.Task;
	}

	// Token: 0x06005619 RID: 22041 RVA: 0x000F8A64 File Offset: 0x000F6C64
	private UniTask OnLogin(FLoginStruct result)
	{
		KuroSdkController.<OnLogin>d__148 <OnLogin>d__;
		<OnLogin>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnLogin>d__.<>4__this = this;
		<OnLogin>d__.result = result;
		<OnLogin>d__.<>1__state = -1;
		<OnLogin>d__.<>t__builder.Start<KuroSdkController.<OnLogin>d__148>(ref <OnLogin>d__);
		return <OnLogin>d__.<>t__builder.Task;
	}

	// Token: 0x0600561A RID: 22042 RVA: 0x000F8AB0 File Offset: 0x000F6CB0
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public UniTask<string> QuerySingleServerRegion(ILoginInfo result)
	{
		KuroSdkController.<QuerySingleServerRegion>d__149 <QuerySingleServerRegion>d__;
		<QuerySingleServerRegion>d__.<>t__builder = AsyncUniTaskMethodBuilder<string>.Create();
		<QuerySingleServerRegion>d__.<>4__this = this;
		<QuerySingleServerRegion>d__.result = result;
		<QuerySingleServerRegion>d__.<>1__state = -1;
		<QuerySingleServerRegion>d__.<>t__builder.Start<KuroSdkController.<QuerySingleServerRegion>d__149>(ref <QuerySingleServerRegion>d__);
		return <QuerySingleServerRegion>d__.<>t__builder.Task;
	}

	// Token: 0x0600561B RID: 22043 RVA: 0x000F8AFC File Offset: 0x000F6CFC
	[NullableContext(0)]
	public UniTask<ESdkCommunicationRestricted> GetUserGeneratedContentRestricted([Nullable(2)] string accountId)
	{
		KuroSdkController.<GetUserGeneratedContentRestricted>d__150 <GetUserGeneratedContentRestricted>d__;
		<GetUserGeneratedContentRestricted>d__.<>t__builder = AsyncUniTaskMethodBuilder<ESdkCommunicationRestricted>.Create();
		<GetUserGeneratedContentRestricted>d__.<>4__this = this;
		<GetUserGeneratedContentRestricted>d__.accountId = accountId;
		<GetUserGeneratedContentRestricted>d__.<>1__state = -1;
		<GetUserGeneratedContentRestricted>d__.<>t__builder.Start<KuroSdkController.<GetUserGeneratedContentRestricted>d__150>(ref <GetUserGeneratedContentRestricted>d__);
		return <GetUserGeneratedContentRestricted>d__.<>t__builder.Task;
	}

	// Token: 0x0600561C RID: 22044 RVA: 0x000F8B47 File Offset: 0x000F6D47
	public void CheckPermission(string id, ESdkPermission permission, Action<bool> callback)
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		if (platformSdkBase == null)
		{
			return;
		}
		platformSdkBase.CheckPermission(id, permission, callback);
	}

	// Token: 0x0600561D RID: 22045 RVA: 0x000F8B5C File Offset: 0x000F6D5C
	public string GetExternalToken()
	{
		PlatformSdkBase platformSdkBase = this.PlatformSdkBase;
		return ((platformSdkBase != null) ? platformSdkBase.GetExternalToken() : null) ?? "";
	}

	// Token: 0x0600561E RID: 22046 RVA: 0x000F8B7C File Offset: 0x000F6D7C
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public UniTask<string> GetExternalCollectionId()
	{
		KuroSdkController.<GetExternalCollectionId>d__153 <GetExternalCollectionId>d__;
		<GetExternalCollectionId>d__.<>t__builder = AsyncUniTaskMethodBuilder<string>.Create();
		<GetExternalCollectionId>d__.<>4__this = this;
		<GetExternalCollectionId>d__.<>1__state = -1;
		<GetExternalCollectionId>d__.<>t__builder.Start<KuroSdkController.<GetExternalCollectionId>d__153>(ref <GetExternalCollectionId>d__);
		return <GetExternalCollectionId>d__.<>t__builder.Task;
	}

	// Token: 0x0600561F RID: 22047 RVA: 0x000F8BC0 File Offset: 0x000F6DC0
	private void RefreshXboxPlayOnlyState()
	{
		if (Info.Instance.IsXboxPlatform())
		{
			bool flag = this.CheckPrivilege(ESdkPrivilege.CrossPlay);
			this.RequestChangeServerXboxPlayOnlyState(!flag);
		}
	}

	// Token: 0x170005FC RID: 1532
	// (get) Token: 0x06005620 RID: 22048 RVA: 0x000F8BEB File Offset: 0x000F6DEB
	public static KuroSdkController Instance
	{
		get
		{
			return KuroSdkController._Instance;
		}
	}

	// Token: 0x06005621 RID: 22049 RVA: 0x000F8BF2 File Offset: 0x000F6DF2
	public static KuroSdkController GetOrCreateInstance()
	{
		if (KuroSdkController._Instance == null)
		{
			KuroSdkController.CreateInstance();
		}
		return KuroSdkController._Instance;
	}

	// Token: 0x06005622 RID: 22050 RVA: 0x000F8C06 File Offset: 0x000F6E06
	public static bool CreateInstance()
	{
		if (KuroSdkController._Instance != null)
		{
			return true;
		}
		KuroSdkController._Instance = new KuroSdkController();
		return true;
	}

	// Token: 0x06005623 RID: 22051 RVA: 0x000F8C1C File Offset: 0x000F6E1C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005624 RID: 22052 RVA: 0x000F8C1E File Offset: 0x000F6E1E
	public static void ResetStaticDefaultValue()
	{
		KuroSdkController._Instance = null;
	}

	// Token: 0x06005625 RID: 22053 RVA: 0x000F8C26 File Offset: 0x000F6E26
	static KuroSdkController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(KuroSdkController.CreateStaticDefaultValue), new Action(KuroSdkController.ResetStaticDefaultValue));
	}

	// Token: 0x040026C9 RID: 9929
	private const int GACHATYPE = 1;

	// Token: 0x040026CA RID: 9930
	private const int PAYDELAY = 10000;

	// Token: 0x040026CB RID: 9931
	private const int TIMERDELAY = 1000;

	// Token: 0x040026CC RID: 9932
	private const int CHECKNOTCEREDDOTGAP = 600000;

	// Token: 0x040026CD RID: 9933
	[Nullable(2)]
	private PlatformSdkBase PlatformSdkBase;

	// Token: 0x040026CE RID: 9934
	private bool IfGlobalSdk;

	// Token: 0x040026CF RID: 9935
	private bool CurrentPostViewRedPointState;

	// Token: 0x040026D0 RID: 9936
	public bool IsKick;

	// Token: 0x040026D1 RID: 9937
	[Nullable(2)]
	private FAndroidScreenChangeHandler AndroidScreenChangeDelegate;

	// Token: 0x040026D2 RID: 9938
	[Nullable(2)]
	private FLGUIShowVirtualKeyboard ShowKeyboardDelegate;

	// Token: 0x040026D3 RID: 9939
	[Nullable(2)]
	private TimerHandle WaitPayResponseTimerId;

	// Token: 0x040026D4 RID: 9940
	[Nullable(2)]
	private TimerHandle CheckQueryProductTimerId;

	// Token: 0x040026D5 RID: 9941
	private bool ListenerState;

	// Token: 0x040026D6 RID: 9942
	[Nullable(2)]
	private TimerHandle TickId;

	// Token: 0x040026D7 RID: 9943
	[Nullable(2)]
	private TimerHandle CheckNoticeRedDotTimerId;

	// Token: 0x040026D8 RID: 9944
	private bool TryInitPostWebViewState;

	// Token: 0x040026D9 RID: 9945
	private bool TryInitIntroductionParamState;

	// Token: 0x040026DA RID: 9946
	[Nullable(2)]
	private static KuroSdkController _Instance;

	// Token: 0x0200749E RID: 29854
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04026AA6 RID: 158374
		[Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public static Action<string, string> <0>__OnThirdPartyJoinSessionEvent;
	}
}
