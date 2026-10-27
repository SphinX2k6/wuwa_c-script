using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D39 RID: 27961
	public class LevelConditionSlotOfCurrentRole : LevelConditionBase
	{
		// Token: 0x06044717 RID: 280343 RVA: 0x010E1720 File Offset: 0x010DF920
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelCondition;
				ELogAuthor author = ELogAuthor.TL;
				string message = "配置错误！条件的参数不应该为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("inConditionInfo.Id", inConditionInfo.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			int num;
			if (!int.TryParse(inConditionInfo.GetLimitParams("Slot"), out num) || num == 0 || num > 4)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.LevelCondition;
				ELogAuthor author2 = ELogAuthor.TL;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
				defaultInterpolatedStringHandler.AppendLiteral("配置错误！条件");
				defaultInterpolatedStringHandler.AppendFormatted<int>(inConditionInfo.Id);
				defaultInterpolatedStringHandler.AppendLiteral("的Slot参数不符合条件类型");
				defaultInterpolatedStringHandler.AppendFormatted<ELevelGeneralCondition>(ELevelGeneralCondition.SlotOfCurrentRole);
				defaultInterpolatedStringHandler.AppendLiteral("的定义");
				instance2.Error(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			SceneTeamItem getCurrentTeamItem = SceneTeamModel.Instance.GetCurrentTeamItem;
			if (getCurrentTeamItem == null)
			{
				return false;
			}
			int num2 = SceneTeamModel.Instance.GetTeamItems(true).IndexOf(getCurrentTeamItem) + 1;
			return num == num2;
		}
	}
}
