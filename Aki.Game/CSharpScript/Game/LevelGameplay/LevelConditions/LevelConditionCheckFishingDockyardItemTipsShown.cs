using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C91 RID: 27793
	public class LevelConditionCheckFishingDockyardItemTipsShown : LevelConditionBase
	{
		// Token: 0x060445B2 RID: 279986 RVA: 0x010DB436 File Offset: 0x010D9636
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}
