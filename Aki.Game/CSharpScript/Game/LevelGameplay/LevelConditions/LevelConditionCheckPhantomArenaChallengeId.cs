using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EF0 RID: 24304
	public class LevelConditionCheckPhantomArenaChallengeId : LevelConditionBase
	{
		// Token: 0x0603A8EC RID: 239852 RVA: 0x0108CF20 File Offset: 0x0108B120
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			int num;
			int.TryParse(inConditionInfo.GetLimitParams("ChallengeId"), out num);
			int challengeId = PhantomArenaBattleModel.Instance.ChallengeId;
			return num == challengeId;
		}
	}
}
