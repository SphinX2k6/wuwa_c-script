using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D7A RID: 28026
	public class LevelConditionRoguelikeHasSelectEntryAndShow : LevelConditionBase
	{
		// Token: 0x060447AD RID: 280493 RVA: 0x010E3AA4 File Offset: 0x010E1CA4
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}
