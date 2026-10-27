using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D3B RID: 23867
	public class IBvbAiRearrangeDataT
	{
		// Token: 0x1700B2EB RID: 45803
		// (get) Token: 0x06028D2D RID: 167213 RVA: 0x0059C4C5 File Offset: 0x0059A6C5
		// (set) Token: 0x06028D2E RID: 167214 RVA: 0x0059C4CD File Offset: 0x0059A6CD
		public EBvbEventName Type { get; set; }

		// Token: 0x1700B2EC RID: 45804
		// (get) Token: 0x06028D2F RID: 167215 RVA: 0x0059C4D6 File Offset: 0x0059A6D6
		// (set) Token: 0x06028D30 RID: 167216 RVA: 0x0059C4DE File Offset: 0x0059A6DE
		public TVarRefUnion BoardCard { get; set; }

		// Token: 0x1700B2ED RID: 45805
		// (get) Token: 0x06028D31 RID: 167217 RVA: 0x0059C4E7 File Offset: 0x0059A6E7
		// (set) Token: 0x06028D32 RID: 167218 RVA: 0x0059C4EF File Offset: 0x0059A6EF
		public TVarRefUnion BoardPos { get; set; }

		// Token: 0x06028D33 RID: 167219 RVA: 0x0059C4F8 File Offset: 0x0059A6F8
		public IBvbAiRearrangeDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
			this.BoardCard = null;
			this.BoardPos = null;
		}
	}
}
