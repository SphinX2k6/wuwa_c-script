using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B72 RID: 23410
	public class IWellStreamingRenderConfigT
	{
		// Token: 0x1700B0E7 RID: 45287
		// (get) Token: 0x06028111 RID: 164113 RVA: 0x0058219B File Offset: 0x0058039B
		// (set) Token: 0x06028112 RID: 164114 RVA: 0x005821A3 File Offset: 0x005803A3
		public IWellStreamingRenderSelfConfigT SelfConfig { get; set; }

		// Token: 0x1700B0E8 RID: 45288
		// (get) Token: 0x06028113 RID: 164115 RVA: 0x005821AC File Offset: 0x005803AC
		// (set) Token: 0x06028114 RID: 164116 RVA: 0x005821B4 File Offset: 0x005803B4
		public IWellStreamingRenderPointConfigT AsStreamPointConfig { get; set; }

		// Token: 0x06028115 RID: 164117 RVA: 0x005821BD File Offset: 0x005803BD
		public IWellStreamingRenderConfigT()
		{
			this.SelfConfig = null;
			this.AsStreamPointConfig = null;
		}
	}
}
