using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CF3 RID: 27891
	public class LevelConditionCheckTeleportStatus : LevelConditionBase
	{
		// Token: 0x06044689 RID: 280201 RVA: 0x010DF7D8 File Offset: 0x010DD9D8
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("TeleportId");
			string limitParams2 = inConditionInfo.GetLimitParams("State");
			if (limitParams == null)
			{
				return false;
			}
			if (((limitParams2 != null) ? int.Parse(limitParams2) : 0) == 1)
			{
				return MapModel.Instance.CheckTeleportUnlocked(int.Parse(limitParams));
			}
			return !MapModel.Instance.CheckTeleportUnlocked(int.Parse(limitParams));
		}
	}
}
