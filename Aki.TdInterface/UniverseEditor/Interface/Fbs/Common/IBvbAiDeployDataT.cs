using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200635A RID: 25434
	public class IBvbAiDeployDataT
	{
		// Token: 0x1700BC14 RID: 48148
		// (get) Token: 0x0602B268 RID: 176744 RVA: 0x005E17F9 File Offset: 0x005DF9F9
		// (set) Token: 0x0602B269 RID: 176745 RVA: 0x005E1801 File Offset: 0x005DFA01
		public EBvbEventName Type { get; set; }

		// Token: 0x1700BC15 RID: 48149
		// (get) Token: 0x0602B26A RID: 176746 RVA: 0x005E180A File Offset: 0x005DFA0A
		// (set) Token: 0x0602B26B RID: 176747 RVA: 0x005E1812 File Offset: 0x005DFA12
		public TVarRefUnion HandCard { get; set; }

		// Token: 0x1700BC16 RID: 48150
		// (get) Token: 0x0602B26C RID: 176748 RVA: 0x005E181B File Offset: 0x005DFA1B
		// (set) Token: 0x0602B26D RID: 176749 RVA: 0x005E1823 File Offset: 0x005DFA23
		public TVarRefUnion BoardPos { get; set; }

		// Token: 0x0602B26E RID: 176750 RVA: 0x005E182C File Offset: 0x005DFA2C
		public IBvbAiDeployDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
			this.HandCard = null;
			this.BoardPos = null;
		}
	}
}
