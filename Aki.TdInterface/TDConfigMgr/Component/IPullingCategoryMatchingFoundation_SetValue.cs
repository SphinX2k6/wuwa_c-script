using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000631 RID: 1585
	public class IPullingCategoryMatchingFoundation_SetValue
	{
		// Token: 0x04001798 RID: 6040
		public EPullingFoundation Type;

		// Token: 0x04001799 RID: 6041
		public int? InitMatchEntity;

		// Token: 0x0400179A RID: 6042
		[Nullable(1)]
		public List<ICategoryMatchingConfigBase> MatchingConfigs;
	}
}
