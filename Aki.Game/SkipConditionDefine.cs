using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001FF0 RID: 8176
public class SkipConditionDefine
{
	// Token: 0x0400ABDB RID: 43995
	[Nullable(1)]
	public static readonly Dictionary<ESkipConditionType, ISkipConditionChecker> SkipConditionCheckerMap = new Dictionary<ESkipConditionType, ISkipConditionChecker>
	{
		{
			ESkipConditionType.SystemFunction,
			new SystemFunctionConditionChecker()
		},
		{
			ESkipConditionType.QuestState,
			new QuestStateConditionChecker()
		},
		{
			ESkipConditionType.TeleportState,
			new TeleportStateConditionChecker()
		}
	};
}
