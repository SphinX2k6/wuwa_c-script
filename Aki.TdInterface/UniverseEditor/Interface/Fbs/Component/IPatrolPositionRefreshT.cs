using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CFD RID: 23805
	public class IPatrolPositionRefreshT
	{
		// Token: 0x1700AEEE RID: 44782
		// (get) Token: 0x06027898 RID: 161944 RVA: 0x00568CEA File Offset: 0x00566EEA
		// (set) Token: 0x06027899 RID: 161945 RVA: 0x00568CF2 File Offset: 0x00566EF2
		public EPatrolPositionRefreshType Type { get; set; }

		// Token: 0x0602789A RID: 161946 RVA: 0x00568CFB File Offset: 0x00566EFB
		public IPatrolPositionRefreshT()
		{
			this.Type = EPatrolPositionRefreshType.NearestSplinePointToPlayer;
		}
	}
}
