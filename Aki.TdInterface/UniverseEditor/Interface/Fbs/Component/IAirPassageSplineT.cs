using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200539B RID: 21403
	public class IAirPassageSplineT
	{
		// Token: 0x17009758 RID: 38744
		// (get) Token: 0x0602164F RID: 136783 RVA: 0x0049BB88 File Offset: 0x00499D88
		// (set) Token: 0x06021650 RID: 136784 RVA: 0x0049BB90 File Offset: 0x00499D90
		public ESplineType Type { get; set; }

		// Token: 0x17009759 RID: 38745
		// (get) Token: 0x06021651 RID: 136785 RVA: 0x0049BB99 File Offset: 0x00499D99
		// (set) Token: 0x06021652 RID: 136786 RVA: 0x0049BBA1 File Offset: 0x00499DA1
		public string MiddleLineEffect { get; set; }

		// Token: 0x1700975A RID: 38746
		// (get) Token: 0x06021653 RID: 136787 RVA: 0x0049BBAA File Offset: 0x00499DAA
		// (set) Token: 0x06021654 RID: 136788 RVA: 0x0049BBB2 File Offset: 0x00499DB2
		public string TailCircleEffect { get; set; }

		// Token: 0x1700975B RID: 38747
		// (get) Token: 0x06021655 RID: 136789 RVA: 0x0049BBBB File Offset: 0x00499DBB
		// (set) Token: 0x06021656 RID: 136790 RVA: 0x0049BBC3 File Offset: 0x00499DC3
		public string MiddleCircleEffect { get; set; }

		// Token: 0x1700975C RID: 38748
		// (get) Token: 0x06021657 RID: 136791 RVA: 0x0049BBCC File Offset: 0x00499DCC
		// (set) Token: 0x06021658 RID: 136792 RVA: 0x0049BBD4 File Offset: 0x00499DD4
		public string MiddleCircleOverlyingEffect { get; set; }

		// Token: 0x1700975D RID: 38749
		// (get) Token: 0x06021659 RID: 136793 RVA: 0x0049BBDD File Offset: 0x00499DDD
		// (set) Token: 0x0602165A RID: 136794 RVA: 0x0049BBE5 File Offset: 0x00499DE5
		public float MiddleCircleSpace { get; set; }

		// Token: 0x1700975E RID: 38750
		// (get) Token: 0x0602165B RID: 136795 RVA: 0x0049BBEE File Offset: 0x00499DEE
		// (set) Token: 0x0602165C RID: 136796 RVA: 0x0049BBF6 File Offset: 0x00499DF6
		public float MiddleCircleRadius { get; set; }

		// Token: 0x1700975F RID: 38751
		// (get) Token: 0x0602165D RID: 136797 RVA: 0x0049BBFF File Offset: 0x00499DFF
		// (set) Token: 0x0602165E RID: 136798 RVA: 0x0049BC07 File Offset: 0x00499E07
		public float MovableRadius { get; set; }

		// Token: 0x17009760 RID: 38752
		// (get) Token: 0x0602165F RID: 136799 RVA: 0x0049BC10 File Offset: 0x00499E10
		// (set) Token: 0x06021660 RID: 136800 RVA: 0x0049BC18 File Offset: 0x00499E18
		public float Resistance { get; set; }

		// Token: 0x17009761 RID: 38753
		// (get) Token: 0x06021661 RID: 136801 RVA: 0x0049BC21 File Offset: 0x00499E21
		// (set) Token: 0x06021662 RID: 136802 RVA: 0x0049BC29 File Offset: 0x00499E29
		public float SpeedLimit { get; set; }

		// Token: 0x17009762 RID: 38754
		// (get) Token: 0x06021663 RID: 136803 RVA: 0x0049BC32 File Offset: 0x00499E32
		// (set) Token: 0x06021664 RID: 136804 RVA: 0x0049BC3A File Offset: 0x00499E3A
		public float SprintSpeedLimit { get; set; }

		// Token: 0x17009763 RID: 38755
		// (get) Token: 0x06021665 RID: 136805 RVA: 0x0049BC43 File Offset: 0x00499E43
		// (set) Token: 0x06021666 RID: 136806 RVA: 0x0049BC4B File Offset: 0x00499E4B
		public List<ICommonSplinePointT> Points { get; set; }

		// Token: 0x06021667 RID: 136807 RVA: 0x0049BC54 File Offset: 0x00499E54
		public IAirPassageSplineT()
		{
			this.Type = ESplineType.Common;
			this.MiddleLineEffect = null;
			this.TailCircleEffect = null;
			this.MiddleCircleEffect = null;
			this.MiddleCircleOverlyingEffect = null;
			this.MiddleCircleSpace = 0f;
			this.MiddleCircleRadius = 0f;
			this.MovableRadius = 0f;
			this.Resistance = 0f;
			this.SpeedLimit = 0f;
			this.SprintSpeedLimit = 0f;
			this.Points = null;
		}
	}
}
