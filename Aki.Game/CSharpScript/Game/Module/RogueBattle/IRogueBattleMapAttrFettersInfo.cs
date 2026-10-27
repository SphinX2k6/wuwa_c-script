using System;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EC9 RID: 20169
	public interface IRogueBattleMapAttrFettersInfo
	{
		// Token: 0x17007EF9 RID: 32505
		// (get) Token: 0x06033C84 RID: 212100
		// (set) Token: 0x06033C85 RID: 212101
		int ConfigId { get; set; }

		// Token: 0x17007EFA RID: 32506
		// (get) Token: 0x06033C86 RID: 212102
		// (set) Token: 0x06033C87 RID: 212103
		bool IsUnlock { get; set; }

		// Token: 0x17007EFB RID: 32507
		// (get) Token: 0x06033C88 RID: 212104
		// (set) Token: 0x06033C89 RID: 212105
		int Level { get; set; }

		// Token: 0x17007EFC RID: 32508
		// (get) Token: 0x06033C8A RID: 212106
		// (set) Token: 0x06033C8B RID: 212107
		bool? IsMaxLevel { get; set; }
	}
}
