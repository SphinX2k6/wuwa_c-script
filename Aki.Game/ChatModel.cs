using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;

// Token: 0x02001796 RID: 6038
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ChatModel : ModelBase
{
	// Token: 0x0600AFC4 RID: 44996 RVA: 0x0027AA5C File Offset: 0x00278C5C
	protected override bool OnInit()
	{
		this.ShowTimeDifferent = ConfigCommonParamById.GetIntConfig("ShowTimeDifferent").Value;
		return true;
	}

	// Token: 0x0600AFC5 RID: 44997 RVA: 0x0027AA84 File Offset: 0x00278C84
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

	// Token: 0x0600AFC6 RID: 44998 RVA: 0x0027AB08 File Offset: 0x00278D08
	public ChatPlayerData AddChatPlayerData(int playerId)
	{
		ChatPlayerData chatPlayerData = new ChatPlayerData(playerId);
		this.ChatPlayerDataMap[playerId] = chatPlayerData;
		return chatPlayerData;
	}

	// Token: 0x0600AFC7 RID: 44999 RVA: 0x0027AB2C File Offset: 0x00278D2C
	[NullableContext(2)]
	public ChatPlayerData GetChatPlayerData(int playerId)
	{
		ChatPlayerData result;
		this.ChatPlayerDataMap.TryGetValue(playerId, out result);
		return result;
	}

	// Token: 0x0600AFC8 RID: 45000 RVA: 0x0027AB4C File Offset: 0x00278D4C
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

	// Token: 0x0600AFC9 RID: 45001 RVA: 0x0027AC05 File Offset: 0x00278E05
	public void ClearChatPlayerData()
	{
		this.ChatPlayerDataMap.Clear();
	}

	// Token: 0x0600AFCA RID: 45002 RVA: 0x0027AC14 File Offset: 0x00278E14
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

	// Token: 0x0600AFCB RID: 45003 RVA: 0x0027ACDC File Offset: 0x00278EDC
	private void ClearAllCreateTime()
	{
		foreach (PrivateChatRoom privateChatRoom in this.PrivateChatRoomMap.Values)
		{
			privateChatRoom.ClearCreateTime();
		}
	}

	// Token: 0x0600AFCC RID: 45004 RVA: 0x0027AD34 File Offset: 0x00278F34
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

	// Token: 0x0600AFCD RID: 45005 RVA: 0x0027ADAC File Offset: 0x00278FAC
	public void AddChatRowData(int senderPlayerId, string chatContentText, ChatContentType chatContentType, bool isOfflineMassage, EChatRoomType contentChatRoomType, double timeStamp, int? targetPlayerId = null, [Nullable(2)] string senderPlayerName = null, int? senderPlayerIcon = null, bool bCheckLength = true)
	{
		this.PushChatRowData(senderPlayerId, chatContentText, chatContentType, isOfflineMassage, contentChatRoomType, timeStamp, targetPlayerId, senderPlayerName, senderPlayerIcon);
		if (bCheckLength && this.ChatRowDataList.Count > 10)
		{
			this.ShiftChatRowData();
		}
	}

	// Token: 0x0600AFCE RID: 45006 RVA: 0x0027ADE7 File Offset: 0x00278FE7
	public void SortChatRowData()
	{
		this.ChatRowDataList.Sort((ChatRowData a, ChatRowData b) => (int)(a.TimeStamp - b.TimeStamp));
	}

	// Token: 0x0600AFCF RID: 45007 RVA: 0x0027AE14 File Offset: 0x00279014
	public void ClampChatRowDataListLength()
	{
		int count = this.ChatRowDataList.Count;
		if (count <= 10)
		{
			return;
		}
		int count2 = Math.Max(count - 10, 0);
		this.ChatRowDataList = this.ChatRowDataList.Skip(count2).ToList<ChatRowData>();
	}

	// Token: 0x0600AFD0 RID: 45008 RVA: 0x0027AE58 File Offset: 0x00279058
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

	// Token: 0x0600AFD1 RID: 45009 RVA: 0x0027AEE4 File Offset: 0x002790E4
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

	// Token: 0x0600AFD2 RID: 45010 RVA: 0x0027AF54 File Offset: 0x00279154
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

	// Token: 0x0600AFD3 RID: 45011 RVA: 0x0027AFB8 File Offset: 0x002791B8
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

	// Token: 0x0600AFD4 RID: 45012 RVA: 0x0027B02E File Offset: 0x0027922E
	public void ClearChatRowData()
	{
		this.ChatRowDataList.Clear();
	}

	// Token: 0x0600AFD5 RID: 45013 RVA: 0x0027B03C File Offset: 0x0027923C
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
			if (chatRoomType.Contains(chatRowData.ContentChatRoomType))
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

	// Token: 0x0600AFD6 RID: 45014 RVA: 0x0027B1F0 File Offset: 0x002793F0
	private void ShiftChatRowData()
	{
		ChatRowData p = this.ChatRowDataList[0];
		this.ChatRowDataList.RemoveAt(0);
		EventSystem.Instance.Emit<ChatRowData>(EEventName.OnPopChatRowData, p);
	}

	// Token: 0x0600AFD7 RID: 45015 RVA: 0x0027B227 File Offset: 0x00279427
	public IReadOnlyList<ChatRowData> GetChatRowDataList()
	{
		return this.ChatRowDataList;
	}

	// Token: 0x0600AFD8 RID: 45016 RVA: 0x0027B230 File Offset: 0x00279430
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

	// Token: 0x0600AFD9 RID: 45017 RVA: 0x0027B28C File Offset: 0x0027948C
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

	// Token: 0x0600AFDA RID: 45018 RVA: 0x0027B3B0 File Offset: 0x002795B0
	public void AddTeamHistoryChatContent(TeamChatRoomBase chatRoom, List<ChannelChatMessageInfo> chatContents)
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

	// Token: 0x0600AFDB RID: 45019 RVA: 0x0027B494 File Offset: 0x00279694
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

	// Token: 0x0600AFDC RID: 45020 RVA: 0x0027B572 File Offset: 0x00279772
	public void LeaveCurrentChatRoom()
	{
		this.CurrentChatRoom = null;
	}

	// Token: 0x0600AFDD RID: 45021 RVA: 0x0027B57C File Offset: 0x0027977C
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

	// Token: 0x0600AFDE RID: 45022 RVA: 0x0027B608 File Offset: 0x00279808
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

	// Token: 0x0600AFDF RID: 45023 RVA: 0x0027B688 File Offset: 0x00279888
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

	// Token: 0x0600AFE0 RID: 45024 RVA: 0x0027B700 File Offset: 0x00279900
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

	// Token: 0x0600AFE1 RID: 45025 RVA: 0x0027B754 File Offset: 0x00279954
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

	// Token: 0x0600AFE2 RID: 45026 RVA: 0x0027B80A File Offset: 0x00279A0A
	[NullableContext(2)]
	public ChatRoom GetJoinedChatRoom()
	{
		return this.CurrentChatRoom;
	}

	// Token: 0x0600AFE3 RID: 45027 RVA: 0x0027B814 File Offset: 0x00279A14
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

	// Token: 0x0600AFE4 RID: 45028 RVA: 0x0027B8A0 File Offset: 0x00279AA0
	public PrivateChatRoom TryGetPrivateChatRoom(int targetPlayerId)
	{
		PrivateChatRoom privateChatRoom = this.GetPrivateChatRoom(targetPlayerId);
		if (privateChatRoom == null)
		{
			privateChatRoom = this.NewPrivateChatRoom(targetPlayerId);
		}
		return privateChatRoom;
	}

	// Token: 0x0600AFE5 RID: 45029 RVA: 0x0027B8C4 File Offset: 0x00279AC4
	public PrivateChatRoom NewPrivateChatRoom(int targetPlayerId)
	{
		PrivateChatRoom privateChatRoom = new PrivateChatRoom(targetPlayerId, 1);
		this.PrivateChatRoomMap[targetPlayerId] = privateChatRoom;
		EventSystem.Instance.Emit<int>(EEventName.OnCreatePrivateChatRoom, targetPlayerId);
		return privateChatRoom;
	}

	// Token: 0x0600AFE6 RID: 45030 RVA: 0x0027B8F8 File Offset: 0x00279AF8
	public TeamChatRoom NewTeamChatRoom()
	{
		this.TeamChatRoom = new TeamChatRoom(2);
		return this.TeamChatRoom;
	}

	// Token: 0x0600AFE7 RID: 45031 RVA: 0x0027B90C File Offset: 0x00279B0C
	public WorldChatRoom NewWorldChatRoom()
	{
		this.WorldChatRoom = new WorldChatRoom(2);
		return this.WorldChatRoom;
	}

	// Token: 0x0600AFE8 RID: 45032 RVA: 0x0027B920 File Offset: 0x00279B20
	public void SelectedPrivateChatFriend(int targetPlayerId)
	{
		PrivateChatRoom privateChatRoom = this.TryGetPrivateChatRoom(targetPlayerId);
		if (!privateChatRoom.CanChat())
		{
			return;
		}
		this.JoinChatRoom(privateChatRoom);
	}

	// Token: 0x0600AFE9 RID: 45033 RVA: 0x0027B948 File Offset: 0x00279B48
	[NullableContext(2)]
	public PrivateChatRoom GetPrivateChatRoom(int targetPlayerId)
	{
		PrivateChatRoom result;
		this.PrivateChatRoomMap.TryGetValue(targetPlayerId, out result);
		return result;
	}

	// Token: 0x0600AFEA RID: 45034 RVA: 0x0027B965 File Offset: 0x00279B65
	[NullableContext(2)]
	public TeamChatRoom GetTeamChatRoom()
	{
		return this.TeamChatRoom;
	}

	// Token: 0x0600AFEB RID: 45035 RVA: 0x0027B96D File Offset: 0x00279B6D
	[NullableContext(2)]
	public void SetTeamChatRoom(TeamChatRoom teamChatRoom)
	{
		this.TeamChatRoom = teamChatRoom;
	}

	// Token: 0x0600AFEC RID: 45036 RVA: 0x0027B976 File Offset: 0x00279B76
	[NullableContext(2)]
	public WorldChatRoom GetWorldChatRoom()
	{
		return this.WorldChatRoom;
	}

	// Token: 0x0600AFED RID: 45037 RVA: 0x0027B97E File Offset: 0x00279B7E
	[NullableContext(2)]
	public void SetWorldChatRoom(WorldChatRoom worldChatRoom)
	{
		this.WorldChatRoom = worldChatRoom;
	}

	// Token: 0x0600AFEE RID: 45038 RVA: 0x0027B988 File Offset: 0x00279B88
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

	// Token: 0x0600AFEF RID: 45039 RVA: 0x0027BA48 File Offset: 0x00279C48
	public bool IsInPrivateChatRoom(int playerId)
	{
		PrivateChatRoom privateChatRoom = this.GetPrivateChatRoom(playerId);
		return privateChatRoom != null && privateChatRoom.GetIsOpen();
	}

	// Token: 0x0600AFF0 RID: 45040 RVA: 0x0027BA68 File Offset: 0x00279C68
	public void AddMutePlayer(int playerId)
	{
		this.MutePlayerIdList.Add(playerId);
		EventSystem.Instance.Emit<int>(EEventName.OnAddMutePlayer, playerId);
	}

	// Token: 0x0600AFF1 RID: 45041 RVA: 0x0027BA88 File Offset: 0x00279C88
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

	// Token: 0x0600AFF2 RID: 45042 RVA: 0x0027BAC4 File Offset: 0x00279CC4
	public void ClearAllMutePlayer()
	{
		this.MutePlayerIdList.Clear();
	}

	// Token: 0x0600AFF3 RID: 45043 RVA: 0x0027BAD1 File Offset: 0x00279CD1
	public bool IsInMute(int playerId)
	{
		return this.MutePlayerIdList.IndexOf(playerId) >= 0;
	}

	// Token: 0x17000EAB RID: 3755
	// (get) Token: 0x0600AFF4 RID: 45044 RVA: 0x0027BAE5 File Offset: 0x00279CE5
	public static ChatModel Instance
	{
		get
		{
			return ChatModel._Instance;
		}
	}

	// Token: 0x0600AFF5 RID: 45045 RVA: 0x0027BAEC File Offset: 0x00279CEC
	public static ChatModel GetOrCreateInstance()
	{
		if (ChatModel._Instance == null)
		{
			ChatModel.CreateInstance();
		}
		return ChatModel._Instance;
	}

	// Token: 0x0600AFF6 RID: 45046 RVA: 0x0027BB00 File Offset: 0x00279D00
	public static bool CreateInstance()
	{
		if (ChatModel._Instance != null)
		{
			return true;
		}
		ChatModel._Instance = new ChatModel();
		return true;
	}

	// Token: 0x0600AFF7 RID: 45047 RVA: 0x0027BB16 File Offset: 0x00279D16
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600AFF8 RID: 45048 RVA: 0x0027BB18 File Offset: 0x00279D18
	public static void ResetStaticDefaultValue()
	{
		ChatModel._Instance = null;
	}

	// Token: 0x0600AFF9 RID: 45049 RVA: 0x0027BB20 File Offset: 0x00279D20
	static ChatModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ChatModel.CreateStaticDefaultValue), new Action(ChatModel.ResetStaticDefaultValue));
	}

	// Token: 0x04004FDE RID: 20446
	private readonly Dictionary<int, ChatPlayerData> ChatPlayerDataMap = new Dictionary<int, ChatPlayerData>();

	// Token: 0x04004FDF RID: 20447
	private List<ChatRowData> ChatRowDataList = new List<ChatRowData>();

	// Token: 0x04004FE0 RID: 20448
	private int ChatRowDataUniqueId;

	// Token: 0x04004FE1 RID: 20449
	private readonly Dictionary<int, PrivateChatRoom> PrivateChatRoomMap = new Dictionary<int, PrivateChatRoom>();

	// Token: 0x04004FE2 RID: 20450
	[Nullable(2)]
	private TeamChatRoom TeamChatRoom;

	// Token: 0x04004FE3 RID: 20451
	[Nullable(2)]
	private WorldChatRoom WorldChatRoom;

	// Token: 0x04004FE4 RID: 20452
	[Nullable(2)]
	private ChatRoom CurrentChatRoom;

	// Token: 0x04004FE5 RID: 20453
	private readonly List<int> MutePlayerIdList = new List<int>();

	// Token: 0x04004FE6 RID: 20454
	public bool IsOpenedChatView;

	// Token: 0x04004FE7 RID: 20455
	public int ShowTimeDifferent;

	// Token: 0x04004FE8 RID: 20456
	[Nullable(2)]
	private static ChatModel _Instance;
}
