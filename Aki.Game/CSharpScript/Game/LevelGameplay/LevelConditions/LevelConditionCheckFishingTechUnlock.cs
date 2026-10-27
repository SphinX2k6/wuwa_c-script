using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C96 RID: 27798
	public class LevelConditionCheckFishingTechUnlock : LevelConditionBase
	{
		// Token: 0x060445BC RID: 279996 RVA: 0x010DB550 File Offset: 0x010D9750
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
