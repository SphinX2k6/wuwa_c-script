using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D11 RID: 27921
	public class LevelConditionOnDangoAbyssEquipPluginWithInvalid : LevelConditionBase
	{
		// Token: 0x060446C6 RID: 280262 RVA: 0x010E08D6 File Offset: 0x010DEAD6
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}
