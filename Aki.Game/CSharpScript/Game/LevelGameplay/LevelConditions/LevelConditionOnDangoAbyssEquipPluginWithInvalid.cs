using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E8E RID: 24206
	public class LevelConditionOnDangoAbyssEquipPluginWithInvalid : LevelConditionBase
	{
		// Token: 0x0603A826 RID: 239654 RVA: 0x0108AA62 File Offset: 0x01088C62
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}
