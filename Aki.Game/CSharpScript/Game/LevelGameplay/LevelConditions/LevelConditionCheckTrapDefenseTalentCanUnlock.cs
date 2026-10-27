using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.TrapDefense;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D8F RID: 28047
	public class LevelConditionCheckTrapDefenseTalentCanUnlock : LevelConditionBase
	{
		// Token: 0x060447DA RID: 280538 RVA: 0x010E44C4 File Offset: 0x010E26C4
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return TrapDefenseModel.Instance.TalentTreeData.HasAnyNodeCanUnlockAndAfford();
		}
	}
}
