using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A77 RID: 23159
	public class ITimedStrikeDeviceT
	{
		// Token: 0x1700AE5E RID: 44638
		// (get) Token: 0x060276DD RID: 161501 RVA: 0x0056CF4C File Offset: 0x0056B14C
		// (set) Token: 0x060276DE RID: 161502 RVA: 0x0056CF54 File Offset: 0x0056B154
		public EProgressBarControlType Type { get; set; }

		// Token: 0x1700AE5F RID: 44639
		// (get) Token: 0x060276DF RID: 161503 RVA: 0x0056CF5D File Offset: 0x0056B15D
		// (set) Token: 0x060276E0 RID: 161504 RVA: 0x0056CF65 File Offset: 0x0056B165
		public int MaxValue { get; set; }

		// Token: 0x1700AE60 RID: 44640
		// (get) Token: 0x060276E1 RID: 161505 RVA: 0x0056CF6E File Offset: 0x0056B16E
		// (set) Token: 0x060276E2 RID: 161506 RVA: 0x0056CF76 File Offset: 0x0056B176
		public int InitValue { get; set; }

		// Token: 0x1700AE61 RID: 44641
		// (get) Token: 0x060276E3 RID: 161507 RVA: 0x0056CF7F File Offset: 0x0056B17F
		// (set) Token: 0x060276E4 RID: 161508 RVA: 0x0056CF87 File Offset: 0x0056B187
		public int ProgressPerformanceAttribute { get; set; }

		// Token: 0x1700AE62 RID: 44642
		// (get) Token: 0x060276E5 RID: 161509 RVA: 0x0056CF90 File Offset: 0x0056B190
		// (set) Token: 0x060276E6 RID: 161510 RVA: 0x0056CF98 File Offset: 0x0056B198
		public int AddValue { get; set; }

		// Token: 0x1700AE63 RID: 44643
		// (get) Token: 0x060276E7 RID: 161511 RVA: 0x0056CFA1 File Offset: 0x0056B1A1
		// (set) Token: 0x060276E8 RID: 161512 RVA: 0x0056CFA9 File Offset: 0x0056B1A9
		public int Timeout { get; set; }

		// Token: 0x1700AE64 RID: 44644
		// (get) Token: 0x060276E9 RID: 161513 RVA: 0x0056CFB2 File Offset: 0x0056B1B2
		// (set) Token: 0x060276EA RID: 161514 RVA: 0x0056CFBA File Offset: 0x0056B1BA
		public int FallbackValue { get; set; }

		// Token: 0x1700AE65 RID: 44645
		// (get) Token: 0x060276EB RID: 161515 RVA: 0x0056CFC3 File Offset: 0x0056B1C3
		// (set) Token: 0x060276EC RID: 161516 RVA: 0x0056CFCB File Offset: 0x0056B1CB
		public int FallbackInterval { get; set; }

		// Token: 0x1700AE66 RID: 44646
		// (get) Token: 0x060276ED RID: 161517 RVA: 0x0056CFD4 File Offset: 0x0056B1D4
		// (set) Token: 0x060276EE RID: 161518 RVA: 0x0056CFDC File Offset: 0x0056B1DC
		public int ZeroValuePerformanceAttribute { get; set; }

		// Token: 0x1700AE67 RID: 44647
		// (get) Token: 0x060276EF RID: 161519 RVA: 0x0056CFE5 File Offset: 0x0056B1E5
		// (set) Token: 0x060276F0 RID: 161520 RVA: 0x0056CFED File Offset: 0x0056B1ED
		public int AscendPerformanceAttribute { get; set; }

		// Token: 0x1700AE68 RID: 44648
		// (get) Token: 0x060276F1 RID: 161521 RVA: 0x0056CFF6 File Offset: 0x0056B1F6
		// (set) Token: 0x060276F2 RID: 161522 RVA: 0x0056CFFE File Offset: 0x0056B1FE
		public int DescendPerformanceAttribute { get; set; }

		// Token: 0x1700AE69 RID: 44649
		// (get) Token: 0x060276F3 RID: 161523 RVA: 0x0056D007 File Offset: 0x0056B207
		// (set) Token: 0x060276F4 RID: 161524 RVA: 0x0056D00F File Offset: 0x0056B20F
		public byte NullMask { get; set; }

		// Token: 0x060276F5 RID: 161525 RVA: 0x0056D018 File Offset: 0x0056B218
		public ITimedStrikeDeviceT()
		{
			this.Type = EProgressBarControlType.CaptureStrategicPoint;
			this.MaxValue = 0;
			this.InitValue = 0;
			this.ProgressPerformanceAttribute = 0;
			this.AddValue = 0;
			this.Timeout = 0;
			this.FallbackValue = 0;
			this.FallbackInterval = 0;
			this.ZeroValuePerformanceAttribute = 0;
			this.AscendPerformanceAttribute = 0;
			this.DescendPerformanceAttribute = 0;
			this.NullMask = 0;
		}
	}
}
