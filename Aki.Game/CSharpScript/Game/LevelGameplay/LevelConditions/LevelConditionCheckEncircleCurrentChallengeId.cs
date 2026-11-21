using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Game.Module.Activity.ActivityContent.Encircle;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005DF3 RID: 24051
	public class LevelConditionCheckEncircleCurrentChallengeId : LevelConditionBase
	{
		// Token: 0x0603A6D9 RID: 239321 RVA: 0x0108352C File Offset: 0x0108172C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelCondition;
				ELogAuthor author = ELogAuthor.TZJ;
				string message = "LevelConditionCheckEncircleCurrentChallengeId配置错误！条件的参数不应该为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("inConditionInfo.Id", inConditionInfo.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("ChallengeId");
			if (limitParams == null)
			{
				return false;
			}
			int num;
			int.TryParse(limitParams, out num);
			return EncirclePlayLevelController.Instance.GetCurrentChallengeId() == num;
		}
	}
}
