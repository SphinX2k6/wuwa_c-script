using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CCC RID: 27852
	public class LevelConditionCheckOperationRestrict : LevelConditionBase
	{
		// Token: 0x06044632 RID: 280114 RVA: 0x010DD965 File Offset: 0x010DBB65
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return LevelEventLockInputState.Instance.IsLockInput();
		}
	}
}
