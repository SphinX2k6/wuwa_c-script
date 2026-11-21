using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200796F RID: 31087
	public class ISplineWayPointT
	{
		// Token: 0x1700E3F6 RID: 58358
		// (get) Token: 0x06036C02 RID: 224258 RVA: 0x00753024 File Offset: 0x00751224
		// (set) Token: 0x06036C03 RID: 224259 RVA: 0x0075302C File Offset: 0x0075122C
		public int Spline { get; set; }

		// Token: 0x1700E3F7 RID: 58359
		// (get) Token: 0x06036C04 RID: 224260 RVA: 0x00753035 File Offset: 0x00751235
		// (set) Token: 0x06036C05 RID: 224261 RVA: 0x0075303D File Offset: 0x0075123D
		public int PointId { get; set; }

		// Token: 0x06036C06 RID: 224262 RVA: 0x00753046 File Offset: 0x00751246
		public ISplineWayPointT()
		{
			this.Spline = 0;
			this.PointId = 0;
		}
	}
}
