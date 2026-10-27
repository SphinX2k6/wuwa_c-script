using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BE6 RID: 27622
	public class INpcSwingT
	{
		// Token: 0x1700CD4B RID: 52555
		// (get) Token: 0x0603088A RID: 198794 RVA: 0x00696C29 File Offset: 0x00694E29
		// (set) Token: 0x0603088B RID: 198795 RVA: 0x00696C31 File Offset: 0x00694E31
		public ENpcLeisureInteract Type { get; set; }

		// Token: 0x1700CD4C RID: 52556
		// (get) Token: 0x0603088C RID: 198796 RVA: 0x00696C3A File Offset: 0x00694E3A
		// (set) Token: 0x0603088D RID: 198797 RVA: 0x00696C42 File Offset: 0x00694E42
		public bool KeepState { get; set; }

		// Token: 0x1700CD4D RID: 52557
		// (get) Token: 0x0603088E RID: 198798 RVA: 0x00696C4B File Offset: 0x00694E4B
		// (set) Token: 0x0603088F RID: 198799 RVA: 0x00696C53 File Offset: 0x00694E53
		public int TargetNpcId { get; set; }

		// Token: 0x1700CD4E RID: 52558
		// (get) Token: 0x06030890 RID: 198800 RVA: 0x00696C5C File Offset: 0x00694E5C
		// (set) Token: 0x06030891 RID: 198801 RVA: 0x00696C64 File Offset: 0x00694E64
		public string SwingDa { get; set; }

		// Token: 0x1700CD4F RID: 52559
		// (get) Token: 0x06030892 RID: 198802 RVA: 0x00696C6D File Offset: 0x00694E6D
		// (set) Token: 0x06030893 RID: 198803 RVA: 0x00696C75 File Offset: 0x00694E75
		public int EntityId { get; set; }

		// Token: 0x1700CD50 RID: 52560
		// (get) Token: 0x06030894 RID: 198804 RVA: 0x00696C7E File Offset: 0x00694E7E
		// (set) Token: 0x06030895 RID: 198805 RVA: 0x00696C86 File Offset: 0x00694E86
		public bool SkipSitDown { get; set; }

		// Token: 0x1700CD51 RID: 52561
		// (get) Token: 0x06030896 RID: 198806 RVA: 0x00696C8F File Offset: 0x00694E8F
		// (set) Token: 0x06030897 RID: 198807 RVA: 0x00696C97 File Offset: 0x00694E97
		public byte NullMask { get; set; }

		// Token: 0x06030898 RID: 198808 RVA: 0x00696CA0 File Offset: 0x00694EA0
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
