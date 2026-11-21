using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006363 RID: 25443
	public class IBvbAiEvolutionDataT
	{
		// Token: 0x1700BC29 RID: 48169
		// (get) Token: 0x0602B2CF RID: 176847 RVA: 0x005E28D9 File Offset: 0x005E0AD9
		// (set) Token: 0x0602B2D0 RID: 176848 RVA: 0x005E28E1 File Offset: 0x005E0AE1
		public EBvbEventName Type { get; set; }

		// Token: 0x1700BC2A RID: 48170
		// (get) Token: 0x0602B2D1 RID: 176849 RVA: 0x005E28EA File Offset: 0x005E0AEA
		// (set) Token: 0x0602B2D2 RID: 176850 RVA: 0x005E28F2 File Offset: 0x005E0AF2
		public TVarRefUnion HandCard { get; set; }

		// Token: 0x1700BC2B RID: 48171
		// (get) Token: 0x0602B2D3 RID: 176851 RVA: 0x005E28FB File Offset: 0x005E0AFB
		// (set) Token: 0x0602B2D4 RID: 176852 RVA: 0x005E2903 File Offset: 0x005E0B03
		public TVarRefUnion BoardCard { get; set; }

		// Token: 0x0602B2D5 RID: 176853 RVA: 0x005E290C File Offset: 0x005E0B0C
		public IBvbAiEvolutionDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
			this.HandCard = null;
			this.BoardCard = null;
		}
	}
}
