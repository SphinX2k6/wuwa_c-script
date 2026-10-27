using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02001798 RID: 6040
[NullableContext(1)]
[Nullable(0)]
public class ChatRoom
{
	// Token: 0x0600B009 RID: 45065 RVA: 0x0027BC60 File Offset: 0x00279E60
	public ChatRoom(EChatRoomType chatRoomType, int configId)
	{
		this.ChatRoomType = chatRoomType;
		this.ConfigId = configId;
		this.IsOpen = false;
		Chat? chatConfig = ChatConfig.Instance.GetChatConfig(this.ConfigId);
		if (chatConfig != null)
		{
			this.LocalSaveMsgLimit = chatConfig.Value.LocalSaveMsgLimit;
			this.ChatCd = chatConfig.Value.ChatCd;
		}
	}

	// Token: 0x0600B00A RID: 45066 RVA: 0x0027BCF1 File Offset: 0x00279EF1
	public void Reset()
	{
		this.ChatContentList.Clear();
		this.CreateTimeStamp = -1.0;
		this.IsOpen = false;
	}

	// Token: 0x0600B00B RID: 45067 RVA: 0x0027BD14 File Offset: 0x00279F14
	public void Open()
	{
		if (this.IsOpen)
		{
			return;
		}
		this.CreateTimeStamp = TimeUtil.Instance.GetServerTime();
		this.IsOpen = true;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Chat;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = " 打开聊天室";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("uniqueId", this.GetUniqueId());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600B00C RID: 45068 RVA: 0x0027BD74 File Offset: 0x00279F74
	public void Close()
	{
		if (!this.IsOpen)
		{
			return;
		}
		this.ChatContentList.Clear();
		this.CreateTimeStamp = -1.0;
		this.IsOpen = false;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Chat;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = " 关闭聊天室";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("uniqueId", this.GetUniqueId());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600B00D RID: 45069 RVA: 0x0027BDDE File Offset: 0x00279FDE
	public bool GetIsOpen()
	{
		return this.IsOpen;
	}

	// Token: 0x0600B00E RID: 45070 RVA: 0x0027BDE6 File Offset: 0x00279FE6
	public void SetIsShowRedDot(bool bShow)
	{
		this.IsShowRedDot = bShow;
	}

	// Token: 0x0600B00F RID: 45071 RVA: 0x0027BDEF File Offset: 0x00279FEF
	public bool GetIsShowRedDot()
	{
		return this.IsShowRedDot;
	}

	// Token: 0x0600B010 RID: 45072 RVA: 0x0027BDF7 File Offset: 0x00279FF7
	public int GetConfigId()
	{
		return this.ConfigId;
	}

	// Token: 0x0600B011 RID: 45073 RVA: 0x0027BDFF File Offset: 0x00279FFF
	public virtual int GetUniqueId()
	{
		return -1;
	}

	// Token: 0x0600B012 RID: 45074 RVA: 0x0027BE02 File Offset: 0x0027A002
	public Chat? GetChatConfig()
	{
		return ChatConfig.Instance.GetChatConfig(this.ConfigId);
	}

	// Token: 0x0600B013 RID: 45075 RVA: 0x0027BE14 File Offset: 0x0027A014
	public IReadOnlyList<ChatContentData> GetChatContentList()
	{
		return this.ChatContentList;
	}

	// Token: 0x0600B014 RID: 45076 RVA: 0x0027BE1C File Offset: 0x0027A01C
	public string GetEarliestHistoryContentUniqueId()
	{
		return this.EarliestHistoryContentUniqueId;
	}

	// Token: 0x0600B015 RID: 45077 RVA: 0x0027BE24 File Offset: 0x0027A024
	public double GetCreateTimeStamp()
	{
		return this.CreateTimeStamp;
	}

	// Token: 0x0600B016 RID: 45078 RVA: 0x0027BE2C File Offset: 0x0027A02C
	public void ClearCreateTime()
	{
		this.CreateTimeStamp = -1.0;
	}

	// Token: 0x0600B017 RID: 45079 RVA: 0x0027BE40 File Offset: 0x0027A040
	public double GetLastTimeStamp()
	{
		int num = this.ChatContentList.Count - 1;
		if (num < 0)
		{
			return 0.0;
		}
		return this.ChatContentList[num].TimeStamp;
	}

	// Token: 0x0600B018 RID: 45080 RVA: 0x0027BE7C File Offset: 0x0027A07C
	public ChatContentData AddChatContent(string contentUniqueId, int senderPlayerId, string content, ChatContentType contentType, ChatChannelNoticeType noticeType, bool isOfflineMassage, double timeStamp, double lastTimeStamp, [Nullable(2)] string senderPlayerName = null, int? senderPlayerIcon = null, [Nullable(2)] string thirdOnlineId = null, [Nullable(2)] string thirdAvoidId = null)
	{
		ChatContentData chatContentData = new ChatContentData(contentUniqueId, senderPlayerId, content, contentType, noticeType, isOfflineMassage, timeStamp, lastTimeStamp, this.ChatRoomType, senderPlayerName, senderPlayerIcon, thirdOnlineId, thirdAvoidId);
		this.ChatContentList.Add(chatContentData);
		return chatContentData;
	}

	// Token: 0x0600B019 RID: 45081 RVA: 0x0027BEB8 File Offset: 0x0027A0B8
	[NullableContext(2)]
	public ChatContentData GetLastChatContentData(int lastIndex = 1)
	{
		int num = this.ChatContentList.Count - lastIndex;
		if (num < 0)
		{
			return null;
		}
		return this.ChatContentList[num];
	}

	// Token: 0x0600B01A RID: 45082 RVA: 0x0027BEE8 File Offset: 0x0027A0E8
	public virtual void AddHistoryChatContent(List<IChatHistory> chatContents)
	{
		chatContents.Sort(delegate(IChatHistory a, IChatHistory b)
		{
			long? utcTime2 = a.UtcTime;
			long? utcTime3 = b.UtcTime;
			if (utcTime2 == null || utcTime3 == null)
			{
				return a.SenderUid.Value - b.SenderUid.Value;
			}
			return (int)(utcTime2.Value - utcTime3.Value);
		});
		this.EarliestHistoryContentUniqueId = chatContents[0].MsgId;
		List<ChatContentData> list = new List<ChatContentData>();
		ChatContentData chatContentData = null;
		foreach (IChatHistory chatHistory in chatContents)
		{
			int? senderUid = chatHistory.SenderUid;
			string content = chatHistory.Content;
			ChatContentType chatContentType = chatHistory.ChatContentType;
			bool? offlineMsg = chatHistory.OfflineMsg;
			string msgId = chatHistory.MsgId;
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
			ChatContentData chatContentData2 = new ChatContentData(msgId, senderUid.Value, content, chatContentType, ChatChannelNoticeType.None, offlineMsg.Value, timeStamp, lastTimeStamp, this.ChatRoomType, null, null, null, null);
			chatContentData = chatContentData2;
			list.Add(chatContentData2);
		}
		this.ChatContentList = list.Concat(this.ChatContentList).ToList<ChatContentData>();
	}

	// Token: 0x04004FEF RID: 20463
	public readonly EChatRoomType ChatRoomType;

	// Token: 0x04004FF0 RID: 20464
	protected List<ChatContentData> ChatContentList = new List<ChatContentData>();

	// Token: 0x04004FF1 RID: 20465
	private double CreateTimeStamp = -1.0;

	// Token: 0x04004FF2 RID: 20466
	private bool IsShowRedDot;

	// Token: 0x04004FF3 RID: 20467
	private readonly int ConfigId;

	// Token: 0x04004FF4 RID: 20468
	protected string EarliestHistoryContentUniqueId = "";

	// Token: 0x04004FF5 RID: 20469
	private bool IsOpen;

	// Token: 0x04004FF6 RID: 20470
	public int LocalSaveMsgLimit;

	// Token: 0x04004FF7 RID: 20471
	public int ChatCd;
}
