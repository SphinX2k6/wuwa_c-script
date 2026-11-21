using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E97 RID: 24215
	public class LevelConditionOnDangoMonopolyViewShowProcessEnd : LevelConditionBase
	{
		// Token: 0x0603A838 RID: 239672 RVA: 0x0108AC18 File Offset: 0x01088E18
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return !(bool)eventArgs[0];
		}
	}
}
