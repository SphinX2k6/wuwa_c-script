using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E26 RID: 24102
	public class LevelConditionCheckInstanceEntranceUnlockStatus : LevelConditionBase
	{
		// Token: 0x0603A743 RID: 239427 RVA: 0x01086298 File Offset: 0x01084498
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			Log.Instance.Info(ELogModule.InstanceDungeon, ELogAuthor.LJQ, "注意，该条件已经废弃，通知程序处理", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
	}
}
