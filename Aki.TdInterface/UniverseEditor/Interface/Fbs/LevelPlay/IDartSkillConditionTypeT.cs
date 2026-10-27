using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004486 RID: 17542
	public class IDartSkillConditionTypeT
	{
		// Token: 0x17007BCF RID: 31695
		// (get) Token: 0x0601A29A RID: 107162 RVA: 0x003BCCCA File Offset: 0x003BAECA
		// (set) Token: 0x0601A29B RID: 107163 RVA: 0x003BCCD2 File Offset: 0x003BAED2
		public EDartSkillConditionType Type { get; set; }

		// Token: 0x0601A29C RID: 107164 RVA: 0x003BCCDB File Offset: 0x003BAEDB
		public IDartSkillConditionTypeT()
		{
			this.Type = EDartSkillConditionType.RemainScoreGe;
		}
	}
}
