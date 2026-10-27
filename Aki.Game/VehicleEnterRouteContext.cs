using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020031F5 RID: 12789
[NullableContext(2)]
[Nullable(0)]
public class VehicleEnterRouteContext
{
	// Token: 0x0400D8DE RID: 55518
	public UWorld World;

	// Token: 0x0400D8DF RID: 55519
	public double NpcLateral;

	// Token: 0x0400D8E0 RID: 55520
	public float ObstacleHalfLength;

	// Token: 0x0400D8E1 RID: 55521
	public float ObstacleHalfWidth;

	// Token: 0x0400D8E2 RID: 55522
	public float WaypointHalfLength;

	// Token: 0x0400D8E3 RID: 55523
	public double WaypointHalfWidth;

	// Token: 0x0400D8E4 RID: 55524
	public VehicleRideLocation SameSideRide;

	// Token: 0x0400D8E5 RID: 55525
	public VehicleRideLocation OppositeRide;
}
