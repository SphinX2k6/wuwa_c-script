using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200635D RID: 25437
	public class IBvbAiDiscardDataT
	{
		// Token: 0x1700BC1B RID: 48155
		// (get) Token: 0x0602B289 RID: 176777 RVA: 0x005E1D4D File Offset: 0x005DFF4D
		// (set) Token: 0x0602B28A RID: 176778 RVA: 0x005E1D55 File Offset: 0x005DFF55
		public EBvbEventName Type { get; set; }

		// Token: 0x1700BC1C RID: 48156
		// (get) Token: 0x0602B28B RID: 176779 RVA: 0x005E1D5E File Offset: 0x005DFF5E
		// (set) Token: 0x0602B28C RID: 176780 RVA: 0x005E1D66 File Offset: 0x005DFF66
		public TVarRefUnion ReserveHandCard { get; set; }

		// Token: 0x1700BC1D RID: 48157
		// (get) Token: 0x0602B28D RID: 176781 RVA: 0x005E1D6F File Offset: 0x005DFF6F
		// (set) Token: 0x0602B28E RID: 176782 RVA: 0x005E1D77 File Offset: 0x005DFF77
		public EDiscardStrategy Strategy { get; set; }

		// Token: 0x0602B28F RID: 176783 RVA: 0x005E1D80 File Offset: 0x005DFF80
		public IBvbAiDiscardDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
			this.ReserveHandCard = null;
			this.Strategy = EDiscardStrategy.LowestScore;
		}
	}
}
