using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D03 RID: 27907
	public class LevelConditionCheckWorldMapSecondaryUiOpened : LevelConditionBase
	{
		// Token: 0x060446A9 RID: 280233 RVA: 0x010E000D File Offset: 0x010DE20D
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return true;
		}
	}
}
