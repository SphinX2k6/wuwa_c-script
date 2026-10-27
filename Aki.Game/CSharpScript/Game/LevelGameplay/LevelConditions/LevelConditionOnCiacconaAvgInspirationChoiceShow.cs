using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D04 RID: 27908
	public class LevelConditionOnCiacconaAvgInspirationChoiceShow : LevelConditionBase
	{
		// Token: 0x060446AB RID: 280235 RVA: 0x010E0018 File Offset: 0x010DE218
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}
