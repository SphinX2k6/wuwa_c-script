using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B6B RID: 23403
	public class IMotorSlideSplineT
	{
		// Token: 0x1700AAF0 RID: 43760
		// (get) Token: 0x06026890 RID: 157840 RVA: 0x00546F4D File Offset: 0x0054514D
		// (set) Token: 0x06026891 RID: 157841 RVA: 0x00546F55 File Offset: 0x00545155
		public ESplineType Type { get; set; }

		// Token: 0x1700AAF1 RID: 43761
		// (get) Token: 0x06026892 RID: 157842 RVA: 0x00546F5E File Offset: 0x0054515E
		// (set) Token: 0x06026893 RID: 157843 RVA: 0x00546F66 File Offset: 0x00545166
		public float RangeRadius { get; set; }

		// Token: 0x1700AAF2 RID: 43762
		// (get) Token: 0x06026894 RID: 157844 RVA: 0x00546F6F File Offset: 0x0054516F
		// (set) Token: 0x06026895 RID: 157845 RVA: 0x00546F77 File Offset: 0x00545177
		public List<IMotorSlideSplinePointT> Points { get; set; }

		// Token: 0x06026896 RID: 157846 RVA: 0x00546F80 File Offset: 0x00545180
		public IMotorSlideSplineT()
		{
			this.Type = ESplineType.Common;
			this.RangeRadius = 0f;
			this.Points = null;
		}
	}
}
