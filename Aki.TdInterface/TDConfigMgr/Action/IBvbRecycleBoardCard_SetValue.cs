using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001831 RID: 6193
	public class IBvbRecycleBoardCard_SetValue
	{
		// Token: 0x04005406 RID: 21510
		public EBvbPlayerOperationType Type;

		// Token: 0x04005407 RID: 21511
		public int? BoardPosIndex;

		// Token: 0x04005408 RID: 21512
		[Nullable(2)]
		public List<int> BoardPosIndexList;
	}
}
