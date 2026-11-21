using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200084D RID: 2125
[NullableContext(1)]
[Nullable(0)]
public class ActivitySubViewNewbieCourseV2 : ActivitySubViewBase
{
	// Token: 0x0600604F RID: 24655 RVA: 0x001EB940 File Offset: 0x001E9B40
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06006050 RID: 24656 RVA: 0x001EBA4E File Offset: 0x001E9C4E
	protected override void OnSetData()
	{
		this.ActivityData = (this.ActivityBaseData as ActivityNewbieCourseV2Data);
	}

	// Token: 0x06006051 RID: 24657 RVA: 0x001EBA64 File Offset: 0x001E9C64
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewNewbieCourseV2.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewNewbieCourseV2.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006052 RID: 24658 RVA: 0x001EBAA7 File Offset: 0x001E9CA7
	protected override void OnRefreshView()
	{
		this.RefreshViewStateAndScrollToFocus();
	}

	// Token: 0x06006053 RID: 24659 RVA: 0x001EBAB0 File Offset: 0x001E9CB0
	protected override void OnTimer(float gap)
	{
		if (this.ActivityBaseData == null)
		{
			return;
		}
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		UUIText text = base.GetText(6);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(item);
		text.SetText(item2, true);
	}

	// Token: 0x06006054 RID: 24660 RVA: 0x001EBAF4 File Offset: 0x001E9CF4
	protected override void OnSequenceStart(string sequenceName)
	{
		if (sequenceName != "Start")
		{
			return;
		}
		GenericScrollViewNew<NewbieCourseV2Item, NewbieCourseV2> rewardListScrollView = this.RewardListScrollView;
		if (rewardListScrollView == null)
		{
			return;
		}
		rewardListScrollView.PlayTurnAnimation();
	}

	// Token: 0x06006055 RID: 24661 RVA: 0x001EBB14 File Offset: 0x001E9D14
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		EventSystem.Instance.Add(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
	}

	// Token: 0x06006056 RID: 24662 RVA: 0x001EBB4E File Offset: 0x001E9D4E
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		EventSystem.Instance.Remove(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
	}

	// Token: 0x06006057 RID: 24663 RVA: 0x001EBB88 File Offset: 0x001E9D88
	protected override void OnBeforeDestroy()
	{
		NewbieCourseV2RewardBannerPanel rewardBannerPanel = this.RewardBannerPanel;
		if (rewardBannerPanel != null)
		{
			rewardBannerPanel.Destroy(null);
		}
		this.RewardBannerPanel = null;
		GenericScrollViewNew<NewbieCourseV2Item, NewbieCourseV2> rewardListScrollView = this.RewardListScrollView;
		foreach (NewbieCourseV2Item child in (((rewardListScrollView != null) ? rewardListScrollView.GetScrollItemList() : null) ?? new List<NewbieCourseV2Item>()))
		{
			base.AddChild(child);
		}
	}

	// Token: 0x06006058 RID: 24664 RVA: 0x001EBC0C File Offset: 0x001E9E0C
	private NewbieCourseV2Item InitItem()
	{
		NewbieCourseV2Item newbieCourseV2Item = new NewbieCourseV2Item();
		if (this.ActivityData != null)
		{
			newbieCourseV2Item.SetActivityData(this.ActivityData);
		}
		return newbieCourseV2Item;
	}

	// Token: 0x06006059 RID: 24665 RVA: 0x001EBC34 File Offset: 0x001E9E34
	private void OnRefreshCommonActivityRedDot(int activityId)
	{
		if (this.ActivityData == null || this.ActivityData.Id != activityId)
		{
			return;
		}
		this.RefreshViewState();
	}

	// Token: 0x0600605A RID: 24666 RVA: 0x001EBC53 File Offset: 0x001E9E53
	private void OnPlayerLevelChanged(int lastLevel, int currentLevel, int currentExp, int lastExp, int addExp, int currentMaxExp, int lastMaxExp)
	{
		if (this.ActivityData == null)
		{
			return;
		}
		this.RefreshViewStateAndScrollToFocus();
	}

	// Token: 0x0600605B RID: 24667 RVA: 0x001EBC64 File Offset: 0x001E9E64
	private int GetFocusRewardRowIndex(IReadOnlyList<NewbieCourseV2> configList)
	{
		if (this.ActivityData == null || configList.Count == 0)
		{
			return 0;
		}
		for (int i = 0; i < configList.Count; i++)
		{
			if (this.ActivityData.GetRewardState(configList[i].TargetLevel) == ENewbieCourseV2ItemState.CanReceive)
			{
				return i;
			}
		}
		for (int j = 0; j < configList.Count; j++)
		{
			if (this.ActivityData.GetRewardState(configList[j].TargetLevel) == ENewbieCourseV2ItemState.Unaccomplished)
			{
				return j;
			}
		}
		return Math.Max(configList.Count - 1, 0);
	}

	// Token: 0x0600605C RID: 24668 RVA: 0x001EBCF1 File Offset: 0x001E9EF1
	private void RefreshViewStateAndScrollToFocus()
	{
		this.RefreshViewState();
		TimerSystem.GameplayTimeInstance.Next(delegate(float _)
		{
			this.TryScrollRewardListToFocusRow();
		}, null, null);
	}

