using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001799 RID: 6041
[NullableContext(1)]
[Nullable(0)]
public class ChatRowData
{
	// Token: 0x0600B01B RID: 45083 RVA: 0x0027C038 File Offset: 0x0027A238
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

	// Token: 0x04004FF8 RID: 20472
	public readonly int UniqueId;

	// Token: 0x04004FF9 RID: 20473
	public readonly int SenderPlayerId;

	// Token: 0x04004FFA RID: 20474
	public int? SenderPlayerIcon;

	// Token: 0x04004FFB RID: 20475
	[Nullable(2)]
	public string SenderPlayerName;

	// Token: 0x04004FFC RID: 20476
	public readonly int? SenderPlayerNumber;

	// Token: 0x04004FFD RID: 20477
	public readonly int? TargetPlayerId;

	// Token: 0x04004FFE RID: 20478
	public readonly string Content = "";

	// Token: 0x04004FFF RID: 20479
	public readonly ChatContentType ContentType;

	// Token: 0x04005000 RID: 20480
	public readonly EChatRoomType ContentChatRoomType;

	// Token: 0x04005001 RID: 20481
	public readonly bool IsOfflineMassage;

	// Token: 0x04005002 RID: 20482
	public readonly double TimeStamp;

	// Token: 0x04005003 RID: 20483
	public bool IsVisible = true;
}
