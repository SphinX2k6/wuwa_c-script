using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050B5 RID: 20661
	[NullableContext(1)]
	[Nullable(0)]
	public class DestroyEntityActionRecord : ActionRecord
	{
		// Token: 0x06034EC6 RID: 216774 RVA: 0x00C88F29 File Offset: 0x00C87129
		public DestroyEntityActionRecord(ActionInfo actionInfo, Dictionary<int, int> entityStateTagIdMap)
		{
			base.ActionInfo = actionInfo;
			this.EntityStateTagIdMap = entityStateTagIdMap;
		}

		// Token: 0x0401C306 RID: 115462
		public Dictionary<int, int> EntityStateTagIdMap;
	}
}
