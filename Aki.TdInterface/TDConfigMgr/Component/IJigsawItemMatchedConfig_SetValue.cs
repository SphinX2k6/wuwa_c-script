using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000500 RID: 1280
	public class IJigsawItemMatchedConfig_SetValue
	{
		// Token: 0x040012FD RID: 4861
		public IPieceIndex TargetIndex;

		// Token: 0x040012FE RID: 4862
		public List<int> JigsawItemIds;

		// Token: 0x040012FF RID: 4863
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> Actions;

		// Token: 0x04001300 RID: 4864
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IConditionAction> ConditionActions;

		// Token: 0x04001301 RID: 4865
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> UnmatchedActions;
	}
}
