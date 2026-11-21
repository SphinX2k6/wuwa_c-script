using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F9A RID: 24474
	public class ISplineWayPointWithWeightT
	{
		// Token: 0x1700B53D RID: 46397
		// (get) Token: 0x0602929C RID: 168604 RVA: 0x0059ED66 File Offset: 0x0059CF66
		// (set) Token: 0x0602929D RID: 168605 RVA: 0x0059ED6E File Offset: 0x0059CF6E
		public int Spline { get; set; }

		// Token: 0x1700B53E RID: 46398
		// (get) Token: 0x0602929E RID: 168606 RVA: 0x0059ED77 File Offset: 0x0059CF77
		// (set) Token: 0x0602929F RID: 168607 RVA: 0x0059ED7F File Offset: 0x0059CF7F
		public int PointId { get; set; }

		// Token: 0x1700B53F RID: 46399
		// (get) Token: 0x060292A0 RID: 168608 RVA: 0x0059ED88 File Offset: 0x0059CF88
		// (set) Token: 0x060292A1 RID: 168609 RVA: 0x0059ED90 File Offset: 0x0059CF90
		public int Weight { get; set; }

		// Token: 0x060292A2 RID: 168610 RVA: 0x0059ED99 File Offset: 0x0059CF99
		public ISplineWayPointWithWeightT()
		{
			this.Spline = 0;
			this.PointId = 0;
			this.Weight = 0;
		}
	}
}
