using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B4F RID: 15183
	public class SkipTaskAdventureGuide : SkipTask
	{
		// Token: 0x06027058 RID: 159832 RVA: 0x00AEC744 File Offset: 0x00AEA944
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
			int? jumpToGridId = null;
			int num2;
			if (data.Length > 2 && int.TryParse(data[2] as string, out num2) && num2 > 0)
			{
				jumpToGridId = new int?(num2);
			}
			if (euiTabViewName == EUiTabViewName.NewSoundAreaView && !AdventureGuideModel.Instance.CheckTargetDungeonTypeCanShow((EDungeonType)num))
			{
				GenericPromptController.Instance.ShowPromptByCode("NotOpen", Array.Empty<object>());
				return;
			}
			AdventureGuideController.Instance.OpenGuideView(new EUiTabViewName?(euiTabViewName), new int?(num), delegate(bool success, int viewId)
			{
				base.Finish();
			}, jumpToGridId);
			if (UiManager.Instance.IsViewShow(EUiViewName.AdventureGuideView))
			{
				base.Finish();
			}
		}
	}
}
