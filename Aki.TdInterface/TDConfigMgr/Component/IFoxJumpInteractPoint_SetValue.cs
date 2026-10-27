using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003BD RID: 957
	[NullableContext(1)]
	[Nullable(0)]
	public class IFoxJumpInteractPoint_SetValue
	{
		// Token: 0x04000F41 RID: 3905
		public EExploreSkillInteractType Type;

		// Token: 0x04000F42 RID: 3906
		public int LockConfigId;

		// Token: 0x04000F43 RID: 3907
		public List<ActionInfo> Actions;

		// Token: 0x04000F44 RID: 3908
		public IFoxJumpInteractPointRelationType PositionConfig;
	}
}
