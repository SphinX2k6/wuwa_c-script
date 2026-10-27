using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200560F RID: 22031
	public class INoRenderPortalComponentT
	{
		// Token: 0x1700A309 RID: 41737
		// (get) Token: 0x06024909 RID: 149769 RVA: 0x0050BB29 File Offset: 0x00509D29
		// (set) Token: 0x0602490A RID: 149770 RVA: 0x0050BB31 File Offset: 0x00509D31
		public bool Disabled { get; set; }

		// Token: 0x1700A30A RID: 41738
		// (get) Token: 0x0602490B RID: 149771 RVA: 0x0050BB3A File Offset: 0x00509D3A
		// (set) Token: 0x0602490C RID: 149772 RVA: 0x0050BB42 File Offset: 0x00509D42
		public IStaticNoRenderPortalT Config { get; set; }

		// Token: 0x1700A30B RID: 41739
		// (get) Token: 0x0602490D RID: 149773 RVA: 0x0050BB4B File Offset: 0x00509D4B
		// (set) Token: 0x0602490E RID: 149774 RVA: 0x0050BB53 File Offset: 0x00509D53
		public byte NullMask { get; set; }

		// Token: 0x0602490F RID: 149775 RVA: 0x0050BB5C File Offset: 0x00509D5C
		public INoRenderPortalComponentT()
		{
			this.Disabled = false;
			this.Config = null;
			this.NullMask = 0;
		}
	}
}
