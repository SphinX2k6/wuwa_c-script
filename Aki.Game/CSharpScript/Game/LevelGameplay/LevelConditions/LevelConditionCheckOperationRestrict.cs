using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E46 RID: 24134
	public class LevelConditionCheckOperationRestrict : LevelConditionBase
	{
		// Token: 0x0603A78C RID: 239500 RVA: 0x010879B9 File Offset: 0x01085BB9
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return LevelEventLockInputState.Instance.IsLockInput();
		}
	}
}
