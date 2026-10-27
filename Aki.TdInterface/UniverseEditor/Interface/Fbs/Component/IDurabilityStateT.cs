using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050C7 RID: 20679
	public class IDurabilityStateT
	{
		// Token: 0x1700967C RID: 38524
		// (get) Token: 0x06021437 RID: 136247 RVA: 0x0049EE57 File Offset: 0x0049D057
		// (set) Token: 0x06021438 RID: 136248 RVA: 0x0049EE5F File Offset: 0x0049D05F
		public int Durability { get; set; }

		// Token: 0x1700967D RID: 38525
		// (get) Token: 0x06021439 RID: 136249 RVA: 0x0049EE68 File Offset: 0x0049D068
		// (set) Token: 0x0602143A RID: 136250 RVA: 0x0049EE70 File Offset: 0x0049D070
		public string State { get; set; }

		// Token: 0x0602143B RID: 136251 RVA: 0x0049EE79 File Offset: 0x0049D079
		public IDurabilityStateT()
		{
			this.Durability = 0;
			this.State = null;
		}
	}
}
