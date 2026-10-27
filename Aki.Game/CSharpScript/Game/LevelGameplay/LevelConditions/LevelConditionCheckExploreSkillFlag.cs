using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C89 RID: 27785
	public class LevelConditionCheckExploreSkillFlag : LevelConditionBase
	{
		// Token: 0x060445A4 RID: 279972 RVA: 0x010DACD4 File Offset: 0x010D8ED4
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelCondition;
				ELogAuthor author = ELogAuthor.TZJ;
				string message = "LevelConditionCheckExploreSkillFlag配置错误！条件的参数不应该为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("inConditionInfo.Id", inConditionInfo.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			int num = int.Parse(inConditionInfo.GetLimitParams("SkillId"));
			if (num == 0)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.LevelCondition;
				ELogAuthor author2 = ELogAuthor.TZJ;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
				defaultInterpolatedStringHandler.AppendLiteral("配置错误！条件");
				defaultInterpolatedStringHandler.AppendFormatted<int>(inConditionInfo.Id);
				defaultInterpolatedStringHandler.AppendLiteral("的SkillId应该是数字");
				instance2.Error(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			bool flag = int.Parse(inConditionInfo.GetLimitParams("Value")) != 0;
			return ExploreSkillFlagModel.Instance.GetExploreSkillFlagEnable((EExploreSkillType)num) == flag;
		}
	}
}
