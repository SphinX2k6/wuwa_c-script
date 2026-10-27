using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A9D RID: 23197
	public class ITimeScheduleEntityTemplateNpcSourceT
	{
		// Token: 0x1700AEBE RID: 44734
		// (get) Token: 0x06027868 RID: 161896 RVA: 0x00570177 File Offset: 0x0056E377
		// (set) Token: 0x06027869 RID: 161897 RVA: 0x0057017F File Offset: 0x0056E37F
		public ETimeScheduleNpcSourceType Type { get; set; }

		// Token: 0x1700AEBF RID: 44735
		// (get) Token: 0x0602786A RID: 161898 RVA: 0x00570188 File Offset: 0x0056E388
		// (set) Token: 0x0602786B RID: 161899 RVA: 0x00570190 File Offset: 0x0056E390
		public List<string> TemplateIds { get; set; }

		// Token: 0x0602786C RID: 161900 RVA: 0x00570199 File Offset: 0x0056E399
		public ITimeScheduleEntityTemplateNpcSourceT()
		{
			this.Type = ETimeScheduleNpcSourceType.EntityTemplate;
			this.TemplateIds = null;
		}
	}
}
