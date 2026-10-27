using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200179C RID: 6044
public class TeamChatRoomBase : ChatRoom
{
	// Token: 0x0600B028 RID: 45096 RVA: 0x0027C1A5 File Offset: 0x0027A3A5
	public TeamChatRoomBase(EChatRoomType chatRoomType, int configId) : base(chatRoomType, configId)
	{
	}

	// Token: 0x0600B029 RID: 45097 RVA: 0x0027C1B0 File Offset: 0x0027A3B0
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
		this.ChatContentList = list.Concat(this.ChatContentList).ToList<ChatContentData>();
	}
}
