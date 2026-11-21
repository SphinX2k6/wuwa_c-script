using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E8D RID: 24205
	public class LevelConditionOnDangoAbyssEquipPluginWithValidChange : LevelConditionBase
	{
		// Token: 0x0603A824 RID: 239652 RVA: 0x0108AA50 File Offset: 0x01088C50
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[1];
		}
	}
}
