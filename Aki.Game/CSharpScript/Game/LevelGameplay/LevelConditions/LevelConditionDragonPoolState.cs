using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.MingSu;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D1D RID: 27933
	public class LevelConditionDragonPoolState : LevelConditionBase
	{
		// Token: 0x060446DE RID: 280286 RVA: 0x010E0B34 File Offset: 0x010DED34
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("DragonPoolId");
			string limitParams2 = inConditionInfo.GetLimitParams("State");
			return limitParams != null && limitParams2 != null && MingSuModel.Instance.GetTargetDragonPoolActiveById(int.Parse(limitParams)) == int.Parse(limitParams2);
		}
	}
}
