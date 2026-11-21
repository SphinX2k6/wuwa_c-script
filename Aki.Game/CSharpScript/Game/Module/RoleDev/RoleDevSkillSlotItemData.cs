using System;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02003C84 RID: 15492
	public class RoleDevSkillSlotItemData : IRoleDevSkillSlotItemData
	{
		// Token: 0x1700512C RID: 20780
		// (get) Token: 0x06027A05 RID: 162309 RVA: 0x00B1A209 File Offset: 0x00B18409
		// (set) Token: 0x06027A06 RID: 162310 RVA: 0x00B1A211 File Offset: 0x00B18411
		public int RoleId { get; set; }

		// Token: 0x1700512D RID: 20781
		// (get) Token: 0x06027A07 RID: 162311 RVA: 0x00B1A21A File Offset: 0x00B1841A
		// (set) Token: 0x06027A08 RID: 162312 RVA: 0x00B1A222 File Offset: 0x00B18422
		public int SkillNodeId { get; set; }

		// Token: 0x1700512E RID: 20782
		// (get) Token: 0x06027A09 RID: 162313 RVA: 0x00B1A22B File Offset: 0x00B1842B
		// (set) Token: 0x06027A0A RID: 162314 RVA: 0x00B1A233 File Offset: 0x00B18433
		public int CurrentLevel { get; set; }

		// Token: 0x1700512F RID: 20783
		// (get) Token: 0x06027A0B RID: 162315 RVA: 0x00B1A23C File Offset: 0x00B1843C
		// (set) Token: 0x06027A0C RID: 162316 RVA: 0x00B1A244 File Offset: 0x00B18444
		public int NormalTargetLevel { get; set; }

		// Token: 0x17005130 RID: 20784
		// (get) Token: 0x06027A0D RID: 162317 RVA: 0x00B1A24D File Offset: 0x00B1844D
		// (set) Token: 0x06027A0E RID: 162318 RVA: 0x00B1A255 File Offset: 0x00B18455
		public int PerfectTargetLevel { get; set; }
	}
}
