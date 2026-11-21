using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A17 RID: 31255
	public class ISunSpiritDifficultyReductionT
	{
		// Token: 0x1700E503 RID: 58627
		// (get) Token: 0x06037116 RID: 225558 RVA: 0x0075BEE0 File Offset: 0x0075A0E0
		// (set) Token: 0x06037117 RID: 225559 RVA: 0x0075BEE8 File Offset: 0x0075A0E8
		public int LoseTimes { get; set; }

		// Token: 0x1700E504 RID: 58628
		// (get) Token: 0x06037118 RID: 225560 RVA: 0x0075BEF1 File Offset: 0x0075A0F1
		// (set) Token: 0x06037119 RID: 225561 RVA: 0x0075BEF9 File Offset: 0x0075A0F9
		public int SubstituteId { get; set; }

		// Token: 0x0603711A RID: 225562 RVA: 0x0075BF02 File Offset: 0x0075A102
		public ISunSpiritDifficultyReductionT()
		{
			this.LoseTimes = 0;
			this.SubstituteId = 0;
		}
	}
}
