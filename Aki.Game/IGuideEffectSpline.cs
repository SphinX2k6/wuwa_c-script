using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000EDA RID: 3802
[NullableContext(1)]
public interface IGuideEffectSpline
{
	// Token: 0x17000744 RID: 1860
	// (get) Token: 0x06005EDC RID: 24284
	// (set) Token: 0x06005EDD RID: 24285
	int EffectHandle { get; set; }

	// Token: 0x17000745 RID: 1861
	// (get) Token: 0x06005EDE RID: 24286
	// (set) Token: 0x06005EDF RID: 24287
	AActor SplineActor { get; set; }

	// Token: 0x17000746 RID: 1862
	// (get) Token: 0x06005EE0 RID: 24288
	// (set) Token: 0x06005EE1 RID: 24289
	USplineComponent SplineComp { get; set; }
}
