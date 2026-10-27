using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200165E RID: 5726
[NullableContext(2)]
[Nullable(0)]
public class WuWuLogisticsActivitySubView : ActivitySubViewBase
{
	// Token: 0x0600A172 RID: 41330 RVA: 0x0023A260 File Offset: 0x00238460
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent))
		};
	}

	// Token: 0x0600A173 RID: 41331 RVA: 0x0023A312 File Offset: 0x00238512
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.RefreshConfirmButtonRedPoint));
	}

	// Token: 0x0600A174 RID: 41332 RVA: 0x0023A330 File Offset: 0x00238530
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.RefreshConfirmButtonRedPoint));
	}

	// Token: 0x0600A175 RID: 41333 RVA: 0x0023A34E File Offset: 0x0023854E
	protected override void OnSetData()
	{
		this.ActivityData = (this.ActivityBaseData as WuWuLogisticsActivityData);
	}

	// Token: 0x0600A176 RID: 41334 RVA: 0x0023A364 File Offset: 0x00238564
	protected override UniTask OnBeforeStartAsync()
	{
		WuWuLogisticsActivitySubView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WuWuLogisticsActivitySubView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A177 RID: 41335 RVA: 0x0023A3A8 File Offset: 0x002385A8
	protected override void OnStart()
	{
		ActivityBaseData activityBaseData = this.ActivityBaseData;
		ActivityTitleTypeA titleComponent = this.TitleComponent;
		if (titleComponent != null)
		{
			titleComponent.SetActivityBaseData(activityBaseData);
		}
		ActivityTitleTypeA titleComponent2 = this.TitleComponent;
		if (titleComponent2 != null)
		{
			titleComponent2.SetTitleByText(activityBaseData.GetTitle());
		}
		string descTheme = activityBaseData.LocalConfig.Value.DescTheme;
		if (!StringUtils.IsEmpty(descTheme))
		{
			this.TitleComponent.SetSubTitleByTextId(descTheme, Array.Empty<string>());
		}
		ActivityDescriptionTypeA descriptionComponent = this.DescriptionComponent;
		if (descriptionComponent != null)
		{
			descriptionComponent.SetContentByTextId(activityBaseData.LocalConfig.Value.Desc, Array.Empty<string>());
		}
		this.InitButtonState();
		this.RefreshDisabledBar();
	}

	// Token: 0x0600A178 RID: 41336 RVA: 0x0023A44A File Offset: 0x0023864A
	protected override void OnRefreshView()
	{
		this.RefreshRewardComponent();
		this.RefreshTimerText();
		this.RefreshCurProgress();
		this.RefreshConfirmButtonRedPoint(0);
		this.RefreshDisabledBar();
	}

	// Token: 0x0600A179 RID: 41337 RVA: 0x0023A46B File Offset: 0x0023866B
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x0600A17A RID: 41338 RVA: 0x0023A473 File Offset: 0x00238673
	protected void InitButtonState()
	{
		this.ConfirmQuick = new ButtonItem(base.GetButton(6).RootUIComp);
		this.ConfirmQuick.SetFunction(new Action<int>(this.OnClickedForwardButton));
	}

	// Token: 0x0600A17B RID: 41339 RVA: 0x0023A4A8 File Offset: 0x002386A8
	private void RefreshTimerText()
	{
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		if (item)
		{
			this.TitleComponent.SetTimeTextByText(item2);
		}
	}

	// Token: 0x0600A17C RID: 41340 RVA: 0x0023A4D8 File Offset: 0x002386D8
	private void RefreshRewardComponent()
	{
		List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
		this.RewardListComponent.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.RewardListComponent.InitCommonGridItem));
		this.RewardListComponent.RefreshItemLayout(previewReward, null);
	}

	// Token: 0x0600A17D RID: 41341 RVA: 0x0023A523 File Offset: 0x00238723
	private void OnClickedForwardButton(int data)
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
			{
				int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
				UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.WuWuLogisticsMissionView, null, null);
		});
	}

	// Token: 0x0600A17E RID: 41342 RVA: 0x0023A544 File Offset: 0x00238744
	private void RefreshDisabledBar()
	{
		ActivityBaseData data = this.ActivityBaseData;
		FunctionalPanelConditionLock disabledBarPanel = this.DisabledBarPanel;
		UUIItem item = base.GetItem(5);
		if (data == null || disabledBarPanel == null || item == null)
		{
			return;
		}
		if (!data.IsUnLock())
		{
			item.SetUIActive(true);
			disabledBarPanel.SetSpriteVisible(true);
			disabledBarPanel.SetButtonVisible(true);
			string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(data.ConditionGroupId);
			if (!string.IsNullOrEmpty(conditionGroupHintText))
			{
				disabledBarPanel.SetTextByTextId(conditionGroupHintText, Array.Empty<string>());
			}
			disabledBarPanel.ButtonCallBack = delegate()
			{
				ActivityController.Instance.OpenActivityConditionView(data.Id);
			};
			ButtonItem confirmQuick = this.ConfirmQuick;
			if (confirmQuick == null)
			{
				return;
			}
			confirmQuick.SetUiActive(false);
			return;
		}
		else if (!data.GetPreGuideQuestFinishState())
		{
			item.SetUIActive(true);
			disabledBarPanel.SetSpriteVisible(false);
			disabledBarPanel.SetButtonVisible(false);
			string preShowGuideQuestName = data.GetPreShowGuideQuestName();
			disabledBarPanel.SetTextByTextId("Text_ActivityNeedPreGiideQuest_Text", new string[]
			{
				preShowGuideQuestName
			});
			disabledBarPanel.ButtonCallBack = null;
			ButtonItem confirmQuick2 = this.ConfirmQuick;
			if (confirmQuick2 == null)
			{
				return;
			}
			confirmQuick2.SetUiActive(false);
			return;
		}
		else
		{
			item.SetUIActive(false);
			ButtonItem confirmQuick3 = this.ConfirmQuick;
			if (confirmQuick3 == null)
			{
				return;
			}
			confirmQuick3.SetUiActive(true);
			return;
		}
	}

	// Token: 0x0600A17F RID: 41343 RVA: 0x0023A664 File Offset: 0x00238864
	private void RefreshCurProgress()
	{
		IReadOnlyList<WuWuTaskPackage> allTaskPackage = WuWuLogisticsConfig.Instance.GetAllTaskPackage();
		int value = (allTaskPackage != null) ? allTaskPackage.Count : 0;
		int completedPackCount = this.ActivityData.GetCompletedPackCount();
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(completedPackCount);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(value);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x0600A180 RID: 41344 RVA: 0x0023A6D4 File Offset: 0x002388D4
	private void RefreshConfirmButtonRedPoint(int uid = 0)
	{
		WuWuLogisticsActivityData activityData = this.ActivityData;
		bool redDotVisible = activityData != null && activityData.RedPointShowState;
		ButtonItem confirmQuick = this.ConfirmQuick;
		if (confirmQuick == null)
		{
			return;
		}
		confirmQuick.SetRedDotVisible(redDotVisible);
	}

	// Token: 0x04004969 RID: 18793
	protected WuWuLogisticsActivityData ActivityData;

	// Token: 0x0400496A RID: 18794
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x0400496B RID: 18795
	private ActivityDescriptionTypeA DescriptionComponent;

	// Token: 0x0400496C RID: 18796
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x0400496D RID: 18797
	protected ButtonItem ConfirmQuick;

	// Token: 0x0400496E RID: 18798
	private FunctionalPanelConditionLock DisabledBarPanel;
}
