using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C88 RID: 23688
	public class IPasserbyNpcLiftMoveT
	{
		// Token: 0x1700AE07 RID: 44551
		// (get) Token: 0x060274BB RID: 160955 RVA: 0x005618FF File Offset: 0x0055FAFF
		// (set) Token: 0x060274BC RID: 160956 RVA: 0x00561907 File Offset: 0x0055FB07
		public EPasserbyNpcMoveType Type { get; set; }

		// Token: 0x1700AE08 RID: 44552
		// (get) Token: 0x060274BD RID: 160957 RVA: 0x00561910 File Offset: 0x0055FB10
		// (set) Token: 0x060274BE RID: 160958 RVA: 0x00561918 File Offset: 0x0055FB18
		public IPasserbyNpcRideLiftLeaveOnArrivalMoveT NpcLiftConfig { get; set; }

		// Token: 0x060274BF RID: 160959 RVA: 0x00561921 File Offset: 0x0055FB21
		public IPasserbyNpcLiftMoveT()
		{
			this.Type = EPasserbyNpcMoveType.Spline;
			this.NpcLiftConfig = null;
		}
	}
}
