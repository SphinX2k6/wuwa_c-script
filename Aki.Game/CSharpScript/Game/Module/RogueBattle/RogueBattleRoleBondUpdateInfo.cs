using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EC6 RID: 20166
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleRoleBondUpdateInfo : IRogueBattleRoleBondUpdateInfo
	{
		// Token: 0x17007EEE RID: 32494
		// (get) Token: 0x06033C6C RID: 212076 RVA: 0x00C20E9D File Offset: 0x00C1F09D
		// (set) Token: 0x06033C6D RID: 212077 RVA: 0x00C20EA5 File Offset: 0x00C1F0A5
		public RoleBondInfo OldRoleBondInfo { get; set; }

		// Token: 0x17007EEF RID: 32495
		// (get) Token: 0x06033C6E RID: 212078 RVA: 0x00C20EAE File Offset: 0x00C1F0AE
		// (set) Token: 0x06033C6F RID: 212079 RVA: 0x00C20EB6 File Offset: 0x00C1F0B6
		public RoleBondInfo NewRoleBondInfo { get; set; }

		// Token: 0x17007EF0 RID: 32496
		// (get) Token: 0x06033C70 RID: 212080 RVA: 0x00C20EBF File Offset: 0x00C1F0BF
		// (set) Token: 0x06033C71 RID: 212081 RVA: 0x00C20EC7 File Offset: 0x00C1F0C7
		public int AddStar { get; set; }
	}
}
