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

// Token: 0x0200127D RID: 4733
[NullableContext(1)]
[Nullable(0)]
public class FightPhotoRewardView : UiViewBase
{
	// Token: 0x06008133 RID: 33075 RVA: 0x001B67AD File Offset: 0x001B49AD
	public FightPhotoRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06008134 RID: 33076 RVA: 0x001B67B8 File Offset: 0x001B49B8
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

	// Token: 0x06008135 RID: 33077 RVA: 0x001B6854 File Offset: 0x001B4A54
	protected override UniTask OnBeforeStartAsync()
	{
		FightPhotoRewardView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FightPhotoRewardView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008136 RID: 33078 RVA: 0x001B6897 File Offset: 0x001B4A97
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x06008137 RID: 33079 RVA: 0x001B68D1 File Offset: 0x001B4AD1
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x06008138 RID: 33080 RVA: 0x001B690B File Offset: 0x001B4B0B
	private void OnRefreshCommonActivityRedDot(int activityId)
	{
		if (activityId == this.ActivityData.Id)
		{
			this.TabLayout.RefreshWithoutDataSync();
			this.RefreshTaskLayout(true);
		}
	}

	// Token: 0x06008139 RID: 33081 RVA: 0x001B692D File Offset: 0x001B4B2D
	private void RefreshTaskLayout(bool isPlayAnim = false)
	{
		this.TaskLayout.RefreshByData(this.ActivityData.GetTaskDataList(this.CurrentTabId), delegate
		{
			this.TaskLayout.LateScrollTo(this.TaskLayout.GetItemByIndex(0), null, false);
		}, isPlayAnim);
	}

	// Token: 0x0600813A RID: 33082 RVA: 0x001B6958 File Offset: 0x001B4B58
	private FightPhotoTaskTabItem CreateTabItem()
	{
		return new FightPhotoTaskTabItem
		{
			activityData = this.ActivityData,
			OnToggleClickCallBack = new Action<int>(this.OnTabClickCallBack)
		};
	}

	// Token: 0x0600813B RID: 33083 RVA: 0x001B697D File Offset: 0x001B4B7D
	private void OnTabClickCallBack(int tabId)
	{
		this.CurrentTabId = tabId;
		this.TabLayout.SelectGridProxyByKey(tabId, false);
		base.PlaySequence("Switch", null, false);
		this.RefreshTaskLayout(false);
	}

	// Token: 0x0600813C RID: 33084 RVA: 0x001B69AC File Offset: 0x001B4BAC
	private FightPhotoTaskItem CreateTaskItem()
	{
		return new FightPhotoTaskItem
		{
			OnRewardBtnClick = new Action(this.OnRewardBtnClick)
		};
	}

	// Token: 0x0600813D RID: 33085 RVA: 0x001B69C5 File Offset: 0x001B4BC5
	private void OnRewardBtnClick()
	{
		this.ActivityData.RequestTaskReward(this.CurrentTabId);
	}

	// Token: 0x0600813E RID: 33086 RVA: 0x001B69D8 File Offset: 0x001B4BD8
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600813F RID: 33087 RVA: 0x001B69E1 File Offset: 0x001B4BE1
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

	// Token: 0x04003A94 RID: 14996
	[Nullable(2)]
	private FightPhotoActivityData ActivityData;

	// Token: 0x04003A95 RID: 14997
	private int CurrentTabId;

	// Token: 0x04003A96 RID: 14998
	private GenericLayout<FightPhotoTaskTabItem, PhotoFightRewardTab> TabLayout;

	// Token: 0x04003A97 RID: 14999
	private GenericScrollViewNew<FightPhotoTaskItem, FightPhotoTaskData> TaskLayout;

	// Token: 0x02007893 RID: 30867
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04027BA6 RID: 162726
		ItemCaption,
		// Token: 0x04027BA7 RID: 162727
		LayoutTab,
		// Token: 0x04027BA8 RID: 162728
		ItemTab,
		// Token: 0x04027BA9 RID: 162729
		ScrollReward,
		// Token: 0x04027BAA RID: 162730
		ItemReward,
		// Token: 0x04027BAB RID: 162731
		AnimController
	}
}
