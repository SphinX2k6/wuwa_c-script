using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001616 RID: 5654
	public class CallByCondition_SetValue
	{
		// Token: 0x040049CC RID: 18892
		public IConditions Conditions;

		// Token: 0x040049CD RID: 18893
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> TrueActions;

		// Token: 0x040049CE RID: 18894
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> FalseActions;
	}
}
