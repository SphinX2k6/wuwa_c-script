using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D0C RID: 23820
	public class IPatrolPositionRefreshTriggerT
	{
		// Token: 0x1700AF00 RID: 44800
		// (get) Token: 0x06027906 RID: 162054 RVA: 0x00569916 File Offset: 0x00567B16
		// (set) Token: 0x06027907 RID: 162055 RVA: 0x0056991E File Offset: 0x00567B1E
		public EPatrolPositionRefreshTriggerType Type { get; set; }

		// Token: 0x06027908 RID: 162056 RVA: 0x00569927 File Offset: 0x00567B27
		public IPatrolPositionRefreshTriggerT()
		{
			this.Type = EPatrolPositionRefreshTriggerType.EntityAwake;
		}
	}
}
