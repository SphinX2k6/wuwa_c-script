using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020005F0 RID: 1520
[NullableContext(2)]
public interface IBabelTowerSettlementViewData
{
	// Token: 0x17000A27 RID: 2599
	// (get) Token: 0x0600477E RID: 18302
	// (set) Token: 0x0600477F RID: 18303
	int LevelId { get; set; }

	// Token: 0x17000A28 RID: 2600
	// (get) Token: 0x06004780 RID: 18304
	// (set) Token: 0x06004781 RID: 18305
	int StarNum { get; set; }

	// Token: 0x17000A29 RID: 2601
	// (get) Token: 0x06004782 RID: 18306
	// (set) Token: 0x06004783 RID: 18307
	int PassTime { get; set; }

	// Token: 0x17000A2A RID: 2602
	// (get) Token: 0x06004784 RID: 18308
	// (set) Token: 0x06004785 RID: 18309
	long PassDate { get; set; }

	// Token: 0x17000A2B RID: 2603
	// (get) Token: 0x06004786 RID: 18310
	// (set) Token: 0x06004787 RID: 18311
	[Nullable(1)]
	List<int> TeamRoleIdList { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000A2C RID: 2604
	// (get) Token: 0x06004788 RID: 18312
	// (set) Token: 0x06004789 RID: 18313
	List<int> BuffIdList { get; set; }

	// Token: 0x17000A2D RID: 2605
	// (get) Token: 0x0600478A RID: 18314
	// (set) Token: 0x0600478B RID: 18315
	List<int> DeTermIdList { get; set; }

	// Token: 0x17000A2E RID: 2606
	// (get) Token: 0x0600478C RID: 18316
	// (set) Token: 0x0600478D RID: 18317
	int OldLevelRank { get; set; }

	// Token: 0x17000A2F RID: 2607
	// (get) Token: 0x0600478E RID: 18318
	// (set) Token: 0x0600478F RID: 18319
	int NewLevelRank { get; set; }

	// Token: 0x17000A30 RID: 2608
	// (get) Token: 0x06004790 RID: 18320
	// (set) Token: 0x06004791 RID: 18321
	int OldTotalRank { get; set; }

	// Token: 0x17000A31 RID: 2609
	// (get) Token: 0x06004792 RID: 18322
	// (set) Token: 0x06004793 RID: 18323
	int NewTotalRank { get; set; }
}
