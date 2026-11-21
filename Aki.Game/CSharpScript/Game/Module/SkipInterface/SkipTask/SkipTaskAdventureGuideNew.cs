using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B50 RID: 15184
	public class SkipTaskAdventureGuideNew : SkipTask
	{
		// Token: 0x0602705B RID: 159835 RVA: 0x00AEC870 File Offset: 0x00AEAA70
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			string childViewName = ConfigGuideDataById.GetConfig(int.Parse((string)data[0]), true).Value.ChildViewName;
			string s = (string)data[1];
			string s2 = (string)data[2];
			EUiTabViewName euiTabViewName = new EUiTabViewName(childViewName);
			if (UiManager.Instance.IsViewShow(EUiViewName.AdventureGuideView) && AdventureGuideModel.Instance.CurrentGuideTabName == euiTabViewName)
			{
				GenericPromptController.Instance.ShowPromptByCode("IsInView", Array.Empty<object>());
				base.Finish();
				return;
			}
			int num = int.Parse(s);
			int value = 0;
			int.TryParse(s2, out value);
			if (euiTabViewName == EUiTabViewName.NewSoundAreaView && !AdventureGuideModel.Instance.CheckTargetDungeonTypeCanShow((EDungeonType)num))
			{
				GenericPromptController.Instance.ShowPromptByCode("NotOpen", Array.Empty<object>());
				return;
			}
			AdventureGuideViewOpenData adventureGuideViewOpenData = new AdventureGuideViewOpenData();
			adventureGuideViewOpenData.OpenTabViewName = new EUiTabViewName?(euiTabViewName);
			adventureGuideViewOpenData.OpenParam = new int?(num);
			adventureGuideViewOpenData.JumpToGridId = new int?(value);
			AdventureGuideController.Instance.OpenGuideViewWithOpenData(adventureGuideViewOpenData, delegate(bool success, int viewId)
			{
				base.Finish();
			});
			if (UiManager.Instance.IsViewShow(EUiViewName.AdventureGuideView))
			{
				base.Finish();
			}
		}
	}
}
