using System;
using System.Runtime.CompilerServices;

// Token: 0x02002A82 RID: 10882
[NullableContext(2)]
public interface ISpecialTransitionFlowParams
{
	// Token: 0x17001E26 RID: 7718
	// (get) Token: 0x06016A93 RID: 92819
	// (set) Token: 0x06016A94 RID: 92820
	IFadeEffect FadeInEffect { get; set; }

	// Token: 0x17001E27 RID: 7719
	// (get) Token: 0x06016A95 RID: 92821
	// (set) Token: 0x06016A96 RID: 92822
	IFadeEffect FadeOutEffect { get; set; }

	// Token: 0x17001E28 RID: 7720
	// (get) Token: 0x06016A97 RID: 92823
	// (set) Token: 0x06016A98 RID: 92824
	float? KeepTime { get; set; }
}
