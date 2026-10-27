using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005E1 RID: 1505
	public class IPatrol_SetValue
	{
		// Token: 0x0400166D RID: 5741
		public bool? Disabled;

		// Token: 0x0400166E RID: 5742
		public bool? EdIsLocked;

		// Token: 0x0400166F RID: 5743
		public int SplineEntityId;

		// Token: 0x04001670 RID: 5744
		[Nullable(2)]
		public List<int> SplineEntityIds;

		// Token: 0x04001671 RID: 5745
		public bool IsCircle;

		// Token: 0x04001672 RID: 5746
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IPatrolAction> Actions;
	}
}
