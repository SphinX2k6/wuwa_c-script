using System;
using System.Runtime.CompilerServices;

// Token: 0x020024DA RID: 9434
[NullableContext(1)]
[Nullable(0)]
public class VisionNewRecommendPreviewViewOpenParam : IVisionNewRecommendPreviewViewOpenParam
{
	// Token: 0x170018B1 RID: 6321
	// (get) Token: 0x06012F77 RID: 77687 RVA: 0x004B20A2 File Offset: 0x004B02A2
	// (set) Token: 0x06012F78 RID: 77688 RVA: 0x004B20AA File Offset: 0x004B02AA
	public VisionNewRecommendProxy Proxy { get; set; }

	// Token: 0x170018B2 RID: 6322
	// (get) Token: 0x06012F79 RID: 77689 RVA: 0x004B20B3 File Offset: 0x004B02B3
	// (set) Token: 0x06012F7A RID: 77690 RVA: 0x004B20BB File Offset: 0x004B02BB
	[Nullable(2)]
	public Action OnApplySuccess { [NullableContext(2)] get; [NullableContext(2)] set; }
}
