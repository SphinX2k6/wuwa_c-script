using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004ED0 RID: 20176
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleMapFetterTabInfo : IRogueBattleMapFetterTabInfo
	{
		// Token: 0x17007F0F RID: 32527
		// (get) Token: 0x06033CB3 RID: 212147 RVA: 0x00C20FF1 File Offset: 0x00C1F1F1
		// (set) Token: 0x06033CB4 RID: 212148 RVA: 0x00C20FF9 File Offset: 0x00C1F1F9
		public bool IsSelected { get; set; }

		// Token: 0x17007F10 RID: 32528
		// (get) Token: 0x06033CB5 RID: 212149 RVA: 0x00C21002 File Offset: 0x00C1F202
		// (set) Token: 0x06033CB6 RID: 212150 RVA: 0x00C2100A File Offset: 0x00C1F20A
		public List<int> Config { get; set; } = new List<int>();
	}
}
