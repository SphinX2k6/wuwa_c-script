using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005A4 RID: 1444
	public class IMovementVehicleFeature_SetValue
	{
		// Token: 0x0400152E RID: 5422
		public EVehicleFeatureFlag Type;

		// Token: 0x0400152F RID: 5423
		public int? MoveSpline;

		// Token: 0x04001530 RID: 5424
		[Nullable(2)]
		public IMovementPerformConfig MovePerformConfig;
	}
}
