using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000704 RID: 1796
[NullableContext(1)]
[Nullable(0)]
public class DangoMonopolyTaskView : DangoMonopolyViewBase
{
	// Token: 0x17000AEF RID: 2799
	// (get) Token: 0x060052ED RID: 21229 RVA: 0x001B8548 File Offset: 0x001B6748
	[Nullable(2)]
	public new DangoMonopolyTaskViewParam OpenParam
	{
		[NullableContext(2)]
		get
		{
			return this.OpenParam as DangoMonopolyTaskViewParam;
		}
	}

	// Token: 0x060052EE RID: 21230 RVA: 0x001B8555 File Offset: 0x001B6755
	public DangoMonopolyTaskView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060052EF RID: 21231 RVA: 0x001B8560 File Offset: 0x001B6760
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

	// Token: 0x060052F0 RID: 21232 RVA: 0x001B8663 File Offset: 0x001B6863
	private void InitDataParam()
	{
	}

	// Token: 0x060052F1 RID: 21233 RVA: 0x001B8668 File Offset: 0x001B6868
	protected override UniTask OnBeforeStartAsync()
	{
		DangoMonopolyTaskView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoMonopolyTaskView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060052F2 RID: 21234 RVA: 0x001B86AB File Offset: 0x001B68AB
	protected override void OnStart()
	{
		UUIText text = base.GetText(6);
		if (text == null)
		{
			return;
		}
		text.ShowTextNew("DangoMonopoly_title_4");
	}

	// Token: 0x060052F3 RID: 21235 RVA: 0x001B86C3 File Offset: 0x001B68C3
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<EDangoMonopolyTaskUpdateType>(EEventName.DangoMonopolyTaskUpdate, new Action<EDangoMonopolyTaskUpdateType>(this.EventDangoMonopolyTaskUpdate));
	}

	// Token: 0x060052F4 RID: 21236 RVA: 0x001B86E1 File Offset: 0x001B68E1
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.DangoMonopolyTaskUpdate, new Action<EDangoMonopolyTaskUpdateType>(this.EventDangoMonopolyTaskUpdate));
	}

	// Token: 0x060052F5 RID: 21237 RVA: 0x001B8700 File Offset: 0x001B6900
	protected override void OnBeforeShow()
	{
		this.TabFinish();
		if (this.IsShowRemainTime)
		{
			int num = 200;
			this.RefreshTimerHandle = TimerSystem.RealTimeInstance.Forever(new TTimerAction(this.OnTimerRefresh), (float)num, 1f, null, null, true);
		}
	}

	// Token: 0x060052F6 RID: 21238 RVA: 0x001B8747 File Offset: 0x001B6947
	protected override void OnAfterHide()
	{
		this.ClearTimer();
	}

	// Token: 0x060052F7 RID: 21239 RVA: 0x001B8750 File Offset: 0x001B6950
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

	// Token: 0x060052F8 RID: 21240 RVA: 0x001B880C File Offset: 0x001B6A0C
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

	// Token: 0x060052F9 RID: 21241 RVA: 0x001B88A4 File Offset: 0x001B6AA4
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
			if (dangoMonopolyTaskData.IsCanReceive() || !this.ActivityData.IsTaskLooked(dangoMonopolyTaskData.Id))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060052FA RID: 21242 RVA: 0x001B893C File Offset: 0x001B6B3C
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

	// Token: 0x060052FB RID: 21243 RVA: 0x001B89D4 File Offset: 0x001B6BD4
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

	// Token: 0x060052FC RID: 21244 RVA: 0x001B8ADC File Offset: 0x001B6CDC
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x060052FD RID: 21245 RVA: 0x001B8ADE File Offset: 0x001B6CDE
	private ShipTowerTeamTabItem TabItemProxyCreate([Nullable(2)] UUIItem _1, int? _2)
	{
		return new ShipTowerTeamTabItem();
	}

	// Token: 0x060052FE RID: 21246 RVA: 0x001B8AE8 File Offset: 0x001B6CE8
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

	// Token: 0x060052FF RID: 21247 RVA: 0x001B8B30 File Offset: 0x001B6D30
	private void UpdateTaskInfo(IDangoMonopolyTaskTabData data)
	{
		GenericLayout<DangoMonopolyTaskItem, DangoMonopolyTaskData> rewardScrollView = this.RewardScrollView;
		if (rewardScrollView != null)
		{
			rewardScrollView.RefreshByData(data.TaskList, null, true);
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

	// Token: 0x06005300 RID: 21248 RVA: 0x001B8BCC File Offset: 0x001B6DCC
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

	// Token: 0x06005301 RID: 21249 RVA: 0x001B8C60 File Offset: 0x001B6E60
	private DangoMonopolyTaskItem CreateRewardItem()
	{
		return new DangoMonopolyTaskItem
		{
			ClickCallBack = new Action<DangoMonopolyTaskData>(this.OnClickReceive)
		};
	}

	// Token: 0x06005302 RID: 21250 RVA: 0x001B8C79 File Offset: 0x001B6E79
	private void OnClickReceive(DangoMonopolyTaskData data)
	{
		ActivityDangoMonopolyData activityData = this.ActivityData;
		if (activityData == null)
		{
			return;
		}
		activityData.RequestReceiveTask(data.Id, false);
	}

	// Token: 0x06005303 RID: 21251 RVA: 0x001B8C92 File Offset: 0x001B6E92
	private void OnClickClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x06005304 RID: 21252 RVA: 0x001B8C9B File Offset: 0x001B6E9B
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

	// Token: 0x06005305 RID: 21253 RVA: 0x001B8CC4 File Offset: 0x001B6EC4
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

	// Token: 0x06005306 RID: 21254 RVA: 0x001B8D18 File Offset: 0x001B6F18
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

	// Token: 0x06005307 RID: 21255 RVA: 0x001B8D7F File Offset: 0x001B6F7F
	private void ClearTimer()
	{
		if (this.RefreshTimerHandle != null && TimerSystem.RealTimeInstance.Has(this.RefreshTimerHandle))
		{
			TimerSystem.RealTimeInstance.Remove(this.RefreshTimerHandle);
			this.RefreshTimerHandle = null;
		}
	}

	// Token: 0x04003A8E RID: 14990
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<ShipTowerTeamTabItem> TabComponent;

	// Token: 0x04003A8F RID: 14991
	private int CurSelectTabIndex;

	// Token: 0x04003A90 RID: 14992
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<DangoMonopolyTaskItem, DangoMonopolyTaskData> RewardScrollView;

	// Token: 0x04003A91 RID: 14993
	[Nullable(2)]
	private TimerHandle RefreshTimerHandle;

	// Token: 0x04003A92 RID: 14994
	private long EndTime;

	// Token: 0x04003A93 RID: 14995
	public bool IsNeedClose;

	// Token: 0x04003A94 RID: 14996
	[Nullable(2)]
	public CommonCurrencyItemListComponent CurrencyItemListComponent;

	// Token: 0x04003A95 RID: 14997
	public bool IsShowRemainTime;

	// Token: 0x020069F5 RID: 27125
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04022E09 RID: 142857
		BtnClose,
		// Token: 0x04022E0A RID: 142858
		ItemTabComponent,
		// Token: 0x04022E0B RID: 142859
		VLayoutReward,
		// Token: 0x04022E0C RID: 142860
		ItemReward,
		// Token: 0x04022E0D RID: 142861
		TxtCountDown,
		// Token: 0x04022E0E RID: 142862
		BtnEmpty,
		// Token: 0x04022E0F RID: 142863
		TxtTitle,
		// Token: 0x04022E10 RID: 142864
		CostContent
	}
}
