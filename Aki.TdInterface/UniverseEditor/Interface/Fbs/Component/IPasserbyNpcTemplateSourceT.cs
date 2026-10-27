using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056E7 RID: 22247
	public class IPasserbyNpcTemplateSourceT
	{
		// Token: 0x1700A59F RID: 42399
		// (get) Token: 0x060252DC RID: 152284 RVA: 0x00521B73 File Offset: 0x0051FD73
		// (set) Token: 0x060252DD RID: 152285 RVA: 0x00521B7B File Offset: 0x0051FD7B
		public EPasserbyNpcSource Type { get; set; }

		// Token: 0x1700A5A0 RID: 42400
		// (get) Token: 0x060252DE RID: 152286 RVA: 0x00521B84 File Offset: 0x0051FD84
		// (set) Token: 0x060252DF RID: 152287 RVA: 0x00521B8C File Offset: 0x0051FD8C
		public List<string> TemplateIds { get; set; }

		// Token: 0x060252E0 RID: 152288 RVA: 0x00521B95 File Offset: 0x0051FD95
		public IPasserbyNpcTemplateSourceT()
		{
			this.Type = EPasserbyNpcSource.Template;
			this.TemplateIds = null;
		}
	}
}
