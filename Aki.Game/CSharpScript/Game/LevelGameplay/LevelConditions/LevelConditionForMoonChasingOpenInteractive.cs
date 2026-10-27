using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D2E RID: 27950
	public class LevelConditionForMoonChasingOpenInteractive : LevelConditionBase
	{
		// Token: 0x06044700 RID: 280320 RVA: 0x010E10AC File Offset: 0x010DF2AC
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}
