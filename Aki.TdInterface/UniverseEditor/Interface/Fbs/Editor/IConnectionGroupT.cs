using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200483F RID: 18495
	public class IConnectionGroupT
	{
		// Token: 0x170084BD RID: 33981
		// (get) Token: 0x0601C98D RID: 117133 RVA: 0x0040AEC3 File Offset: 0x004090C3
		// (set) Token: 0x0601C98E RID: 117134 RVA: 0x0040AECB File Offset: 0x004090CB
		public int EditorPort { get; set; }

		// Token: 0x170084BE RID: 33982
		// (get) Token: 0x0601C98F RID: 117135 RVA: 0x0040AED4 File Offset: 0x004090D4
		// (set) Token: 0x0601C990 RID: 117136 RVA: 0x0040AEDC File Offset: 0x004090DC
		public int GameClientGmPort { get; set; }

		// Token: 0x170084BF RID: 33983
		// (get) Token: 0x0601C991 RID: 117137 RVA: 0x0040AEE5 File Offset: 0x004090E5
		// (set) Token: 0x0601C992 RID: 117138 RVA: 0x0040AEED File Offset: 0x004090ED
		public IConnectionIpEndPointT P4Proxy { get; set; }

		// Token: 0x170084C0 RID: 33984
		// (get) Token: 0x0601C993 RID: 117139 RVA: 0x0040AEF6 File Offset: 0x004090F6
		// (set) Token: 0x0601C994 RID: 117140 RVA: 0x0040AEFE File Offset: 0x004090FE
		public IGameServerConnectionConfigT GameServerConfig { get; set; }

		// Token: 0x0601C995 RID: 117141 RVA: 0x0040AF07 File Offset: 0x00409107
		public IConnectionGroupT()
		{
			this.EditorPort = 0;
			this.GameClientGmPort = 0;
			this.P4Proxy = null;
			this.GameServerConfig = null;
		}
	}
}
