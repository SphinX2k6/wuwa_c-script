using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058F8 RID: 22776
	public class ISearchTargetCfgT
	{
		// Token: 0x1700AAB3 RID: 43699
		// (get) Token: 0x060267BA RID: 157626 RVA: 0x0054D7BA File Offset: 0x0054B9BA
		// (set) Token: 0x060267BB RID: 157627 RVA: 0x0054D7C2 File Offset: 0x0054B9C2
		public List<IEntityAngleWeightT> AngleWeight { get; set; }

		// Token: 0x1700AAB4 RID: 43700
		// (get) Token: 0x060267BC RID: 157628 RVA: 0x0054D7CB File Offset: 0x0054B9CB
		// (set) Token: 0x060267BD RID: 157629 RVA: 0x0054D7D3 File Offset: 0x0054B9D3
		public List<IEntityCategoryWeightT> LockConditions { get; set; }

		// Token: 0x1700AAB5 RID: 43701
		// (get) Token: 0x060267BE RID: 157630 RVA: 0x0054D7DC File Offset: 0x0054B9DC
		// (set) Token: 0x060267BF RID: 157631 RVA: 0x0054D7E4 File Offset: 0x0054B9E4
		public bool IgnoreDistanceWeight { get; set; }

		// Token: 0x1700AAB6 RID: 43702
		// (get) Token: 0x060267C0 RID: 157632 RVA: 0x0054D7ED File Offset: 0x0054B9ED
		// (set) Token: 0x060267C1 RID: 157633 RVA: 0x0054D7F5 File Offset: 0x0054B9F5
		public byte NullMask { get; set; }

		// Token: 0x060267C2 RID: 157634 RVA: 0x0054D7FE File Offset: 0x0054B9FE
		public ISearchTargetCfgT()
		{
			this.AngleWeight = null;
			this.LockConditions = null;
			this.IgnoreDistanceWeight = false;
			this.NullMask = 0;
		}
	}
}
