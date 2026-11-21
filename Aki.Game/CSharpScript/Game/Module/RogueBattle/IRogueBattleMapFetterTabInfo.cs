using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E98 RID: 16024
	[NullableContext(1)]
	public interface IRogueBattleMapFetterTabInfo
	{
		// Token: 0x170052BD RID: 21181
		// (get) Token: 0x06028B1A RID: 166682
		// (set) Token: 0x06028B1B RID: 166683
		bool IsSelected { get; set; }

		// Token: 0x170052BE RID: 21182
		// (get) Token: 0x06028B1C RID: 166684
		// (set) Token: 0x06028B1D RID: 166685
		List<int> Config { get; set; }
	}
}
