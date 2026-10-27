using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D10 RID: 27920
	public class LevelConditionOnDangoAbyssEquipPluginWithValidChange : LevelConditionBase
	{
		// Token: 0x060446C4 RID: 280260 RVA: 0x010E08C4 File Offset: 0x010DEAC4
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[1];
		}
	}
}
