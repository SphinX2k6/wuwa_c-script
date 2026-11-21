using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E81 RID: 24193
	public class LevelConditionOnCiacconaAvgInspirationChoiceShow : LevelConditionBase
	{
		// Token: 0x0603A80B RID: 239627 RVA: 0x0108A1A4 File Offset: 0x010883A4
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}
