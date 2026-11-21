using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D06 RID: 23814
	public class IPatrolPositionRefreshOnEntityAwakeT
	{
		// Token: 0x1700AEFA RID: 44794
		// (get) Token: 0x060278E2 RID: 162018 RVA: 0x00569626 File Offset: 0x00567826
		// (set) Token: 0x060278E3 RID: 162019 RVA: 0x0056962E File Offset: 0x0056782E
		public EPatrolPositionRefreshTriggerType Type { get; set; }

		// Token: 0x060278E4 RID: 162020 RVA: 0x00569637 File Offset: 0x00567837
		public IPatrolPositionRefreshOnEntityAwakeT()
		{
			this.Type = EPatrolPositionRefreshTriggerType.EntityAwake;
		}
	}
}
