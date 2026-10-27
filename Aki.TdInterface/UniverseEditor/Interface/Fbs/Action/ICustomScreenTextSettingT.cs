using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200650E RID: 25870
	public class ICustomScreenTextSettingT
	{
		// Token: 0x1700C060 RID: 49248
		// (get) Token: 0x0602CE0B RID: 183819 RVA: 0x00629FA9 File Offset: 0x006281A9
		// (set) Token: 0x0602CE0C RID: 183820 RVA: 0x00629FB1 File Offset: 0x006281B1
		public bool IsShowTextInfo { get; set; }

		// Token: 0x1700C061 RID: 49249
		// (get) Token: 0x0602CE0D RID: 183821 RVA: 0x00629FBA File Offset: 0x006281BA
		// (set) Token: 0x0602CE0E RID: 183822 RVA: 0x00629FC2 File Offset: 0x006281C2
		public string TidTextContent { get; set; }

		// Token: 0x1700C062 RID: 49250
		// (get) Token: 0x0602CE0F RID: 183823 RVA: 0x00629FCB File Offset: 0x006281CB
		// (set) Token: 0x0602CE10 RID: 183824 RVA: 0x00629FD3 File Offset: 0x006281D3
		public byte NullMask { get; set; }

		// Token: 0x0602CE11 RID: 183825 RVA: 0x00629FDC File Offset: 0x006281DC
		public ICustomScreenTextSettingT()
		{
			this.IsShowTextInfo = false;
			this.TidTextContent = null;
			this.NullMask = 0;
		}
	}
}
