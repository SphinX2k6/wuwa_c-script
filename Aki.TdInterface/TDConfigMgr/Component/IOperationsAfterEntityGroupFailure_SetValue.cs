using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005B5 RID: 1461
	public class IOperationsAfterEntityGroupFailure_SetValue
	{
		// Token: 0x040015E6 RID: 5606
		public bool? IsResetState;

		// Token: 0x040015E7 RID: 5607
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Actions;
	}
}
