using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FC4 RID: 24516
	public class IStateRepPerfItemT
	{
		// Token: 0x1700B58C RID: 46476
		// (get) Token: 0x0602940B RID: 168971 RVA: 0x005A171B File Offset: 0x0059F91B
		// (set) Token: 0x0602940C RID: 168972 RVA: 0x005A1723 File Offset: 0x0059F923
		public string StateTag { get; set; }

		// Token: 0x1700B58D RID: 46477
		// (get) Token: 0x0602940D RID: 168973 RVA: 0x005A172C File Offset: 0x0059F92C
		// (set) Token: 0x0602940E RID: 168974 RVA: 0x005A1734 File Offset: 0x0059F934
		public TStateRepPerfUnion ReplacePerformance { get; set; }

		// Token: 0x0602940F RID: 168975 RVA: 0x005A173D File Offset: 0x0059F93D
		public IStateRepPerfItemT()
		{
			this.StateTag = null;
			this.ReplacePerformance = null;
		}
	}
}
