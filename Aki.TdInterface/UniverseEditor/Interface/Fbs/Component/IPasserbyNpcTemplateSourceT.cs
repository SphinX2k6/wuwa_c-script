using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CD6 RID: 23766
	public class IPasserbyNpcTemplateSourceT
	{
		// Token: 0x1700AEA2 RID: 44706
		// (get) Token: 0x06027743 RID: 161603 RVA: 0x005665BF File Offset: 0x005647BF
		// (set) Token: 0x06027744 RID: 161604 RVA: 0x005665C7 File Offset: 0x005647C7
		public EPasserbyNpcSource Type { get; set; }

		// Token: 0x1700AEA3 RID: 44707
		// (get) Token: 0x06027745 RID: 161605 RVA: 0x005665D0 File Offset: 0x005647D0
		// (set) Token: 0x06027746 RID: 161606 RVA: 0x005665D8 File Offset: 0x005647D8
		public List<string> TemplateIds { get; set; }

		// Token: 0x06027747 RID: 161607 RVA: 0x005665E1 File Offset: 0x005647E1
		public IPasserbyNpcTemplateSourceT()
		{
			this.Type = EPasserbyNpcSource.Template;
			this.TemplateIds = null;
		}
	}
}
