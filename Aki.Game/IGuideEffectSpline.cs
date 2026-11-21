using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200038F RID: 911
[NullableContext(1)]
public interface IGuideEffectSpline
{
	// Token: 0x17000768 RID: 1896
	// (get) Token: 0x06003273 RID: 12915
	// (set) Token: 0x06003274 RID: 12916
	int EffectHandle { get; set; }

	// Token: 0x17000769 RID: 1897
	// (get) Token: 0x06003275 RID: 12917
	// (set) Token: 0x06003276 RID: 12918
	AActor SplineActor { get; set; }

	// Token: 0x1700076A RID: 1898
	// (get) Token: 0x06003277 RID: 12919
	// (set) Token: 0x06003278 RID: 12920
	USplineComponent SplineComp { get; set; }
}
