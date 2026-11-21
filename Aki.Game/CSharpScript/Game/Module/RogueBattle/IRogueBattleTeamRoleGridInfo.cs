using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E90 RID: 16016
	[NullableContext(1)]
	public interface IRogueBattleTeamRoleGridInfo
	{
		// Token: 0x170052A1 RID: 21153
		// (get) Token: 0x06028ADE RID: 166622
		// (set) Token: 0x06028ADF RID: 166623
		RoleDataBase RoleData { get; set; }

		// Token: 0x170052A2 RID: 21154
		// (get) Token: 0x06028AE0 RID: 166624
		// (set) Token: 0x06028AE1 RID: 166625
		int RoleStarLv { get; set; }

		// Token: 0x170052A3 RID: 21155
		// (get) Token: 0x06028AE2 RID: 166626
		// (set) Token: 0x06028AE3 RID: 166627
		int FormationIndex { get; set; }

		// Token: 0x170052A4 RID: 21156
		// (get) Token: 0x06028AE4 RID: 166628
		// (set) Token: 0x06028AE5 RID: 166629
		bool IsLinkOn { get; set; }
	}
}
