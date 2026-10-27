using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001825 RID: 6181
	public class IBvbChangeBoardCard_SetValue
	{
		// Token: 0x040053EB RID: 21483
		public EBvbPlayerOperationType Type;

		// Token: 0x040053EC RID: 21484
		public int? BoardPosIndex;

		// Token: 0x040053ED RID: 21485
		[Nullable(2)]
		public List<int> BoardPosIndexList;
	}
}
