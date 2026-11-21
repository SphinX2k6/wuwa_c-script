using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020005F1 RID: 1521
[NullableContext(2)]
[Nullable(0)]
public class BabelTowerSettlementViewData : IBabelTowerSettlementViewData
{
	// Token: 0x17000A32 RID: 2610
	// (get) Token: 0x06004794 RID: 18324 RVA: 0x0018474C File Offset: 0x0018294C
	// (set) Token: 0x06004795 RID: 18325 RVA: 0x00184754 File Offset: 0x00182954
	public int LevelId { get; set; }

	// Token: 0x17000A33 RID: 2611
	// (get) Token: 0x06004796 RID: 18326 RVA: 0x0018475D File Offset: 0x0018295D
	// (set) Token: 0x06004797 RID: 18327 RVA: 0x00184765 File Offset: 0x00182965
	public int StarNum { get; set; }

	// Token: 0x17000A34 RID: 2612
	// (get) Token: 0x06004798 RID: 18328 RVA: 0x0018476E File Offset: 0x0018296E
	// (set) Token: 0x06004799 RID: 18329 RVA: 0x00184776 File Offset: 0x00182976
	public int PassTime { get; set; }

	// Token: 0x17000A35 RID: 2613
	// (get) Token: 0x0600479A RID: 18330 RVA: 0x0018477F File Offset: 0x0018297F
	// (set) Token: 0x0600479B RID: 18331 RVA: 0x00184787 File Offset: 0x00182987
	public long PassDate { get; set; }

	// Token: 0x17000A36 RID: 2614
	// (get) Token: 0x0600479C RID: 18332 RVA: 0x00184790 File Offset: 0x00182990
	// (set) Token: 0x0600479D RID: 18333 RVA: 0x00184798 File Offset: 0x00182998
	[Nullable(1)]
	public List<int> TeamRoleIdList { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000A37 RID: 2615
	// (get) Token: 0x0600479E RID: 18334 RVA: 0x001847A1 File Offset: 0x001829A1
	// (set) Token: 0x0600479F RID: 18335 RVA: 0x001847A9 File Offset: 0x001829A9
	public List<int> BuffIdList { get; set; }

	// Token: 0x17000A38 RID: 2616
	// (get) Token: 0x060047A0 RID: 18336 RVA: 0x001847B2 File Offset: 0x001829B2
	// (set) Token: 0x060047A1 RID: 18337 RVA: 0x001847BA File Offset: 0x001829BA
	public List<int> DeTermIdList { get; set; }

	// Token: 0x17000A39 RID: 2617
	// (get) Token: 0x060047A2 RID: 18338 RVA: 0x001847C3 File Offset: 0x001829C3
	// (set) Token: 0x060047A3 RID: 18339 RVA: 0x001847CB File Offset: 0x001829CB
	public int OldLevelRank { get; set; }

	// Token: 0x17000A3A RID: 2618
	// (get) Token: 0x060047A4 RID: 18340 RVA: 0x001847D4 File Offset: 0x001829D4
	// (set) Token: 0x060047A5 RID: 18341 RVA: 0x001847DC File Offset: 0x001829DC
	public int NewLevelRank { get; set; }

	// Token: 0x17000A3B RID: 2619
	// (get) Token: 0x060047A6 RID: 18342 RVA: 0x001847E5 File Offset: 0x001829E5
	// (set) Token: 0x060047A7 RID: 18343 RVA: 0x001847ED File Offset: 0x001829ED
	public int OldTotalRank { get; set; }

	// Token: 0x17000A3C RID: 2620
	// (get) Token: 0x060047A8 RID: 18344 RVA: 0x001847F6 File Offset: 0x001829F6
	// (set) Token: 0x060047A9 RID: 18345 RVA: 0x001847FE File Offset: 0x001829FE
	public int NewTotalRank { get; set; }
}
