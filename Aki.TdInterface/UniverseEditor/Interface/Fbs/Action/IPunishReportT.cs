using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DD8 RID: 28120
	public class IPunishReportT
	{
		// Token: 0x1700D1A3 RID: 53667
		// (get) Token: 0x06031ABF RID: 203455 RVA: 0x006BA624 File Offset: 0x006B8824
		// (set) Token: 0x06031AC0 RID: 203456 RVA: 0x006BA62C File Offset: 0x006B882C
		public ECommonTipType Type { get; set; }

		// Token: 0x1700D1A4 RID: 53668
		// (get) Token: 0x06031AC1 RID: 203457 RVA: 0x006BA635 File Offset: 0x006B8835
		// (set) Token: 0x06031AC2 RID: 203458 RVA: 0x006BA63D File Offset: 0x006B883D
		public string MainText { get; set; }

		// Token: 0x1700D1A5 RID: 53669
		// (get) Token: 0x06031AC3 RID: 203459 RVA: 0x006BA646 File Offset: 0x006B8846
		// (set) Token: 0x06031AC4 RID: 203460 RVA: 0x006BA64E File Offset: 0x006B884E
		public string SubText { get; set; }

		// Token: 0x1700D1A6 RID: 53670
		// (get) Token: 0x06031AC5 RID: 203461 RVA: 0x006BA657 File Offset: 0x006B8857
		// (set) Token: 0x06031AC6 RID: 203462 RVA: 0x006BA65F File Offset: 0x006B885F
		public EPunishReportShowType ShowType { get; set; }

		// Token: 0x1700D1A7 RID: 53671
		// (get) Token: 0x06031AC7 RID: 203463 RVA: 0x006BA668 File Offset: 0x006B8868
		// (set) Token: 0x06031AC8 RID: 203464 RVA: 0x006BA670 File Offset: 0x006B8870
		public byte NullMask { get; set; }

		// Token: 0x06031AC9 RID: 203465 RVA: 0x006BA679 File Offset: 0x006B8879
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
