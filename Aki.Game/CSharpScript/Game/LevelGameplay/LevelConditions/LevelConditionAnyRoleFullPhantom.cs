using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C47 RID: 27719
	public class LevelConditionAnyRoleFullPhantom : LevelConditionBase
	{
		// Token: 0x060444E8 RID: 279784 RVA: 0x010D3BAC File Offset: 0x010D1DAC
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
