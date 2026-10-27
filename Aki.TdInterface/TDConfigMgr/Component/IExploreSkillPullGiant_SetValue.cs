using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000357 RID: 855
	public class IExploreSkillPullGiant_SetValue
	{
		// Token: 0x04000E1F RID: 3615
		public EExploreSkillInteractType Type;

		// Token: 0x04000E20 RID: 3616
		public float PullTime;

		// Token: 0x04000E21 RID: 3617
		[Nullable(1)]
		public List<ActionInfo> Actions;
	}
}
