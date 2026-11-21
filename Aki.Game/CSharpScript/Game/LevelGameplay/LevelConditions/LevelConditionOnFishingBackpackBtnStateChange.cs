using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005ED6 RID: 24278
	public class LevelConditionOnFishingBackpackBtnStateChange : LevelConditionBase
	{
		// Token: 0x0603A8B8 RID: 239800 RVA: 0x0108C839 File Offset: 0x0108AA39
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return eventArgs.Length == 1 && eventArgs[0] is bool && (bool)eventArgs[0];
		}
	}
}
