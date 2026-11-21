using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A3B RID: 19003
	[NullableContext(2)]
	public interface IFlagChallengeFormationRoleItemData
	{
		// Token: 0x17005FC6 RID: 24518
		// (get) Token: 0x0602F995 RID: 194965
		// (set) Token: 0x0602F996 RID: 194966
		int Index { get; set; }

		// Token: 0x17005FC7 RID: 24519
		// (get) Token: 0x0602F997 RID: 194967
		// (set) Token: 0x0602F998 RID: 194968
		RoleDataBase RoleData { get; set; }
	}
}
