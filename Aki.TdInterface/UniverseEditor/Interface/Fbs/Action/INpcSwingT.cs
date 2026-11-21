using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200734A RID: 29514
	public class INpcSwingT
	{
		// Token: 0x1700D857 RID: 55383
		// (get) Token: 0x060337A6 RID: 210854 RVA: 0x006F0529 File Offset: 0x006EE729
		// (set) Token: 0x060337A7 RID: 210855 RVA: 0x006F0531 File Offset: 0x006EE731
		public ENpcLeisureInteract Type { get; set; }

		// Token: 0x1700D858 RID: 55384
		// (get) Token: 0x060337A8 RID: 210856 RVA: 0x006F053A File Offset: 0x006EE73A
		// (set) Token: 0x060337A9 RID: 210857 RVA: 0x006F0542 File Offset: 0x006EE742
		public bool KeepState { get; set; }

		// Token: 0x1700D859 RID: 55385
		// (get) Token: 0x060337AA RID: 210858 RVA: 0x006F054B File Offset: 0x006EE74B
		// (set) Token: 0x060337AB RID: 210859 RVA: 0x006F0553 File Offset: 0x006EE753
		public int TargetNpcId { get; set; }

		// Token: 0x1700D85A RID: 55386
		// (get) Token: 0x060337AC RID: 210860 RVA: 0x006F055C File Offset: 0x006EE75C
		// (set) Token: 0x060337AD RID: 210861 RVA: 0x006F0564 File Offset: 0x006EE764
		public string SwingDa { get; set; }

		// Token: 0x1700D85B RID: 55387
		// (get) Token: 0x060337AE RID: 210862 RVA: 0x006F056D File Offset: 0x006EE76D
		// (set) Token: 0x060337AF RID: 210863 RVA: 0x006F0575 File Offset: 0x006EE775
		public int EntityId { get; set; }

		// Token: 0x1700D85C RID: 55388
		// (get) Token: 0x060337B0 RID: 210864 RVA: 0x006F057E File Offset: 0x006EE77E
		// (set) Token: 0x060337B1 RID: 210865 RVA: 0x006F0586 File Offset: 0x006EE786
		public bool SkipSitDown { get; set; }

		// Token: 0x1700D85D RID: 55389
		// (get) Token: 0x060337B2 RID: 210866 RVA: 0x006F058F File Offset: 0x006EE78F
		// (set) Token: 0x060337B3 RID: 210867 RVA: 0x006F0597 File Offset: 0x006EE797
		public byte NullMask { get; set; }

		// Token: 0x060337B4 RID: 210868 RVA: 0x006F05A0 File Offset: 0x006EE7A0
		public INpcSwingT()
		{
			this.Type = ENpcLeisureInteract.SitDown;
			this.KeepState = false;
			this.TargetNpcId = 0;
			this.SwingDa = null;
			this.EntityId = 0;
			this.SkipSitDown = false;
			this.NullMask = 0;
		}
	}
}
