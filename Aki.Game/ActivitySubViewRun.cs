using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B41 RID: 2881
public class ActivitySubViewRun : ActivitySubViewBase
{
	// Token: 0x06007771 RID: 30577 RVA: 0x0024CFEC File Offset: 0x0024B1EC
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

	// Token: 0x06007772 RID: 30578 RVA: 0x0024D17C File Offset: 0x0024B37C
	protected override void OnStart()
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(4);
		this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(scrollViewWithScrollbar, this.CreatePropItem, null, false, null);
	}

	// Token: 0x06007773 RID: 30579 RVA: 0x0024D1A6 File Offset: 0x0024B3A6
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

	// Token: 0x06007774 RID: 30580 RVA: 0x0024D1C4 File Offset: 0x0024B3C4
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

	// Token: 0x06007775 RID: 30581 RVA: 0x0024D1F0 File Offset: 0x0024B3F0
	public void BindRedPoint()
	{
		if (!this.RedPointBindState)
		{
			this.RedPointBindState = true;
			RedDotController.Instance.BindRedDot(ERedDotName.CommonActivityPage, base.GetItem(6), null, this.ActivityBaseData.Id);
		}
	}

	// Token: 0x06007776 RID: 30582 RVA: 0x0024D220 File Offset: 0x0024B420
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x06007777 RID: 30583 RVA: 0x0024D228 File Offset: 0x0024B428
	private void RefreshTitle()
	{
		base.GetText(0).SetText(this.ActivityBaseData.GetTitle(), true);
	}

	// Token: 0x06007778 RID: 30584 RVA: 0x0024D244 File Offset: 0x0024B444
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

	// Token: 0x06007779 RID: 30585 RVA: 0x0024D2B4 File Offset: 0x0024B4B4
	private void RefreshConfirmButton()
	{
		base.GetButton(3).RootUIComp.Get().SetUIActive(this.ActivityBaseData.IsUnLock());
	}

	// Token: 0x0600777A RID: 30586 RVA: 0x0024D2E8 File Offset: 0x0024B4E8
	private void RefreshRewards()
	{
		List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
		this.RewardScrollView.RefreshByData(previewReward, null, false);
	}

	// Token: 0x0600777B RID: 30587 RVA: 0x0024D318 File Offset: 0x0024B518
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

	// Token: 0x0600777C RID: 30588 RVA: 0x0024D358 File Offset: 0x0024B558
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

	// Token: 0x0600777D RID: 30589 RVA: 0x0024D3A9 File Offset: 0x0024B5A9
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.CommonActivityPage, base.GetItem(6), this.ActivityBaseData.Id);
	}

	// Token: 0x0600777E RID: 30590 RVA: 0x0024D3CC File Offset: 0x0024B5CC
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

	// Token: 0x04004AF1 RID: 19185
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x04004AF2 RID: 19186
	private bool RedPointBindState;

	// Token: 0x04004AF3 RID: 19187
	[Nullable(1)]
	private readonly Func<CommonItemSmallItemGrid> CreatePropItem = () => new CommonItemSmallItemGrid();

	// Token: 0x02006DDC RID: 28124
	private class EComponents
	{
		// Token: 0x04023FF7 RID: 147447
		public const int TitleText = 0;

		// Token: 0x04023FF8 RID: 147448
		public const int TxtContent = 1;

		// Token: 0x04023FF9 RID: 147449
		public const int RemainTimeText = 2;

		// Token: 0x04023FFA RID: 147450
		public const int ConfirmButton = 3;

		// Token: 0x04023FFB RID: 147451
		public const int RewardPreviewScroller = 4;

		// Token: 0x04023FFC RID: 147452
		public const int TxtFunc = 5;

		// Token: 0x04023FFD RID: 147453
		public const int RedDot = 6;

		// Token: 0x04023FFE RID: 147454
		public const int PreMissionText = 7;

		// Token: 0x04023FFF RID: 147455
		public const int PnlCondition = 8;
	}
}
