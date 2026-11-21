using System;
using System.Runtime.CompilerServices;

// Token: 0x020008D5 RID: 2261
[NullableContext(2)]
[Nullable(0)]
internal class PinballBattleBossComingTipsParam : IPinballBattleBossComingTipsParam, IPinballBattleTipsBaseParam
{
	// Token: 0x17000CA1 RID: 3233
	// (get) Token: 0x060064DB RID: 25819 RVA: 0x001FB7F0 File Offset: 0x001F99F0
	// (set) Token: 0x060064DC RID: 25820 RVA: 0x001FB7F8 File Offset: 0x001F99F8
	public int BossTypeId { get; set; }

	// Token: 0x17000CA2 RID: 3234
	// (get) Token: 0x060064DD RID: 25821 RVA: 0x001FB801 File Offset: 0x001F9A01
	// (set) Token: 0x060064DE RID: 25822 RVA: 0x001FB809 File Offset: 0x001F9A09
	public Action CloseCallback { get; set; }

	// Token: 0x17000CA3 RID: 3235
	// (get) Token: 0x060064DF RID: 25823 RVA: 0x001FB812 File Offset: 0x001F9A12
	// (set) Token: 0x060064E0 RID: 25824 RVA: 0x001FB81A File Offset: 0x001F9A1A
	public bool? AddMask { get; set; }

	// Token: 0x17000CA4 RID: 3236
	// (get) Token: 0x060064E1 RID: 25825 RVA: 0x001FB823 File Offset: 0x001F9A23
	// (set) Token: 0x060064E2 RID: 25826 RVA: 0x001FB82B File Offset: 0x001F9A2B
	public int? CloseTime { get; set; }

	// Token: 0x17000CA5 RID: 3237
	// (get) Token: 0x060064E3 RID: 25827 RVA: 0x001FB834 File Offset: 0x001F9A34
	// (set) Token: 0x060064E4 RID: 25828 RVA: 0x001FB83C File Offset: 0x001F9A3C
	public bool? MoveToBehind { get; set; }
}
