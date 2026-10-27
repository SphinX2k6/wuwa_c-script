using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014BD RID: 5309
	public class CallByCondition_SetValue
	{
		// Token: 0x04004631 RID: 17969
		[Nullable(1)]
		public IConditions Conditions;

		// Token: 0x04004632 RID: 17970
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> TrueActions;

		// Token: 0x04004633 RID: 17971
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> FalseActions;
	}
}
