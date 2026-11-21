using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005530 RID: 21808
	public class ICommonSplineT
	{
		// Token: 0x17009BE3 RID: 39907
		// (get) Token: 0x060227C9 RID: 141257 RVA: 0x004C01EF File Offset: 0x004BE3EF
		// (set) Token: 0x060227CA RID: 141258 RVA: 0x004C01F7 File Offset: 0x004BE3F7
		public ESplineType Type { get; set; }

		// Token: 0x17009BE4 RID: 39908
		// (get) Token: 0x060227CB RID: 141259 RVA: 0x004C0200 File Offset: 0x004BE400
		// (set) Token: 0x060227CC RID: 141260 RVA: 0x004C0208 File Offset: 0x004BE408
		public List<ICommonSplinePointT> Points { get; set; }

		// Token: 0x060227CD RID: 141261 RVA: 0x004C0211 File Offset: 0x004BE411
		public ICommonSplineT()
		{
			this.Type = ESplineType.Common;
			this.Points = null;
		}
	}
}
