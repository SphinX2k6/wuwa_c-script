using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CB5 RID: 27829
	public class LevelConditionCheckIsMulti : LevelConditionBase
	{
		// Token: 0x060445FD RID: 280061 RVA: 0x010DC694 File Offset: 0x010DA894
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return GameModeModel.Instance.IsMulti;
		}
	}
}
