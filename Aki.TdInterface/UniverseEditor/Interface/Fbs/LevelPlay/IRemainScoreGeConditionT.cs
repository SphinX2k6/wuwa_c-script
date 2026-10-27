using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004540 RID: 17728
	public class IRemainScoreGeConditionT
	{
		// Token: 0x17007DBD RID: 32189
		// (get) Token: 0x0601AAAD RID: 109229 RVA: 0x003CDF0C File Offset: 0x003CC10C
		// (set) Token: 0x0601AAAE RID: 109230 RVA: 0x003CDF14 File Offset: 0x003CC114
		public EDartSkillConditionType Type { get; set; }

		// Token: 0x17007DBE RID: 32190
		// (get) Token: 0x0601AAAF RID: 109231 RVA: 0x003CDF1D File Offset: 0x003CC11D
		// (set) Token: 0x0601AAB0 RID: 109232 RVA: 0x003CDF25 File Offset: 0x003CC125
		public int Score { get; set; }

		// Token: 0x0601AAB1 RID: 109233 RVA: 0x003CDF2E File Offset: 0x003CC12E
		public IRemainScoreGeConditionT()
		{
			this.Type = EDartSkillConditionType.RemainScoreGe;
			this.Score = 0;
		}
	}
}
