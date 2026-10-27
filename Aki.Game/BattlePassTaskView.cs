using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002336 RID: 9014
[NullableContext(1)]
[Nullable(0)]
public class BattlePassTaskView : UiTabViewBase
{
	// Token: 0x06011D7F RID: 73087 RVA: 0x00465638 File Offset: 0x00463838
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06011D80 RID: 73088 RVA: 0x004656E4 File Offset: 0x004638E4
	private UniTask InitBattlePassBackgroundPanel()
	{
		BattlePassTaskView.<InitBattlePassBackgroundPanel>d__8 <InitBattlePassBackgroundPanel>d__;
		<InitBattlePassBackgroundPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitBattlePassBackgroundPanel>d__.<>4__this = this;
		<InitBattlePassBackgroundPanel>d__.<>1__state = -1;
		<InitBattlePassBackgroundPanel>d__.<>t__builder.Start<BattlePassTaskView.<InitBattlePassBackgroundPanel>d__8>(ref <InitBattlePassBackgroundPanel>d__);
		return <InitBattlePassBackgroundPanel>d__.<>t__builder.Task;
	}

	// Token: 0x06011D81 RID: 73089 RVA: 0x00465728 File Offset: 0x00463928
	private UniTask InitTaskLoopView()
	{
		BattlePassTaskView.<InitTaskLoopView>d__9 <InitTaskLoopView>d__;
		<InitTaskLoopView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTaskLoopView>d__.<>4__this = this;
		<InitTaskLoopView>d__.<>1__state = -1;
		<InitTaskLoopView>d__.<>t__builder.Start<BattlePassTaskView.<InitTaskLoopView>d__9>(ref <InitTaskLoopView>d__);
		return <InitTaskLoopView>d__.<>t__builder.Task;
	}

