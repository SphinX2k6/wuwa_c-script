using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A3D RID: 14909
	public class IBvbCardFilterCompareCardTypeT
	{
		// Token: 0x1700662A RID: 26154
		// (get) Token: 0x060142DA RID: 82650 RVA: 0x002F321C File Offset: 0x002F141C
		// (set) Token: 0x060142DB RID: 82651 RVA: 0x002F3224 File Offset: 0x002F1424
		public EBvbCardFilterType Type { get; set; }

		// Token: 0x1700662B RID: 26155
		// (get) Token: 0x060142DC RID: 82652 RVA: 0x002F322D File Offset: 0x002F142D
		// (set) Token: 0x060142DD RID: 82653 RVA: 0x002F3235 File Offset: 0x002F1435
		public int CardType { get; set; }

		// Token: 0x060142DE RID: 82654 RVA: 0x002F323E File Offset: 0x002F143E
		public IBvbCardFilterCompareCardTypeT()
		{
			this.Type = EBvbCardFilterType.CompareCost;
			this.CardType = 0;
		}
	}
}
