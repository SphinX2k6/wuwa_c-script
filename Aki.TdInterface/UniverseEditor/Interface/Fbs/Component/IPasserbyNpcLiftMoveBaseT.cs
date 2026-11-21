using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C8B RID: 23691
	public class IPasserbyNpcLiftMoveBaseT
	{
		// Token: 0x1700AE0B RID: 44555
		// (get) Token: 0x060274CF RID: 160975 RVA: 0x00561ABE File Offset: 0x0055FCBE
		// (set) Token: 0x060274D0 RID: 160976 RVA: 0x00561AC6 File Offset: 0x0055FCC6
		public EPasserbyNpcLiftMoveType Type { get; set; }

		// Token: 0x060274D1 RID: 160977 RVA: 0x00561ACF File Offset: 0x0055FCCF
		public IPasserbyNpcLiftMoveBaseT()
		{
			this.Type = EPasserbyNpcLiftMoveType.RideLiftLeaveOnArrival;
		}
	}
}
