using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004ECF RID: 20175
	[NullableContext(1)]
	public interface IRogueBattleMapFetterTabInfo
	{
		// Token: 0x17007F0D RID: 32525
		// (get) Token: 0x06033CAF RID: 212143
		// (set) Token: 0x06033CB0 RID: 212144
		bool IsSelected { get; set; }

		// Token: 0x17007F0E RID: 32526
		// (get) Token: 0x06033CB1 RID: 212145
		// (set) Token: 0x06033CB2 RID: 212146
		List<int> Config { get; set; }
	}
}
