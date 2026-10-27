using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004A7 RID: 1191
	[NullableContext(1)]
	[Nullable(0)]
	public class IJigsawItemMatchedConfig_SetValue
	{
		// Token: 0x040011DB RID: 4571
		public IPieceIndex TargetIndex;

		// Token: 0x040011DC RID: 4572
		public List<int> JigsawItemIds;

		// Token: 0x040011DD RID: 4573
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Actions;

		// Token: 0x040011DE RID: 4574
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IConditionAction> ConditionActions;

		// Token: 0x040011DF RID: 4575
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> UnmatchedActions;
	}
}
