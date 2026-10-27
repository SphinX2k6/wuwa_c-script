using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AA9 RID: 23209
	public class ITimeScheduleNpcSourceT
	{
		// Token: 0x1700AED5 RID: 44757
		// (get) Token: 0x060278C6 RID: 161990 RVA: 0x00570CC6 File Offset: 0x0056EEC6
		// (set) Token: 0x060278C7 RID: 161991 RVA: 0x00570CCE File Offset: 0x0056EECE
		public ETimeScheduleNpcSourceType Type { get; set; }

		// Token: 0x060278C8 RID: 161992 RVA: 0x00570CD7 File Offset: 0x0056EED7
		public ITimeScheduleNpcSourceT()
		{
			this.Type = ETimeScheduleNpcSourceType.EntityTemplate;
		}
	}
}
