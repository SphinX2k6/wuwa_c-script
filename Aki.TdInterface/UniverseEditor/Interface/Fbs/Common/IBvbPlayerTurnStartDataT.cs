using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006390 RID: 25488
	public class IBvbPlayerTurnStartDataT
	{
		// Token: 0x1700BC71 RID: 48241
		// (get) Token: 0x0602B498 RID: 177304 RVA: 0x005E6D7A File Offset: 0x005E4F7A
		// (set) Token: 0x0602B499 RID: 177305 RVA: 0x005E6D82 File Offset: 0x005E4F82
		public EBvbEventName Type { get; set; }

		// Token: 0x0602B49A RID: 177306 RVA: 0x005E6D8B File Offset: 0x005E4F8B
		public IBvbPlayerTurnStartDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
		}
	}
}
