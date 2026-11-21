using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000C49 RID: 3145
[NullableContext(1)]
public interface IChatRowSaveInfo
{
	// Token: 0x17000EAA RID: 3754
	// (get) Token: 0x06008361 RID: 33633
	// (set) Token: 0x06008362 RID: 33634
	ChatContentType ChatContentType { get; set; }

	// Token: 0x17000EAB RID: 3755
	// (get) Token: 0x06008363 RID: 33635
	// (set) Token: 0x06008364 RID: 33636
	string Content { get; set; }

	// Token: 0x17000EAC RID: 3756
	// (get) Token: 0x06008365 RID: 33637
	// (set) Token: 0x06008366 RID: 33638
	string MsgId { get; set; }

	// Token: 0x17000EAD RID: 3757
	// (get) Token: 0x06008367 RID: 33639
	// (set) Token: 0x06008368 RID: 33640
	bool OfflineMsg { get; set; }

	// Token: 0x17000EAE RID: 3758
	// (get) Token: 0x06008369 RID: 33641
	// (set) Token: 0x0600836A RID: 33642
	int SenderUid { get; set; }

	// Token: 0x17000EAF RID: 3759
	// (get) Token: 0x0600836B RID: 33643
	// (set) Token: 0x0600836C RID: 33644
	long UtcTime { get; set; }
}
