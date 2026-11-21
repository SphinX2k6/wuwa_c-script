using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E13 RID: 24083
	public class LevelConditionCheckFormationAnyRoleDead : LevelConditionBase
	{
		// Token: 0x0603A71C RID: 239388 RVA: 0x010856C4 File Offset: 0x010838C4
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			using (List<SceneTeamItem>.Enumerator enumerator = SceneTeamModel.Instance.GetTeamItems(false).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsDead())
					{
						return true;
					}
				}
			}
			return false;
		}
	}
}
