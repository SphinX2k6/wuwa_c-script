using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E91 RID: 20113
	public class ICheckDollGrabShowcaseItemComboAchievedT
	{
		// Token: 0x17008F74 RID: 36724
		// (get) Token: 0x0601F29F RID: 127647 RVA: 0x00458AF8 File Offset: 0x00456CF8
		// (set) Token: 0x0601F2A0 RID: 127648 RVA: 0x00458B00 File Offset: 0x00456D00
		public ECondition Type { get; set; }

		// Token: 0x17008F75 RID: 36725
		// (get) Token: 0x0601F2A1 RID: 127649 RVA: 0x00458B09 File Offset: 0x00456D09
		// (set) Token: 0x0601F2A2 RID: 127650 RVA: 0x00458B11 File Offset: 0x00456D11
		public int ShowcaseEntityId { get; set; }

		// Token: 0x17008F76 RID: 36726
		// (get) Token: 0x0601F2A3 RID: 127651 RVA: 0x00458B1A File Offset: 0x00456D1A
		// (set) Token: 0x0601F2A4 RID: 127652 RVA: 0x00458B22 File Offset: 0x00456D22
		public ECompare Compare { get; set; }

		// Token: 0x17008F77 RID: 36727
		// (get) Token: 0x0601F2A5 RID: 127653 RVA: 0x00458B2B File Offset: 0x00456D2B
		// (set) Token: 0x0601F2A6 RID: 127654 RVA: 0x00458B33 File Offset: 0x00456D33
		public int Count { get; set; }

		// Token: 0x0601F2A7 RID: 127655 RVA: 0x00458B3C File Offset: 0x00456D3C
		public ICheckDollGrabShowcaseItemComboAchievedT()
		{
			this.Type = ECondition.CompareVar;
			this.ShowcaseEntityId = 0;
			this.Compare = ECompare.Eq;
			this.Count = 0;
		}
	}
}
