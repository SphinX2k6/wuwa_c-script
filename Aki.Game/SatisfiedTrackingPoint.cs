using System;
using System.Runtime.CompilerServices;

// Token: 0x0200259D RID: 9629
[NullableContext(1)]
[Nullable(0)]
public class SatisfiedTrackingPoint : ISatisfiedTrackingPoint
{
	// Token: 0x17001911 RID: 6417
	// (get) Token: 0x0601380C RID: 79884 RVA: 0x004DEE40 File Offset: 0x004DD040
	// (set) Token: 0x0601380D RID: 79885 RVA: 0x004DEE48 File Offset: 0x004DD048
	public Vector Position { get; set; }

	// Token: 0x17001912 RID: 6418
	// (get) Token: 0x0601380E RID: 79886 RVA: 0x004DEE51 File Offset: 0x004DD051
	// (set) Token: 0x0601380F RID: 79887 RVA: 0x004DEE59 File Offset: 0x004DD059
	public bool IsOptional { get; set; }

	// Token: 0x17001913 RID: 6419
	// (get) Token: 0x06013810 RID: 79888 RVA: 0x004DEE62 File Offset: 0x004DD062
	// (set) Token: 0x06013811 RID: 79889 RVA: 0x004DEE6A File Offset: 0x004DD06A
	public string Id { get; set; }
}
