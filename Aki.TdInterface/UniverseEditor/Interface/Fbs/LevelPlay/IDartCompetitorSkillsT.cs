using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048D6 RID: 18646
	public class IDartCompetitorSkillsT
	{
		// Token: 0x170081E1 RID: 33249
		// (get) Token: 0x0601B999 RID: 113049 RVA: 0x003E72AA File Offset: 0x003E54AA
		// (set) Token: 0x0601B99A RID: 113050 RVA: 0x003E72B2 File Offset: 0x003E54B2
		public int Mode301Skill { get; set; }

		// Token: 0x170081E2 RID: 33250
		// (get) Token: 0x0601B99B RID: 113051 RVA: 0x003E72BB File Offset: 0x003E54BB
		// (set) Token: 0x0601B99C RID: 113052 RVA: 0x003E72C3 File Offset: 0x003E54C3
		public int Mode501Skill { get; set; }

		// Token: 0x170081E3 RID: 33251
		// (get) Token: 0x0601B99D RID: 113053 RVA: 0x003E72CC File Offset: 0x003E54CC
		// (set) Token: 0x0601B99E RID: 113054 RVA: 0x003E72D4 File Offset: 0x003E54D4
		public int Mode701Skill { get; set; }

		// Token: 0x0601B99F RID: 113055 RVA: 0x003E72DD File Offset: 0x003E54DD
		public IDartCompetitorSkillsT()
		{
			this.Mode301Skill = 0;
			this.Mode501Skill = 0;
			this.Mode701Skill = 0;
		}
	}
}
