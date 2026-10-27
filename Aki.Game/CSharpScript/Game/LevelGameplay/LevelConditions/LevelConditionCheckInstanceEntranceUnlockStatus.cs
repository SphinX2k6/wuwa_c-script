using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CAC RID: 27820
	public class LevelConditionCheckInstanceEntranceUnlockStatus : LevelConditionBase
	{
		// Token: 0x060445E9 RID: 280041 RVA: 0x010DC2EC File Offset: 0x010DA4EC
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			Log.Instance.Info(ELogModule.InstanceDungeon, ELogAuthor.LJQ, "注意，该条件已经废弃，通知程序处理", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
	}
}
