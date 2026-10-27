using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AAF RID: 23215
	public class ITimeScheduleRandomSchedulePositionDistributionT
	{
		// Token: 0x1700AEDA RID: 44762
		// (get) Token: 0x060278E4 RID: 162020 RVA: 0x00570F3A File Offset: 0x0056F13A
		// (set) Token: 0x060278E5 RID: 162021 RVA: 0x00570F42 File Offset: 0x0056F142
		public ETimeScheduleDistributionType Type { get; set; }

		// Token: 0x060278E6 RID: 162022 RVA: 0x00570F4B File Offset: 0x0056F14B
		public ITimeScheduleRandomSchedulePositionDistributionT()
		{
			this.Type = ETimeScheduleDistributionType.RandomSchedulePosition;
		}
	}
}
