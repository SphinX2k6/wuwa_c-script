using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C53 RID: 27731
	public class LevelConditionCheckBattleRoleWeaponType : LevelConditionBase
	{
		// Token: 0x06044512 RID: 279826 RVA: 0x010D6C58 File Offset: 0x010D4E58
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelCondition;
				ELogAuthor author = ELogAuthor.TL;
				string message = "配置错误！条件的参数不应该为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("inConditionInfo.Id", inConditionInfo.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("WeaponType");
			if (limitParams == null)
			{
				return false;
			}
			int num = int.Parse(limitParams);
			int? battleTeamFirstRoleId = RoleModel.Instance.GetBattleTeamFirstRoleId();
			return battleTeamFirstRoleId != null && RoleConfig.Instance.GetRoleConfig(battleTeamFirstRoleId.Value).Value.WeaponType == num;
		}
	}
}
