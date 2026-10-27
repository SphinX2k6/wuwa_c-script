using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002A75 RID: 10869
public class SkipConditionDefine
{
	// Token: 0x0400A7D7 RID: 42967
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
