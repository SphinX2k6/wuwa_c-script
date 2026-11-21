using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D0E RID: 23822
	public enum IPatrolPositionRefreshTrigger_Union : byte
	{
		// Token: 0x0400F847 RID: 63559
		NONE,
		// Token: 0x0400F848 RID: 63560
		IPatrolPositionRefreshTrigger,
		// Token: 0x0400F849 RID: 63561
		IPatrolPositionRefreshOnEntityAwake,
		// Token: 0x0400F84A RID: 63562
		IPatrolPositionRefreshOnEntityVisibilityShown
	}
}
