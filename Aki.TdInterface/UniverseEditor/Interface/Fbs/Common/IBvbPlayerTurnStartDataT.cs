using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D59 RID: 23897
	public class IBvbPlayerTurnStartDataT
	{
		// Token: 0x1700B310 RID: 45840
		// (get) Token: 0x06028E2E RID: 167470 RVA: 0x0059E30A File Offset: 0x0059C50A
		// (set) Token: 0x06028E2F RID: 167471 RVA: 0x0059E312 File Offset: 0x0059C512
		public EBvbEventName Type { get; set; }

		// Token: 0x06028E30 RID: 167472 RVA: 0x0059E31B File Offset: 0x0059C51B
		public IBvbPlayerTurnStartDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
		}
	}
}
