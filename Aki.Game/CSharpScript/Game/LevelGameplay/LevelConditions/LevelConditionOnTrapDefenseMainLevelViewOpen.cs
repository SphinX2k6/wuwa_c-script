using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005F1A RID: 24346
	public class LevelConditionOnTrapDefenseMainLevelViewOpen : LevelConditionBase
	{
		// Token: 0x0603A956 RID: 239958 RVA: 0x0108EAD7 File Offset: 0x0108CCD7
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}
