using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002660 RID: 9824
[NullableContext(1)]
public interface ISpherePullTarget
{
	// Token: 0x170026E0 RID: 9952
	// (get) Token: 0x0601899A RID: 100762
	// (set) Token: 0x0601899B RID: 100763
	IVector Center { get; set; }

	// Token: 0x170026E1 RID: 9953
	// (get) Token: 0x0601899C RID: 100764
	// (set) Token: 0x0601899D RID: 100765
	float Radius { get; set; }

	// Token: 0x170026E2 RID: 9954
	// (get) Token: 0x0601899E RID: 100766
	// (set) Token: 0x0601899F RID: 100767
	float GroundHeight { get; set; }

	// Token: 0x170026E3 RID: 9955
	// (get) Token: 0x060189A0 RID: 100768
	// (set) Token: 0x060189A1 RID: 100769
	IVector GravityDirection { get; set; }

	// Token: 0x170026E4 RID: 9956
	// (get) Token: 0x060189A2 RID: 100770
	// (set) Token: 0x060189A3 RID: 100771
	CurveBase Curve { get; set; }
}
