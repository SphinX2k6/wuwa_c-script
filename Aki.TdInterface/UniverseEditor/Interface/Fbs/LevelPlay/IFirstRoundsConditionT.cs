using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044CB RID: 17611
	public class IFirstRoundsConditionT
	{
		// Token: 0x17007C4F RID: 31823
		// (get) Token: 0x0601A526 RID: 107814 RVA: 0x003C2168 File Offset: 0x003C0368
		// (set) Token: 0x0601A527 RID: 107815 RVA: 0x003C2170 File Offset: 0x003C0370
		public EDartSkillConditionType Type { get; set; }

		// Token: 0x17007C50 RID: 31824
		// (get) Token: 0x0601A528 RID: 107816 RVA: 0x003C2179 File Offset: 0x003C0379
		// (set) Token: 0x0601A529 RID: 107817 RVA: 0x003C2181 File Offset: 0x003C0381
		public int Round { get; set; }

		// Token: 0x0601A52A RID: 107818 RVA: 0x003C218A File Offset: 0x003C038A
		public IFirstRoundsConditionT()
		{
			this.Type = EDartSkillConditionType.RemainScoreGe;
			this.Round = 0;
		}
	}
}
