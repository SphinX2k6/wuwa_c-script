using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C9A RID: 27802
	public class LevelConditionCheckFormationViewDimension : LevelConditionBase
	{
		// Token: 0x060445C4 RID: 280004 RVA: 0x010DB780 File Offset: 0x010D9980
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
