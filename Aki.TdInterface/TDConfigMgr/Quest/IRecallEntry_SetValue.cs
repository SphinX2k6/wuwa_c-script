using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010E9 RID: 4329
	[NullableContext(1)]
	[Nullable(0)]
	public class IRecallEntry_SetValue
	{
		// Token: 0x04003ADD RID: 15069
		public int RecallId;

		// Token: 0x04003ADE RID: 15070
		public List<int> IncludeGroups;

		// Token: 0x04003ADF RID: 15071
		public List<int> ExcludeGroups;
	}
}
