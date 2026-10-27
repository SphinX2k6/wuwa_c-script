using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002B44 RID: 11076
[NullableContext(1)]
public interface ISurvivorsRogueParallaxItem
{
	// Token: 0x17001EA0 RID: 7840
	// (get) Token: 0x06016F91 RID: 94097
	// (set) Token: 0x06016F92 RID: 94098
	UUIItem Item { get; set; }

	// Token: 0x17001EA1 RID: 7841
	// (get) Token: 0x06016F93 RID: 94099
	// (set) Token: 0x06016F94 RID: 94100
	float InitPosY { get; set; }

	// Token: 0x17001EA2 RID: 7842
	// (get) Token: 0x06016F95 RID: 94101
	// (set) Token: 0x06016F96 RID: 94102
	float ParallaxFactor { get; set; }
}
