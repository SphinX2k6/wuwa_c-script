using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F47 RID: 20295
	public class IButterflySplineT
	{
		// Token: 0x17009249 RID: 37449
		// (get) Token: 0x06020239 RID: 131641 RVA: 0x00478B3B File Offset: 0x00476D3B
		// (set) Token: 0x0602023A RID: 131642 RVA: 0x00478B43 File Offset: 0x00476D43
		public ESplineType Type { get; set; }

		// Token: 0x1700924A RID: 37450
		// (get) Token: 0x0602023B RID: 131643 RVA: 0x00478B4C File Offset: 0x00476D4C
		// (set) Token: 0x0602023C RID: 131644 RVA: 0x00478B54 File Offset: 0x00476D54
		public List<IButterflySplinePointT> Points { get; set; }

		// Token: 0x0602023D RID: 131645 RVA: 0x00478B5D File Offset: 0x00476D5D
		public IButterflySplineT()
		{
			this.Type = ESplineType.Common;
			this.Points = null;
		}
	}
}
