using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200637B RID: 25467
	public class IBvbAiTurnEndDataT
	{
		// Token: 0x1700BC5D RID: 48221
		// (get) Token: 0x0602B3F2 RID: 177138 RVA: 0x005E5D92 File Offset: 0x005E3F92
		// (set) Token: 0x0602B3F3 RID: 177139 RVA: 0x005E5D9A File Offset: 0x005E3F9A
		public EBvbEventName Type { get; set; }

		// Token: 0x0602B3F4 RID: 177140 RVA: 0x005E5DA3 File Offset: 0x005E3FA3
		public IBvbAiTurnEndDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
		}
	}
}
