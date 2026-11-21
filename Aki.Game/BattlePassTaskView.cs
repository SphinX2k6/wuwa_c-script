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

// Token: 0x0200181B RID: 6171
[NullableContext(1)]
[Nullable(0)]
public class BattlePassTaskView : UiTabViewBase
{
	// Token: 0x0600F22F RID: 61999 RVA: 0x00472700 File Offset: 0x00470900
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

	// Token: 0x0600F230 RID: 62000 RVA: 0x004727AC File Offset: 0x004709AC
	private UniTask InitBattlePassBackgroundPanel()
	{
		BattlePassTaskView.<InitBattlePassBackgroundPanel>d__8 <InitBattlePassBackgroundPanel>d__;
		<InitBattlePassBackgroundPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitBattlePassBackgroundPanel>d__.<>4__this = this;
		<InitBattlePassBackgroundPanel>d__.<>1__state = -1;
		<InitBattlePassBackgroundPanel>d__.<>t__builder.Start<BattlePassTaskView.<InitBattlePassBackgroundPanel>d__8>(ref <InitBattlePassBackgroundPanel>d__);
		return <InitBattlePassBackgroundPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600F231 RID: 62001 RVA: 0x004727F0 File Offset: 0x004709F0
	private UniTask InitTaskLoopView()
	{
		BattlePassTaskView.<InitTaskLoopView>d__9 <InitTaskLoopView>d__;
		<InitTaskLoopView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTaskLoopView>d__.<>4__this = this;
		<InitTaskLoopView>d__.<>1__state = -1;
		<InitTaskLoopView>d__.<>t__builder.Start<BattlePassTaskView.<InitTaskLoopView>d__9>(ref <InitTaskLoopView>d__);
		return <InitTaskLoopView>d__.<>t__builder.Task;
	}

	// Token: 0x0600F232 RID: 62002 RVA: 0x00472834 File Offset: 0x00470A34
	protected override UniTask OnBeforeStartAsync()
	{
		BattlePassTaskView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BattlePassTaskView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F233 RID: 62003 RVA: 0x00472878 File Offset: 0x00470A78
	protected override void OnAfterShow()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence != null)
		{
			uiViewSequence.PlaySequence("Switch", false, null);
		}
		this.RefreshTaskData();
	}

	// Token: 0x0600F234 RID: 62004 RVA: 0x004728AC File Offset: 0x00470AAC
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

	// Token: 0x0600F235 RID: 62005 RVA: 0x004728F8 File Offset: 0x00470AF8
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.UpdateBattlePassTaskEvent, new Action(this.OnReceiveBattlePassTaskUpdate));
		EventSystem.Instance.Add(EEventName.ReceiveBattlePassTaskEvent, new Action<bool>(this.OnReceiveBattlePassTaskData));
	}

	// Token: 0x0600F236 RID: 62006 RVA: 0x00472932 File Offset: 0x00470B32
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.UpdateBattlePassTaskEvent, new Action(this.OnReceiveBattlePassTaskUpdate));
		EventSystem.Instance.Remove(EEventName.ReceiveBattlePassTaskEvent, new Action<bool>(this.OnReceiveBattlePassTaskData));
	}

	// Token: 0x0600F237 RID: 62007 RVA: 0x0047296C File Offset: 0x00470B6C
	private void OnReceiveBattlePassTaskUpdate()
	{
		this.RefreshTaskData();
	}

	// Token: 0x0600F238 RID: 62008 RVA: 0x00472974 File Offset: 0x00470B74
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

	// Token: 0x0600F239 RID: 62009 RVA: 0x004729D2 File Offset: 0x00470BD2
	private BattlePassTaskLoopItem CreateLoopItem()
	{
		return new BattlePassTaskLoopItem();
	}

	// Token: 0x0600F23A RID: 62010 RVA: 0x004729D9 File Offset: 0x00470BD9
	private BattlePassTaskTabItem InitDetail()
	{
		BattlePassTaskTabItem battlePassTaskTabItem = new BattlePassTaskTabItem();
		battlePassTaskTabItem.SetSelectedCallBack(new Action<int>(this.OnClickTypeToggle));
		battlePassTaskTabItem.SetCanExecuteChange(new Func<int, bool>(this.OnCanExecuteChange));
		return battlePassTaskTabItem;
	}

	// Token: 0x0600F23B RID: 62011 RVA: 0x00472A04 File Offset: 0x00470C04
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

	// Token: 0x0600F23C RID: 62012 RVA: 0x00472A4B File Offset: 0x00470C4B
	private bool OnCanExecuteChange(int index)
	{
		return this.CurrentIndex != index;
	}

	// Token: 0x0600F23D RID: 62013 RVA: 0x00472A5C File Offset: 0x00470C5C
	private void RefreshTaskData()
	{
		if (this.CurrentIndex == -1)
		{
			return;
		}
		BattlePassModel.Instance.GetTaskList(this.TypeList[this.CurrentIndex], this.TaskList);
		this.TaskLoopView.RefreshByData(this.TaskList, false, null, true);
	}

	// Token: 0x0600F23E RID: 62014 RVA: 0x00472AA8 File Offset: 0x00470CA8
	protected override void OnBeforeDestroy()
	{
		if (this.TaskLoopView != null)
		{
			this.TaskLoopView.ClearGridProxies();
			this.TaskLoopView = null;
		}
		this.TaskList = new List<BattlePassTaskData>();
	}

	// Token: 0x04008880 RID: 34944
	private int CurrentIndex = -1;

	// Token: 0x04008881 RID: 34945
	[Nullable(2)]
	private BattlePassBackgroundPanel BackgroundPanel;

	// Token: 0x04008882 RID: 34946
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<BattlePassTaskTabItem, EBattlePassTaskUpdateState> TypeLayout;

	// Token: 0x04008883 RID: 34947
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<BattlePassTaskLoopItem, BattlePassTaskData> TaskLoopView;

	// Token: 0x04008884 RID: 34948
	private List<BattlePassTaskData> TaskList = new List<BattlePassTaskData>();

	// Token: 0x04008885 RID: 34949
	private readonly List<EBattlePassTaskUpdateState> TypeList = new List<EBattlePassTaskUpdateState>
	{
		EBattlePassTaskUpdateState.EveryDay,
		EBattlePassTaskUpdateState.EveryWeek,
		EBattlePassTaskUpdateState.Always
	};

	// Token: 0x02007A41 RID: 31297
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04027A09 RID: 162313
		BattlePassBackground,
		// Token: 0x04027A0A RID: 162314
		TypeLayout,
		// Token: 0x04027A0B RID: 162315
		TaskLoop,
		// Token: 0x04027A0C RID: 162316
		TaskItem
	}
}
