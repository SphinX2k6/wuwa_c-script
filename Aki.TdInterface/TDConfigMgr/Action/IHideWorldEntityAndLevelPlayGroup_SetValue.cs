using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CBD RID: 7357
	[NullableContext(2)]
	[Nullable(0)]
	public class IHideWorldEntityAndLevelPlayGroup_SetValue
	{
		// Token: 0x04005F90 RID: 24464
		public EHideType Type;

		// Token: 0x04005F91 RID: 24465
		[Nullable(0)]
		public List<int> HideRangeEntities;

		// Token: 0x04005F92 RID: 24466
		public List<int> ExcludeEntities;

		// Token: 0x04005F93 RID: 24467
		public List<int> ExcludeLevelPlays;

		// Token: 0x04005F94 RID: 24468
		public List<int> AppendEntities;

		// Token: 0x04005F95 RID: 24469
		public List<int> AppendLevelPlays;
	}
}
