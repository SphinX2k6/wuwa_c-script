using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010DB RID: 4315
	public class IRecallConditionByGroup_SetValue
	{
		// Token: 0x04003AB9 RID: 15033
		public ERecallConditionType Type;

		// Token: 0x04003ABA RID: 15034
		public ERecallOperation Operation;

		// Token: 0x04003ABB RID: 15035
		[Nullable(1)]
		public List<int> GroupIds;
	}
}
