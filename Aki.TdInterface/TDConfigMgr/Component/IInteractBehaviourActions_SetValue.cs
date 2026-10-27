using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000475 RID: 1141
	public class IInteractBehaviourActions_SetValue
	{
		// Token: 0x0400115D RID: 4445
		public ELevelAIBehaviourType Type;

		// Token: 0x0400115E RID: 4446
		[Nullable(1)]
		public List<ActionInfo> Actions;
	}
}
