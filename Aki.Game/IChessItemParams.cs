using System;

// Token: 0x02000686 RID: 1670
public interface IChessItemParams
{
	// Token: 0x17000A78 RID: 2680
	// (get) Token: 0x06004D21 RID: 19745
	// (set) Token: 0x06004D22 RID: 19746
	int Id { get; set; }

	// Token: 0x17000A79 RID: 2681
	// (get) Token: 0x06004D23 RID: 19747
	// (set) Token: 0x06004D24 RID: 19748
	long CreatureDataId { get; set; }

	// Token: 0x17000A7A RID: 2682
	// (get) Token: 0x06004D25 RID: 19749
	// (set) Token: 0x06004D26 RID: 19750
	bool RotationIsForward { get; set; }

	// Token: 0x17000A7B RID: 2683
	// (get) Token: 0x06004D27 RID: 19751
	// (set) Token: 0x06004D28 RID: 19752
	int InitPointId { get; set; }
}
