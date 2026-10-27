using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.InstanceDungeon.Define;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Platform.PlatformSdk;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x020022DC RID: 8924
[NullableContext(2)]
[Nullable(0)]
[TickController(0)]
public class OnlineController : UiControllerBase
{
	// Token: 0x060118AC RID: 71852 RVA: 0x0044C754 File Offset: 0x0044A954
	protected override bool OnInit()
	{
		int? intConfig = ConfigCommonParamById.GetIntConfig("netstate_push_interval");
		int inverseMillisecond = TimeUtil.Instance.InverseMillisecond;
		this.PingPushInterval = ((intConfig != null) ? new float?((float)(intConfig.GetValueOrDefault() * inverseMillisecond)) : null);
		intConfig = ConfigCommonParamById.GetIntConfig("netstate_great");
		this.NetGreatDefine = ((intConfig != null) ? new float?((float)intConfig.GetValueOrDefault()) : null);
		intConfig = ConfigCommonParamById.GetIntConfig("netstate_good");
		this.NetGoodDefine = ((intConfig != null) ? new float?((float)intConfig.GetValueOrDefault()) : null);
		intConfig = ConfigCommonParamById.GetIntConfig("netstate_weak");
		this.NetWeaktDefine = ((intConfig != null) ? new float?((float)intConfig.GetValueOrDefault()) : null);
		this.JoinSessionDelegate = DelegateUtils.ToManualReleaseDelegate<FJoinSessionCallBack>(new Action<string, string>(this.AddJoinSessionDelegate));
		UKuroStaticPS5Library.AddJoinSessionDelegate(this.JoinSessionDelegate);
		return true;
	}

