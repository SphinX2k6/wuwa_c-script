using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D0E RID: 27918
	public class LevelConditionOnDangoAbyssEnterWithTeamExploreBtn : LevelConditionBase
	{
		// Token: 0x060446C0 RID: 280256 RVA: 0x010E0870 File Offset: 0x010DEA70
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}
