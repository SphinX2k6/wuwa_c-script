using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200598D RID: 22925
	public class ISplineWayPointWithWeightT
	{
		// Token: 0x1700AC09 RID: 44041
		// (get) Token: 0x06026D32 RID: 159026 RVA: 0x005580FA File Offset: 0x005562FA
		// (set) Token: 0x06026D33 RID: 159027 RVA: 0x00558102 File Offset: 0x00556302
		public int Spline { get; set; }

		// Token: 0x1700AC0A RID: 44042
		// (get) Token: 0x06026D34 RID: 159028 RVA: 0x0055810B File Offset: 0x0055630B
		// (set) Token: 0x06026D35 RID: 159029 RVA: 0x00558113 File Offset: 0x00556313
		public int PointId { get; set; }

		// Token: 0x1700AC0B RID: 44043
		// (get) Token: 0x06026D36 RID: 159030 RVA: 0x0055811C File Offset: 0x0055631C
		// (set) Token: 0x06026D37 RID: 159031 RVA: 0x00558124 File Offset: 0x00556324
		public int Weight { get; set; }

		// Token: 0x06026D38 RID: 159032 RVA: 0x0055812D File Offset: 0x0055632D
		public ISplineWayPointWithWeightT()
		{
			this.Spline = 0;
			this.PointId = 0;
			this.Weight = 0;
		}
	}
}
