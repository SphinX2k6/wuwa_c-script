using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D8C RID: 23948
	public class IDynamicSummonGongduolaConfigT
	{
		// Token: 0x1700B35B RID: 45915
		// (get) Token: 0x06028FB0 RID: 167856 RVA: 0x005A1041 File Offset: 0x0059F241
		// (set) Token: 0x06028FB1 RID: 167857 RVA: 0x005A1049 File Offset: 0x0059F249
		public int LevelId { get; set; }

		// Token: 0x1700B35C RID: 45916
		// (get) Token: 0x06028FB2 RID: 167858 RVA: 0x005A1052 File Offset: 0x0059F252
		// (set) Token: 0x06028FB3 RID: 167859 RVA: 0x005A105A File Offset: 0x0059F25A
		public int Radius { get; set; }

		// Token: 0x1700B35D RID: 45917
		// (get) Token: 0x06028FB4 RID: 167860 RVA: 0x005A1063 File Offset: 0x0059F263
		// (set) Token: 0x06028FB5 RID: 167861 RVA: 0x005A106B File Offset: 0x0059F26B
		public List<IDynamicSummonGongduolaPointT> SummonPoints { get; set; }

		// Token: 0x06028FB6 RID: 167862 RVA: 0x005A1074 File Offset: 0x0059F274
		public IDynamicSummonGongduolaConfigT()
		{
			this.LevelId = 0;
			this.Radius = 0;
			this.SummonPoints = null;
		}
	}
}
