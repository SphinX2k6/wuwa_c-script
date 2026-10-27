using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002E91 RID: 11921
public static class BuffTypesHelper
{
	// Token: 0x0400BDE5 RID: 48613
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
