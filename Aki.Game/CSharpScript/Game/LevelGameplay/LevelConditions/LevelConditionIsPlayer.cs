using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D40 RID: 27968
	public class LevelConditionIsPlayer : LevelConditionBase
	{
		// Token: 0x06044725 RID: 280357 RVA: 0x010E1F1C File Offset: 0x010E011C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0 || inTrigger == null)
			{
				return false;
			}
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (inConditionInfo.GetLimitParams("IsPlayer") == "1")
			{
				return baseCharacter == inTrigger;
			}
			return baseCharacter != inTrigger;
		}
	}
}
