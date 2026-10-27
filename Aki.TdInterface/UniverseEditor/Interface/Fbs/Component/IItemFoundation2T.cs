using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005495 RID: 21653
	public class IItemFoundation2T
	{
		// Token: 0x17009F76 RID: 40822
		// (get) Token: 0x06023A3E RID: 145982 RVA: 0x004ED925 File Offset: 0x004EBB25
		// (set) Token: 0x06023A3F RID: 145983 RVA: 0x004ED92D File Offset: 0x004EBB2D
		public bool Disabled { get; set; }

		// Token: 0x17009F77 RID: 40823
		// (get) Token: 0x06023A40 RID: 145984 RVA: 0x004ED936 File Offset: 0x004EBB36
		// (set) Token: 0x06023A41 RID: 145985 RVA: 0x004ED93E File Offset: 0x004EBB3E
		public TItemFoundationUnion Config { get; set; }

		// Token: 0x17009F78 RID: 40824
		// (get) Token: 0x06023A42 RID: 145986 RVA: 0x004ED947 File Offset: 0x004EBB47
		// (set) Token: 0x06023A43 RID: 145987 RVA: 0x004ED94F File Offset: 0x004EBB4F
		public byte NullMask { get; set; }

		// Token: 0x06023A44 RID: 145988 RVA: 0x004ED958 File Offset: 0x004EBB58
		public IItemFoundation2T()
		{
			this.Disabled = false;
			this.Config = null;
			this.NullMask = 0;
		}
	}
}
