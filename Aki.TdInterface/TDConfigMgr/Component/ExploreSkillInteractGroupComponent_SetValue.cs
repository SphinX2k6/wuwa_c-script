using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200016C RID: 364
	public class ExploreSkillInteractGroupComponent_SetValue
	{
		// Token: 0x040006E9 RID: 1769
		public bool? Disabled;

		// Token: 0x040006EA RID: 1770
		public bool? EdIsLocked;

		// Token: 0x040006EB RID: 1771
		[Nullable(1)]
		public List<IExploreSkillInteract> ExploreSkillInteractList;
	}
}
