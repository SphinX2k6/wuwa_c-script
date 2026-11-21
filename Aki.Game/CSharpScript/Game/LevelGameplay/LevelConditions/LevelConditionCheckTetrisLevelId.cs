using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Game.Module.Activity.ActivityContent.Tetris.View;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E72 RID: 24178
	public class LevelConditionCheckTetrisLevelId : LevelConditionBase
	{
		// Token: 0x0603A7ED RID: 239597 RVA: 0x01089ACC File Offset: 0x01087CCC
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
				string message = "LevelConditionCheckTetrisLevelId配置错误！条件的参数不应该为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("inConditionInfo.Id", inConditionInfo.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			TetrisPlayView tetrisPlayView = UiManager.Instance.GetViewByName(EUiViewName.TetrisPlayView) as TetrisPlayView;
			if (tetrisPlayView != null)
			{
				Tetris? tetris;
				int? num2 = (tetrisPlayView.GetTetrisPlayController().GetCurrentConfig() != null) ? new int?(tetris.GetValueOrDefault().Id) : null;
				int num3 = num;
				return num2.GetValueOrDefault() == num3 & num2 != null;
			}
			return false;
		}
	}
}
