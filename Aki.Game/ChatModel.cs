using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;

// Token: 0x02000C4F RID: 3151
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ChatModel : ModelBase
{
	// Token: 0x060083AC RID: 33708 RVA: 0x00284EE0 File Offset: 0x002830E0
	protected override bool OnInit()
	{
		this.ShowTimeDifferent = ConfigCommonParamById.GetIntConfig("ShowTimeDifferent").Value;
		return true;
	}

	// Token: 0x060083AD RID: 33709 RVA: 0x00284F08 File Offset: 0x00283108
	protected override bool OnClear()
	{
		foreach (PrivateChatRoom privateChatRoom in this.PrivateChatRoomMap.Values)
		{
			privateChatRoom.Reset();
		}
		this.PrivateChatRoomMap.Clear();
		this.ChatRowDataList.Clear();
		this.MutePlayerIdList.Clear();
		this.CurrentChatRoom = null;
		this.ClearChatPlayerData();
		return true;
	}

	// Token: 0x060083AE RID: 33710 RVA: 0x00284F8C File Offset: 0x0028318C
	public ChatPlayerData AddChatPlayerData(int playerId)
	{
		ChatPlayerData chatPlayerData = new ChatPlayerData(playerId);
		this.ChatPlayerDataMap[playerId] = chatPlayerData;
		return chatPlayerData;
	}

	// Token: 0x060083AF RID: 33711 RVA: 0x00284FB0 File Offset: 0x002831B0
	[NullableContext(2)]
	public ChatPlayerData GetChatPlayerData(int playerId)
	{
		ChatPlayerData result;
		this.ChatPlayerDataMap.TryGetValue(playerId, out result);
		return result;
	}

	// Token: 0x060083B0 RID: 33712 RVA: 0x00284FD0 File Offset: 0x002831D0
	[NullableContext(2)]
	public void RefreshChatPlayerData(int playerId, int? playerIcon = null, string playerName = null, int? playerTitleId = null, int? playerTitleExParam = null)
	{
		ChatPlayerData chatPlayerData = this.GetChatPlayerData(playerId);
		if (chatPlayerData == null)
		{
			chatPlayerData = this.AddChatPlayerData(playerId);
		}
		int playerIcon2 = chatPlayerData.GetPlayerIcon();
		string playerName2 = chatPlayerData.GetPlayerName();
		PersonalModel instance = PersonalModel.Instance;
		PersonalInfoData personalInfoData = instance.GetPersonalInfoData();
		if (personalInfoData != null && personalInfoData.PlayerId == playerId)
		{
			chatPlayerData.SetPlayerIcon(new int?(instance.GetHeadPhotoId()));
			chatPlayerData.SetPlayerName(personalInfoData.Name);
		}
		else
		{
			chatPlayerData.SetPlayerIcon(playerIcon);
			chatPlayerData.SetPlayerName(playerName);
			chatPlayerData.SetPlayerTitleId(playerTitleId);
			chatPlayerData.SetPlayerTitleExParam(playerTitleExParam);
		}
		int num = playerIcon2;
		int? num2 = playerIcon;
		if (!(num == num2.GetValueOrDefault() & num2 != null) || playerName2 != playerName)
		{
			EventSystem.Instance.Emit<int>(EEventName.OnChatPlayerInfoChanged, playerId);
		}
	}

	// Token: 0x060083B1 RID: 33713 RVA: 0x00285089 File Offset: 0x00283289
	public void ClearChatPlayerData()
	{
		this.ChatPlayerDataMap.Clear();
	}

	// Token: 0x060083B2 RID: 33714 RVA: 0x00285098 File Offset: 0x00283298
	public void AddChatContent(ChatRoom chatRoom, string contentUniqueId, int senderPlayerId, string chatContentText, ChatContentType chatContentType, ChatChannelNoticeType noticeType, bool isOfflineMassage, double timeStamp, double lastTimeStamp, [Nullable(2)] string senderPlayerName = null, int? senderPlayerIcon = null, [Nullable(2)] string thirdOnlineId = null, [Nullable(2)] string thirdAvoidId = null)
	{
		ChatContentData p = chatRoom.AddChatContent(contentUniqueId, senderPlayerId, chatContentText, chatContentType, noticeType, isOfflineMassage, timeStamp, lastTimeStamp, senderPlayerName, senderPlayerIcon, thirdOnlineId, thirdAvoidId);
		int value = 0;
		EChatRoomType contentChatRoomType = EChatRoomType.None;
		PrivateChatRoom privateChatRoom = chatRoom as PrivateChatRoom;
		if (privateChatRoom != null)
		{
			value = privateChatRoom.GetTargetPlayerId();
			contentChatRoomType = EChatRoomType.Private;
		}
		else if (chatRoom is TeamChatRoom)
		{
			contentChatRoomType = EChatRoomType.Team;
		}
		else if (chatRoom is WorldChatRoom)
		{
			contentChatRoomType = EChatRoomType.World;
		}
		int? id = PlayerInfoModel.Instance.GetId();
		if (!(senderPlayerId == id.GetValueOrDefault() & id != null))
		{
			this.SetChatRoomRedDot(chatRoom, true);
		}
		if (noticeType == ChatChannelNoticeType.None)
		{
			this.AddChatRowData(senderPlayerId, chatContentText, chatContentType, false, contentChatRoomType, timeStamp, new int?(value), senderPlayerName, senderPlayerIcon, true);
		}
		this.ClearAllCreateTime();
		EventSystem.Instance.Emit<ChatRoom, ChatContentData>(EEventName.OnAddChatContent, chatRoom, p);
		EventSystem.Instance.Emit(EEventName.OnRefreshChatRedDot);
	}

	// Token: 0x060083B3 RID: 33715 RVA: 0x00285160 File Offset: 0x00283360
	private void ClearAllCreateTime()
	{
		foreach (PrivateChatRoom privateChatRoom in this.PrivateChatRoomMap.Values)
		{
			privateChatRoom.ClearCreateTime();
		}
	}

	// Token: 0x060083B4 RID: 33716 RVA: 0x002851B8 File Offset: 0x002833B8
	public unsafe void RequestPrivateRoomLocalHistory(PrivateChatRoom chatRoom)
	{
		int uniqueId = chatRoom.GetUniqueId();
		string earliestHistoryContentUniqueId = chatRoom.GetEarliestHistoryContentUniqueId();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Chat;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "===目前暂时屏蔽聊天本地缓存的请求===";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("chatUniqueId", uniqueId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("fromContentUniqueId", earliestHistoryContentUniqueId);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x060083B5 RID: 33717 RVA: 0x00285230 File Offset: 0x00283430
	public void AddChatRowData(int senderPlayerId, string chatContentText, ChatContentType chatContentType, bool isOfflineMassage, EChatRoomType contentChatRoomType, double timeStamp, int? targetPlayerId = null, [Nullable(2)] string senderPlayerName = null, int? senderPlayerIcon = null, bool bCheckLength = true)
	{
		this.PushChatRowData(senderPlayerId, chatContentText, chatContentType, isOfflineMassage, contentChatRoomType, timeStamp, targetPlayerId, senderPlayerName, senderPlayerIcon);
		if (bCheckLength && this.ChatRowDataList.Count > 10)
		{
			this.ShiftChatRowData();
		}
	}

	// Token: 0x060083B6 RID: 33718 RVA: 0x0028526B File Offset: 0x0028346B
	public void SortChatRowData()
	{
		this.ChatRowDataList.Sort((ChatRowData a, ChatRowData b) => (int)(a.TimeStamp - b.TimeStamp));
	}

	// Token: 0x060083B7 RID: 33719 RVA: 0x00285298 File Offset: 0x00283498
	public void ClampChatRowDataListLength()
	{
		int count = this.ChatRowDataList.Count;
		if (count <= 10)
		{
			return;
		}
		int num = Math.Max(count - 10, 0);
		List<ChatRowData> list = new List<ChatRowData>(count - num);
		for (int i = num; i < this.ChatRowDataList.Count; i++)
		{
			list.Add(this.ChatRowDataList[i]);
		}
		this.ChatRowDataList = list;
	}

	// Token: 0x060083B8 RID: 33720 RVA: 0x002852FC File Offset: 0x002834FC
	public void DeletePrivateChat(int playerId)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Chat;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "[ChatDebug]删除主界面聊天数据";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("playerId", playerId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		for (int i = 0; i < this.ChatRowDataList.Count; i++)
		{
			int? targetPlayerId = this.ChatRowDataList[i].TargetPlayerId;
			if (targetPlayerId.GetValueOrDefault() == playerId & targetPlayerId != null)
			{
				this.ChatRowDataList.RemoveAt(i);
				i--;
			}
		}
	}

	// Token: 0x060083B9 RID: 33721 RVA: 0x00285388 File Offset: 0x00283588
	public void DeleteTeamChat()
	{
		Log.Instance.Info(ELogModule.Chat, ELogAuthor.LJQ, "[ChatDebug]删除主界面队伍聊天数据", default(ReadOnlySpan<ValueTuple<string, object>>));
		for (int i = 0; i < this.ChatRowDataList.Count; i++)
		{
			ChatRowData chatRowData = this.ChatRowDataList[i];
			if (chatRowData.ContentChatRoomType == EChatRoomType.Team || chatRowData.ContentChatRoomType == EChatRoomType.World)
			{
				this.ChatRowDataList.RemoveAt(i);
				i--;
			}
		}
	}

	// Token: 0x060083BA RID: 33722 RVA: 0x002853F8 File Offset: 0x002835F8
	public void SetTeamChatRowDataVisible(bool bVisible)
	{
		foreach (ChatRowData chatRowData in this.ChatRowDataList)
		{
			EChatRoomType contentChatRoomType = chatRowData.ContentChatRoomType;
			if (contentChatRoomType == EChatRoomType.Team || contentChatRoomType == EChatRoomType.World)
			{
				chatRowData.IsVisible = bVisible;
			}
		}
	}

	// Token: 0x060083BB RID: 33723 RVA: 0x0028545C File Offset: 0x0028365C
	private void PushChatRowData(int senderPlayerId, string chatContentText, ChatContentType chatContentType, bool isOfflineMassage, EChatRoomType contentChatRoomType, double timeStamp, int? targetPlayerId = null, [Nullable(2)] string senderPlayerName = null, int? senderPlayerIcon = null)
	{
		OnlineTeamData currentTeamListById = OnlineModel.Instance.GetCurrentTeamListById(senderPlayerId);
		int? senderPlayerNumber = (currentTeamListById != null) ? new int?(currentTeamListById.PlayerNumber) : null;
		int chatRowDataUniqueId = this.ChatRowDataUniqueId;
		this.ChatRowDataUniqueId = chatRowDataUniqueId + 1;
		ChatRowData chatRowData = new ChatRowData(chatRowDataUniqueId, senderPlayerId, chatContentText, chatContentType, isOfflineMassage, contentChatRoomType, timeStamp, targetPlayerId, senderPlayerName, senderPlayerIcon, senderPlayerNumber);
		this.ChatRowDataList.Add(chatRowData);
		EventSystem.Instance.Emit<ChatRowData>(EEventName.OnPushChatRowData, chatRowData);
	}

	// Token: 0x060083BC RID: 33724 RVA: 0x002854D2 File Offset: 0x002836D2
	public void ClearChatRowData()
	{
		this.ChatRowDataList.Clear();
	}

	// Token: 0x060083BD RID: 33725 RVA: 0x002854E0 File Offset: 0x002836E0
	public unsafe void RemoveChatRowDataByChatRoomType(params EChatRoomType[] chatRoomType)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Chat;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "[ChatDebug]删除主界面聊天数据---开始";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("chatRoomType", chatRoomType);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("chatRowDataListLength", this.ChatRowDataList.Count);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		List<int> list = new List<int>();
		for (int i = 0; i < this.ChatRowDataList.Count; i++)
		{
			ChatRowData chatRowData = this.ChatRowDataList[i];
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Chat;
			ELogAuthor author2 = ELogAuthor.LJQ;
			string message2 = "[ChatDebug]删除主界面聊天数据---打印当前聊天记录";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Content", chatRowData.Content);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("TimeStamp", chatRowData.TimeStamp);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			if (Array.IndexOf<EChatRoomType>(chatRoomType, chatRowData.ContentChatRoomType) >= 0)
			{
				list.Add(i);
			}
		}
		for (int j = list.Count - 1; j >= 0; j--)
		{
			this.ChatRowDataList.RemoveAt(list[j]);
		}
		Log instance3 = Log.Instance;
		ELogModule module3 = ELogModule.Chat;
		ELogAuthor author3 = ELogAuthor.LJQ;
		string message3 = "[ChatDebug]删除主界面聊天数据---结束";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("removeIndexList", list);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("chatRowDataListLength", this.ChatRowDataList.Count);
		instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
	}

	// Token: 0x060083BE RID: 33726 RVA: 0x00285694 File Offset: 0x00283894
	private void ShiftChatRowData()
	{
		ChatRowData p = this.ChatRowDataList[0];
		this.ChatRowDataList.RemoveAt(0);
		EventSystem.Instance.Emit<ChatRowData>(EEventName.OnPopChatRowData, p);
	}

	// Token: 0x060083BF RID: 33727 RVA: 0x002856CB File Offset: 0x002838CB
	public IReadOnlyList<ChatRowData> GetChatRowDataList()
	{
		return this.ChatRowDataList;
	}

	// Token: 0x060083C0 RID: 33728 RVA: 0x002856D4 File Offset: 0x002838D4
	public bool HasOfflineMassage()
	{
		using (List<ChatRowData>.Enumerator enumerator = this.ChatRowDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.IsOfflineMassage)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060083C1 RID: 33729 RVA: 0x00285730 File Offset: 0x00283930
	public void AddPrivateHistoryChatContent(PrivateChatRoom chatRoom, List<ChatContentProto> chatContents)
	{
		List<IChatHistory> list = new List<IChatHistory>();
		foreach (ChatContentProto chatContentProto in chatContents)
		{
			int senderUID = chatContentProto.SenderUID;
			ChatHistory item = new ChatHistory
			{
				UtcTime = new long?(chatContentProto.UTCTime),
				MsgId = chatContentProto.MsgId,
				SenderUid = new int?(senderUID),
				Content = chatContentProto.Content,
				ChatContentType = chatContentProto.ChatContentType,
				OfflineMsg = new bool?(chatContentProto.OfflineMsg)
			};
			list.Add(item);
			FriendModel instance = FriendModel.Instance;
			FriendData friendData = (instance != null) ? instance.GetFriendById(senderUID) : null;
			if (friendData != null)
			{
				this.RefreshChatPlayerData(senderUID, new int?(friendData.PlayerHeadPhoto), friendData.PlayerName, new int?(friendData.PlayerTitleId), new int?(friendData.PlayerTitleStarLevel));
			}
		}
		chatRoom.AddHistoryChatContent(list);
		chatRoom.Open();
		EventSystem.Instance.Emit<ChatRoom>(EEventName.OnAddHistoryChatContentCompleted, chatRoom);
	}

	// Token: 0x060083C2 RID: 33730 RVA: 0x00285854 File Offset: 0x00283A54
	public void AddTeamHistoryChatContent(TeamChatRoomBase chatRoom, IEnumerable<ChannelChatMessageInfo> chatContents)
	{
		List<IChatHistory> list = new List<IChatHistory>();
		foreach (ChannelChatMessageInfo channelChatMessageInfo in chatContents)
		{
			ChatHistory item = new ChatHistory
			{
				SenderPlayerId = new int?(channelChatMessageInfo.SenderId),
				SenderPlayerName = channelChatMessageInfo.SenderName,
				UtcTime = new long?(channelChatMessageInfo.SendTime),
				SenderIcon = new int?(channelChatMessageInfo.SenderIcon),
				Content = channelChatMessageInfo.Content,
				ChatContentType = channelChatMessageInfo.ChatContentType,
				NoticeType = new ChatChannelNoticeType?(channelChatMessageInfo.NoticeType)
			};
			list.Add(item);
		}
		chatRoom.AddHistoryChatContent(list);
		chatRoom.Open();
		EventSystem.Instance.Emit<ChatRoom>(EEventName.OnAddHistoryChatContentCompleted, chatRoom);
	}

	// Token: 0x060083C3 RID: 33731 RVA: 0x00285934 File Offset: 0x00283B34
	public void JoinChatRoom(ChatRoom chatRoom)
	{
		this.SetChatRoomRedDot(chatRoom, false);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Chat;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = " 加入聊天室";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("UniqueId", chatRoom.GetUniqueId());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (chatRoom.GetIsOpen())
		{
			this.CurrentChatRoom = chatRoom;
			EventSystem.Instance.Emit<ChatRoom>(EEventName.OnJoinChatRoom, chatRoom);
		}
		else
		{
			PrivateChatRoom privateChatRoom = chatRoom as PrivateChatRoom;
			if (privateChatRoom != null)
			{
				if (!privateChatRoom.CanChat())
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Chat;
					ELogAuthor author2 = ELogAuthor.LJQ;
					string message2 = " 加入私人聊天室时，对应好友在黑名单或不在好友列表中，无法加入聊天室";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("UniqueId", chatRoom.GetUniqueId());
					instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return;
				}
				this.CurrentChatRoom = chatRoom;
				this.RequestOpenPrivateChatRoom(privateChatRoom);
			}
			else
			{
				this.CurrentChatRoom = chatRoom;
				this.RequestOpenChatRoom(chatRoom);
			}
		}
		EventSystem.Instance.Emit(EEventName.OnRefreshChatRedDot);
	}

	// Token: 0x060083C4 RID: 33732 RVA: 0x00285A12 File Offset: 0x00283C12
	public void LeaveCurrentChatRoom()
	{
		this.CurrentChatRoom = null;
	}

	// Token: 0x060083C5 RID: 33733 RVA: 0x00285A1C File Offset: 0x00283C1C
	public void RemovePrivateChatRoom(int targetPlayerId)
	{
		PrivateChatRoom privateChatRoom = this.CurrentChatRoom as PrivateChatRoom;
		if (privateChatRoom != null && privateChatRoom.GetTargetPlayerId() == targetPlayerId)
		{
			this.LeaveCurrentChatRoom();
		}
		PrivateChatRoom privateChatRoom2 = this.GetPrivateChatRoom(targetPlayerId);
		if (privateChatRoom2 == null)
		{
			return;
		}
		privateChatRoom2.Reset();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Chat;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = " 删除私人聊天室";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PlayerId", targetPlayerId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.PrivateChatRoomMap.Remove(targetPlayerId);
		EventSystem.Instance.Emit<int>(EEventName.OnRemovePrivateChatRoom, targetPlayerId);
	}

	// Token: 0x060083C6 RID: 33734 RVA: 0x00285AA8 File Offset: 0x00283CA8
	public void ClosePrivateChatRoom(int targetPlayerId)
	{
		PrivateChatRoom privateChatRoom = this.CurrentChatRoom as PrivateChatRoom;
		if (privateChatRoom != null && privateChatRoom.GetTargetPlayerId() == targetPlayerId)
		{
			this.CurrentChatRoom = null;
		}
		PrivateChatRoom privateChatRoom2 = this.GetPrivateChatRoom(targetPlayerId);
		if (privateChatRoom2 == null)
		{
			return;
		}
		privateChatRoom2.Close();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Chat;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = " 关闭私人聊天室";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PlayerId", targetPlayerId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		EventSystem.Instance.Emit<int>(EEventName.OnClosePrivateChatRoom, targetPlayerId);
	}

	// Token: 0x060083C7 RID: 33735 RVA: 0x00285B28 File Offset: 0x00283D28
	public void RequestOpenPrivateChatRoom(PrivateChatRoom privateChatRoom)
	{
		if (privateChatRoom.GetIsOpen())
		{
			return;
		}
		int targetPlayerId = privateChatRoom.GetTargetPlayerId();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Chat;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = " 请求打开私人聊天室";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PlayerId", targetPlayerId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		privateChatRoom.Open();
		ChatController.Instance.PrivateChatHistoryRequest(targetPlayerId);
		this.SetChatRoomRedDot(privateChatRoom, true);
		EventSystem.Instance.Emit<ChatRoom>(EEventName.OnOpenChatRoom, privateChatRoom);
	}

	// Token: 0x060083C8 RID: 33736 RVA: 0x00285BA0 File Offset: 0x00283DA0
	public void RequestOpenChatRoom(ChatRoom chatRoom)
	{
		if (chatRoom.GetIsOpen())
		{
			return;
		}
		Log.Instance.Info(ELogModule.Chat, ELogAuthor.LJQ, " 请求打开队伍/联机聊天室 ", default(ReadOnlySpan<ValueTuple<string, object>>));
		chatRoom.Open();
		this.SetChatRoomRedDot(chatRoom, true);
		EventSystem.Instance.Emit<ChatRoom>(EEventName.OnOpenChatRoom, chatRoom);
	}

	// Token: 0x060083C9 RID: 33737 RVA: 0x00285BF4 File Offset: 0x00283DF4
	public void SetChatRoomRedDot(ChatRoom chatRoom, bool bVisible)
	{
		if (chatRoom == null)
		{
			return;
		}
		if (chatRoom.GetIsShowRedDot() == bVisible)
		{
			return;
		}
		ChatRoom joinedChatRoom = this.GetJoinedChatRoom();
		int? num = (joinedChatRoom != null) ? new int?(joinedChatRoom.GetUniqueId()) : null;
		int uniqueId = chatRoom.GetUniqueId();
		if (num.GetValueOrDefault() == uniqueId & num != null)
		{
			return;
		}
		chatRoom.SetIsShowRedDot(bVisible);
		PrivateChatRoom privateChatRoom = chatRoom as PrivateChatRoom;
		if (privateChatRoom != null)
		{
			int targetPlayerId = privateChatRoom.GetTargetPlayerId();
			EventSystem.Instance.Emit<int>(EEventName.OnRefreshChatRoomRedDot, targetPlayerId);
			return;
		}
		if (chatRoom is TeamChatRoom)
		{
			EventSystem.Instance.Emit<int>(EEventName.OnRefreshChatRoomRedDot, 2);
			return;
		}
		if (chatRoom is WorldChatRoom)
		{
			EventSystem.Instance.Emit<int>(EEventName.OnRefreshChatRoomRedDot, 3);
		}
	}

	// Token: 0x060083CA RID: 33738 RVA: 0x00285CAA File Offset: 0x00283EAA
	[NullableContext(2)]
	public ChatRoom GetJoinedChatRoom()
	{
		return this.CurrentChatRoom;
	}

	// Token: 0x060083CB RID: 33739 RVA: 0x00285CB4 File Offset: 0x00283EB4
	public bool HasRedDot()
	{
		using (Dictionary<int, PrivateChatRoom>.ValueCollection.Enumerator enumerator = this.PrivateChatRoomMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.GetIsShowRedDot())
				{
					return true;
				}
			}
		}
		TeamChatRoom teamChatRoom = this.TeamChatRoom;
		if (teamChatRoom != null && teamChatRoom.GetIsShowRedDot())
		{
			return true;
		}
		WorldChatRoom worldChatRoom = this.WorldChatRoom;
		return worldChatRoom != null && worldChatRoom.GetIsShowRedDot();
	}

	// Token: 0x060083CC RID: 33740 RVA: 0x00285D40 File Offset: 0x00283F40
	public PrivateChatRoom TryGetPrivateChatRoom(int targetPlayerId)
	{
		PrivateChatRoom privateChatRoom = this.GetPrivateChatRoom(targetPlayerId);
		if (privateChatRoom == null)
		{
			privateChatRoom = this.NewPrivateChatRoom(targetPlayerId);
		}
		return privateChatRoom;
	}

	// Token: 0x060083CD RID: 33741 RVA: 0x00285D64 File Offset: 0x00283F64
	public PrivateChatRoom NewPrivateChatRoom(int targetPlayerId)
	{
		PrivateChatRoom privateChatRoom = new PrivateChatRoom(targetPlayerId, 1);
		this.PrivateChatRoomMap[targetPlayerId] = privateChatRoom;
		EventSystem.Instance.Emit<int>(EEventName.OnCreatePrivateChatRoom, targetPlayerId);
		return privateChatRoom;
	}

	// Token: 0x060083CE RID: 33742 RVA: 0x00285D98 File Offset: 0x00283F98
	public TeamChatRoom NewTeamChatRoom()
	{
		this.TeamChatRoom = new TeamChatRoom(2);
		return this.TeamChatRoom;
	}

	// Token: 0x060083CF RID: 33743 RVA: 0x00285DAC File Offset: 0x00283FAC
	public WorldChatRoom NewWorldChatRoom()
	{
		this.WorldChatRoom = new WorldChatRoom(2);
		return this.WorldChatRoom;
	}

	// Token: 0x060083D0 RID: 33744 RVA: 0x00285DC0 File Offset: 0x00283FC0
	public void SelectedPrivateChatFriend(int targetPlayerId)
	{
		PrivateChatRoom privateChatRoom = this.TryGetPrivateChatRoom(targetPlayerId);
		if (!privateChatRoom.CanChat())
		{
			return;
		}
		this.JoinChatRoom(privateChatRoom);
	}

	// Token: 0x060083D1 RID: 33745 RVA: 0x00285DE8 File Offset: 0x00283FE8
	[NullableContext(2)]
	public PrivateChatRoom GetPrivateChatRoom(int targetPlayerId)
	{
		PrivateChatRoom result;
		this.PrivateChatRoomMap.TryGetValue(targetPlayerId, out result);
		return result;
	}

	// Token: 0x060083D2 RID: 33746 RVA: 0x00285E05 File Offset: 0x00284005
	[NullableContext(2)]
	public TeamChatRoom GetTeamChatRoom()
	{
		return this.TeamChatRoom;
	}

	// Token: 0x060083D3 RID: 33747 RVA: 0x00285E0D File Offset: 0x0028400D
	[NullableContext(2)]
	public void SetTeamChatRoom(TeamChatRoom teamChatRoom)
	{
		this.TeamChatRoom = teamChatRoom;
	}

	// Token: 0x060083D4 RID: 33748 RVA: 0x00285E16 File Offset: 0x00284016
	[NullableContext(2)]
	public WorldChatRoom GetWorldChatRoom()
	{
		return this.WorldChatRoom;
	}

	// Token: 0x060083D5 RID: 33749 RVA: 0x00285E1E File Offset: 0x0028401E
	[NullableContext(2)]
	public void SetWorldChatRoom(WorldChatRoom worldChatRoom)
	{
		this.WorldChatRoom = worldChatRoom;
	}

	// Token: 0x060083D6 RID: 33750 RVA: 0x00285E28 File Offset: 0x00284028
	public List<ChatRoom> GetAllSortedChatRoom()
	{
		List<ChatRoom> list = new List<ChatRoom>();
		foreach (PrivateChatRoom privateChatRoom in this.PrivateChatRoomMap.Values)
		{
			if (privateChatRoom.GetIsOpen() && privateChatRoom.CanChat())
			{
				list.Add(privateChatRoom);
			}
		}
		list.Sort(delegate(ChatRoom a, ChatRoom b)
		{
			double lastTimeStamp = a.GetLastTimeStamp();
			double lastTimeStamp2 = b.GetLastTimeStamp();
			if (lastTimeStamp == 0.0)
			{
				return -1;
			}
			if (lastTimeStamp2 == 0.0)
			{
				return 1;
			}
			if (lastTimeStamp != lastTimeStamp2)
			{
				return lastTimeStamp2.CompareTo(lastTimeStamp);
			}
			return b.GetCreateTimeStamp().CompareTo(a.GetCreateTimeStamp());
		});
		TeamChatRoom teamChatRoom = this.GetTeamChatRoom();
		if (teamChatRoom != null)
		{
			list.Insert(0, teamChatRoom);
			return list;
		}
		WorldChatRoom worldChatRoom = this.GetWorldChatRoom();
		if (worldChatRoom != null)
		{
			list.Insert(0, worldChatRoom);
		}
		return list;
	}

	// Token: 0x060083D7 RID: 33751 RVA: 0x00285EE8 File Offset: 0x002840E8
	public bool IsInPrivateChatRoom(int playerId)
	{
		PrivateChatRoom privateChatRoom = this.GetPrivateChatRoom(playerId);
		return privateChatRoom != null && privateChatRoom.GetIsOpen();
	}

	// Token: 0x060083D8 RID: 33752 RVA: 0x00285F08 File Offset: 0x00284108
	public void AddMutePlayer(int playerId)
	{
		this.MutePlayerIdList.Add(playerId);
		EventSystem.Instance.Emit<int>(EEventName.OnAddMutePlayer, playerId);
	}

	// Token: 0x060083D9 RID: 33753 RVA: 0x00285F28 File Offset: 0x00284128
	public void RemoveMutePlayer(int playerId)
	{
		int num = this.MutePlayerIdList.IndexOf(playerId);
		if (num < 0)
		{
			return;
		}
		this.MutePlayerIdList.RemoveAt(num);
		EventSystem.Instance.Emit<int>(EEventName.OnRemoveMutePlayer, playerId);
	}

	// Token: 0x060083DA RID: 33754 RVA: 0x00285F64 File Offset: 0x00284164
	public void ClearAllMutePlayer()
	{
		this.MutePlayerIdList.Clear();
	}

	// Token: 0x060083DB RID: 33755 RVA: 0x00285F71 File Offset: 0x00284171
	public bool IsInMute(int playerId)
	{
		return this.MutePlayerIdList.IndexOf(playerId) >= 0;
	}

	// Token: 0x17000ECE RID: 3790
	// (get) Token: 0x060083DC RID: 33756 RVA: 0x00285F85 File Offset: 0x00284185
	public static ChatModel Instance
	{
		get
		{
			return ChatModel._Instance;
		}
	}

	// Token: 0x060083DD RID: 33757 RVA: 0x00285F8C File Offset: 0x0028418C
	public static ChatModel GetOrCreateInstance()
	{
		if (ChatModel._Instance == null)
		{
			ChatModel.CreateInstance();
		}
		return ChatModel._Instance;
	}

	// Token: 0x060083DE RID: 33758 RVA: 0x00285FA0 File Offset: 0x002841A0
	public static bool CreateInstance()
	{
		if (ChatModel._Instance != null)
		{
			return true;
		}
		ChatModel._Instance = new ChatModel();
		return true;
	}

	// Token: 0x060083DF RID: 33759 RVA: 0x00285FB6 File Offset: 0x002841B6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060083E0 RID: 33760 RVA: 0x00285FB8 File Offset: 0x002841B8
	public static void ResetStaticDefaultValue()
	{
		ChatModel._Instance = null;
	}

	// Token: 0x060083E1 RID: 33761 RVA: 0x00285FC0 File Offset: 0x002841C0
	static ChatModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ChatModel.CreateStaticDefaultValue), new Action(ChatModel.ResetStaticDefaultValue));
	}

	// Token: 0x04005088 RID: 20616
	private readonly Dictionary<int, ChatPlayerData> ChatPlayerDataMap = new Dictionary<int, ChatPlayerData>();

	// Token: 0x04005089 RID: 20617
	private List<ChatRowData> ChatRowDataList = new List<ChatRowData>();

	// Token: 0x0400508A RID: 20618
	private int ChatRowDataUniqueId;

	// Token: 0x0400508B RID: 20619
	private readonly Dictionary<int, PrivateChatRoom> PrivateChatRoomMap = new Dictionary<int, PrivateChatRoom>();

	// Token: 0x0400508C RID: 20620
	[Nullable(2)]
	private TeamChatRoom TeamChatRoom;

	// Token: 0x0400508D RID: 20621
	[Nullable(2)]
	private WorldChatRoom WorldChatRoom;

	// Token: 0x0400508E RID: 20622
	[Nullable(2)]
	private ChatRoom CurrentChatRoom;

	// Token: 0x0400508F RID: 20623
	private readonly List<int> MutePlayerIdList = new List<int>();

	// Token: 0x04005090 RID: 20624
	public bool IsOpenedChatView;

	// Token: 0x04005091 RID: 20625
	public int ShowTimeDifferent;

	// Token: 0x04005092 RID: 20626
	[Nullable(2)]
	private static ChatModel _Instance;
}
