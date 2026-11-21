using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EC5 RID: 24261
	public class LevelConditionCheckNoMoraleAreaFinished : LevelConditionBase
	{
		// Token: 0x0603A896 RID: 239766 RVA: 0x0108C3C8 File Offset: 0x0108A5C8
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
