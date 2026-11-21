using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000107 RID: 263
	public class EntityGroupComponent_SetValue
	{
		// Token: 0x04000579 RID: 1401
		public bool? Disabled;

		// Token: 0x0400057A RID: 1402
		public bool? EdIsLocked;

		// Token: 0x0400057B RID: 1403
		public List<int> EntityIds;

		// Token: 0x0400057C RID: 1404
		public List<IEntityStateTrigger> StateTriggers;

		// Token: 0x0400057D RID: 1405
		public IFinishStateTrigger FinishState;

		// Token: 0x0400057E RID: 1406
		[Nullable(2)]
		public IFailureStateTrigger FailureState;
	}
}
