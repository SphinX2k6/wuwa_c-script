using System;
using System.Runtime.CompilerServices;

// Token: 0x020032D6 RID: 13014
[NullableContext(2)]
[Nullable(0)]
public class IMoveVehicleConfig
{
	// Token: 0x0400DFF3 RID: 57331
	public int SplineId;

	// Token: 0x0400DFF4 RID: 57332
	public bool? SimulateRotation;

	// Token: 0x0400DFF5 RID: 57333
	public bool? FixedPitch;

	// Token: 0x0400DFF6 RID: 57334
	public bool? NeedSync;

	// Token: 0x0400DFF7 RID: 57335
	public bool? DynamicGravity;

	// Token: 0x0400DFF8 RID: 57336
	public bool? StartFromNearest;

	// Token: 0x0400DFF9 RID: 57337
	public bool? ForceToFirstPoint;

	// Token: 0x0400DFFA RID: 57338
	public bool? KeepForward;

	// Token: 0x0400DFFB RID: 57339
	public Action<bool> OnArriveStartPointHandle;

	// Token: 0x0400DFFC RID: 57340
	public Action<bool> OnMoveEndHandle;
}
