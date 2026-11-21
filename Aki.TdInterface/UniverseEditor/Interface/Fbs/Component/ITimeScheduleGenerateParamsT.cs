using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060B0 RID: 24752
	public class ITimeScheduleGenerateParamsT
	{
		// Token: 0x1700B80A RID: 47114
		// (get) Token: 0x06029E2A RID: 171562 RVA: 0x005B7C92 File Offset: 0x005B5E92
		// (set) Token: 0x06029E2B RID: 171563 RVA: 0x005B7C9A File Offset: 0x005B5E9A
		public ETimeScheduleGenerateType Type { get; set; }

		// Token: 0x06029E2C RID: 171564 RVA: 0x005B7CA3 File Offset: 0x005B5EA3
		public ITimeScheduleGenerateParamsT()
		{
			this.Type = ETimeScheduleGenerateType.FixedIntervalRefresh;
		}
	}
}
