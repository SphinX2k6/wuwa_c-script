using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E77 RID: 24183
	public class LevelConditionCheckTrialRole : LevelConditionBase
	{
		// Token: 0x0603A7F7 RID: 239607 RVA: 0x01089E18 File Offset: 0x01088018
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
