using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000390 RID: 912
[NullableContext(1)]
[Nullable(0)]
public class GuideEffectSpline : IGuideEffectSpline
{
	// Token: 0x1700076B RID: 1899
	// (get) Token: 0x06003279 RID: 12921 RVA: 0x00122AE4 File Offset: 0x00120CE4
	// (set) Token: 0x0600327A RID: 12922 RVA: 0x00122AEC File Offset: 0x00120CEC
	public int EffectHandle { get; set; }

	// Token: 0x1700076C RID: 1900
	// (get) Token: 0x0600327B RID: 12923 RVA: 0x00122AF5 File Offset: 0x00120CF5
	// (set) Token: 0x0600327C RID: 12924 RVA: 0x00122AFD File Offset: 0x00120CFD
	public AActor SplineActor { get; set; }

	// Token: 0x1700076D RID: 1901
	// (get) Token: 0x0600327D RID: 12925 RVA: 0x00122B06 File Offset: 0x00120D06
	// (set) Token: 0x0600327E RID: 12926 RVA: 0x00122B0E File Offset: 0x00120D0E
	public USplineComponent SplineComp { get; set; }
}
