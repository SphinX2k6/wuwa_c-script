using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E8B RID: 24203
	public class LevelConditionOnDangoAbyssEnterWithTeamExploreBtn : LevelConditionBase
	{
		// Token: 0x0603A820 RID: 239648 RVA: 0x0108A9FC File Offset: 0x01088BFC
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}
