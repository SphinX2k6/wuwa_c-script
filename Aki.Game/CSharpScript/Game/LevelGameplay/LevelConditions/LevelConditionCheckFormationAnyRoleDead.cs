using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C99 RID: 27801
	public class LevelConditionCheckFormationAnyRoleDead : LevelConditionBase
	{
		// Token: 0x060445C2 RID: 280002 RVA: 0x010DB718 File Offset: 0x010D9918
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
