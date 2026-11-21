using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E5C RID: 24156
	public class LevelConditionCheckRogueCanUnlockSkill : LevelConditionBase
	{
		// Token: 0x0603A7BA RID: 239546 RVA: 0x01088CC6 File Offset: 0x01086EC6
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return RoguelikeModel.Instance.CheckHasCanUnlockSkill();
		}
	}
}
