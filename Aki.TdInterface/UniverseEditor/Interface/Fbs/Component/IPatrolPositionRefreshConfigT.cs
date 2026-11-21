using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D03 RID: 23811
	public class IPatrolPositionRefreshConfigT
	{
		// Token: 0x1700AEF6 RID: 44790
		// (get) Token: 0x060278CE RID: 161998 RVA: 0x00569467 File Offset: 0x00567667
		// (set) Token: 0x060278CF RID: 161999 RVA: 0x0056946F File Offset: 0x0056766F
		public List<TPatrolPositionRefreshTriggerUnion> TriggerConditions { get; set; }

		// Token: 0x1700AEF7 RID: 44791
		// (get) Token: 0x060278D0 RID: 162000 RVA: 0x00569478 File Offset: 0x00567678
		// (set) Token: 0x060278D1 RID: 162001 RVA: 0x00569480 File Offset: 0x00567680
		public IPatrolPositionRefreshAtNearestSplinePointToPlayerT Refresh { get; set; }

		// Token: 0x060278D2 RID: 162002 RVA: 0x00569489 File Offset: 0x00567689
		public IPatrolPositionRefreshConfigT()
		{
			this.TriggerConditions = null;
			this.Refresh = null;
		}
	}
}
