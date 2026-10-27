using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056B4 RID: 22196
	public class IParkourSplineT
	{
		// Token: 0x1700A519 RID: 42265
		// (get) Token: 0x060250F0 RID: 151792 RVA: 0x0051DDD0 File Offset: 0x0051BFD0
		// (set) Token: 0x060250F1 RID: 151793 RVA: 0x0051DDD8 File Offset: 0x0051BFD8
		public ESplineType Type { get; set; }

		// Token: 0x1700A51A RID: 42266
		// (get) Token: 0x060250F2 RID: 151794 RVA: 0x0051DDE1 File Offset: 0x0051BFE1
		// (set) Token: 0x060250F3 RID: 151795 RVA: 0x0051DDE9 File Offset: 0x0051BFE9
		public bool IsRequireToEnd { get; set; }

		// Token: 0x1700A51B RID: 42267
		// (get) Token: 0x060250F4 RID: 151796 RVA: 0x0051DDF2 File Offset: 0x0051BFF2
		// (set) Token: 0x060250F5 RID: 151797 RVA: 0x0051DDFA File Offset: 0x0051BFFA
		public int CheckPointsRequire { get; set; }

		// Token: 0x1700A51C RID: 42268
		// (get) Token: 0x060250F6 RID: 151798 RVA: 0x0051DE03 File Offset: 0x0051C003
		// (set) Token: 0x060250F7 RID: 151799 RVA: 0x0051DE0B File Offset: 0x0051C00B
		public string CheckPointResource { get; set; }

		// Token: 0x1700A51D RID: 42269
		// (get) Token: 0x060250F8 RID: 151800 RVA: 0x0051DE14 File Offset: 0x0051C014
		// (set) Token: 0x060250F9 RID: 151801 RVA: 0x0051DE1C File Offset: 0x0051C01C
		public string CheckPointsDestroyRes { get; set; }

		// Token: 0x1700A51E RID: 42270
		// (get) Token: 0x060250FA RID: 151802 RVA: 0x0051DE25 File Offset: 0x0051C025
		// (set) Token: 0x060250FB RID: 151803 RVA: 0x0051DE2D File Offset: 0x0051C02D
		public string StartResource { get; set; }

		// Token: 0x1700A51F RID: 42271
		// (get) Token: 0x060250FC RID: 151804 RVA: 0x0051DE36 File Offset: 0x0051C036
		// (set) Token: 0x060250FD RID: 151805 RVA: 0x0051DE3E File Offset: 0x0051C03E
		public string EndResource { get; set; }

		// Token: 0x1700A520 RID: 42272
		// (get) Token: 0x060250FE RID: 151806 RVA: 0x0051DE47 File Offset: 0x0051C047
		// (set) Token: 0x060250FF RID: 151807 RVA: 0x0051DE4F File Offset: 0x0051C04F
		public List<IParkourSplinePointT> Points { get; set; }

		// Token: 0x06025100 RID: 151808 RVA: 0x0051DE58 File Offset: 0x0051C058
		public IParkourSplineT()
		{
			this.Type = ESplineType.Common;
			this.IsRequireToEnd = false;
			this.CheckPointsRequire = 0;
			this.CheckPointResource = null;
			this.CheckPointsDestroyRes = null;
			this.StartResource = null;
			this.EndResource = null;
			this.Points = null;
		}
	}
}
