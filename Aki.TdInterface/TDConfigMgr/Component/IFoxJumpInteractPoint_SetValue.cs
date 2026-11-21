using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000408 RID: 1032
	public class IFoxJumpInteractPoint_SetValue
	{
		// Token: 0x04001042 RID: 4162
		public EExploreSkillInteractType Type;

		// Token: 0x04001043 RID: 4163
		public int LockConfigId;

		// Token: 0x04001044 RID: 4164
		public List<ActionInfo> Actions;

		// Token: 0x04001045 RID: 4165
		public IFoxJumpInteractPointRelationType PositionConfig;
	}
}
