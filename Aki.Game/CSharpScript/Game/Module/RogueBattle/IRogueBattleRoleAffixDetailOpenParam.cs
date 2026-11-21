using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E96 RID: 16022
	[NullableContext(1)]
	public interface IRogueBattleRoleAffixDetailOpenParam
	{
		// Token: 0x170052B7 RID: 21175
		// (get) Token: 0x06028B0D RID: 166669
		// (set) Token: 0x06028B0E RID: 166670
		int Index { get; set; }

		// Token: 0x170052B8 RID: 21176
		// (get) Token: 0x06028B0F RID: 166671
		// (set) Token: 0x06028B10 RID: 166672
		List<int> AffixIds { get; set; }

		// Token: 0x170052B9 RID: 21177
		// (get) Token: 0x06028B11 RID: 166673
		// (set) Token: 0x06028B12 RID: 166674
		int RoleId { get; set; }
	}
}
