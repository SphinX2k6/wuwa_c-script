using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D86 RID: 23942
	public class IDiscardForEnergyToDeployTypeT
	{
		// Token: 0x1700B34D RID: 45901
		// (get) Token: 0x06028F68 RID: 167784 RVA: 0x005A0421 File Offset: 0x0059E621
		// (set) Token: 0x06028F69 RID: 167785 RVA: 0x005A0429 File Offset: 0x0059E629
		public EGoalActType Type { get; set; }

		// Token: 0x1700B34E RID: 45902
		// (get) Token: 0x06028F6A RID: 167786 RVA: 0x005A0432 File Offset: 0x0059E632
		// (set) Token: 0x06028F6B RID: 167787 RVA: 0x005A043A File Offset: 0x0059E63A
		public TVarRefUnion ReserveHandCard { get; set; }

		// Token: 0x1700B34F RID: 45903
		// (get) Token: 0x06028F6C RID: 167788 RVA: 0x005A0443 File Offset: 0x0059E643
		// (set) Token: 0x06028F6D RID: 167789 RVA: 0x005A044B File Offset: 0x0059E64B
		public TVarRefUnion BoardPos { get; set; }

		// Token: 0x06028F6E RID: 167790 RVA: 0x005A0454 File Offset: 0x0059E654
		public IDiscardForEnergyToDeployTypeT()
		{
			this.Type = EGoalActType.Deploy;
			this.ReserveHandCard = null;
			this.BoardPos = null;
		}
	}
}
