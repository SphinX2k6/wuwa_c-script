using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020020C0 RID: 8384
[NullableContext(1)]
public interface ISurvivorsRogueParallaxItem
{
	// Token: 0x17001EF8 RID: 7928
	// (get) Token: 0x060149C2 RID: 84418
	// (set) Token: 0x060149C3 RID: 84419
	UUIItem Item { get; set; }

	// Token: 0x17001EF9 RID: 7929
	// (get) Token: 0x060149C4 RID: 84420
	// (set) Token: 0x060149C5 RID: 84421
	float InitPosY { get; set; }

	// Token: 0x17001EFA RID: 7930
	// (get) Token: 0x060149C6 RID: 84422
	// (set) Token: 0x060149C7 RID: 84423
	float ParallaxFactor { get; set; }
}
