using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004ECD RID: 20173
	[NullableContext(1)]
	public interface IRogueBattleRoleAffixDetailOpenParam
	{
		// Token: 0x17007F07 RID: 32519
		// (get) Token: 0x06033CA2 RID: 212130
		// (set) Token: 0x06033CA3 RID: 212131
		int Index { get; set; }

		// Token: 0x17007F08 RID: 32520
		// (get) Token: 0x06033CA4 RID: 212132
		// (set) Token: 0x06033CA5 RID: 212133
		List<int> AffixIds { get; set; }

		// Token: 0x17007F09 RID: 32521
		// (get) Token: 0x06033CA6 RID: 212134
		// (set) Token: 0x06033CA7 RID: 212135
		int RoleId { get; set; }
	}
}
