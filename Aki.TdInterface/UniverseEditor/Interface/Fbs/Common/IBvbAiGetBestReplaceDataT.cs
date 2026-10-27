using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D35 RID: 23861
	public class IBvbAiGetBestReplaceDataT
	{
		// Token: 0x1700B2DD RID: 45789
		// (get) Token: 0x06028CDD RID: 167133 RVA: 0x0059B56D File Offset: 0x0059976D
		// (set) Token: 0x06028CDE RID: 167134 RVA: 0x0059B575 File Offset: 0x00599775
		public EBvbEventName Type { get; set; }

		// Token: 0x1700B2DE RID: 45790
		// (get) Token: 0x06028CDF RID: 167135 RVA: 0x0059B57E File Offset: 0x0059977E
		// (set) Token: 0x06028CE0 RID: 167136 RVA: 0x0059B586 File Offset: 0x00599786
		public TVarRefUnion HandCard { get; set; }

		// Token: 0x1700B2DF RID: 45791
		// (get) Token: 0x06028CE1 RID: 167137 RVA: 0x0059B58F File Offset: 0x0059978F
		// (set) Token: 0x06028CE2 RID: 167138 RVA: 0x0059B597 File Offset: 0x00599797
		public TVarRefUnion BoardCardStored { get; set; }

		// Token: 0x06028CE3 RID: 167139 RVA: 0x0059B5A0 File Offset: 0x005997A0
		public IBvbAiGetBestReplaceDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
			this.HandCard = null;
			this.BoardCardStored = null;
		}
	}
}
