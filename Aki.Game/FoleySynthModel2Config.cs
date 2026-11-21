using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002578 RID: 9592
[NullableContext(2)]
[Nullable(0)]
public class FoleySynthModel2Config : FoleySynthModelConfig
{
	// Token: 0x0400C9B2 RID: 51634
	public float Ceil;

	// Token: 0x0400C9B3 RID: 51635
	[Nullable(1)]
	public string CeilEvent = "";

	// Token: 0x0400C9B4 RID: 51636
	public float Floor;

	// Token: 0x0400C9B5 RID: 51637
	[Nullable(1)]
	public string FloorEvent = "";

	// Token: 0x0400C9B6 RID: 51638
	public float FloorPrecent;

	// Token: 0x0400C9B7 RID: 51639
	public UAkRtpc RtpcVelMax;

	// Token: 0x0400C9B8 RID: 51640
	public UAkRtpc RtpcAccMax;

	// Token: 0x0400C9B9 RID: 51641
	public UAkRtpc RtpcVelDur;

	// Token: 0x0400C9BA RID: 51642
	public float CeilInterpolation;

	// Token: 0x0400C9BB RID: 51643
	public float FloorInterpolation;
}