	// Token: 0x06011D82 RID: 73090 RVA: 0x0046576C File Offset: 0x0046396C
	protected override UniTask OnBeforeStartAsync()
	{
		BattlePassTaskView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BattlePassTaskView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011D83 RID: 73091 RVA: 0x004657B0 File Offset: 0x004639B0
	protected override void OnAfterShow()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence != null)
		{
			uiViewSequence.PlaySequence("Switch", false, null);
		}
		this.RefreshTaskData();
	}

	// Token: 0x06011D84 RID: 73092 RVA: 0x004657E4 File Offset: 0x004639E4
	public void SelectToggleByIndex(int index, bool bIgnored = false)
	{
		if (bIgnored)
		{
			BattlePassTaskTabItem layoutItemByIndex = this.TypeLayout.GetLayoutItemByIndex(this.CurrentIndex);
			if (layoutItemByIndex != null)
			{
				layoutItemByIndex.SetForceSwitch(EToggleState.ETT_UnChecked, false);
			}
			this.CurrentIndex = -1;
		}
		BattlePassTaskTabItem layoutItemByIndex2 = this.TypeLayout.GetLayoutItemByIndex(index);
		if (layoutItemByIndex2 != null)
		{
			layoutItemByIndex2.SetForceSwitch(EToggleState.ETT_Checked, true);
		}
	}

	// Token: 0x06011D85 RID: 73093 RVA: 0x00465830 File Offset: 0x00463A30
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.UpdateBattlePassTaskEvent, new Action(this.OnReceiveBattlePassTaskUpdate));
		EventSystem.Instance.Add(EEventName.ReceiveBattlePassTaskEvent, new Action<bool>(this.OnReceiveBattlePassTaskData));
	}

	// Token: 0x06011D86 RID: 73094 RVA: 0x0046586A File Offset: 0x00463A6A
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.UpdateBattlePassTaskEvent, new Action(this.OnReceiveBattlePassTaskUpdate));
		EventSystem.Instance.Remove(EEventName.ReceiveBattlePassTaskEvent, new Action<bool>(this.OnReceiveBattlePassTaskData));
	}

	// Token: 0x06011D87 RID: 73095 RVA: 0x004658A4 File Offset: 0x00463AA4
	private void OnReceiveBattlePassTaskUpdate()
	{
		this.RefreshTaskData();
	}

	// Token: 0x06011D88 RID: 73096 RVA: 0x004658AC File Offset: 0x00463AAC
	private void OnReceiveBattlePassTaskData(bool isWeekUpdate)
	{
		if (this.CurrentIndex == -1)
		{
			return;
		}
		if (this.TypeList[this.CurrentIndex] == EBattlePassTaskUpdateState.EveryDay || (this.TypeList[this.CurrentIndex] == EBattlePassTaskUpdateState.EveryWeek && isWeekUpdate))
		{
			ConfirmBoxController.Instance.ShowConfirmBoxNew(new ConfirmBoxDataNew(EConfirmBoxConfigId.BattlePassTaskExpire));
		}
		this.RefreshTaskData();
	}

	// Token: 0x06011D89 RID: 73097 RVA: 0x0046590A File Offset: 0x00463B0A
	private BattlePassTaskLoopItem CreateLoopItem()
	{
		return new BattlePassTaskLoopItem();
	}

	// Token: 0x06011D8A RID: 73098 RVA: 0x00465911 File Offset: 0x00463B11
	private BattlePassTaskTabItem InitDetail()
	{
		BattlePassTaskTabItem battlePassTaskTabItem = new BattlePassTaskTabItem();
		battlePassTaskTabItem.SetSelectedCallBack(new Action<int>(this.OnClickTypeToggle));
		battlePassTaskTabItem.SetCanExecuteChange(new Func<int, bool>(this.OnCanExecuteChange));
		return battlePassTaskTabItem;
	}

	// Token: 0x06011D8B RID: 73099 RVA: 0x0046593C File Offset: 0x00463B3C
	private void OnClickTypeToggle(int index)
	{
		if (index == this.CurrentIndex)
		{
			return;
		}
		int currentIndex = this.CurrentIndex;
		this.CurrentIndex = index;
		if (currentIndex != -1)
		{
			BattlePassTaskTabItem layoutItemByIndex = this.TypeLayout.GetLayoutItemByIndex(currentIndex);
			if (layoutItemByIndex != null)
			{
				layoutItemByIndex.SetForceSwitch(EToggleState.ETT_UnChecked, false);
			}
		}
		this.RefreshTaskData();
	}

	// Token: 0x06011D8C RID: 73100 RVA: 0x00465983 File Offset: 0x00463B83
	private bool OnCanExecuteChange(int index)
	{
		return this.CurrentIndex != index;
	}

	// Token: 0x06011D8D RID: 73101 RVA: 0x00465994 File Offset: 0x00463B94
	private void RefreshTaskData()
	{
		if (this.CurrentIndex == -1)
		{
			return;
		}
		BattlePassModel.Instance.GetTaskList(this.TypeList[this.CurrentIndex], this.TaskList);
		this.TaskLoopView.RefreshByData(this.TaskList, false, null, true);
	}

	// Token: 0x06011D8E RID: 73102 RVA: 0x004659E0 File Offset: 0x00463BE0
	protected override void OnBeforeDestroy()
	{
		if (this.TaskLoopView != null)
		{
			this.TaskLoopView.ClearGridProxies();
			this.TaskLoopView = null;
		}
		this.TaskList = new List<BattlePassTaskData>();
	}

	// Token: 0x0400873D RID: 34621
	private int CurrentIndex = -1;

	// Token: 0x0400873E RID: 34622
	[Nullable(2)]
	private BattlePassBackgroundPanel BackgroundPanel;

	// Token: 0x0400873F RID: 34623
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<BattlePassTaskTabItem, EBattlePassTaskUpdateState> TypeLayout;

	// Token: 0x04008740 RID: 34624
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<BattlePassTaskLoopItem, BattlePassTaskData> TaskLoopView;

	// Token: 0x04008741 RID: 34625
	private List<BattlePassTaskData> TaskList = new List<BattlePassTaskData>();

	// Token: 0x04008742 RID: 34626
	private readonly List<EBattlePassTaskUpdateState> TypeList = new List<EBattlePassTaskUpdateState>
	{
		EBattlePassTaskUpdateState.EveryDay,
		EBattlePassTaskUpdateState.EveryWeek,
		EBattlePassTaskUpdateState.Always
	};

	// Token: 0x020088B8 RID: 35000
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402C6F5 RID: 182005
		BattlePassBackground,
		// Token: 0x0402C6F6 RID: 182006
		TypeLayout,
		// Token: 0x0402C6F7 RID: 182007
		TaskLoop,
		// Token: 0x0402C6F8 RID: 182008
		TaskItem
	}
}
