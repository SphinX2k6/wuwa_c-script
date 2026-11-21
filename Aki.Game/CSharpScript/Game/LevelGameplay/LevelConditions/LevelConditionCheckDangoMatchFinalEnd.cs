using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.RacingBets.Data;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E93 RID: 24211
	public class LevelConditionCheckDangoMatchFinalEnd : LevelConditionBase
	{
		// Token: 0x0603A830 RID: 239664 RVA: 0x0108AB88 File Offset: 0x01088D88
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
