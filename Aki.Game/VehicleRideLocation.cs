using System;
using System.Runtime.CompilerServices;

// Token: 0x02002761 RID: 10081
public class VehicleRideLocation
{
	// Token: 0x0400DD75 RID: 56693
	public CommonNpcPerformComponent.EEnterVehicleDirection Direction;

	// Token: 0x0400DD76 RID: 56694
	[Nullable(1)]
	public readonly Vector Location = Vector.Create();
}
