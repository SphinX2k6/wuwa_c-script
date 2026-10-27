using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003022 RID: 12322
[NullableContext(2)]
[Nullable(0)]
public class FoleySynthModel2Config : FoleySynthModelConfig
{
	// Token: 0x0400C5E5 RID: 50661
	public float Ceil;

	// Token: 0x0400C5E6 RID: 50662
	[Nullable(1)]
	public string CeilEvent = "";

	// Token: 0x0400C5E7 RID: 50663
	public float Floor;

	// Token: 0x0400C5E8 RID: 50664
	[Nullable(1)]
	public string FloorEvent = "";

	// Token: 0x0400C5E9 RID: 50665
	public float FloorPrecent;

	// Token: 0x0400C5EA RID: 50666
	public UAkRtpc RtpcVelMax;

	// Token: 0x0400C5EB RID: 50667
	public UAkRtpc RtpcAccMax;

	// Token: 0x0400C5EC RID: 50668
	public UAkRtpc RtpcVelDur;

	// Token: 0x0400C5ED RID: 50669
	public float CeilInterpolation;

	// Token: 0x0400C5EE RID: 50670
	public float FloorInterpolation;
}
