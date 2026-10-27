using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CD0 RID: 27856
	public class LevelConditionCheckPhantomTeam : LevelConditionBase
	{
		// Token: 0x0604463A RID: 280122 RVA: 0x010DDA40 File Offset: 0x010DBC40
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return SceneTeamModel.Instance.IsPhantomTeam;
		}
	}
}
