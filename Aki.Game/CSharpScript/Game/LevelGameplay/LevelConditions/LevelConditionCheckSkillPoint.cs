using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E68 RID: 24168
	public class LevelConditionCheckSkillPoint : LevelConditionBase
	{
		// Token: 0x0603A7D2 RID: 239570 RVA: 0x01089200 File Offset: 0x01087400
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}
