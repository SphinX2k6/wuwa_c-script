using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E99 RID: 16025
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleMapFetterTabInfo : IRogueBattleMapFetterTabInfo
	{
		// Token: 0x170052BF RID: 21183
		// (get) Token: 0x06028B1E RID: 166686 RVA: 0x00B6A509 File Offset: 0x00B68709
		// (set) Token: 0x06028B1F RID: 166687 RVA: 0x00B6A511 File Offset: 0x00B68711
		public bool IsSelected { get; set; }

		// Token: 0x170052C0 RID: 21184
		// (get) Token: 0x06028B20 RID: 166688 RVA: 0x00B6A51A File Offset: 0x00B6871A
		// (set) Token: 0x06028B21 RID: 166689 RVA: 0x00B6A522 File Offset: 0x00B68722
		public List<int> Config { get; set; } = new List<int>();
	}
}
