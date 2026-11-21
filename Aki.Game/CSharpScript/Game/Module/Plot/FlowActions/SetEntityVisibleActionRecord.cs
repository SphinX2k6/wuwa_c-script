using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x0200409F RID: 16543
	[NullableContext(1)]
	[Nullable(0)]
	public class SetEntityVisibleActionRecord : ActionRecord
	{
		// Token: 0x06029E1F RID: 171551 RVA: 0x00BD7A2E File Offset: 0x00BD5C2E
		public SetEntityVisibleActionRecord(ActionInfo actionInfo, Dictionary<int, int> entityStateTagIdMap)
		{
			base.ActionInfo = actionInfo;
			this.EntityStateTagIdMap = entityStateTagIdMap;
		}

		// Token: 0x04016D3C RID: 93500
		public Dictionary<int, int> EntityStateTagIdMap;
	}
}
