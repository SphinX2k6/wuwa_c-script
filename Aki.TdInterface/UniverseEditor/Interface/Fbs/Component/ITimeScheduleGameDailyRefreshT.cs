using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AA0 RID: 23200
	public class ITimeScheduleGameDailyRefreshT
	{
		// Token: 0x1700AEC2 RID: 44738
		// (get) Token: 0x0602787C RID: 161916 RVA: 0x00570312 File Offset: 0x0056E512
		// (set) Token: 0x0602787D RID: 161917 RVA: 0x0057031A File Offset: 0x0056E51A
		public ETimeScheduleRefreshType Type { get; set; }

		// Token: 0x0602787E RID: 161918 RVA: 0x00570323 File Offset: 0x0056E523
		public ITimeScheduleGameDailyRefreshT()
		{
			this.Type = ETimeScheduleRefreshType.GameDaily;
		}
	}
}
