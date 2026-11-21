using System;
using System.Runtime.CompilerServices;

// Token: 0x02002766 RID: 10086
[NullableContext(1)]
[Nullable(0)]
public class VehicleEnterBoxDebugGeometry
{
	// Token: 0x0400DD86 RID: 56710
	public readonly Vector Center = Vector.Create();

	// Token: 0x0400DD87 RID: 56711
	public readonly Rotator Rotation = Rotator.Create();

	// Token: 0x0400DD88 RID: 56712
	public float ObstacleHalfLength;

	// Token: 0x0400DD89 RID: 56713
	public float ObstacleHalfWidth;

	// Token: 0x0400DD8A RID: 56714
	public float WaypointHalfLength;

	// Token: 0x0400DD8B RID: 56715
	public double WaypointHalfWidth;
}
