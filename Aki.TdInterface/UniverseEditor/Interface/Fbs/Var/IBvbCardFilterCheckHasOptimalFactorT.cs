using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A31 RID: 14897
	public class IBvbCardFilterCheckHasOptimalFactorT
	{
		// Token: 0x17006616 RID: 26134
		// (get) Token: 0x06014282 RID: 82562 RVA: 0x002F29EB File Offset: 0x002F0BEB
		// (set) Token: 0x06014283 RID: 82563 RVA: 0x002F29F3 File Offset: 0x002F0BF3
		public EBvbCardFilterType Type { get; set; }

		// Token: 0x17006617 RID: 26135
		// (get) Token: 0x06014284 RID: 82564 RVA: 0x002F29FC File Offset: 0x002F0BFC
		// (set) Token: 0x06014285 RID: 82565 RVA: 0x002F2A04 File Offset: 0x002F0C04
		public TVarRefUnion HandCard { get; set; }

		// Token: 0x06014286 RID: 82566 RVA: 0x002F2A0D File Offset: 0x002F0C0D
		public IBvbCardFilterCheckHasOptimalFactorT()
		{
			this.Type = EBvbCardFilterType.CompareCost;
			this.HandCard = null;
		}
	}
}
