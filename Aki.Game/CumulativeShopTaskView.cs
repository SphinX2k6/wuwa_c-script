using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001207 RID: 4615
[NullableContext(1)]
[Nullable(0)]
public class CumulativeShopTaskView : UiViewBase
{
	// Token: 0x06007B89 RID: 31625 RVA: 0x001A1025 File Offset: 0x0019F225
	public CumulativeShopTaskView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06007B8A RID: 31626 RVA: 0x001A1030 File Offset: 0x0019F230
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent))
		};
	}

	// Token: 0x06007B8B RID: 31627 RVA: 0x001A10A0 File Offset: 0x0019F2A0
	protected override UniTask OnBeforeStartAsync()
	{
		CumulativeShopTaskView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CumulativeShopTaskView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007B8C RID: 31628 RVA: 0x001A10E4 File Offset: 0x0019F2E4
	protected override void OnStart()
	{
		this.TabScrollView = new GenericScrollViewNew<CumulativeShopTaskTabItem, int>(base.GetScrollViewWithScrollbar(4), new Func<CumulativeShopTaskTabItem>(this.InitTabItem), null, false, null);
		this.TaskLoopScrollView = new LoopScrollView<CumulativeShopTaskItem, int>(base.GetLoopScrollViewComponent(1), base.GetItem(2).GetOwner() as AUIBaseActor, new Func<CumulativeShopTaskItem>(this.InitTaskItem), false);
		this.CaptionItem.SetTitleLocalText("Activity_105100001_QuestList_Desc");
	}

	// Token: 0x06007B8D RID: 31629 RVA: 0x001A1152 File Offset: 0x0019F352
	protected override void OnBeforeShow()
	{
		CumulativeShopController.Instance.ConsumptiveActivityInfoRequest();
	}

	// Token: 0x06007B8E RID: 31630 RVA: 0x001A1160 File Offset: 0x0019F360
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.CumulativeShopTaskRefresh, new Action<int>(this.OnCumulativeShopTaskRefresh));
		EventSystem.Instance.Add(EEventName.CumulativeShopTaskViewDataRefresh, new Action(this.CumulativeShopTaskViewDataRefresh));
		EventSystem.Instance.Add(EEventName.OnActivityUpdate, new Action(this.OnActivityUpdate));
	}

	// Token: 0x06007B8F RID: 31631 RVA: 0x001A11C4 File Offset: 0x0019F3C4
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.CumulativeShopTaskRefresh, new Action<int>(this.OnCumulativeShopTaskRefresh));
		EventSystem.Instance.Remove(EEventName.CumulativeShopTaskViewDataRefresh, new Action(this.CumulativeShopTaskViewDataRefresh));
		EventSystem.Instance.Remove(EEventName.OnActivityUpdate, new Action(this.OnActivityUpdate));
	}

	// Token: 0x06007B90 RID: 31632 RVA: 0x001A1225 File Offset: 0x0019F425
	private CumulativeShopTaskTabItem InitTabItem()
	{
		return new CumulativeShopTaskTabItem
		{
			OnClickBack = new Action<int, UUIExtendToggle>(this.OnClickTabBack)
		};
	}

	// Token: 0x06007B91 RID: 31633 RVA: 0x001A123E File Offset: 0x0019F43E
	private CumulativeShopTaskItem InitTaskItem()
	{
		return new CumulativeShopTaskItem();
	}

	// Token: 0x06007B92 RID: 31634 RVA: 0x001A1248 File Offset: 0x0019F448
	private void OnClickTabBack(int tabIndex, UUIExtendToggle toggle)
	{
		UUIExtendToggle lastSelectToggle = this.LastSelectToggle;
		if (lastSelectToggle != null)
		{
			lastSelectToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.LastSelectToggle = toggle;
		this.CurrentSelectTabIndex = tabIndex;
		List<int> tabTaskList = CumulativeShopController.Instance.GetCumulativeShopData().GetTabTaskList(tabIndex);
		this.TaskLoopScrollView.RefreshByData(tabTaskList ?? new List<int>(), false, null, false);
		UUIInturnAnimController uiAnimController = this.TaskLoopScrollView.GetUiAnimController();
		if (uiAnimController == null)
		{
			return;
		}
		uiAnimController.Play("", -1, false);
	}

	// Token: 0x06007B93 RID: 31635 RVA: 0x001A12C0 File Offset: 0x0019F4C0
	private void CumulativeShopTaskRefresh()
	{
		List<int> tabTaskList = CumulativeShopController.Instance.GetCumulativeShopData().GetTabTaskList(this.CurrentSelectTabIndex);
		this.TaskLoopScrollView.RefreshByData(tabTaskList ?? new List<int>(), false, null, false);
		UUIInturnAnimController uiAnimController = this.TaskLoopScrollView.GetUiAnimController();
		if (uiAnimController == null)
		{
			return;
		}
		uiAnimController.Play("", -1, false);
	}

	// Token: 0x06007B94 RID: 31636 RVA: 0x001A1317 File Offset: 0x0019F517
	private void OnCumulativeShopTaskRefresh(int tabIndex)
	{
		this.CumulativeShopTaskRefresh();
	}

	// Token: 0x06007B95 RID: 31637 RVA: 0x001A1320 File Offset: 0x0019F520
	private void OnActivityUpdate()
	{
		CumulativeShopData cumulativeShopData = CumulativeShopController.Instance.GetCumulativeShopData();
		if (cumulativeShopData == null || !cumulativeShopData.CheckIfInOpenTime())
		{
			ActivityController.Instance.ShowActivityRefreshAndBackToBattleView();
		}
	}

	// Token: 0x06007B96 RID: 31638 RVA: 0x001A1350 File Offset: 0x0019F550
	private void CumulativeShopTaskViewDataRefresh()
	{
		List<int> taskTabList = new List<int>(CumulativeShopController.Instance.GetCumulativeShopData().TaskTabMap.Keys);
		taskTabList.Sort((int a, int b) => a - b);
		this.TabScrollView.RefreshByData(taskTabList, delegate
		{
			CumulativeShopData cumulativeShopData = CumulativeShopController.Instance.GetCumulativeShopData();
			bool flag = false;
			for (int i = 0; i < taskTabList.Count; i++)
			{
				int tabIndex = taskTabList[i];
				if (cumulativeShopData.GetTaskTabRedDot(tabIndex))
				{
					this.TabScrollView.SelectGridProxy(i, false);
					if (this.CurrentSelectTabIndex - 1 == i)
					{
						this.CumulativeShopTaskRefresh();
					}
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				this.TabScrollView.SelectGridProxy(Math.Max(this.CurrentSelectTabIndex - 1, 0), true);
				this.CumulativeShopTaskRefresh();
			}
		}, false);
	}

	// Token: 0x04003897 RID: 14487
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CumulativeShopTaskTabItem, int> TabScrollView;

	// Token: 0x04003898 RID: 14488
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<CumulativeShopTaskItem, int> TaskLoopScrollView;

	// Token: 0x04003899 RID: 14489
	[Nullable(2)]
	private UUIExtendToggle LastSelectToggle;

	// Token: 0x0400389A RID: 14490
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400389B RID: 14491
	private int CurrentSelectTabIndex;
}
