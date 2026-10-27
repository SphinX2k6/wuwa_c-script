using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C94 RID: 27796
	public class LevelConditionCheckFishingQteBtnHitValidArea : LevelConditionBase
	{
		// Token: 0x060445B8 RID: 279992 RVA: 0x010DB531 File Offset: 0x010D9731
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}
