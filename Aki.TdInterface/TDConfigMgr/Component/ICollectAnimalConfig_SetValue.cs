using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000248 RID: 584
	public class ICollectAnimalConfig_SetValue
	{
		// Token: 0x04000A77 RID: 2679
		public ESpecialAnimalType Type;

		// Token: 0x04000A78 RID: 2680
		[Nullable(1)]
		public List<ICollectAnimalPartsConfig> PartsMap;
	}
}
