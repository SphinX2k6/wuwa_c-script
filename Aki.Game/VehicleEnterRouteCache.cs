using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020031F4 RID: 12788
public class VehicleEnterRouteCache
{
	// Token: 0x0400D8DB RID: 55515
	public int VehicleEntityId;

	// Token: 0x0400D8DC RID: 55516
	public CommonNpcPerformComponent.EEnterVehicleDirection Direction;

	// Token: 0x0400D8DD RID: 55517
	[Nullable(1)]
	public readonly List<Vector> Path = new List<Vector>();
}
