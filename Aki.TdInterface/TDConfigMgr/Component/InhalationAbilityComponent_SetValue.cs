using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000549 RID: 1353
	public class InhalationAbilityComponent_SetValue
	{
		// Token: 0x040013E1 RID: 5089
		public bool? Disabled;

		// Token: 0x040013E2 RID: 5090
		public bool? EdIsLocked;

		// Token: 0x040013E3 RID: 5091
		[Nullable(1)]
		public List<IInhalationConfig> InhalationConfigs;
	}
}
