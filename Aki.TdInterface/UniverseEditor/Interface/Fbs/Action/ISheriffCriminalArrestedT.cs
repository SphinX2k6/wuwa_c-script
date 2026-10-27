using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070C2 RID: 28866
	public class ISheriffCriminalArrestedT
	{
		// Token: 0x1700D671 RID: 54897
		// (get) Token: 0x0603320E RID: 209422 RVA: 0x006E5084 File Offset: 0x006E3284
		// (set) Token: 0x0603320F RID: 209423 RVA: 0x006E508C File Offset: 0x006E328C
		public ECommonTipType Type { get; set; }

		// Token: 0x1700D672 RID: 54898
		// (get) Token: 0x06033210 RID: 209424 RVA: 0x006E5095 File Offset: 0x006E3295
		// (set) Token: 0x06033211 RID: 209425 RVA: 0x006E509D File Offset: 0x006E329D
		public int Id { get; set; }

		// Token: 0x06033212 RID: 209426 RVA: 0x006E50A6 File Offset: 0x006E32A6
		public ISheriffCriminalArrestedT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.Id = 0;
		}
	}
}
