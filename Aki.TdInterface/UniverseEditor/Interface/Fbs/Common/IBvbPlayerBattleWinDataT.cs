using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200638A RID: 25482
	public class IBvbPlayerBattleWinDataT
	{
		// Token: 0x1700BC6B RID: 48235
		// (get) Token: 0x0602B474 RID: 177268 RVA: 0x005E6A8A File Offset: 0x005E4C8A
		// (set) Token: 0x0602B475 RID: 177269 RVA: 0x005E6A92 File Offset: 0x005E4C92
		public EBvbEventName Type { get; set; }

		// Token: 0x0602B476 RID: 177270 RVA: 0x005E6A9B File Offset: 0x005E4C9B
		public IBvbPlayerBattleWinDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
		}
	}
}
