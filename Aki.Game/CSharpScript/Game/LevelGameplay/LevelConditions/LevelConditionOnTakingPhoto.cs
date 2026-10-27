using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D68 RID: 28008
	public class LevelConditionOnTakingPhoto : LevelConditionBase
	{
		// Token: 0x06044776 RID: 280438 RVA: 0x010E2B84 File Offset: 0x010E0D84
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}
