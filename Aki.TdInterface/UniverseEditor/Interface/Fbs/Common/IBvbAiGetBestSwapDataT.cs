using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D38 RID: 23864
	public class IBvbAiGetBestSwapDataT
	{
		// Token: 0x1700B2E4 RID: 45796
		// (get) Token: 0x06028D05 RID: 167173 RVA: 0x0059BD19 File Offset: 0x00599F19
		// (set) Token: 0x06028D06 RID: 167174 RVA: 0x0059BD21 File Offset: 0x00599F21
		public EBvbEventName Type { get; set; }

		// Token: 0x1700B2E5 RID: 45797
		// (get) Token: 0x06028D07 RID: 167175 RVA: 0x0059BD2A File Offset: 0x00599F2A
		// (set) Token: 0x06028D08 RID: 167176 RVA: 0x0059BD32 File Offset: 0x00599F32
		public TVarRefUnion BoardCard1Stored { get; set; }

		// Token: 0x1700B2E6 RID: 45798
		// (get) Token: 0x06028D09 RID: 167177 RVA: 0x0059BD3B File Offset: 0x00599F3B
		// (set) Token: 0x06028D0A RID: 167178 RVA: 0x0059BD43 File Offset: 0x00599F43
		public TVarRefUnion BoardCard2Stored { get; set; }

		// Token: 0x06028D0B RID: 167179 RVA: 0x0059BD4C File Offset: 0x00599F4C
		public IBvbAiGetBestSwapDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
			this.BoardCard1Stored = null;
			this.BoardCard2Stored = null;
		}
	}
}
