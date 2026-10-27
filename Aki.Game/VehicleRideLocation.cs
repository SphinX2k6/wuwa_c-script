using System;
using System.Runtime.CompilerServices;

// Token: 0x020031F2 RID: 12786
public class VehicleRideLocation
{
	// Token: 0x0400D8D7 RID: 55511
	public CommonNpcPerformComponent.EEnterVehicleDirection Direction;

	// Token: 0x0400D8D8 RID: 55512
	[Nullable(1)]
	public readonly Vector Location = Vector.Create();
}
