using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001360 RID: 4960
[NullableContext(1)]
[Nullable(0)]
public class RewardMainView : UiViewBase
{
	// Token: 0x06008A2B RID: 35371 RVA: 0x001D8640 File Offset: 0x001D6840
	public RewardMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06008A2C RID: 35372 RVA: 0x001D8668 File Offset: 0x001D6868
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x06008A2D RID: 35373 RVA: 0x001D86F0 File Offset: 0x001D68F0
	protected override UniTask OnBeforeStartAsync()
	{
		RewardMainView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RewardMainView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008A2E RID: 35374 RVA: 0x001D8733 File Offset: 0x001D6933
	protected override void OnBeforeShow()
	{
		ActivityMoonChasingController.Instance.CheckIsActivityClose();
	}

	// Token: 0x06008A2F RID: 35375 RVA: 0x001D873F File Offset: 0x001D693F
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.TakenRewardTargetData, new Action<int>(this.TakenRewardTargetData));
		EventSystem.Instance.Add(EEventName.MoonChasingRefreshRewardRedDot, new Action(this.OnMoonChasingRefreshRewardRedDot));
	}

	// Token: 0x06008A30 RID: 35376 RVA: 0x001D8779 File Offset: 0x001D6979
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.TakenRewardTargetData, new Action<int>(this.TakenRewardTargetData));
		EventSystem.Instance.Remove(EEventName.MoonChasingRefreshRewardRedDot, new Action(this.OnMoonChasingRefreshRewardRedDot));
	}

	// Token: 0x06008A31 RID: 35377 RVA: 0x001D87B4 File Offset: 0x001D69B4
	private void TakenRewardTargetData(int id)
	{
		TaskData specialTaskData = MoonChasingRewardModel.Instance.GetSpecialTaskData();
		if (id == specialTaskData.TaskId)
		{
			this.RefreshGrandItem();
			return;
		}
		this.RefreshTabItem();
	}

	// Token: 0x06008A32 RID: 35378 RVA: 0x001D87E2 File Offset: 0x001D69E2
	private void OnMoonChasingRefreshRewardRedDot()
	{
		this.RefreshTabItem();
	}

	// Token: 0x06008A33 RID: 35379 RVA: 0x001D87EA File Offset: 0x001D69EA
	private void OnClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x06008A34 RID: 35380 RVA: 0x001D87F3 File Offset: 0x001D69F3
	private void ToggleCallBack(int index)
	{
		this.InsControl.TabItemToggleClick(index);
	}

	// Token: 0x06008A35 RID: 35381 RVA: 0x001D8804 File Offset: 0x001D6A04
	public UniTask InitCaption()
	{
		RewardMainView.<InitCaption>d__16 <InitCaption>d__;
		<InitCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCaption>d__.<>4__this = this;
		<InitCaption>d__.<>1__state = -1;
		<InitCaption>d__.<>t__builder.Start<RewardMainView.<InitCaption>d__16>(ref <InitCaption>d__);
		return <InitCaption>d__.<>t__builder.Task;
	}

	// Token: 0x06008A36 RID: 35382 RVA: 0x001D8848 File Offset: 0x001D6A48
	public UniTask InitGrandItem()
	{
		RewardMainView.<InitGrandItem>d__17 <InitGrandItem>d__;
		<InitGrandItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitGrandItem>d__.<>4__this = this;
		<InitGrandItem>d__.<>1__state = -1;
		<InitGrandItem>d__.<>t__builder.Start<RewardMainView.<InitGrandItem>d__17>(ref <InitGrandItem>d__);
		return <InitGrandItem>d__.<>t__builder.Task;
	}

	// Token: 0x06008A37 RID: 35383 RVA: 0x001D888C File Offset: 0x001D6A8C
	private void RefreshGrandItem()
	{
		this.GrandItem.SetActive(false);
		TaskData specialTaskData = MoonChasingRewardModel.Instance.GetSpecialTaskData();
		this.GrandItem.Refresh(specialTaskData);
		this.GrandItem.SetActive(true);
	}

	// Token: 0x06008A38 RID: 35384 RVA: 0x001D88C8 File Offset: 0x001D6AC8
	private void RefreshTabItem()
	{
		bool allTaskDataRedDotState = MoonChasingRewardModel.Instance.GetAllTaskDataRedDotState(false);
		this.TabItemList[0].SetRedDotVisible(allTaskDataRedDotState);
		bool shopRedDotState = MoonChasingRewardModel.Instance.GetShopRedDotState();
		this.TabItemList[1].SetRedDotVisible(shopRedDotState);
	}

	// Token: 0x06008A39 RID: 35385 RVA: 0x001D8910 File Offset: 0x001D6B10
	public UniTask InitTabComponent()
	{
		RewardMainView.<InitTabComponent>d__20 <InitTabComponent>d__;
		<InitTabComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTabComponent>d__.<>4__this = this;
		<InitTabComponent>d__.<>1__state = -1;
		<InitTabComponent>d__.<>t__builder.Start<RewardMainView.<InitTabComponent>d__20>(ref <InitTabComponent>d__);
		return <InitTabComponent>d__.<>t__builder.Task;
	}

	// Token: 0x06008A3A RID: 35386 RVA: 0x001D8953 File Offset: 0x001D6B53
	public void InitTabViewComponent()
	{
		this.TabViewComponent = new TabViewComponent<UiDynamicTab>(base.GetItem(1), EKeyMode.Default);
	}

	// Token: 0x06008A3B RID: 35387 RVA: 0x001D8968 File Offset: 0x001D6B68
	public void SetTabState(int index, bool state, bool bFireEvent)
	{
		this.TabItemList[index].SetToggleState(state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, bFireEvent);
	}

	// Token: 0x06008A3C RID: 35388 RVA: 0x001D8984 File Offset: 0x001D6B84
	public void SwitchTabView(UiDynamicTab data, int index)
	{
		EUiTabViewName viewName = (EUiTabViewName)data.ChildViewName;
		this.TabViewComponent.ToggleCallBack(data, viewName, this.TabItemList[index], this.CanAccomplishTask, null);
		UUIItem rootItem = this.TabItemList[0].GetRootItem();
		UUIItem rootItem2 = this.TabItemList[1].GetRootItem();
		int hierarchyIndex = rootItem.GetHierarchyIndex();
		int hierarchyIndex2 = rootItem2.GetHierarchyIndex();
		if ((hierarchyIndex > hierarchyIndex2 && index == 0) || (hierarchyIndex < hierarchyIndex2 && index == 1))
		{
			return;
		}
		rootItem.SetHierarchyIndex(hierarchyIndex2);
		rootItem2.SetHierarchyIndex(hierarchyIndex);
	}

	// Token: 0x04003D9C RID: 15772
	private readonly RewardInstanceController InsControl = new RewardInstanceController();

	// Token: 0x04003D9D RID: 15773
	protected PopupCaptionItem Caption;

	// Token: 0x04003D9E RID: 15774
	protected RewardGrandItem GrandItem;

	// Token: 0x04003D9F RID: 15775
	protected List<RewardMainTabItem> TabItemList = new List<RewardMainTabItem>();

	// Token: 0x04003DA0 RID: 15776
	protected TabViewComponent<UiDynamicTab> TabViewComponent;

	// Token: 0x04003DA1 RID: 15777
	private bool CanAccomplishTask = true;

	// Token: 0x020079C2 RID: 31170
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04028158 RID: 164184
		public const int CaptionItem = 0;

		// Token: 0x04028159 RID: 164185
		public const int ContentItem = 1;

		// Token: 0x0402815A RID: 164186
		public const int ShopButtonItem = 2;

		// Token: 0x0402815B RID: 164187
		public const int TargetButtonItem = 3;

		// Token: 0x0402815C RID: 164188
		public const int GrandItem = 4;
	}
}
