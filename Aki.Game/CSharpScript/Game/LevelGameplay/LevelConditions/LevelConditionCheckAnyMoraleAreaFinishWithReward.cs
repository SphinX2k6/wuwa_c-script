using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EC3 RID: 24259
	public class LevelConditionCheckAnyMoraleAreaFinishWithReward : LevelConditionBase
	{
		// Token: 0x0603A892 RID: 239762 RVA: 0x0108C344 File Offset: 0x0108A544
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
