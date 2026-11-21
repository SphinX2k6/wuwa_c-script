using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060A4 RID: 24740
	public class ITimeScheduleEntityTemplateNpcSourceT
	{
		// Token: 0x1700B7F1 RID: 47089
		// (get) Token: 0x06029DC2 RID: 171458 RVA: 0x005B6F0F File Offset: 0x005B510F
		// (set) Token: 0x06029DC3 RID: 171459 RVA: 0x005B6F17 File Offset: 0x005B5117
		public ETimeScheduleNpcSourceType Type { get; set; }

		// Token: 0x1700B7F2 RID: 47090
		// (get) Token: 0x06029DC4 RID: 171460 RVA: 0x005B6F20 File Offset: 0x005B5120
		// (set) Token: 0x06029DC5 RID: 171461 RVA: 0x005B6F28 File Offset: 0x005B5128
		public List<string> TemplateIds { get; set; }

		// Token: 0x06029DC6 RID: 171462 RVA: 0x005B6F31 File Offset: 0x005B5131
		public ITimeScheduleEntityTemplateNpcSourceT()
		{
			this.Type = ETimeScheduleNpcSourceType.EntityTemplate;
			this.TemplateIds = null;
		}
	}
}
