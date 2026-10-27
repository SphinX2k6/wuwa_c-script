using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001829 RID: 6185
	public class IBvbDeploy_SetValue
	{
		// Token: 0x040053F4 RID: 21492
		public EBvbPlayerOperationType Type;

		// Token: 0x040053F5 RID: 21493
		public int? HandCardIndex;

		// Token: 0x040053F6 RID: 21494
		public int? BoardPosIndex;

		// Token: 0x040053F7 RID: 21495
		[Nullable(2)]
		public List<int> BoardPosIndexList;
	}
}
