using System;
using System.Runtime.CompilerServices;

// Token: 0x02002848 RID: 10312
[NullableContext(2)]
[Nullable(0)]
public class IMoveVehicleConfig
{
	// Token: 0x0400E49E RID: 58526
	public int SplineId;

	// Token: 0x0400E49F RID: 58527
	public bool? SimulateRotation;

	// Token: 0x0400E4A0 RID: 58528
	public bool? FixedPitch;

	// Token: 0x0400E4A1 RID: 58529
	public bool? NeedSync;

	// Token: 0x0400E4A2 RID: 58530
	public bool? DynamicGravity;

	// Token: 0x0400E4A3 RID: 58531
	public bool? StartFromNearest;

	// Token: 0x0400E4A4 RID: 58532
	public bool? ForceToFirstPoint;

	// Token: 0x0400E4A5 RID: 58533
	public bool? KeepForward;

	// Token: 0x0400E4A6 RID: 58534
	public Action<bool> OnArriveStartPointHandle;

	// Token: 0x0400E4A7 RID: 58535
	public Action<bool> OnMoveEndHandle;
}
