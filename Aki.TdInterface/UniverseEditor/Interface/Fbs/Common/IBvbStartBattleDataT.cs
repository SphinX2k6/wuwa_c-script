using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D68 RID: 23912
	public class IBvbStartBattleDataT
	{
		// Token: 0x1700B31E RID: 45854
		// (get) Token: 0x06028E84 RID: 167556 RVA: 0x0059EA32 File Offset: 0x0059CC32
		// (set) Token: 0x06028E85 RID: 167557 RVA: 0x0059EA3A File Offset: 0x0059CC3A
		public EBvbEventName Type { get; set; }

		// Token: 0x06028E86 RID: 167558 RVA: 0x0059EA43 File Offset: 0x0059CC43
		public IBvbStartBattleDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
		}
	}
}
