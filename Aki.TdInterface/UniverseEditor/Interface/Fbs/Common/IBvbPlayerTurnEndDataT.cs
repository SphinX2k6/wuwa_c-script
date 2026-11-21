using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200638D RID: 25485
	public class IBvbPlayerTurnEndDataT
	{
		// Token: 0x1700BC6E RID: 48238
		// (get) Token: 0x0602B486 RID: 177286 RVA: 0x005E6C02 File Offset: 0x005E4E02
		// (set) Token: 0x0602B487 RID: 177287 RVA: 0x005E6C0A File Offset: 0x005E4E0A
		public EBvbEventName Type { get; set; }

		// Token: 0x0602B488 RID: 177288 RVA: 0x005E6C13 File Offset: 0x005E4E13
		public IBvbPlayerTurnEndDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
		}
	}
}
