using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000535 RID: 1333
	public class IMovablePlatformVehicleFeature_SetValue
	{
		// Token: 0x040013A2 RID: 5026
		public EVehicleFeatureFlag Type;

		// Token: 0x040013A3 RID: 5027
		[Nullable(1)]
		public List<int> PlayerAttachTags;

		// Token: 0x040013A4 RID: 5028
		public int SafePointId;
	}
}
