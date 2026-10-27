using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061DD RID: 25053
	public class IBadBuKingChallengeTipT
	{
		// Token: 0x1700BACD RID: 47821
		// (get) Token: 0x0602B2ED RID: 176877 RVA: 0x005F3B63 File Offset: 0x005F1D63
		// (set) Token: 0x0602B2EE RID: 176878 RVA: 0x005F3B6B File Offset: 0x005F1D6B
		public ECommonTipType Type { get; set; }

		// Token: 0x1700BACE RID: 47822
		// (get) Token: 0x0602B2EF RID: 176879 RVA: 0x005F3B74 File Offset: 0x005F1D74
		// (set) Token: 0x0602B2F0 RID: 176880 RVA: 0x005F3B7C File Offset: 0x005F1D7C
		public string WarningText { get; set; }

		// Token: 0x0602B2F1 RID: 176881 RVA: 0x005F3B85 File Offset: 0x005F1D85
		public IBadBuKingChallengeTipT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.WarningText = null;
		}
	}
}
