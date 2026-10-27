using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D60 RID: 28000
	public class LevelConditionOnPlayerRevive : LevelConditionBase
	{
		// Token: 0x06044766 RID: 280422 RVA: 0x010E28C8 File Offset: 0x010E0AC8
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			bool flag = (bool)eventArgs[0];
			ETeamGroupType eteamGroupType = (ETeamGroupType)eventArgs[1];
			ETeamLivingState eteamLivingState = (ETeamLivingState)eventArgs[2];
			ETeamLivingState eteamLivingState2 = (ETeamLivingState)eventArgs[3];
			return flag && eteamGroupType == ETeamGroupType.Battle && eteamLivingState == ETeamLivingState.Alive && eteamLivingState2 == ETeamLivingState.Dead;
		}
	}
}
