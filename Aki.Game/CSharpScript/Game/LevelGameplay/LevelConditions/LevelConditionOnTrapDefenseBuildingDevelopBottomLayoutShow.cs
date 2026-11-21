using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005F17 RID: 24343
	public class LevelConditionOnTrapDefenseBuildingDevelopBottomLayoutShow : LevelConditionBase
	{
		// Token: 0x0603A950 RID: 239952 RVA: 0x0108E956 File Offset: 0x0108CB56
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}
