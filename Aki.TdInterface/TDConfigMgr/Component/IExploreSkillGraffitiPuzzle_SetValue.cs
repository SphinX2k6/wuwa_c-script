using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000395 RID: 917
	public class IExploreSkillGraffitiPuzzle_SetValue
	{
		// Token: 0x04000EF0 RID: 3824
		public EExploreSkillInteractType Type;

		// Token: 0x04000EF1 RID: 3825
		public List<IGraffitiPointPair> PointPairs;

		// Token: 0x04000EF2 RID: 3826
		public float AlignDuration;

		// Token: 0x04000EF3 RID: 3827
		public List<int> HighlightEntityIds;

		// Token: 0x04000EF4 RID: 3828
		public int HighlightTag;

		// Token: 0x04000EF5 RID: 3829
		public List<ActionInfo> Actions;
	}
}
