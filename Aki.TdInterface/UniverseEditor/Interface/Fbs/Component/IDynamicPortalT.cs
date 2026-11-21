using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200564D RID: 22093
	public class IDynamicPortalT
	{
		// Token: 0x17009EB6 RID: 40630
		// (get) Token: 0x060234D3 RID: 144595 RVA: 0x004DB549 File Offset: 0x004D9749
		// (set) Token: 0x060234D4 RID: 144596 RVA: 0x004DB551 File Offset: 0x004D9751
		public EPortalType Type { get; set; }

		// Token: 0x17009EB7 RID: 40631
		// (get) Token: 0x060234D5 RID: 144597 RVA: 0x004DB55A File Offset: 0x004D975A
		// (set) Token: 0x060234D6 RID: 144598 RVA: 0x004DB562 File Offset: 0x004D9762
		public EPortalModel PortalModel { get; set; }

		// Token: 0x17009EB8 RID: 40632
		// (get) Token: 0x060234D7 RID: 144599 RVA: 0x004DB56B File Offset: 0x004D976B
		// (set) Token: 0x060234D8 RID: 144600 RVA: 0x004DB573 File Offset: 0x004D9773
		public IPortalRenderConfigT RenderConfig { get; set; }

		// Token: 0x060234D9 RID: 144601 RVA: 0x004DB57C File Offset: 0x004D977C
		public IDynamicPortalT()
		{
			this.Type = EPortalType.Static;
			this.PortalModel = EPortalModel.A;
			this.RenderConfig = null;
		}
	}
}
