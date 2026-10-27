using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CE2 RID: 27874
	public class LevelConditionCheckRogueCanUnlockSkill : LevelConditionBase
	{
		// Token: 0x06044660 RID: 280160 RVA: 0x010DEBE6 File Offset: 0x010DCDE6
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return RoguelikeModel.Instance.CheckHasCanUnlockSkill();
		}
	}
}
