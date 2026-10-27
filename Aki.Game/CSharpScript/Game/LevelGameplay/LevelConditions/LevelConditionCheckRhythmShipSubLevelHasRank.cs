using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CE0 RID: 27872
	public class LevelConditionCheckRhythmShipSubLevelHasRank : LevelConditionBase
	{
		// Token: 0x0604465C RID: 280156 RVA: 0x010DEAE8 File Offset: 0x010DCCE8
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			int num;
			if (!int.TryParse(inConditionInfo.GetLimitParams("Id"), out num) || num == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelCondition;
				ELogAuthor author = ELogAuthor.TZJ;
				string message = "LevelConditionCheckRhythmShipSubLevelHasRank]配置错误！条件的参数不应该为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("inConditionInfo.Id", inConditionInfo.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			return RhythmShipModel.Instance.GetSubLevelHasRank(num);
		}
	}
}
