using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D34 RID: 27956
	public class LevelConditionHasNotInvitedRoleInSpring25 : LevelConditionBase
	{
		// Token: 0x0604470D RID: 280333 RVA: 0x010E1529 File Offset: 0x010DF729
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return !Spring25Model.Instance.IsLetterListViewAvailable;
		}
	}
}
