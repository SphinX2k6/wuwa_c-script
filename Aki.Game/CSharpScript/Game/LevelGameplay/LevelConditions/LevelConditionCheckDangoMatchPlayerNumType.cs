using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.RacingBets.Data;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E92 RID: 24210
	public class LevelConditionCheckDangoMatchPlayerNumType : LevelConditionBase
	{
		// Token: 0x0603A82E RID: 239662 RVA: 0x0108AB28 File Offset: 0x01088D28
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			int num = int.Parse(inConditionInfo.GetLimitParams("Type"));
			RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
			if (racingBetsSeasonData == null)
			{
				return false;
			}
			RacingBetsLegMatchData curLegMatchData = racingBetsSeasonData.GetCurLegMatchData();
			if (curLegMatchData == null)
			{
				return false;
			}
			ERacingBetsLegMatchState legMatchState = curLegMatchData.GetLegMatchState();
			return curLegMatchData.GetRacingBetsMainViewActorShowType(legMatchState) == (ERacingBetsMainViewShowType)num;
		}
	}
}
