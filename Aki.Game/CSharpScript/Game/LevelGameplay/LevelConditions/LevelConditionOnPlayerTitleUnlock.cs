using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D61 RID: 28001
	public class LevelConditionOnPlayerTitleUnlock : LevelConditionBase
	{
		// Token: 0x06044768 RID: 280424 RVA: 0x010E2910 File Offset: 0x010E0B10
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}
