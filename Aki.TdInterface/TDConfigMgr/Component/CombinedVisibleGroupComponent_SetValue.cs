using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000047 RID: 71
	[NullableContext(1)]
	[Nullable(0)]
	public class CombinedVisibleGroupComponent_SetValue
	{
		// Token: 0x0400017C RID: 380
		public bool? Disabled;

		// Token: 0x0400017D RID: 381
		public bool? EdIsLocked;

		// Token: 0x0400017E RID: 382
		public List<int> AreaIds;

		// Token: 0x0400017F RID: 383
		public bool IncludeSubArea;

		// Token: 0x04000180 RID: 384
		public List<int> EntityIds;
	}
}
