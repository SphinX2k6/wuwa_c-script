using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000814 RID: 2068
[NullableContext(1)]
[Nullable(0)]
public class RewardMainView : UiViewBase
{
	// Token: 0x06005DC6 RID: 24006 RVA: 0x001E149C File Offset: 0x001DF69C
	public RewardMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06005DC7 RID: 24007 RVA: 0x001E14C4 File Offset: 0x001DF6C4
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

	// Token: 0x06005DC8 RID: 24008 RVA: 0x001E154C File Offset: 0x001DF74C
	protected override UniTask OnBeforeStartAsync()
	{
		RewardMainView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RewardMainView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005DC9 RID: 24009 RVA: 0x001E158F File Offset: 0x001DF78F
	protected override void OnBeforeShow()
	{
		ActivityMoonChasingController.Instance.CheckIsActivityClose();
	}

	// Token: 0x06005DCA RID: 24010 RVA: 0x001E159B File Offset: 0x001DF79B
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.TakenRewardTargetData, new Action<int>(this.TakenRewardTargetData));
		EventSystem.Instance.Add(EEventName.MoonChasingRefreshRewardRedDot, new Action(this.OnMoonChasingRefreshRewardRedDot));
	}

	// Token: 0x06005DCB RID: 24011 RVA: 0x001E15D5 File Offset: 0x001DF7D5
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.TakenRewardTargetData, new Action<int>(this.TakenRewardTargetData));
		EventSystem.Instance.Remove(EEventName.MoonChasingRefreshRewardRedDot, new Action(this.OnMoonChasingRefreshRewardRedDot));
	}

	// Token: 0x06005DCC RID: 24012 RVA: 0x001E1610 File Offset: 0x001DF810
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

	// Token: 0x06005DCD RID: 24013 RVA: 0x001E163E File Offset: 0x001DF83E
	private void OnMoonChasingRefreshRewardRedDot()
	{
		this.RefreshTabItem();
	}

	// Token: 0x06005DCE RID: 24014 RVA: 0x001E1646 File Offset: 0x001DF846
	private void OnClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x06005DCF RID: 24015 RVA: 0x001E164F File Offset: 0x001DF84F
	private void ToggleCallBack(int index)
	{
		this.InsControl.TabItemToggleClick(index);
	}

	// Token: 0x06005DD0 RID: 24016 RVA: 0x001E1660 File Offset: 0x001DF860
	public UniTask InitCaption()
	{
		RewardMainView.<InitCaption>d__16 <InitCaption>d__;
		<InitCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCaption>d__.<>4__this = this;
		<InitCaption>d__.<>1__state = -1;
		<InitCaption>d__.<>t__builder.Start<RewardMainView.<InitCaption>d__16>(ref <InitCaption>d__);
		return <InitCaption>d__.<>t__builder.Task;
	}

	// Token: 0x06005DD1 RID: 24017 RVA: 0x001E16A4 File Offset: 0x001DF8A4
	public UniTask InitGrandItem()
	{
		RewardMainView.<InitGrandItem>d__17 <InitGrandItem>d__;
		<InitGrandItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitGrandItem>d__.<>4__this = this;
		<InitGrandItem>d__.<>1__state = -1;
		<InitGrandItem>d__.<>t__builder.Start<RewardMainView.<InitGrandItem>d__17>(ref <InitGrandItem>d__);
		return <InitGrandItem>d__.<>t__builder.Task;
	}

	// Token: 0x06005DD2 RID: 24018 RVA: 0x001E16E8 File Offset: 0x001DF8E8
	private void RefreshGrandItem()
	{
		this.GrandItem.SetActive(false);
		TaskData specialTaskData = MoonChasingRewardModel.Instance.GetSpecialTaskData();
		this.GrandItem.Refresh(specialTaskData);
		this.GrandItem.SetActive(true);
	}

	// Token: 0x06005DD3 RID: 24019 RVA: 0x001E1724 File Offset: 0x001DF924
	private void RefreshTabItem()
	{
		bool allTaskDataRedDotState = MoonChasingRewardModel.Instance.GetAllTaskDataRedDotState(false);
		this.TabItemList[0].SetRedDotVisible(allTaskDataRedDotState);
		bool shopRedDotState = MoonChasingRewardModel.Instance.GetShopRedDotState();
		this.TabItemList[1].SetRedDotVisible(shopRedDotState);
	}

	// Token: 0x06005DD4 RID: 24020 RVA: 0x001E176C File Offset: 0x001DF96C
	public UniTask InitTabComponent()
	{
		RewardMainView.<InitTabComponent>d__20 <InitTabComponent>d__;
		<InitTabComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTabComponent>d__.<>4__this = this;
		<InitTabComponent>d__.<>1__state = -1;
		<InitTabComponent>d__.<>t__builder.Start<RewardMainView.<InitTabComponent>d__20>(ref <InitTabComponent>d__);
		return <InitTabComponent>d__.<>t__builder.Task;
	}

	// Token: 0x06005DD5 RID: 24021 RVA: 0x001E17AF File Offset: 0x001DF9AF
	public void InitTabViewComponent()
	{
		this.TabViewComponent = new TabViewComponent<UiDynamicTab>(base.GetItem(1), EKeyMode.Default);
	}

	// Token: 0x06005DD6 RID: 24022 RVA: 0x001E17C4 File Offset: 0x001DF9C4
	public void SetTabState(int index, bool state, bool bFireEvent)
	{
		this.TabItemList[index].SetToggleState(state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, bFireEvent);
	}

	// Token: 0x06005DD7 RID: 24023 RVA: 0x001E17E0 File Offset: 0x001DF9E0
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

	// Token: 0x04003E34 RID: 15924
	private readonly RewardInstanceController InsControl = new RewardInstanceController();

	// Token: 0x04003E35 RID: 15925
	protected PopupCaptionItem Caption;

	// Token: 0x04003E36 RID: 15926
	protected RewardGrandItem GrandItem;

	// Token: 0x04003E37 RID: 15927
	protected List<RewardMainTabItem> TabItemList = new List<RewardMainTabItem>();

	// Token: 0x04003E38 RID: 15928
	protected TabViewComponent<UiDynamicTab> TabViewComponent;

	// Token: 0x04003E39 RID: 15929
	private bool CanAccomplishTask = true;

	// Token: 0x02006B4C RID: 27468
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04023485 RID: 144517
		public const int CaptionItem = 0;

		// Token: 0x04023486 RID: 144518
		public const int ContentItem = 1;

		// Token: 0x04023487 RID: 144519
		public const int ShopButtonItem = 2;

		// Token: 0x04023488 RID: 144520
		public const int TargetButtonItem = 3;

		// Token: 0x04023489 RID: 144521
		public const int GrandItem = 4;
	}
}
