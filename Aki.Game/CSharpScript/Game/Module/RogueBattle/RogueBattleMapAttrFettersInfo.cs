using System;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E93 RID: 16019
	public class RogueBattleMapAttrFettersInfo : IRogueBattleMapAttrFettersInfo
	{
		// Token: 0x170052AD RID: 21165
		// (get) Token: 0x06028AF7 RID: 166647 RVA: 0x00B6A43C File Offset: 0x00B6863C
		// (set) Token: 0x06028AF8 RID: 166648 RVA: 0x00B6A444 File Offset: 0x00B68644
		public int ConfigId { get; set; }

		// Token: 0x170052AE RID: 21166
		// (get) Token: 0x06028AF9 RID: 166649 RVA: 0x00B6A44D File Offset: 0x00B6864D
		// (set) Token: 0x06028AFA RID: 166650 RVA: 0x00B6A455 File Offset: 0x00B68655
		public bool IsUnlock { get; set; }

		// Token: 0x170052AF RID: 21167
		// (get) Token: 0x06028AFB RID: 166651 RVA: 0x00B6A45E File Offset: 0x00B6865E
		// (set) Token: 0x06028AFC RID: 166652 RVA: 0x00B6A466 File Offset: 0x00B68666
		public int Level { get; set; }

		// Token: 0x170052B0 RID: 21168
		// (get) Token: 0x06028AFD RID: 166653 RVA: 0x00B6A46F File Offset: 0x00B6866F
		// (set) Token: 0x06028AFE RID: 166654 RVA: 0x00B6A477 File Offset: 0x00B68677
		public bool? IsMaxLevel { get; set; }
	}
}
