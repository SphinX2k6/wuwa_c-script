using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E97 RID: 16023
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleRoleAffixDetailOpenParam : IRogueBattleRoleAffixDetailOpenParam
	{
		// Token: 0x170052BA RID: 21178
		// (get) Token: 0x06028B13 RID: 166675 RVA: 0x00B6A4C3 File Offset: 0x00B686C3
		// (set) Token: 0x06028B14 RID: 166676 RVA: 0x00B6A4CB File Offset: 0x00B686CB
		public int Index { get; set; }

		// Token: 0x170052BB RID: 21179
		// (get) Token: 0x06028B15 RID: 166677 RVA: 0x00B6A4D4 File Offset: 0x00B686D4
		// (set) Token: 0x06028B16 RID: 166678 RVA: 0x00B6A4DC File Offset: 0x00B686DC
		public List<int> AffixIds { get; set; } = new List<int>();

		// Token: 0x170052BC RID: 21180
		// (get) Token: 0x06028B17 RID: 166679 RVA: 0x00B6A4E5 File Offset: 0x00B686E5
		// (set) Token: 0x06028B18 RID: 166680 RVA: 0x00B6A4ED File Offset: 0x00B686ED
		public int RoleId { get; set; }
	}
}
