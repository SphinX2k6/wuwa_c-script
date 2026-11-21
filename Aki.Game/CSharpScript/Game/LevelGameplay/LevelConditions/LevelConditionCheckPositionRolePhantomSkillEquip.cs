using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E55 RID: 24149
	public class LevelConditionCheckPositionRolePhantomSkillEquip : LevelConditionBase
	{
		// Token: 0x0603A7AC RID: 239532 RVA: 0x0108896C File Offset: 0x01086B6C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			int num = int.Parse(inConditionInfo.GetLimitParams("Pos"));
			SceneTeamItem sceneTeamItem = SceneTeamModel.Instance.GetTeamItems(true)[num - 1];
			return sceneTeamItem != null && sceneTeamItem.IsMyRole() && PhantomBattleController.Instance.GetEquipByIndex(sceneTeamItem.GetConfigId, num - 1) != 0;
		}
	}
}
