using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001364 RID: 4964
[NullableContext(1)]
[Nullable(0)]
public class RewardTargetTabView : UiTabViewBase
{
	// Token: 0x06008A52 RID: 35410 RVA: 0x001D8DE8 File Offset: 0x001D6FE8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x06008A53 RID: 35411 RVA: 0x001D8E58 File Offset: 0x001D7058
	protected override void OnStart()
	{
		object extraParams = this.ExtraParams;
		bool canAccomplishTask;
		if (extraParams is bool)
		{
			bool flag = (bool)extraParams;
			canAccomplishTask = flag;
		}
		else
		{
			canAccomplishTask = true;
		}
		this.CanAccomplishTask = canAccomplishTask;
		this.TabLayout = new GenericLayout<RewardTargetTabItem, RewardTabData>(base.GetHorizontalLayout(0), new Func<RewardTargetTabItem>(this.TabItemProxyCreate), null, false, true);
		this.LoopScroll = new LoopScrollView<TaskItem, TaskData>(base.GetLoopScrollViewComponent(2), (AUIBaseActor)base.GetItem(3).GetOwner(), new Func<TaskItem>(this.InitTargetItem), false);
	}

	// Token: 0x06008A54 RID: 35412 RVA: 0x001D8ED8 File Offset: 0x001D70D8
	private List<RewardTabData> CreateTabItemDataList(IReadOnlyList<TrackMoonTargetType> tabList)
	{
		List<RewardTabData> list = new List<RewardTabData>();
		for (int i = 0; i < tabList.Count; i++)
		{
			RewardTabData rewardTabData = new RewardTabData();
			rewardTabData.NameTextId = tabList[i].Name;
			rewardTabData.Index = i;
			rewardTabData.ClickedCallback = new Action<int>(this.TabCallBack);
			rewardTabData.RefreshRedDot = ((int tabIndex) => MoonChasingRewardModel.Instance.GetTaskDataRedDotStateByTabId(tabIndex));
			list.Add(rewardTabData);
		}
		return list;
	}

	// Token: 0x06008A55 RID: 35413 RVA: 0x001D8F60 File Offset: 0x001D7160
	protected override UniTask OnBeforeShowAsyncImplement()
	{
		RewardTargetTabView.<OnBeforeShowAsyncImplement>d__8 <OnBeforeShowAsyncImplement>d__;
		<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<RewardTargetTabView.<OnBeforeShowAsyncImplement>d__8>(ref <OnBeforeShowAsyncImplement>d__);
		return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06008A56 RID: 35414 RVA: 0x001D8FA4 File Offset: 0x001D71A4
	protected override void OnBeforeShow()
	{
		UiTabSequence tabBehavior = base.GetTabBehavior<UiTabSequence>();
		LevelSequencePlayer levelSequencePlayer = (tabBehavior != null) ? tabBehavior.GetLevelSequencePlayer() : null;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}
	}

	// Token: 0x06008A57 RID: 35415 RVA: 0x001D8FDE File Offset: 0x001D71DE
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.TakenRewardTargetData, new Action<int>(this.TakenRewardTargetData));
	}

	// Token: 0x06008A58 RID: 35416 RVA: 0x001D8FFC File Offset: 0x001D71FC
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.TakenRewardTargetData, new Action<int>(this.TakenRewardTargetData));
	}

	// Token: 0x06008A59 RID: 35417 RVA: 0x001D901C File Offset: 0x001D721C
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		UUIItem grid = this.LoopScroll.GetGrid(0);
		if (grid == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			grid,
			grid
		};
	}

	// Token: 0x06008A5A RID: 35418 RVA: 0x001D9049 File Offset: 0x001D7249
	private void TakenRewardTargetData(int id)
	{
		if (MoonChasingRewardModel.Instance.GetTaskDataById(id) == null)
		{
			return;
		}
		this.TabLayout.GetLayoutItemByIndex(this.CurrentTabIndex).RefreshRedDot();
		this.RefreshLoopScrollView(this.CurrentTabIndex);
	}

	// Token: 0x06008A5B RID: 35419 RVA: 0x001D907B File Offset: 0x001D727B
	private TaskItem InitTargetItem()
	{
		return new TaskItem();
	}

	// Token: 0x06008A5C RID: 35420 RVA: 0x001D9082 File Offset: 0x001D7282
	private RewardTargetTabItem TabItemProxyCreate()
	{
		return new RewardTargetTabItem();
	}

	// Token: 0x06008A5D RID: 35421 RVA: 0x001D908C File Offset: 0x001D728C
	private void TabCallBack(int index)
	{
		if (this.CurrentTabIndex != index && this.CurrentTabIndex != -1)
		{
			RewardTargetTabItem layoutItemByIndex = this.TabLayout.GetLayoutItemByIndex(this.CurrentTabIndex);
			if (layoutItemByIndex != null)
			{
				layoutItemByIndex.SetToggleState(false, false);
			}
		}
		this.CurrentTabIndex = index;
		this.RefreshLoopScrollView(this.CurrentTabIndex);
	}

	// Token: 0x06008A5E RID: 35422 RVA: 0x001D90DC File Offset: 0x001D72DC
	private void RefreshLoopScrollView(int tabIndex)
	{
		this.DataList.Clear();
		List<TaskData> taskDataByTabId = MoonChasingRewardModel.Instance.GetTaskDataByTabId(tabIndex + 1);
		taskDataByTabId.Sort(new Comparison<TaskData>(MoonChasingRewardModel.Instance.SortTaskData));
		if (!this.CanAccomplishTask)
		{
			using (List<TaskData>.Enumerator enumerator = taskDataByTabId.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					TaskData taskData = enumerator.Current;
					TaskData taskData2 = taskData.DeepCopy(taskData);
					taskData2.JumpId = 0;
					taskData2.DoingTextId = "Moonfiesta_TargetDone";
					this.DataList.Add(taskData2);
				}
				goto IL_8C;
			}
		}
		this.DataList = taskDataByTabId;
		IL_8C:
		this.LoopScroll.RefreshByDataAsync(this.DataList, false, true).Forget();
	}

	// Token: 0x04003DA5 RID: 15781
	protected GenericLayout<RewardTargetTabItem, RewardTabData> TabLayout;

	// Token: 0x04003DA6 RID: 15782
	private int CurrentTabIndex = -1;

	// Token: 0x04003DA7 RID: 15783
	protected LoopScrollView<TaskItem, TaskData> LoopScroll;

	// Token: 0x04003DA8 RID: 15784
	private List<TaskData> DataList = new List<TaskData>();

	// Token: 0x04003DA9 RID: 15785
	private bool CanAccomplishTask = true;

	// Token: 0x020079CB RID: 31179
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04028179 RID: 164217
		public const int TabRootItem = 0;

		// Token: 0x0402817A RID: 164218
		public const int TabItem = 1;

		// Token: 0x0402817B RID: 164219
		public const int Scroll = 2;

		// Token: 0x0402817C RID: 164220
		public const int TargetItem = 3;
	}
}
