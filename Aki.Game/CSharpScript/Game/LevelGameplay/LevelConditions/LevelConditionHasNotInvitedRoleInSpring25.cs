using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EB1 RID: 24241
	public class LevelConditionHasNotInvitedRoleInSpring25 : LevelConditionBase
	{
		// Token: 0x0603A86D RID: 239725 RVA: 0x0108B6B5 File Offset: 0x010898B5
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return !Spring25Model.Instance.IsLetterListViewAvailable;
		}
	}
}
