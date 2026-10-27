using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.RacingBets.Data;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D16 RID: 27926
	public class LevelConditionCheckDangoMatchFinalEnd : LevelConditionBase
	{
		// Token: 0x060446D0 RID: 280272 RVA: 0x010E09FC File Offset: 0x010DEBFC
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
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
			bool flag = RacingBetsModel.Instance.IsFinalLegMatch(curLegMatchData.Id);
			bool flag2 = curLegMatchData.GetLegMatchState() == ERacingBetsLegMatchState.EndOfMatch;
			return flag && flag2;
		}
	}
}
