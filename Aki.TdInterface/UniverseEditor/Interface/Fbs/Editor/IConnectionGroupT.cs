using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CA7 RID: 19623
	public class IConnectionGroupT
	{
		// Token: 0x17008B08 RID: 35592
		// (get) Token: 0x0601E18A RID: 123274 RVA: 0x00437813 File Offset: 0x00435A13
		// (set) Token: 0x0601E18B RID: 123275 RVA: 0x0043781B File Offset: 0x00435A1B
		public int EditorPort { get; set; }

		// Token: 0x17008B09 RID: 35593
		// (get) Token: 0x0601E18C RID: 123276 RVA: 0x00437824 File Offset: 0x00435A24
		// (set) Token: 0x0601E18D RID: 123277 RVA: 0x0043782C File Offset: 0x00435A2C
		public int GameClientGmPort { get; set; }

		// Token: 0x17008B0A RID: 35594
		// (get) Token: 0x0601E18E RID: 123278 RVA: 0x00437835 File Offset: 0x00435A35
		// (set) Token: 0x0601E18F RID: 123279 RVA: 0x0043783D File Offset: 0x00435A3D
		public IConnectionIpEndPointT P4Proxy { get; set; }

		// Token: 0x17008B0B RID: 35595
		// (get) Token: 0x0601E190 RID: 123280 RVA: 0x00437846 File Offset: 0x00435A46
		// (set) Token: 0x0601E191 RID: 123281 RVA: 0x0043784E File Offset: 0x00435A4E
		public IGameServerConnectionConfigT GameServerConfig { get; set; }

		// Token: 0x0601E192 RID: 123282 RVA: 0x00437857 File Offset: 0x00435A57
		public IConnectionGroupT()
		{
			this.EditorPort = 0;
			this.GameClientGmPort = 0;
			this.P4Proxy = null;
			this.GameServerConfig = null;
		}
	}
}
