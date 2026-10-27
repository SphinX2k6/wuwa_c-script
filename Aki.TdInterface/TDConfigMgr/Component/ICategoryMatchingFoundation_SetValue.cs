using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000224 RID: 548
	public class ICategoryMatchingFoundation_SetValue
	{
		// Token: 0x040009CA RID: 2506
		public EItemFoundation Type;

		// Token: 0x040009CB RID: 2507
		public int? InitMatchEntity;

		// Token: 0x040009CC RID: 2508
		[Nullable(1)]
		public List<ICategoryMatchingConfig> MatchingConfigs;
	}
}
