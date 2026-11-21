using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007894 RID: 30868
	public class ISheriffStartTrackT
	{
		// Token: 0x1700E25E RID: 57950
		// (get) Token: 0x060364DC RID: 222428 RVA: 0x00745A90 File Offset: 0x00743C90
		// (set) Token: 0x060364DD RID: 222429 RVA: 0x00745A98 File Offset: 0x00743C98
		public ECommonTipType Type { get; set; }

		// Token: 0x1700E25F RID: 57951
		// (get) Token: 0x060364DE RID: 222430 RVA: 0x00745AA1 File Offset: 0x00743CA1
		// (set) Token: 0x060364DF RID: 222431 RVA: 0x00745AA9 File Offset: 0x00743CA9
		public int AnomalyId { get; set; }

		// Token: 0x060364E0 RID: 222432 RVA: 0x00745AB2 File Offset: 0x00743CB2
		public ISheriffStartTrackT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.AnomalyId = 0;
		}
	}
}
