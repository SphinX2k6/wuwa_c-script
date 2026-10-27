using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D71 RID: 28017
	public class LevelConditionCheckPhantomArenaChallengeId : LevelConditionBase
	{
		// Token: 0x06044788 RID: 280456 RVA: 0x010E2D3C File Offset: 0x010E0F3C
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
