using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D5D RID: 15709
	[NullableContext(1)]
	public interface IRoguelikeRoleAffixDetailViewParam
	{
		// Token: 0x17005242 RID: 21058
		// (get) Token: 0x0602836E RID: 164718
		// (set) Token: 0x0602836F RID: 164719
		int Index { get; set; }

		// Token: 0x17005243 RID: 21059
		// (get) Token: 0x06028370 RID: 164720
		// (set) Token: 0x06028371 RID: 164721
		List<int> AffixIds { get; set; }
	}
}
