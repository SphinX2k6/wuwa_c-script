using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E44 RID: 24132
	public class LevelConditionCheckOnSelectSettingMainType : LevelConditionBase
	{
		// Token: 0x0603A788 RID: 239496 RVA: 0x010878F0 File Offset: 0x01085AF0
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("MainType");
			if (limitParams == null)
			{
				return false;
			}
			if (!UiManager.Instance.IsViewOpen(EUiViewName.MenuView))
			{
				return false;
			}
			MenuView menuView = UiManager.Instance.GetViewByName(EUiViewName.MenuView) as MenuView;
			return int.Parse(limitParams) == menuView.MenuViewDataExternal.MenuViewDataCurMainType;
		}
	}
}
