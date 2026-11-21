using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060B6 RID: 24758
	public class ITimeScheduleNpcSourceT
	{
		// Token: 0x1700B80F RID: 47119
		// (get) Token: 0x06029E48 RID: 171592 RVA: 0x005B7F06 File Offset: 0x005B6106
		// (set) Token: 0x06029E49 RID: 171593 RVA: 0x005B7F0E File Offset: 0x005B610E
		public ETimeScheduleNpcSourceType Type { get; set; }

		// Token: 0x06029E4A RID: 171594 RVA: 0x005B7F17 File Offset: 0x005B6117
		public ITimeScheduleNpcSourceT()
		{
			this.Type = ETimeScheduleNpcSourceType.EntityTemplate;
		}
	}
}
