using System;
using System.Runtime.CompilerServices;

// Token: 0x0200259C RID: 9628
[NullableContext(1)]
public interface ISatisfiedTrackingPoint
{
	// Token: 0x1700190E RID: 6414
	// (get) Token: 0x06013806 RID: 79878
	// (set) Token: 0x06013807 RID: 79879
	Vector Position { get; set; }

	// Token: 0x1700190F RID: 6415
	// (get) Token: 0x06013808 RID: 79880
	// (set) Token: 0x06013809 RID: 79881
	bool IsOptional { get; set; }

	// Token: 0x17001910 RID: 6416
	// (get) Token: 0x0601380A RID: 79882
	// (set) Token: 0x0601380B RID: 79883
	string Id { get; set; }
}
