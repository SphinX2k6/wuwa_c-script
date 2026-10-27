using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200719A RID: 29082
	public class ISplineWayPointT
	{
		// Token: 0x1700D7FF RID: 55295
		// (get) Token: 0x06033906 RID: 211206 RVA: 0x006F1D94 File Offset: 0x006EFF94
		// (set) Token: 0x06033907 RID: 211207 RVA: 0x006F1D9C File Offset: 0x006EFF9C
		public int Spline { get; set; }

		// Token: 0x1700D800 RID: 55296
		// (get) Token: 0x06033908 RID: 211208 RVA: 0x006F1DA5 File Offset: 0x006EFFA5
		// (set) Token: 0x06033909 RID: 211209 RVA: 0x006F1DAD File Offset: 0x006EFFAD
		public int PointId { get; set; }

		// Token: 0x0603390A RID: 211210 RVA: 0x006F1DB6 File Offset: 0x006EFFB6
		public ISplineWayPointT()
		{
			this.Spline = 0;
			this.PointId = 0;
		}
	}
}
