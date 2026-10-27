using System;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004ED1 RID: 20177
	public interface IRogueBattleMapFetterInfo
	{
		// Token: 0x17007F11 RID: 32529
		// (get) Token: 0x06033CB8 RID: 212152
		// (set) Token: 0x06033CB9 RID: 212153
		int ConfigId { get; set; }

		// Token: 0x17007F12 RID: 32530
		// (get) Token: 0x06033CBA RID: 212154
		// (set) Token: 0x06033CBB RID: 212155
		int Level { get; set; }

		// Token: 0x17007F13 RID: 32531
		// (get) Token: 0x06033CBC RID: 212156
		// (set) Token: 0x06033CBD RID: 212157
		bool IsReached { get; set; }
	}
}
