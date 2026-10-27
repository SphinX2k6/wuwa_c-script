using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050CF RID: 20687
	[NullableContext(1)]
	[Nullable(0)]
	public class SetEntityVisibleActionRecord : ActionRecord
	{
		// Token: 0x06034F26 RID: 216870 RVA: 0x00C8A746 File Offset: 0x00C88946
		public SetEntityVisibleActionRecord(ActionInfo actionInfo, Dictionary<int, int> entityStateTagIdMap)
		{
			base.ActionInfo = actionInfo;
			this.EntityStateTagIdMap = entityStateTagIdMap;
		}

		// Token: 0x0401C30B RID: 115467
		public Dictionary<int, int> EntityStateTagIdMap;
	}
}
