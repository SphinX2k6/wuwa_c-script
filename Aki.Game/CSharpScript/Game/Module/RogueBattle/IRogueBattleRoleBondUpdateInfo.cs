using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E8E RID: 16014
	[NullableContext(1)]
	public interface IRogueBattleRoleBondUpdateInfo
	{
		// Token: 0x1700529B RID: 21147
		// (get) Token: 0x06028AD1 RID: 166609
		// (set) Token: 0x06028AD2 RID: 166610
		RoleBondInfo OldRoleBondInfo { get; set; }

		// Token: 0x1700529C RID: 21148
		// (get) Token: 0x06028AD3 RID: 166611
		// (set) Token: 0x06028AD4 RID: 166612
		RoleBondInfo NewRoleBondInfo { get; set; }

		// Token: 0x1700529D RID: 21149
		// (get) Token: 0x06028AD5 RID: 166613
		// (set) Token: 0x06028AD6 RID: 166614
		int AddStar { get; set; }
	}
}
