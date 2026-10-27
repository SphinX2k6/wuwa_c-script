using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EC5 RID: 20165
	[NullableContext(1)]
	public interface IRogueBattleRoleBondUpdateInfo
	{
		// Token: 0x17007EEB RID: 32491
		// (get) Token: 0x06033C66 RID: 212070
		// (set) Token: 0x06033C67 RID: 212071
		RoleBondInfo OldRoleBondInfo { get; set; }

		// Token: 0x17007EEC RID: 32492
		// (get) Token: 0x06033C68 RID: 212072
		// (set) Token: 0x06033C69 RID: 212073
		RoleBondInfo NewRoleBondInfo { get; set; }

		// Token: 0x17007EED RID: 32493
		// (get) Token: 0x06033C6A RID: 212074
		// (set) Token: 0x06033C6B RID: 212075
		int AddStar { get; set; }
	}
}
