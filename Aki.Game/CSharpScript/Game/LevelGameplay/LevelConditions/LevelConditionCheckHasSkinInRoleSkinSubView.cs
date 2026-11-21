using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E1F RID: 24095
	public class LevelConditionCheckHasSkinInRoleSkinSubView : LevelConditionBase
	{
		// Token: 0x0603A736 RID: 239414 RVA: 0x01085E42 File Offset: 0x01084042
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return eventArgs.Length >= 1 && (bool)eventArgs[0];
		}
	}
}
