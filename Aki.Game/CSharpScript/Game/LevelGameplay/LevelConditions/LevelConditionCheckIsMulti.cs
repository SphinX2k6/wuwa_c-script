using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E2F RID: 24111
	public class LevelConditionCheckIsMulti : LevelConditionBase
	{
		// Token: 0x0603A757 RID: 239447 RVA: 0x01086640 File Offset: 0x01084840
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return GameModeModel.Instance.IsMulti;
		}
	}
}
