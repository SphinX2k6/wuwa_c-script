using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200684B RID: 26699
	public class IBadBuKingChallengeTipT
	{
		// Token: 0x1700C450 RID: 50256
		// (get) Token: 0x0602DA34 RID: 186932 RVA: 0x0063E5D7 File Offset: 0x0063C7D7
		// (set) Token: 0x0602DA35 RID: 186933 RVA: 0x0063E5DF File Offset: 0x0063C7DF
		public ECommonTipType Type { get; set; }

		// Token: 0x1700C451 RID: 50257
		// (get) Token: 0x0602DA36 RID: 186934 RVA: 0x0063E5E8 File Offset: 0x0063C7E8
		// (set) Token: 0x0602DA37 RID: 186935 RVA: 0x0063E5F0 File Offset: 0x0063C7F0
		public string WarningText { get; set; }

		// Token: 0x0602DA38 RID: 186936 RVA: 0x0063E5F9 File Offset: 0x0063C7F9
		public IBadBuKingChallengeTipT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.WarningText = null;
		}
	}
}
