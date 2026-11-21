using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickTimeAction.Condition
{
	// Token: 0x02003F1C RID: 16156
	[NullableContext(1)]
	[Nullable(0)]
	public class CfgLazyConditionGroup
	{
		// Token: 0x04016459 RID: 91225
		public List<CfgLazyConditionBase> ConditionGroup = new List<CfgLazyConditionBase>();

		// Token: 0x0401645A RID: 91226
		public string ConditionFormula = string.Empty;

		// Token: 0x0401645B RID: 91227
		public int PayloadId;
	}
}
