using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CB5 RID: 23733
	public class IPasserbyNpcSourceT
	{
		// Token: 0x1700AE59 RID: 44633
		// (get) Token: 0x06027621 RID: 161313 RVA: 0x005640EE File Offset: 0x005622EE
		// (set) Token: 0x06027622 RID: 161314 RVA: 0x005640F6 File Offset: 0x005622F6
		public EPasserbyNpcSource Type { get; set; }

		// Token: 0x06027623 RID: 161315 RVA: 0x005640FF File Offset: 0x005622FF
		public IPasserbyNpcSourceT()
		{
			this.Type = EPasserbyNpcSource.Template;
		}
	}
}
