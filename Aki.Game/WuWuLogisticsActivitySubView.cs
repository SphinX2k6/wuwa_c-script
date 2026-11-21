using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000B16 RID: 2838
[NullableContext(2)]
[Nullable(0)]
public class WuWuLogisticsActivitySubView : ActivitySubViewBase
{
	// Token: 0x06007550 RID: 30032 RVA: 0x002440FC File Offset: 0x002422FC
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

	// Token: 0x06007551 RID: 30033 RVA: 0x002441AE File Offset: 0x002423AE
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.RefreshConfirmButtonRedPoint));
	}

	// Token: 0x06007552 RID: 30034 RVA: 0x002441CC File Offset: 0x002423CC
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.RefreshConfirmButtonRedPoint));
	}

	// Token: 0x06007553 RID: 30035 RVA: 0x002441EA File Offset: 0x002423EA
	protected override void OnSetData()
	{
		this.ActivityData = (this.ActivityBaseData as WuWuLogisticsActivityData);
	}

	// Token: 0x06007554 RID: 30036 RVA: 0x00244200 File Offset: 0x00242400
	protected override UniTask OnBeforeStartAsync()
	{
		WuWuLogisticsActivitySubView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WuWuLogisticsActivitySubView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007555 RID: 30037 RVA: 0x00244244 File Offset: 0x00242444
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

	// Token: 0x06007556 RID: 30038 RVA: 0x002442E6 File Offset: 0x002424E6
	protected override void OnRefreshView()
	{
		this.RefreshRewardComponent();
		this.RefreshTimerText();
		this.RefreshCurProgress();
		this.RefreshConfirmButtonRedPoint(0);
		this.RefreshDisabledBar();
	}

	// Token: 0x06007557 RID: 30039 RVA: 0x00244307 File Offset: 0x00242507
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x06007558 RID: 30040 RVA: 0x0024430F File Offset: 0x0024250F
	protected void InitButtonState()
	{
		this.ConfirmQuick = new ButtonItem(base.GetButton(6).RootUIComp);
		this.ConfirmQuick.SetFunction(new Action<int>(this.OnClickedForwardButton));
	}

	// Token: 0x06007559 RID: 30041 RVA: 0x00244344 File Offset: 0x00242544
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

	// Token: 0x0600755A RID: 30042 RVA: 0x00244374 File Offset: 0x00242574
	private void RefreshRewardComponent()
	{
		List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
		this.RewardListComponent.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.RewardListComponent.InitCommonGridItem));
		this.RewardListComponent.RefreshItemLayout(previewReward, null);
	}

	// Token: 0x0600755B RID: 30043 RVA: 0x002443BF File Offset: 0x002425BF
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

	// Token: 0x0600755C RID: 30044 RVA: 0x002443E0 File Offset: 0x002425E0
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

	// Token: 0x0600755D RID: 30045 RVA: 0x00244500 File Offset: 0x00242700
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

	// Token: 0x0600755E RID: 30046 RVA: 0x00244570 File Offset: 0x00242770
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

	// Token: 0x04004A0F RID: 18959
	protected WuWuLogisticsActivityData ActivityData;

	// Token: 0x04004A10 RID: 18960
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x04004A11 RID: 18961
	private ActivityDescriptionTypeA DescriptionComponent;

	// Token: 0x04004A12 RID: 18962
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x04004A13 RID: 18963
	protected ButtonItem ConfirmQuick;

	// Token: 0x04004A14 RID: 18964
	private FunctionalPanelConditionLock DisabledBarPanel;
}
