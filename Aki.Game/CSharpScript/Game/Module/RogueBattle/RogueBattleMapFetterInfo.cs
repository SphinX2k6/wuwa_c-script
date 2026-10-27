using System;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004ED2 RID: 20178
	public class RogueBattleMapFetterInfo : IRogueBattleMapFetterInfo
	{
		// Token: 0x17007F14 RID: 32532
		// (get) Token: 0x06033CBE RID: 212158 RVA: 0x00C21026 File Offset: 0x00C1F226
		// (set) Token: 0x06033CBF RID: 212159 RVA: 0x00C2102E File Offset: 0x00C1F22E
		public int ConfigId { get; set; }

		// Token: 0x17007F15 RID: 32533
		// (get) Token: 0x06033CC0 RID: 212160 RVA: 0x00C21037 File Offset: 0x00C1F237
		// (set) Token: 0x06033CC1 RID: 212161 RVA: 0x00C2103F File Offset: 0x00C1F23F
		public int Level { get; set; }

		// Token: 0x17007F16 RID: 32534
		// (get) Token: 0x06033CC2 RID: 212162 RVA: 0x00C21048 File Offset: 0x00C1F248
		// (set) Token: 0x06033CC3 RID: 212163 RVA: 0x00C21050 File Offset: 0x00C1F250
		public bool IsReached { get; set; }
	}
}
