using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060A7 RID: 24743
	public class ITimeScheduleFixedIntervalRefreshT
	{
		// Token: 0x1700B7F8 RID: 47096
		// (get) Token: 0x06029DDC RID: 171484 RVA: 0x005B72A3 File Offset: 0x005B54A3
		// (set) Token: 0x06029DDD RID: 171485 RVA: 0x005B72AB File Offset: 0x005B54AB
		public ETimeScheduleGenerateType Type { get; set; }

		// Token: 0x1700B7F9 RID: 47097
		// (get) Token: 0x06029DDE RID: 171486 RVA: 0x005B72B4 File Offset: 0x005B54B4
		// (set) Token: 0x06029DDF RID: 171487 RVA: 0x005B72BC File Offset: 0x005B54BC
		public ITimeScheduleRefreshIntervalT RefreshInterval { get; set; }

		// Token: 0x1700B7FA RID: 47098
		// (get) Token: 0x06029DE0 RID: 171488 RVA: 0x005B72C5 File Offset: 0x005B54C5
		// (set) Token: 0x06029DE1 RID: 171489 RVA: 0x005B72CD File Offset: 0x005B54CD
		public int RefreshCount { get; set; }

		// Token: 0x1700B7FB RID: 47099
		// (get) Token: 0x06029DE2 RID: 171490 RVA: 0x005B72D6 File Offset: 0x005B54D6
		// (set) Token: 0x06029DE3 RID: 171491 RVA: 0x005B72DE File Offset: 0x005B54DE
		public ITimeScheduleFixedPositionsT RefreshPosition { get; set; }

		// Token: 0x06029DE4 RID: 171492 RVA: 0x005B72E7 File Offset: 0x005B54E7
		public ITimeScheduleFixedIntervalRefreshT()
		{
			this.Type = ETimeScheduleGenerateType.FixedIntervalRefresh;
			this.RefreshInterval = null;
			this.RefreshCount = 0;
			this.RefreshPosition = null;
		}
	}
}
