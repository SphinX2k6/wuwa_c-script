using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C48 RID: 27720
	public class LevelConditionCheckCalabashChildFunctionOpen : LevelConditionBase
	{
		// Token: 0x060444EA RID: 279786 RVA: 0x010D3C5C File Offset: 0x010D1E5C
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
