using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E10 RID: 24080
	public class IRangeSplineT
	{
		// Token: 0x1700B180 RID: 45440
		// (get) Token: 0x0602835F RID: 164703 RVA: 0x0057FD29 File Offset: 0x0057DF29
		// (set) Token: 0x06028360 RID: 164704 RVA: 0x0057FD31 File Offset: 0x0057DF31
		public ESplineType Type { get; set; }

		// Token: 0x1700B181 RID: 45441
		// (get) Token: 0x06028361 RID: 164705 RVA: 0x0057FD3A File Offset: 0x0057DF3A
		// (set) Token: 0x06028362 RID: 164706 RVA: 0x0057FD42 File Offset: 0x0057DF42
		public float Height { get; set; }

		// Token: 0x1700B182 RID: 45442
		// (get) Token: 0x06028363 RID: 164707 RVA: 0x0057FD4B File Offset: 0x0057DF4B
		// (set) Token: 0x06028364 RID: 164708 RVA: 0x0057FD53 File Offset: 0x0057DF53
		public List<ICommonSplinePointT> Points { get; set; }

		// Token: 0x06028365 RID: 164709 RVA: 0x0057FD5C File Offset: 0x0057DF5C
		public IRangeSplineT()
		{
			this.Type = ESplineType.Common;
			this.Height = 0f;
			this.Points = null;
		}
	}
}
