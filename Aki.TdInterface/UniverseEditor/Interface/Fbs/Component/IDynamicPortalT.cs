using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050E8 RID: 20712
	public class IDynamicPortalT
	{
		// Token: 0x170096C9 RID: 38601
		// (get) Token: 0x0602157F RID: 136575 RVA: 0x004A15BD File Offset: 0x0049F7BD
		// (set) Token: 0x06021580 RID: 136576 RVA: 0x004A15C5 File Offset: 0x0049F7C5
		public EPortalType Type { get; set; }

		// Token: 0x170096CA RID: 38602
		// (get) Token: 0x06021581 RID: 136577 RVA: 0x004A15CE File Offset: 0x0049F7CE
		// (set) Token: 0x06021582 RID: 136578 RVA: 0x004A15D6 File Offset: 0x0049F7D6
		public EPortalModel PortalModel { get; set; }

		// Token: 0x170096CB RID: 38603
		// (get) Token: 0x06021583 RID: 136579 RVA: 0x004A15DF File Offset: 0x0049F7DF
		// (set) Token: 0x06021584 RID: 136580 RVA: 0x004A15E7 File Offset: 0x0049F7E7
		public IPortalRenderConfigT RenderConfig { get; set; }

		// Token: 0x06021585 RID: 136581 RVA: 0x004A15F0 File Offset: 0x0049F7F0
		public IDynamicPortalT()
		{
			this.Type = EPortalType.Static;
			this.PortalModel = EPortalModel.A;
			this.RenderConfig = null;
		}
	}
}
