using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072DE RID: 29406
	public class ITalkItemDisableAutoSelectOptionGroupT
	{
		// Token: 0x1700DC7A RID: 56442
		// (get) Token: 0x06034B38 RID: 215864 RVA: 0x0071FD01 File Offset: 0x0071DF01
		// (set) Token: 0x06034B39 RID: 215865 RVA: 0x0071FD09 File Offset: 0x0071DF09
		public string TextKey { get; set; }

		// Token: 0x1700DC7B RID: 56443
		// (get) Token: 0x06034B3A RID: 215866 RVA: 0x0071FD12 File Offset: 0x0071DF12
		// (set) Token: 0x06034B3B RID: 215867 RVA: 0x0071FD1A File Offset: 0x0071DF1A
		public int IconId { get; set; }

		// Token: 0x1700DC7C RID: 56444
		// (get) Token: 0x06034B3C RID: 215868 RVA: 0x0071FD23 File Offset: 0x0071DF23
		// (set) Token: 0x06034B3D RID: 215869 RVA: 0x0071FD2B File Offset: 0x0071DF2B
		public byte NullMask { get; set; }

		// Token: 0x06034B3E RID: 215870 RVA: 0x0071FD34 File Offset: 0x0071DF34
		public ITalkItemDisableAutoSelectOptionGroupT()
		{
			this.TextKey = null;
			this.IconId = 0;
			this.NullMask = 0;
		}
	}
}
