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

// Token: 0x020020C6 RID: 8390
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueRewardView : UiTickViewBase
{
	// Token: 0x06014A14 RID: 84500 RVA: 0x00603222 File Offset: 0x00601422
	public SurvivorsRogueRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014A15 RID: 84501 RVA: 0x00603240 File Offset: 0x00601440
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

	// Token: 0x06014A16 RID: 84502 RVA: 0x0060332C File Offset: 0x0060152C
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRogueRewardView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueRewardView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014A17 RID: 84503 RVA: 0x0060336F File Offset: 0x0060156F
	protected override void OnBeforeShow()
	{
		SurvivorsActivityController.Instance.CheckIsActivityClose();
	}

	// Token: 0x06014A18 RID: 84504 RVA: 0x0060337B File Offset: 0x0060157B
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshView));
	}

	// Token: 0x06014A19 RID: 84505 RVA: 0x00603399 File Offset: 0x00601599
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshView));
	}

	// Token: 0x06014A1A RID: 84506 RVA: 0x006033B8 File Offset: 0x006015B8
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

	// Token: 0x06014A1B RID: 84507 RVA: 0x00603409 File Offset: 0x00601609
	private SurvivorsRewardTabItem CreateTabItem()
	{
		return new SurvivorsRewardTabItem();
	}

	// Token: 0x06014A1C RID: 84508 RVA: 0x00603410 File Offset: 0x00601610
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

	// Token: 0x06014A1D RID: 84509 RVA: 0x0060347B File Offset: 0x0060167B
	private bool GetTabRedDotState(SurvivorRewardTaskTabData data)
	{
		return this.ActivityDataBase.GetTypeRedDotState(data.Type);
	}

	// Token: 0x06014A1E RID: 84510 RVA: 0x00603490 File Offset: 0x00601690
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

	// Token: 0x06014A1F RID: 84511 RVA: 0x006035C8 File Offset: 0x006017C8
	private SurvivorsRewardTaskItem CreateTaskItem()
	{
		return new SurvivorsRewardTaskItem
		{
			OnGetBtnClick = new Action(this.OnTaskClickCallBack)
		};
	}

	// Token: 0x06014A20 RID: 84512 RVA: 0x006035E4 File Offset: 0x006017E4
	private void RefreshTaskLayout()
	{
		List<ActivityTaskData> rewardTaskDataListByTypeId = this.ActivityDataBase.GetRewardTaskDataListByTypeId(this.CurTaskTabTypeId);
		this.TaskLayout.RefreshByData(rewardTaskDataListByTypeId, delegate
		{
			this.TaskLayout.ScrollToTopByIndex(0);
		}, true);
	}

	// Token: 0x06014A21 RID: 84513 RVA: 0x0060361C File Offset: 0x0060181C
	private void OnTaskClickCallBack()
	{
		List<int> availableGetTaskRewardIdsByType = this.ActivityDataBase.GetAvailableGetTaskRewardIdsByType(this.CurTaskTabTypeId);
		if (availableGetTaskRewardIdsByType.Count > 0)
		{
			SurvivorsActivityController.Instance.RequestGetRewardTask(availableGetTaskRewardIdsByType.ToArray());
		}
	}

	// Token: 0x06014A22 RID: 84514 RVA: 0x00603654 File Offset: 0x00601854
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

	// Token: 0x06014A23 RID: 84515 RVA: 0x006036B0 File Offset: 0x006018B0
	private void OnClickGetProgressReward()
	{
		List<int> allAvailableGetMilestoneRewardIds = this.ActivityDataBase.GetAllAvailableGetMilestoneRewardIds();
		if (allAvailableGetMilestoneRewardIds.Count > 0)
		{
			SurvivorsActivityController.Instance.RequestGetRewardScore(allAvailableGetMilestoneRewardIds.ToArray());
		}
	}

	// Token: 0x06014A24 RID: 84516 RVA: 0x006036E2 File Offset: 0x006018E2
	protected override void OnTick(float delta)
	{
		this.RefreshTimeText();
	}

	// Token: 0x06014A25 RID: 84517 RVA: 0x006036EC File Offset: 0x006018EC
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

	// Token: 0x06014A26 RID: 84518 RVA: 0x00603740 File Offset: 0x00601940
	private void OnCardDetailBtnClick()
	{
		SurvivorsActivityConfig? survivorsActivityConfig;
		int? num = (SurvivorsRogueModel.Instance.GetRogueActivityConfig() != null) ? new int?(survivorsActivityConfig.GetValueOrDefault().TaskDisplayItemId) : null;
		if (num != null)
		{
			ItemController.Instance.OpenItemTipsByItemId(num.Value, true, null, false);
		}
	}

	// Token: 0x06014A27 RID: 84519 RVA: 0x0060379E File Offset: 0x0060199E
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400AF95 RID: 44949
	[Nullable(2)]
	protected SurvivorsActivityData ActivityDataBase;

	// Token: 0x0400AF96 RID: 44950
	private int CurTaskTabTypeId = -1;

	// Token: 0x0400AF97 RID: 44951
	private GenericLayout<SurvivorsRewardTabItem, SurvivorRewardTaskTabData> TabLayout;

	// Token: 0x0400AF98 RID: 44952
	private GenericScrollViewNew<SurvivorsRewardTaskItem, ActivityTaskData> TaskLayout;

	// Token: 0x0400AF99 RID: 44953
	private SurvivorsScoreProgressPanel ProgressItem;

	// Token: 0x0400AF9A RID: 44954
	private string RemainTimeText = string.Empty;
}
