using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003A4 RID: 932
	public class IExploreSkillQuantumDiffusion_SetValue
	{
		// Token: 0x04000F24 RID: 3876
		public EExploreSkillInteractType Type;

		// Token: 0x04000F25 RID: 3877
		public bool? NeedFollowShooter;

		// Token: 0x04000F26 RID: 3878
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> Actions;
	}
}
