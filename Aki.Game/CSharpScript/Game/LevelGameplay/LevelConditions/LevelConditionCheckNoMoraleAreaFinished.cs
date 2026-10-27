using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D48 RID: 27976
	public class LevelConditionCheckNoMoraleAreaFinished : LevelConditionBase
	{
		// Token: 0x06044736 RID: 280374 RVA: 0x010E223C File Offset: 0x010E043C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			using (List<MoraleAreaData>.Enumerator enumerator = MoraleModel.Instance.AreaDataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.HighDifficultyFlagSomeActive())
					{
						return false;
					}
				}
			}
			return true;
		}
	}
}
