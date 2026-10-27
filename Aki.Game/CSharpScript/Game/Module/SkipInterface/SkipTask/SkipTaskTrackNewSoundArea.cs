using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BB9 RID: 19385
	public class SkipTaskTrackNewSoundArea : SkipTask
	{
		// Token: 0x06032300 RID: 205568 RVA: 0x00BA971C File Offset: 0x00BA791C
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			string s = (string)data[0];
			EUiTabViewName newSoundAreaView = EUiTabViewName.NewSoundAreaView;
			if (UiManager.Instance.IsViewShow(EUiViewName.AdventureGuideView) && AdventureGuideModel.Instance.CurrentGuideTabName == newSoundAreaView)
			{
				GenericPromptController.Instance.ShowPromptByCode("IsInView", Array.Empty<object>());
				base.Finish();
				return;
			}
			if (newSoundAreaView == EUiTabViewName.NewSoundAreaView && !AdventureGuideModel.Instance.CheckTargetDungeonTypeCanShow(EDungeonType.NoSoundArea))
			{
				GenericPromptController.Instance.ShowPromptByCode("NotOpen", Array.Empty<object>());
				return;
			}
			AdventureGuideViewOpenData adventureGuideViewOpenData = new AdventureGuideViewOpenData();
			adventureGuideViewOpenData.OpenTabViewName = new EUiTabViewName?(newSoundAreaView);
			int num = int.Parse(s);
			SilentAreaDetection? silentAreaDetectionConfById = AdventureGuideConfig.Instance.GetSilentAreaDetectionConfById(num);
			if (silentAreaDetectionConfById == null)
			{
				return;
			}
			adventureGuideViewOpenData.OpenParam = new int?(silentAreaDetectionConfById.Value.Secondary);
			adventureGuideViewOpenData.NewSoundDetectTracingIdList = new int[]
			{
				num
			};
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
