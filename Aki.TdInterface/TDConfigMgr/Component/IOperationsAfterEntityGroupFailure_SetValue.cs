using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000620 RID: 1568
	public class IOperationsAfterEntityGroupFailure_SetValue
	{
		// Token: 0x0400175A RID: 5978
		public bool? IsResetState;

		// Token: 0x0400175B RID: 5979
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> Actions;
	}
}
