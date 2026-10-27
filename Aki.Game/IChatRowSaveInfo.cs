using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001790 RID: 6032
[NullableContext(1)]
public interface IChatRowSaveInfo
{
	// Token: 0x17000E87 RID: 3719
	// (get) Token: 0x0600AF79 RID: 44921
	// (set) Token: 0x0600AF7A RID: 44922
	ChatContentType ChatContentType { get; set; }

	// Token: 0x17000E88 RID: 3720
	// (get) Token: 0x0600AF7B RID: 44923
	// (set) Token: 0x0600AF7C RID: 44924
	string Content { get; set; }

	// Token: 0x17000E89 RID: 3721
	// (get) Token: 0x0600AF7D RID: 44925
	// (set) Token: 0x0600AF7E RID: 44926
	string MsgId { get; set; }

	// Token: 0x17000E8A RID: 3722
	// (get) Token: 0x0600AF7F RID: 44927
	// (set) Token: 0x0600AF80 RID: 44928
	bool OfflineMsg { get; set; }

	// Token: 0x17000E8B RID: 3723
	// (get) Token: 0x0600AF81 RID: 44929
	// (set) Token: 0x0600AF82 RID: 44930
	int SenderUid { get; set; }

	// Token: 0x17000E8C RID: 3724
	// (get) Token: 0x0600AF83 RID: 44931
	// (set) Token: 0x0600AF84 RID: 44932
	long UtcTime { get; set; }
}
