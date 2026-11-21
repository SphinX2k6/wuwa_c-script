using System;
using System.Runtime.CompilerServices;

// Token: 0x02001A88 RID: 6792
[NullableContext(1)]
[Nullable(0)]
public class SatisfiedTrackingPoint : ISatisfiedTrackingPoint
{
	// Token: 0x1700194B RID: 6475
	// (get) Token: 0x06010CEE RID: 68846 RVA: 0x004ED974 File Offset: 0x004EBB74
	// (set) Token: 0x06010CEF RID: 68847 RVA: 0x004ED97C File Offset: 0x004EBB7C
	public Vector Position { get; set; }

	// Token: 0x1700194C RID: 6476
	// (get) Token: 0x06010CF0 RID: 68848 RVA: 0x004ED985 File Offset: 0x004EBB85
	// (set) Token: 0x06010CF1 RID: 68849 RVA: 0x004ED98D File Offset: 0x004EBB8D
	public bool IsOptional { get; set; }

	// Token: 0x1700194D RID: 6477
	// (get) Token: 0x06010CF2 RID: 68850 RVA: 0x004ED996 File Offset: 0x004EBB96
	// (set) Token: 0x06010CF3 RID: 68851 RVA: 0x004ED99E File Offset: 0x004EBB9E
	public string Id { get; set; }
}
