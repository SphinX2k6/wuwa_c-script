using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CAB RID: 7339
	public class IHideHighlightExploreSkillIcon_SetValue
	{
		// Token: 0x04005F6B RID: 24427
		public EHighlightExploreSkillIconType Type;

		// Token: 0x04005F6C RID: 24428
		public EHighlightType? HighlightType;

		// Token: 0x04005F6D RID: 24429
		[Nullable(2)]
		public IHideHighlightExploreSkillIconTargetConfig TargetConfig;
	}
}
