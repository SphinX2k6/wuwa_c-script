using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A40 RID: 14912
	public class IBvbCardFilterCompareCostT
	{
		// Token: 0x17006630 RID: 26160
		// (get) Token: 0x060142F2 RID: 82674 RVA: 0x002F347A File Offset: 0x002F167A
		// (set) Token: 0x060142F3 RID: 82675 RVA: 0x002F3482 File Offset: 0x002F1682
		public EBvbCardFilterType Type { get; set; }

		// Token: 0x17006631 RID: 26161
		// (get) Token: 0x060142F4 RID: 82676 RVA: 0x002F348B File Offset: 0x002F168B
		// (set) Token: 0x060142F5 RID: 82677 RVA: 0x002F3493 File Offset: 0x002F1693
		public EVarCompare CompareType { get; set; }

		// Token: 0x17006632 RID: 26162
		// (get) Token: 0x060142F6 RID: 82678 RVA: 0x002F349C File Offset: 0x002F169C
		// (set) Token: 0x060142F7 RID: 82679 RVA: 0x002F34A4 File Offset: 0x002F16A4
		public int Cost { get; set; }

		// Token: 0x060142F8 RID: 82680 RVA: 0x002F34AD File Offset: 0x002F16AD
		public IBvbCardFilterCompareCostT()
		{
			this.Type = EBvbCardFilterType.CompareCost;
			this.CompareType = EVarCompare.Eq;
			this.Cost = 0;
		}
	}
}
