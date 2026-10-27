using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Tetris;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CF6 RID: 27894
	public class LevelConditionCheckTetrisScore : LevelConditionBase
	{
		// Token: 0x0604468F RID: 280207 RVA: 0x010DF9DC File Offset: 0x010DDBDC
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			int num;
			if (!int.TryParse(inConditionInfo.GetLimitParams("Score"), out num) || num == 0)
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
			if (tetrisPlayView == null)
			{
				return false;
			}
			int? num2;
			if (tetrisPlayView == null)
			{
				num2 = null;
			}
			else
			{
				TetrisPlayController tetrisPlayController = tetrisPlayView.GetTetrisPlayController();
				num2 = ((tetrisPlayController != null) ? new int?(tetrisPlayController.GetCurrentScore()) : null);
			}
			int? num3 = num2;
			int num4 = num;
			return num3.GetValueOrDefault() >= num4 & num3 != null;
		}
	}
}
