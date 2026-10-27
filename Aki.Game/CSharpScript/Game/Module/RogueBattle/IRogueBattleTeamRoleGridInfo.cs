using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EC7 RID: 20167
	[NullableContext(1)]
	public interface IRogueBattleTeamRoleGridInfo
	{
		// Token: 0x17007EF1 RID: 32497
		// (get) Token: 0x06033C73 RID: 212083
		// (set) Token: 0x06033C74 RID: 212084
		RoleDataBase RoleData { get; set; }

		// Token: 0x17007EF2 RID: 32498
		// (get) Token: 0x06033C75 RID: 212085
		// (set) Token: 0x06033C76 RID: 212086
		int RoleStarLv { get; set; }

		// Token: 0x17007EF3 RID: 32499
		// (get) Token: 0x06033C77 RID: 212087
		// (set) Token: 0x06033C78 RID: 212088
		int FormationIndex { get; set; }

		// Token: 0x17007EF4 RID: 32500
		// (get) Token: 0x06033C79 RID: 212089
		// (set) Token: 0x06033C7A RID: 212090
		bool IsLinkOn { get; set; }
	}
}
