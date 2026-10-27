using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200039F RID: 927
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowerPollutionPointLightConfig_SetValue
	{
		// Token: 0x04000EDE RID: 3806
		public List<int> PointLightEntityIds;

		// Token: 0x04000EDF RID: 3807
		public List<IPointLightOperations> PointLightConfig;
	}
}
