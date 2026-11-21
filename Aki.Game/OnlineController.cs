using System;
using System.Collections.Generic;
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

// Token: 0x020017C0 RID: 6080
[NullableContext(2)]
[Nullable(0)]
[TickController(0)]
public class OnlineController : UiControllerBase
{
	// Token: 0x0600ED43 RID: 60739 RVA: 0x0045945C File Offset: 0x0045765C
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

	// Token: 0x0600ED44 RID: 60740 RVA: 0x00459561 File Offset: 0x00457761
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

	// Token: 0x0600ED45 RID: 60741 RVA: 0x0045958C File Offset: 0x0045778C
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

	// Token: 0x0600ED46 RID: 60742 RVA: 0x004596A0 File Offset: 0x004578A0
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

	// Token: 0x0600ED47 RID: 60743 RVA: 0x004597B0 File Offset: 0x004579B0
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

	// Token: 0x0600ED48 RID: 60744 RVA: 0x004597FC File Offset: 0x004579FC
	private UniTask OpenThirdPartyMessageBox(ESdkPrivilege privilege)
	{
		OnlineController.<OpenThirdPartyMessageBox>d__20 <OpenThirdPartyMessageBox>d__;
		<OpenThirdPartyMessageBox>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenThirdPartyMessageBox>d__.privilege = privilege;
		<OpenThirdPartyMessageBox>d__.<>1__state = -1;
		<OpenThirdPartyMessageBox>d__.<>t__builder.Start<OnlineController.<OpenThirdPartyMessageBox>d__20>(ref <OpenThirdPartyMessageBox>d__);
		return <OpenThirdPartyMessageBox>d__.<>t__builder.Task;
	}

	// Token: 0x0600ED49 RID: 60745 RVA: 0x00459840 File Offset: 0x00457A40
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

	// Token: 0x0600ED4A RID: 60746 RVA: 0x00459930 File Offset: 0x00457B30
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

