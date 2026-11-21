using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000C55 RID: 3157
public class TeamChatRoomBase : ChatRoom
{
	// Token: 0x06008410 RID: 33808 RVA: 0x002866C1 File Offset: 0x002848C1
	public TeamChatRoomBase(EChatRoomType chatRoomType, int configId) : base(chatRoomType, configId)
	{
	}

	// Token: 0x06008411 RID: 33809 RVA: 0x002866CC File Offset: 0x002848CC
	[NullableContext(1)]
	public override void AddHistoryChatContent(List<IChatHistory> chatContents)
	{
		this.EarliestHistoryContentUniqueId = "";
		List<ChatContentData> list = new List<ChatContentData>();
		ChatContentData chatContentData = null;
		foreach (IChatHistory chatHistory in chatContents)
		{
			int? senderPlayerId = chatHistory.SenderPlayerId;
			string content = chatHistory.Content;
			ChatContentType chatContentType = chatHistory.ChatContentType;
			ChatChannelNoticeType? noticeType = chatHistory.NoticeType;
			bool isOfflineMassage = true;
			string contentUniqueId = "";
			long? utcTime = chatHistory.UtcTime;
			double timeStamp;
			if (utcTime != null)
			{
				timeStamp = (double)utcTime.Value;
			}
			else
			{
				timeStamp = TimeUtil.Instance.GetServerTime();
			}
			double lastTimeStamp = 0.0;
			if (chatContentData != null)
			{
				lastTimeStamp = chatContentData.TimeStamp;
			}
			int? num = null;
			string senderPlayerName = chatHistory.SenderPlayerName;
			num = chatHistory.SenderIcon;
			ChatContentData chatContentData2 = new ChatContentData(contentUniqueId, senderPlayerId.Value, content, chatContentType, noticeType.Value, isOfflineMassage, timeStamp, lastTimeStamp, this.ChatRoomType, senderPlayerName, new int?(num.Value), null, null);
			chatContentData = chatContentData2;
			list.Add(chatContentData2);
		}
		List<ChatContentData> list2 = new List<ChatContentData>();
		foreach (ChatContentData item in list)
		{
			list2.Add(item);
		}
		foreach (ChatContentData item2 in this.ChatContentList)
		{
			list2.Add(item2);
		}
		this.ChatContentList = list2;
	}
}
