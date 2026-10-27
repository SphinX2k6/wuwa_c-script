using System;
using System.Runtime.CompilerServices;

// Token: 0x020031F7 RID: 12791
[NullableContext(1)]
[Nullable(0)]
public class VehicleEnterBoxDebugGeometry
{
	// Token: 0x0400D8E8 RID: 55528
	public readonly Vector Center = Vector.Create();

	// Token: 0x0400D8E9 RID: 55529
	public readonly Rotator Rotation = Rotator.Create();

	// Token: 0x0400D8EA RID: 55530
	public float ObstacleHalfLength;

	// Token: 0x0400D8EB RID: 55531
	public float ObstacleHalfWidth;

	// Token: 0x0400D8EC RID: 55532
	public float WaypointHalfLength;

	// Token: 0x0400D8ED RID: 55533
	public double WaypointHalfWidth;
}
