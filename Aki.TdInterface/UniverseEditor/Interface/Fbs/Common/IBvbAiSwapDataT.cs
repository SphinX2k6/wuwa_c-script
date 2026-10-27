using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D41 RID: 23873
	public class IBvbAiSwapDataT
	{
		// Token: 0x1700B2F7 RID: 45815
		// (get) Token: 0x06028D72 RID: 167282 RVA: 0x0059D0FD File Offset: 0x0059B2FD
		// (set) Token: 0x06028D73 RID: 167283 RVA: 0x0059D105 File Offset: 0x0059B305
		public EBvbEventName Type { get; set; }

		// Token: 0x1700B2F8 RID: 45816
		// (get) Token: 0x06028D74 RID: 167284 RVA: 0x0059D10E File Offset: 0x0059B30E
		// (set) Token: 0x06028D75 RID: 167285 RVA: 0x0059D116 File Offset: 0x0059B316
		public TVarRefUnion BoardCard1 { get; set; }

		// Token: 0x1700B2F9 RID: 45817
		// (get) Token: 0x06028D76 RID: 167286 RVA: 0x0059D11F File Offset: 0x0059B31F
		// (set) Token: 0x06028D77 RID: 167287 RVA: 0x0059D127 File Offset: 0x0059B327
		public TVarRefUnion BoardCard2 { get; set; }

		// Token: 0x06028D78 RID: 167288 RVA: 0x0059D130 File Offset: 0x0059B330
		public IBvbAiSwapDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
			this.BoardCard1 = null;
			this.BoardCard2 = null;
		}
	}
}
