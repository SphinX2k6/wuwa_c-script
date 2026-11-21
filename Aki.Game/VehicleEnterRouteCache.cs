using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002763 RID: 10083
public class VehicleEnterRouteCache
{
	// Token: 0x0400DD79 RID: 56697
	public int VehicleEntityId;

	// Token: 0x0400DD7A RID: 56698
	public CommonNpcPerformComponent.EEnterVehicleDirection Direction;

	// Token: 0x0400DD7B RID: 56699
	[Nullable(1)]
	public readonly List<Vector> Path = new List<Vector>();
}
