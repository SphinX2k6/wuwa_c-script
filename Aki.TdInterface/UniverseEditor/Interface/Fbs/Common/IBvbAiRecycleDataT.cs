using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D3E RID: 23870
	public class IBvbAiRecycleDataT
	{
		// Token: 0x1700B2F1 RID: 45809
		// (get) Token: 0x06028D4C RID: 167244 RVA: 0x0059C9A7 File Offset: 0x0059ABA7
		// (set) Token: 0x06028D4D RID: 167245 RVA: 0x0059C9AF File Offset: 0x0059ABAF
		public EBvbEventName Type { get; set; }

		// Token: 0x1700B2F2 RID: 45810
		// (get) Token: 0x06028D4E RID: 167246 RVA: 0x0059C9B8 File Offset: 0x0059ABB8
		// (set) Token: 0x06028D4F RID: 167247 RVA: 0x0059C9C0 File Offset: 0x0059ABC0
		public TVarRefUnion BoardCard { get; set; }

		// Token: 0x06028D50 RID: 167248 RVA: 0x0059C9C9 File Offset: 0x0059ABC9
		public IBvbAiRecycleDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
			this.BoardCard = null;
		}
	}
}
