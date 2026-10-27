using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044DD RID: 17629
	public class IHoldBreathResultT
	{
		// Token: 0x17007C6F RID: 31855
		// (get) Token: 0x0601A5BC RID: 107964 RVA: 0x003C323E File Offset: 0x003C143E
		// (set) Token: 0x0601A5BD RID: 107965 RVA: 0x003C3246 File Offset: 0x003C1446
		public EDartSkillResultType Type { get; set; }

		// Token: 0x17007C70 RID: 31856
		// (get) Token: 0x0601A5BE RID: 107966 RVA: 0x003C324F File Offset: 0x003C144F
		// (set) Token: 0x0601A5BF RID: 107967 RVA: 0x003C3257 File Offset: 0x003C1457
		public int Probability { get; set; }

		// Token: 0x17007C71 RID: 31857
		// (get) Token: 0x0601A5C0 RID: 107968 RVA: 0x003C3260 File Offset: 0x003C1460
		// (set) Token: 0x0601A5C1 RID: 107969 RVA: 0x003C3268 File Offset: 0x003C1468
		public int SpeedReducePercent { get; set; }

		// Token: 0x0601A5C2 RID: 107970 RVA: 0x003C3271 File Offset: 0x003C1471
		public IHoldBreathResultT()
		{
			this.Type = EDartSkillResultType.NoBust;
			this.Probability = 0;
			this.SpeedReducePercent = 0;
		}
	}
}
