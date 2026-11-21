using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E10 RID: 24080
	public class LevelConditionCheckFishingTechUnlock : LevelConditionBase
	{
		// Token: 0x0603A716 RID: 239382 RVA: 0x010854FC File Offset: 0x010836FC
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			int techId;
			if (!int.TryParse(inConditionInfo.GetLimitParams("FishingTechId"), out techId))
			{
				Log.Instance.Error(ELogModule.LevelCondition, ELogAuthor.HYF, "CheckFishingTechUnlock条件参数错误, 无法解析为数值", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			bool flag = (inConditionInfo.GetLimitParams("ReverseUnlockCheck") ?? "FALSE").ToUpper() == "TRUE";
			return FishingModel.Instance.GetFishingTechUnlock(techId) != flag;
		}
	}
}
