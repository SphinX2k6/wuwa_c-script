using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x02004085 RID: 16517
	[NullableContext(1)]
	[Nullable(0)]
	public class DestroyEntityActionRecord : ActionRecord
	{
		// Token: 0x06029DBF RID: 171455 RVA: 0x00BD6212 File Offset: 0x00BD4412
		public DestroyEntityActionRecord(ActionInfo actionInfo, Dictionary<int, int> entityStateTagIdMap)
		{
			base.ActionInfo = actionInfo;
			this.EntityStateTagIdMap = entityStateTagIdMap;
		}

		// Token: 0x04016D37 RID: 93495
		public Dictionary<int, int> EntityStateTagIdMap;
	}
}
