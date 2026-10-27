using System;
using System.Runtime.CompilerServices;

// Token: 0x020012C7 RID: 4807
[NullableContext(1)]
[Nullable(0)]
public class ActivitySubMapExploreItemData : IActivitySubMapExploreItemData
{
	// Token: 0x17000B3F RID: 2879
	// (get) Token: 0x0600841C RID: 33820 RVA: 0x001C1E0A File Offset: 0x001C000A
	// (set) Token: 0x0600841D RID: 33821 RVA: 0x001C1E12 File Offset: 0x001C0012
	public int TaskId { get; set; }

	// Token: 0x17000B40 RID: 2880
	// (get) Token: 0x0600841E RID: 33822 RVA: 0x001C1E1B File Offset: 0x001C001B
	// (set) Token: 0x0600841F RID: 33823 RVA: 0x001C1E23 File Offset: 0x001C0023
	public string RewardDesc { get; set; }

	// Token: 0x17000B41 RID: 2881
	// (get) Token: 0x06008420 RID: 33824 RVA: 0x001C1E2C File Offset: 0x001C002C
	// (set) Token: 0x06008421 RID: 33825 RVA: 0x001C1E34 File Offset: 0x001C0034
	public int RewardItemId { get; set; }

	// Token: 0x17000B42 RID: 2882
	// (get) Token: 0x06008422 RID: 33826 RVA: 0x001C1E3D File Offset: 0x001C003D
	// (set) Token: 0x06008423 RID: 33827 RVA: 0x001C1E45 File Offset: 0x001C0045
	public int? RewardItemCount { get; set; }

	// Token: 0x17000B43 RID: 2883
	// (get) Token: 0x06008424 RID: 33828 RVA: 0x001C1E4E File Offset: 0x001C004E
	// (set) Token: 0x06008425 RID: 33829 RVA: 0x001C1E56 File Offset: 0x001C0056
	public bool IsComplete { get; set; }

	// Token: 0x17000B44 RID: 2884
	// (get) Token: 0x06008426 RID: 33830 RVA: 0x001C1E5F File Offset: 0x001C005F
	// (set) Token: 0x06008427 RID: 33831 RVA: 0x001C1E67 File Offset: 0x001C0067
	public bool IsCanGet { get; set; }

	// Token: 0x17000B45 RID: 2885
	// (get) Token: 0x06008428 RID: 33832 RVA: 0x001C1E70 File Offset: 0x001C0070
	// (set) Token: 0x06008429 RID: 33833 RVA: 0x001C1E78 File Offset: 0x001C0078
	public bool IsRunning { get; set; }
}
