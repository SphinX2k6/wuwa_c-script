using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D46 RID: 27974
	public class LevelConditionCheckAnyMoraleAreaFinishWithReward : LevelConditionBase
	{
		// Token: 0x06044732 RID: 280370 RVA: 0x010E21B8 File Offset: 0x010E03B8
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			foreach (MoraleAreaData moraleAreaData in MoraleModel.Instance.AreaDataList)
			{
				if (moraleAreaData.HighDifficultyFlagSomeActive() && moraleAreaData.IsExistBox())
				{
					return true;
				}
			}
			return false;
		}
	}
}
