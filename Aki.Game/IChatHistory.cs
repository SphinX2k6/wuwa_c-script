using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000C4B RID: 3147
[NullableContext(2)]
public interface IChatHistory
{
	// Token: 0x17000EB6 RID: 3766
	// (get) Token: 0x0600837A RID: 33658
	// (set) Token: 0x0600837B RID: 33659
	long? UtcTime { get; set; }

	// Token: 0x17000EB7 RID: 3767
	// (get) Token: 0x0600837C RID: 33660
	// (set) Token: 0x0600837D RID: 33661
	string MsgId { get; set; }

	// Token: 0x17000EB8 RID: 3768
	// (get) Token: 0x0600837E RID: 33662
	// (set) Token: 0x0600837F RID: 33663
	int? SenderUid { get; set; }

	// Token: 0x17000EB9 RID: 3769
	// (get) Token: 0x06008380 RID: 33664
	// (set) Token: 0x06008381 RID: 33665
	int? SenderPlayerId { get; set; }

	// Token: 0x17000EBA RID: 3770
	// (get) Token: 0x06008382 RID: 33666
	// (set) Token: 0x06008383 RID: 33667
	string SenderPlayerName { get; set; }

	// Token: 0x17000EBB RID: 3771
	// (get) Token: 0x06008384 RID: 33668
	// (set) Token: 0x06008385 RID: 33669
	int? SenderIcon { get; set; }

	// Token: 0x17000EBC RID: 3772
	// (get) Token: 0x06008386 RID: 33670
	// (set) Token: 0x06008387 RID: 33671
	[Nullable(1)]
	string Content { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000EBD RID: 3773
	// (get) Token: 0x06008388 RID: 33672
	// (set) Token: 0x06008389 RID: 33673
	ChatContentType ChatContentType { get; set; }

	// Token: 0x17000EBE RID: 3774
	// (get) Token: 0x0600838A RID: 33674
	// (set) Token: 0x0600838B RID: 33675
	ChatChannelNoticeType? NoticeType { get; set; }

	// Token: 0x17000EBF RID: 3775
	// (get) Token: 0x0600838C RID: 33676
	// (set) Token: 0x0600838D RID: 33677
	bool? OfflineMsg { get; set; }
}
