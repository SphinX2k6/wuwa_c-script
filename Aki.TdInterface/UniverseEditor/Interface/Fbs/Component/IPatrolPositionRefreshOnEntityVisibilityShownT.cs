using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D09 RID: 23817
	public class IPatrolPositionRefreshOnEntityVisibilityShownT
	{
		// Token: 0x1700AEFD RID: 44797
		// (get) Token: 0x060278F4 RID: 162036 RVA: 0x0056979E File Offset: 0x0056799E
		// (set) Token: 0x060278F5 RID: 162037 RVA: 0x005697A6 File Offset: 0x005679A6
		public EPatrolPositionRefreshTriggerType Type { get; set; }

		// Token: 0x060278F6 RID: 162038 RVA: 0x005697AF File Offset: 0x005679AF
		public IPatrolPositionRefreshOnEntityVisibilityShownT()
		{
			this.Type = EPatrolPositionRefreshTriggerType.EntityAwake;
		}
	}
}
