using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AA6 RID: 23206
	public class ITimeScheduleGenerateParamsT
	{
		// Token: 0x1700AECF RID: 44751
		// (get) Token: 0x060278AE RID: 161966 RVA: 0x00570A9F File Offset: 0x0056EC9F
		// (set) Token: 0x060278AF RID: 161967 RVA: 0x00570AA7 File Offset: 0x0056ECA7
		public ITimeScheduleGameDailyRefreshT RefreshType { get; set; }

		// Token: 0x1700AED0 RID: 44752
		// (get) Token: 0x060278B0 RID: 161968 RVA: 0x00570AB0 File Offset: 0x0056ECB0
		// (set) Token: 0x060278B1 RID: 161969 RVA: 0x00570AB8 File Offset: 0x0056ECB8
		public int MaxCount { get; set; }

		// Token: 0x1700AED1 RID: 44753
		// (get) Token: 0x060278B2 RID: 161970 RVA: 0x00570AC1 File Offset: 0x0056ECC1
		// (set) Token: 0x060278B3 RID: 161971 RVA: 0x00570AC9 File Offset: 0x0056ECC9
		public int MinCount { get; set; }

		// Token: 0x1700AED2 RID: 44754
		// (get) Token: 0x060278B4 RID: 161972 RVA: 0x00570AD2 File Offset: 0x0056ECD2
		// (set) Token: 0x060278B5 RID: 161973 RVA: 0x00570ADA File Offset: 0x0056ECDA
		public ITimeScheduleRandomSchedulePositionDistributionT DistributionType { get; set; }

		// Token: 0x060278B6 RID: 161974 RVA: 0x00570AE3 File Offset: 0x0056ECE3
		public ITimeScheduleGenerateParamsT()
		{
			this.RefreshType = null;
			this.MaxCount = 0;
			this.MinCount = 0;
			this.DistributionType = null;
		}
	}
}
