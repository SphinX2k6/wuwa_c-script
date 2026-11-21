using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.MapRogue;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005ECE RID: 24270
	public class LevelConditionCheckGridHasExplored : LevelConditionBase
	{
		// Token: 0x0603A8A8 RID: 239784 RVA: 0x0108C634 File Offset: 0x0108A834
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
