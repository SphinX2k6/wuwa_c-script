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

// Token: 0x02000818 RID: 2072
[NullableContext(1)]
[Nullable(0)]
public class RewardTargetTabView : UiTabViewBase
{
	// Token: 0x06005DED RID: 24045 RVA: 0x001E1C44 File Offset: 0x001DFE44
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

	// Token: 0x06005DEE RID: 24046 RVA: 0x001E1CB4 File Offset: 0x001DFEB4
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

	// Token: 0x06005DEF RID: 24047 RVA: 0x001E1D34 File Offset: 0x001DFF34
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

	// Token: 0x06005DF0 RID: 24048 RVA: 0x001E1DBC File Offset: 0x001DFFBC
	protected override UniTask OnBeforeShowAsyncImplement()
	{
		RewardTargetTabView.<OnBeforeShowAsyncImplement>d__8 <OnBeforeShowAsyncImplement>d__;
		<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<RewardTargetTabView.<OnBeforeShowAsyncImplement>d__8>(ref <OnBeforeShowAsyncImplement>d__);
		return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06005DF1 RID: 24049 RVA: 0x001E1E00 File Offset: 0x001E0000
	protected override void OnBeforeShow()
	{
		UiTabSequence tabBehavior = base.GetTabBehavior<UiTabSequence>();
		LevelSequencePlayer levelSequencePlayer = (tabBehavior != null) ? tabBehavior.GetLevelSequencePlayer() : null;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}
	}

	// Token: 0x06005DF2 RID: 24050 RVA: 0x001E1E3A File Offset: 0x001E003A
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.TakenRewardTargetData, new Action<int>(this.TakenRewardTargetData));
	}

	// Token: 0x06005DF3 RID: 24051 RVA: 0x001E1E58 File Offset: 0x001E0058
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.TakenRewardTargetData, new Action<int>(this.TakenRewardTargetData));
	}

	// Token: 0x06005DF4 RID: 24052 RVA: 0x001E1E78 File Offset: 0x001E0078
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

	// Token: 0x06005DF5 RID: 24053 RVA: 0x001E1EA5 File Offset: 0x001E00A5
	private void TakenRewardTargetData(int id)
	{
		if (MoonChasingRewardModel.Instance.GetTaskDataById(id) == null)
		{
			return;
		}
		this.TabLayout.GetLayoutItemByIndex(this.CurrentTabIndex).RefreshRedDot();
		this.RefreshLoopScrollView(this.CurrentTabIndex);
	}

	// Token: 0x06005DF6 RID: 24054 RVA: 0x001E1ED7 File Offset: 0x001E00D7
	private TaskItem InitTargetItem()
	{
		return new TaskItem();
	}

	// Token: 0x06005DF7 RID: 24055 RVA: 0x001E1EDE File Offset: 0x001E00DE
	private RewardTargetTabItem TabItemProxyCreate()
	{
		return new RewardTargetTabItem();
	}

	// Token: 0x06005DF8 RID: 24056 RVA: 0x001E1EE8 File Offset: 0x001E00E8
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

	// Token: 0x06005DF9 RID: 24057 RVA: 0x001E1F38 File Offset: 0x001E0138
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

	// Token: 0x04003E3D RID: 15933
	protected GenericLayout<RewardTargetTabItem, RewardTabData> TabLayout;

	// Token: 0x04003E3E RID: 15934
	private int CurrentTabIndex = -1;

	// Token: 0x04003E3F RID: 15935
	protected LoopScrollView<TaskItem, TaskData> LoopScroll;

	// Token: 0x04003E40 RID: 15936
	private List<TaskData> DataList = new List<TaskData>();

	// Token: 0x04003E41 RID: 15937
	private bool CanAccomplishTask = true;

	// Token: 0x02006B55 RID: 27477
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x040234A6 RID: 144550
		public const int TabRootItem = 0;

		// Token: 0x040234A7 RID: 144551
		public const int TabItem = 1;

		// Token: 0x040234A8 RID: 144552
		public const int Scroll = 2;

		// Token: 0x040234A9 RID: 144553
		public const int TargetItem = 3;
	}
}
