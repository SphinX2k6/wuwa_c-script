using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050EB RID: 20715
	public class IDynamicPortalByBulletT
	{
		// Token: 0x170096D5 RID: 38613
		// (get) Token: 0x060215A3 RID: 136611 RVA: 0x004A1C7B File Offset: 0x0049FE7B
		// (set) Token: 0x060215A4 RID: 136612 RVA: 0x004A1C83 File Offset: 0x0049FE83
		public EDynamicPortalCreateType Type { get; set; }

		// Token: 0x170096D6 RID: 38614
		// (get) Token: 0x060215A5 RID: 136613 RVA: 0x004A1C8C File Offset: 0x0049FE8C
		// (set) Token: 0x060215A6 RID: 136614 RVA: 0x004A1C94 File Offset: 0x0049FE94
		public IDynamicPortalConfigT PortalA { get; set; }

		// Token: 0x170096D7 RID: 38615
		// (get) Token: 0x060215A7 RID: 136615 RVA: 0x004A1C9D File Offset: 0x0049FE9D
		// (set) Token: 0x060215A8 RID: 136616 RVA: 0x004A1CA5 File Offset: 0x0049FEA5
		public IDynamicPortalConfigT PortalB { get; set; }

		// Token: 0x170096D8 RID: 38616
		// (get) Token: 0x060215A9 RID: 136617 RVA: 0x004A1CAE File Offset: 0x0049FEAE
		// (set) Token: 0x060215AA RID: 136618 RVA: 0x004A1CB6 File Offset: 0x0049FEB6
		public EPortalModel InitOpenPortal { get; set; }

		// Token: 0x170096D9 RID: 38617
		// (get) Token: 0x060215AB RID: 136619 RVA: 0x004A1CBF File Offset: 0x0049FEBF
		// (set) Token: 0x060215AC RID: 136620 RVA: 0x004A1CC7 File Offset: 0x0049FEC7
		public IPortalRenderConfigT RenderConfig { get; set; }

		// Token: 0x170096DA RID: 38618
		// (get) Token: 0x060215AD RID: 136621 RVA: 0x004A1CD0 File Offset: 0x0049FED0
		// (set) Token: 0x060215AE RID: 136622 RVA: 0x004A1CD8 File Offset: 0x0049FED8
		public IDynamicBulletConfigT TypeA { get; set; }

		// Token: 0x170096DB RID: 38619
		// (get) Token: 0x060215AF RID: 136623 RVA: 0x004A1CE1 File Offset: 0x0049FEE1
		// (set) Token: 0x060215B0 RID: 136624 RVA: 0x004A1CE9 File Offset: 0x0049FEE9
		public IDynamicBulletConfigT TypeB { get; set; }

		// Token: 0x170096DC RID: 38620
		// (get) Token: 0x060215B1 RID: 136625 RVA: 0x004A1CF2 File Offset: 0x0049FEF2
		// (set) Token: 0x060215B2 RID: 136626 RVA: 0x004A1CFA File Offset: 0x0049FEFA
		public byte NullMask { get; set; }

		// Token: 0x060215B3 RID: 136627 RVA: 0x004A1D03 File Offset: 0x0049FF03
		public IDynamicPortalByBulletT()
		{
			this.Type = EDynamicPortalCreateType.Bullet;
			this.PortalA = null;
			this.PortalB = null;
			this.InitOpenPortal = EPortalModel.A;
			this.RenderConfig = null;
			this.TypeA = null;
			this.TypeB = null;
			this.NullMask = 0;
		}
	}
}
