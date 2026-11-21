using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E0D RID: 24077
	public class LevelConditionCheckFishingEntrustState : LevelConditionBase
	{
		// Token: 0x0603A710 RID: 239376 RVA: 0x01085460 File Offset: 0x01083660
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("EntrustId");
			string limitParams2 = inConditionInfo.GetLimitParams("EntrustState");
			int key;
			int num;
			if (!int.TryParse(limitParams, out key) || !int.TryParse(limitParams2, out num))
			{
				Log.Instance.Error(ELogModule.LevelCondition, ELogAuthor.HYF, "CheckFishingEntrustState条件参数错误, 无法解析为数值", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			EFishingEntrustState efishingEntrustState;
			if (!FishingQuestModel.Instance.CurrentEntrusts.TryGetValue(key, out efishingEntrustState))
			{
				return num == -1;
			}
			return efishingEntrustState == (EFishingEntrustState)num;
		}

		// Token: 0x0401EC6C RID: 126060
		private const int NONE_OR_FINISHED = -1;
	}
}
