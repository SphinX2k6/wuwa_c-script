using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020006BB RID: 1723
[NullableContext(1)]
[Nullable(0)]
public class CumulativeShopTaskView : UiViewBase
{
	// Token: 0x06004F1F RID: 20255 RVA: 0x001A9CDD File Offset: 0x001A7EDD
	public CumulativeShopTaskView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06004F20 RID: 20256 RVA: 0x001A9CE8 File Offset: 0x001A7EE8
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

	// Token: 0x06004F21 RID: 20257 RVA: 0x001A9D58 File Offset: 0x001A7F58
	protected override UniTask OnBeforeStartAsync()
	{
		CumulativeShopTaskView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CumulativeShopTaskView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004F22 RID: 20258 RVA: 0x001A9D9C File Offset: 0x001A7F9C
	protected override void OnStart()
	{
		this.TabScrollView = new GenericScrollViewNew<CumulativeShopTaskTabItem, int>(base.GetScrollViewWithScrollbar(4), new Func<CumulativeShopTaskTabItem>(this.InitTabItem), null, false, null);
		this.TaskLoopScrollView = new LoopScrollView<CumulativeShopTaskItem, int>(base.GetLoopScrollViewComponent(1), base.GetItem(2).GetOwner() as AUIBaseActor, new Func<CumulativeShopTaskItem>(this.InitTaskItem), false);
		this.CaptionItem.SetTitleLocalText("Activity_105100001_QuestList_Desc");
	}

	// Token: 0x06004F23 RID: 20259 RVA: 0x001A9E0A File Offset: 0x001A800A
	protected override void OnBeforeShow()
	{
		CumulativeShopController.Instance.ConsumptiveActivityInfoRequest();
	}

	// Token: 0x06004F24 RID: 20260 RVA: 0x001A9E18 File Offset: 0x001A8018
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.CumulativeShopTaskRefresh, new Action<int>(this.OnCumulativeShopTaskRefresh));
		EventSystem.Instance.Add(EEventName.CumulativeShopTaskViewDataRefresh, new Action(this.CumulativeShopTaskViewDataRefresh));
		EventSystem.Instance.Add(EEventName.OnActivityUpdate, new Action(this.OnActivityUpdate));
	}

	// Token: 0x06004F25 RID: 20261 RVA: 0x001A9E7C File Offset: 0x001A807C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.CumulativeShopTaskRefresh, new Action<int>(this.OnCumulativeShopTaskRefresh));
		EventSystem.Instance.Remove(EEventName.CumulativeShopTaskViewDataRefresh, new Action(this.CumulativeShopTaskViewDataRefresh));
		EventSystem.Instance.Remove(EEventName.OnActivityUpdate, new Action(this.OnActivityUpdate));
	}

	// Token: 0x06004F26 RID: 20262 RVA: 0x001A9EDD File Offset: 0x001A80DD
	private CumulativeShopTaskTabItem InitTabItem()
	{
		return new CumulativeShopTaskTabItem
		{
			OnClickBack = new Action<int, UUIExtendToggle>(this.OnClickTabBack)
		};
	}

	// Token: 0x06004F27 RID: 20263 RVA: 0x001A9EF6 File Offset: 0x001A80F6
	private CumulativeShopTaskItem InitTaskItem()
	{
		return new CumulativeShopTaskItem();
	}

	// Token: 0x06004F28 RID: 20264 RVA: 0x001A9F00 File Offset: 0x001A8100
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

	// Token: 0x06004F29 RID: 20265 RVA: 0x001A9F78 File Offset: 0x001A8178
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

	// Token: 0x06004F2A RID: 20266 RVA: 0x001A9FCF File Offset: 0x001A81CF
	private void OnCumulativeShopTaskRefresh(int tabIndex)
	{
		this.CumulativeShopTaskRefresh();
	}

	// Token: 0x06004F2B RID: 20267 RVA: 0x001A9FD8 File Offset: 0x001A81D8
	private void OnActivityUpdate()
	{
		CumulativeShopData cumulativeShopData = CumulativeShopController.Instance.GetCumulativeShopData();
		if (cumulativeShopData == null || !cumulativeShopData.CheckIfInOpenTime())
		{
			ActivityController.Instance.ShowActivityRefreshAndBackToBattleView();
		}
	}

	// Token: 0x06004F2C RID: 20268 RVA: 0x001AA008 File Offset: 0x001A8208
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

	// Token: 0x04003930 RID: 14640
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CumulativeShopTaskTabItem, int> TabScrollView;

	// Token: 0x04003931 RID: 14641
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<CumulativeShopTaskItem, int> TaskLoopScrollView;

	// Token: 0x04003932 RID: 14642
	[Nullable(2)]
	private UUIExtendToggle LastSelectToggle;

	// Token: 0x04003933 RID: 14643
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003934 RID: 14644
	private int CurrentSelectTabIndex;
}
