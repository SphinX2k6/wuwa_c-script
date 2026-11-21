using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000672 RID: 1650
	public class IPatrol_SetValue
	{
		// Token: 0x04001844 RID: 6212
		public bool? Disabled;

		// Token: 0x04001845 RID: 6213
		public bool? EdIsLocked;

		// Token: 0x04001846 RID: 6214
		public int SplineEntityId;

		// Token: 0x04001847 RID: 6215
		[Nullable(2)]
		public List<int> SplineEntityIds;

		// Token: 0x04001848 RID: 6216
		public bool IsCircle;

		// Token: 0x04001849 RID: 6217
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IPatrolAction> Actions;
	}
}
