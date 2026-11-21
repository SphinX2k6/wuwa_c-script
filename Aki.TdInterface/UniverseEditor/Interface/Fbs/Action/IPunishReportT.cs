using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007553 RID: 30035
	public class IPunishReportT
	{
		// Token: 0x1700DCEB RID: 56555
		// (get) Token: 0x06034ABB RID: 215739 RVA: 0x00715D0C File Offset: 0x00713F0C
		// (set) Token: 0x06034ABC RID: 215740 RVA: 0x00715D14 File Offset: 0x00713F14
		public ECommonTipType Type { get; set; }

		// Token: 0x1700DCEC RID: 56556
		// (get) Token: 0x06034ABD RID: 215741 RVA: 0x00715D1D File Offset: 0x00713F1D
		// (set) Token: 0x06034ABE RID: 215742 RVA: 0x00715D25 File Offset: 0x00713F25
		public string MainText { get; set; }

		// Token: 0x1700DCED RID: 56557
		// (get) Token: 0x06034ABF RID: 215743 RVA: 0x00715D2E File Offset: 0x00713F2E
		// (set) Token: 0x06034AC0 RID: 215744 RVA: 0x00715D36 File Offset: 0x00713F36
		public string SubText { get; set; }

		// Token: 0x1700DCEE RID: 56558
		// (get) Token: 0x06034AC1 RID: 215745 RVA: 0x00715D3F File Offset: 0x00713F3F
		// (set) Token: 0x06034AC2 RID: 215746 RVA: 0x00715D47 File Offset: 0x00713F47
		public EPunishReportShowType ShowType { get; set; }

		// Token: 0x1700DCEF RID: 56559
		// (get) Token: 0x06034AC3 RID: 215747 RVA: 0x00715D50 File Offset: 0x00713F50
		// (set) Token: 0x06034AC4 RID: 215748 RVA: 0x00715D58 File Offset: 0x00713F58
		public byte NullMask { get; set; }

		// Token: 0x06034AC5 RID: 215749 RVA: 0x00715D61 File Offset: 0x00713F61
		public IPunishReportT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.MainText = null;
			this.SubText = null;
			this.ShowType = EPunishReportShowType.Default;
			this.NullMask = 0;
		}
	}
}
