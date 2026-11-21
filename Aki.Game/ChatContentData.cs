using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000C42 RID: 3138
[NullableContext(2)]
[Nullable(0)]
public class ChatContentData
{
	// Token: 0x06008324 RID: 33572 RVA: 0x002838D0 File Offset: 0x00281AD0
	public ChatContentData([Nullable(1)] string contentUniqueId, int senderPlayerId, [Nullable(1)] string content, ChatContentType contentType, ChatChannelNoticeType noticeType, bool isOfflineMassage, double timeStamp, double lastTimeStamp, EChatRoomType chatRoomType, string senderPlayerName = null, int? senderPlayerIcon = null, string thirdOnlineId = null, string thirdAvoidId = null)
	{
		this.ContentUniqueId = contentUniqueId;
		this.SenderPlayerId = senderPlayerId;
		this.Content = content;
		this.ContentType = contentType;
		this.NoticeType = noticeType;
		this.IsOfflineMassage = isOfflineMassage;
		this.TimeStamp = timeStamp;
		this.LastTimeStamp = lastTimeStamp;
		this.ChatRoomType = chatRoomType;
		this.SenderPlayerName = senderPlayerName;
		this.SenderPlayerIcon = senderPlayerIcon;
		this.ThirdOnlineId = thirdOnlineId;
		this.ThirdAvoidId = thirdAvoidId;
	}

	// Token: 0x06008325 RID: 33573 RVA: 0x00283948 File Offset: 0x00281B48
	public bool IsOwnSend()
	{
		int? id = PlayerInfoModel.Instance.GetId();
		int senderPlayerId = this.SenderPlayerId;
		return id.GetValueOrDefault() == senderPlayerId & id != null;
	}

	// Token: 0x0400504C RID: 20556
	[Nullable(1)]
	public readonly string ContentUniqueId;

	// Token: 0x0400504D RID: 20557
	public readonly int SenderPlayerId;

	// Token: 0x0400504E RID: 20558
	public int? SenderPlayerIcon;

	// Token: 0x0400504F RID: 20559
	public string SenderPlayerName;

	// Token: 0x04005050 RID: 20560
	[Nullable(1)]
	public readonly string Content;

	// Token: 0x04005051 RID: 20561
	public readonly ChatContentType ContentType;

	// Token: 0x04005052 RID: 20562
	public readonly ChatChannelNoticeType NoticeType;

	// Token: 0x04005053 RID: 20563
	public readonly bool IsOfflineMassage;

	// Token: 0x04005054 RID: 20564
	public double TimeStamp;

	// Token: 0x04005055 RID: 20565
	public double LastTimeStamp;

	// Token: 0x04005056 RID: 20566
	public readonly EChatRoomType ChatRoomType;

	// Token: 0x04005057 RID: 20567
	public readonly string ThirdOnlineId;

	// Token: 0x04005058 RID: 20568
	public readonly string ThirdAvoidId;
}
