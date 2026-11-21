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

// Token: 0x02000731 RID: 1841
[NullableContext(1)]
[Nullable(0)]
public class FightPhotoRewardView : UiViewBase
{
	// Token: 0x060054CA RID: 21706 RVA: 0x001BF47D File Offset: 0x001BD67D
	public FightPhotoRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060054CB RID: 21707 RVA: 0x001BF488 File Offset: 0x001BD688
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIInturnAnimController))
		};
	}

	// Token: 0x060054CC RID: 21708 RVA: 0x001BF524 File Offset: 0x001BD724
	protected override UniTask OnBeforeStartAsync()
	{
		FightPhotoRewardView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FightPhotoRewardView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060054CD RID: 21709 RVA: 0x001BF567 File Offset: 0x001BD767
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x060054CE RID: 21710 RVA: 0x001BF5A1 File Offset: 0x001BD7A1
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x060054CF RID: 21711 RVA: 0x001BF5DB File Offset: 0x001BD7DB
	private void OnRefreshCommonActivityRedDot(int activityId)
	{
		if (activityId == this.ActivityData.Id)
		{
			this.TabLayout.RefreshWithoutDataSync();
			this.RefreshTaskLayout(true);
		}
	}

	// Token: 0x060054D0 RID: 21712 RVA: 0x001BF5FD File Offset: 0x001BD7FD
	private void RefreshTaskLayout(bool isPlayAnim = false)
	{
		this.TaskLayout.RefreshByData(this.ActivityData.GetTaskDataList(this.CurrentTabId), delegate
		{
			this.TaskLayout.LateScrollTo(this.TaskLayout.GetItemByIndex(0), null, false);
		}, isPlayAnim);
	}

	// Token: 0x060054D1 RID: 21713 RVA: 0x001BF628 File Offset: 0x001BD828
	private FightPhotoTaskTabItem CreateTabItem()
	{
		return new FightPhotoTaskTabItem
		{
			activityData = this.ActivityData,
			OnToggleClickCallBack = new Action<int>(this.OnTabClickCallBack)
		};
	}

	// Token: 0x060054D2 RID: 21714 RVA: 0x001BF64D File Offset: 0x001BD84D
	private void OnTabClickCallBack(int tabId)
	{
		this.CurrentTabId = tabId;
		this.TabLayout.SelectGridProxyByKey(tabId, false);
		base.PlaySequence("Switch", null, false);
		this.RefreshTaskLayout(false);
	}

	// Token: 0x060054D3 RID: 21715 RVA: 0x001BF67C File Offset: 0x001BD87C
	private FightPhotoTaskItem CreateTaskItem()
	{
		return new FightPhotoTaskItem
		{
			OnRewardBtnClick = new Action(this.OnRewardBtnClick)
		};
	}

	// Token: 0x060054D4 RID: 21716 RVA: 0x001BF695 File Offset: 0x001BD895
	private void OnRewardBtnClick()
	{
		this.ActivityData.RequestTaskReward(this.CurrentTabId);
	}

	// Token: 0x060054D5 RID: 21717 RVA: 0x001BF6A8 File Offset: 0x001BD8A8
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x060054D6 RID: 21718 RVA: 0x001BF6B1 File Offset: 0x001BD8B1
	private void OnActivitySequenceEmitEvent(string param)
	{
		if (param == "ListAnim")
		{
			UUIInturnAnimController uiInturnAnimController = base.GetUiInturnAnimController(5);
			if (uiInturnAnimController == null)
			{
				return;
			}
			uiInturnAnimController.Play("", -1, false);
		}
	}

	// Token: 0x04003B2C RID: 15148
	[Nullable(2)]
	private FightPhotoActivityData ActivityData;

	// Token: 0x04003B2D RID: 15149
	private int CurrentTabId;

	// Token: 0x04003B2E RID: 15150
	private GenericLayout<FightPhotoTaskTabItem, PhotoFightRewardTab> TabLayout;

	// Token: 0x04003B2F RID: 15151
	private GenericScrollViewNew<FightPhotoTaskItem, FightPhotoTaskData> TaskLayout;

	// Token: 0x02006A1E RID: 27166
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04022ED7 RID: 143063
		ItemCaption,
		// Token: 0x04022ED8 RID: 143064
		LayoutTab,
		// Token: 0x04022ED9 RID: 143065
		ItemTab,
		// Token: 0x04022EDA RID: 143066
		ScrollReward,
		// Token: 0x04022EDB RID: 143067
		ItemReward,
		// Token: 0x04022EDC RID: 143068
		AnimController
	}
}
