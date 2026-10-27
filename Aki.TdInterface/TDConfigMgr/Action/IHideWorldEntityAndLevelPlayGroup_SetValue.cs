using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B0E RID: 6926
	[NullableContext(2)]
	[Nullable(0)]
	public class IHideWorldEntityAndLevelPlayGroup_SetValue
	{
		// Token: 0x04005AF2 RID: 23282
		public EHideType Type;

		// Token: 0x04005AF3 RID: 23283
		[Nullable(1)]
		public List<int> HideRangeEntities;

		// Token: 0x04005AF4 RID: 23284
		public List<int> ExcludeEntities;

		// Token: 0x04005AF5 RID: 23285
		public List<int> ExcludeLevelPlays;

		// Token: 0x04005AF6 RID: 23286
		public List<int> AppendEntities;

		// Token: 0x04005AF7 RID: 23287
		public List<int> AppendLevelPlays;
	}
}
