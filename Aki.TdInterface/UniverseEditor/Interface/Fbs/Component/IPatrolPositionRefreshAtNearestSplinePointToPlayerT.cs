using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D00 RID: 23808
	public class IPatrolPositionRefreshAtNearestSplinePointToPlayerT
	{
		// Token: 0x1700AEF1 RID: 44785
		// (get) Token: 0x060278AA RID: 161962 RVA: 0x00568E62 File Offset: 0x00567062
		// (set) Token: 0x060278AB RID: 161963 RVA: 0x00568E6A File Offset: 0x0056706A
		public EPatrolPositionRefreshType Type { get; set; }

		// Token: 0x060278AC RID: 161964 RVA: 0x00568E73 File Offset: 0x00567073
		public IPatrolPositionRefreshAtNearestSplinePointToPlayerT()
		{
			this.Type = EPatrolPositionRefreshType.NearestSplinePointToPlayer;
		}
	}
}
