using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickTimeAction.Condition
{
	// Token: 0x02004F53 RID: 20307
	[NullableContext(1)]
	[Nullable(0)]
	public class CfgLazyConditionGroup
	{
		// Token: 0x0401BA84 RID: 113284
		public List<CfgLazyConditionBase> ConditionGroup = new List<CfgLazyConditionBase>();

		// Token: 0x0401BA85 RID: 113285
		public string ConditionFormula = string.Empty;

		// Token: 0x0401BA86 RID: 113286
		public int PayloadId;
	}
}
