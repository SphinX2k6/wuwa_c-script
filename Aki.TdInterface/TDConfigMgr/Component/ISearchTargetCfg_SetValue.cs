using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006BD RID: 1725
	[NullableContext(1)]
	[Nullable(0)]
	public class ISearchTargetCfg_SetValue
	{
		// Token: 0x0400195F RID: 6495
		public List<IEntityAngleWeight> AngleWeight;

		// Token: 0x04001960 RID: 6496
		public List<IEntityCategoryWeight> LockConditions;

		// Token: 0x04001961 RID: 6497
		public bool? IgnoreDistanceWeight;
	}
}
