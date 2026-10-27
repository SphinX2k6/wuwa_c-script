using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D23 RID: 23843
	public class IBvbAiDeployDataT
	{
		// Token: 0x1700B2B3 RID: 45747
		// (get) Token: 0x06028BFE RID: 166910 RVA: 0x00598D89 File Offset: 0x00596F89
		// (set) Token: 0x06028BFF RID: 166911 RVA: 0x00598D91 File Offset: 0x00596F91
		public EBvbEventName Type { get; set; }

		// Token: 0x1700B2B4 RID: 45748
		// (get) Token: 0x06028C00 RID: 166912 RVA: 0x00598D9A File Offset: 0x00596F9A
		// (set) Token: 0x06028C01 RID: 166913 RVA: 0x00598DA2 File Offset: 0x00596FA2
		public TVarRefUnion HandCard { get; set; }

		// Token: 0x1700B2B5 RID: 45749
		// (get) Token: 0x06028C02 RID: 166914 RVA: 0x00598DAB File Offset: 0x00596FAB
		// (set) Token: 0x06028C03 RID: 166915 RVA: 0x00598DB3 File Offset: 0x00596FB3
		public TVarRefUnion BoardPos { get; set; }

		// Token: 0x06028C04 RID: 166916 RVA: 0x00598DBC File Offset: 0x00596FBC
		public IBvbAiDeployDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
			this.HandCard = null;
			this.BoardPos = null;
		}
	}
}
