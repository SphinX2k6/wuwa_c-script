using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001789 RID: 6025
[NullableContext(2)]
[Nullable(0)]
public class ChatContentData
{
	// Token: 0x0600AF3C RID: 44860 RVA: 0x0027939C File Offset: 0x0027759C
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

	// Token: 0x0600AF3D RID: 44861 RVA: 0x00279414 File Offset: 0x00277614
	public bool IsOwnSend()
	{
		int? id = PlayerInfoModel.Instance.GetId();
		int senderPlayerId = this.SenderPlayerId;
		return id.GetValueOrDefault() == senderPlayerId & id != null;
	}

	// Token: 0x04004FA2 RID: 20386
	[Nullable(1)]
	public readonly string ContentUniqueId;

	// Token: 0x04004FA3 RID: 20387
	public readonly int SenderPlayerId;

	// Token: 0x04004FA4 RID: 20388
	public int? SenderPlayerIcon;

	// Token: 0x04004FA5 RID: 20389
	public string SenderPlayerName;

	// Token: 0x04004FA6 RID: 20390
	[Nullable(1)]
	public readonly string Content;

	// Token: 0x04004FA7 RID: 20391
	public readonly ChatContentType ContentType;

	// Token: 0x04004FA8 RID: 20392
	public readonly ChatChannelNoticeType NoticeType;

	// Token: 0x04004FA9 RID: 20393
	public readonly bool IsOfflineMassage;

	// Token: 0x04004FAA RID: 20394
	public double TimeStamp;

	// Token: 0x04004FAB RID: 20395
	public double LastTimeStamp;

	// Token: 0x04004FAC RID: 20396
	public readonly EChatRoomType ChatRoomType;

	// Token: 0x04004FAD RID: 20397
	public readonly string ThirdOnlineId;

	// Token: 0x04004FAE RID: 20398
	public readonly string ThirdAvoidId;
}
