using System;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E9A RID: 16026
	public interface IRogueBattleMapFetterInfo
	{
		// Token: 0x170052C1 RID: 21185
		// (get) Token: 0x06028B23 RID: 166691
		// (set) Token: 0x06028B24 RID: 166692
		int ConfigId { get; set; }

		// Token: 0x170052C2 RID: 21186
		// (get) Token: 0x06028B25 RID: 166693
		// (set) Token: 0x06028B26 RID: 166694
		int Level { get; set; }

		// Token: 0x170052C3 RID: 21187
		// (get) Token: 0x06028B27 RID: 166695
		// (set) Token: 0x06028B28 RID: 166696
		bool IsReached { get; set; }
	}
}
