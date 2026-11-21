using System;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02003CDE RID: 15582
	public class RoleDevelopSkillData : IRoleDevelopSkillData
	{
		// Token: 0x170051EA RID: 20970
		// (get) Token: 0x06027E69 RID: 163433 RVA: 0x00B2770F File Offset: 0x00B2590F
		// (set) Token: 0x06027E6A RID: 163434 RVA: 0x00B27717 File Offset: 0x00B25917
		public int RoleId { get; set; }

		// Token: 0x170051EB RID: 20971
		// (get) Token: 0x06027E6B RID: 163435 RVA: 0x00B27720 File Offset: 0x00B25920
		// (set) Token: 0x06027E6C RID: 163436 RVA: 0x00B27728 File Offset: 0x00B25928
		public int SkillNodeId { get; set; }

		// Token: 0x170051EC RID: 20972
		// (get) Token: 0x06027E6D RID: 163437 RVA: 0x00B27731 File Offset: 0x00B25931
		// (set) Token: 0x06027E6E RID: 163438 RVA: 0x00B27739 File Offset: 0x00B25939
		public int CurrentLevel { get; set; }

		// Token: 0x170051ED RID: 20973
		// (get) Token: 0x06027E6F RID: 163439 RVA: 0x00B27742 File Offset: 0x00B25942
		// (set) Token: 0x06027E70 RID: 163440 RVA: 0x00B2774A File Offset: 0x00B2594A
		public int TargetLevel { get; set; }

		// Token: 0x170051EE RID: 20974
		// (get) Token: 0x06027E71 RID: 163441 RVA: 0x00B27753 File Offset: 0x00B25953
		// (set) Token: 0x06027E72 RID: 163442 RVA: 0x00B2775B File Offset: 0x00B2595B
		public int Index { get; set; }
	}
}
