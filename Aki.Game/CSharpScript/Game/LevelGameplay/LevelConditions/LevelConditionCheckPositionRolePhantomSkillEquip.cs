using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CDB RID: 27867
	public class LevelConditionCheckPositionRolePhantomSkillEquip : LevelConditionBase
	{
		// Token: 0x06044652 RID: 280146 RVA: 0x010DE88C File Offset: 0x010DCA8C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			int num = int.Parse(inConditionInfo.GetLimitParams("Pos"));
			SceneTeamItem sceneTeamItem = SceneTeamModel.Instance.GetTeamItems(true)[num - 1];
			return sceneTeamItem != null && sceneTeamItem.IsMyRole() && PhantomBattleController.Instance.GetEquipByIndex(sceneTeamItem.GetConfigId, num - 1) != 0;
		}
	}
}
