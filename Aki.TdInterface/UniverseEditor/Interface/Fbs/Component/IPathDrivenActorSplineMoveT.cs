using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CEE RID: 23790
	public class IPathDrivenActorSplineMoveT
	{
		// Token: 0x1700AECB RID: 44747
		// (get) Token: 0x06027802 RID: 161794 RVA: 0x00567C49 File Offset: 0x00565E49
		// (set) Token: 0x06027803 RID: 161795 RVA: 0x00567C51 File Offset: 0x00565E51
		public EPathDrivenActorMoveType Type { get; set; }

		// Token: 0x1700AECC RID: 44748
		// (get) Token: 0x06027804 RID: 161796 RVA: 0x00567C5A File Offset: 0x00565E5A
		// (set) Token: 0x06027805 RID: 161797 RVA: 0x00567C62 File Offset: 0x00565E62
		public List<int> SplineEntityIds { get; set; }

		// Token: 0x1700AECD RID: 44749
		// (get) Token: 0x06027806 RID: 161798 RVA: 0x00567C6B File Offset: 0x00565E6B
		// (set) Token: 0x06027807 RID: 161799 RVA: 0x00567C73 File Offset: 0x00565E73
		public bool IsRandomSpline { get; set; }

		// Token: 0x1700AECE RID: 44750
		// (get) Token: 0x06027808 RID: 161800 RVA: 0x00567C7C File Offset: 0x00565E7C
		// (set) Token: 0x06027809 RID: 161801 RVA: 0x00567C84 File Offset: 0x00565E84
		public bool IsChainedSpline { get; set; }

		// Token: 0x1700AECF RID: 44751
		// (get) Token: 0x0602780A RID: 161802 RVA: 0x00567C8D File Offset: 0x00565E8D
		// (set) Token: 0x0602780B RID: 161803 RVA: 0x00567C95 File Offset: 0x00565E95
		public bool IsLoop { get; set; }

		// Token: 0x1700AED0 RID: 44752
		// (get) Token: 0x0602780C RID: 161804 RVA: 0x00567C9E File Offset: 0x00565E9E
		// (set) Token: 0x0602780D RID: 161805 RVA: 0x00567CA6 File Offset: 0x00565EA6
		public bool IsFollowSplineDir { get; set; }

		// Token: 0x1700AED1 RID: 44753
		// (get) Token: 0x0602780E RID: 161806 RVA: 0x00567CAF File Offset: 0x00565EAF
		// (set) Token: 0x0602780F RID: 161807 RVA: 0x00567CB7 File Offset: 0x00565EB7
		public byte NullMask { get; set; }

		// Token: 0x06027810 RID: 161808 RVA: 0x00567CC0 File Offset: 0x00565EC0
		public IPathDrivenActorSplineMoveT()
		{
			this.Type = EPathDrivenActorMoveType.Spline;
			this.SplineEntityIds = null;
			this.IsRandomSpline = false;
			this.IsChainedSpline = false;
			this.IsLoop = false;
			this.IsFollowSplineDir = false;
			this.NullMask = 0;
		}
	}
}