	// Token: 0x0600605D RID: 24669 RVA: 0x001EBD14 File Offset: 0x001E9F14
	private void ApplyRewardListContentPadding()
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(2);
		AUIBaseActor auibaseActor = (scrollViewWithScrollbar != null) ? scrollViewWithScrollbar.GetContent() : null;
		if (auibaseActor == null)
		{
			return;
		}
		UUIVerticalLayout uuiverticalLayout = auibaseActor.GetComponentByClass(UUIVerticalLayout.StaticClass()) as UUIVerticalLayout;
		if (uuiverticalLayout == null)
		{
			return;
		}
		FMargin padding = uuiverticalLayout.GetPadding();
		padding.Top = 16f;
		uuiverticalLayout.SetPadding(padding);
	}

	// Token: 0x0600605E RID: 24670 RVA: 0x001EBD70 File Offset: 0x001E9F70
	private void TryScrollRewardListToFocusRow()
	{
		if (this.ActivityData == null || this.RewardListScrollView == null)
		{
			return;
		}
		IReadOnlyList<NewbieCourseV2> configList = ActivityNewbieCourseV2Config.Instance.GetConfigList(this.ActivityData.Id);
		int focusRewardRowIndex = this.GetFocusRewardRowIndex(configList);
		if (focusRewardRowIndex >= configList.Count)
		{
			return;
		}
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(2);
		if (scrollViewWithScrollbar == null)
		{
			return;
		}
		UUIItem itemByIndex = this.RewardListScrollView.GetItemByIndex(focusRewardRowIndex);
		if (itemByIndex == null)
		{
			return;
		}
		UUIItem uuiitem = scrollViewWithScrollbar.ContentUIItem.Get();
		if (uuiitem == null)
		{
			return;
		}
		FVector relativeLocation = uuiitem.RelativeLocation;
		FVector2D fvector2D = new FVector2D(relativeLocation.X, relativeLocation.Y);
		scrollViewWithScrollbar.ScrollToTop(ref fvector2D, itemByIndex, false);
		uuiitem.SetAnchorOffsetY(uuiitem.GetAnchorOffsetY() - 16f);
	}

	// Token: 0x0600605F RID: 24671 RVA: 0x001EBE28 File Offset: 0x001EA028
	private void RefreshViewState()
	{
		int? playerLevel = PlayerInfoModel.Instance.GetPlayerLevel();
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.SetText(playerLevel.ToString(), true);
		}
		UUIText text2 = base.GetText(5);
		if (text2 != null)
		{
			ActivityNewbieCourseV2Data activityData = this.ActivityData;
			text2.SetText(((activityData != null) ? activityData.GetTitle() : null) ?? "", true);
		}
		UUITexture texture = base.GetTexture(4);
		if (texture != null)
		{
			string resourceId = (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male) ? "T_NewcomerLogoMale" : "T_NewcomerLogoFemale";
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			if (!string.IsNullOrEmpty(resourcePath))
			{
				base.SetTextureByPath(resourcePath, texture, null, null);
			}
		}
		if (this.RewardBannerPanel != null)
		{
			NewbieCourseV2RewardBannerPanel rewardBannerPanel = this.RewardBannerPanel;
			ActivityNewbieCourseV2Data activityData2 = this.ActivityData;
			rewardBannerPanel.SetActivityId((activityData2 != null) ? activityData2.Id : 0);
			this.RewardBannerPanel.RefreshWeaponPreviewEntrance();
		}
		GenericScrollViewNew<NewbieCourseV2Item, NewbieCourseV2> rewardListScrollView = this.RewardListScrollView;
		foreach (NewbieCourseV2Item newbieCourseV2Item in (((rewardListScrollView != null) ? rewardListScrollView.GetScrollItemList() : null) ?? new List<NewbieCourseV2Item>()))
		{
			newbieCourseV2Item.RefreshCurrentState();
		}
	}

	// Token: 0x04003EFF RID: 16127
	private const string NewcomerLogoMaleResourceId = "T_NewcomerLogoMale";

	// Token: 0x04003F00 RID: 16128
	private const string NewcomerLogoFemaleResourceId = "T_NewcomerLogoFemale";

	// Token: 0x04003F01 RID: 16129
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<NewbieCourseV2Item, NewbieCourseV2> RewardListScrollView;

	// Token: 0x04003F02 RID: 16130
	[Nullable(2)]
	private ActivityNewbieCourseV2Data ActivityData;

	// Token: 0x04003F03 RID: 16131
	[Nullable(2)]
	private NewbieCourseV2RewardBannerPanel RewardBannerPanel;

	// Token: 0x02006B90 RID: 27536
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040235C7 RID: 144839
		public const int BtnReward = 0;

		// Token: 0x040235C8 RID: 144840
		public const int TxtTipNum = 1;

		// Token: 0x040235C9 RID: 144841
		public const int SvList = 2;

		// Token: 0x040235CA RID: 144842
		public const int QuestItem = 3;

		// Token: 0x040235CB RID: 144843
		public const int TexLogo = 4;

		// Token: 0x040235CC RID: 144844
		public const int TxtTopInfo = 5;

		// Token: 0x040235CD RID: 144845
		public const int TxtTopTime = 6;
	}
}
