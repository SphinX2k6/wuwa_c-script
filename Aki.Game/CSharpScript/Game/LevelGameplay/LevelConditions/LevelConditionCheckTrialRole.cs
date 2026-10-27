using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CFA RID: 27898
	public class LevelConditionCheckTrialRole : LevelConditionBase
	{
		// Token: 0x06044697 RID: 280215 RVA: 0x010DFC8C File Offset: 0x010DDE8C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (!RoleController.Instance.IsInRoleTrial())
			{
				return false;
			}
			using (HashSet<int>.Enumerator enumerator = RoleModel.Instance.RoleTrialIdList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (RoleUtils.GetTrialRoleType(enumerator.Current) == ETrialRoleType.NormalTrial)
					{
						return true;
					}
				}
			}
			return false;
		}
	}
}
