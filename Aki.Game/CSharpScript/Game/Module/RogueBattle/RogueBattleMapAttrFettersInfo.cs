using System;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004ECA RID: 20170
	public class RogueBattleMapAttrFettersInfo : IRogueBattleMapAttrFettersInfo
	{
		// Token: 0x17007EFD RID: 32509
		// (get) Token: 0x06033C8C RID: 212108 RVA: 0x00C20F24 File Offset: 0x00C1F124
		// (set) Token: 0x06033C8D RID: 212109 RVA: 0x00C20F2C File Offset: 0x00C1F12C
		public int ConfigId { get; set; }

		// Token: 0x17007EFE RID: 32510
		// (get) Token: 0x06033C8E RID: 212110 RVA: 0x00C20F35 File Offset: 0x00C1F135
		// (set) Token: 0x06033C8F RID: 212111 RVA: 0x00C20F3D File Offset: 0x00C1F13D
		public bool IsUnlock { get; set; }

		// Token: 0x17007EFF RID: 32511
		// (get) Token: 0x06033C90 RID: 212112 RVA: 0x00C20F46 File Offset: 0x00C1F146
		// (set) Token: 0x06033C91 RID: 212113 RVA: 0x00C20F4E File Offset: 0x00C1F14E
		public int Level { get; set; }

		// Token: 0x17007F00 RID: 32512
		// (get) Token: 0x06033C92 RID: 212114 RVA: 0x00C20F57 File Offset: 0x00C1F157
		// (set) Token: 0x06033C93 RID: 212115 RVA: 0x00C20F5F File Offset: 0x00C1F15F
		public bool? IsMaxLevel { get; set; }
	}
}
