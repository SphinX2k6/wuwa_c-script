using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C92 RID: 27794
	public class LevelConditionCheckCurFishingEntrustAvailablePeriod : LevelConditionBase
	{
		// Token: 0x060445B4 RID: 279988 RVA: 0x010DB448 File Offset: 0x010D9648
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("ExceptedPeriod");
			if (limitParams == null)
			{
				return false;
			}
			int currentTraceEntrust = FishingQuestModel.Instance.CurrentTraceEntrust;
			if (currentTraceEntrust == 0)
			{
				return false;
			}
			FishingEntrust? fishingEntrust = FishingConfig.Instance.GetFishingEntrust(currentTraceEntrust);
			return limitParams.ToUpper() == (fishingEntrust.Value.IsNight ? "NIGHT" : "DAY");
		}
	}
}
