using System;
using System.Runtime.CompilerServices;

// Token: 0x02001AA2 RID: 6818
[NullableContext(2)]
[Nullable(0)]
public class PlayPointInfo : IPlayPointInfo
{
	// Token: 0x1700108B RID: 4235
	// (get) Token: 0x0600C9E2 RID: 51682 RVA: 0x002E1691 File Offset: 0x002DF891
	// (set) Token: 0x0600C9E3 RID: 51683 RVA: 0x002E1699 File Offset: 0x002DF899
	public int PlayId { get; set; }

	// Token: 0x1700108C RID: 4236
	// (get) Token: 0x0600C9E4 RID: 51684 RVA: 0x002E16A2 File Offset: 0x002DF8A2
	// (set) Token: 0x0600C9E5 RID: 51685 RVA: 0x002E16AA File Offset: 0x002DF8AA
	public int EntityId { get; set; }

	// Token: 0x1700108D RID: 4237
	// (get) Token: 0x0600C9E6 RID: 51686 RVA: 0x002E16B3 File Offset: 0x002DF8B3
	// (set) Token: 0x0600C9E7 RID: 51687 RVA: 0x002E16BB File Offset: 0x002DF8BB
	public EPlayPointState PlayState { get; set; }

	// Token: 0x1700108E RID: 4238
	// (get) Token: 0x0600C9E8 RID: 51688 RVA: 0x002E16C4 File Offset: 0x002DF8C4
	// (set) Token: 0x0600C9E9 RID: 51689 RVA: 0x002E16CC File Offset: 0x002DF8CC
	public bool? IsClear { get; set; }

	// Token: 0x1700108F RID: 4239
	// (get) Token: 0x0600C9EA RID: 51690 RVA: 0x002E16D5 File Offset: 0x002DF8D5
	// (set) Token: 0x0600C9EB RID: 51691 RVA: 0x002E16DD File Offset: 0x002DF8DD
	public string ClearInfo { get; set; }

	// Token: 0x17001090 RID: 4240
	// (get) Token: 0x0600C9EC RID: 51692 RVA: 0x002E16E6 File Offset: 0x002DF8E6
	// (set) Token: 0x0600C9ED RID: 51693 RVA: 0x002E16EE File Offset: 0x002DF8EE
	public bool? LevelPlayMarkUnlock { get; set; }

	// Token: 0x17001091 RID: 4241
	// (get) Token: 0x0600C9EE RID: 51694 RVA: 0x002E16F7 File Offset: 0x002DF8F7
	// (set) Token: 0x0600C9EF RID: 51695 RVA: 0x002E16FF File Offset: 0x002DF8FF
	public bool IsUnlock { get; set; }
}
