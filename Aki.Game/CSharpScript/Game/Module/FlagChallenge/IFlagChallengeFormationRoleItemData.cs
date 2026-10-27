using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A5F RID: 23135
	[NullableContext(2)]
	public interface IFlagChallengeFormationRoleItemData
	{
		// Token: 0x17008BF8 RID: 35832
		// (get) Token: 0x0603AA4C RID: 240204
		// (set) Token: 0x0603AA4D RID: 240205
		int Index { get; set; }

		// Token: 0x17008BF9 RID: 35833
		// (get) Token: 0x0603AA4E RID: 240206
		// (set) Token: 0x0603AA4F RID: 240207
		RoleDataBase RoleData { get; set; }
	}
}
