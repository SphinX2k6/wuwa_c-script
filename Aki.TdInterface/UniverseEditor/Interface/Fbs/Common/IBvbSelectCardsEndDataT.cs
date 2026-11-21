using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006399 RID: 25497
	public class IBvbSelectCardsEndDataT
	{
		// Token: 0x1700BC79 RID: 48249
		// (get) Token: 0x0602B4CA RID: 177354 RVA: 0x005E71B2 File Offset: 0x005E53B2
		// (set) Token: 0x0602B4CB RID: 177355 RVA: 0x005E71BA File Offset: 0x005E53BA
		public EBvbEventName Type { get; set; }

		// Token: 0x0602B4CC RID: 177356 RVA: 0x005E71C3 File Offset: 0x005E53C3
		public IBvbSelectCardsEndDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
		}
	}
}
