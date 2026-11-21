using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000C52 RID: 3154
[NullableContext(1)]
[Nullable(0)]
public class ChatRowData
{
	// Token: 0x06008403 RID: 33795 RVA: 0x00286554 File Offset: 0x00284754
	public ChatRowData(int uniqueId, int senderPlayerId, string content, ChatContentType contentType, bool isOfflineMassage, EChatRoomType contentChatRoomType, double timeStamp, int? targetPlayerId = null, [Nullable(2)] string senderPlayerName = null, int? senderPlayerIcon = null, int? senderPlayerNumber = null)
	{
		this.UniqueId = uniqueId;
		this.SenderPlayerId = senderPlayerId;
		this.Content = content;
		this.ContentType = contentType;
		this.IsOfflineMassage = isOfflineMassage;
		this.TargetPlayerId = targetPlayerId;
		this.ContentChatRoomType = contentChatRoomType;
		this.TimeStamp = timeStamp;
		this.SenderPlayerName = senderPlayerName;
		this.SenderPlayerIcon = senderPlayerIcon;
		this.SenderPlayerNumber = senderPlayerNumber;
	}

	// Token: 0x040050A2 RID: 20642
	public readonly int UniqueId;

	// Token: 0x040050A3 RID: 20643
	public readonly int SenderPlayerId;

	// Token: 0x040050A4 RID: 20644
	public int? SenderPlayerIcon;

	// Token: 0x040050A5 RID: 20645
	[Nullable(2)]
	public string SenderPlayerName;

	// Token: 0x040050A6 RID: 20646
	public readonly int? SenderPlayerNumber;

	// Token: 0x040050A7 RID: 20647
	public readonly int? TargetPlayerId;

	// Token: 0x040050A8 RID: 20648
	public readonly string Content = "";

	// Token: 0x040050A9 RID: 20649
	public readonly ChatContentType ContentType;

	// Token: 0x040050AA RID: 20650
	public readonly EChatRoomType ContentChatRoomType;

	// Token: 0x040050AB RID: 20651
	public readonly bool IsOfflineMassage;

	// Token: 0x040050AC RID: 20652
	public readonly double TimeStamp;

	// Token: 0x040050AD RID: 20653
	public bool IsVisible = true;
}
