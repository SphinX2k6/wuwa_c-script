using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E1B RID: 15899
	public class IBvbCardFilterCompareCostT
	{
		// Token: 0x17006B60 RID: 27488
		// (get) Token: 0x0601560E RID: 87566 RVA: 0x00316666 File Offset: 0x00314866
		// (set) Token: 0x0601560F RID: 87567 RVA: 0x0031666E File Offset: 0x0031486E
		public EBvbCardFilterType Type { get; set; }

		// Token: 0x17006B61 RID: 27489
		// (get) Token: 0x06015610 RID: 87568 RVA: 0x00316677 File Offset: 0x00314877
		// (set) Token: 0x06015611 RID: 87569 RVA: 0x0031667F File Offset: 0x0031487F
		public EVarCompare CompareType { get; set; }

		// Token: 0x17006B62 RID: 27490
		// (get) Token: 0x06015612 RID: 87570 RVA: 0x00316688 File Offset: 0x00314888
		// (set) Token: 0x06015613 RID: 87571 RVA: 0x00316690 File Offset: 0x00314890
		public int Cost { get; set; }

		// Token: 0x06015614 RID: 87572 RVA: 0x00316699 File Offset: 0x00314899
		public IBvbCardFilterCompareCostT()
		{
			this.Type = EBvbCardFilterType.CompareCost;
			this.CompareType = EVarCompare.Eq;
			this.Cost = 0;
		}
	}
}
