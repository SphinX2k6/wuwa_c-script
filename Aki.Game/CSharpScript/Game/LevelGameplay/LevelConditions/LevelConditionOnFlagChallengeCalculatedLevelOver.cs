using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Battle;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005ED9 RID: 24281
	public class LevelConditionOnFlagChallengeCalculatedLevelOver : LevelConditionBase
	{
		// Token: 0x0603A8BE RID: 239806 RVA: 0x0108C88C File Offset: 0x0108AA8C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("Level");
			int num;
			if (limitParams == null || int.TryParse(limitParams, out num) || num == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelCondition;
				ELogAuthor author = ELogAuthor.TZJ;
				string message = "LevelConditionOnFlagChallengeCalculatedLevelOver配置错误！条件的参数不应该为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("inConditionInfo.Id", inConditionInfo.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			return FlagChallengeBattleModel.Instance.GetCalculatedLevel() >= num;
		}
	}
}
