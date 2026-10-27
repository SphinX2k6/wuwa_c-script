using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200053D RID: 1341
	public class IMovementVehicleFeature_SetValue
	{
		// Token: 0x040013C4 RID: 5060
		public EVehicleFeatureFlag Type;

		// Token: 0x040013C5 RID: 5061
		public int? MoveSpline;

		// Token: 0x040013C6 RID: 5062
		[Nullable(2)]
		public IMovementPerformConfig MovePerformConfig;
	}
}
