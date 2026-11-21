using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200067E RID: 1662
	public class IPatrolPositionRefreshConfig_SetValue
	{
		// Token: 0x04001861 RID: 6241
		public List<IPatrolPositionRefreshTrigger> TriggerConditions;

		// Token: 0x04001862 RID: 6242
		public IPatrolPositionRefreshAtNearestSplinePointToPlayer Refresh;
	}
}
