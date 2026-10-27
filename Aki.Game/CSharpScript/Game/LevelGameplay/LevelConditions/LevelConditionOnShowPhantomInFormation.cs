using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D66 RID: 28006
	public class LevelConditionOnShowPhantomInFormation : LevelConditionBase
	{
		// Token: 0x06044772 RID: 280434 RVA: 0x010E2A85 File Offset: 0x010E0C85
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}
