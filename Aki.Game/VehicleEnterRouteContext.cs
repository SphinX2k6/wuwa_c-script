using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002764 RID: 10084
[NullableContext(2)]
[Nullable(0)]
public class VehicleEnterRouteContext
{
	// Token: 0x0400DD7C RID: 56700
	public UWorld World;

	// Token: 0x0400DD7D RID: 56701
	public double NpcLateral;

	// Token: 0x0400DD7E RID: 56702
	public float ObstacleHalfLength;

	// Token: 0x0400DD7F RID: 56703
	public float ObstacleHalfWidth;

	// Token: 0x0400DD80 RID: 56704
	public float WaypointHalfLength;

	// Token: 0x0400DD81 RID: 56705
	public double WaypointHalfWidth;

	// Token: 0x0400DD82 RID: 56706
	public VehicleRideLocation SameSideRide;

	// Token: 0x0400DD83 RID: 56707
	public VehicleRideLocation OppositeRide;
}
