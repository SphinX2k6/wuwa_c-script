using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005E3 RID: 1507
	public class IPatrolAction_SetValue
	{
		// Token: 0x04001677 RID: 5751
		public int Point;

		// Token: 0x04001678 RID: 5752
		[Nullable(1)]
		public List<ActionInfo> Actions;
	}
}
