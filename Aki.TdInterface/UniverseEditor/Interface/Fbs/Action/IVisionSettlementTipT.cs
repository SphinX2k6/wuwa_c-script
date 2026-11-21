using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D44 RID: 32068
	public class IVisionSettlementTipT
	{
		// Token: 0x1700F003 RID: 61443
		// (get) Token: 0x06039E54 RID: 237140 RVA: 0x007CF3BC File Offset: 0x007CD5BC
		// (set) Token: 0x06039E55 RID: 237141 RVA: 0x007CF3C4 File Offset: 0x007CD5C4
		public ECommonTipType Type { get; set; }

		// Token: 0x1700F004 RID: 61444
		// (get) Token: 0x06039E56 RID: 237142 RVA: 0x007CF3CD File Offset: 0x007CD5CD
		// (set) Token: 0x06039E57 RID: 237143 RVA: 0x007CF3D5 File Offset: 0x007CD5D5
		public string TidMainText { get; set; }

		// Token: 0x1700F005 RID: 61445
		// (get) Token: 0x06039E58 RID: 237144 RVA: 0x007CF3DE File Offset: 0x007CD5DE
		// (set) Token: 0x06039E59 RID: 237145 RVA: 0x007CF3E6 File Offset: 0x007CD5E6
		public string TidSubText { get; set; }

		// Token: 0x06039E5A RID: 237146 RVA: 0x007CF3EF File Offset: 0x007CD5EF
		public IVisionSettlementTipT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidMainText = null;
			this.TidSubText = null;
		}
	}
}
