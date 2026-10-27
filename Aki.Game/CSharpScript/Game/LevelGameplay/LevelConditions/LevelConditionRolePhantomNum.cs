using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D7D RID: 28029
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelConditionRolePhantomNum : LevelConditionBase
	{
		// Token: 0x060447B3 RID: 280499 RVA: 0x010E3BE4 File Offset: 0x010E1DE4
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			int num;
			if (!int.TryParse(inConditionInfo.GetLimitParams("RoleId"), out num))
			{
				return false;
			}
			int targetValue;
			if (!int.TryParse(inConditionInfo.GetLimitParams("Value"), out targetValue))
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("Op");
			if (limitParams == null)
			{
				return false;
			}
			if (num > 0)
			{
				return this.CheckRolePhantomNum(num, targetValue, limitParams);
			}
			foreach (RoleInstance roleInstance in RoleModel.Instance.GetRoleList())
			{
				if (this.CheckRolePhantomNum(roleInstance.GetRoleId(), targetValue, limitParams))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060447B4 RID: 280500 RVA: 0x010E3C81 File Offset: 0x010E1E81
		private bool CheckRolePhantomNum(int roleId, int targetValue, string op)
		{
			return RoleModel.Instance.GetRoleInstanceById(roleId) != null && base.CheckCompareValue(op, (double)PhantomBattleModel.Instance.GetBattleDataById(roleId).GetEquippedNum(), (double)targetValue);
		}
	}
}
