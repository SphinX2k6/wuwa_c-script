using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E4A RID: 24138
	public class LevelConditionCheckPhantomTeam : LevelConditionBase
	{
		// Token: 0x0603A794 RID: 239508 RVA: 0x01087A94 File Offset: 0x01085C94
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return SceneTeamModel.Instance.IsPhantomTeam;
		}
	}
}
