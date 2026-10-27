using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050F1 RID: 20721
	public class IDynamicPortalCreateModeT
	{
		// Token: 0x170096E9 RID: 38633
		// (get) Token: 0x060215E5 RID: 136677 RVA: 0x004A24F4 File Offset: 0x004A06F4
		// (set) Token: 0x060215E6 RID: 136678 RVA: 0x004A24FC File Offset: 0x004A06FC
		public EDynamicPortalCreateType Type { get; set; }

		// Token: 0x170096EA RID: 38634
		// (get) Token: 0x060215E7 RID: 136679 RVA: 0x004A2505 File Offset: 0x004A0705
		// (set) Token: 0x060215E8 RID: 136680 RVA: 0x004A250D File Offset: 0x004A070D
		public IDynamicPortalConfigT PortalA { get; set; }

		// Token: 0x170096EB RID: 38635
		// (get) Token: 0x060215E9 RID: 136681 RVA: 0x004A2516 File Offset: 0x004A0716
		// (set) Token: 0x060215EA RID: 136682 RVA: 0x004A251E File Offset: 0x004A071E
		public IDynamicPortalConfigT PortalB { get; set; }

		// Token: 0x170096EC RID: 38636
		// (get) Token: 0x060215EB RID: 136683 RVA: 0x004A2527 File Offset: 0x004A0727
		// (set) Token: 0x060215EC RID: 136684 RVA: 0x004A252F File Offset: 0x004A072F
		public EPortalModel InitOpenPortal { get; set; }

		// Token: 0x170096ED RID: 38637
		// (get) Token: 0x060215ED RID: 136685 RVA: 0x004A2538 File Offset: 0x004A0738
		// (set) Token: 0x060215EE RID: 136686 RVA: 0x004A2540 File Offset: 0x004A0740
		public IPortalRenderConfigT RenderConfig { get; set; }

		// Token: 0x170096EE RID: 38638
		// (get) Token: 0x060215EF RID: 136687 RVA: 0x004A2549 File Offset: 0x004A0749
		// (set) Token: 0x060215F0 RID: 136688 RVA: 0x004A2551 File Offset: 0x004A0751
		public byte NullMask { get; set; }

		// Token: 0x060215F1 RID: 136689 RVA: 0x004A255A File Offset: 0x004A075A
		public IDynamicPortalCreateModeT()
		{
			this.Type = EDynamicPortalCreateType.Bullet;
			this.PortalA = null;
			this.PortalB = null;
			this.InitOpenPortal = EPortalModel.A;
			this.RenderConfig = null;
			this.NullMask = 0;
		}
	}
}
