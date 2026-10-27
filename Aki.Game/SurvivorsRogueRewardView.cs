using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002B4A RID: 11082
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueRewardView : UiTickViewBase
{
	// Token: 0x06016FE3 RID: 94179 RVA: 0x005D66B6 File Offset: 0x005D48B6
	public SurvivorsRogueRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06016FE4 RID: 94180 RVA: 0x005D66D4 File Offset: 0x005D48D4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnCardDetailBtnClick))
		};
	}

	// Token: 0x06016FE5 RID: 94181 RVA: 0x005D67C0 File Offset: 0x005D49C0
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRogueRewardView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueRewardView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016FE6 RID: 94182 RVA: 0x005D6803 File Offset: 0x005D4A03
	protected override void OnBeforeShow()
	{
		SurvivorsActivityController.Instance.CheckIsActivityClose();
	}

	// Token: 0x06016FE7 RID: 94183 RVA: 0x005D680F File Offset: 0x005D4A0F
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshView));
	}

	// Token: 0x06016FE8 RID: 94184 RVA: 0x005D682D File Offset: 0x005D4A2D
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshView));
	}

	// Token: 0x06016FE9 RID: 94185 RVA: 0x005D684C File Offset: 0x005D4A4C
	private void OnRefreshView(int activityId)
	{
		if (this.ActivityDataBase.Id != activityId)
		{
			return;
		}
		List<SurvivorsRewardTabItem> layoutItemList = this.TabLayout.GetLayoutItemList();
		for (int i = 0; i < layoutItemList.Count; i++)
		{
			layoutItemList[i].RefreshRedDot();
		}
		this.RefreshTaskLayout();
		this.RefreshProgressItem();
	}

	// Token: 0x06016FEA RID: 94186 RVA: 0x005D689D File Offset: 0x005D4A9D
	private SurvivorsRewardTabItem CreateTabItem()
	{
		return new SurvivorsRewardTabItem();
	}

	// Token: 0x06016FEB RID: 94187 RVA: 0x005D68A4 File Offset: 0x005D4AA4
	private void OnTabClickCallBack(SurvivorRewardTaskTabData data)
	{
		if (this.CurTaskTabTypeId != data.Type && this.CurTaskTabTypeId != -1)
		{
			SurvivorsRewardTabItem layoutItemByKey = this.TabLayout.GetLayoutItemByKey(this.CurTaskTabTypeId);
			if (layoutItemByKey != null)
			{
				layoutItemByKey.SetToggleState(false, false);
			}
		}
		this.TabLayout.SelectGridProxy(data.Index, false);
		this.CurTaskTabTypeId = data.Type;
		this.RefreshTaskLayout();
	}

	// Token: 0x06016FEC RID: 94188 RVA: 0x005D690F File Offset: 0x005D4B0F
	private bool GetTabRedDotState(SurvivorRewardTaskTabData data)
	{
		return this.ActivityDataBase.GetTypeRedDotState(data.Type);
	}

	// Token: 0x06016FED RID: 94189 RVA: 0x005D6924 File Offset: 0x005D4B24
	private IReadOnlyList<SurvivorRewardTaskTabData> GetTaskTabList()
	{
		List<SurvivorRewardTaskTabData> list = new List<SurvivorRewardTaskTabData>();
		List<int> list2 = new List<int>(this.ActivityDataBase.RewardType2TaskIdList.Keys);
		list2.Sort((int a, int b) => a - b);
		SurvivorsActivityConfig value = SurvivorsRogueConfig.Instance.GetSurvivorsActivityConfigByActivityId(this.ActivityDataBase.Id).Value;
		int num = 0;
		for (int i = 0; i < list2.Count; i++)
		{
			int num2 = list2[i];
			string nameTextId = null;
			for (int j = 0; j < value.TaskTypeLength; j++)
			{
				DicIntString? dicIntString = value.TaskType(j);
				if (dicIntString != null && dicIntString.Value.Key == num2)
				{
					nameTextId = dicIntString.Value.Value;
					break;
				}
			}
			SurvivorRewardTaskTabData item = new SurvivorRewardTaskTabData
			{
				Type = num2,
				Index = num,
				NameTextId = nameTextId,
				ClickedCallback = new Action<SurvivorRewardTaskTabData>(this.OnTabClickCallBack),
				RefreshRedDot = new Func<SurvivorRewardTaskTabData, bool>(this.GetTabRedDotState)
			};
			list.Add(item);
			num++;
		}
		return list;
	}

	// Token: 0x06016FEE RID: 94190 RVA: 0x005D6A5C File Offset: 0x005D4C5C
	private SurvivorsRewardTaskItem CreateTaskItem()
	{
		return new SurvivorsRewardTaskItem
		{
			OnGetBtnClick = new Action(this.OnTaskClickCallBack)
		};
	}

	// Token: 0x06016FEF RID: 94191 RVA: 0x005D6A78 File Offset: 0x005D4C78
	private void RefreshTaskLayout()
	{
		List<ActivityTaskData> rewardTaskDataListByTypeId = this.ActivityDataBase.GetRewardTaskDataListByTypeId(this.CurTaskTabTypeId);
		this.TaskLayout.RefreshByData(rewardTaskDataListByTypeId, delegate
		{
			this.TaskLayout.ScrollToTopByIndex(0);
		}, true);
	}

	// Token: 0x06016FF0 RID: 94192 RVA: 0x005D6AB0 File Offset: 0x005D4CB0
	private void OnTaskClickCallBack()
	{
		List<int> availableGetTaskRewardIdsByType = this.ActivityDataBase.GetAvailableGetTaskRewardIdsByType(this.CurTaskTabTypeId);
		if (availableGetTaskRewardIdsByType.Count > 0)
		{
			SurvivorsActivityController.Instance.RequestGetRewardTask(availableGetTaskRewardIdsByType.ToArray());
		}
	}

	// Token: 0x06016FF1 RID: 94193 RVA: 0x005D6AE8 File Offset: 0x005D4CE8
	private void RefreshProgressItem()
	{
		SurvivorsRogueRewardView.<>c__DisplayClass20_0 CS$<>8__locals1 = new SurvivorsRogueRewardView.<>c__DisplayClass20_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.dataList = this.ActivityDataBase.GetAllMilestoneReward();
		CS$<>8__locals1.currentCount = this.ActivityDataBase.GetMilestoneItemCount();
		UiAsyncTask task = new UiAsyncTask("SurvivorsRogueRewardView.RefreshProgressItem", delegate()
		{
			SurvivorsRogueRewardView.<>c__DisplayClass20_0.<<RefreshProgressItem>b__0>d <<RefreshProgressItem>b__0>d;
			<<RefreshProgressItem>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<RefreshProgressItem>b__0>d.<>4__this = CS$<>8__locals1;
			<<RefreshProgressItem>b__0>d.<>1__state = -1;
			<<RefreshProgressItem>b__0>d.<>t__builder.Start<SurvivorsRogueRewardView.<>c__DisplayClass20_0.<<RefreshProgressItem>b__0>d>(ref <<RefreshProgressItem>b__0>d);
			return <<RefreshProgressItem>b__0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task);
	}

	// Token: 0x06016FF2 RID: 94194 RVA: 0x005D6B44 File Offset: 0x005D4D44
	private void OnClickGetProgressReward()
	{
		List<int> allAvailableGetMilestoneRewardIds = this.ActivityDataBase.GetAllAvailableGetMilestoneRewardIds();
		if (allAvailableGetMilestoneRewardIds.Count > 0)
		{
			SurvivorsActivityController.Instance.RequestGetRewardScore(allAvailableGetMilestoneRewardIds.ToArray());
		}
	}

	// Token: 0x06016FF3 RID: 94195 RVA: 0x005D6B76 File Offset: 0x005D4D76
	protected override void OnTick(float delta)
	{
		this.RefreshTimeText();
	}

	// Token: 0x06016FF4 RID: 94196 RVA: 0x005D6B80 File Offset: 0x005D4D80
	private void RefreshTimeText()
	{
		if (this.ActivityDataBase == null || !this.ActivityDataBase.CheckIfInOpenTime())
		{
			return;
		}
		string remainTimeText = ActivityModel.Instance.GetRemainTimeText(this.ActivityDataBase.EndOpenTime, this.RemainTimeText);
		UUIText text = base.GetText(7);
		if (text == null)
		{
			return;
		}
		text.SetText(remainTimeText, true);
	}

	// Token: 0x06016FF5 RID: 94197 RVA: 0x005D6BD4 File Offset: 0x005D4DD4
	private void OnCardDetailBtnClick()
	{
		SurvivorsActivityConfig? survivorsActivityConfig;
		int? num = (SurvivorsRogueModel.Instance.GetRogueActivityConfig() != null) ? new int?(survivorsActivityConfig.GetValueOrDefault().TaskDisplayItemId) : null;
		if (num != null)
		{
			ItemController.Instance.OpenItemTipsByItemId(num.Value, true, null);
		}
	}

	// Token: 0x06016FF6 RID: 94198 RVA: 0x005D6C31 File Offset: 0x005D4E31
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400AB8F RID: 43919
	[Nullable(2)]
	protected SurvivorsActivityData ActivityDataBase;

	// Token: 0x0400AB90 RID: 43920
	private int CurTaskTabTypeId = -1;

	// Token: 0x0400AB91 RID: 43921
	private GenericLayout<SurvivorsRewardTabItem, SurvivorRewardTaskTabData> TabLayout;

	// Token: 0x0400AB92 RID: 43922
	private GenericScrollViewNew<SurvivorsRewardTaskItem, ActivityTaskData> TaskLayout;

	// Token: 0x0400AB93 RID: 43923
	private SurvivorsScoreProgressPanel ProgressItem;

	// Token: 0x0400AB94 RID: 43924
	private string RemainTimeText = string.Empty;
}
