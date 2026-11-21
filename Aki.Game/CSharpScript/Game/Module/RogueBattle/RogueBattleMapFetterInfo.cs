using System;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E9B RID: 16027
	public class RogueBattleMapFetterInfo : IRogueBattleMapFetterInfo
	{
		// Token: 0x170052C4 RID: 21188
		// (get) Token: 0x06028B29 RID: 166697 RVA: 0x00B6A53E File Offset: 0x00B6873E
		// (set) Token: 0x06028B2A RID: 166698 RVA: 0x00B6A546 File Offset: 0x00B68746
		public int ConfigId { get; set; }

		// Token: 0x170052C5 RID: 21189
		// (get) Token: 0x06028B2B RID: 166699 RVA: 0x00B6A54F File Offset: 0x00B6874F
		// (set) Token: 0x06028B2C RID: 166700 RVA: 0x00B6A557 File Offset: 0x00B68757
		public int Level { get; set; }

		// Token: 0x170052C6 RID: 21190
		// (get) Token: 0x06028B2D RID: 166701 RVA: 0x00B6A560 File Offset: 0x00B68760
		// (set) Token: 0x06028B2E RID: 166702 RVA: 0x00B6A568 File Offset: 0x00B68768
		public bool IsReached { get; set; }
	}
}
