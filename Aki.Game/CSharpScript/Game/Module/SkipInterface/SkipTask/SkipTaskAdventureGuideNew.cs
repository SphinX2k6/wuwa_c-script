using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BA6 RID: 19366
	public class SkipTaskAdventureGuideNew : SkipTask
	{
		// Token: 0x060322CA RID: 205514 RVA: 0x00BA85FC File Offset: 0x00BA67FC
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
