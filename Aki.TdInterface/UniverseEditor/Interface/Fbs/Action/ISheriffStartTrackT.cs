using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070C8 RID: 28872
	public class ISheriffStartTrackT
	{
		// Token: 0x1700D67B RID: 54907
		// (get) Token: 0x0603323A RID: 209466 RVA: 0x006E5484 File Offset: 0x006E3684
		// (set) Token: 0x0603323B RID: 209467 RVA: 0x006E548C File Offset: 0x006E368C
		public ECommonTipType Type { get; set; }

		// Token: 0x1700D67C RID: 54908
		// (get) Token: 0x0603323C RID: 209468 RVA: 0x006E5495 File Offset: 0x006E3695
		// (set) Token: 0x0603323D RID: 209469 RVA: 0x006E549D File Offset: 0x006E369D
		public int AnomalyId { get; set; }

		// Token: 0x0603323E RID: 209470 RVA: 0x006E54A6 File Offset: 0x006E36A6
		public ISheriffStartTrackT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.AnomalyId = 0;
		}
	}
}
