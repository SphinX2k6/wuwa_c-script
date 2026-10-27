using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.MapRogue;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D51 RID: 27985
	public class LevelConditionCheckGridHasExplored : LevelConditionBase
	{
		// Token: 0x06044748 RID: 280392 RVA: 0x010E24A8 File Offset: 0x010E06A8
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("GridIndex");
			int index = (limitParams != null) ? int.Parse(limitParams) : 0;
			MapRogueGameInfo gameInfo = MapRogueModel.Instance.GameInfo;
			bool? flag;
			if (gameInfo == null)
			{
				flag = null;
			}
			else
			{
				MapGridData mapGridData = gameInfo.MapGrids[index];
				flag = ((mapGridData != null) ? new bool?(mapGridData.IsExplore) : null);
			}
			bool? flag2 = flag;
			return flag2.GetValueOrDefault();
		}
	}
}
