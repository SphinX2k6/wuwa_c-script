using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000582 RID: 1410
	public class IMonsterSummonInteractPoint_SetValue
	{
		// Token: 0x04001494 RID: 5268
		public EExploreSkillInteractType Type;

		// Token: 0x04001495 RID: 5269
		public float Range;

		// Token: 0x04001496 RID: 5270
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> Actions;
	}
}
