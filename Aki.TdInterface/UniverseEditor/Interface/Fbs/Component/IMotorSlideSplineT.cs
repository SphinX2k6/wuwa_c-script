using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055CD RID: 21965
	public class IMotorSlideSplineT
	{
		// Token: 0x1700A268 RID: 41576
		// (get) Token: 0x06024683 RID: 149123 RVA: 0x005069D5 File Offset: 0x00504BD5
		// (set) Token: 0x06024684 RID: 149124 RVA: 0x005069DD File Offset: 0x00504BDD
		public ESplineType Type { get; set; }

		// Token: 0x1700A269 RID: 41577
		// (get) Token: 0x06024685 RID: 149125 RVA: 0x005069E6 File Offset: 0x00504BE6
		// (set) Token: 0x06024686 RID: 149126 RVA: 0x005069EE File Offset: 0x00504BEE
		public float RangeRadius { get; set; }

		// Token: 0x1700A26A RID: 41578
		// (get) Token: 0x06024687 RID: 149127 RVA: 0x005069F7 File Offset: 0x00504BF7
		// (set) Token: 0x06024688 RID: 149128 RVA: 0x005069FF File Offset: 0x00504BFF
		public List<IMotorSlideSplinePointT> Points { get; set; }

		// Token: 0x06024689 RID: 149129 RVA: 0x00506A08 File Offset: 0x00504C08
		public IMotorSlideSplineT()
		{
			this.Type = ESplineType.Common;
			this.RangeRadius = 0f;
			this.Points = null;
		}
	}
}
