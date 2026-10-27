using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001250 RID: 4688
[NullableContext(1)]
[Nullable(0)]
public class DangoMonopolyTaskView : DangoMonopolyViewBase
{
	// Token: 0x17000ACF RID: 2767
	// (get) Token: 0x06007F56 RID: 32598 RVA: 0x001AF890 File Offset: 0x001ADA90
	[Nullable(2)]
	public new DangoMonopolyTaskViewParam OpenParam
	{
		[NullableContext(2)]
		get
		{
			return this.OpenParam as DangoMonopolyTaskViewParam;
		}
	}

	// Token: 0x06007F57 RID: 32599 RVA: 0x001AF89D File Offset: 0x001ADA9D
	public DangoMonopolyTaskView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06007F58 RID: 32600 RVA: 0x001AF8A8 File Offset: 0x001ADAA8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickClose)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickClose))
		};
	}

	// Token: 0x06007F59 RID: 32601 RVA: 0x001AF9AB File Offset: 0x001ADBAB
	private void InitDataParam()
	{
	}

	// Token: 0x06007F5A RID: 32602 RVA: 0x001AF9B0 File Offset: 0x001ADBB0
	protected override UniTask OnBeforeStartAsync()
	{
		DangoMonopolyTaskView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoMonopolyTaskView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007F5B RID: 32603 RVA: 0x001AF9F3 File Offset: 0x001ADBF3
	protected override void OnStart()
	{
		UUIText text = base.GetText(6);
		if (text == null)
		{
			return;
		}
		text.ShowTextNew("DangoMonopoly_title_4");
	}

	// Token: 0x06007F5C RID: 32604 RVA: 0x001AFA0B File Offset: 0x001ADC0B
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<EDangoMonopolyTaskUpdateType>(EEventName.DangoMonopolyTaskUpdate, new Action<EDangoMonopolyTaskUpdateType>(this.EventDangoMonopolyTaskUpdate));
	}

	// Token: 0x06007F5D RID: 32605 RVA: 0x001AFA29 File Offset: 0x001ADC29
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.DangoMonopolyTaskUpdate, new Action<EDangoMonopolyTaskUpdateType>(this.EventDangoMonopolyTaskUpdate));
	}

	// Token: 0x06007F5E RID: 32606 RVA: 0x001AFA48 File Offset: 0x001ADC48
	protected override void OnBeforeShow()
	{
		this.TabFinish();
		if (this.IsShowRemainTime)
		{
			int num = 200;
			this.RefreshTimerHandle = TimerSystem.RealTimeInstance.Forever(new TTimerAction(this.OnTimerRefresh), (float)num, 1f, null, null, true);
		}
	}

	// Token: 0x06007F5F RID: 32607 RVA: 0x001AFA8F File Offset: 0x001ADC8F
	protected override void OnAfterHide()
	{
		this.ClearTimer();
	}

	// Token: 0x06007F60 RID: 32608 RVA: 0x001AFA98 File Offset: 0x001ADC98
	private void TabFinish()
	{
		Dictionary<int, ShipTowerTeamTabItem> tabItemMap = this.TabComponent.GetTabItemMap();
		DangoMonopolyTaskViewParam openParam = this.OpenParam;
		List<IDangoMonopolyTaskTabData> list = ((openParam != null) ? openParam.TaskList : null) ?? new List<IDangoMonopolyTaskTabData>();
		foreach (KeyValuePair<int, ShipTowerTeamTabItem> keyValuePair in tabItemMap)
		{
			int key = keyValuePair.Key;
			ShipTowerTeamTabItem value = keyValuePair.Value;
			if (key < list.Count)
			{
				value.UpdateNameText(list[key].TaskTypeName);
				value.UpdateRedDotVisible(this.GetTaskListRedDotState(key));
			}
		}
		this.TabComponent.SelectToggleByIndex(this.GetJumpTabIndex(), true, true);
	}

	// Token: 0x06007F61 RID: 32609 RVA: 0x001AFB54 File Offset: 0x001ADD54
	public void UpdateTabRedDotState()
	{
		Dictionary<int, ShipTowerTeamTabItem> tabItemMap = this.TabComponent.GetTabItemMap();
		DangoMonopolyTaskViewParam openParam = this.OpenParam;
		List<IDangoMonopolyTaskTabData> list = ((openParam != null) ? openParam.TaskList : null) ?? new List<IDangoMonopolyTaskTabData>();
		foreach (KeyValuePair<int, ShipTowerTeamTabItem> keyValuePair in tabItemMap)
		{
			int key = keyValuePair.Key;
			ShipTowerTeamTabItem value = keyValuePair.Value;
			if (key < list.Count)
			{
				value.UpdateRedDotVisible(this.GetTaskListRedDotState(key));
			}
		}
	}

	// Token: 0x06007F62 RID: 32610 RVA: 0x001AFBEC File Offset: 0x001ADDEC
	public bool GetTaskListRedDotState(int index)
	{
		DangoMonopolyTaskViewParam openParam = this.OpenParam;
		List<IDangoMonopolyTaskTabData> list = ((openParam != null) ? openParam.TaskList : null) ?? new List<IDangoMonopolyTaskTabData>();
		if (index >= list.Count)
		{
			return false;
		}
		foreach (DangoMonopolyTaskData dangoMonopolyTaskData in list[index].TaskList)
		{
			if (dangoMonopolyTaskData.IsCanReceive() || !this.ActivityData.TaskLookedSet.Contains(dangoMonopolyTaskData.Id))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06007F63 RID: 32611 RVA: 0x001AFC88 File Offset: 0x001ADE88
	public void UpdateTabRedDotStateByIndex(int index)
	{
		ShipTowerTeamTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
		DangoMonopolyTaskViewParam openParam = this.OpenParam;
		List<IDangoMonopolyTaskTabData> list = ((openParam != null) ? openParam.TaskList : null) ?? new List<IDangoMonopolyTaskTabData>();
		if (tabItemByIndex != null && index < list.Count)
		{
			using (IEnumerator<DangoMonopolyTaskData> enumerator = list[index].TaskList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsCanReceive())
					{
						tabItemByIndex.UpdateRedDotVisible(true);
						return;
					}
				}
			}
			tabItemByIndex.UpdateRedDotVisible(false);
		}
	}

	// Token: 0x06007F64 RID: 32612 RVA: 0x001AFD20 File Offset: 0x001ADF20
	private int GetJumpTabIndex()
	{
		if (this.OpenParam == null)
		{
			return 0;
		}
		int valueOrDefault = this.OpenParam.TaskId.GetValueOrDefault();
		ActivityDangoMonopolyData activityData = this.ActivityData;
		DangoMonopolyTaskData dangoMonopolyTaskData;
		if (activityData != null && activityData.TaskIdMap.TryGetValue(valueOrDefault, out dangoMonopolyTaskData) && dangoMonopolyTaskData != null)
		{
			EDangoMonopolyTaskType taskType = dangoMonopolyTaskData.TaskType;
			List<IDangoMonopolyTaskTabData> taskList = this.OpenParam.TaskList;
			for (int i = 0; i < taskList.Count; i++)
			{
				if (taskList[i].TaskType == taskType)
				{
					return Math.Max(i, 0);
				}
			}
		}
		List<IDangoMonopolyTaskTabData> taskList2 = this.OpenParam.TaskList;
		for (int j = 0; j < taskList2.Count; j++)
		{
			using (IEnumerator<DangoMonopolyTaskData> enumerator = taskList2[j].TaskList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsCanReceive())
					{
						return Math.Max(j, 0);
					}
				}
			}
		}
		return 0;
	}

	// Token: 0x06007F65 RID: 32613 RVA: 0x001AFE28 File Offset: 0x001AE028
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x06007F66 RID: 32614 RVA: 0x001AFE2A File Offset: 0x001AE02A
	private ShipTowerTeamTabItem TabItemProxyCreate([Nullable(2)] UUIItem _1, int? _2)
	{
		return new ShipTowerTeamTabItem();
	}

	// Token: 0x06007F67 RID: 32615 RVA: 0x001AFE34 File Offset: 0x001AE034
	private void ToggleTwoTabCallBack(int index)
	{
		this.CurSelectTabIndex = index;
		DangoMonopolyTaskViewParam openParam = this.OpenParam;
		List<IDangoMonopolyTaskTabData> list = ((openParam != null) ? openParam.TaskList : null) ?? new List<IDangoMonopolyTaskTabData>();
		if (index < list.Count)
		{
			IDangoMonopolyTaskTabData data = list[index];
			this.UpdateTaskInfo(data);
		}
	}

	// Token: 0x06007F68 RID: 32616 RVA: 0x001AFE7C File Offset: 0x001AE07C
	private void UpdateTaskInfo(IDangoMonopolyTaskTabData data)
	{
		GenericLayout<DangoMonopolyTaskItem, DangoMonopolyTaskData> rewardScrollView = this.RewardScrollView;
		if (rewardScrollView != null)
		{
			rewardScrollView.RefreshByData(data.TaskList.ToList<DangoMonopolyTaskData>(), null, true);
		}
		this.UpdateRemainTimeInfo(data);
		List<int> list = new List<int>();
		foreach (DangoMonopolyTaskData dangoMonopolyTaskData in data.TaskList)
		{
			list.Add(dangoMonopolyTaskData.Id);
		}
		ActivityDangoMonopolyData activityData = this.ActivityData;
		if (activityData != null && activityData.AddNewTaskIdList(list))
		{
			this.UpdateTabRedDotStateByIndex(this.CurSelectTabIndex);
		}
	}

	// Token: 0x06007F69 RID: 32617 RVA: 0x001AFF1C File Offset: 0x001AE11C
	public void UpdateRemainTimeInfo(IDangoMonopolyTaskTabData data)
	{
		UUIText text = base.GetText(4);
		if (this.IsShowRemainTime)
		{
			this.EndTime = data.EndTime;
			if (text != null)
			{
				text.SetUIActive(this.EndTime > 0L);
			}
			this.OnTimerRefresh(0f);
			return;
		}
		EDangoMonopolyTaskType taskType = data.TaskType;
		if (taskType != EDangoMonopolyTaskType.DailyTask)
		{
			if (taskType != EDangoMonopolyTaskType.WeeklyTask)
			{
				if (text != null)
				{
					text.SetUIActive(false);
				}
			}
			else
			{
				if (text != null)
				{
					text.SetUIActive(true);
				}
				if (text != null)
				{
					text.ShowTextNew("DangoMonopoly_title_23");
					return;
				}
			}
		}
		else
		{
			if (text != null)
			{
				text.SetUIActive(true);
			}
			if (text != null)
			{
				text.ShowTextNew("DangoMonopoly_title_22");
				return;
			}
		}
	}

	// Token: 0x06007F6A RID: 32618 RVA: 0x001AFFB0 File Offset: 0x001AE1B0
	private DangoMonopolyTaskItem CreateRewardItem()
	{
		return new DangoMonopolyTaskItem
		{
			ClickCallBack = new Action<DangoMonopolyTaskData>(this.OnClickReceive)
		};
	}

	// Token: 0x06007F6B RID: 32619 RVA: 0x001AFFC9 File Offset: 0x001AE1C9
	private void OnClickReceive(DangoMonopolyTaskData data)
	{
		ActivityDangoMonopolyData activityData = this.ActivityData;
		if (activityData == null)
		{
			return;
		}
		activityData.RequestReceiveTask(data.Id, false);
	}

	// Token: 0x06007F6C RID: 32620 RVA: 0x001AFFE2 File Offset: 0x001AE1E2
	private void OnClickClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x06007F6D RID: 32621 RVA: 0x001AFFEB File Offset: 0x001AE1EB
	private void EventDangoMonopolyTaskUpdate(EDangoMonopolyTaskUpdateType updateType)
	{
		if (updateType != EDangoMonopolyTaskUpdateType.Update)
		{
			if (updateType - EDangoMonopolyTaskUpdateType.Add <= 1)
			{
				this.ShowTipClose();
			}
		}
		else
		{
			this.ToggleTwoTabCallBack(this.CurSelectTabIndex);
		}
		this.UpdateTabRedDotState();
	}

	// Token: 0x06007F6E RID: 32622 RVA: 0x001B0014 File Offset: 0x001AE214
	public void ShowTipClose()
	{
		if (this.IsNeedClose)
		{
			return;
		}
		this.IsNeedClose = true;
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.BattlePassTaskExpire);
		confirmBoxDataNew.IsEscViewTriggerCallBack = false;
		confirmBoxDataNew.FunctionMap.Add(1, delegate
		{
			base.CloseMe(null);
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06007F6F RID: 32623 RVA: 0x001B0068 File Offset: 0x001AE268
	private void OnTimerRefresh(float _)
	{
		if (this.EndTime > 0L)
		{
			double remainTime = Math.Max((double)this.EndTime - TimeUtil.Instance.GetServerTime(), 0.0);
			CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3(remainTime);
			UUIText text = base.GetText(4);
			LguiUtil.Instance.SetLocalTextNew(text, "DangoMonopoly_title_20", new <>z__ReadOnlySingleElementList<object>(remainTimeDataFormat.CountDownText));
		}
	}

	// Token: 0x06007F70 RID: 32624 RVA: 0x001B00CF File Offset: 0x001AE2CF
	private void ClearTimer()
	{
		if (this.RefreshTimerHandle != null && TimerSystem.RealTimeInstance.Has(this.RefreshTimerHandle))
		{
			TimerSystem.RealTimeInstance.Remove(this.RefreshTimerHandle);
			this.RefreshTimerHandle = null;
		}
	}

	// Token: 0x040039F6 RID: 14838
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<ShipTowerTeamTabItem> TabComponent;

	// Token: 0x040039F7 RID: 14839
	private int CurSelectTabIndex;

	// Token: 0x040039F8 RID: 14840
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<DangoMonopolyTaskItem, DangoMonopolyTaskData> RewardScrollView;

	// Token: 0x040039F9 RID: 14841
	[Nullable(2)]
	private TimerHandle RefreshTimerHandle;

	// Token: 0x040039FA RID: 14842
	private long EndTime;

	// Token: 0x040039FB RID: 14843
	public bool IsNeedClose;

	// Token: 0x040039FC RID: 14844
	[Nullable(2)]
	public CommonCurrencyItemListComponent CurrencyItemListComponent;

	// Token: 0x040039FD RID: 14845
	public bool IsShowRemainTime;

	// Token: 0x0200786A RID: 30826
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04027AD8 RID: 162520
		BtnClose,
		// Token: 0x04027AD9 RID: 162521
		ItemTabComponent,
		// Token: 0x04027ADA RID: 162522
		VLayoutReward,
		// Token: 0x04027ADB RID: 162523
		ItemReward,
		// Token: 0x04027ADC RID: 162524
		TxtCountDown,
		// Token: 0x04027ADD RID: 162525
		BtnEmpty,
		// Token: 0x04027ADE RID: 162526
		TxtTitle,
		// Token: 0x04027ADF RID: 162527
		CostContent
	}
}
