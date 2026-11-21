using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E40 RID: 24128
	public class IRefreshSingleT
	{
		// Token: 0x1700B1D5 RID: 45525
		// (get) Token: 0x060284ED RID: 165101 RVA: 0x00582BEB File Offset: 0x00580DEB
		// (set) Token: 0x060284EE RID: 165102 RVA: 0x00582BF3 File Offset: 0x00580DF3
		public int RefreshInterval { get; set; }

		// Token: 0x1700B1D6 RID: 45526
		// (get) Token: 0x060284EF RID: 165103 RVA: 0x00582BFC File Offset: 0x00580DFC
		// (set) Token: 0x060284F0 RID: 165104 RVA: 0x00582C04 File Offset: 0x00580E04
		public int MaxRefreshTimes { get; set; }

		// Token: 0x1700B1D7 RID: 45527
		// (get) Token: 0x060284F1 RID: 165105 RVA: 0x00582C0D File Offset: 0x00580E0D
		// (set) Token: 0x060284F2 RID: 165106 RVA: 0x00582C15 File Offset: 0x00580E15
		public bool DelayRefresh { get; set; }

		// Token: 0x1700B1D8 RID: 45528
		// (get) Token: 0x060284F3 RID: 165107 RVA: 0x00582C1E File Offset: 0x00580E1E
		// (set) Token: 0x060284F4 RID: 165108 RVA: 0x00582C26 File Offset: 0x00580E26
		public ITempleGuidT TemplateGuid { get; set; }

		// Token: 0x060284F5 RID: 165109 RVA: 0x00582C2F File Offset: 0x00580E2F
		public IRefreshSingleT()
		{
			this.RefreshInterval = 0;
			this.MaxRefreshTimes = 0;
			this.DelayRefresh = false;
			this.TemplateGuid = null;
		}
	}
}
