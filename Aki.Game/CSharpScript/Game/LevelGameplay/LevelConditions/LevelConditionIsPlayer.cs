using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EBD RID: 24253
	public class LevelConditionIsPlayer : LevelConditionBase
	{
		// Token: 0x0603A885 RID: 239749 RVA: 0x0108C0A8 File Offset: 0x0108A2A8
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
