using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x02005713 RID: 22291
	public class KurotatoSaveData : IKurotatoSaveData
	{
		// Token: 0x17008853 RID: 34899
		// (get) Token: 0x06038A95 RID: 232085 RVA: 0x00D70975 File Offset: 0x00D6EB75
		// (set) Token: 0x06038A96 RID: 232086 RVA: 0x00D7097D File Offset: 0x00D6EB7D
		public long SaveTimestamp { get; set; }

		// Token: 0x17008854 RID: 34900
		// (get) Token: 0x06038A97 RID: 232087 RVA: 0x00D70986 File Offset: 0x00D6EB86
		// (set) Token: 0x06038A98 RID: 232088 RVA: 0x00D7098E File Offset: 0x00D6EB8E
		public int RoleLevel { get; set; }

		// Token: 0x17008855 RID: 34901
		// (get) Token: 0x06038A99 RID: 232089 RVA: 0x00D70997 File Offset: 0x00D6EB97
		// (set) Token: 0x06038A9A RID: 232090 RVA: 0x00D7099F File Offset: 0x00D6EB9F
		public int WaveNum { get; set; }
	}
}
