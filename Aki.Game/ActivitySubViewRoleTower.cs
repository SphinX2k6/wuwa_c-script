using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000980 RID: 2432
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewRoleTower : ActivitySubViewBase
{
	// Token: 0x06006AD6 RID: 27350 RVA: 0x00213888 File Offset: 0x00211A88
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06006AD7 RID: 27351 RVA: 0x00213954 File Offset: 0x00211B54
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewRoleTower.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewRoleTower.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006AD8 RID: 27352 RVA: 0x00213998 File Offset: 0x00211B98
	protected override void OnStart()
	{
		ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
		if (commonInfoPanel != null)
		{
			commonInfoPanel.SetClickFunc(delegate(ActivityBaseData _)
			{
				this.OnClickEnter();
			});
		}
		ActivitySubViewGeneralInfo commonInfoPanel2 = this.CommonInfoPanel;
		if (commonInfoPanel2 != null)
		{
			commonInfoPanel2.SetBtnText("PrefabTextItem_1222136140_Text", Array.Empty<object>());
		}
		this.LimitRewardButton = new ButtonItem(base.GetItem(3));
		this.LimitRewardButton.SetFunction(delegate(int _)
		{
			this.OnClickLimitReward();
		});
		RoleTowerActivityRankButtonItem rankButton = this.RankButton;
		if (rankButton != null)
		{
			rankButton.SetFunction(new Action(this.OnClickRank));
		}
		this.OnRefreshView();
	}

	// Token: 0x06006AD9 RID: 27353 RVA: 0x00213A29 File Offset: 0x00211C29
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
	}

	// Token: 0x06006ADA RID: 27354 RVA: 0x00213A47 File Offset: 0x00211C47
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
	}

	// Token: 0x06006ADB RID: 27355 RVA: 0x00213A68 File Offset: 0x00211C68
	protected override void OnRefreshView()
	{
		ActivityRoleTowerData activityRoleTowerData = this.ActivityBaseData as ActivityRoleTowerData;
		if (activityRoleTowerData != null)
		{
			activityRoleTowerData.ReadNewLevelRedDot(ActivityRoleTowerData.ENewLevelRedDotDepth.ActivityTab);
		}
		ActivityBaseData activityBaseData = this.ActivityBaseData;
		bool uiactive = activityBaseData != null && activityBaseData.IsUnLock();
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(uiactive);
		}
		this.RefreshLimitReward();
	}

	// Token: 0x06006ADC RID: 27356 RVA: 0x00213AB8 File Offset: 0x00211CB8
	protected override void OnTimer(float gap)
	{
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		UUIText text = base.GetText(4);
		if (text != null)
		{
			text.SetUIActive(item);
		}
		if (item)
		{
			UUIText text2 = base.GetText(4);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(item2, true);
		}
	}

	// Token: 0x06006ADD RID: 27357 RVA: 0x00213B04 File Offset: 0x00211D04
	private void OnRedDotRefresh(int activityId)
	{
		ActivityBaseData activityBaseData = this.ActivityBaseData;
		int? num = (activityBaseData != null) ? new int?(activityBaseData.Id) : null;
		if (!(activityId == num.GetValueOrDefault() & num != null))
		{
			return;
		}
		this.OnRefreshView();
	}

	// Token: 0x06006ADE RID: 27358 RVA: 0x00213B4C File Offset: 0x00211D4C
	private void RefreshLimitReward()
	{
		int num = 0;
		int num2 = 0;
		foreach (RoleTowerReward roleTowerReward in RoleTowerModel.Instance.GetRewardCfgList())
		{
			num2++;
			RoleTowerRewardData rewardState = RoleTowerModel.Instance.GetRewardState(roleTowerReward.Id);
			if (rewardState != null && rewardState.State == ERoleTowerRewardState.Received)
			{
				num++;
			}
		}
		ActivityRoleTowerData activityRoleTowerData = this.ActivityBaseData as ActivityRoleTowerData;
		ButtonItem limitRewardButton = this.LimitRewardButton;
		if (limitRewardButton != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
			limitRewardButton.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		ButtonItem limitRewardButton2 = this.LimitRewardButton;
		if (limitRewardButton2 != null)
		{
			limitRewardButton2.SetRedDotVisible(RoleTowerModel.Instance.HasAnyRedDot());
		}
		RoleTowerActivityRankButtonItem rankButton = this.RankButton;
		if (rankButton != null)
		{
			rankButton.SetRedDotVisible(false);
		}
		ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
		if (commonInfoPanel == null)
		{
			return;
		}
		commonInfoPanel.SetFunctionRedDotVisible((activityRoleTowerData != null && activityRoleTowerData.HasFirstOpenPageRedDot()) || (activityRoleTowerData != null && activityRoleTowerData.HasNewLevelRedDot(ActivityRoleTowerData.ENewLevelRedDotDepth.EnterButton)) || RoleTowerModel.Instance.HasAnyRedDot());
	}

	// Token: 0x06006ADF RID: 27359 RVA: 0x00213C70 File Offset: 0x00211E70
	private void OnClickEnter()
	{
		RoleTowerModel.Instance.OpenActivityLoadingView();
	}

	// Token: 0x06006AE0 RID: 27360 RVA: 0x00213C7C File Offset: 0x00211E7C
	private void OnClickRank()
	{
		RoleTowerModel.Instance.OpenRankView(0);
	}

	// Token: 0x06006AE1 RID: 27361 RVA: 0x00213C89 File Offset: 0x00211E89
	private void OnClickLimitReward()
	{
		RoleTowerModel.Instance.OpenRewardView();
	}

	// Token: 0x0400432E RID: 17198
	private ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x0400432F RID: 17199
	private ButtonItem LimitRewardButton;

	// Token: 0x04004330 RID: 17200
	private RoleTowerActivityRankButtonItem RankButton;

	// Token: 0x02006C89 RID: 27785
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04023A7F RID: 146047
		UiItemComActivityInfo,
		// Token: 0x04023A80 RID: 146048
		PnlActivatedGreen,
		// Token: 0x04023A81 RID: 146049
		UiItemRankItem,
		// Token: 0x04023A82 RID: 146050
		UiItemLimitReward,
		// Token: 0x04023A83 RID: 146051
		TxtTaskTime
	}
}
