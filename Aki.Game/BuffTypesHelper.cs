using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020023E3 RID: 9187
public static class BuffTypesHelper
{
	// Token: 0x0400C17C RID: 49532
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly HashSet<EBuffActionType> actionTagRemove = new HashSet<EBuffActionType>
	{
		EBuffActionType.RemoveBuffWhenInstigatorHasEveryTag,
		EBuffActionType.RemoveBuffWhenInstigatorHasSomeTag,
		EBuffActionType.RemoveBuffWhenInstigatorNotHasEveryTag,
		EBuffActionType.RemoveBuffWhenInstigatorNotHasSomeTag,
		EBuffActionType.RemoveBuffWhenVictimHasEveryTag,
		EBuffActionType.RemoveBuffWhenVictimHasSomeTag,
		EBuffActionType.RemoveBuffWhenVictimNotHasEveryTag,
		EBuffActionType.RemoveBuffWhenVictimNotHasSomeTag
	};
}
