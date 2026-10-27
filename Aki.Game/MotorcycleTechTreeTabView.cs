using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Motorcycle.Model;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002274 RID: 8820
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleTechTreeTabView : UiTabViewBase
{
	// Token: 0x170015F4 RID: 5620
	// (get) Token: 0x06011391 RID: 70545 RVA: 0x004330F1 File Offset: 0x004312F1
	private bool IsLockByTime
	{
		get
		{
			return MotorcycleDevelopModel.Instance.IsSwitchTechTreeTimeLocked();
		}
	}

	// Token: 0x170015F5 RID: 5621
	// (get) Token: 0x06011392 RID: 70546 RVA: 0x004330FD File Offset: 0x004312FD
	private bool IsLockByPlayerStatus
	{
		get
		{
			return MotorcycleDevelopModel.Instance.IsSwitchTechTreePlayerLocked();
		}
	}

	// Token: 0x06011393 RID: 70547 RVA: 0x0043310C File Offset: 0x0043130C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.OnBtnSwitchClick))
		};
	}

	// Token: 0x06011394 RID: 70548 RVA: 0x0043323C File Offset: 0x0043143C
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleTechTreeTabView.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleTechTreeTabView.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011395 RID: 70549 RVA: 0x0043327F File Offset: 0x0043147F
	protected override void OnBeforeShow()
	{
		this.SelectedTreeType = MotorcycleDevelopModel.Instance.GetSelectedTreeType();
		if (this.SelectedTreeType == 0)
		{
			this.SelectedTreeType = MotorcycleDevelopModel.Instance.GetCurTreeType();
		}
		this.OnTabUpdateAsync();
		MotorcycleUiModelUtil.Instance.ShowMotorLoadingIcon(false);
	}

	// Token: 0x06011396 RID: 70550 RVA: 0x004332BB File Offset: 0x004314BB
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MotorDevelopTechTreeUpdate, new Action<bool>(this.OnTechTreeNodeUpdate));
	}

	// Token: 0x06011397 RID: 70551 RVA: 0x004332D9 File Offset: 0x004314D9
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MotorDevelopTechTreeUpdate, new Action<bool>(this.OnTechTreeNodeUpdate));
	}

	// Token: 0x06011398 RID: 70552 RVA: 0x004332F7 File Offset: 0x004314F7
	protected override void OnBeforeHide()
	{
		this.CanPlayChangeTween = false;
	}

	// Token: 0x06011399 RID: 70553 RVA: 0x00433300 File Offset: 0x00431500
	private void OnTechTreeNodeUpdate(bool isUpdateNode)
	{
		this.RefreshCurrencyItemList();
		if (isUpdateNode)
		{
			this.OnNodeUpdateAsync(false);
			return;
		}
		this.OnTabItemUpdateAsync();
		this.RefreshActivateTreeTypeBtn();
	}

	// Token: 0x0601139A RID: 70554 RVA: 0x00433324 File Offset: 0x00431524
	private UniTask OnNodeUpdateAsync(bool isPlayNodeTween)
	{
		MotorcycleTechTreeTabView.<OnNodeUpdateAsync>d__24 <OnNodeUpdateAsync>d__;
		<OnNodeUpdateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnNodeUpdateAsync>d__.<>4__this = this;
		<OnNodeUpdateAsync>d__.isPlayNodeTween = isPlayNodeTween;
		<OnNodeUpdateAsync>d__.<>1__state = -1;
		<OnNodeUpdateAsync>d__.<>t__builder.Start<MotorcycleTechTreeTabView.<OnNodeUpdateAsync>d__24>(ref <OnNodeUpdateAsync>d__);
		return <OnNodeUpdateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601139B RID: 70555 RVA: 0x00433370 File Offset: 0x00431570
	private UniTask OnTabItemUpdateAsync()
	{
		MotorcycleTechTreeTabView.<OnTabItemUpdateAsync>d__25 <OnTabItemUpdateAsync>d__;
		<OnTabItemUpdateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnTabItemUpdateAsync>d__.<>4__this = this;
		<OnTabItemUpdateAsync>d__.<>1__state = -1;
		<OnTabItemUpdateAsync>d__.<>t__builder.Start<MotorcycleTechTreeTabView.<OnTabItemUpdateAsync>d__25>(ref <OnTabItemUpdateAsync>d__);
		return <OnTabItemUpdateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601139C RID: 70556 RVA: 0x004333B4 File Offset: 0x004315B4
	private UniTask OnTabUpdateAsync()
	{
		MotorcycleTechTreeTabView.<OnTabUpdateAsync>d__26 <OnTabUpdateAsync>d__;
		<OnTabUpdateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnTabUpdateAsync>d__.<>4__this = this;
		<OnTabUpdateAsync>d__.<>1__state = -1;
		<OnTabUpdateAsync>d__.<>t__builder.Start<MotorcycleTechTreeTabView.<OnTabUpdateAsync>d__26>(ref <OnTabUpdateAsync>d__);
		return <OnTabUpdateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601139D RID: 70557 RVA: 0x004333F7 File Offset: 0x004315F7
	private MotorcycleTechTreeNodeListItem InitListItem()
	{
		return new MotorcycleTechTreeNodeListItem
		{
			OnAfterRefreshOneNode = new Action<MotorcycleTechTreeNodeItem>(this.OnAfterRefreshOneNode)
		};
	}

	// Token: 0x0601139E RID: 70558 RVA: 0x00433410 File Offset: 0x00431610
	private MotorcycleTreeTypeTabItem InitTreeTabItem([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new MotorcycleTreeTypeTabItem();
	}

	// Token: 0x0601139F RID: 70559 RVA: 0x00433417 File Offset: 0x00431617
	private void OnAfterRefreshOneNode(MotorcycleTechTreeNodeItem nodeItem)
	{
		if (nodeItem == null)
		{
			return;
		}
		nodeItem.OnClickToggleBack = new Action<MotorTechTreeNode, UUIExtendToggle>(this.OnClickNode);
		this.ExclusiveNodeItemList.Add(nodeItem);
	}

	// Token: 0x060113A0 RID: 70560 RVA: 0x0043343C File Offset: 0x0043163C
	private void OnClickNode(MotorTechTreeNode treeNode, UUIExtendToggle toggle)
	{
		MotorcycleTechTreeTabView.<>c__DisplayClass30_0 CS$<>8__locals1 = new MotorcycleTechTreeTabView.<>c__DisplayClass30_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.treeNode = treeNode;
		if (this.CurrentSelectToggle != null)
		{
			this.CurrentSelectToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentSelectToggle = toggle;
		this.CurrentSelectToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		this.CurrentSelectNode = CS$<>8__locals1.treeNode;
		new UiAsyncTask("UpdateNodeInfoPanel", delegate()
		{
			MotorcycleTechTreeTabView.<>c__DisplayClass30_0.<<OnClickNode>b__0>d <<OnClickNode>b__0>d;
			<<OnClickNode>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnClickNode>b__0>d.<>4__this = CS$<>8__locals1;
			<<OnClickNode>b__0>d.<>1__state = -1;
			<<OnClickNode>b__0>d.<>t__builder.Start<MotorcycleTechTreeTabView.<>c__DisplayClass30_0.<<OnClickNode>b__0>d>(ref <<OnClickNode>b__0>d);
			return <<OnClickNode>b__0>d.<>t__builder.Task;
		}, null).Run();
	}

	// Token: 0x060113A1 RID: 70561 RVA: 0x004334B8 File Offset: 0x004316B8
	private void ToggleCallBack(int index)
	{
		if (this.IsFirstInitTab)
		{
			return;
		}
		if (index == 1)
		{
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "MotorTechTab2");
		}
		else if (index == 2)
		{
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "MotorTechTab3");
		}
		this.RefreshUiAsync(index);
	}

	// Token: 0x060113A2 RID: 70562 RVA: 0x0043350C File Offset: 0x0043170C
	private UniTask RefreshUiAsync(int selectIndex)
	{
		MotorcycleTechTreeTabView.<RefreshUiAsync>d__32 <RefreshUiAsync>d__;
		<RefreshUiAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshUiAsync>d__.<>4__this = this;
		<RefreshUiAsync>d__.selectIndex = selectIndex;
		<RefreshUiAsync>d__.<>1__state = -1;
		<RefreshUiAsync>d__.<>t__builder.Start<MotorcycleTechTreeTabView.<RefreshUiAsync>d__32>(ref <RefreshUiAsync>d__);
		return <RefreshUiAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060113A3 RID: 70563 RVA: 0x00433558 File Offset: 0x00431758
	private void RefreshActivateTreeTypeBtn()
	{
		bool flag = MotorcycleDevelopModel.Instance.GetCurTreeType() == this.SelectedTreeType;
		base.GetItem(4).SetUIActive(!flag);
		base.GetItem(6).SetUIActive(flag);
	}

	// Token: 0x060113A4 RID: 70564 RVA: 0x00433598 File Offset: 0x00431798
	private void RefreshCurrencyItemList()
	{
		if (MotorcycleDevelopModel.Instance.IsAllNodeMaxLevel(this.SelectedTreeType))
		{
			MotorDevelopRootData p = new MotorDevelopRootData
			{
				Currency = Array.Empty<int>()
			};
			EventSystem.Instance.Emit<MotorDevelopRootData>(EEventName.MotorDevelopRootUpdate, p);
			return;
		}
		MotorTechTree? motorTechTreeConfig = MotorConfig.Instance.GetMotorTechTreeConfig(this.SelectedTreeType);
		if (motorTechTreeConfig != null)
		{
			MotorDevelopRootData p2 = new MotorDevelopRootData
			{
				Currency = new int[]
				{
					motorTechTreeConfig.Value.TpItemId
				}
			};
			EventSystem.Instance.Emit<MotorDevelopRootData>(EEventName.MotorDevelopRootUpdate, p2);
		}
	}

	// Token: 0x060113A5 RID: 70565 RVA: 0x0043362C File Offset: 0x0043182C
	private UniTask RefreshCommonNodeList()
	{
		MotorcycleTechTreeTabView.<RefreshCommonNodeList>d__35 <RefreshCommonNodeList>d__;
		<RefreshCommonNodeList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshCommonNodeList>d__.<>4__this = this;
		<RefreshCommonNodeList>d__.<>1__state = -1;
		<RefreshCommonNodeList>d__.<>t__builder.Start<MotorcycleTechTreeTabView.<RefreshCommonNodeList>d__35>(ref <RefreshCommonNodeList>d__);
		return <RefreshCommonNodeList>d__.<>t__builder.Task;
	}

	// Token: 0x060113A6 RID: 70566 RVA: 0x00433670 File Offset: 0x00431870
	private UniTask RefreshAllNodes()
	{
		MotorcycleTechTreeTabView.<RefreshAllNodes>d__36 <RefreshAllNodes>d__;
		<RefreshAllNodes>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAllNodes>d__.<>4__this = this;
		<RefreshAllNodes>d__.<>1__state = -1;
		<RefreshAllNodes>d__.<>t__builder.Start<MotorcycleTechTreeTabView.<RefreshAllNodes>d__36>(ref <RefreshAllNodes>d__);
		return <RefreshAllNodes>d__.<>t__builder.Task;
	}

	// Token: 0x060113A7 RID: 70567 RVA: 0x004336B4 File Offset: 0x004318B4
	private void OnBtnSwitchClick()
	{
		if (this.IsLockByTime)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("MotorBike_TechTree_ChangeFail_Time", Array.Empty<object>());
			return;
		}
		if (this.IsLockByPlayerStatus)
		{
			return;
		}
		MotorcycleDevelopController.Instance.RequestMotorTechTreeSwitch(this.SelectedTreeType, delegate
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("SwitchMotorTechTreeCD");
			if (intConfig != null)
			{
				MotorcycleDevelopModel.Instance.StartSwitchTechTreeLockTimer(intConfig.Value);
			}
		});
	}

	// Token: 0x060113A8 RID: 70568 RVA: 0x00433718 File Offset: 0x00431918
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		string a = configParams[0];
		if (a == "ComNode")
		{
			int index = int.Parse(configParams[1]);
			MotorcycleTechTreeComStyleItem comStyleItem = this.ComStyleItem;
			MotorcycleTechTreeComNodeItem motorcycleTechTreeComNodeItem = (comStyleItem != null) ? comStyleItem.GetGuideNodeItem(index) : null;
			if (motorcycleTechTreeComNodeItem != null)
			{
				UUIItem rootItem = motorcycleTechTreeComNodeItem.GetRootItem();
				if (rootItem == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					rootItem,
					rootItem
				};
			}
		}
		if (a == "ComNode2")
		{
			int index2 = int.Parse(configParams[1]);
			MotorcycleTechTreeComStyleItem2 comStyleDoubleItem = this.ComStyleDoubleItem;
			MotorcycleTechTreeComNodeItem motorcycleTechTreeComNodeItem2 = (comStyleDoubleItem != null) ? comStyleDoubleItem.GetGuideNodeItem(index2) : null;
			if (motorcycleTechTreeComNodeItem2 != null)
			{
				UUIItem rootItem2 = motorcycleTechTreeComNodeItem2.GetRootItem();
				if (rootItem2 == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					rootItem2,
					rootItem2
				};
			}
		}
		if (!(a == "moto_skill_tab"))
		{
			return null;
		}
		int index3 = int.Parse(configParams[1]);
		TabComponent<MotorcycleTreeTypeTabItem> tabComponent = this.TabComponent;
		MotorcycleTreeTypeTabItem motorcycleTreeTypeTabItem = (tabComponent != null) ? tabComponent.GetTabItemByIndex(index3) : null;
		UUIItem uuiitem = (motorcycleTreeTypeTabItem != null) ? motorcycleTreeTypeTabItem.GetRootItem() : null;
		if (uuiitem == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			uuiitem,
			uuiitem
		};
	}

	// Token: 0x0400830F RID: 33551
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<MotorcycleTreeTypeTabItem> TabComponent;

	// Token: 0x04008310 RID: 33552
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MotorcycleTechTreeNodeListItem, IMotorTechNodeListData> NodeLayout;

	// Token: 0x04008311 RID: 33553
	[Nullable(2)]
	private MotorcycleTechTreeComStyleItem ComStyleItem;

	// Token: 0x04008312 RID: 33554
	[Nullable(2)]
	private MotorcycleTechTreeComStyleItem2 ComStyleDoubleItem;

	// Token: 0x04008313 RID: 33555
	[Nullable(2)]
	private MotorcycleTechTreeFirstNodeItem FirstNodeItem;

	// Token: 0x04008314 RID: 33556
	private List<MotorcycleTechTreeNodeItem> ExclusiveNodeItemList = new List<MotorcycleTechTreeNodeItem>();

	// Token: 0x04008315 RID: 33557
	[Nullable(2)]
	private MotorcycleTechTreeInfoPanel InfoPanel;

	// Token: 0x04008316 RID: 33558
	[Nullable(2)]
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x04008317 RID: 33559
	[Nullable(2)]
	private MotorTechTreeNode CurrentSelectNode;

	// Token: 0x04008318 RID: 33560
	private int SelectedTreeType;

	// Token: 0x04008319 RID: 33561
	private bool IsFirstInitTab = true;

	// Token: 0x0400831A RID: 33562
	private bool CanPlayChangeTween;

	// Token: 0x020087AE RID: 34734
	[NullableContext(0)]
	private class EMotorTechTreeComponent
	{
		// Token: 0x0402C17F RID: 180607
		public const int PnlSkillTip = 0;

		// Token: 0x0402C180 RID: 180608
		public const int SkillFirstItem = 1;

		// Token: 0x0402C181 RID: 180609
		public const int SkillSubLayout = 2;

		// Token: 0x0402C182 RID: 180610
		public const int PnlSkillSubListItem = 3;

		// Token: 0x0402C183 RID: 180611
		public const int NotActivatedTreeItem = 4;

		// Token: 0x0402C184 RID: 180612
		public const int BtnSwitch = 5;

		// Token: 0x0402C185 RID: 180613
		public const int ActivateTreeItem = 6;

		// Token: 0x0402C186 RID: 180614
		public const int TabLayout = 7;

		// Token: 0x0402C187 RID: 180615
		public const int TabItem = 8;

		// Token: 0x0402C188 RID: 180616
		public const int SkillCommonStyleItem = 9;

		// Token: 0x0402C189 RID: 180617
		public const int SkillCommonStyleDoubleItem = 10;
	}
}
