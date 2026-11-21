using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059DF RID: 23007
	public class IInteractiveComponentT
	{
		// Token: 0x1700A739 RID: 42809
		// (get) Token: 0x06025917 RID: 153879 RVA: 0x0052729E File Offset: 0x0052549E
		// (set) Token: 0x06025918 RID: 153880 RVA: 0x005272A6 File Offset: 0x005254A6
		public bool Disabled { get; set; }

		// Token: 0x1700A73A RID: 42810
		// (get) Token: 0x06025919 RID: 153881 RVA: 0x005272AF File Offset: 0x005254AF
		// (set) Token: 0x0602591A RID: 153882 RVA: 0x005272B7 File Offset: 0x005254B7
		public string Content { get; set; }

		// Token: 0x1700A73B RID: 42811
		// (get) Token: 0x0602591B RID: 153883 RVA: 0x005272C0 File Offset: 0x005254C0
		// (set) Token: 0x0602591C RID: 153884 RVA: 0x005272C8 File Offset: 0x005254C8
		public string Icon { get; set; }

		// Token: 0x1700A73C RID: 42812
		// (get) Token: 0x0602591D RID: 153885 RVA: 0x005272D1 File Offset: 0x005254D1
		// (set) Token: 0x0602591E RID: 153886 RVA: 0x005272D9 File Offset: 0x005254D9
		public byte NullMask { get; set; }

		// Token: 0x0602591F RID: 153887 RVA: 0x005272E2 File Offset: 0x005254E2
		public IInteractiveComponentT()
		{
			this.Disabled = false;
			this.Content = null;
			this.Icon = null;
			this.NullMask = 0;
		}
	}
}
