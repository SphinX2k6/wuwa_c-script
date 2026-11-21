using System;
using System.Runtime.CompilerServices;

// Token: 0x020019C1 RID: 6593
[NullableContext(1)]
[Nullable(0)]
public class VisionNewRecommendPreviewViewOpenParam : IVisionNewRecommendPreviewViewOpenParam
{
	// Token: 0x170018EB RID: 6379
	// (get) Token: 0x06010436 RID: 66614 RVA: 0x004BFCA2 File Offset: 0x004BDEA2
	// (set) Token: 0x06010437 RID: 66615 RVA: 0x004BFCAA File Offset: 0x004BDEAA
	public VisionNewRecommendProxy Proxy { get; set; }

	// Token: 0x170018EC RID: 6380
	// (get) Token: 0x06010438 RID: 66616 RVA: 0x004BFCB3 File Offset: 0x004BDEB3
	// (set) Token: 0x06010439 RID: 66617 RVA: 0x004BFCBB File Offset: 0x004BDEBB
	[Nullable(2)]
	public Action OnApplySuccess { [NullableContext(2)] get; [NullableContext(2)] set; }
}
