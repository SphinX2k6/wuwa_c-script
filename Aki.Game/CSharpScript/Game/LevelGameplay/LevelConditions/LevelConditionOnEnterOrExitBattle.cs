using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005ED5 RID: 24277
	public class LevelConditionOnEnterOrExitBattle : LevelConditionBase
	{
		// Token: 0x0603A8B6 RID: 239798 RVA: 0x0108C7F0 File Offset: 0x0108A9F0
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("CheckValue");
			if (limitParams == null)
			{
				return false;
			}
			bool flag = limitParams == "TRUE";
			return (bool)eventArgs[0] == flag;
		}
	}
}
