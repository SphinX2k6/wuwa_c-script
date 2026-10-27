using System;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Anniversary
{
	// Token: 0x02006921 RID: 26913
	public class AnniversarySubActivityPinballUiItem : AnniversaryActivityEnterItem
	{
		// Token: 0x060431A9 RID: 274857 RVA: 0x0105A57C File Offset: 0x0105877C
		public override void ChildUpdateTips()
		{
			UUIText text = base.GetText(1);
			if (text == null || this.Data == null)
			{
				return;
			}
			text.SetUIActive(false);
			AnniversarySubActivityPinball anniversarySubActivityPinball = this.Data as AnniversarySubActivityPinball;
			if (anniversarySubActivityPinball == null || anniversarySubActivityPinball.ActivityData == null || !anniversarySubActivityPinball.ActivityData.IsUnLock())
			{
				return;
			}
			if (anniversarySubActivityPinball.GetNewChapter())
			{
				text.SetUIActive(true);
				LguiUtil.Instance.SetLocalTextNew(text, "Activity_Anniversary2_01_New", Array.Empty<object>());
				return;
			}
			long nextLockedChapterTime = anniversarySubActivityPinball.GetNextLockedChapterTime();
			if (nextLockedChapterTime > 0L)
			{
				string text2 = TextConfig.Instance.GetMultiTextByKey("Activity_Anniversary2_01_Time") ?? "";
				string remainTimeText = ActivityModel.Instance.GetRemainTimeText(nextLockedChapterTime, text2);
				if (string.IsNullOrEmpty(remainTimeText))
				{
					return;
				}
				text.SetUIActive(true);
				text.SetText(remainTimeText, true);
			}
		}
	}
}
