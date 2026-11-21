using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000EAE RID: 3758
[NullableContext(1)]
[Nullable(0)]
public class ActivityGoalData : DailyActivityDefine.IActivityGoalData
{
	// Token: 0x17001062 RID: 4194
	// (get) Token: 0x0600965C RID: 38492 RVA: 0x002C8B78 File Offset: 0x002C6D78
	// (set) Token: 0x0600965D RID: 38493 RVA: 0x002C8B80 File Offset: 0x002C6D80
	public int Id { get; set; }

	// Token: 0x17001063 RID: 4195
	// (get) Token: 0x0600965E RID: 38494 RVA: 0x002C8B89 File Offset: 0x002C6D89
	// (set) Token: 0x0600965F RID: 38495 RVA: 0x002C8B91 File Offset: 0x002C6D91
	public int Goal { get; set; }

	// Token: 0x17001064 RID: 4196
	// (get) Token: 0x06009660 RID: 38496 RVA: 0x002C8B9A File Offset: 0x002C6D9A
	// (set) Token: 0x06009661 RID: 38497 RVA: 0x002C8BA2 File Offset: 0x002C6DA2
	public List<TItem> Rewards { get; set; } = new List<TItem>();

	// Token: 0x17001065 RID: 4197
	// (get) Token: 0x06009662 RID: 38498 RVA: 0x002C8BAB File Offset: 0x002C6DAB
	// (set) Token: 0x06009663 RID: 38499 RVA: 0x002C8BB3 File Offset: 0x002C6DB3
	public bool Achieved { get; set; }

	// Token: 0x17001066 RID: 4198
	// (get) Token: 0x06009664 RID: 38500 RVA: 0x002C8BBC File Offset: 0x002C6DBC
	// (set) Token: 0x06009665 RID: 38501 RVA: 0x002C8BC4 File Offset: 0x002C6DC4
	public EDailyActiveState State { get; set; }
}
