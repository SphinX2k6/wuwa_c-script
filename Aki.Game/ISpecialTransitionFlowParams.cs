using System;
using System.Runtime.CompilerServices;

// Token: 0x02001FFE RID: 8190
[NullableContext(2)]
public interface ISpecialTransitionFlowParams
{
	// Token: 0x17001E7E RID: 7806
	// (get) Token: 0x060144B8 RID: 83128
	// (set) Token: 0x060144B9 RID: 83129
	IFadeEffect FadeInEffect { get; set; }

	// Token: 0x17001E7F RID: 7807
	// (get) Token: 0x060144BA RID: 83130
	// (set) Token: 0x060144BB RID: 83131
	IFadeEffect FadeOutEffect { get; set; }

	// Token: 0x17001E80 RID: 7808
	// (get) Token: 0x060144BC RID: 83132
	// (set) Token: 0x060144BD RID: 83133
	float? KeepTime { get; set; }
}
