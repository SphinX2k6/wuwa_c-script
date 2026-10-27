using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D62 RID: 23906
	public class IBvbSelectCardsEndDataT
	{
		// Token: 0x1700B318 RID: 45848
		// (get) Token: 0x06028E60 RID: 167520 RVA: 0x0059E742 File Offset: 0x0059C942
		// (set) Token: 0x06028E61 RID: 167521 RVA: 0x0059E74A File Offset: 0x0059C94A
		public EBvbEventName Type { get; set; }

		// Token: 0x06028E62 RID: 167522 RVA: 0x0059E753 File Offset: 0x0059C953
		public IBvbSelectCardsEndDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
		}
	}
}
