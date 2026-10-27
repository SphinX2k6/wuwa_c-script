using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D92 RID: 23954
	public class IDynamicSummonGongduolaPointT
	{
		// Token: 0x1700B367 RID: 45927
		// (get) Token: 0x06028FE8 RID: 167912 RVA: 0x005A17DE File Offset: 0x0059F9DE
		// (set) Token: 0x06028FE9 RID: 167913 RVA: 0x005A17E6 File Offset: 0x0059F9E6
		public int EntityId { get; set; }

		// Token: 0x1700B368 RID: 45928
		// (get) Token: 0x06028FEA RID: 167914 RVA: 0x005A17EF File Offset: 0x0059F9EF
		// (set) Token: 0x06028FEB RID: 167915 RVA: 0x005A17F7 File Offset: 0x0059F9F7
		public string Id { get; set; }

		// Token: 0x1700B369 RID: 45929
		// (get) Token: 0x06028FEC RID: 167916 RVA: 0x005A1800 File Offset: 0x0059FA00
		// (set) Token: 0x06028FED RID: 167917 RVA: 0x005A1808 File Offset: 0x0059FA08
		public IVectorInfoT Position { get; set; }

		// Token: 0x1700B36A RID: 45930
		// (get) Token: 0x06028FEE RID: 167918 RVA: 0x005A1811 File Offset: 0x0059FA11
		// (set) Token: 0x06028FEF RID: 167919 RVA: 0x005A1819 File Offset: 0x0059FA19
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x1700B36B RID: 45931
		// (get) Token: 0x06028FF0 RID: 167920 RVA: 0x005A1822 File Offset: 0x0059FA22
		// (set) Token: 0x06028FF1 RID: 167921 RVA: 0x005A182A File Offset: 0x0059FA2A
		public EWorldAxisType Gravity { get; set; }

		// Token: 0x06028FF2 RID: 167922 RVA: 0x005A1833 File Offset: 0x0059FA33
		public IDynamicSummonGongduolaPointT()
		{
			this.EntityId = 0;
			this.Id = null;
			this.Position = null;
			this.Rotation = null;
			this.Gravity = EWorldAxisType.PositiveX;
		}
	}
}
