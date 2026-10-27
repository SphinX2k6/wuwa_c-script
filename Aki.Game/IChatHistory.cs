using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001792 RID: 6034
[NullableContext(2)]
public interface IChatHistory
{
	// Token: 0x17000E93 RID: 3731
	// (get) Token: 0x0600AF92 RID: 44946
	// (set) Token: 0x0600AF93 RID: 44947
	long? UtcTime { get; set; }

	// Token: 0x17000E94 RID: 3732
	// (get) Token: 0x0600AF94 RID: 44948
	// (set) Token: 0x0600AF95 RID: 44949
	string MsgId { get; set; }

	// Token: 0x17000E95 RID: 3733
	// (get) Token: 0x0600AF96 RID: 44950
	// (set) Token: 0x0600AF97 RID: 44951
	int? SenderUid { get; set; }

	// Token: 0x17000E96 RID: 3734
	// (get) Token: 0x0600AF98 RID: 44952
	// (set) Token: 0x0600AF99 RID: 44953
	int? SenderPlayerId { get; set; }

	// Token: 0x17000E97 RID: 3735
	// (get) Token: 0x0600AF9A RID: 44954
	// (set) Token: 0x0600AF9B RID: 44955
	string SenderPlayerName { get; set; }

	// Token: 0x17000E98 RID: 3736
	// (get) Token: 0x0600AF9C RID: 44956
	// (set) Token: 0x0600AF9D RID: 44957
	int? SenderIcon { get; set; }

	// Token: 0x17000E99 RID: 3737
	// (get) Token: 0x0600AF9E RID: 44958
	// (set) Token: 0x0600AF9F RID: 44959
	[Nullable(1)]
	string Content { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000E9A RID: 3738
	// (get) Token: 0x0600AFA0 RID: 44960
	// (set) Token: 0x0600AFA1 RID: 44961
	ChatContentType ChatContentType { get; set; }

	// Token: 0x17000E9B RID: 3739
	// (get) Token: 0x0600AFA2 RID: 44962
	// (set) Token: 0x0600AFA3 RID: 44963
	ChatChannelNoticeType? NoticeType { get; set; }

	// Token: 0x17000E9C RID: 3740
	// (get) Token: 0x0600AFA4 RID: 44964
	// (set) Token: 0x0600AFA5 RID: 44965
	bool? OfflineMsg { get; set; }
}
