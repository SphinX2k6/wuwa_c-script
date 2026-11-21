using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E91 RID: 16017
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleTeamRoleGridInfo : IRogueBattleTeamRoleGridInfo
	{
		// Token: 0x170052A5 RID: 21157
		// (get) Token: 0x06028AE6 RID: 166630 RVA: 0x00B6A3F0 File Offset: 0x00B685F0
		// (set) Token: 0x06028AE7 RID: 166631 RVA: 0x00B6A3F8 File Offset: 0x00B685F8
		public RoleDataBase RoleData { get; set; }

		// Token: 0x170052A6 RID: 21158
		// (get) Token: 0x06028AE8 RID: 166632 RVA: 0x00B6A401 File Offset: 0x00B68601
		// (set) Token: 0x06028AE9 RID: 166633 RVA: 0x00B6A409 File Offset: 0x00B68609
		public int RoleStarLv { get; set; }

		// Token: 0x170052A7 RID: 21159
		// (get) Token: 0x06028AEA RID: 166634 RVA: 0x00B6A412 File Offset: 0x00B68612
		// (set) Token: 0x06028AEB RID: 166635 RVA: 0x00B6A41A File Offset: 0x00B6861A
		public int FormationIndex { get; set; }

		// Token: 0x170052A8 RID: 21160
		// (get) Token: 0x06028AEC RID: 166636 RVA: 0x00B6A423 File Offset: 0x00B68623
		// (set) Token: 0x06028AED RID: 166637 RVA: 0x00B6A42B File Offset: 0x00B6862B
		public bool IsLinkOn { get; set; }
	}
}
