using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005F0A RID: 24330
	public class LevelConditionTeamCouldEquipPhantom : LevelConditionBase
	{
		// Token: 0x0603A936 RID: 239926 RVA: 0x0108E4C8 File Offset: 0x0108C6C8
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (PhantomBattleModel.Instance.GetUnEquipVisionArray().Length == 0)
			{
				return false;
			}
			List<SceneTeamItem> teamItems = SceneTeamModel.Instance.GetTeamItems(true);
			for (int i = 0; i < teamItems.Count; i++)
			{
				SceneTeamItem sceneTeamItem = teamItems[i];
				PhantomRoleEquipmentData battleDataById = PhantomBattleModel.Instance.GetBattleDataById(sceneTeamItem.GetConfigId);
				if (battleDataById != null && battleDataById.CheckHasEmpty())
				{
					return true;
				}
			}
			return false;
		}
	}
}
