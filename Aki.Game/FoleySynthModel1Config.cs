using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002577 RID: 9591
[NullableContext(1)]
[Nullable(0)]
public class FoleySynthModel1Config : FoleySynthModelConfig
{
	// Token: 0x0400C9AB RID: 51627
	public float Ceil;

	// Token: 0x0400C9AC RID: 51628
	public string CeilEvent = "";

	// Token: 0x0400C9AD RID: 51629
	public float Floor;

	// Token: 0x0400C9AE RID: 51630
	public string FloorEvent = "";

	// Token: 0x0400C9AF RID: 51631
	[Nullable(2)]
	public UAkRtpc Rtpc;

	// Token: 0x0400C9B0 RID: 51632
	public float CeilInterpolation;

	// Token: 0x0400C9B1 RID: 51633
	public float FloorInterpolation;
}
