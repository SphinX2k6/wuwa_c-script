using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CF8 RID: 19704
	public class ITimePeriodT
	{
		// Token: 0x17008EF9 RID: 36601
		// (get) Token: 0x0601F466 RID: 128102 RVA: 0x0045D0D6 File Offset: 0x0045B2D6
		// (set) Token: 0x0601F467 RID: 128103 RVA: 0x0045D0DE File Offset: 0x0045B2DE
		public EVisibleCondition Type { get; set; }

		// Token: 0x17008EFA RID: 36602
		// (get) Token: 0x0601F468 RID: 128104 RVA: 0x0045D0E7 File Offset: 0x0045B2E7
		// (set) Token: 0x0601F469 RID: 128105 RVA: 0x0045D0EF File Offset: 0x0045B2EF
		public ECompare Compare { get; set; }

		// Token: 0x17008EFB RID: 36603
		// (get) Token: 0x0601F46A RID: 128106 RVA: 0x0045D0F8 File Offset: 0x0045B2F8
		// (set) Token: 0x0601F46B RID: 128107 RVA: 0x0045D100 File Offset: 0x0045B300
		public ETimePeriod TimePeriod { get; set; }

		// Token: 0x0601F46C RID: 128108 RVA: 0x0045D109 File Offset: 0x0045B309
		public ITimePeriodT()
		{
			this.Type = EVisibleCondition.Weather;
			this.Compare = ECompare.Eq;
			this.TimePeriod = ETimePeriod.DayTime;
		}
	}
}
