using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F45 RID: 20293
	public class ICheckInRangeProperlyConditionT
	{
		// Token: 0x17009103 RID: 37123
		// (get) Token: 0x0601F911 RID: 129297 RVA: 0x00464480 File Offset: 0x00462680
		// (set) Token: 0x0601F912 RID: 129298 RVA: 0x00464488 File Offset: 0x00462688
		public ECondition Type { get; set; }

		// Token: 0x17009104 RID: 37124
		// (get) Token: 0x0601F913 RID: 129299 RVA: 0x00464491 File Offset: 0x00462691
		// (set) Token: 0x0601F914 RID: 129300 RVA: 0x00464499 File Offset: 0x00462699
		public List<int> RangeEntities { get; set; }

		// Token: 0x17009105 RID: 37125
		// (get) Token: 0x0601F915 RID: 129301 RVA: 0x004644A2 File Offset: 0x004626A2
		// (set) Token: 0x0601F916 RID: 129302 RVA: 0x004644AA File Offset: 0x004626AA
		public bool InRange { get; set; }

		// Token: 0x17009106 RID: 37126
		// (get) Token: 0x0601F917 RID: 129303 RVA: 0x004644B3 File Offset: 0x004626B3
		// (set) Token: 0x0601F918 RID: 129304 RVA: 0x004644BB File Offset: 0x004626BB
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x0601F919 RID: 129305 RVA: 0x004644C4 File Offset: 0x004626C4
		public ICheckInRangeProperlyConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.RangeEntities = null;
			this.InRange = false;
			this.OnlinePlayerConditionTargetOption = null;
		}
	}
}
