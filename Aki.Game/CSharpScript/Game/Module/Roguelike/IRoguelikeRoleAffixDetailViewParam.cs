using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004D94 RID: 19860
	[NullableContext(1)]
	public interface IRoguelikeRoleAffixDetailViewParam
	{
		// Token: 0x17007E92 RID: 32402
		// (get) Token: 0x06033501 RID: 210177
		// (set) Token: 0x06033502 RID: 210178
		int Index { get; set; }

		// Token: 0x17007E93 RID: 32403
		// (get) Token: 0x06033503 RID: 210179
		// (set) Token: 0x06033504 RID: 210180
		List<int> AffixIds { get; set; }
	}
}
