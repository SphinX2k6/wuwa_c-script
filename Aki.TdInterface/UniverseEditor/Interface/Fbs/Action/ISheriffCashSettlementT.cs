using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070B9 RID: 28857
	public class ISheriffCashSettlementT
	{
		// Token: 0x1700D660 RID: 54880
		// (get) Token: 0x060331C8 RID: 209352 RVA: 0x006E4A08 File Offset: 0x006E2C08
		// (set) Token: 0x060331C9 RID: 209353 RVA: 0x006E4A10 File Offset: 0x006E2C10
		public ECommonTipType Type { get; set; }

		// Token: 0x1700D661 RID: 54881
		// (get) Token: 0x060331CA RID: 209354 RVA: 0x006E4A19 File Offset: 0x006E2C19
		// (set) Token: 0x060331CB RID: 209355 RVA: 0x006E4A21 File Offset: 0x006E2C21
		public string TidMainText { get; set; }

		// Token: 0x1700D662 RID: 54882
		// (get) Token: 0x060331CC RID: 209356 RVA: 0x006E4A2A File Offset: 0x006E2C2A
		// (set) Token: 0x060331CD RID: 209357 RVA: 0x006E4A32 File Offset: 0x006E2C32
		public string TidSubText { get; set; }

		// Token: 0x1700D663 RID: 54883
		// (get) Token: 0x060331CE RID: 209358 RVA: 0x006E4A3B File Offset: 0x006E2C3B
		// (set) Token: 0x060331CF RID: 209359 RVA: 0x006E4A43 File Offset: 0x006E2C43
		public TVarRefUnion VarRef { get; set; }

		// Token: 0x060331D0 RID: 209360 RVA: 0x006E4A4C File Offset: 0x006E2C4C
		public ISheriffCashSettlementT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidMainText = null;
			this.TidSubText = null;
			this.VarRef = null;
		}
	}
}
