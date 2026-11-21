using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063C6 RID: 25542
	public class IDiscardForEnergyToEvolutionTypeT
	{
		// Token: 0x1700BCBA RID: 48314
		// (get) Token: 0x0602B61A RID: 177690 RVA: 0x005E98FD File Offset: 0x005E7AFD
		// (set) Token: 0x0602B61B RID: 177691 RVA: 0x005E9905 File Offset: 0x005E7B05
		public EGoalActType Type { get; set; }

		// Token: 0x1700BCBB RID: 48315
		// (get) Token: 0x0602B61C RID: 177692 RVA: 0x005E990E File Offset: 0x005E7B0E
		// (set) Token: 0x0602B61D RID: 177693 RVA: 0x005E9916 File Offset: 0x005E7B16
		public TVarRefUnion ReserveBoardCard { get; set; }

		// Token: 0x1700BCBC RID: 48316
		// (get) Token: 0x0602B61E RID: 177694 RVA: 0x005E991F File Offset: 0x005E7B1F
		// (set) Token: 0x0602B61F RID: 177695 RVA: 0x005E9927 File Offset: 0x005E7B27
		public TVarRefUnion ReserveHandCard { get; set; }

		// Token: 0x0602B620 RID: 177696 RVA: 0x005E9930 File Offset: 0x005E7B30
		public IDiscardForEnergyToEvolutionTypeT()
		{
			this.Type = EGoalActType.Deploy;
			this.ReserveBoardCard = null;
			this.ReserveHandCard = null;
		}
	}
}
