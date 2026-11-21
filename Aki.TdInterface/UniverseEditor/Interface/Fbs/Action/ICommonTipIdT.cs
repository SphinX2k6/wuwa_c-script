using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B0A RID: 27402
	public class ICommonTipIdT
	{
		// Token: 0x1700C93D RID: 51517
		// (get) Token: 0x0602F1D0 RID: 192976 RVA: 0x0066CDF0 File Offset: 0x0066AFF0
		// (set) Token: 0x0602F1D1 RID: 192977 RVA: 0x0066CDF8 File Offset: 0x0066AFF8
		public ECommonTipType Type { get; set; }

		// Token: 0x1700C93E RID: 51518
		// (get) Token: 0x0602F1D2 RID: 192978 RVA: 0x0066CE01 File Offset: 0x0066B001
		// (set) Token: 0x0602F1D3 RID: 192979 RVA: 0x0066CE09 File Offset: 0x0066B009
		public int Id { get; set; }

		// Token: 0x0602F1D4 RID: 192980 RVA: 0x0066CE12 File Offset: 0x0066B012
		public ICommonTipIdT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.Id = 0;
		}
	}
}
