using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005DC1 RID: 24001
	public class LevelConditionCheckCalabashChildFunctionOpen : LevelConditionBase
	{
		// Token: 0x0603A642 RID: 239170 RVA: 0x0107DB0C File Offset: 0x0107BD0C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("ChildViewName");
			if (limitParams == null)
			{
				return false;
			}
			UiDynamicTab[] viewTabList = CalabashModel.Instance.GetViewTabList();
			bool flag = false;
			foreach (UiDynamicTab uiDynamicTab in viewTabList)
			{
				if (uiDynamicTab.ChildViewName == limitParams)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return false;
			}
			VisionIntensifyView visionIntensifyView = UiManager.Instance.GetViewByName(EUiViewName.VisionIntensifyView) as VisionIntensifyView;
			if (visionIntensifyView == null)
			{
				return false;
			}
			int currentUniqueId = visionIntensifyView.GetCurrentUniqueId();
			PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(currentUniqueId);
			return phantomBattleData != null && phantomBattleData.GetVisionIfCanRefine(EVisionRefineRefineType.Main);
		}
	}
}
