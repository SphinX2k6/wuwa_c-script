using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A14 RID: 18964
	public class IRoundIndexConditionT
	{
		// Token: 0x17008506 RID: 34054
		// (get) Token: 0x0601C74A RID: 116554 RVA: 0x00404BCC File Offset: 0x00402DCC
		// (set) Token: 0x0601C74B RID: 116555 RVA: 0x00404BD4 File Offset: 0x00402DD4
		public EDartSkillConditionType Type { get; set; }

		// Token: 0x17008507 RID: 34055
		// (get) Token: 0x0601C74C RID: 116556 RVA: 0x00404BDD File Offset: 0x00402DDD
		// (set) Token: 0x0601C74D RID: 116557 RVA: 0x00404BE5 File Offset: 0x00402DE5
		public int Round { get; set; }

		// Token: 0x0601C74E RID: 116558 RVA: 0x00404BEE File Offset: 0x00402DEE
		public IRoundIndexConditionT()
		{
			this.Type = EDartSkillConditionType.RemainScoreGe;
			this.Round = 0;
		}
	}
}
