using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E7C RID: 24188
	public class LevelConditionCheckUIState : LevelConditionBase
	{
		// Token: 0x0603A801 RID: 239617 RVA: 0x01089FC8 File Offset: 0x010881C8
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("UIName");
			string limitParams2 = inConditionInfo.GetLimitParams("UIState");
			int num;
			if (limitParams == null || limitParams2 == null || !int.TryParse(limitParams2, out num))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelCondition;
				ELogAuthor author = ELogAuthor.TL;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
				defaultInterpolatedStringHandler.AppendLiteral("配置错误！条件");
				defaultInterpolatedStringHandler.AppendFormatted<int>(inConditionInfo.Id);
				defaultInterpolatedStringHandler.AppendLiteral("的参数不符合条件类型");
				defaultInterpolatedStringHandler.AppendFormatted<ELevelGeneralCondition>(ELevelGeneralCondition.CheckUIState);
				defaultInterpolatedStringHandler.AppendLiteral("的定义");
				instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			if (num != 0)
			{
				return UiManager.Instance.IsViewShow((EUiViewName)limitParams);
			}
			return !UiManager.Instance.IsViewShow((EUiViewName)limitParams);
		}
	}
}