	// Token: 0x0600ED4B RID: 60747 RVA: 0x00459A04 File Offset: 0x00457C04
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
		Net.Instance.Register(ENotifyMessageId.PlayerNetStateS2cNotify, new Action<IMessage, Net.CallbackStatus>(this.PlayerNetStateS2cNotify));
	}

	// Token: 0x0600ED4C RID: 60748 RVA: 0x00459C44 File Offset: 0x00457E44
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

	// Token: 0x0600ED4D RID: 60749 RVA: 0x00459D74 File Offset: 0x00457F74
	private void WorldDone()
	{
		OnlineModel.Instance.SetPermissionsSetting((WorldEnterPermission)FunctionModel.Instance.GetWorldPermission().GetValueOrDefault());
		this.RefreshWorldPermissionSetting();
		OnlineModel.Instance.ClearOtherScenePlayerDataList();
	}

	// Token: 0x0600ED4E RID: 60750 RVA: 0x00459DB0 File Offset: 0x00457FB0
	private void RefreshWorldPermissionSetting()
	{
		if (!KuroSdkController.Instance.CheckPrivilege(ESdkPrivilege.Multiplayer))
		{
			OnlineController.Instance.WorldEnterPermissionsRequest(WorldEnterPermission.ForbidJoin);
			Log.Instance.Info(ELogModule.InstanceDungeon, ELogAuthor.YZY, "通信受限，禁止加入联机", default(ReadOnlySpan<ValueTuple<string, object>>));
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

	// Token: 0x0600ED4F RID: 60751 RVA: 0x00459E28 File Offset: 0x00458028
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

	// Token: 0x0600ED50 RID: 60752 RVA: 0x00459EC9 File Offset: 0x004580C9
	private EConfirmBoxConfigId GetConfirmBoxIdByNoMatchType()
	{
		if (this.NoMatchType.GetValueOrDefault() == TeamType.MatchTeam)
		{
			return EConfirmBoxConfigId.ClientVersionNoMatchTeam;
		}
		return EConfirmBoxConfigId.ClientVersionNoMatchOnline;
	}

	// Token: 0x0600ED51 RID: 60753 RVA: 0x00459EE4 File Offset: 0x004580E4
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

	// Token: 0x0600ED52 RID: 60754 RVA: 0x00459F50 File Offset: 0x00458150
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

	// Token: 0x0600ED53 RID: 60755 RVA: 0x00459FD0 File Offset: 0x004581D0
	private void OnCloseLoading()
	{
		if (this.TipsCache == null)
		{
			return;
		}
		ScrollingTipsController.Instance.ShowTipsById(this.TipsCache[0].Value.Item1, this.TipsCache[0].Value.Item2);
		this.TipsCache = null;
	}

	// Token: 0x0600ED54 RID: 60756 RVA: 0x0045A023 File Offset: 0x00458223
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

	// Token: 0x0600ED55 RID: 60757 RVA: 0x0045A04B File Offset: 0x0045824B
	[NullableContext(1)]
	private void OnInputAnyKey(bool bPress, FKey key)
	{
		LoginModel.Instance.ThirdGameAutoLoginId = "-1";
		EventSystem.Instance.Remove(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey));
	}

	// Token: 0x0600ED56 RID: 60758 RVA: 0x0045A078 File Offset: 0x00458278
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

	// Token: 0x0600ED57 RID: 60759 RVA: 0x0045A0BC File Offset: 0x004582BC
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
			this.PlayerNetStateCheck();
		}
		this.LastPingPush += delta;
	}

	// Token: 0x0600ED58 RID: 60760 RVA: 0x0045A184 File Offset: 0x00458384
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

	// Token: 0x0600ED59 RID: 60761 RVA: 0x0045A1D0 File Offset: 0x004583D0
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

	// Token: 0x0600ED5A RID: 60762 RVA: 0x0045A21C File Offset: 0x0045841C
	public void WorldEnterPermissionsRequest(WorldEnterPermission type)
	{
		WorldEnterPermissionsRequest worldEnterPermissionsRequest = Aki.Protocol.WorldEnterPermissionsRequest.Create();
		worldEnterPermissionsRequest.Type = type;
		Net.Instance.Call(ERequestMessageId.WorldEnterPermissionsRequest, worldEnterPermissionsRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			WorldEnterPermissionsResponse worldEnterPermissionsResponse = (WorldEnterPermissionsResponse)msg;
			if (worldEnterPermissionsResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(worldEnterPermissionsResponse.ErrorCode, 24472, null, true, true);
				return;
			}
			OnlineModel.Instance.SetPermissionsSetting(worldEnterPermissionsResponse.Type);
			EventSystem.Instance.Emit(EEventName.OnRefreshPermissionsSetting);
		}, 0);
	}

	// Token: 0x0600ED5B RID: 60763 RVA: 0x0045A268 File Offset: 0x00458468
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(applyJoinWorldResponse.ErrorCode, 15396, applyJoinWorldResponse.ErrorParams, true, true);
			}
		}, 0);
	}

	// Token: 0x0600ED5C RID: 60764 RVA: 0x0045A2E0 File Offset: 0x004584E0
	private bool CheckTowerViewIfOpen()
	{
		return UiManager.Instance.IsViewOpen(EUiViewName.CycleTowerView) || UiManager.Instance.IsViewOpen(EUiViewName.CycleTowerChallengeView) || UiManager.Instance.IsViewOpen(EUiViewName.CycleTowerTeamView) || (UiManager.Instance.IsViewOpen(EUiViewName.SingleTimeTowerView) || UiManager.Instance.IsViewOpen(EUiViewName.SingleTimeTowerChallengeView) || UiManager.Instance.IsViewOpen(EUiViewName.SingleTimeTowerTeamView));
	}

	// Token: 0x0600ED5D RID: 60765 RVA: 0x0045A358 File Offset: 0x00458558
	public void ApplyJoinWorldNotify(IMessage msg, Net.CallbackStatus status)
	{
		ApplyJoinWorldNotify message = (ApplyJoinWorldNotify)msg;
		this.OnApplyJoinNotify(message).Forget();
	}

	// Token: 0x0600ED5E RID: 60766 RVA: 0x0045A378 File Offset: 0x00458578
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

	// Token: 0x0600ED5F RID: 60767 RVA: 0x0045A3C4 File Offset: 0x004585C4
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

	// Token: 0x0600ED60 RID: 60768 RVA: 0x0045A438 File Offset: 0x00458638
	public void AllApplyJoinNotify(IMessage msg, Net.CallbackStatus status)
	{
		AllApplyJoinNotify message = (AllApplyJoinNotify)msg;
		this.OnAllApplyJoinNotify(message).Forget();
	}

	// Token: 0x0600ED61 RID: 60769 RVA: 0x0045A458 File Offset: 0x00458658
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

	// Token: 0x0600ED62 RID: 60770 RVA: 0x0045A49C File Offset: 0x0045869C
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

	// Token: 0x0600ED63 RID: 60771 RVA: 0x0045A4EC File Offset: 0x004586EC
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

	// Token: 0x0600ED64 RID: 60772 RVA: 0x0045A538 File Offset: 0x00458738
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(agreeJoinResultResponse.ErrorCode, 24721, null, true, true);
				return;
			}
			OnlineModel.Instance.DeleteCurrentApplyListById(applyPlayerId);
			EventSystem.Instance.Emit(EEventName.OnRefreshApply);
		}, 0);
	}

	// Token: 0x0600ED65 RID: 60773 RVA: 0x0045A5B4 File Offset: 0x004587B4
	public void MatchChangePlayerUiStateRequest(EMatchPlayerUiState matchUiState)
	{
		MatchChangePlayerUiStateRequest matchChangePlayerUiStateRequest = Aki.Protocol.MatchChangePlayerUiStateRequest.Create();
		matchChangePlayerUiStateRequest.MatchUiState = matchUiState;
		Net.Instance.Call(ERequestMessageId.MatchChangePlayerUiStateRequest, matchChangePlayerUiStateRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			MatchChangePlayerUiStateResponse matchChangePlayerUiStateResponse = (MatchChangePlayerUiStateResponse)msg;
			if (matchChangePlayerUiStateResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(matchChangePlayerUiStateResponse.ErrorCode, 24721, null, true, true);
				return;
			}
			int value = PlayerInfoModel.Instance.GetId().Value;
			InstanceDungeonModel.Instance.SetPlayerUiState(value, matchUiState);
		}, 0);
	}

	// Token: 0x0600ED66 RID: 60774 RVA: 0x0045A600 File Offset: 0x00458800
	public void JoinWorldTeamNotify(IMessage msg, Net.CallbackStatus status)
	{
		JoinWorldTeamNotify message = (JoinWorldTeamNotify)msg;
		this.OnJoinWorldTeamNotify(message).Forget();
	}

	// Token: 0x0600ED67 RID: 60775 RVA: 0x0045A620 File Offset: 0x00458820
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

	// Token: 0x0600ED68 RID: 60776 RVA: 0x0045A66C File Offset: 0x0045886C
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

	// Token: 0x0600ED69 RID: 60777 RVA: 0x0045A838 File Offset: 0x00458A38
	public void PlayerEnterWorldTeamNotify(IMessage msg, Net.CallbackStatus status)
	{
		PlayerEnterWorldTeamNotify message = (PlayerEnterWorldTeamNotify)msg;
		this.OnPlayerEnterWorldTeamNotify(message).Forget();
	}

	// Token: 0x0600ED6A RID: 60778 RVA: 0x0045A858 File Offset: 0x00458A58
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

	// Token: 0x0600ED6B RID: 60779 RVA: 0x0045A89C File Offset: 0x00458A9C
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

	// Token: 0x0600ED6C RID: 60780 RVA: 0x0045A960 File Offset: 0x00458B60
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

	// Token: 0x0600ED6D RID: 60781 RVA: 0x0045AA80 File Offset: 0x00458C80
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

	// Token: 0x0600ED6E RID: 60782 RVA: 0x0045AB38 File Offset: 0x00458D38
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

	// Token: 0x0600ED6F RID: 60783 RVA: 0x0045ABAC File Offset: 0x00458DAC
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

	// Token: 0x0600ED70 RID: 60784 RVA: 0x0045AC00 File Offset: 0x00458E00
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

	// Token: 0x0600ED71 RID: 60785 RVA: 0x0045AC64 File Offset: 0x00458E64
	public bool IsNetStateGood(ENetPingState pingState)
	{
		return pingState == ENetPingState.Great || pingState == ENetPingState.Good;
	}

	// Token: 0x0600ED72 RID: 60786 RVA: 0x0045AC70 File Offset: 0x00458E70
	public void MatchChangePlayerUiStateNotify(IMessage msg, Net.CallbackStatus status)
	{
		MatchChangePlayerUiStateNotify matchChangePlayerUiStateNotify = (MatchChangePlayerUiStateNotify)msg;
		InstanceDungeonModel.Instance.SetPlayerUiState(matchChangePlayerUiStateNotify.PlayerId, matchChangePlayerUiStateNotify.MatchUiState);
	}

	// Token: 0x0600ED73 RID: 60787 RVA: 0x0045AC9C File Offset: 0x00458E9C
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

	// Token: 0x0600ED74 RID: 60788 RVA: 0x0045AE1C File Offset: 0x0045901C
	public void ApplyerEnterSceneNotify(IMessage msg, Net.CallbackStatus status)
	{
		ApplyerEnterSceneNotify applyerEnterSceneNotify = (ApplyerEnterSceneNotify)msg;
		string textByErrorId = ErrorCodeConfig.Instance.GetTextByErrorId(applyerEnterSceneNotify.ErrorCode);
		GenericPromptController.Instance.ShowPromptByItsType<object>(EPromptSubViewType.FloatLinePrompt, null, null, new string[]
		{
			textByErrorId
		}, null, null, null, null, null, false, null);
	}

	// Token: 0x0600ED75 RID: 60789 RVA: 0x0045AE70 File Offset: 0x00459070
	public void PlayerPsnSessionNotify(IMessage msg, Net.CallbackStatus status)
	{
		PlayerPsnSessionNotify playerPsnSessionNotify = (PlayerPsnSessionNotify)msg;
		if (GameModeModel.Instance.IsMulti && !OnlineModel.Instance.GetIsMyTeam())
		{
			this.JoinPlayerSession(playerPsnSessionNotify.PsnSessionId);
		}
	}

	// Token: 0x0600ED76 RID: 60790 RVA: 0x0045AEA8 File Offset: 0x004590A8
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

	// Token: 0x0600ED77 RID: 60791 RVA: 0x0045AF78 File Offset: 0x00459178
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

	// Token: 0x0600ED78 RID: 60792 RVA: 0x0045AFE4 File Offset: 0x004591E4
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

	// Token: 0x0600ED79 RID: 60793 RVA: 0x0045B034 File Offset: 0x00459234
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

	// Token: 0x0600ED7A RID: 60794 RVA: 0x0045B0A8 File Offset: 0x004592A8
	[NullableContext(1)]
	private void PlayerNetStateS2cNotify([Nullable(2)] IMessage msg, Net.CallbackStatus status)
	{
		PlayerNetStateS2cNotify playerNetStateS2cNotify = (PlayerNetStateS2cNotify)msg;
		PlayerNetStateBackServerPush playerNetStateBackServerPush = PlayerNetStateBackServerPush.Create();
		playerNetStateBackServerPush.Uid = playerNetStateS2cNotify.Uid;
		Net.Instance.Send(EPushMessageId.PlayerNetStateBackServerPush, playerNetStateBackServerPush);
	}

	// Token: 0x0600ED7B RID: 60795 RVA: 0x0045B0E0 File Offset: 0x004592E0
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(applyRechallengeResponse.ErrorCode, 29801, null, true, true);
			}
			if (!OnlineModel.Instance.GetIsMyTeam())
			{
				ScrollingTipsController.Instance.ShowTipsById("HaveSuggest", Array.Empty<object>());
				return;
			}
			ScrollingTipsController.Instance.ShowTipsById("HaveInvite", Array.Empty<object>());
		}, 0);
	}

	// Token: 0x0600ED7C RID: 60796 RVA: 0x0045B144 File Offset: 0x00459344
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(receiveRechallengeResponse.ErrorCode, 21241, null, true, true);
			}
		}, 0);
	}

	// Token: 0x0600ED7D RID: 60797 RVA: 0x0045B1A8 File Offset: 0x004593A8
	public void InviteRechallengeRequest()
	{
		OnlineModel.Instance.RefreshInitiateTime();
		InviteRechallengeRequest message = Aki.Protocol.InviteRechallengeRequest.Create();
		Net.Instance.Call(ERequestMessageId.InviteRechallengeRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			InviteRechallengeResponse inviteRechallengeResponse = (InviteRechallengeResponse)msg;
			if (inviteRechallengeResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(inviteRechallengeResponse.ErrorCode, 15563, null, true, true);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.OnlineChallengeStateView, null, null);
			if (UiManager.Instance.IsViewOpen(EUiViewName.OnlineChallengeApplyView))
			{
				UiManager.Instance.CloseView(EUiViewName.OnlineChallengeApplyView, null);
			}
		}, 0);
	}

	// Token: 0x0600ED7E RID: 60798 RVA: 0x0045B1F8 File Offset: 0x004593F8
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(leaveWorldTeamResponse.ErrorCode, 16579, null, true, true);
				return;
			}
			OnlineModel.Instance.ClearOnlineTeamMap();
		}, 0);
	}

	// Token: 0x0600ED7F RID: 60799 RVA: 0x0045B250 File Offset: 0x00459450
	public void KickWorldTeamRequest(int playerId)
	{
		KickWorldTeamRequest kickWorldTeamRequest = Aki.Protocol.KickWorldTeamRequest.Create();
		kickWorldTeamRequest.PlayerId = playerId;
		Net.Instance.Call(ERequestMessageId.KickWorldTeamRequest, kickWorldTeamRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			KickWorldTeamResponse kickWorldTeamResponse = (KickWorldTeamResponse)msg;
			if (kickWorldTeamResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(kickWorldTeamResponse.ErrorCode, 26682, null, true, true);
			}
		}, 0);
	}

	// Token: 0x0600ED80 RID: 60800 RVA: 0x0045B29C File Offset: 0x0045949C
	[NullableContext(1)]
	public void PlayerCreatePsnSessionRequest(string playerSessionId)
	{
		PlayerCreatePsnSessionRequest playerCreatePsnSessionRequest = Aki.Protocol.PlayerCreatePsnSessionRequest.Create();
		playerCreatePsnSessionRequest.PsnSessionId = playerSessionId;
		Net.Instance.Call(ERequestMessageId.PlayerCreatePsnSessionRequest, playerCreatePsnSessionRequest, delegate(IMessage response, Net.CallbackStatus _)
		{
		}, 0);
	}

	// Token: 0x0600ED81 RID: 60801 RVA: 0x0045B2E8 File Offset: 0x004594E8
	public void PlayerNetStateCheck()
	{
		float rttMs = Net.Instance.RttMs;
		int value = PlayerInfoModel.Instance.GetId().Value;
		ENetPingState netPingState = this.GetNetPingState(rttMs);
		OnlineTeamData currentTeamListById = OnlineModel.Instance.GetCurrentTeamListById(value);
		if (currentTeamListById != null && currentTeamListById.PingState != netPingState)
		{
			currentTeamListById.PingState = netPingState;
			EventSystem.Instance.Emit<int, ENetPingState>(EEventName.OnRefreshPlayerPing, value, netPingState);
		}
	}

	// Token: 0x0600ED82 RID: 60802 RVA: 0x0045B350 File Offset: 0x00459550
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

	// Token: 0x0600ED83 RID: 60803 RVA: 0x0045B3C8 File Offset: 0x004595C8
	protected override void OnAddOpenViewCheckFunction()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.OnlineWorldHallView, new Func<EUiViewName, object, bool>(this.CanOpenView), "OnlineController.CanOpenView");
	}

	// Token: 0x0600ED84 RID: 60804 RVA: 0x0045B3EA File Offset: 0x004595EA
	protected override void OnRemoveOpenViewCheckFunction()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.OnlineWorldHallView, new Func<EUiViewName, object, bool>(this.CanOpenView));
	}

	// Token: 0x0600ED85 RID: 60805 RVA: 0x0045B408 File Offset: 0x00459608
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

	// Token: 0x0600ED86 RID: 60806 RVA: 0x0045B50C File Offset: 0x0045970C
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

	// Token: 0x0600ED87 RID: 60807 RVA: 0x0045B5A0 File Offset: 0x004597A0
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

	// Token: 0x0600ED88 RID: 60808 RVA: 0x0045B7A4 File Offset: 0x004599A4
	[NullableContext(1)]
	private static bool CheckStringEmptyOrDnt(string stringContent)
	{
		return StringUtils.IsEmpty(stringContent) || stringContent.StartsWith("dnt/");
	}

	// Token: 0x0600ED89 RID: 60809 RVA: 0x0045B7C0 File Offset: 0x004599C0
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

	// Token: 0x0600ED8A RID: 60810 RVA: 0x0045B82C File Offset: 0x00459A2C
	[NullableContext(1)]
	public string CreatePlayerSession()
	{
		int? id = PlayerInfoModel.Instance.GetId();
		return KuroSdkController.Instance.CreatePlayerSession(id);
	}

	// Token: 0x0600ED8B RID: 60811 RVA: 0x0045B84F File Offset: 0x00459A4F
	public void LeavePlayerSession()
	{
		KuroSdkController.Instance.LeavePlayerSession();
		if (this.NotifyPlayStationPremiumTimer != null)
		{
			this.NotifyPlayStationPremiumTimer.Remove();
			this.NotifyPlayStationPremiumTimer = null;
		}
	}

	// Token: 0x0600ED8C RID: 60812 RVA: 0x0045B876 File Offset: 0x00459A76
	[NullableContext(1)]
	public void JoinPlayerSession(string playerSession)
	{
		KuroSdkController.Instance.JoinPlayerSession(playerSession);
	}

	// Token: 0x0600ED8D RID: 60813 RVA: 0x0045B884 File Offset: 0x00459A84
	public void CheckJoinSession()
	{
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		string thirdGameAutoLoginId = (platformSdk != null) ? platformSdk.CheckJoinSession() : null;
		LoginModel.Instance.ThirdGameAutoLoginId = thirdGameAutoLoginId;
	}

	// Token: 0x0600ED8E RID: 60814 RVA: 0x0045B8B3 File Offset: 0x00459AB3
	public void NotifyPlayStationPremium()
	{
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		if (platformSdk == null)
		{
			return;
		}
		platformSdk.NotifyPlayStationPremium(KuroSdkModel.Instance.PlayStationPlayOnlyState);
	}

	// Token: 0x0600ED8F RID: 60815 RVA: 0x0045B8D3 File Offset: 0x00459AD3
	[NullableContext(1)]
	public string GetPlayerIdByPlayerSessionId(string playerSessionId)
	{
		return KuroSdkController.Instance.GetPlayerIdByPlayerSessionId(playerSessionId);
	}

	// Token: 0x0600ED90 RID: 60816 RVA: 0x0045B8E0 File Offset: 0x00459AE0
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

	// Token: 0x0600ED91 RID: 60817 RVA: 0x0045B90C File Offset: 0x00459B0C
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
			confirmBoxDataNew.FunctionMap.Add(0, new Action(this.<RefreshSingleConfirm>g__stayWorldCallBack|100_1));
			confirmBoxDataNew.FunctionMap.Add(1, delegate
			{
				int valueOrDefault = PlayerInfoModel.Instance.GetId().GetValueOrDefault();
				this.LeaveWorldTeamRequest(valueOrDefault, null);
			});
			confirmBoxDataNew.FunctionMap.Add(2, new Action(this.<RefreshSingleConfirm>g__stayWorldCallBack|100_1));
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

	// Token: 0x0600ED92 RID: 60818 RVA: 0x0045B96D File Offset: 0x00459B6D
	private void StartShowOnlineModeTips()
	{
		this.ClearOnlineTipsTimer();
		this.SingleOnlineTipsTimer = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			this.ShowOnlineModeTips();
		}, this.ONLINE_SING_TIPS_TIMER_INTERVAL, 1f, null, null, true);
	}

	// Token: 0x0600ED93 RID: 60819 RVA: 0x0045B9A0 File Offset: 0x00459BA0
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

	// Token: 0x0600ED94 RID: 60820 RVA: 0x0045BA38 File Offset: 0x00459C38
	private void ClearOnlineTipsTimer()
	{
		if (this.SingleOnlineTipsTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.SingleOnlineTipsTimer);
		}
		this.SingleOnlineTipsTimer = null;
	}

	// Token: 0x0600ED95 RID: 60821 RVA: 0x0045BA5A File Offset: 0x00459C5A
	private void ClearOnlineConfirmTimer()
	{
		if (this.SingleConfirmTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.SingleConfirmTimer);
		}
		this.SingleConfirmTimer = null;
	}

	// Token: 0x0600ED96 RID: 60822 RVA: 0x0045BA7C File Offset: 0x00459C7C
	private void CsRequestJoinWorld(int worldId, int worldEnterWay)
	{
		this.ApplyJoinWorldRequest(worldId, (WorldEnterWay)worldEnterWay);
	}

	// Token: 0x17001696 RID: 5782
	// (get) Token: 0x0600ED97 RID: 60823 RVA: 0x0045BA86 File Offset: 0x00459C86
	[Nullable(1)]
	public static OnlineController Instance
	{
		[NullableContext(1)]
		get
		{
			return OnlineController._Instance;
		}
	}

	// Token: 0x0600ED98 RID: 60824 RVA: 0x0045BA8D File Offset: 0x00459C8D
	[NullableContext(1)]
	public static OnlineController GetOrCreateInstance()
	{
		if (OnlineController._Instance == null)
		{
			OnlineController.CreateInstance();
		}
		return OnlineController._Instance;
	}

	// Token: 0x0600ED99 RID: 60825 RVA: 0x0045BAA1 File Offset: 0x00459CA1
	public static bool CreateInstance()
	{
		if (OnlineController._Instance != null)
		{
			return true;
		}
		OnlineController._Instance = new OnlineController();
		return true;
	}

	// Token: 0x0600ED9A RID: 60826 RVA: 0x0045BAB7 File Offset: 0x00459CB7
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600ED9B RID: 60827 RVA: 0x0045BAB9 File Offset: 0x00459CB9
	public static void ResetStaticDefaultValue()
	{
		OnlineController._Instance = null;
	}

	// Token: 0x0600ED9C RID: 60828 RVA: 0x0045BAC1 File Offset: 0x00459CC1
	static OnlineController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(OnlineController.CreateStaticDefaultValue), new Action(OnlineController.ResetStaticDefaultValue));
	}

	// Token: 0x0600EDA1 RID: 60833 RVA: 0x0045BC70 File Offset: 0x00459E70
	[CompilerGenerated]
	private void <RefreshSingleConfirm>g__stayWorldCallBack|100_1()
	{
		this.StartShowOnlineModeTips();
	}

	// Token: 0x0400867C RID: 34428
	private int LIST_REQUEST_CD = 5;

	// Token: 0x0400867D RID: 34429
	private float NOTIFY_PLAYSTATION_CD = (float)TimeUtil.Instance.InverseMillisecond;

	// Token: 0x0400867E RID: 34430
	private float ONLINE_SING_LONG_TIME = (float)(300 * TimeUtil.Instance.InverseMillisecond);

	// Token: 0x0400867F RID: 34431
	private float ONLINE_SING_TIPS_TIME = (float)(1200 * TimeUtil.Instance.InverseMillisecond);

	// Token: 0x04008680 RID: 34432
	public float ONLINE_SING_TIPS_TIMER_INTERVAL = (float)(60 * TimeUtil.Instance.InverseMillisecond);

	// Token: 0x04008681 RID: 34433
	private double TargetRequestTimeStamp;

	// Token: 0x04008682 RID: 34434
	[Nullable(new byte[]
	{
		1,
		0,
		1,
		1,
		1
	})]
	private ValueTuple<string, object[]>?[] TipsCache;

	// Token: 0x04008683 RID: 34435
	private float? PingPushInterval;

	// Token: 0x04008684 RID: 34436
	private float? LastPingPush;

	// Token: 0x04008685 RID: 34437
	private float? NetGreatDefine;

	// Token: 0x04008686 RID: 34438
	private float? NetGoodDefine;

	// Token: 0x04008687 RID: 34439
	private float? NetWeaktDefine;

	// Token: 0x04008688 RID: 34440
	private TimerHandle NotifyPlayStationPremiumTimer;

	// Token: 0x04008689 RID: 34441
	private TeamType? NoMatchType;

	// Token: 0x0400868A RID: 34442
	private FJoinSessionCallBack JoinSessionDelegate;

	// Token: 0x0400868B RID: 34443
	public string HandleTips;

	// Token: 0x0400868C RID: 34444
	public bool IsFirstSetMode;

	// Token: 0x0400868D RID: 34445
	private TimerHandle CheckoutDialogTimerHandle;

	// Token: 0x0400868E RID: 34446
	private TimerHandle SingleConfirmTimer;

	// Token: 0x0400868F RID: 34447
	private TimerHandle SingleOnlineTipsTimer;

	// Token: 0x04008690 RID: 34448
	private bool SingleOnlineTipsHandle;

	// Token: 0x04008691 RID: 34449
	private bool HaveSingleConfirm;

	// Token: 0x04008692 RID: 34450
	private double ShowTipsInterval;

	// Token: 0x04008693 RID: 34451
	private static OnlineController _Instance;
}
