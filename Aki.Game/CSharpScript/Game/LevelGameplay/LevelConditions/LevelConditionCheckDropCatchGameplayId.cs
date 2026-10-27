using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C71 RID: 27761
	public class LevelConditionCheckDropCatchGameplayId : LevelConditionBase
	{
		// Token: 0x0604456C RID: 279916 RVA: 0x010D8FDC File Offset: 0x010D71DC
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			int num;
			if (int.TryParse(inConditionInfo.GetLimitParams("id") ?? string.Empty, out num) && num != 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelCondition;
				ELogAuthor author = ELogAuthor.TZJ;
				string message = "LevelConditionCheckDropCatchGameplayId配置错误！条件的参数不应该为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("inConditionInfo.Id", inConditionInfo.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			return DropCatchGameplayController.Instance.GetCurrentGameplayId() == num;
		}
	}
}
