using System;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02004CD3 RID: 19667
	public class RoleDevSkillSlotItemData : IRoleDevSkillSlotItemData
	{
		// Token: 0x17007D82 RID: 32130
		// (get) Token: 0x06032C51 RID: 207953 RVA: 0x00BD5471 File Offset: 0x00BD3671
		// (set) Token: 0x06032C52 RID: 207954 RVA: 0x00BD5479 File Offset: 0x00BD3679
		public int RoleId { get; set; }

		// Token: 0x17007D83 RID: 32131
		// (get) Token: 0x06032C53 RID: 207955 RVA: 0x00BD5482 File Offset: 0x00BD3682
		// (set) Token: 0x06032C54 RID: 207956 RVA: 0x00BD548A File Offset: 0x00BD368A
		public int SkillNodeId { get; set; }

		// Token: 0x17007D84 RID: 32132
		// (get) Token: 0x06032C55 RID: 207957 RVA: 0x00BD5493 File Offset: 0x00BD3693
		// (set) Token: 0x06032C56 RID: 207958 RVA: 0x00BD549B File Offset: 0x00BD369B
		public int CurrentLevel { get; set; }

		// Token: 0x17007D85 RID: 32133
		// (get) Token: 0x06032C57 RID: 207959 RVA: 0x00BD54A4 File Offset: 0x00BD36A4
		// (set) Token: 0x06032C58 RID: 207960 RVA: 0x00BD54AC File Offset: 0x00BD36AC
		public int NormalTargetLevel { get; set; }

		// Token: 0x17007D86 RID: 32134
		// (get) Token: 0x06032C59 RID: 207961 RVA: 0x00BD54B5 File Offset: 0x00BD36B5
		// (set) Token: 0x06032C5A RID: 207962 RVA: 0x00BD54BD File Offset: 0x00BD36BD
		public int PerfectTargetLevel { get; set; }
	}
}
