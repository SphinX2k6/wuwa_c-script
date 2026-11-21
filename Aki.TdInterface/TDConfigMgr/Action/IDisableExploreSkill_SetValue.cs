using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B34 RID: 6964
	public class IDisableExploreSkill_SetValue
	{
		// Token: 0x04005BD3 RID: 23507
		public bool? PlaceTemporaryTeleport;

		// Token: 0x04005BD4 RID: 23508
		public bool? IsComplementary;

		// Token: 0x04005BD5 RID: 23509
		[Nullable(2)]
		public List<EExploreSkillType> ExploreSkillList;
	}
}
