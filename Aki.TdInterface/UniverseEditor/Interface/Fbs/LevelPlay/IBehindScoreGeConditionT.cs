using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048A0 RID: 18592
	public class IBehindScoreGeConditionT
	{
		// Token: 0x1700814D RID: 33101
		// (get) Token: 0x0601B781 RID: 112513 RVA: 0x003E3160 File Offset: 0x003E1360
		// (set) Token: 0x0601B782 RID: 112514 RVA: 0x003E3168 File Offset: 0x003E1368
		public EDartSkillConditionType Type { get; set; }

		// Token: 0x1700814E RID: 33102
		// (get) Token: 0x0601B783 RID: 112515 RVA: 0x003E3171 File Offset: 0x003E1371
		// (set) Token: 0x0601B784 RID: 112516 RVA: 0x003E3179 File Offset: 0x003E1379
		public int Score { get; set; }

		// Token: 0x0601B785 RID: 112517 RVA: 0x003E3182 File Offset: 0x003E1382
		public IBehindScoreGeConditionT()
		{
			this.Type = EDartSkillConditionType.RemainScoreGe;
			this.Score = 0;
		}
	}
}
