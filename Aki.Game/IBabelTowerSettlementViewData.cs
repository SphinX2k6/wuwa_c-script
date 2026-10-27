using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200113C RID: 4412
[NullableContext(2)]
public interface IBabelTowerSettlementViewData
{
	// Token: 0x17000A07 RID: 2567
	// (get) Token: 0x060073E7 RID: 29671
	// (set) Token: 0x060073E8 RID: 29672
	int LevelId { get; set; }

	// Token: 0x17000A08 RID: 2568
	// (get) Token: 0x060073E9 RID: 29673
	// (set) Token: 0x060073EA RID: 29674
	int StarNum { get; set; }

	// Token: 0x17000A09 RID: 2569
	// (get) Token: 0x060073EB RID: 29675
	// (set) Token: 0x060073EC RID: 29676
	int PassTime { get; set; }

	// Token: 0x17000A0A RID: 2570
	// (get) Token: 0x060073ED RID: 29677
	// (set) Token: 0x060073EE RID: 29678
	long PassDate { get; set; }

	// Token: 0x17000A0B RID: 2571
	// (get) Token: 0x060073EF RID: 29679
	// (set) Token: 0x060073F0 RID: 29680
	[Nullable(1)]
	List<int> TeamRoleIdList { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000A0C RID: 2572
	// (get) Token: 0x060073F1 RID: 29681
	// (set) Token: 0x060073F2 RID: 29682
	List<int> BuffIdList { get; set; }

	// Token: 0x17000A0D RID: 2573
	// (get) Token: 0x060073F3 RID: 29683
	// (set) Token: 0x060073F4 RID: 29684
	List<int> DeTermIdList { get; set; }

	// Token: 0x17000A0E RID: 2574
	// (get) Token: 0x060073F5 RID: 29685
	// (set) Token: 0x060073F6 RID: 29686
	int OldLevelRank { get; set; }

	// Token: 0x17000A0F RID: 2575
	// (get) Token: 0x060073F7 RID: 29687
	// (set) Token: 0x060073F8 RID: 29688
	int NewLevelRank { get; set; }

	// Token: 0x17000A10 RID: 2576
	// (get) Token: 0x060073F9 RID: 29689
	// (set) Token: 0x060073FA RID: 29690
	int OldTotalRank { get; set; }

	// Token: 0x17000A11 RID: 2577
	// (get) Token: 0x060073FB RID: 29691
	// (set) Token: 0x060073FC RID: 29692
	int NewTotalRank { get; set; }
}
