using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BE9 RID: 27625
	public class INpcSwingGetUpT
	{
		// Token: 0x1700CD57 RID: 52567
		// (get) Token: 0x060308AE RID: 198830 RVA: 0x00696FBC File Offset: 0x006951BC
		// (set) Token: 0x060308AF RID: 198831 RVA: 0x00696FC4 File Offset: 0x006951C4
		public ENpcLeisureInteract Type { get; set; }

		// Token: 0x1700CD58 RID: 52568
		// (get) Token: 0x060308B0 RID: 198832 RVA: 0x00696FCD File Offset: 0x006951CD
		// (set) Token: 0x060308B1 RID: 198833 RVA: 0x00696FD5 File Offset: 0x006951D5
		public bool KeepState { get; set; }

		// Token: 0x1700CD59 RID: 52569
		// (get) Token: 0x060308B2 RID: 198834 RVA: 0x00696FDE File Offset: 0x006951DE
		// (set) Token: 0x060308B3 RID: 198835 RVA: 0x00696FE6 File Offset: 0x006951E6
		public int TargetNpcId { get; set; }

		// Token: 0x1700CD5A RID: 52570
		// (get) Token: 0x060308B4 RID: 198836 RVA: 0x00696FEF File Offset: 0x006951EF
		// (set) Token: 0x060308B5 RID: 198837 RVA: 0x00696FF7 File Offset: 0x006951F7
		public byte NullMask { get; set; }

		// Token: 0x060308B6 RID: 198838 RVA: 0x00697000 File Offset: 0x00695200
		public INpcSwingGetUpT()
		{
			this.Type = ENpcLeisureInteract.SitDown;
			this.KeepState = false;
			this.TargetNpcId = 0;
			this.NullMask = 0;
		}
	}
}
