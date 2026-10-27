using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002042 RID: 8258
	public class IVehicleNewSplineMoveTarget_SetValue
	{
		// Token: 0x04006D31 RID: 27953
		public ENewSplineMoveTargetType Type;

		// Token: 0x04006D32 RID: 27954
		[Nullable(1)]
		public ITargetVehicle TargetVehicle;

		// Token: 0x04006D33 RID: 27955
		public bool? IsLookDir;
	}
}
