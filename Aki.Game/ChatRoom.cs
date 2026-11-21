using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02000C51 RID: 3153
[NullableContext(1)]
[Nullable(0)]
public class ChatRoom
{
	// Token: 0x060083F1 RID: 33777 RVA: 0x00286100 File Offset: 0x00284300
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

	// Token: 0x060083F2 RID: 33778 RVA: 0x00286191 File Offset: 0x00284391
	public void Reset()
	{
		this.ChatContentList.Clear();
		this.CreateTimeStamp = -1.0;
		this.IsOpen = false;
	}

	// Token: 0x060083F3 RID: 33779 RVA: 0x002861B4 File Offset: 0x002843B4
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

	// Token: 0x060083F4 RID: 33780 RVA: 0x00286214 File Offset: 0x00284414
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

	// Token: 0x060083F5 RID: 33781 RVA: 0x0028627E File Offset: 0x0028447E
	public bool GetIsOpen()
	{
		return this.IsOpen;
	}

	// Token: 0x060083F6 RID: 33782 RVA: 0x00286286 File Offset: 0x00284486
	public void SetIsShowRedDot(bool bShow)
	{
		this.IsShowRedDot = bShow;
	}

	// Token: 0x060083F7 RID: 33783 RVA: 0x0028628F File Offset: 0x0028448F
	public bool GetIsShowRedDot()
	{
		return this.IsShowRedDot;
	}

	// Token: 0x060083F8 RID: 33784 RVA: 0x00286297 File Offset: 0x00284497
	public int GetConfigId()
	{
		return this.ConfigId;
	}

	// Token: 0x060083F9 RID: 33785 RVA: 0x0028629F File Offset: 0x0028449F
	public virtual int GetUniqueId()
	{
		return -1;
	}

	// Token: 0x060083FA RID: 33786 RVA: 0x002862A2 File Offset: 0x002844A2
	public Chat? GetChatConfig()
	{
		return ChatConfig.Instance.GetChatConfig(this.ConfigId);
	}

	// Token: 0x060083FB RID: 33787 RVA: 0x002862B4 File Offset: 0x002844B4
	public IReadOnlyList<ChatContentData> GetChatContentList()
	{
		return this.ChatContentList;
	}

	// Token: 0x060083FC RID: 33788 RVA: 0x002862BC File Offset: 0x002844BC
	public string GetEarliestHistoryContentUniqueId()
	{
		return this.EarliestHistoryContentUniqueId;
	}

	// Token: 0x060083FD RID: 33789 RVA: 0x002862C4 File Offset: 0x002844C4
	public double GetCreateTimeStamp()
	{
		return this.CreateTimeStamp;
	}

	// Token: 0x060083FE RID: 33790 RVA: 0x002862CC File Offset: 0x002844CC
	public void ClearCreateTime()
	{
		this.CreateTimeStamp = -1.0;
	}

	// Token: 0x060083FF RID: 33791 RVA: 0x002862E0 File Offset: 0x002844E0
	public double GetLastTimeStamp()
	{
		int num = this.ChatContentList.Count - 1;
		if (num < 0)
		{
			return 0.0;
		}
		return this.ChatContentList[num].TimeStamp;
	}

	// Token: 0x06008400 RID: 33792 RVA: 0x0028631C File Offset: 0x0028451C
	public ChatContentData AddChatContent(string contentUniqueId, int senderPlayerId, string content, ChatContentType contentType, ChatChannelNoticeType noticeType, bool isOfflineMassage, double timeStamp, double lastTimeStamp, [Nullable(2)] string senderPlayerName = null, int? senderPlayerIcon = null, [Nullable(2)] string thirdOnlineId = null, [Nullable(2)] string thirdAvoidId = null)
	{
		ChatContentData chatContentData = new ChatContentData(contentUniqueId, senderPlayerId, content, contentType, noticeType, isOfflineMassage, timeStamp, lastTimeStamp, this.ChatRoomType, senderPlayerName, senderPlayerIcon, thirdOnlineId, thirdAvoidId);
		this.ChatContentList.Add(chatContentData);
		return chatContentData;
	}

	// Token: 0x06008401 RID: 33793 RVA: 0x00286358 File Offset: 0x00284558
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

	// Token: 0x06008402 RID: 33794 RVA: 0x00286388 File Offset: 0x00284588
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

	// Token: 0x04005099 RID: 20633
	public readonly EChatRoomType ChatRoomType;

	// Token: 0x0400509A RID: 20634
	protected List<ChatContentData> ChatContentList = new List<ChatContentData>();

	// Token: 0x0400509B RID: 20635
	private double CreateTimeStamp = -1.0;

	// Token: 0x0400509C RID: 20636
	private bool IsShowRedDot;

	// Token: 0x0400509D RID: 20637
	private readonly int ConfigId;

	// Token: 0x0400509E RID: 20638
	protected string EarliestHistoryContentUniqueId = "";

	// Token: 0x0400509F RID: 20639
	private bool IsOpen;

	// Token: 0x040050A0 RID: 20640
	public int LocalSaveMsgLimit;

	// Token: 0x040050A1 RID: 20641
	public int ChatCd;
}
