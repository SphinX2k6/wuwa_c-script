using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E14 RID: 24084
	public class LevelConditionCheckFormationViewDimension : LevelConditionBase
	{
		// Token: 0x0603A71E RID: 239390 RVA: 0x0108572C File Offset: 0x0108392C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("Dimension");
			if (limitParams == null)
			{
				return false;
			}
			int num = int.Parse(limitParams);
			if (num == 2)
			{
				return UiManager.Instance.IsViewOpen(EUiViewName.Formation2DView);
			}
			return num == 3 && UiManager.Instance.IsViewOpen(EUiViewName.Formation3DView);
		}
	}
}
