using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056CF RID: 22223
	public class IPasserbyNpcSourceT
	{
		// Token: 0x1700A564 RID: 42340
		// (get) Token: 0x06025200 RID: 152064 RVA: 0x00520022 File Offset: 0x0051E222
		// (set) Token: 0x06025201 RID: 152065 RVA: 0x0052002A File Offset: 0x0051E22A
		public EPasserbyNpcSource Type { get; set; }

		// Token: 0x06025202 RID: 152066 RVA: 0x00520033 File Offset: 0x0051E233
		public IPasserbyNpcSourceT()
		{
			this.Type = EPasserbyNpcSource.Template;
		}
	}
}
