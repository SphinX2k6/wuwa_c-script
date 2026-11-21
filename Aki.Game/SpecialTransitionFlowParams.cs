using System;
using System.Runtime.CompilerServices;

// Token: 0x02001FFF RID: 8191
[NullableContext(2)]
[Nullable(0)]
public class SpecialTransitionFlowParams : ISpecialTransitionFlowParams
{
	// Token: 0x17001E81 RID: 7809
	// (get) Token: 0x060144BE RID: 83134 RVA: 0x005E9B73 File Offset: 0x005E7D73
	// (set) Token: 0x060144BF RID: 83135 RVA: 0x005E9B7B File Offset: 0x005E7D7B
	public IFadeEffect FadeInEffect { get; set; }

	// Token: 0x17001E82 RID: 7810
	// (get) Token: 0x060144C0 RID: 83136 RVA: 0x005E9B84 File Offset: 0x005E7D84
	// (set) Token: 0x060144C1 RID: 83137 RVA: 0x005E9B8C File Offset: 0x005E7D8C
	public IFadeEffect FadeOutEffect { get; set; }

	// Token: 0x17001E83 RID: 7811
	// (get) Token: 0x060144C2 RID: 83138 RVA: 0x005E9B95 File Offset: 0x005E7D95
	// (set) Token: 0x060144C3 RID: 83139 RVA: 0x005E9B9D File Offset: 0x005E7D9D
	public float? KeepTime { get; set; }
}
