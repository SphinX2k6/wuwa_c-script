using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005DC0 RID: 24000
	public class LevelConditionAnyRoleFullPhantom : LevelConditionBase
	{
		// Token: 0x0603A640 RID: 239168 RVA: 0x0107DA5C File Offset: 0x0107BC5C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("CheckValue");
			if (limitParams == null)
			{
				return false;
			}
			bool flag = limitParams == "TRUE";
			foreach (SceneTeamItem sceneTeamItem in SceneTeamModel.Instance.GetTeamItems(true))
			{
				PhantomRoleEquipmentData battleDataById = PhantomBattleModel.Instance.GetBattleDataById(sceneTeamItem.GetConfigId);
				if (battleDataById == null || !battleDataById.CheckHasEmpty())
				{
					return flag;
				}
			}
			return !flag;
		}
	}
}
