using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004933 RID: 18739
	public class IFirstRoundsConditionT
	{
		// Token: 0x1700828E RID: 33422
		// (get) Token: 0x0601BCF7 RID: 113911 RVA: 0x003EE374 File Offset: 0x003EC574
		// (set) Token: 0x0601BCF8 RID: 113912 RVA: 0x003EE37C File Offset: 0x003EC57C
		public EDartSkillConditionType Type { get; set; }

		// Token: 0x1700828F RID: 33423
		// (get) Token: 0x0601BCF9 RID: 113913 RVA: 0x003EE385 File Offset: 0x003EC585
		// (set) Token: 0x0601BCFA RID: 113914 RVA: 0x003EE38D File Offset: 0x003EC58D
		public int Round { get; set; }

		// Token: 0x0601BCFB RID: 113915 RVA: 0x003EE396 File Offset: 0x003EC596
		public IFirstRoundsConditionT()
		{
			this.Type = EDartSkillConditionType.RemainScoreGe;
			this.Round = 0;
		}
	}
}