	// Token: 0x060118AD RID: 71853 RVA: 0x0044C859 File Offset: 0x0044AA59
	protected override bool OnClear()
	{
		if (this.JoinSessionDelegate != null)
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<string, string>(this.AddJoinSessionDelegate));
			this.JoinSessionDelegate = null;
		}
		UKuroStaticPS5Library.ClearJoinSessionDelegate();
		return true;
	}

	// Token: 0x060118AE RID: 71854 RVA: 0x0044C884 File Offset: 0x0044AA84
	[NullableContext(1)]
	private unsafe void AddJoinSessionDelegate(string userId, string playerSession)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Login;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "PS5 PlaySession 点击加入事件触发 ";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("userId:", userId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("playerSession", playerSession);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		UKuroStaticPS5Library.ClearJoinSessionHandle();
		if (UiManager.Instance.IsViewShow(EUiViewName.LoginView) || LoadingModel.Instance.IsLoadingView || LoginModel.Instance.IsLoginStatus(LoginDefine.ELoginStatus.Init))
		{
			LoginModel.Instance.ThirdGameAutoLoginId = playerSession;
			EventSystem.Instance.Emit(EEventName.PlayStationJoinSessionEvent);
			Log.Instance.Info(ELogModule.Login, ELogAuthor.LJQ, "PS5 PlaySession 点击加入事件触发 登录或加载界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (GameModeController.Instance.IsInInstance())
		{
			Log.Instance.Info(ELogModule.Login, ELogAuthor.LJQ, "PS5 PlaySession 点击加入事件触发 副本中", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		Log.Instance.Info(ELogModule.Login, ELogAuthor.LJQ, "PS5 PlaySession 点击加入事件触发 大世界申请联机", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.TryApplyJoinWorldRequest(playerSession).Forget();
	}

	// Token: 0x060118AF RID: 71855 RVA: 0x0044C998 File Offset: 0x0044AB98
	[NullableContext(1)]
	public unsafe static void OnThirdPartyJoinSessionEvent(string userId, string playerSession)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Login;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "PS5 PlaySession 点击加入事件触发 ";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("userId:", userId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("playerSession", playerSession);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		if (!KuroSdkController.Instance.CheckPrivilege(ESdkPrivilege.UserGeneratedContent))
		{
			Log.Instance.Info(ELogModule.Chat, ELogAuthor.LJQ, "OnThirdPartyJoinSessionEvent 玩家没有UGC权限", default(ReadOnlySpan<ValueTuple<string, object>>));
			OnlineController.Instance.OpenThirdPartyMessageBox(ESdkPrivilege.UserGeneratedContent).Forget();
			return;
		}
		if (UiManager.Instance.IsViewShow(EUiViewName.LoginView) || LoadingModel.Instance.IsLoadingView || LoginModel.Instance.IsLoginStatus(LoginDefine.ELoginStatus.Init))
		{
			LoginModel.Instance.ThirdGameAutoLoginId = playerSession;
			EventSystem.Instance.Emit(EEventName.PlayStationJoinSessionEvent);
			Log.Instance.Info(ELogModule.Login, ELogAuthor.LJQ, "PS5 PlaySession 点击加入事件触发 登录或加载界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (GameModeController.Instance.IsInInstance())
		{
			Log.Instance.Info(ELogModule.Login, ELogAuthor.LJQ, "PS5 PlaySession 点击加入事件触发 副本中", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		Log.Instance.Info(ELogModule.Login, ELogAuthor.LJQ, "PS5 PlaySession 点击加入事件触发 大世界申请联机", default(ReadOnlySpan<ValueTuple<string, object>>));
		OnlineController.Instance.TryApplyJoinWorldRequest(playerSession).Forget();
	}

	// Token: 0x060118B0 RID: 71856 RVA: 0x0044CAE4 File Offset: 0x0044ACE4
	[NullableContext(1)]
	private UniTask TryApplyJoinWorldRequest(string playerSession)
	{
		OnlineController.<TryApplyJoinWorldRequest>d__19 <TryApplyJoinWorldRequest>d__;
		<TryApplyJoinWorldRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<TryApplyJoinWorldRequest>d__.<>4__this = this;
		<TryApplyJoinWorldRequest>d__.playerSession = playerSession;
		<TryApplyJoinWorldRequest>d__.<>1__state = -1;
		<TryApplyJoinWorldRequest>d__.<>t__builder.Start<OnlineController.<TryApplyJoinWorldRequest>d__19>(ref <TryApplyJoinWorldRequest>d__);
		return <TryApplyJoinWorldRequest>d__.<>t__builder.Task;
	}

	// Token: 0x060118B1 RID: 71857 RVA: 0x0044CB30 File Offset: 0x0044AD30
	private UniTask OpenThirdPartyMessageBox(ESdkPrivilege privilege)
	{
		OnlineController.<OpenThirdPartyMessageBox>d__20 <OpenThirdPartyMessageBox>d__;
		<OpenThirdPartyMessageBox>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenThirdPartyMessageBox>d__.privilege = privilege;
		<OpenThirdPartyMessageBox>d__.<>1__state = -1;
		<OpenThirdPartyMessageBox>d__.<>t__builder.Start<OnlineController.<OpenThirdPartyMessageBox>d__20>(ref <OpenThirdPartyMessageBox>d__);
		return <OpenThirdPartyMessageBox>d__.<>t__builder.Task;
	}

	// Token: 0x060118B2 RID: 71858 RVA: 0x0044CB74 File Offset: 0x0044AD74
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int>(EEventName.ScenePlayerLeaveScene, new Action<int>(this.ScenePlayerLeaveScene));
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.WorldDone));
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.WorldDoneAndCloseLoading));
		EventSystem.Instance.Add(EEventName.OnCloseLoadingView, new Action(this.OnCloseLoadingView));
		EventSystem.Instance.Add(EEventName.OnFinishLoadingState, new Action(this.OnCloseLoading));
		EventSystem.Instance.Add(EEventName.OnSetGameModeDataDone, new Action(this.OnSetGameModeDataDone));
		EventSystem.Instance.Add(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey));
		EventSystem.Instance.Add(EEventName.CsRequestJoinWorld, new Action<int, int>(this.CsRequestJoinWorld));
	}

	// Token: 0x060118B3 RID: 71859 RVA: 0x0044CC64 File Offset: 0x0044AE64
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.ScenePlayerLeaveScene, new Action<int>(this.ScenePlayerLeaveScene));
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.WorldDone));
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.WorldDoneAndCloseLoading));
		EventSystem.Instance.Remove(EEventName.OnCloseLoadingView, new Action(this.OnCloseLoadingView));
		EventSystem.Instance.Remove(EEventName.OnFinishLoadingState, new Action(this.OnCloseLoading));
		EventSystem.Instance.Remove(EEventName.OnSetGameModeDataDone, new Action(this.OnSetGameModeDataDone));
		EventSystem.Instance.Remove(EEventName.CsRequestJoinWorld, new Action<int, int>(this.CsRequestJoinWorld));
	}

	// Token: 0x060118B4 RID: 71860 RVA: 0x0044CD38 File Offset: 0x0044AF38
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.ApplyJoinWorldNotify, new Action<IMessage, Net.CallbackStatus>(this.ApplyJoinWorldNotify));
		Net.Instance.Register(ENotifyMessageId.AgreeJoinResultNotify, new Action<IMessage, Net.CallbackStatus>(this.AgreeJoinResultNotify));
		Net.Instance.Register(ENotifyMessageId.AllApplyJoinNotify, new Action<IMessage, Net.CallbackStatus>(this.AllApplyJoinNotify));
		Net.Instance.Register(ENotifyMessageId.JoinWorldTeamNotify, new Action<IMessage, Net.CallbackStatus>(this.JoinWorldTeamNotify));
		Net.Instance.Register(ENotifyMessageId.PlayerLeaveWorldTeamNotify, new Action<IMessage, Net.CallbackStatus>(this.PlayerLeaveWorldTeamNotify));
		Net.Instance.Register(ENotifyMessageId.PlayerEnterWorldTeamNotify, new Action<IMessage, Net.CallbackStatus>(this.PlayerEnterWorldTeamNotify));
		Net.Instance.Register(ENotifyMessageId.WorldTeamPlayerInfoChangeNotify, new Action<IMessage, Net.CallbackStatus>(this.WorldTeamPlayerInfoChangeNotify));
		Net.Instance.Register(ENotifyMessageId.ReceiveRechallengeNotify, new Action<IMessage, Net.CallbackStatus>(this.ReceiveRechallengeNotify));
		Net.Instance.Register(ENotifyMessageId.InviteRechallengeNotify, new Action<IMessage, Net.CallbackStatus>(this.InviteRechallengeNotify));
		Net.Instance.Register(ENotifyMessageId.ReceiveRechallengePlayerIdsNotify, new Action<IMessage, Net.CallbackStatus>(this.ReceiveRechallengePlayerIdsNotify));
		Net.Instance.Register(ENotifyMessageId.PlayerNetStateNotify, new Action<IMessage, Net.CallbackStatus>(this.PlayerNetStateNotify));
		Net.Instance.Register(ENotifyMessageId.MatchChangePlayerUiStateNotify, new Action<IMessage, Net.CallbackStatus>(this.MatchChangePlayerUiStateNotify));
		Net.Instance.Register(ENotifyMessageId.PlayerTeleportStateNotify, new Action<IMessage, Net.CallbackStatus>(this.PlayerTeleportStateNotify));
		Net.Instance.Register(ENotifyMessageId.ApplyerEnterSceneNotify, new Action<IMessage, Net.CallbackStatus>(this.ApplyerEnterSceneNotify));
		Net.Instance.Register(ENotifyMessageId.PlayerPsnSessionNotify, new Action<IMessage, Net.CallbackStatus>(this.PlayerPsnSessionNotify));
		Net.Instance.Register(ENotifyMessageId.SyncPlayerLocationNotify, new Action<IMessage, Net.CallbackStatus>(this.SyncPlayerLocationNotify));
		Net.Instance.Register(ENotifyMessageId.ClientVersionNoMatchNotify, new Action<IMessage, Net.CallbackStatus>(this.ClientVersionNoMatchNotify));
		Net.Instance.Register(ENotifyMessageId.PlayerGravityUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.PlayerGravityUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.TeamTeleportStartNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTeamTeleportStartNotify));
	}

	// Token: 0x060118B5 RID: 71861 RVA: 0x0044CF5C File Offset: 0x0044B15C
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ApplyJoinWorldNotify);
		Net.Instance.UnRegister(ENotifyMessageId.AgreeJoinResultNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PlayerLeaveWorldTeamNotify);
		Net.Instance.UnRegister(ENotifyMessageId.JoinWorldTeamNotify);
		Net.Instance.UnRegister(ENotifyMessageId.AllApplyJoinNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PlayerEnterWorldTeamNotify);
		Net.Instance.UnRegister(ENotifyMessageId.WorldTeamPlayerInfoChangeNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ReceiveRechallengeNotify);
		Net.Instance.UnRegister(ENotifyMessageId.InviteRechallengeNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ReceiveRechallengePlayerIdsNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PlayerNetStateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.MatchChangePlayerUiStateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PlayerTeleportStateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ApplyerEnterSceneNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SyncPlayerLocationNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ClientVersionNoMatchNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PlayerGravityUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TeamTeleportStartNotify);
	}

	// Token: 0x060118B6 RID: 71862 RVA: 0x0044D08C File Offset: 0x0044B28C
	private void WorldDone()
	{
		OnlineModel.Instance.SetPermissionsSetting((WorldEnterPermission)FunctionModel.Instance.GetWorldPermission().GetValueOrDefault());
		this.RefreshWorldPermissionSetting();
		OnlineModel.Instance.ClearOtherScenePlayerDataList();
	}

	// Token: 0x060118B7 RID: 71863 RVA: 0x0044D0C8 File Offset: 0x0044B2C8
	private void RefreshWorldPermissionSetting()
	{
		if (!KuroSdkController.Instance.CheckPrivilege(ESdkPrivilege.Multiplayer))
		{
			OnlineController.Instance.WorldEnterPermissionsRequest(WorldEnterPermission.ForbidJoin);
			Log.Instance.Info(ELogModule.InstanceDungeon, ELogAuthor.YZY, "通信受限，禁止加入联机", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (!KuroSdkController.Instance.CheckPrivilege(ESdkPrivilege.UserGeneratedContent))
		{
			OnlineController.Instance.WorldEnterPermissionsRequest(WorldEnterPermission.ForbidJoin);
			Log.Instance.Info(ELogModule.InstanceDungeon, ELogAuthor.YZY, "ugcPrivilege受限，禁止加入联机", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		KuroSdkController.Instance.GetCommunicationRestricted(PlayerInfoModel.Instance.GetThirdPartyAccountId(), delegate(ESdkCommunicationRestricted state)
		{
			if (state == ESdkCommunicationRestricted.Yes)
			{
				OnlineController.Instance.WorldEnterPermissionsRequest(WorldEnterPermission.ForbidJoin);
				Log.Instance.Info(ELogModule.InstanceDungeon, ELogAuthor.YZY, "通信受限，禁止加入联机", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		});
	}

	// Token: 0x060118B8 RID: 71864 RVA: 0x0044D174 File Offset: 0x0044B374
	private void WorldDoneAndCloseLoading()
	{
		string thirdGameAutoLoginId = LoginModel.Instance.ThirdGameAutoLoginId;
		if (thirdGameAutoLoginId != "-1")
		{
			this.TryApplyJoinWorldRequest(thirdGameAutoLoginId).ContinueWith(delegate()
			{
				LoginModel.Instance.ThirdGameAutoLoginId = "-1";
			}).Forget();
		}
		if (this.NoMatchType != null)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(this.GetConfirmBoxIdByNoMatchType());
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			this.NoMatchType = null;
		}
		if (this.SingleOnlineTipsHandle)
		{
			this.ShowOnlineModeTips();
			this.SingleOnlineTipsHandle = false;
		}
		this.RefreshSingleConfirm();
	}

	// Token: 0x060118B9 RID: 71865 RVA: 0x0044D215 File Offset: 0x0044B415
	private EConfirmBoxConfigId GetConfirmBoxIdByNoMatchType()
	{
		if (this.NoMatchType.GetValueOrDefault() == TeamType.MatchTeam)
		{
			return EConfirmBoxConfigId.ClientVersionNoMatchTeam;
		}
		return EConfirmBoxConfigId.ClientVersionNoMatchOnline;
	}

	// Token: 0x060118BA RID: 71866 RVA: 0x0044D230 File Offset: 0x0044B430
	private void OnCloseLoadingView()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn && GameModeModel.Instance.IsMulti)
		{
			if (this.NotifyPlayStationPremiumTimer != null)
			{
				this.NotifyPlayStationPremiumTimer.Remove();
				this.NotifyPlayStationPremiumTimer = null;
			}
			this.NotifyPlayStationPremiumTimer = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
			{
				this.NotifyPlayStationPremium();
			}, this.NOTIFY_PLAYSTATION_CD, 1f, null, null, true);
		}
	}

	// Token: 0x060118BB RID: 71867 RVA: 0x0044D29C File Offset: 0x0044B49C
	private void ScenePlayerLeaveScene(int playerId)
	{
		if (!GameModeController.Instance.IsInInstance())
		{
			return;
		}
		OnlineModel.Instance.SetContinuingChallengeConfirmState(playerId, EContinuingChallenge.Leave);
		OnlineModel.Instance.SetAllowInitiate(false);
		EventSystem.Instance.Emit<int, EContinuingChallenge>(EEventName.PlayerChallengeStateChange, playerId, EContinuingChallenge.Leave);
		EventSystem.Instance.Emit(EEventName.OnRefreshOnlineChallengePlayer);
		if (InstanceDungeonModel.Instance.InstanceFinishSuccess != EInstanceFinishState.Success)
		{
			this.HandleTips = "OnlineSomeOneLeaveInstance";
			return;
		}
		ScrollingTipsController.Instance.ShowTipsByTextId("OnlineSomeOneLeaveInstance", Array.Empty<object>());
	}

	// Token: 0x060118BC RID: 71868 RVA: 0x0044D31C File Offset: 0x0044B51C
	private void OnCloseLoading()
	{
		if (this.TipsCache == null)
		{
			return;
		}
		ScrollingTipsController.Instance.ShowTipsById(this.TipsCache[0].Value.Item1, this.TipsCache[0].Value.Item2);
		this.TipsCache = null;
	}

	// Token: 0x060118BD RID: 71869 RVA: 0x0044D36F File Offset: 0x0044B56F
	private void OnSetGameModeDataDone()
	{
		if (this.IsFirstSetMode)
		{
			this.IsFirstSetMode = false;
			if (GameModeModel.Instance.IsMulti)
			{
				OnlineController.Instance.CheckPlatformCanopen();
			}
		}
	}

	// Token: 0x060118BE RID: 71870 RVA: 0x0044D397 File Offset: 0x0044B597
	[NullableContext(1)]
	private void OnInputAnyKey(bool bPress, FKey key)
	{
		LoginModel.Instance.ThirdGameAutoLoginId = "-1";
		EventSystem.Instance.Remove(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey));
	}

	// Token: 0x060118BF RID: 71871 RVA: 0x0044D3C4 File Offset: 0x0044B5C4
	[NullableContext(0)]
	public UniTask<bool> RefreshWorldList()
	{
		OnlineController.<RefreshWorldList>d__36 <RefreshWorldList>d__;
		<RefreshWorldList>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RefreshWorldList>d__.<>4__this = this;
		<RefreshWorldList>d__.<>1__state = -1;
		<RefreshWorldList>d__.<>t__builder.Start<OnlineController.<RefreshWorldList>d__36>(ref <RefreshWorldList>d__);
		return <RefreshWorldList>d__.<>t__builder.Task;
	}

	// Token: 0x060118C0 RID: 71872 RVA: 0x0044D408 File Offset: 0x0044B608
	protected override void OnTick(float delta)
	{
		if (!GameModeModel.Instance.WorldDone || !GameModeModel.Instance.IsMulti)
		{
			return;
		}
		float? lastPingPush = this.LastPingPush;
		float? pingPushInterval = this.PingPushInterval;
		if (lastPingPush.GetValueOrDefault() > pingPushInterval.GetValueOrDefault() & (lastPingPush != null & pingPushInterval != null))
		{
			this.LastPingPush -= this.PingPushInterval.Value;
			this.PlayerNetStatePush();
		}
		this.LastPingPush += delta;
	}

	// Token: 0x060118C1 RID: 71873 RVA: 0x0044D4D0 File Offset: 0x0044B6D0
	[NullableContext(0)]
	public UniTask<bool> LobbyListRequest(bool isFriend)
	{
		OnlineController.<LobbyListRequest>d__38 <LobbyListRequest>d__;
		<LobbyListRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<LobbyListRequest>d__.<>4__this = this;
		<LobbyListRequest>d__.isFriend = isFriend;
		<LobbyListRequest>d__.<>1__state = -1;
		<LobbyListRequest>d__.<>t__builder.Start<OnlineController.<LobbyListRequest>d__38>(ref <LobbyListRequest>d__);
		return <LobbyListRequest>d__.<>t__builder.Task;
	}

	// Token: 0x060118C2 RID: 71874 RVA: 0x0044D51C File Offset: 0x0044B71C
	[NullableContext(1)]
	private UniTask OnLobbyListRequest(LobbyListResponse response, bool isFriend)
	{
		OnlineController.<OnLobbyListRequest>d__39 <OnLobbyListRequest>d__;
		<OnLobbyListRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnLobbyListRequest>d__.response = response;
		<OnLobbyListRequest>d__.isFriend = isFriend;
		<OnLobbyListRequest>d__.<>1__state = -1;
		<OnLobbyListRequest>d__.<>t__builder.Start<OnlineController.<OnLobbyListRequest>d__39>(ref <OnLobbyListRequest>d__);
		return <OnLobbyListRequest>d__.<>t__builder.Task;
	}

	// Token: 0x060118C3 RID: 71875 RVA: 0x0044D568 File Offset: 0x0044B768
	public void WorldEnterPermissionsRequest(WorldEnterPermission type)
	{
		WorldEnterPermissionsRequest worldEnterPermissionsRequest = Aki.Protocol.WorldEnterPermissionsRequest.Create();
		worldEnterPermissionsRequest.Type = type;
		Net.Instance.Call(ERequestMessageId.WorldEnterPermissionsRequest, worldEnterPermissionsRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			WorldEnterPermissionsResponse worldEnterPermissionsResponse = (WorldEnterPermissionsResponse)msg;
			if (worldEnterPermissionsResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(worldEnterPermissionsResponse.ErrorCode, 26732, null, true, true);
				return;
			}
			OnlineModel.Instance.SetPermissionsSetting(worldEnterPermissionsResponse.Type);
			EventSystem.Instance.Emit(EEventName.OnRefreshPermissionsSetting);
		}, 0);
	}

	// Token: 0x060118C4 RID: 71876 RVA: 0x0044D5B4 File Offset: 0x0044B7B4
	public void ApplyJoinWorldRequest(int worldId, WorldEnterWay entryWay)
	{
		if (!GameModeModel.Instance.IsMulti && !OnlineController.Instance.CheckPlatformCanopen())
		{
			return;
		}
		if (!SubPackageDownLoadModel.Instance.CheckOnlineHaveSubPackage())
		{
			return;
		}
		ApplyJoinWorldRequest applyJoinWorldRequest = Aki.Protocol.ApplyJoinWorldRequest.Create();
		applyJoinWorldRequest.PlayerId = worldId;
		applyJoinWorldRequest.Ways = entryWay;
		Net.Instance.Call(ERequestMessageId.ApplyJoinWorldRequest, applyJoinWorldRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ApplyJoinWorldResponse applyJoinWorldResponse = (ApplyJoinWorldResponse)msg;
			if (applyJoinWorldResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(applyJoinWorldResponse.ErrorCode, 24536, applyJoinWorldResponse.ErrorParams.ToArray<string>(), true, true);
			}
		}, 0);
	}

	// Token: 0x060118C5 RID: 71877 RVA: 0x0044D62C File Offset: 0x0044B82C
	private bool CheckTowerViewIfOpen()
	{
		return UiManager.Instance.IsViewOpen(EUiViewName.CycleTowerView) || UiManager.Instance.IsViewOpen(EUiViewName.CycleTowerChallengeView) || UiManager.Instance.IsViewOpen(EUiViewName.CycleTowerTeamView) || (UiManager.Instance.IsViewOpen(EUiViewName.SingleTimeTowerView) || UiManager.Instance.IsViewOpen(EUiViewName.SingleTimeTowerChallengeView) || UiManager.Instance.IsViewOpen(EUiViewName.SingleTimeTowerTeamView));
	}

	// Token: 0x060118C6 RID: 71878 RVA: 0x0044D6A4 File Offset: 0x0044B8A4
	public void ApplyJoinWorldNotify(IMessage msg, Net.CallbackStatus status)
	{
		ApplyJoinWorldNotify message = (ApplyJoinWorldNotify)msg;
		this.OnApplyJoinNotify(message).Forget();
	}

	// Token: 0x060118C7 RID: 71879 RVA: 0x0044D6C4 File Offset: 0x0044B8C4
	[NullableContext(1)]
	private UniTask OnApplyJoinNotify(ApplyJoinWorldNotify message)
	{
		OnlineController.<OnApplyJoinNotify>d__44 <OnApplyJoinNotify>d__;
		<OnApplyJoinNotify>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnApplyJoinNotify>d__.<>4__this = this;
		<OnApplyJoinNotify>d__.message = message;
		<OnApplyJoinNotify>d__.<>1__state = -1;
		<OnApplyJoinNotify>d__.<>t__builder.Start<OnlineController.<OnApplyJoinNotify>d__44>(ref <OnApplyJoinNotify>d__);
		return <OnApplyJoinNotify>d__.<>t__builder.Task;
	}

	// Token: 0x060118C8 RID: 71880 RVA: 0x0044D710 File Offset: 0x0044B910
	public void AgreeJoinResultNotify(IMessage msg, Net.CallbackStatus status)
	{
		AgreeJoinResultNotify agreeJoinResultNotify = (AgreeJoinResultNotify)msg;
		if (agreeJoinResultNotify.ErrorCode != Aki.Protocol.ErrorCode.Success)
		{
			ScrollingTipsController.Instance.ShowTipsById("ApplyRefused", new object[]
			{
				agreeJoinResultNotify.PlayerName
			});
			return;
		}
		this.TipsCache = new ValueTuple<string, object[]>?[1];
		this.TipsCache[0] = new ValueTuple<string, object[]>?(new ValueTuple<string, object[]>("EnteringOtherWorld", new object[]
		{
			agreeJoinResultNotify.PlayerName
		}));
	}

	// Token: 0x060118C9 RID: 71881 RVA: 0x0044D784 File Offset: 0x0044B984
	public void AllApplyJoinNotify(IMessage msg, Net.CallbackStatus status)
	{
		AllApplyJoinNotify message = (AllApplyJoinNotify)msg;
		this.OnAllApplyJoinNotify(message).Forget();
	}

	// Token: 0x060118CA RID: 71882 RVA: 0x0044D7A4 File Offset: 0x0044B9A4
	[NullableContext(1)]
	public UniTask OnAllApplyJoinNotify(AllApplyJoinNotify message)
	{
		OnlineController.<OnAllApplyJoinNotify>d__47 <OnAllApplyJoinNotify>d__;
		<OnAllApplyJoinNotify>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnAllApplyJoinNotify>d__.message = message;
		<OnAllApplyJoinNotify>d__.<>1__state = -1;
		<OnAllApplyJoinNotify>d__.<>t__builder.Start<OnlineController.<OnAllApplyJoinNotify>d__47>(ref <OnAllApplyJoinNotify>d__);
		return <OnAllApplyJoinNotify>d__.<>t__builder.Task;
	}

	// Token: 0x060118CB RID: 71883 RVA: 0x0044D7E8 File Offset: 0x0044B9E8
	public void LobbyQueryPlayersRequest(int playerId)
	{
		LobbyQueryPlayersRequest lobbyQueryPlayersRequest = Aki.Protocol.LobbyQueryPlayersRequest.Create();
		lobbyQueryPlayersRequest.PlayerId = playerId;
		Net.Instance.Call(ERequestMessageId.LobbyQueryPlayersRequest, lobbyQueryPlayersRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			LobbyQueryPlayersResponse response = (LobbyQueryPlayersResponse)msg;
			this.OnQueryPlayersResponse(response, playerId).Forget();
		}, 0);
	}

	// Token: 0x060118CC RID: 71884 RVA: 0x0044D838 File Offset: 0x0044BA38
	[NullableContext(1)]
	private UniTask OnQueryPlayersResponse(LobbyQueryPlayersResponse response, int playerId)
	{
		OnlineController.<OnQueryPlayersResponse>d__49 <OnQueryPlayersResponse>d__;
		<OnQueryPlayersResponse>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnQueryPlayersResponse>d__.response = response;
		<OnQueryPlayersResponse>d__.playerId = playerId;
		<OnQueryPlayersResponse>d__.<>1__state = -1;
		<OnQueryPlayersResponse>d__.<>t__builder.Start<OnlineController.<OnQueryPlayersResponse>d__49>(ref <OnQueryPlayersResponse>d__);
		return <OnQueryPlayersResponse>d__.<>t__builder.Task;
	}

	// Token: 0x060118CD RID: 71885 RVA: 0x0044D884 File Offset: 0x0044BA84
	public void AgreeJoinResultRequest(int applyPlayerId, bool result)
	{
		if (result && !GameModeModel.Instance.IsMulti && !OnlineController.Instance.CheckPlatformCanopen())
		{
			return;
		}
		if (!SubPackageDownLoadModel.Instance.CheckOnlineHaveSubPackage())
		{
			return;
		}
		AgreeJoinResultRequest agreeJoinResultRequest = Aki.Protocol.AgreeJoinResultRequest.Create();
		agreeJoinResultRequest.PlayerId = applyPlayerId;
		agreeJoinResultRequest.Result = result;
		Net.Instance.Call(ERequestMessageId.AgreeJoinResultRequest, agreeJoinResultRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			AgreeJoinResultResponse agreeJoinResultResponse = (AgreeJoinResultResponse)msg;
			if (agreeJoinResultResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(agreeJoinResultResponse.ErrorCode, 19703, null, true, true);
				return;
			}
			OnlineModel.Instance.DeleteCurrentApplyListById(applyPlayerId);
			EventSystem.Instance.Emit(EEventName.OnRefreshApply);
		}, 0);
	}

	// Token: 0x060118CE RID: 71886 RVA: 0x0044D900 File Offset: 0x0044BB00
	public void MatchChangePlayerUiStateRequest(EMatchPlayerUiState matchUiState)
	{
		MatchChangePlayerUiStateRequest matchChangePlayerUiStateRequest = Aki.Protocol.MatchChangePlayerUiStateRequest.Create();
		matchChangePlayerUiStateRequest.MatchUiState = matchUiState;
		Net.Instance.Call(ERequestMessageId.MatchChangePlayerUiStateRequest, matchChangePlayerUiStateRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			MatchChangePlayerUiStateResponse matchChangePlayerUiStateResponse = (MatchChangePlayerUiStateResponse)msg;
			if (matchChangePlayerUiStateResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(matchChangePlayerUiStateResponse.ErrorCode, 19703, null, true, true);
				return;
			}
			int value = PlayerInfoModel.Instance.GetId().Value;
			InstanceDungeonModel.Instance.SetPlayerUiState(value, matchUiState);
		}, 0);
	}

	// Token: 0x060118CF RID: 71887 RVA: 0x0044D94C File Offset: 0x0044BB4C
	public void JoinWorldTeamNotify(IMessage msg, Net.CallbackStatus status)
	{
		JoinWorldTeamNotify message = (JoinWorldTeamNotify)msg;
		this.OnJoinWorldTeamNotify(message).Forget();
	}

	// Token: 0x060118D0 RID: 71888 RVA: 0x0044D96C File Offset: 0x0044BB6C
	[NullableContext(1)]
	private UniTask OnJoinWorldTeamNotify(JoinWorldTeamNotify message)
	{
		OnlineController.<OnJoinWorldTeamNotify>d__53 <OnJoinWorldTeamNotify>d__;
		<OnJoinWorldTeamNotify>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnJoinWorldTeamNotify>d__.<>4__this = this;
		<OnJoinWorldTeamNotify>d__.message = message;
		<OnJoinWorldTeamNotify>d__.<>1__state = -1;
		<OnJoinWorldTeamNotify>d__.<>t__builder.Start<OnlineController.<OnJoinWorldTeamNotify>d__53>(ref <OnJoinWorldTeamNotify>d__);
		return <OnJoinWorldTeamNotify>d__.<>t__builder.Task;
	}

	// Token: 0x060118D1 RID: 71889 RVA: 0x0044D9B8 File Offset: 0x0044BBB8
	public void PlayerLeaveWorldTeamNotify(IMessage msg, Net.CallbackStatus status)
	{
		PlayerLeaveWorldTeamNotify playerLeaveWorldTeamNotify = (PlayerLeaveWorldTeamNotify)msg;
		int playerId = playerLeaveWorldTeamNotify.PlayerId;
		OnlineTeamData currentTeamListById = OnlineModel.Instance.GetCurrentTeamListById(playerId);
		if (currentTeamListById.IsSelf)
		{
			if (!GameModeModel.Instance.WorldDone)
			{
				Log.Instance.Info(ELogModule.Formation, ELogAuthor.LJQ, "离开队伍时世界未加载完成", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.ShowBackLoginConfirmBox();
				return;
			}
			if (UiManager.Instance.IsViewOpen(EUiViewName.OnlineWorldHallView))
			{
				UiManager.Instance.CloseView(EUiViewName.OnlineWorldHallView, null);
			}
			if (playerId != OnlineModel.Instance.OwnerId)
			{
				if (playerLeaveWorldTeamNotify.Reason == WorldTeamLeaveReason.Dissolve)
				{
					this.TipsCache = new ValueTuple<string, object[]>?[1];
					this.TipsCache[0] = new ValueTuple<string, object[]>?(new ValueTuple<string, object[]>("LeaderExitOnlineTeam", new object[]
					{
						currentTeamListById.Name
					}));
				}
				else
				{
					this.TipsCache = new ValueTuple<string, object[]>?[1];
					this.TipsCache[0] = new ValueTuple<string, object[]>?(new ValueTuple<string, object[]>("OnlineSimulationPassiveExit", new object[0]));
				}
			}
			OnlineModel.Instance.SetTeamOwnerId(-1);
			OnlineModel.Instance.ClearOnlineTeamMap();
			OnlineModel.Instance.ClearPlayerTeleportState();
			OnlineModel.Instance.ClearWorldTeamPlayerFightInfo();
			OnlineModel.Instance.ClearOtherScenePlayerDataList();
			this.HaveSingleConfirm = false;
			this.ClearOnlineTipsTimer();
			this.ClearOnlineConfirmTimer();
			this.LeavePlayerSession();
			EventSystem.Instance.Emit(EEventName.OnLeaveOnlineWorld);
		}
		else
		{
			ScrollingTipsController.Instance.ShowTipsById("ExitOnlineTeam", new object[]
			{
				currentTeamListById.Name
			});
			OnlineModel.Instance.ResetTeamDataPlayer(currentTeamListById.PlayerNumber);
			OnlineModel.Instance.DeleteCurrentTeamListById(playerId);
			OnlineModel.Instance.DeleteWorldTeamPlayerFightInfo(playerId);
			OnlineModel.Instance.DeleteOtherScenePlayerDataList(playerId);
			OnlineModel.Instance.DeletePlayerTeleportState(playerId);
		}
		this.RefreshSingleConfirm();
		EventSystem.Instance.Emit(EEventName.OnRefreshOnlineTeamList);
	}

	// Token: 0x060118D2 RID: 71890 RVA: 0x0044DB84 File Offset: 0x0044BD84
	public void PlayerEnterWorldTeamNotify(IMessage msg, Net.CallbackStatus status)
	{
		PlayerEnterWorldTeamNotify message = (PlayerEnterWorldTeamNotify)msg;
		this.OnPlayerEnterWorldTeamNotify(message).Forget();
	}

	// Token: 0x060118D3 RID: 71891 RVA: 0x0044DBA4 File Offset: 0x0044BDA4
	[NullableContext(1)]
	private UniTask OnPlayerEnterWorldTeamNotify(PlayerEnterWorldTeamNotify message)
	{
		OnlineController.<OnPlayerEnterWorldTeamNotify>d__56 <OnPlayerEnterWorldTeamNotify>d__;
		<OnPlayerEnterWorldTeamNotify>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayerEnterWorldTeamNotify>d__.message = message;
		<OnPlayerEnterWorldTeamNotify>d__.<>1__state = -1;
		<OnPlayerEnterWorldTeamNotify>d__.<>t__builder.Start<OnlineController.<OnPlayerEnterWorldTeamNotify>d__56>(ref <OnPlayerEnterWorldTeamNotify>d__);
		return <OnPlayerEnterWorldTeamNotify>d__.<>t__builder.Task;
	}

	// Token: 0x060118D4 RID: 71892 RVA: 0x0044DBE8 File Offset: 0x0044BDE8
	public void WorldTeamPlayerInfoChangeNotify(IMessage msg, Net.CallbackStatus status)
	{
		WorldTeamPlayerInfoChangeNotify worldTeamPlayerInfoChangeNotify = (WorldTeamPlayerInfoChangeNotify)msg;
		OnlineTeamData currentTeamListById = OnlineModel.Instance.GetCurrentTeamListById(worldTeamPlayerInfoChangeNotify.PlayerId);
		if (currentTeamListById == null)
		{
			return;
		}
		switch (worldTeamPlayerInfoChangeNotify.ChangeType)
		{
		case WorldTeamPlayerChangeType.Name:
			currentTeamListById.Name = worldTeamPlayerInfoChangeNotify.StringValue;
			break;
		case WorldTeamPlayerChangeType.Head:
			currentTeamListById.HeadId = worldTeamPlayerInfoChangeNotify.IntValue;
			break;
		case WorldTeamPlayerChangeType.Level:
			currentTeamListById.Level = worldTeamPlayerInfoChangeNotify.IntValue;
			break;
		case WorldTeamPlayerChangeType.Signature:
			currentTeamListById.Signature = worldTeamPlayerInfoChangeNotify.StringValue;
			break;
		case WorldTeamPlayerChangeType.PlayerTitle:
			currentTeamListById.SetPlayerTitleInfo(worldTeamPlayerInfoChangeNotify.StringValue);
			break;
		case WorldTeamPlayerChangeType.Sex:
			currentTeamListById.Sex = worldTeamPlayerInfoChangeNotify.IntValue;
			break;
		}
		EventSystem.Instance.Emit(EEventName.OnRefreshOnlineTeamList);
		EventSystem.Instance.Emit<WorldTeamPlayerInfoChangeNotify>(EEventName.OnWorldTeamPlayerInfoChanged, worldTeamPlayerInfoChangeNotify);
	}

	// Token: 0x060118D5 RID: 71893 RVA: 0x0044DCAC File Offset: 0x0044BEAC
	public void ReceiveRechallengeNotify(IMessage msg, Net.CallbackStatus status)
	{
		ReceiveRechallengeNotify receiveRechallengeNotify = (ReceiveRechallengeNotify)msg;
		int playerId = receiveRechallengeNotify.PlayerId;
		if (receiveRechallengeNotify.Result != ERechallengeResultResult.Accept)
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.OnlineChallengeStateView))
			{
				UiManager.Instance.CloseView(EUiViewName.OnlineChallengeStateView, null);
			}
			int num = playerId;
			PlayerInfoModel instance = PlayerInfoModel.Instance;
			int? num2 = (instance != null) ? instance.GetId() : null;
			if (!(num == num2.GetValueOrDefault() & num2 != null))
			{
				string name = OnlineModel.Instance.GetCurrentTeamListById(playerId).Name;
				ScrollingTipsController.Instance.ShowTipsById("RefuseInviteMatch", new object[]
				{
					name
				});
			}
			return;
		}
		OnlineModel.Instance.SetContinuingChallengeConfirmState(playerId, EContinuingChallenge.Accept);
		EventSystem.Instance.Emit(EEventName.OnRefreshOnlineChallengePlayer);
		int? id = PlayerInfoModel.Instance.GetId();
		if (playerId == OnlineModel.Instance.OwnerId)
		{
			EContinuingChallenge? continuingChallengeConfirmState = OnlineModel.Instance.GetContinuingChallengeConfirmState(id.Value);
			EContinuingChallenge econtinuingChallenge = EContinuingChallenge.Accept;
			if (continuingChallengeConfirmState.GetValueOrDefault() == econtinuingChallenge & continuingChallengeConfirmState != null)
			{
				UiManager.Instance.OpenView(EUiViewName.OnlineChallengeStateView, null, null);
			}
		}
		EventSystem.Instance.Emit<int, EContinuingChallenge>(EEventName.PlayerChallengeStateChange, playerId, EContinuingChallenge.Accept);
	}

	// Token: 0x060118D6 RID: 71894 RVA: 0x0044DDCC File Offset: 0x0044BFCC
	public void InviteRechallengeNotify(IMessage msg, Net.CallbackStatus status)
	{
		InviteRechallengeNotify inviteRechallengeNotify = (InviteRechallengeNotify)msg;
		EContinuingChallenge? continuingChallengeConfirmState = OnlineModel.Instance.GetContinuingChallengeConfirmState(PlayerInfoModel.Instance.GetId().Value);
		EventSystem.Instance.Emit(EEventName.OnRefreshOnlineChallengePlayer);
		EContinuingChallenge? econtinuingChallenge = continuingChallengeConfirmState;
		EContinuingChallenge econtinuingChallenge2 = EContinuingChallenge.Accept;
		if ((econtinuingChallenge.GetValueOrDefault() == econtinuingChallenge2 & econtinuingChallenge != null) && OnlineModel.Instance.GetIsMyTeam())
		{
			return;
		}
		OnlineModel.Instance.SetChallengeApplyPlayerId(inviteRechallengeNotify.InviterPlayerId);
		if (!UiManager.Instance.IsViewOpen(EUiViewName.OnlineChallengeStateView))
		{
			if (!UiManager.Instance.IsViewOpen(EUiViewName.OnlineChallengeApplyView))
			{
				UiManager.Instance.OpenView(EUiViewName.OnlineChallengeApplyView, null, null);
				return;
			}
			EventSystem.Instance.Emit(EEventName.OnRefreshSuggestChallengePlayerInfo);
		}
	}

	// Token: 0x060118D7 RID: 71895 RVA: 0x0044DE84 File Offset: 0x0044C084
	public void ReceiveRechallengePlayerIdsNotify(IMessage msg, Net.CallbackStatus status)
	{
		ReceiveRechallengePlayerIdsNotify receiveRechallengePlayerIdsNotify = (ReceiveRechallengePlayerIdsNotify)msg;
		OnlineModel.Instance.ResetContinuingChallengeConfirmState();
		foreach (int playerId in receiveRechallengePlayerIdsNotify.PlayerIds)
		{
			OnlineModel.Instance.SetContinuingChallengeConfirmState(playerId, EContinuingChallenge.Accept);
			EventSystem.Instance.Emit(EEventName.OnRefreshOnlineChallengePlayer);
		}
	}

	// Token: 0x060118D8 RID: 71896 RVA: 0x0044DEF8 File Offset: 0x0044C0F8
	public void PlayerNetStateNotify(IMessage msg, Net.CallbackStatus status)
	{
		PlayerNetStateNotify playerNetStateNotify = (PlayerNetStateNotify)msg;
		OnlineTeamData currentTeamListById = OnlineModel.Instance.GetCurrentTeamListById(playerNetStateNotify.PlayerId);
		if (currentTeamListById == null)
		{
			return;
		}
		currentTeamListById.PingState = playerNetStateNotify.PingState;
		EventSystem.Instance.Emit<int, ENetPingState>(EEventName.OnRefreshPlayerPing, playerNetStateNotify.PlayerId, currentTeamListById.PingState);
	}

	// Token: 0x060118D9 RID: 71897 RVA: 0x0044DF4C File Offset: 0x0044C14C
	public bool CheckPlayerNetHealthy(int playerId)
	{
		int? id = PlayerInfoModel.Instance.GetId();
		if (id.GetValueOrDefault() == playerId & id != null)
		{
			ENetPingState netPingState = this.GetNetPingState(Net.Instance.RttMs);
			return this.IsNetStateGood(netPingState);
		}
		OnlineTeamData currentTeamListById = OnlineModel.Instance.GetCurrentTeamListById(playerId);
		return currentTeamListById != null && this.IsNetStateGood(currentTeamListById.PingState);
	}

	// Token: 0x060118DA RID: 71898 RVA: 0x0044DFB0 File Offset: 0x0044C1B0
	public bool IsNetStateGood(ENetPingState pingState)
	{
		return pingState == ENetPingState.Great || pingState == ENetPingState.Good;
	}

	// Token: 0x060118DB RID: 71899 RVA: 0x0044DFBC File Offset: 0x0044C1BC
	public void MatchChangePlayerUiStateNotify(IMessage msg, Net.CallbackStatus status)
	{
		MatchChangePlayerUiStateNotify matchChangePlayerUiStateNotify = (MatchChangePlayerUiStateNotify)msg;
		InstanceDungeonModel.Instance.SetPlayerUiState(matchChangePlayerUiStateNotify.PlayerId, matchChangePlayerUiStateNotify.MatchUiState);
	}

	// Token: 0x060118DC RID: 71900 RVA: 0x0044DFE8 File Offset: 0x0044C1E8
	public void PlayerTeleportStateNotify(IMessage msg, Net.CallbackStatus status)
	{
		PlayerTeleportStateNotify playerTeleportStateNotify = (PlayerTeleportStateNotify)msg;
		int playerId = playerTeleportStateNotify.PlayerId;
		OnlineModel.Instance.SetPlayerTeleportState(playerId, playerTeleportStateNotify.TeleportState);
		EventSystem.Instance.Emit<int>(EEventName.OnRefreshPlayerUiState, playerId);
		int num = playerId;
		int? id = PlayerInfoModel.Instance.GetId();
		if (num == id.GetValueOrDefault() & id != null)
		{
			return;
		}
		bool flag = playerTeleportStateNotify.TeleportState == EPlayerTeleportState.Default;
		OnlineModel.Instance.SetRoleActivated(playerId, flag);
		if (flag)
		{
			if (playerTeleportStateNotify.CurRolePosInfo == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MultiPlayerTeam;
				ELogAuthor author = ELogAuthor.WCL;
				string message = "队友传送完成通知缺失位置信息";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("playerId", playerId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			EntityHandle entity = CreatureModel.Instance.GetEntity(MathUtils.Instance.LongToBigInt(playerTeleportStateNotify.CurRolePosInfo.EntityId));
			if (entity != null && entity.Entity != null)
			{
				if (entity.IsInit)
				{
					CharacterActorComponent component = entity.Entity.GetComponent<CharacterActorComponent>();
					global::Vector vector = global::Vector.Create((double)playerTeleportStateNotify.CurRolePosInfo.Location.X, (double)playerTeleportStateNotify.CurRolePosInfo.Location.Y, (double)playerTeleportStateNotify.CurRolePosInfo.Location.Z);
					if (!component.FixBornLocation("队友传送完成", true, vector, true, false, true))
					{
						component.TeleportTo(vector.ToUeVector(false), component.ActorRotationProxy.ToUeRotator(), "队友传送完成(地面修正失败)");
					}
				}
				CharacterMovementSyncComponent component2 = entity.Entity.GetComponent<CharacterMovementSyncComponent>();
				if (component2 == null)
				{
					return;
				}
				component2.ClearReplaySamples();
			}
		}
	}

	// Token: 0x060118DD RID: 71901 RVA: 0x0044E168 File Offset: 0x0044C368
	public void ApplyerEnterSceneNotify(IMessage msg, Net.CallbackStatus status)
	{
		ApplyerEnterSceneNotify applyerEnterSceneNotify = (ApplyerEnterSceneNotify)msg;
		string textByErrorId = ErrorCodeConfig.Instance.GetTextByErrorId(applyerEnterSceneNotify.ErrorCode);
		GenericPromptController.Instance.ShowPromptByItsType<object>(EPromptSubViewType.FloatLinePrompt, null, null, new string[]
		{
			textByErrorId
		}, null, null, null, null, null, false, null);
	}

	// Token: 0x060118DE RID: 71902 RVA: 0x0044E1BC File Offset: 0x0044C3BC
	public void PlayerPsnSessionNotify(IMessage msg, Net.CallbackStatus status)
	{
		PlayerPsnSessionNotify playerPsnSessionNotify = (PlayerPsnSessionNotify)msg;
		if (GameModeModel.Instance.IsMulti && !OnlineModel.Instance.GetIsMyTeam())
		{
			this.JoinPlayerSession(playerPsnSessionNotify.PsnSessionId);
		}
	}

	// Token: 0x060118DF RID: 71903 RVA: 0x0044E1F4 File Offset: 0x0044C3F4
	public void SyncPlayerLocationNotify(IMessage msg, Net.CallbackStatus status)
	{
		foreach (PlayerLocation playerLocation in ((SyncPlayerLocationNotify)msg).LocationList)
		{
			OtherScenePlayerData otherScenePlayerData = OnlineModel.Instance.GetOtherScenePlayerDataByPlayerId(playerLocation.PlayerId);
			if (otherScenePlayerData == null)
			{
				otherScenePlayerData = new OtherScenePlayerData(playerLocation.PlayerId, playerLocation.MapId, playerLocation.Location, playerLocation.AreaId);
				OnlineModel.Instance.PushOtherScenePlayerDataList(otherScenePlayerData);
			}
			global::Vector vector = global::Vector.Create(playerLocation.Location);
			otherScenePlayerData.SetLocation(vector);
			otherScenePlayerData.MapId = playerLocation.MapId;
			otherScenePlayerData.Area = playerLocation.AreaId;
			EventSystem.Instance.Emit<int, global::Vector>(EEventName.ScenePlayerLocationChanged, playerLocation.PlayerId, vector);
		}
	}

	// Token: 0x060118E0 RID: 71904 RVA: 0x0044E2C4 File Offset: 0x0044C4C4
	public void ClientVersionNoMatchNotify(IMessage msg, Net.CallbackStatus status)
	{
		ClientVersionNoMatchNotify clientVersionNoMatchNotify = (ClientVersionNoMatchNotify)msg;
		TeamType? noMatchType = this.NoMatchType;
		TeamType teamType = TeamType.WorldTeam;
		if (!(noMatchType.GetValueOrDefault() == teamType & noMatchType != null))
		{
			this.NoMatchType = new TeamType?(clientVersionNoMatchNotify.TeamType);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.MultiPlayerTeam;
		ELogAuthor author = ELogAuthor.CX;
		string message = "客户端版本不匹配";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Proto_ClientVersionNoMatchNotify", clientVersionNoMatchNotify);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x060118E1 RID: 71905 RVA: 0x0044E330 File Offset: 0x0044C530
	public void PlayerGravityUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		PlayerGravityUpdateNotify playerGravityUpdateNotify = (PlayerGravityUpdateNotify)msg;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.MultiPlayerTeam;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "PlayerGravityUpdateNotify";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("message.Proto_CurGravityDirection", playerGravityUpdateNotify.CurGravityDirection);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		OnlineModel.Instance.SetPlayerGravityIsNormal(playerGravityUpdateNotify.CurGravityDirection);
	}

	// Token: 0x060118E2 RID: 71906 RVA: 0x0044E380 File Offset: 0x0044C580
	private void OnTeamTeleportStartNotify(IMessage msg, Net.CallbackStatus status)
	{
		TeamTeleportStartNotify teamTeleportStartNotify = (TeamTeleportStartNotify)msg;
		PlayerInfoModel instance = PlayerInfoModel.Instance;
		int? num = (instance != null) ? instance.GetId() : null;
		int playerId = teamTeleportStartNotify.PlayerId;
		if (!(num.GetValueOrDefault() == playerId & num != null))
		{
			GenericPromptController.Instance.ShowPromptByItsType<object>(EPromptSubViewType.TeamTeleportCountDown, null, null, null, null, null, null, null, new int?(teamTeleportStartNotify.TimeoutSec), false, null);
		}
	}

	// Token: 0x060118E3 RID: 71907 RVA: 0x0044E3F4 File Offset: 0x0044C5F4
	public void ApplyRechallengeRequest(ApplyRechallengeReason reson)
	{
		OnlineModel.Instance.RefreshInitiateTime();
		ApplyRechallengeRequest applyRechallengeRequest = Aki.Protocol.ApplyRechallengeRequest.Create();
		applyRechallengeRequest.Reason = reson;
		EventSystem.Instance.Emit(EEventName.OnRefreshOnlineChallengePlayer);
		Net.Instance.Call(ERequestMessageId.ApplyRechallengeRequest, applyRechallengeRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ApplyRechallengeResponse applyRechallengeResponse = (ApplyRechallengeResponse)msg;
			if (applyRechallengeResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(applyRechallengeResponse.ErrorCode, 22112, null, true, true);
			}
			if (!OnlineModel.Instance.GetIsMyTeam())
			{
				ScrollingTipsController.Instance.ShowTipsById("HaveSuggest", Array.Empty<object>());
				return;
			}
			ScrollingTipsController.Instance.ShowTipsById("HaveInvite", Array.Empty<object>());
		}, 0);
	}

	// Token: 0x060118E4 RID: 71908 RVA: 0x0044E458 File Offset: 0x0044C658
	public void ReceiveRechallengeRequest(bool isAccept, bool isClickCancel)
	{
		ReceiveRechallengeRequest receiveRechallengeRequest = Aki.Protocol.ReceiveRechallengeRequest.Create();
		if (isAccept)
		{
			receiveRechallengeRequest.Result = ERechallengeResultResult.Accept;
		}
		else if (isClickCancel)
		{
			receiveRechallengeRequest.Result = ERechallengeResultResult.ActiveRefuse;
		}
		else
		{
			receiveRechallengeRequest.Result = ERechallengeResultResult.TimeOutRefuse;
		}
		Net.Instance.Call(ERequestMessageId.ReceiveRechallengeRequest, receiveRechallengeRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ReceiveRechallengeResponse receiveRechallengeResponse = (ReceiveRechallengeResponse)msg;
			if (receiveRechallengeResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(receiveRechallengeResponse.ErrorCode, 26240, null, true, true);
			}
		}, 0);
	}

	// Token: 0x060118E5 RID: 71909 RVA: 0x0044E4BC File Offset: 0x0044C6BC
	public void InviteRechallengeRequest()
	{
		OnlineModel.Instance.RefreshInitiateTime();
		InviteRechallengeRequest message = Aki.Protocol.InviteRechallengeRequest.Create();
		Net.Instance.Call(ERequestMessageId.InviteRechallengeRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			InviteRechallengeResponse inviteRechallengeResponse = (InviteRechallengeResponse)msg;
			if (inviteRechallengeResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(inviteRechallengeResponse.ErrorCode, 16100, null, true, true);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.OnlineChallengeStateView, null, null);
			if (UiManager.Instance.IsViewOpen(EUiViewName.OnlineChallengeApplyView))
			{
				UiManager.Instance.CloseView(EUiViewName.OnlineChallengeApplyView, null);
			}
		}, 0);
	}

	// Token: 0x060118E6 RID: 71910 RVA: 0x0044E50C File Offset: 0x0044C70C
	public void LeaveWorldTeamRequest(int playerId, WorldTeamLeaveReason? reason = null)
	{
		LeaveWorldTeamRequest leaveWorldTeamRequest = Aki.Protocol.LeaveWorldTeamRequest.Create();
		leaveWorldTeamRequest.PlayerId = playerId;
		leaveWorldTeamRequest.Reason = reason.GetValueOrDefault();
		Net.Instance.Call(ERequestMessageId.LeaveWorldTeamRequest, leaveWorldTeamRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			LeaveWorldTeamResponse leaveWorldTeamResponse = (LeaveWorldTeamResponse)msg;
			if (leaveWorldTeamResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(leaveWorldTeamResponse.ErrorCode, 16965, null, true, true);
				return;
			}
			OnlineModel.Instance.ClearOnlineTeamMap();
		}, 0);
	}

	// Token: 0x060118E7 RID: 71911 RVA: 0x0044E564 File Offset: 0x0044C764
	public void KickWorldTeamRequest(int playerId)
	{
		KickWorldTeamRequest kickWorldTeamRequest = Aki.Protocol.KickWorldTeamRequest.Create();
		kickWorldTeamRequest.PlayerId = playerId;
		Net.Instance.Call(ERequestMessageId.KickWorldTeamRequest, kickWorldTeamRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			KickWorldTeamResponse kickWorldTeamResponse = (KickWorldTeamResponse)msg;
			if (kickWorldTeamResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(kickWorldTeamResponse.ErrorCode, 19020, null, true, true);
			}
		}, 0);
	}

	// Token: 0x060118E8 RID: 71912 RVA: 0x0044E5B0 File Offset: 0x0044C7B0
	[NullableContext(1)]
	public void PlayerCreatePsnSessionRequest(string playerSessionId)
	{
		PlayerCreatePsnSessionRequest playerCreatePsnSessionRequest = Aki.Protocol.PlayerCreatePsnSessionRequest.Create();
		playerCreatePsnSessionRequest.PsnSessionId = playerSessionId;
		Net.Instance.Call(ERequestMessageId.PlayerCreatePsnSessionRequest, playerCreatePsnSessionRequest, delegate(IMessage response, Net.CallbackStatus _)
		{
		}, 0);
	}

	// Token: 0x060118E9 RID: 71913 RVA: 0x0044E5FC File Offset: 0x0044C7FC
	public void PlayerNetStatePush()
	{
		PlayerNetStatePush playerNetStatePush = Aki.Protocol.PlayerNetStatePush.Create();
		float rttMs = Net.Instance.RttMs;
		playerNetStatePush.RttMs = (int)rttMs;
		Net.Instance.Send(EPushMessageId.PlayerNetStatePush, playerNetStatePush);
		int value = PlayerInfoModel.Instance.GetId().Value;
		ENetPingState netPingState = this.GetNetPingState(rttMs);
		OnlineTeamData currentTeamListById = OnlineModel.Instance.GetCurrentTeamListById(value);
		if (currentTeamListById != null && currentTeamListById.PingState != netPingState)
		{
			currentTeamListById.PingState = netPingState;
			EventSystem.Instance.Emit<int, ENetPingState>(EEventName.OnRefreshPlayerPing, value, netPingState);
		}
	}

	// Token: 0x060118EA RID: 71914 RVA: 0x0044E684 File Offset: 0x0044C884
	public ENetPingState GetNetPingState(float rttMs)
	{
		if (rttMs < 0f)
		{
			return ENetPingState.Unknown;
		}
		float? num = this.NetGreatDefine;
		if (rttMs <= num.GetValueOrDefault() & num != null)
		{
			return ENetPingState.Great;
		}
		num = this.NetGoodDefine;
		if (rttMs <= num.GetValueOrDefault() & num != null)
		{
			return ENetPingState.Good;
		}
		num = this.NetWeaktDefine;
		if (rttMs <= num.GetValueOrDefault() & num != null)
		{
			return ENetPingState.Poor;
		}
		return ENetPingState.Unknown;
	}

	// Token: 0x060118EB RID: 71915 RVA: 0x0044E6FC File Offset: 0x0044C8FC
	protected override void OnAddOpenViewCheckFunction()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.OnlineWorldHallView, new Func<EUiViewName, object, bool>(this.CanOpenView), "OnlineController.CanOpenView");
	}

	// Token: 0x060118EC RID: 71916 RVA: 0x0044E71E File Offset: 0x0044C91E
	protected override void OnRemoveOpenViewCheckFunction()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.OnlineWorldHallView, new Func<EUiViewName, object, bool>(this.CanOpenView));
	}

	// Token: 0x060118ED RID: 71917 RVA: 0x0044E73C File Offset: 0x0044C93C
	[NullableContext(1)]
	private bool CanOpenView(EUiViewName viewName, object param)
	{
		if (!KuroSdkController.Instance.CheckPrivilege(ESdkPrivilege.Multiplayer))
		{
			Log.Instance.Info(ELogModule.MultiPlayerTeam, ELogAuthor.YZY, "多人在线权限不足，拒绝申请", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.OpenThirdPartyMessageBox(ESdkPrivilege.Multiplayer).Forget();
			return false;
		}
		if (!KuroSdkController.Instance.CheckPrivilege(ESdkPrivilege.Communications))
		{
			Log.Instance.Info(ELogModule.MultiPlayerTeam, ELogAuthor.YZY, "通信受限，拒绝申请", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.OpenThirdPartyMessageBox(ESdkPrivilege.Communications).Forget();
			return false;
		}
		if (SceneTeamModel.Instance.IsPhantomTeam || SceneTeamModel.Instance.HasPhantomRole())
		{
			ScrollingTipsController.Instance.ShowTipsById("PhantomFormationEnterOnlineTip", Array.Empty<object>());
			return false;
		}
		if (!GameModeModel.Instance.IsMulti && !FunctionModel.Instance.IsOpen(10021))
		{
			return false;
		}
		if (!GameModeModel.Instance.IsMulti && GameModeController.Instance.IsInInstance())
		{
			ScrollingTipsController.Instance.ShowTipsById("OnlineDisabledByInstance", Array.Empty<object>());
			return false;
		}
		return this.ShowTipsWhenOnlineDisabled(null);
	}

	// Token: 0x060118EE RID: 71918 RVA: 0x0044E840 File Offset: 0x0044CA40
	public bool CheckPlatformCanopen()
	{
		if (!KuroSdkController.Instance.CheckPrivilege(ESdkPrivilege.Multiplayer))
		{
			Log.Instance.Info(ELogModule.MultiPlayerTeam, ELogAuthor.YZY, "多人在线权限不足，拒绝申请", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.OpenThirdPartyMessageBox(ESdkPrivilege.Multiplayer).Forget();
			return false;
		}
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		int? num = (platformSdk != null) ? new int?(platformSdk.CheckUserPremium()) : null;
		if (num.GetValueOrDefault() == -1)
		{
			this.CheckoutCommerceDialogPremiumMode();
		}
		int? num2 = num;
		int num3 = 0;
		return num2.GetValueOrDefault() >= num3 & num2 != null;
	}

	// Token: 0x060118EF RID: 71919 RVA: 0x0044E8D4 File Offset: 0x0044CAD4
	[NullableContext(1)]
	public bool ShowTipsWhenOnlineDisabled(EDisableOnlineType[] ignoreCheckList = null)
	{
		if (!OnlineModel.Instance.IsOnlineDisabled())
		{
			return true;
		}
		IReadOnlyDictionary<DisableOnlineSource, EDisableOnlineType> onlineDisabledSource = OnlineModel.Instance.GetOnlineDisabledSource();
		if (onlineDisabledSource == null)
		{
			return true;
		}
		Dictionary<DisableOnlineSource, EDisableOnlineType> dictionary = new Dictionary<DisableOnlineSource, EDisableOnlineType>();
		using (IEnumerator<KeyValuePair<DisableOnlineSource, EDisableOnlineType>> enumerator = onlineDisabledSource.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				KeyValuePair<DisableOnlineSource, EDisableOnlineType> kvp = enumerator.Current;
				if (ignoreCheckList == null || !Array.Exists<EDisableOnlineType>(ignoreCheckList, (EDisableOnlineType x) => x == kvp.Value))
				{
					dictionary.Add(kvp.Key, kvp.Value);
				}
			}
		}
		if (dictionary.Count == 0)
		{
			return true;
		}
		foreach (KeyValuePair<DisableOnlineSource, EDisableOnlineType> keyValuePair in onlineDisabledSource)
		{
			EDisableOnlineType value = keyValuePair.Value;
			if (value != EDisableOnlineType.NonOnlineQuest)
			{
				if (value != EDisableOnlineType.NonOnlinePlay)
				{
					ScrollingTipsController.Instance.ShowTipsById(OnlineDefine.onlineDisabledSourceTipsId[(int)keyValuePair.Value], Array.Empty<object>());
				}
				else
				{
					string name = LevelPlayModel.Instance.GetProcessingLevelPlayInfo(keyValuePair.Key.TreeId).Name;
					if (OnlineController.CheckStringEmptyOrDnt(name))
					{
						ScrollingTipsController.Instance.ShowTipsByTextId("Text_OnlineDisabledByNonOnlinePlay_Fallback_Text", Array.Empty<object>());
					}
					else
					{
						ScrollingTipsController.Instance.ShowTipsById(OnlineDefine.onlineDisabledSourceTipsId[(int)keyValuePair.Value], new object[]
						{
							name
						});
					}
				}
			}
			else
			{
				string name2 = QuestNewModel.Instance.GetQuest(keyValuePair.Key.TreeId).Name;
				if (OnlineController.CheckStringEmptyOrDnt(name2))
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("Text_OnlineDisabledByNonOnlineQuest_Fallback_Text", Array.Empty<object>());
				}
				else
				{
					ScrollingTipsController.Instance.ShowTipsById(OnlineDefine.onlineDisabledSourceTipsId[(int)keyValuePair.Value], new object[]
					{
						name2
					});
				}
			}
		}
		return false;
	}

	// Token: 0x060118F0 RID: 71920 RVA: 0x0044EAD8 File Offset: 0x0044CCD8
	[NullableContext(1)]
	private static bool CheckStringEmptyOrDnt(string stringContent)
	{
		return StringUtils.IsEmpty(stringContent) || stringContent.StartsWith("dnt/");
	}

	// Token: 0x060118F1 RID: 71921 RVA: 0x0044EAF4 File Offset: 0x0044CCF4
	private void ShowBackLoginConfirmBox()
	{
		ConfirmBoxDataNew confirmBoxDataNew;
		if (Info.Instance.IsXboxPlatform())
		{
			confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.XboxExitGame);
		}
		else
		{
			confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.LeaveMultiOnLoading);
		}
		confirmBoxDataNew.FunctionMap[1] = delegate()
		{
			KuroSdkController.Instance.PostKuroSdkEvent(EKuroSdkEventKey.KUROSDKEXIT);
		};
		ConfirmBoxController.Instance.ShowNetWorkConfirmBoxView(confirmBoxDataNew, null);
	}

	// Token: 0x060118F2 RID: 71922 RVA: 0x0044EB60 File Offset: 0x0044CD60
	[NullableContext(1)]
	public string CreatePlayerSession()
	{
		int? id = PlayerInfoModel.Instance.GetId();
		return KuroSdkController.Instance.CreatePlayerSession(id);
	}

	// Token: 0x060118F3 RID: 71923 RVA: 0x0044EB83 File Offset: 0x0044CD83
	public void LeavePlayerSession()
	{
		KuroSdkController.Instance.LeavePlayerSession();
		if (this.NotifyPlayStationPremiumTimer != null)
		{
			this.NotifyPlayStationPremiumTimer.Remove();
			this.NotifyPlayStationPremiumTimer = null;
		}
	}

	// Token: 0x060118F4 RID: 71924 RVA: 0x0044EBAA File Offset: 0x0044CDAA
	[NullableContext(1)]
	public void JoinPlayerSession(string playerSession)
	{
		KuroSdkController.Instance.JoinPlayerSession(playerSession);
	}

	// Token: 0x060118F5 RID: 71925 RVA: 0x0044EBB8 File Offset: 0x0044CDB8
	public void CheckJoinSession()
	{
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		string thirdGameAutoLoginId = (platformSdk != null) ? platformSdk.CheckJoinSession() : null;
		LoginModel.Instance.ThirdGameAutoLoginId = thirdGameAutoLoginId;
	}

	// Token: 0x060118F6 RID: 71926 RVA: 0x0044EBE7 File Offset: 0x0044CDE7
	public void NotifyPlayStationPremium()
	{
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		if (platformSdk == null)
		{
			return;
		}
		platformSdk.NotifyPlayStationPremium(KuroSdkModel.Instance.PlayStationPlayOnlyState);
	}

	// Token: 0x060118F7 RID: 71927 RVA: 0x0044EC07 File Offset: 0x0044CE07
	[NullableContext(1)]
	public string GetPlayerIdByPlayerSessionId(string playerSessionId)
	{
		return KuroSdkController.Instance.GetPlayerIdByPlayerSessionId(playerSessionId);
	}

	// Token: 0x060118F8 RID: 71928 RVA: 0x0044EC14 File Offset: 0x0044CE14
	public void CheckoutCommerceDialogPremiumMode()
	{
		this.CheckoutDialogTimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			ESdkDialogResult esdkDialogResult = PlatformSdkManagerNew.Instance.GetPlatformSdk().PollCheckoutDialogResult();
			if (esdkDialogResult != ESdkDialogResult.Waiting)
			{
				if (esdkDialogResult == ESdkDialogResult.Yes)
				{
					TimerSystem.GameplayTimeInstance.Remove(this.CheckoutDialogTimerHandle);
					this.CheckoutDialogTimerHandle = null;
					return;
				}
				TimerSystem.GameplayTimeInstance.Remove(this.CheckoutDialogTimerHandle);
				this.CheckoutDialogTimerHandle = null;
			}
		}, 500f, 1f, null, null, true);
	}

	// Token: 0x060118F9 RID: 71929 RVA: 0x0044EC40 File Offset: 0x0044CE40
	private void RefreshSingleConfirm()
	{
		if (this.HaveSingleConfirm)
		{
			return;
		}
		if (OnlineModel.Instance.GetCurrentTeamSize() != 1)
		{
			this.ClearOnlineConfirmTimer();
			return;
		}
		if (this.SingleConfirmTimer != null)
		{
			return;
		}
		this.SingleConfirmTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			if (GameModeController.Instance.IsInInstance())
			{
				this.StartShowOnlineModeTips();
				return;
			}
			if (OnlineModel.Instance.GetCurrentTeamSize() != 1)
			{
				this.ClearOnlineConfirmTimer();
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.OnlineSingleConfirm);
			confirmBoxDataNew.FunctionMap.Add(0, new Action(this.<RefreshSingleConfirm>g__stayWorldCallBack|99_1));
			confirmBoxDataNew.FunctionMap.Add(1, delegate
			{
				int valueOrDefault = PlayerInfoModel.Instance.GetId().GetValueOrDefault();
				this.LeaveWorldTeamRequest(valueOrDefault, null);
			});
			confirmBoxDataNew.FunctionMap.Add(2, new Action(this.<RefreshSingleConfirm>g__stayWorldCallBack|99_1));
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			if (UiManager.Instance.IsViewShow(EUiViewName.BattleView))
			{
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			}
			else
			{
				this.StartShowOnlineModeTips();
			}
			this.ClearOnlineConfirmTimer();
			this.HaveSingleConfirm = true;
		}, this.ONLINE_SING_LONG_TIME, null, "OnlineSingleConfirm", true, 1f);
	}

	// Token: 0x060118FA RID: 71930 RVA: 0x0044ECA1 File Offset: 0x0044CEA1
	private void StartShowOnlineModeTips()
	{
		this.ClearOnlineTipsTimer();
		this.SingleOnlineTipsTimer = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			this.ShowOnlineModeTips();
		}, this.ONLINE_SING_TIPS_TIMER_INTERVAL, 1f, null, null, true);
	}

	// Token: 0x060118FB RID: 71931 RVA: 0x0044ECD4 File Offset: 0x0044CED4
	private void ShowOnlineModeTips()
	{
		if (!GameModeModel.Instance.IsMulti)
		{
			this.ClearOnlineTipsTimer();
			return;
		}
		if (OnlineModel.Instance.GetCurrentTeamSize() != 1)
		{
			this.ShowTipsInterval = 0.0;
			return;
		}
		this.ShowTipsInterval += (double)this.ONLINE_SING_TIPS_TIMER_INTERVAL;
		if (this.ShowTipsInterval < (double)this.ONLINE_SING_TIPS_TIME)
		{
			return;
		}
		if (GameModeController.Instance.IsInInstance())
		{
			this.SingleOnlineTipsHandle = true;
			return;
		}
		ScrollingTipsController.Instance.ShowTipsByTextId("OnlineSingleTips", Array.Empty<object>());
		this.ShowTipsInterval = 0.0;
	}

	// Token: 0x060118FC RID: 71932 RVA: 0x0044ED6C File Offset: 0x0044CF6C
	private void ClearOnlineTipsTimer()
	{
		if (this.SingleOnlineTipsTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.SingleOnlineTipsTimer);
		}
		this.SingleOnlineTipsTimer = null;
	}

	// Token: 0x060118FD RID: 71933 RVA: 0x0044ED8E File Offset: 0x0044CF8E
	private void ClearOnlineConfirmTimer()
	{
		if (this.SingleConfirmTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.SingleConfirmTimer);
		}
		this.SingleConfirmTimer = null;
	}

	// Token: 0x060118FE RID: 71934 RVA: 0x0044EDB0 File Offset: 0x0044CFB0
	private void CsRequestJoinWorld(int worldId, int worldEnterWay)
	{
		this.ApplyJoinWorldRequest(worldId, (WorldEnterWay)worldEnterWay);
	}

	// Token: 0x1700165F RID: 5727
	// (get) Token: 0x060118FF RID: 71935 RVA: 0x0044EDBA File Offset: 0x0044CFBA
	[Nullable(1)]
	public static OnlineController Instance
	{
		[NullableContext(1)]
		get
		{
			return OnlineController._Instance;
		}
	}

	// Token: 0x06011900 RID: 71936 RVA: 0x0044EDC1 File Offset: 0x0044CFC1
	[NullableContext(1)]
	public static OnlineController GetOrCreateInstance()
	{
		if (OnlineController._Instance == null)
		{
			OnlineController.CreateInstance();
		}
		return OnlineController._Instance;
	}

	// Token: 0x06011901 RID: 71937 RVA: 0x0044EDD5 File Offset: 0x0044CFD5
	public static bool CreateInstance()
	{
		if (OnlineController._Instance != null)
		{
			return true;
		}
		OnlineController._Instance = new OnlineController();
		return true;
	}

	// Token: 0x06011902 RID: 71938 RVA: 0x0044EDEB File Offset: 0x0044CFEB
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011903 RID: 71939 RVA: 0x0044EDED File Offset: 0x0044CFED
	public static void ResetStaticDefaultValue()
	{
		OnlineController._Instance = null;
	}

	// Token: 0x06011904 RID: 71940 RVA: 0x0044EDF5 File Offset: 0x0044CFF5
	static OnlineController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(OnlineController.CreateStaticDefaultValue), new Action(OnlineController.ResetStaticDefaultValue));
	}

	// Token: 0x06011909 RID: 71945 RVA: 0x0044EFA4 File Offset: 0x0044D1A4
	[CompilerGenerated]
	private void <RefreshSingleConfirm>g__stayWorldCallBack|99_1()
	{
		this.StartShowOnlineModeTips();
	}

	// Token: 0x0400853E RID: 34110
	private int LIST_REQUEST_CD = 5;

	// Token: 0x0400853F RID: 34111
	private float NOTIFY_PLAYSTATION_CD = (float)TimeUtil.Instance.InverseMillisecond;

	// Token: 0x04008540 RID: 34112
	private float ONLINE_SING_LONG_TIME = (float)(300 * TimeUtil.Instance.InverseMillisecond);

	// Token: 0x04008541 RID: 34113
	private float ONLINE_SING_TIPS_TIME = (float)(1200 * TimeUtil.Instance.InverseMillisecond);

	// Token: 0x04008542 RID: 34114
	public float ONLINE_SING_TIPS_TIMER_INTERVAL = (float)(60 * TimeUtil.Instance.InverseMillisecond);

	// Token: 0x04008543 RID: 34115
	private double TargetRequestTimeStamp;

	// Token: 0x04008544 RID: 34116
	[Nullable(new byte[]
	{
		1,
		0,
		1,
		1,
		1
	})]
	private ValueTuple<string, object[]>?[] TipsCache;

	// Token: 0x04008545 RID: 34117
	private float? PingPushInterval;

	// Token: 0x04008546 RID: 34118
	private float? LastPingPush;

	// Token: 0x04008547 RID: 34119
	private float? NetGreatDefine;

	// Token: 0x04008548 RID: 34120
	private float? NetGoodDefine;

	// Token: 0x04008549 RID: 34121
	private float? NetWeaktDefine;

	// Token: 0x0400854A RID: 34122
	private TimerHandle NotifyPlayStationPremiumTimer;

	// Token: 0x0400854B RID: 34123
	private TeamType? NoMatchType;

	// Token: 0x0400854C RID: 34124
	private FJoinSessionCallBack JoinSessionDelegate;

	// Token: 0x0400854D RID: 34125
	public string HandleTips;

	// Token: 0x0400854E RID: 34126
	public bool IsFirstSetMode;

	// Token: 0x0400854F RID: 34127
	private TimerHandle CheckoutDialogTimerHandle;

	// Token: 0x04008550 RID: 34128
	private TimerHandle SingleConfirmTimer;

	// Token: 0x04008551 RID: 34129
	private TimerHandle SingleOnlineTipsTimer;

	// Token: 0x04008552 RID: 34130
	private bool SingleOnlineTipsHandle;

	// Token: 0x04008553 RID: 34131
	private bool HaveSingleConfirm;

	// Token: 0x04008554 RID: 34132
	private double ShowTipsInterval;

	// Token: 0x04008555 RID: 34133
	private static OnlineController _Instance;
}
