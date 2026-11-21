using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060BF RID: 24767
	public class ITimeScheduleRefreshPositionT
	{
		// Token: 0x1700B819 RID: 47129
		// (get) Token: 0x06029E7C RID: 171644 RVA: 0x005B839A File Offset: 0x005B659A
		// (set) Token: 0x06029E7D RID: 171645 RVA: 0x005B83A2 File Offset: 0x005B65A2
		public ETimeScheduleRefreshPositionType Type { get; set; }

		// Token: 0x06029E7E RID: 171646 RVA: 0x005B83AB File Offset: 0x005B65AB
		public ITimeScheduleRefreshPositionT()
		{
			this.Type = ETimeScheduleRefreshPositionType.FixedPositions;
		}
	}
}
