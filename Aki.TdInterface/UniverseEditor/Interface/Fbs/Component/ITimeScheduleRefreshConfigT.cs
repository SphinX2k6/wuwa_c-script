using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AB2 RID: 23218
	public class ITimeScheduleRefreshConfigT
	{
		// Token: 0x1700AEDD RID: 44765
		// (get) Token: 0x060278F6 RID: 162038 RVA: 0x005710B2 File Offset: 0x0056F2B2
		// (set) Token: 0x060278F7 RID: 162039 RVA: 0x005710BA File Offset: 0x0056F2BA
		public ETimeScheduleRefreshType Type { get; set; }

		// Token: 0x060278F8 RID: 162040 RVA: 0x005710C3 File Offset: 0x0056F2C3
		public ITimeScheduleRefreshConfigT()
		{
			this.Type = ETimeScheduleRefreshType.GameDaily;
		}
	}
}
