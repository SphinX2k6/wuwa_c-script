using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E70 RID: 24176
	public class LevelConditionCheckTeleportStatus : LevelConditionBase
	{
		// Token: 0x0603A7E9 RID: 239593 RVA: 0x010899B8 File Offset: 0x01087BB8
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
