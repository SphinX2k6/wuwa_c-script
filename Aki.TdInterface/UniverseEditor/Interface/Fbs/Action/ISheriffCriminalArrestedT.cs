using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200788E RID: 30862
	public class ISheriffCriminalArrestedT
	{
		// Token: 0x1700E254 RID: 57940
		// (get) Token: 0x060364B0 RID: 222384 RVA: 0x00745690 File Offset: 0x00743890
		// (set) Token: 0x060364B1 RID: 222385 RVA: 0x00745698 File Offset: 0x00743898
		public ECommonTipType Type { get; set; }

		// Token: 0x1700E255 RID: 57941
		// (get) Token: 0x060364B2 RID: 222386 RVA: 0x007456A1 File Offset: 0x007438A1
		// (set) Token: 0x060364B3 RID: 222387 RVA: 0x007456A9 File Offset: 0x007438A9
		public int Id { get; set; }

		// Token: 0x060364B4 RID: 222388 RVA: 0x007456B2 File Offset: 0x007438B2
		public ISheriffCriminalArrestedT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.Id = 0;
		}
	}
}
