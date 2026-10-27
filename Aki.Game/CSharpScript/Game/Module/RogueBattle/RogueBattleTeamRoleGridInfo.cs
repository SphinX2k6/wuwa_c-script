using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EC8 RID: 20168
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleTeamRoleGridInfo : IRogueBattleTeamRoleGridInfo
	{
		// Token: 0x17007EF5 RID: 32501
		// (get) Token: 0x06033C7B RID: 212091 RVA: 0x00C20ED8 File Offset: 0x00C1F0D8
		// (set) Token: 0x06033C7C RID: 212092 RVA: 0x00C20EE0 File Offset: 0x00C1F0E0
		public RoleDataBase RoleData { get; set; }

		// Token: 0x17007EF6 RID: 32502
		// (get) Token: 0x06033C7D RID: 212093 RVA: 0x00C20EE9 File Offset: 0x00C1F0E9
		// (set) Token: 0x06033C7E RID: 212094 RVA: 0x00C20EF1 File Offset: 0x00C1F0F1
		public int RoleStarLv { get; set; }

		// Token: 0x17007EF7 RID: 32503
		// (get) Token: 0x06033C7F RID: 212095 RVA: 0x00C20EFA File Offset: 0x00C1F0FA
		// (set) Token: 0x06033C80 RID: 212096 RVA: 0x00C20F02 File Offset: 0x00C1F102
		public int FormationIndex { get; set; }

		// Token: 0x17007EF8 RID: 32504
		// (get) Token: 0x06033C81 RID: 212097 RVA: 0x00C20F0B File Offset: 0x00C1F10B
		// (set) Token: 0x06033C82 RID: 212098 RVA: 0x00C20F13 File Offset: 0x00C1F113
		public bool IsLinkOn { get; set; }
	}
}
