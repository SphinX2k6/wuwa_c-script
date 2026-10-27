using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CA5 RID: 27813
	public class LevelConditionCheckHasSkinInRoleSkinSubView : LevelConditionBase
	{
		// Token: 0x060445DC RID: 280028 RVA: 0x010DBE96 File Offset: 0x010DA096
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return eventArgs.Length >= 1 && (bool)eventArgs[0];
		}
	}
}
