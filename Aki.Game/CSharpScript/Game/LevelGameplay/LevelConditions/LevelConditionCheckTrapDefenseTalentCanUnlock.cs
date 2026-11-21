using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.TrapDefense;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005F0E RID: 24334
	public class LevelConditionCheckTrapDefenseTalentCanUnlock : LevelConditionBase
	{
		// Token: 0x0603A93E RID: 239934 RVA: 0x0108E6EC File Offset: 0x0108C8EC
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return TrapDefenseModel.Instance.TalentTreeData.HasAnyNodeCanUnlockAndAfford();
		}
	}
}
