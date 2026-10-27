using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200113D RID: 4413
[NullableContext(2)]
[Nullable(0)]
public class BabelTowerSettlementViewData : IBabelTowerSettlementViewData
{
	// Token: 0x17000A12 RID: 2578
	// (get) Token: 0x060073FD RID: 29693 RVA: 0x0017BBFE File Offset: 0x00179DFE
	// (set) Token: 0x060073FE RID: 29694 RVA: 0x0017BC06 File Offset: 0x00179E06
	public int LevelId { get; set; }

	// Token: 0x17000A13 RID: 2579
	// (get) Token: 0x060073FF RID: 29695 RVA: 0x0017BC0F File Offset: 0x00179E0F
	// (set) Token: 0x06007400 RID: 29696 RVA: 0x0017BC17 File Offset: 0x00179E17
	public int StarNum { get; set; }

	// Token: 0x17000A14 RID: 2580
	// (get) Token: 0x06007401 RID: 29697 RVA: 0x0017BC20 File Offset: 0x00179E20
	// (set) Token: 0x06007402 RID: 29698 RVA: 0x0017BC28 File Offset: 0x00179E28
	public int PassTime { get; set; }

	// Token: 0x17000A15 RID: 2581
	// (get) Token: 0x06007403 RID: 29699 RVA: 0x0017BC31 File Offset: 0x00179E31
	// (set) Token: 0x06007404 RID: 29700 RVA: 0x0017BC39 File Offset: 0x00179E39
	public long PassDate { get; set; }

	// Token: 0x17000A16 RID: 2582
	// (get) Token: 0x06007405 RID: 29701 RVA: 0x0017BC42 File Offset: 0x00179E42
	// (set) Token: 0x06007406 RID: 29702 RVA: 0x0017BC4A File Offset: 0x00179E4A
	[Nullable(1)]
	public List<int> TeamRoleIdList { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000A17 RID: 2583
	// (get) Token: 0x06007407 RID: 29703 RVA: 0x0017BC53 File Offset: 0x00179E53
	// (set) Token: 0x06007408 RID: 29704 RVA: 0x0017BC5B File Offset: 0x00179E5B
	public List<int> BuffIdList { get; set; }

	// Token: 0x17000A18 RID: 2584
	// (get) Token: 0x06007409 RID: 29705 RVA: 0x0017BC64 File Offset: 0x00179E64
	// (set) Token: 0x0600740A RID: 29706 RVA: 0x0017BC6C File Offset: 0x00179E6C
	public List<int> DeTermIdList { get; set; }

	// Token: 0x17000A19 RID: 2585
	// (get) Token: 0x0600740B RID: 29707 RVA: 0x0017BC75 File Offset: 0x00179E75
	// (set) Token: 0x0600740C RID: 29708 RVA: 0x0017BC7D File Offset: 0x00179E7D
	public int OldLevelRank { get; set; }

	// Token: 0x17000A1A RID: 2586
	// (get) Token: 0x0600740D RID: 29709 RVA: 0x0017BC86 File Offset: 0x00179E86
	// (set) Token: 0x0600740E RID: 29710 RVA: 0x0017BC8E File Offset: 0x00179E8E
	public int NewLevelRank { get; set; }

	// Token: 0x17000A1B RID: 2587
	// (get) Token: 0x0600740F RID: 29711 RVA: 0x0017BC97 File Offset: 0x00179E97
	// (set) Token: 0x06007410 RID: 29712 RVA: 0x0017BC9F File Offset: 0x00179E9F
	public int OldTotalRank { get; set; }

	// Token: 0x17000A1C RID: 2588
	// (get) Token: 0x06007411 RID: 29713 RVA: 0x0017BCA8 File Offset: 0x00179EA8
	// (set) Token: 0x06007412 RID: 29714 RVA: 0x0017BCB0 File Offset: 0x00179EB0
	public int NewTotalRank { get; set; }
}
