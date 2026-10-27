using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007242 RID: 29250
	public class ISunSpiritDifficultyReductionT
	{
		// Token: 0x1700D90A RID: 55562
		// (get) Token: 0x06033E14 RID: 212500 RVA: 0x006FAB80 File Offset: 0x006F8D80
		// (set) Token: 0x06033E15 RID: 212501 RVA: 0x006FAB88 File Offset: 0x006F8D88
		public int LoseTimes { get; set; }

		// Token: 0x1700D90B RID: 55563
		// (get) Token: 0x06033E16 RID: 212502 RVA: 0x006FAB91 File Offset: 0x006F8D91
		// (set) Token: 0x06033E17 RID: 212503 RVA: 0x006FAB99 File Offset: 0x006F8D99
		public int SubstituteId { get; set; }

		// Token: 0x06033E18 RID: 212504 RVA: 0x006FABA2 File Offset: 0x006F8DA2
		public ISunSpiritDifficultyReductionT()
		{
			this.LoseTimes = 0;
			this.SubstituteId = 0;
		}
	}
}
