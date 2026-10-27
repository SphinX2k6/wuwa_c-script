using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200498C RID: 18828
	public class ICheckBvbActivityRankT
	{
		// Token: 0x17008801 RID: 34817
		// (get) Token: 0x0601D5BE RID: 120254 RVA: 0x00423AB2 File Offset: 0x00421CB2
		// (set) Token: 0x0601D5BF RID: 120255 RVA: 0x00423ABA File Offset: 0x00421CBA
		public ECondition Type { get; set; }

		// Token: 0x17008802 RID: 34818
		// (get) Token: 0x0601D5C0 RID: 120256 RVA: 0x00423AC3 File Offset: 0x00421CC3
		// (set) Token: 0x0601D5C1 RID: 120257 RVA: 0x00423ACB File Offset: 0x00421CCB
		public ECompare Compare { get; set; }

		// Token: 0x17008803 RID: 34819
		// (get) Token: 0x0601D5C2 RID: 120258 RVA: 0x00423AD4 File Offset: 0x00421CD4
		// (set) Token: 0x0601D5C3 RID: 120259 RVA: 0x00423ADC File Offset: 0x00421CDC
		public int Rank { get; set; }

		// Token: 0x0601D5C4 RID: 120260 RVA: 0x00423AE5 File Offset: 0x00421CE5
		public ICheckBvbActivityRankT()
		{
			this.Type = ECondition.CompareVar;
			this.Compare = ECompare.Eq;
			this.Rank = 0;
		}
	}
}
