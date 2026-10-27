using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CEB RID: 27883
	public class LevelConditionCheckSkillPoint : LevelConditionBase
	{
		// Token: 0x06044672 RID: 280178 RVA: 0x010DF020 File Offset: 0x010DD220
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}
