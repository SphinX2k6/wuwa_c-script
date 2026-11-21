using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005F1E RID: 24350
	public class LevelConditionOnWorldMapGravityBtnShow : LevelConditionBase
	{
		// Token: 0x0603A95E RID: 239966 RVA: 0x0108EB99 File Offset: 0x0108CD99
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}
