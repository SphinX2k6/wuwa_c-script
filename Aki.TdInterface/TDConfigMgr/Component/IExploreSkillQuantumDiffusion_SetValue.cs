using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200035B RID: 859
	public class IExploreSkillQuantumDiffusion_SetValue
	{
		// Token: 0x04000E2D RID: 3629
		public EExploreSkillInteractType Type;

		// Token: 0x04000E2E RID: 3630
		public bool? NeedFollowShooter;

		// Token: 0x04000E2F RID: 3631
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Actions;
	}
}
