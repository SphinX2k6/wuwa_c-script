using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004945 RID: 18757
	public class IHoldBreathResultT
	{
		// Token: 0x170082AE RID: 33454
		// (get) Token: 0x0601BD8D RID: 114061 RVA: 0x003EF44A File Offset: 0x003ED64A
		// (set) Token: 0x0601BD8E RID: 114062 RVA: 0x003EF452 File Offset: 0x003ED652
		public EDartSkillResultType Type { get; set; }

		// Token: 0x170082AF RID: 33455
		// (get) Token: 0x0601BD8F RID: 114063 RVA: 0x003EF45B File Offset: 0x003ED65B
		// (set) Token: 0x0601BD90 RID: 114064 RVA: 0x003EF463 File Offset: 0x003ED663
		public int Probability { get; set; }

		// Token: 0x170082B0 RID: 33456
		// (get) Token: 0x0601BD91 RID: 114065 RVA: 0x003EF46C File Offset: 0x003ED66C
		// (set) Token: 0x0601BD92 RID: 114066 RVA: 0x003EF474 File Offset: 0x003ED674
		public int SpeedReducePercent { get; set; }

		// Token: 0x0601BD93 RID: 114067 RVA: 0x003EF47D File Offset: 0x003ED67D
		public IHoldBreathResultT()
		{
			this.Type = EDartSkillResultType.NoBust;
			this.Probability = 0;
			this.SpeedReducePercent = 0;
		}
	}
}
