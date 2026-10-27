using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003021 RID: 12321
[NullableContext(1)]
[Nullable(0)]
public class FoleySynthModel1Config : FoleySynthModelConfig
{
	// Token: 0x0400C5DE RID: 50654
	public float Ceil;

	// Token: 0x0400C5DF RID: 50655
	public string CeilEvent = "";

	// Token: 0x0400C5E0 RID: 50656
	public float Floor;

	// Token: 0x0400C5E1 RID: 50657
	public string FloorEvent = "";

	// Token: 0x0400C5E2 RID: 50658
	[Nullable(2)]
	public UAkRtpc Rtpc;

	// Token: 0x0400C5E3 RID: 50659
	public float CeilInterpolation;

	// Token: 0x0400C5E4 RID: 50660
	public float FloorInterpolation;
}
