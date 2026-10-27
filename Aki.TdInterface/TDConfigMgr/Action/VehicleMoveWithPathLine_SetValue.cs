using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002274 RID: 8820
	[NullableContext(1)]
	[Nullable(0)]
	public class VehicleMoveWithPathLine_SetValue
	{
		// Token: 0x04007345 RID: 29509
		public ITargetVehicle TargetVehicle;

		// Token: 0x04007346 RID: 29510
		public int SplineEntityId;

		// Token: 0x04007347 RID: 29511
		public IVehicleControlType ControlType;
	}
}
