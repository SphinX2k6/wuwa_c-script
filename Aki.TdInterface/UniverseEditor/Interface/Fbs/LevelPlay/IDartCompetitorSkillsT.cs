using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200446E RID: 17518
	public class IDartCompetitorSkillsT
	{
		// Token: 0x17007BA2 RID: 31650
		// (get) Token: 0x0601A1C8 RID: 106952 RVA: 0x003BB09E File Offset: 0x003B929E
		// (set) Token: 0x0601A1C9 RID: 106953 RVA: 0x003BB0A6 File Offset: 0x003B92A6
		public int Mode301Skill { get; set; }

		// Token: 0x17007BA3 RID: 31651
		// (get) Token: 0x0601A1CA RID: 106954 RVA: 0x003BB0AF File Offset: 0x003B92AF
		// (set) Token: 0x0601A1CB RID: 106955 RVA: 0x003BB0B7 File Offset: 0x003B92B7
		public int Mode501Skill { get; set; }

		// Token: 0x17007BA4 RID: 31652
		// (get) Token: 0x0601A1CC RID: 106956 RVA: 0x003BB0C0 File Offset: 0x003B92C0
		// (set) Token: 0x0601A1CD RID: 106957 RVA: 0x003BB0C8 File Offset: 0x003B92C8
		public int Mode701Skill { get; set; }

		// Token: 0x0601A1CE RID: 106958 RVA: 0x003BB0D1 File Offset: 0x003B92D1
		public IDartCompetitorSkillsT()
		{
			this.Mode301Skill = 0;
			this.Mode501Skill = 0;
			this.Mode701Skill = 0;
		}
	}
}
