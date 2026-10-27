using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BA5 RID: 19365
	public class SkipTaskAdventureGuide : SkipTask
	{
		// Token: 0x060322C7 RID: 205511 RVA: 0x00BA84FC File Offset: 0x00BA66FC
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			string s = (string)data[0];
			string value = (string)data[1];
			EUiTabViewName euiTabViewName = new EUiTabViewName(value);
			if (UiManager.Instance.IsViewShow(EUiViewName.AdventureGuideView) && AdventureGuideModel.Instance.CurrentGuideTabName == euiTabViewName)
			{
				GenericPromptController.Instance.ShowPromptByCode("IsInView", Array.Empty<object>());
				base.Finish();
				return;
			}
			int num = int.Parse(s);
			if (euiTabViewName == EUiTabViewName.NewSoundAreaView && !AdventureGuideModel.Instance.CheckTargetDungeonTypeCanShow((EDungeonType)num))
			{
				GenericPromptController.Instance.ShowPromptByCode("NotOpen", Array.Empty<object>());
				return;
			}
			AdventureGuideController.Instance.OpenGuideView(new EUiTabViewName?(euiTabViewName), new int?(num), delegate(bool success, int viewId)
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
