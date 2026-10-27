using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020000FE RID: 254
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityGroupComponent_SetValue
	{
		// Token: 0x0400054F RID: 1359
		public bool? Disabled;

		// Token: 0x04000550 RID: 1360
		public bool? EdIsLocked;

		// Token: 0x04000551 RID: 1361
		public List<int> EntityIds;

		// Token: 0x04000552 RID: 1362
		public List<IEntityStateTrigger> StateTriggers;

		// Token: 0x04000553 RID: 1363
		public IFinishStateTrigger FinishState;

		// Token: 0x04000554 RID: 1364
		[Nullable(2)]
		public IFailureStateTrigger FailureState;
	}
}
