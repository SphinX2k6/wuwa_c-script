using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001689 RID: 5769
public class ActivitySubViewRun : ActivitySubViewBase
{
	// Token: 0x0600A393 RID: 41875 RVA: 0x00242F84 File Offset: 0x00241184
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickConfirmBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A394 RID: 41876 RVA: 0x00243114 File Offset: 0x00241314
	protected override void OnStart()
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(4);
		this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(scrollViewWithScrollbar, this.CreatePropItem, null, false, null);
	}

	// Token: 0x0600A395 RID: 41877 RVA: 0x0024313E File Offset: 0x0024133E
	private void OnClickConfirmBtn()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			if (this.ActivityBaseData.GetPreGuideQuestFinishState())
			{
				ActivityController.Instance.RequestReadActivity(this.ActivityBaseData);
				ActivityController.Instance.OpenActivityContentView(this.ActivityBaseData);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.QuestView, this.ActivityBaseData.GetUnFinishPreGuideQuestId(), null);
		});
	}

	// Token: 0x0600A396 RID: 41878 RVA: 0x0024315C File Offset: 0x0024135C
	protected override void OnRefreshView()
	{
		this.RefreshTimerText();
		this.RefreshRewards();
		this.RefreshTitle();
		this.RefreshContent();
		this.BindRedPoint();
		this.RefreshConfirmButton();
		this.RefreshPreConditionText();
	}

	// Token: 0x0600A397 RID: 41879 RVA: 0x00243188 File Offset: 0x00241388
	public void BindRedPoint()
	{
		if (!this.RedPointBindState)
		{
			this.RedPointBindState = true;
			RedDotController.Instance.BindRedDot(ERedDotName.CommonActivityPage, base.GetItem(6), null, this.ActivityBaseData.Id);
		}
	}

	// Token: 0x0600A398 RID: 41880 RVA: 0x002431B8 File Offset: 0x002413B8
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x0600A399 RID: 41881 RVA: 0x002431C0 File Offset: 0x002413C0
	private void RefreshTitle()
	{
		base.GetText(0).SetText(this.ActivityBaseData.GetTitle(), true);
	}

	// Token: 0x0600A39A RID: 41882 RVA: 0x002431DC File Offset: 0x002413DC
	private void RefreshContent()
	{
		base.GetText(1).ShowTextNew(this.ActivityBaseData.LocalConfig.Value.Desc);
		if (this.ActivityBaseData.IsUnLock() && this.ActivityBaseData.GetPreGuideQuestFinishState())
		{
			base.GetText(5).ShowTextNew("ReadyToFightText");
			return;
		}
		base.GetText(5).ShowTextNew("JumpToQuestText");
	}

	// Token: 0x0600A39B RID: 41883 RVA: 0x0024324C File Offset: 0x0024144C
	private void RefreshConfirmButton()
	{
		base.GetButton(3).RootUIComp.Get().SetUIActive(this.ActivityBaseData.IsUnLock());
	}

	// Token: 0x0600A39C RID: 41884 RVA: 0x00243280 File Offset: 0x00241480
	private void RefreshRewards()
	{
		List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
		this.RewardScrollView.RefreshByData(previewReward, null, false);
	}

	// Token: 0x0600A39D RID: 41885 RVA: 0x002432B0 File Offset: 0x002414B0
	private void RefreshTimerText()
	{
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		base.GetText(2).SetUIActive(item);
		if (item)
		{
			base.GetText(2).SetText(item2, true);
		}
	}

	// Token: 0x0600A39E RID: 41886 RVA: 0x002432F0 File Offset: 0x002414F0
	private void RefreshPreConditionText()
	{
		UUIText text = base.GetText(7);
		bool flag = !this.ActivityBaseData.IsUnLock() || !this.ActivityBaseData.GetPreGuideQuestFinishState();
		base.GetItem(8).SetUIActive(flag);
		if (flag)
		{
			text.SetText(this.GetCurrentLockConditionText(), true);
		}
	}

	// Token: 0x0600A39F RID: 41887 RVA: 0x00243341 File Offset: 0x00241541
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.CommonActivityPage, base.GetItem(6), this.ActivityBaseData.Id);
	}

	// Token: 0x0600A3A0 RID: 41888 RVA: 0x00243364 File Offset: 0x00241564
	[NullableContext(1)]
	protected override string GetCurrentLockConditionText()
	{
		string currentLockConditionText = base.GetCurrentLockConditionText();
		string text = (currentLockConditionText == "") ? currentLockConditionText : ConfigMultiTextLang.GetLocalTextNew(currentLockConditionText, null);
		if (StringUtils.IsEmpty(text))
		{
			string preShowGuideQuestName = this.ActivityBaseData.GetPreShowGuideQuestName();
			text = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("Text_ActivityNeedPreGiideQuest_Text", null), new string[]
			{
				preShowGuideQuestName
			});
		}
		return text;
	}

	// Token: 0x04004A4A RID: 19018
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x04004A4B RID: 19019
	private bool RedPointBindState;

	// Token: 0x04004A4C RID: 19020
	[Nullable(1)]
	private readonly Func<CommonItemSmallItemGrid> CreatePropItem = () => new CommonItemSmallItemGrid();

	// Token: 0x02007C57 RID: 31831
	private class EComponents
	{
		// Token: 0x04028CCD RID: 167117
		public const int TitleText = 0;

		// Token: 0x04028CCE RID: 167118
		public const int TxtContent = 1;

		// Token: 0x04028CCF RID: 167119
		public const int RemainTimeText = 2;

		// Token: 0x04028CD0 RID: 167120
		public const int ConfirmButton = 3;

		// Token: 0x04028CD1 RID: 167121
		public const int RewardPreviewScroller = 4;

		// Token: 0x04028CD2 RID: 167122
		public const int TxtFunc = 5;

		// Token: 0x04028CD3 RID: 167123
		public const int RedDot = 6;

		// Token: 0x04028CD4 RID: 167124
		public const int PreMissionText = 7;

		// Token: 0x04028CD5 RID: 167125
		public const int PnlCondition = 8;
	}
}
