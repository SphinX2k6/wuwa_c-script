using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Platform.PlatformSdk;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;

// Token: 0x0200178A RID: 6026
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ChatController : UiControllerBase
{
	// Token: 0x0600AF3E RID: 44862 RVA: 0x00279445 File Offset: 0x00277645
	protected override bool OnClear()
	{
		if (this.DelayPrivateChatDataRequestTimer != null && TimerSystem.GameplayTimeInstance.Has(this.DelayPrivateChatDataRequestTimer))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.DelayPrivateChatDataRequestTimer);
			this.DelayPrivateChatDataRequestTimer = null;
		}
		return true;
	}

	// Token: 0x0600AF3F RID: 44863 RVA: 0x0027947C File Offset: 0x0027767C
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int>(EEventName.OnSelectChatFriend, this.OnSelectChatFriend);
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, this.OnOpenView);
		EventSystem.Instance.Add(EEventName.OnEnterTeam, new Action(this.OnEnterTeam));
		EventSystem.Instance.Add(EEventName.OnLeaveTeam, new Action(this.OnLeaveTeam));
		EventSystem.Instance.Add(EEventName.OnEnterOnlineWorld, new Action(this.OnEnterOnlineWorld));
		EventSystem.Instance.Add(EEventName.OnLeaveOnlineWorld, new Action(this.OnLeaveOnlineWorld));
		EventSystem.Instance.Add<int>(EEventName.OnRemoveFriend, this.OnRemoveFriend);
		EventSystem.Instance.Add(EEventName.ResetModuleByResetToBattleView, this.OnPlayerDead);
		EventSystem.Instance.Add(EEventName.OnGetFriendInitData, new Action(this.OnGetFriendInitData));
		EventSystem.Instance.Add<WorldTeamPlayerInfoChangeNotify>(EEventName.OnWorldTeamPlayerInfoChanged, new Action<WorldTeamPlayerInfoChangeNotify>(this.OnWorldTeamPlayerInfoChanged));
		EventSystem.Instance.Add(EEventName.TsSyncChatEnterTeam, new Action(this.OnEnterTeam));
		EventSystem.Instance.Add(EEventName.TsSyncChatLeaveTeam, new Action(this.OnLeaveTeam));
		EventSystem.Instance.Add(EEventName.TsSyncChatEnterOnlineWorld, new Action(this.OnEnterOnlineWorld));
		EventSystem.Instance.Add(EEventName.TsSyncChatLeaveOnlineWorld, new Action(this.OnLeaveOnlineWorld));
		EventSystem.Instance.Add<double, double, double, double>(EEventName.TsSyncTime, new Action<double, double, double, double>(this.OnTsSyncTime));
		EventSystem.Instance.Add<int>(EEventName.TsSyncAddMutePlayer, new Action<int>(this.TsSyncAddMutePlayer));
		EventSystem.Instance.Add<int>(EEventName.TsSyncRemoveMutePlayer, new Action<int>(this.TsSyncRemoveMutePlayer));
	}

	// Token: 0x0600AF40 RID: 44864 RVA: 0x0027964C File Offset: 0x0027784C
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnSelectChatFriend, this.OnSelectChatFriend);
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.OpenView, this.OnOpenView);
		EventSystem.Instance.Remove(EEventName.OnEnterTeam, new Action(this.OnEnterTeam));
		EventSystem.Instance.Remove(EEventName.OnLeaveTeam, new Action(this.OnLeaveTeam));
		EventSystem.Instance.Remove(EEventName.OnEnterOnlineWorld, new Action(this.OnEnterOnlineWorld));
		EventSystem.Instance.Remove(EEventName.OnLeaveOnlineWorld, new Action(this.OnLeaveOnlineWorld));
		EventSystem.Instance.Remove<int>(EEventName.OnRemoveFriend, this.OnRemoveFriend);
		EventSystem.Instance.Remove(EEventName.ResetModuleByResetToBattleView, this.OnPlayerDead);
		EventSystem.Instance.Remove(EEventName.OnGetFriendInitData, new Action(this.OnGetFriendInitData));
		EventSystem.Instance.Remove(EEventName.OnWorldTeamPlayerInfoChanged, new Action<WorldTeamPlayerInfoChangeNotify>(this.OnWorldTeamPlayerInfoChanged));
		EventSystem.Instance.Remove(EEventName.TsSyncChatEnterTeam, new Action(this.OnEnterTeam));
		EventSystem.Instance.Remove(EEventName.TsSyncChatLeaveTeam, new Action(this.OnLeaveTeam));
		EventSystem.Instance.Remove(EEventName.TsSyncChatEnterOnlineWorld, new Action(this.OnEnterOnlineWorld));
		EventSystem.Instance.Remove(EEventName.TsSyncChatLeaveOnlineWorld, new Action(this.OnLeaveOnlineWorld));
		EventSystem.Instance.Remove(EEventName.TsSyncTime, new Action<double, double, double, double>(this.OnTsSyncTime));
		EventSystem.Instance.Remove(EEventName.TsSyncAddMutePlayer, new Action<int>(this.TsSyncAddMutePlayer));
		EventSystem.Instance.Remove(EEventName.TsSyncRemoveMutePlayer, new Action<int>(this.TsSyncRemoveMutePlayer));
	}

	// Token: 0x0600AF41 RID: 44865 RVA: 0x0027981C File Offset: 0x00277A1C
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.PrivateMessageNotify, new Action<IMessage, Net.CallbackStatus>(this.PrivateMessageNotify));
		Net.Instance.Register(ENotifyMessageId.ChannelChatMessageNotify, new Action<IMessage, Net.CallbackStatus>(this.ChannelChatMessageNotify));
		Net.Instance.Register(ENotifyMessageId.PrivateChatHistoryNotify, new Action<IMessage, Net.CallbackStatus>(this.PrivateChatHistoryNotify));
		Net.Instance.Register(ENotifyMessageId.ChannelChatHistoryNotify, new Action<IMessage, Net.CallbackStatus>(this.ChannelChatHistoryNotify));
		Net.Instance.Register(ENotifyMessageId.ChatMutePlayerListNotify, new Action<IMessage, Net.CallbackStatus>(this.ChatMutePlayerListNotify));
		Net.Instance.Register(ENotifyMessageId.BanChatNotify, new Action<IMessage, Net.CallbackStatus>(this.BanChatNotify));
		Net.Instance.Register(ENotifyMessageId.PrivateChatClearNotify, new Action<IMessage, Net.CallbackStatus>(this.PrivateChatClearNotify));
	}

	// Token: 0x0600AF42 RID: 44866 RVA: 0x002798F0 File Offset: 0x00277AF0
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.PrivateMessageNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ChannelChatMessageNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PrivateChatHistoryNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ChannelChatHistoryNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ChatMutePlayerListNotify);
		Net.Instance.UnRegister(ENotifyMessageId.BanChatNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PrivateChatClearNotify);
	}

	// Token: 0x0600AF43 RID: 44867 RVA: 0x0027996D File Offset: 0x00277B6D
	private void OnEnterOnlineWorld()
	{
		if (ChatModel.Instance.GetWorldChatRoom() == null)
		{
			ChatModel.Instance.SetWorldChatRoom(ChatModel.Instance.NewWorldChatRoom());
		}
	}

	// Token: 0x0600AF44 RID: 44868 RVA: 0x00279990 File Offset: 0x00277B90
	private void OnLeaveOnlineWorld()
	{
		ChatModel instance = ChatModel.Instance;
		instance.SetWorldChatRoom(null);
		instance.SetTeamChatRowDataVisible(false);
		WorldChatRoom worldChatRoom = instance.GetWorldChatRoom();
		if (worldChatRoom != null)
		{
			instance.SetChatRoomRedDot(worldChatRoom, false);
		}
		if (UiManager.Instance.IsViewShow(EUiViewName.ChatView))
		{
			UiManager.Instance.CloseView(EUiViewName.ChatView, null);
		}
	}

	// Token: 0x0600AF45 RID: 44869 RVA: 0x002799E4 File Offset: 0x00277BE4
	private void OnEnterTeam()
	{
		ChatModel instance = ChatModel.Instance;
		instance.SetTeamChatRoom(instance.NewTeamChatRoom());
	}

	// Token: 0x0600AF46 RID: 44870 RVA: 0x002799F8 File Offset: 0x00277BF8
	private void OnLeaveTeam()
	{
		ChatModel instance = ChatModel.Instance;
		instance.SetTeamChatRoom(null);
		instance.SetTeamChatRowDataVisible(false);
		TeamChatRoom teamChatRoom = instance.GetTeamChatRoom();
		if (teamChatRoom != null)
		{
			instance.SetChatRoomRedDot(teamChatRoom, false);
		}
		if (UiManager.Instance.IsViewShow(EUiViewName.ChatView))
		{
			UiManager.Instance.CloseView(EUiViewName.ChatView, null);
		}
	}

	// Token: 0x0600AF47 RID: 44871 RVA: 0x00279A4C File Offset: 0x00277C4C
	private void OnTsSyncTime(double serverTime, double flowTime, double predictedServerCombatTimeOffset, double predictedServerStopTimeOffset)
	{
		Time.Instance.SyncTime(serverTime, flowTime, predictedServerCombatTimeOffset, predictedServerStopTimeOffset);
	}

	// Token: 0x0600AF48 RID: 44872 RVA: 0x00279A5D File Offset: 0x00277C5D
	private void TsSyncAddMutePlayer(int playerId)
	{
		ChatModel.Instance.AddMutePlayer(playerId);
	}

	// Token: 0x0600AF49 RID: 44873 RVA: 0x00279A6A File Offset: 0x00277C6A
	private void TsSyncRemoveMutePlayer(int playerId)
	{
		ChatModel.Instance.RemoveMutePlayer(playerId);
	}

	// Token: 0x0600AF4A RID: 44874 RVA: 0x00279A78 File Offset: 0x00277C78
	public void PrivateChatRequest(ChatContentType chatContentType, string content, int targetPlayerId)
	{
		List<int> limitedPlayerIdList = new List<int>();
		if (!KuroSdkModel.Instance.GetPlayerChatPermission(targetPlayerId))
		{
			limitedPlayerIdList.Add(targetPlayerId);
		}
		KuroSdkController.Instance.GetCommunicationRestricted(PlayerInfoModel.Instance.GetThirdPartyAccountId(), delegate(ESdkCommunicationRestricted state)
		{
			if (state == ESdkCommunicationRestricted.Yes)
			{
				ScrollingTipsController.Instance.ShowTipsByText(ConfigMultiTextLang.GetLocalTextNew("CommunicationRectricted", null));
				this.OpenThirdPartyMessageBox().Forget();
				return;
			}
			if (targetPlayerId == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Chat;
				ELogAuthor author = ELogAuthor.LJQ;
				string message = "PrivateChatRequest 私聊对象玩家Id不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("targetPlayerId", targetPlayerId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			PrivateChatRequest privateChatRequest = Aki.Protocol.PrivateChatRequest.Create();
			privateChatRequest.ChatContentType = chatContentType;
			privateChatRequest.Content = content;
			privateChatRequest.TargetUID = targetPlayerId;
			privateChatRequest.XboxBlockedPlayerIds.AddRange(limitedPlayerIdList);
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Chat;
			ELogAuthor author2 = ELogAuthor.LJQ;
			string message2 = "PrivateChatRequest 客户端请求私聊聊天";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("request", privateChatRequest);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			Net.Instance.Call(ERequestMessageId.PrivateChatRequest, privateChatRequest, new Action<IMessage, Net.CallbackStatus>(base.<PrivateChatRequest>g__ResponseCallback|1), 0);
		});
	}

	// Token: 0x0600AF4B RID: 44875 RVA: 0x00279AF8 File Offset: 0x00277CF8
	private UniTask OpenThirdPartyMessageBox()
	{
		ChatController.<OpenThirdPartyMessageBox>d__19 <OpenThirdPartyMessageBox>d__;
		<OpenThirdPartyMessageBox>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenThirdPartyMessageBox>d__.<>1__state = -1;
		<OpenThirdPartyMessageBox>d__.<>t__builder.Start<ChatController.<OpenThirdPartyMessageBox>d__19>(ref <OpenThirdPartyMessageBox>d__);
		return <OpenThirdPartyMessageBox>d__.<>t__builder.Task;
	}

	// Token: 0x0600AF4C RID: 44876 RVA: 0x00279B34 File Offset: 0x00277D34
	public void ChannelChatRequest(ChatContentType chatContentType, string content, SubChatChannelType subChannelType)
	{
		List<int> list = new List<int>();
		if (subChannelType == SubChatChannelType.MatchTeam)
		{
			MatchTeamInfo matchTeamInfo = InstanceDungeonModel.Instance.GetMatchTeamInfo();
			if (matchTeamInfo == null)
			{
				goto IL_CB;
			}
			using (IEnumerator<MatchPlayerInfo> enumerator = matchTeamInfo.PlayerInfos.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					MatchPlayerInfo matchPlayerInfo = enumerator.Current;
					list.Add(matchPlayerInfo.PlayerId);
				}
				goto IL_CB;
			}
		}
		if (subChannelType == SubChatChannelType.WorldTeam)
		{
			List<OnlineTeamData> teamList = OnlineModel.Instance.GetTeamList();
			if (teamList != null)
			{
				foreach (OnlineTeamData onlineTeamData in teamList)
				{
					list.Add(onlineTeamData.PlayerId);
				}
			}
		}
		IL_CB:
		List<int> limitedPlayerIdList = new List<int>();
		foreach (int num in list)
		{
			if (!KuroSdkModel.Instance.GetPlayerChatPermission(num))
			{
				limitedPlayerIdList.Add(num);
			}
		}
		KuroSdkController.Instance.GetCommunicationRestricted(PlayerInfoModel.Instance.GetThirdPartyAccountId(), delegate(ESdkCommunicationRestricted state)
		{
			if (state == ESdkCommunicationRestricted.Yes)
			{
				ScrollingTipsController.Instance.ShowTipsByText(ConfigMultiTextLang.GetLocalTextNew("CommunicationRectricted", null));
				this.OpenThirdPartyMessageBox().Forget();
				return;
			}
			ChannelChatRequest channelChatRequest = Aki.Protocol.ChannelChatRequest.Create();
			channelChatRequest.ChannelType = ChatChannelType.Team;
			channelChatRequest.SubChannelType = subChannelType;
			channelChatRequest.ChatContentType = chatContentType;
			channelChatRequest.Content = content;
			channelChatRequest.XboxBlockedPlayerIds.AddRange(limitedPlayerIdList);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Chat;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "ChannelChatRequest 客户端请求队伍聊天";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("request", channelChatRequest);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			Net instance2 = Net.Instance;
			ERequestMessageId requestMessageId = ERequestMessageId.ChannelChatRequest;
			IMessage message2 = channelChatRequest;
			Action<IMessage, Net.CallbackStatus> handle;
			if ((handle = ChatController.<>O.<0>__ResponseCallback) == null)
			{
				handle = (ChatController.<>O.<0>__ResponseCallback = new Action<IMessage, Net.CallbackStatus>(ChatController.<ChannelChatRequest>g__ResponseCallback|20_1));
			}
			instance2.Call(requestMessageId, message2, handle, 0);
		});
	}

	// Token: 0x0600AF4D RID: 44877 RVA: 0x00279CA8 File Offset: 0x00277EA8
	private UniTask OnPrivateMessageNotify(PrivateMessageNotify notify, [Nullable(2)] Net.CallbackStatus status)
	{
		ChatController.<OnPrivateMessageNotify>d__21 <OnPrivateMessageNotify>d__;
		<OnPrivateMessageNotify>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPrivateMessageNotify>d__.<>4__this = this;
		<OnPrivateMessageNotify>d__.notify = notify;
		<OnPrivateMessageNotify>d__.<>1__state = -1;
		<OnPrivateMessageNotify>d__.<>t__builder.Start<ChatController.<OnPrivateMessageNotify>d__21>(ref <OnPrivateMessageNotify>d__);
		return <OnPrivateMessageNotify>d__.<>t__builder.Task;
	}

	// Token: 0x0600AF4E RID: 44878 RVA: 0x00279CF4 File Offset: 0x00277EF4
	[NullableContext(2)]
	private void PrivateMessageNotify(IMessage msg, Net.CallbackStatus status)
	{
		PrivateMessageNotify notify = (PrivateMessageNotify)msg;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Chat;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "PrivateMessageNotify 私聊聊天服务端通知";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("notify", notify);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (!KuroSdkController.Instance.CheckPrivilege(ESdkPrivilege.UserGeneratedContent))
		{
			Log.Instance.Info(ELogModule.Chat, ELogAuthor.LJQ, "PrivateMessageNotify 玩家没有UGC权限，无法接收私聊消息", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		KuroSdkController.Instance.GetCommunicationRestricted(PlayerInfoModel.Instance.GetThirdPartyAccountId(), delegate(ESdkCommunicationRestricted state)
		{
			if (state == ESdkCommunicationRestricted.Yes)
			{
				return;
			}
			this.OnPrivateMessageNotify(notify, status).Forget();
		});
	}

	// Token: 0x0600AF4F RID: 44879 RVA: 0x00279D9C File Offset: 0x00277F9C
	private UniTask OnChannelChatMessageNotify(ChannelChatMessageNotify notify, [Nullable(2)] Net.CallbackStatus status)
	{
		ChatController.<OnChannelChatMessageNotify>d__23 <OnChannelChatMessageNotify>d__;
		<OnChannelChatMessageNotify>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnChannelChatMessageNotify>d__.notify = notify;
		<OnChannelChatMessageNotify>d__.<>1__state = -1;
		<OnChannelChatMessageNotify>d__.<>t__builder.Start<ChatController.<OnChannelChatMessageNotify>d__23>(ref <OnChannelChatMessageNotify>d__);
		return <OnChannelChatMessageNotify>d__.<>t__builder.Task;
	}

	// Token: 0x0600AF50 RID: 44880 RVA: 0x00279DE0 File Offset: 0x00277FE0
	[NullableContext(2)]
	private void ChannelChatMessageNotify(IMessage msg, Net.CallbackStatus status)
	{
		ChannelChatMessageNotify notify = (ChannelChatMessageNotify)msg;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Chat;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "ChannelChatMessageNotify 队伍聊天服务端通知";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("notify", notify);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		KuroSdkController.Instance.GetCommunicationRestricted(PlayerInfoModel.Instance.GetThirdPartyAccountId(), delegate(ESdkCommunicationRestricted state)
		{
			if (state == ESdkCommunicationRestricted.Yes)
			{
				return;
			}
			ChatController.Instance.OnChannelChatMessageNotify(notify, status).Forget();
		});
	}

	// Token: 0x0600AF51 RID: 44881 RVA: 0x00279E54 File Offset: 0x00278054
	public void PrivateChatHistoryRequest(int playerId)
	{
		if (!KuroSdkController.Instance.CheckPrivilege(ESdkPrivilege.UserGeneratedContent))
		{
			Log.Instance.Info(ELogModule.Chat, ELogAuthor.LJQ, "PrivateMessageNotify 玩家没有UGC权限，无法接收私聊消息", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		Action<IMessage, Net.CallbackStatus> <>9__1;
		KuroSdkController.Instance.GetCommunicationRestricted(PlayerInfoModel.Instance.GetThirdPartyAccountId(), delegate(ESdkCommunicationRestricted state)
		{
			if (state == ESdkCommunicationRestricted.Yes)
			{
				return;
			}
			PrivateChatHistoryRequest privateChatHistoryRequest = Aki.Protocol.PrivateChatHistoryRequest.Create();
			privateChatHistoryRequest.TargetUID = playerId;
			this.IsInRequestHistory = true;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Chat;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "PrivateChatHistoryRequest 客户端请求最近的私聊记录";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("request", privateChatHistoryRequest);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			Action<IMessage, Net.CallbackStatus> action;
			if ((action = <>9__1) == null)
			{
				action = (<>9__1 = delegate(IMessage msg, Net.CallbackStatus _)
				{
					PrivateChatHistoryResponse privateChatHistoryResponse = (PrivateChatHistoryResponse)msg;
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Chat;
					ELogAuthor author2 = ELogAuthor.LJQ;
					string message2 = "PrivateChatHistoryResponse 私聊聊天历史服务端回应";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("response", privateChatHistoryResponse);
					instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					if (privateChatHistoryResponse == null || privateChatHistoryResponse.ErrorCode > Aki.Protocol.ErrorCode.Success)
					{
						return;
					}
					this.IsInRequestHistory = false;
					ChatModel instance3 = ChatModel.Instance;
					PrivateChatHistoryContentProto privateChatHistoryContentProto = (privateChatHistoryResponse != null) ? privateChatHistoryResponse.Data : null;
					int num = (privateChatHistoryContentProto != null) ? privateChatHistoryContentProto.TargetUID : 0;
					if (num == 0)
					{
						return;
					}
					PrivateChatRoom privateChatRoom = instance3.GetPrivateChatRoom(num);
					if (privateChatRoom == null)
					{
						return;
					}
					RepeatedField<ChatContentProto> repeatedField = (privateChatHistoryContentProto != null) ? privateChatHistoryContentProto.Chats : null;
					if (repeatedField == null || repeatedField.Count <= 0)
					{
						return;
					}
					this.SavePrivateHistoryChatAndOpenChatPad(privateChatRoom, repeatedField.ToList<ChatContentProto>(), playerId).Forget();
				});
			}
			Action<IMessage, Net.CallbackStatus> handle = action;
			Net.Instance.Call(ERequestMessageId.PrivateChatHistoryRequest, privateChatHistoryRequest, handle, 0);
		});
	}

	// Token: 0x0600AF52 RID: 44882 RVA: 0x00279EC4 File Offset: 0x002780C4
	private UniTask SavePrivateHistoryChatAndOpenChatPad(PrivateChatRoom chatRoom, List<ChatContentProto> data, int playerId)
	{
		ChatController.<SavePrivateHistoryChatAndOpenChatPad>d__26 <SavePrivateHistoryChatAndOpenChatPad>d__;
		<SavePrivateHistoryChatAndOpenChatPad>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SavePrivateHistoryChatAndOpenChatPad>d__.<>4__this = this;
		<SavePrivateHistoryChatAndOpenChatPad>d__.chatRoom = chatRoom;
		<SavePrivateHistoryChatAndOpenChatPad>d__.data = data;
		<SavePrivateHistoryChatAndOpenChatPad>d__.playerId = playerId;
		<SavePrivateHistoryChatAndOpenChatPad>d__.<>1__state = -1;
		<SavePrivateHistoryChatAndOpenChatPad>d__.<>t__builder.Start<ChatController.<SavePrivateHistoryChatAndOpenChatPad>d__26>(ref <SavePrivateHistoryChatAndOpenChatPad>d__);
		return <SavePrivateHistoryChatAndOpenChatPad>d__.<>t__builder.Task;
	}

	// Token: 0x0600AF53 RID: 44883 RVA: 0x00279F20 File Offset: 0x00278120
	private UniTask OnPrivateChatHistoryNotify(PrivateChatHistoryNotify notify, [Nullable(2)] Net.CallbackStatus status)
	{
		ChatController.<OnPrivateChatHistoryNotify>d__27 <OnPrivateChatHistoryNotify>d__;
		<OnPrivateChatHistoryNotify>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPrivateChatHistoryNotify>d__.<>4__this = this;
		<OnPrivateChatHistoryNotify>d__.notify = notify;
		<OnPrivateChatHistoryNotify>d__.<>1__state = -1;
		<OnPrivateChatHistoryNotify>d__.<>t__builder.Start<ChatController.<OnPrivateChatHistoryNotify>d__27>(ref <OnPrivateChatHistoryNotify>d__);
		return <OnPrivateChatHistoryNotify>d__.<>t__builder.Task;
	}

	// Token: 0x0600AF54 RID: 44884 RVA: 0x00279F6C File Offset: 0x0027816C
	[NullableContext(2)]
	private void PrivateChatHistoryNotify(IMessage msg, Net.CallbackStatus status)
	{
		PrivateChatHistoryNotify notify = (PrivateChatHistoryNotify)msg;
		Log.Instance.Info(ELogModule.Chat, ELogAuthor.LJQ, "PrivateChatHistoryNotify 服务端推送最近的私人聊天历史记录", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (!KuroSdkController.Instance.CheckPrivilege(ESdkPrivilege.UserGeneratedContent))
		{
			Log.Instance.Info(ELogModule.Chat, ELogAuthor.LJQ, "PrivateMessageNotify 玩家没有UGC权限，无法接收私聊消息", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		KuroSdkController.Instance.GetCommunicationRestricted(PlayerInfoModel.Instance.GetThirdPartyAccountId(), delegate(ESdkCommunicationRestricted state)
		{
			if (state == ESdkCommunicationRestricted.Yes)
			{
				return;
			}
			this.OnPrivateChatHistoryNotify(notify, status).Forget();
		});
	}

	// Token: 0x0600AF55 RID: 44885 RVA: 0x0027A004 File Offset: 0x00278204
	private UniTask OnChannelChatHistoryNotify(ChannelChatHistoryNotify notify, [Nullable(2)] Net.CallbackStatus status)
	{
		ChatController.<OnChannelChatHistoryNotify>d__29 <OnChannelChatHistoryNotify>d__;
		<OnChannelChatHistoryNotify>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnChannelChatHistoryNotify>d__.notify = notify;
		<OnChannelChatHistoryNotify>d__.<>1__state = -1;
		<OnChannelChatHistoryNotify>d__.<>t__builder.Start<ChatController.<OnChannelChatHistoryNotify>d__29>(ref <OnChannelChatHistoryNotify>d__);
		return <OnChannelChatHistoryNotify>d__.<>t__builder.Task;
	}

	// Token: 0x0600AF56 RID: 44886 RVA: 0x0027A048 File Offset: 0x00278248
	[NullableContext(2)]
	private void ChannelChatHistoryNotify(IMessage msg, Net.CallbackStatus status)
	{
		ChannelChatHistoryNotify notify = (ChannelChatHistoryNotify)msg;
		Log.Instance.Info(ELogModule.Chat, ELogAuthor.LJQ, "ChannelChatHistoryNotify 服务端推送最近的队伍聊天历史记录", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (!KuroSdkController.Instance.CheckPrivilege(ESdkPrivilege.UserGeneratedContent))
		{
			Log.Instance.Info(ELogModule.Chat, ELogAuthor.LJQ, "PrivateMessageNotify 玩家没有UGC权限，无法接收私聊消息", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		KuroSdkController.Instance.GetCommunicationRestricted(PlayerInfoModel.Instance.GetThirdPartyAccountId(), delegate(ESdkCommunicationRestricted state)
		{
			if (state == ESdkCommunicationRestricted.Yes)
			{
				return;
			}
			ChatController.Instance.OnChannelChatHistoryNotify(notify, status).Forget();
		});
	}

	// Token: 0x0600AF57 RID: 44887 RVA: 0x0027A0D8 File Offset: 0x002782D8
	[NullableContext(2)]
	private void ChatMutePlayerListNotify(IMessage msg, Net.CallbackStatus status)
	{
		ChatMutePlayerListNotify chatMutePlayerListNotify = (ChatMutePlayerListNotify)msg;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Chat;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "ChatMutePlayerListNotify 服务端通知屏蔽列表";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("notify", chatMutePlayerListNotify);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		ChatModel instance2 = ChatModel.Instance;
		instance2.ClearAllMutePlayer();
		foreach (int playerId in chatMutePlayerListNotify.PlayerId)
		{
			instance2.AddMutePlayer(playerId);
		}
	}

	// Token: 0x0600AF58 RID: 44888 RVA: 0x0027A164 File Offset: 0x00278364
	public void ChatMutePlayerRequest(int playerId, bool bMute)
	{
		ChatMutePlayerRequest chatMutePlayerRequest = Aki.Protocol.ChatMutePlayerRequest.Create();
		chatMutePlayerRequest.TargetUID = playerId;
		chatMutePlayerRequest.Mute = bMute;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Chat;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "ChatMutePlayerRequest 客户端请求屏蔽";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("request", chatMutePlayerRequest);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		Net.Instance.Call(ERequestMessageId.ChatMutePlayerRequest, chatMutePlayerRequest, new Action<IMessage, Net.CallbackStatus>(this.ChatMutePlayerResponse), 0);
		if (bMute)
		{
			ChatModel.Instance.AddMutePlayer(playerId);
			EventSystem.Instance.Emit<int>(EEventName.CsRequestAddMutePlayer, playerId);
			return;
		}
		ChatModel.Instance.RemoveMutePlayer(playerId);
		EventSystem.Instance.Emit<int>(EEventName.CsRequestRemoveMutePlayer, playerId);
	}

	// Token: 0x0600AF59 RID: 44889 RVA: 0x0027A208 File Offset: 0x00278408
	[NullableContext(2)]
	private void ChatMutePlayerResponse(IMessage msg, Net.CallbackStatus status)
	{
		ChatMutePlayerResponse chatMutePlayerResponse = (ChatMutePlayerResponse)msg;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Chat;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "ChatMutePlayerResponse 服务端屏蔽回应";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("response", chatMutePlayerResponse);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		RepeatedField<int> repeatedField = (chatMutePlayerResponse != null) ? chatMutePlayerResponse.RemoveMutes : null;
		if (repeatedField == null || repeatedField.Count == 0)
		{
			return;
		}
		ChatModel instance2 = ChatModel.Instance;
		foreach (int num in repeatedField)
		{
			instance2.RemoveMutePlayer(num);
			EventSystem.Instance.Emit<int>(EEventName.CsRequestRemoveMutePlayer, num);
		}
	}

	// Token: 0x0600AF5A RID: 44890 RVA: 0x0027A2B8 File Offset: 0x002784B8
	public void ChatReportPush(int targetPlayerId)
	{
	}

	// Token: 0x0600AF5B RID: 44891 RVA: 0x0027A2BC File Offset: 0x002784BC
	[NullableContext(2)]
	private void BanChatNotify(IMessage msg, Net.CallbackStatus status)
	{
		BanChatNotify banChatNotify = (BanChatNotify)msg;
		this.ShowBanTips(banChatNotify.BanEndTime);
	}

	// Token: 0x0600AF5C RID: 44892 RVA: 0x0027A2DC File Offset: 0x002784DC
	private void ShowBanTips(long time)
	{
		CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat8((double)time - TimeUtil.Instance.GetServerTime());
		string text = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("Text_BanChatTextTime_Text", null), new string[]
		{
			remainTimeDataFormat.CountDownText
		});
		ScrollingTipsController.Instance.ShowTipsByText(text);
	}

	// Token: 0x0600AF5D RID: 44893 RVA: 0x0027A32C File Offset: 0x0027852C
	[NullableContext(2)]
	private void PrivateChatClearNotify(IMessage msg, Net.CallbackStatus status)
	{
		PrivateChatClearNotify privateChatClearNotify = (PrivateChatClearNotify)msg;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Chat;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "PrivateMessageNotify 私聊聊天服务端通知删除信息";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("notify", privateChatClearNotify);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		foreach (int num in privateChatClearNotify.PlayerId)
		{
			ChatModel.Instance.DeletePrivateChat(num);
			PrivateChatRoom privateChatRoom = ChatModel.Instance.GetPrivateChatRoom(num);
			if (privateChatRoom != null)
			{
				privateChatRoom.Close();
			}
			EventSystem.Instance.Emit<int>(EEventName.OnClosePrivateChatRoom, num);
		}
		EventSystem.Instance.Emit<bool>(EEventName.OnRefreshChatRowData, false);
	}

	// Token: 0x0600AF5E RID: 44894 RVA: 0x0027A3E8 File Offset: 0x002785E8
	public void PrivateChatOperateRequest(PrivateChatOperateType operateType, int targetPlayerId)
	{
		PrivateChatOperateRequest privateChatOperateRequest = Aki.Protocol.PrivateChatOperateRequest.Create();
		privateChatOperateRequest.OperateType = operateType;
		privateChatOperateRequest.TarPlayerId = targetPlayerId;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Chat;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "PrivateChatOperateRequest 客户端请求聊天操作";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("request", privateChatOperateRequest);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		Net.Instance.Call(ERequestMessageId.PrivateChatOperateRequest, privateChatOperateRequest, new Action<IMessage, Net.CallbackStatus>(this.PrivateChatOperateResponse), 0);
		if (operateType == PrivateChatOperateType.CloseChat)
		{
			ChatModel.Instance.ClosePrivateChatRoom(targetPlayerId);
		}
	}

	// Token: 0x0600AF5F RID: 44895 RVA: 0x0027A460 File Offset: 0x00278660
	[NullableContext(2)]
	private void PrivateChatOperateResponse(IMessage msg, Net.CallbackStatus status)
	{
		PrivateChatOperateResponse privateChatOperateResponse = (PrivateChatOperateResponse)msg;
		if (privateChatOperateResponse != null && privateChatOperateResponse.ErrorCode == Aki.Protocol.ErrorCode.ErrBanChatDefault)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Chat;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "PrivateChatOperateResponse 聊天操作回应";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("response", privateChatOperateResponse);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600AF60 RID: 44896 RVA: 0x0027A4AE File Offset: 0x002786AE
	public void OpenFriendChat(int friendPlayerId)
	{
		ChatModel.Instance.SelectedPrivateChatFriend(friendPlayerId);
		UiManager.Instance.OpenView(EUiViewName.ChatView, null, null);
	}

	// Token: 0x0600AF61 RID: 44897 RVA: 0x0027A4CC File Offset: 0x002786CC
	public void TryActiveDeleteFriendTips(int playerId)
	{
		if (!UiManager.Instance.IsViewShow(EUiViewName.ChatView))
		{
			return;
		}
		ChatRoom joinedChatRoom = ChatModel.Instance.GetJoinedChatRoom();
		if (joinedChatRoom == null)
		{
			return;
		}
		if (!(joinedChatRoom is PrivateChatRoom))
		{
			return;
		}
		if (((PrivateChatRoom)joinedChatRoom).GetTargetPlayerId() != playerId)
		{
			return;
		}
		ScrollingTipsController.Instance.ShowTipsById("DeleteFriendText", Array.Empty<object>());
	}

	// Token: 0x0600AF62 RID: 44898 RVA: 0x0027A526 File Offset: 0x00278726
	private void OnGetFriendInitData()
	{
		this.PrivateChatDataRequest();
	}

	// Token: 0x0600AF63 RID: 44899 RVA: 0x0027A530 File Offset: 0x00278730
	private void PrivateChatDataRequest()
	{
		PrivateChatDataRequest message = Aki.Protocol.PrivateChatDataRequest.Create();
		Net.Instance.Call(ERequestMessageId.PrivateChatDataRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PrivateChatDataResponse privateChatDataResponse = (PrivateChatDataResponse)msg;
			if (privateChatDataResponse == null || !privateChatDataResponse.LoadSucc)
			{
				if (this.DelayPrivateChatDataRequestTimer != null && TimerSystem.GameplayTimeInstance.Has(this.DelayPrivateChatDataRequestTimer))
				{
					return;
				}
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Chat;
				ELogAuthor author = ELogAuthor.LJQ;
				string message2 = "PrivateChatDataResponse 服务端加载聊天数据失败，等待一段时间后重新请求";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("DelayTime", 60000);
				instance.Info(module, author, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.DelayPrivateChatDataRequestTimer = TimerSystem.GameplayTimeInstance.Delay(new TTimerAction(this.OnDelayPrivateChatDataRequest), 60000f, null, null, true, 1f);
			}
		}, 0);
	}

	// Token: 0x0600AF64 RID: 44900 RVA: 0x0027A560 File Offset: 0x00278760
	private void OnDelayPrivateChatDataRequest(float delta)
	{
		Log.Instance.Info(ELogModule.Chat, ELogAuthor.LJQ, "PrivateChatDataResponse 开始重新请求", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.PrivateChatDataRequest();
		this.DelayPrivateChatDataRequestTimer = null;
	}

	// Token: 0x0600AF65 RID: 44901 RVA: 0x0027A598 File Offset: 0x00278798
	private void OnWorldTeamPlayerInfoChanged(WorldTeamPlayerInfoChangeNotify message)
	{
		int playerId = message.PlayerId;
		ChatPlayerData chatPlayerData = ChatModel.Instance.GetChatPlayerData(playerId);
		if (chatPlayerData == null)
		{
			return;
		}
		switch (message.ChangeType)
		{
		case WorldTeamPlayerChangeType.Name:
			chatPlayerData.SetPlayerName(message.StringValue);
			break;
		case WorldTeamPlayerChangeType.Head:
			chatPlayerData.SetPlayerIcon(new int?(message.IntValue));
			break;
		case WorldTeamPlayerChangeType.PlayerTitle:
			chatPlayerData.SetPlayerTitle(message.StringValue);
			break;
		case WorldTeamPlayerChangeType.Sex:
			chatPlayerData.SetSex(message.IntValue);
			break;
		}
		EventSystem.Instance.Emit<int>(EEventName.OnChatPlayerInfoChanged, playerId);
	}

	// Token: 0x0600AF66 RID: 44902 RVA: 0x0027A630 File Offset: 0x00278830
	public void RequestChatOption(int playerId)
	{
		FriendController.Instance.RequestPlayerCurrentDeactivationState(playerId, delegate(bool deactivation)
		{
			if (deactivation)
			{
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew("PlayerDeleteSelf", null);
				GenericPromptController.Instance.ShowPromptByItsType<object>(EPromptSubViewType.FloatLinePrompt, null, null, new string[]
				{
					localTextNew
				}, null, null, null, null, null, false, null);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.ChatOption, playerId, null);
		});
	}

	// Token: 0x17000E84 RID: 3716
	// (get) Token: 0x0600AF67 RID: 44903 RVA: 0x0027A666 File Offset: 0x00278866
	public static ChatController Instance
	{
		get
		{
			return ChatController._Instance;
		}
	}

	// Token: 0x0600AF68 RID: 44904 RVA: 0x0027A66D File Offset: 0x0027886D
	public static ChatController GetOrCreateInstance()
	{
		if (ChatController._Instance == null)
		{
			ChatController.CreateInstance();
		}
		return ChatController._Instance;
	}

	// Token: 0x0600AF69 RID: 44905 RVA: 0x0027A681 File Offset: 0x00278881
	public static bool CreateInstance()
	{
		if (ChatController._Instance != null)
		{
			return true;
		}
		ChatController._Instance = new ChatController();
		return true;
	}

	// Token: 0x0600AF6A RID: 44906 RVA: 0x0027A697 File Offset: 0x00278897
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600AF6B RID: 44907 RVA: 0x0027A699 File Offset: 0x00278899
	public static void ResetStaticDefaultValue()
	{
		ChatController._Instance = null;
	}

	// Token: 0x0600AF6C RID: 44908 RVA: 0x0027A6A1 File Offset: 0x002788A1
	static ChatController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ChatController.CreateStaticDefaultValue), new Action(ChatController.ResetStaticDefaultValue));
	}

	// Token: 0x0600AF6E RID: 44910 RVA: 0x0027A768 File Offset: 0x00278968
	[NullableContext(2)]
	[CompilerGenerated]
	internal static void <ChannelChatRequest>g__ResponseCallback|20_1(IMessage msg, Net.CallbackStatus _)
	{
		ChannelChatResponse channelChatResponse = (ChannelChatResponse)msg;
		if (channelChatResponse != null && channelChatResponse.ErrorCode <= Aki.Protocol.ErrorCode.Success)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Chat;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "ChannelChatRequest 队伍聊天服务端回应";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("response", channelChatResponse);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (channelChatResponse != null && channelChatResponse.ErrorCode == Aki.Protocol.ErrorCode.ErrBanChatDefault)
		{
			ChatController.Instance.ShowBanTips((channelChatResponse != null) ? channelChatResponse.BanEndTime : 0L);
			return;
		}
		ErrorCodeController.Instance.OpenErrorCodeTipView((channelChatResponse != null) ? channelChatResponse.ErrorCode : Aki.Protocol.ErrorCode.Success, 18195, null, true, true);
	}

	// Token: 0x04004FAF RID: 20399
	public bool IsInRequestHistory;

	// Token: 0x04004FB0 RID: 20400
	[Nullable(2)]
	private TimerHandle DelayPrivateChatDataRequestTimer;

	// Token: 0x04004FB1 RID: 20401
	private readonly Action OnPlayerDead = delegate()
	{
		if (!UiManager.Instance.IsViewShow(EUiViewName.ChatView))
		{
			return;
		}
		UiManager.Instance.CloseView(EUiViewName.ChatView, null);
	};

	// Token: 0x04004FB2 RID: 20402
	private readonly Action<int> OnSelectChatFriend = delegate(int playerId)
	{
		ChatModel.Instance.SelectedPrivateChatFriend(playerId);
	};

	// Token: 0x04004FB3 RID: 20403
	private readonly Action<EUiViewName, int> OnOpenView = delegate(EUiViewName viewName, int id)
	{
		if (viewName != EUiViewName.ChatView)
		{
			return;
		}
		ChatModel.Instance.IsOpenedChatView = true;
		EventSystem.Instance.Emit(EEventName.OnRefreshChatRedDot);
	};

	// Token: 0x04004FB4 RID: 20404
	private readonly Action<int> OnRemoveFriend = delegate(int playerId)
	{
		ChatModel.Instance.RemovePrivateChatRoom(playerId);
	};

	// Token: 0x04004FB5 RID: 20405
	[Nullable(2)]
	private static ChatController _Instance;

	// Token: 0x02007D98 RID: 32152
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04029207 RID: 168455
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <0>__ResponseCallback;
	}
}
