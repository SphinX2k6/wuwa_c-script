using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D06 RID: 27910
	public class LevelConditionOnCiacconaChapterRestart : LevelConditionBase
	{
		// Token: 0x060446AF RID: 280239 RVA: 0x010E0035 File Offset: 0x010DE235
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}
