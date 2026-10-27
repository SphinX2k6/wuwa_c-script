using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200746D RID: 29805
	public class ITrapDefenseTipT
	{
		// Token: 0x1700E237 RID: 57911
		// (get) Token: 0x0603625E RID: 221790 RVA: 0x0075CA89 File Offset: 0x0075AC89
		// (set) Token: 0x0603625F RID: 221791 RVA: 0x0075CA91 File Offset: 0x0075AC91
		public ECommonTipType Type { get; set; }

		// Token: 0x1700E238 RID: 57912
		// (get) Token: 0x06036260 RID: 221792 RVA: 0x0075CA9A File Offset: 0x0075AC9A
		// (set) Token: 0x06036261 RID: 221793 RVA: 0x0075CAA2 File Offset: 0x0075ACA2
		public string MainText { get; set; }

		// Token: 0x1700E239 RID: 57913
		// (get) Token: 0x06036262 RID: 221794 RVA: 0x0075CAAB File Offset: 0x0075ACAB
		// (set) Token: 0x06036263 RID: 221795 RVA: 0x0075CAB3 File Offset: 0x0075ACB3
		public ETrapDefenseTipType TipType { get; set; }

		// Token: 0x06036264 RID: 221796 RVA: 0x0075CABC File Offset: 0x0075ACBC
		public ITrapDefenseTipT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.MainText = null;
			this.TipType = ETrapDefenseTipType.OpenNewAreaTip;
		}
	}
}
