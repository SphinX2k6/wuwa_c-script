using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000EDB RID: 3803
[NullableContext(1)]
[Nullable(0)]
public class GuideEffectSpline : IGuideEffectSpline
{
	// Token: 0x17000747 RID: 1863
	// (get) Token: 0x06005EE2 RID: 24290 RVA: 0x0011AD98 File Offset: 0x00118F98
	// (set) Token: 0x06005EE3 RID: 24291 RVA: 0x0011ADA0 File Offset: 0x00118FA0
	public int EffectHandle { get; set; }

	// Token: 0x17000748 RID: 1864
	// (get) Token: 0x06005EE4 RID: 24292 RVA: 0x0011ADA9 File Offset: 0x00118FA9
	// (set) Token: 0x06005EE5 RID: 24293 RVA: 0x0011ADB1 File Offset: 0x00118FB1
	public AActor SplineActor { get; set; }

	// Token: 0x17000749 RID: 1865
	// (get) Token: 0x06005EE6 RID: 24294 RVA: 0x0011ADBA File Offset: 0x00118FBA
	// (set) Token: 0x06005EE7 RID: 24295 RVA: 0x0011ADC2 File Offset: 0x00118FC2
	public USplineComponent SplineComp { get; set; }
}
