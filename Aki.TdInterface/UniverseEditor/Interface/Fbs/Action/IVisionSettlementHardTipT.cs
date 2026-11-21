using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D41 RID: 32065
	public class IVisionSettlementHardTipT
	{
		// Token: 0x1700EFFC RID: 61436
		// (get) Token: 0x06039E36 RID: 237110 RVA: 0x007CF0CC File Offset: 0x007CD2CC
		// (set) Token: 0x06039E37 RID: 237111 RVA: 0x007CF0D4 File Offset: 0x007CD2D4
		public ECommonTipType Type { get; set; }

		// Token: 0x1700EFFD RID: 61437
		// (get) Token: 0x06039E38 RID: 237112 RVA: 0x007CF0DD File Offset: 0x007CD2DD
		// (set) Token: 0x06039E39 RID: 237113 RVA: 0x007CF0E5 File Offset: 0x007CD2E5
		public string TidMainText { get; set; }

		// Token: 0x1700EFFE RID: 61438
		// (get) Token: 0x06039E3A RID: 237114 RVA: 0x007CF0EE File Offset: 0x007CD2EE
		// (set) Token: 0x06039E3B RID: 237115 RVA: 0x007CF0F6 File Offset: 0x007CD2F6
		public string TidSubText { get; set; }

		// Token: 0x06039E3C RID: 237116 RVA: 0x007CF0FF File Offset: 0x007CD2FF
		public IVisionSettlementHardTipT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidMainText = null;
			this.TidSubText = null;
		}
	}
}
