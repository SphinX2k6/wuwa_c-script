using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E0E RID: 24078
	public class LevelConditionCheckFishingQteBtnHitValidArea : LevelConditionBase
	{
		// Token: 0x0603A712 RID: 239378 RVA: 0x010854DD File Offset: 0x010836DD
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}
