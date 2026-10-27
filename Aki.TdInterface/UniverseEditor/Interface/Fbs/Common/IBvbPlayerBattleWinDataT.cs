using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D53 RID: 23891
	public class IBvbPlayerBattleWinDataT
	{
		// Token: 0x1700B30A RID: 45834
		// (get) Token: 0x06028E0A RID: 167434 RVA: 0x0059E01A File Offset: 0x0059C21A
		// (set) Token: 0x06028E0B RID: 167435 RVA: 0x0059E022 File Offset: 0x0059C222
		public EBvbEventName Type { get; set; }

		// Token: 0x06028E0C RID: 167436 RVA: 0x0059E02B File Offset: 0x0059C22B
		public IBvbPlayerBattleWinDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
		}
	}
}
