using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D5D RID: 27997
	public class LevelConditionOnHonamiStoryLifeSupportChange : LevelConditionBase
	{
		// Token: 0x06044760 RID: 280416 RVA: 0x010E27A4 File Offset: 0x010E09A4
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			float num = (float)eventArgs[0];
			float num2 = (float)eventArgs[1];
			string limitParams = inConditionInfo.GetLimitParams("CheckLower");
			if (limitParams == null)
			{
				return false;
			}
			if (limitParams == "TRUE")
			{
				return num2 < num;
			}
			string limitParams2 = inConditionInfo.GetLimitParams("CheckPercent");
			if (limitParams2 == null)
			{
				return false;
			}
			float num3;
			if (float.TryParse(limitParams2, out num3))
			{
				float max = FormationAttributeController.Instance.GetMax(EFormationAttributeId.HonamiStoryLifeSupport);
				return num2 / max * 100f < num3;
			}
			return false;
		}
	}
}
