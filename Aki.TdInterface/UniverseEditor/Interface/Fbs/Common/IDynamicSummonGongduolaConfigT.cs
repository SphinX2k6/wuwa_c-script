using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063C9 RID: 25545
	public class IDynamicSummonGongduolaConfigT
	{
		// Token: 0x1700BCC1 RID: 48321
		// (get) Token: 0x0602B63A RID: 177722 RVA: 0x005E9D71 File Offset: 0x005E7F71
		// (set) Token: 0x0602B63B RID: 177723 RVA: 0x005E9D79 File Offset: 0x005E7F79
		public int LevelId { get; set; }

		// Token: 0x1700BCC2 RID: 48322
		// (get) Token: 0x0602B63C RID: 177724 RVA: 0x005E9D82 File Offset: 0x005E7F82
		// (set) Token: 0x0602B63D RID: 177725 RVA: 0x005E9D8A File Offset: 0x005E7F8A
		public int Radius { get; set; }

		// Token: 0x1700BCC3 RID: 48323
		// (get) Token: 0x0602B63E RID: 177726 RVA: 0x005E9D93 File Offset: 0x005E7F93
		// (set) Token: 0x0602B63F RID: 177727 RVA: 0x005E9D9B File Offset: 0x005E7F9B
		public List<IDynamicSummonGongduolaPointT> SummonPoints { get; set; }

		// Token: 0x0602B640 RID: 177728 RVA: 0x005E9DA4 File Offset: 0x005E7FA4
		public IDynamicSummonGongduolaConfigT()
		{
			this.LevelId = 0;
			this.Radius = 0;
			this.SummonPoints = null;
		}
	}
}
