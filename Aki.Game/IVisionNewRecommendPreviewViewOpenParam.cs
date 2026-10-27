using System;
using System.Runtime.CompilerServices;

// Token: 0x020024D9 RID: 9433
[NullableContext(1)]
public interface IVisionNewRecommendPreviewViewOpenParam
{
	// Token: 0x170018AF RID: 6319
	// (get) Token: 0x06012F73 RID: 77683
	// (set) Token: 0x06012F74 RID: 77684
	VisionNewRecommendProxy Proxy { get; set; }

	// Token: 0x170018B0 RID: 6320
	// (get) Token: 0x06012F75 RID: 77685
	// (set) Token: 0x06012F76 RID: 77686
	[Nullable(2)]
	Action OnApplySuccess { [NullableContext(2)] get; [NullableContext(2)] set; }
}
