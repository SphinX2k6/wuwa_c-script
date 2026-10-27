using System;
using System.Runtime.CompilerServices;

// Token: 0x02002A83 RID: 10883
[NullableContext(2)]
[Nullable(0)]
public class SpecialTransitionFlowParams : ISpecialTransitionFlowParams
{
	// Token: 0x17001E29 RID: 7721
	// (get) Token: 0x06016A99 RID: 92825 RVA: 0x005BD943 File Offset: 0x005BBB43
	// (set) Token: 0x06016A9A RID: 92826 RVA: 0x005BD94B File Offset: 0x005BBB4B
	public IFadeEffect FadeInEffect { get; set; }

	// Token: 0x17001E2A RID: 7722
	// (get) Token: 0x06016A9B RID: 92827 RVA: 0x005BD954 File Offset: 0x005BBB54
	// (set) Token: 0x06016A9C RID: 92828 RVA: 0x005BD95C File Offset: 0x005BBB5C
	public IFadeEffect FadeOutEffect { get; set; }

	// Token: 0x17001E2B RID: 7723
	// (get) Token: 0x06016A9D RID: 92829 RVA: 0x005BD965 File Offset: 0x005BBB65
	// (set) Token: 0x06016A9E RID: 92830 RVA: 0x005BD96D File Offset: 0x005BBB6D
	public float? KeepTime { get; set; }
}
