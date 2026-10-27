using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004ED6 RID: 20182
	[NullableContext(1)]
	public interface IRogueBattleEnvironmentInfo
	{
		// Token: 0x17007F1F RID: 32543
		// (get) Token: 0x06033CD6 RID: 212182
		// (set) Token: 0x06033CD7 RID: 212183
		string Icon { get; set; }

		// Token: 0x17007F20 RID: 32544
		// (get) Token: 0x06033CD8 RID: 212184
		// (set) Token: 0x06033CD9 RID: 212185
		string TextId { get; set; }

		// Token: 0x17007F21 RID: 32545
		// (get) Token: 0x06033CDA RID: 212186
		// (set) Token: 0x06033CDB RID: 212187
		List<string> Param { get; set; }
	}
}
