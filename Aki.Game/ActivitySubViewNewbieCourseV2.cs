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

// Token: 0x02001399 RID: 5017
[NullableContext(1)]
[Nullable(0)]
public class ActivitySubViewNewbieCourseV2 : ActivitySubViewBase
{
	// Token: 0x06008CB6 RID: 36022 RVA: 0x001E2B90 File Offset: 0x001E0D90
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

	// Token: 0x06008CB7 RID: 36023 RVA: 0x001E2C9E File Offset: 0x001E0E9E
	protected override void OnSetData()
	{
		this.ActivityData = (this.ActivityBaseData as ActivityNewbieCourseV2Data);
	}

	// Token: 0x06008CB8 RID: 36024 RVA: 0x001E2CB4 File Offset: 0x001E0EB4
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewNewbieCourseV2.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewNewbieCourseV2.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008CB9 RID: 36025 RVA: 0x001E2CF7 File Offset: 0x001E0EF7
	protected override void OnRefreshView()
	{
		this.RefreshViewStateAndScrollToFocus();
	}

	// Token: 0x06008CBA RID: 36026 RVA: 0x001E2D00 File Offset: 0x001E0F00
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

	// Token: 0x06008CBB RID: 36027 RVA: 0x001E2D44 File Offset: 0x001E0F44
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

	// Token: 0x06008CBC RID: 36028 RVA: 0x001E2D64 File Offset: 0x001E0F64
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		EventSystem.Instance.Add(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
	}

	// Token: 0x06008CBD RID: 36029 RVA: 0x001E2D9E File Offset: 0x001E0F9E
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		EventSystem.Instance.Remove(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
	}

	// Token: 0x06008CBE RID: 36030 RVA: 0x001E2DD8 File Offset: 0x001E0FD8
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

	// Token: 0x06008CBF RID: 36031 RVA: 0x001E2E5C File Offset: 0x001E105C
	private NewbieCourseV2Item InitItem()
	{
		NewbieCourseV2Item newbieCourseV2Item = new NewbieCourseV2Item();
		if (this.ActivityData != null)
		{
			newbieCourseV2Item.SetActivityData(this.ActivityData);
		}
		return newbieCourseV2Item;
	}

	// Token: 0x06008CC0 RID: 36032 RVA: 0x001E2E84 File Offset: 0x001E1084
	private void OnRefreshCommonActivityRedDot(int activityId)
	{
		if (this.ActivityData == null || this.ActivityData.Id != activityId)
		{
			return;
		}
		this.RefreshViewState();
	}

	// Token: 0x06008CC1 RID: 36033 RVA: 0x001E2EA3 File Offset: 0x001E10A3
	private void OnPlayerLevelChanged(int lastLevel, int currentLevel, int currentExp, int lastExp, int addExp, int currentMaxExp, int lastMaxExp)
	{
		if (this.ActivityData == null)
		{
			return;
		}
		this.RefreshViewStateAndScrollToFocus();
	}

	// Token: 0x06008CC2 RID: 36034 RVA: 0x001E2EB4 File Offset: 0x001E10B4
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

	// Token: 0x06008CC3 RID: 36035 RVA: 0x001E2F41 File Offset: 0x001E1141
	private void RefreshViewStateAndScrollToFocus()
	{
		this.RefreshViewState();
		TimerSystem.GameplayTimeInstance.Next(delegate(float _)
		{
			this.TryScrollRewardListToFocusRow();
		}, null, null);
	}

	// Token: 0x06008CC4 RID: 36036 RVA: 0x001E2F64 File Offset: 0x001E1164
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

	// Token: 0x06008CC5 RID: 36037 RVA: 0x001E2FC0 File Offset: 0x001E11C0
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

	// Token: 0x06008CC6 RID: 36038 RVA: 0x001E3078 File Offset: 0x001E1278
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

	// Token: 0x04003E67 RID: 15975
	private const string NewcomerLogoMaleResourceId = "T_NewcomerLogoMale";

	// Token: 0x04003E68 RID: 15976
	private const string NewcomerLogoFemaleResourceId = "T_NewcomerLogoFemale";

	// Token: 0x04003E69 RID: 15977
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<NewbieCourseV2Item, NewbieCourseV2> RewardListScrollView;

	// Token: 0x04003E6A RID: 15978
	[Nullable(2)]
	private ActivityNewbieCourseV2Data ActivityData;

	// Token: 0x04003E6B RID: 15979
	[Nullable(2)]
	private NewbieCourseV2RewardBannerPanel RewardBannerPanel;

	// Token: 0x02007A08 RID: 31240
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040282A4 RID: 164516
		public const int BtnReward = 0;

		// Token: 0x040282A5 RID: 164517
		public const int TxtTipNum = 1;

		// Token: 0x040282A6 RID: 164518
		public const int SvList = 2;

		// Token: 0x040282A7 RID: 164519
		public const int QuestItem = 3;

		// Token: 0x040282A8 RID: 164520
		public const int TexLogo = 4;

		// Token: 0x040282A9 RID: 164521
		public const int TxtTopInfo = 5;

		// Token: 0x040282AA RID: 164522
		public const int TxtTopTime = 6;
	}
}
