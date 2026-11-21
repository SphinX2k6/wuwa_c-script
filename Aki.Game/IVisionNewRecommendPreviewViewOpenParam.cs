using System;
using System.Runtime.CompilerServices;

// Token: 0x020019C0 RID: 6592
[NullableContext(1)]
public interface IVisionNewRecommendPreviewViewOpenParam
{
	// Token: 0x170018E9 RID: 6377
	// (get) Token: 0x06010432 RID: 66610
	// (set) Token: 0x06010433 RID: 66611
	VisionNewRecommendProxy Proxy { get; set; }

	// Token: 0x170018EA RID: 6378
	// (get) Token: 0x06010434 RID: 66612
	// (set) Token: 0x06010435 RID: 66613
	[Nullable(2)]
	Action OnApplySuccess { [NullableContext(2)] get; [NullableContext(2)] set; }
}
