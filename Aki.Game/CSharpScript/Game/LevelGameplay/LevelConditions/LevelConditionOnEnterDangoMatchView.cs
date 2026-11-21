using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E90 RID: 24208
	public class LevelConditionOnEnterDangoMatchView : LevelConditionBase
	{
		// Token: 0x0603A82A RID: 239658 RVA: 0x0108AAC5 File Offset: 0x01088CC5
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}
