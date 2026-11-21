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

// Token: 0x02001758 RID: 5976
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleTechTreeTabView : UiTabViewBase
{
	// Token: 0x1700162B RID: 5675
	// (get) Token: 0x0600E827 RID: 59431 RVA: 0x0043FCFD File Offset: 0x0043DEFD
	private bool IsLockByTime
	{
		get
		{
			return MotorcycleDevelopModel.Instance.IsSwitchTechTreeTimeLocked();
		}
	}

	// Token: 0x1700162C RID: 5676
	// (get) Token: 0x0600E828 RID: 59432 RVA: 0x0043FD09 File Offset: 0x0043DF09
	private bool IsLockByPlayerStatus
	{
		get
		{
			return MotorcycleDevelopModel.Instance.IsSwitchTechTreePlayerLocked();
		}
	}

	// Token: 0x0600E829 RID: 59433 RVA: 0x0043FD18 File Offset: 0x0043DF18
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

	// Token: 0x0600E82A RID: 59434 RVA: 0x0043FE48 File Offset: 0x0043E048
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleTechTreeTabView.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleTechTreeTabView.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E82B RID: 59435 RVA: 0x0043FE8B File Offset: 0x0043E08B
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

	// Token: 0x0600E82C RID: 59436 RVA: 0x0043FEC7 File Offset: 0x0043E0C7
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MotorDevelopTechTreeUpdate, new Action<bool>(this.OnTechTreeNodeUpdate));
	}

	// Token: 0x0600E82D RID: 59437 RVA: 0x0043FEE5 File Offset: 0x0043E0E5
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MotorDevelopTechTreeUpdate, new Action<bool>(this.OnTechTreeNodeUpdate));
	}

	// Token: 0x0600E82E RID: 59438 RVA: 0x0043FF03 File Offset: 0x0043E103
	protected override void OnBeforeHide()
	{
		this.CanPlayChangeTween = false;
	}

	// Token: 0x0600E82F RID: 59439 RVA: 0x0043FF0C File Offset: 0x0043E10C
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

	// Token: 0x0600E830 RID: 59440 RVA: 0x0043FF30 File Offset: 0x0043E130
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

	// Token: 0x0600E831 RID: 59441 RVA: 0x0043FF7C File Offset: 0x0043E17C
	private UniTask OnTabItemUpdateAsync()
	{
		MotorcycleTechTreeTabView.<OnTabItemUpdateAsync>d__25 <OnTabItemUpdateAsync>d__;
		<OnTabItemUpdateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnTabItemUpdateAsync>d__.<>4__this = this;
		<OnTabItemUpdateAsync>d__.<>1__state = -1;
		<OnTabItemUpdateAsync>d__.<>t__builder.Start<MotorcycleTechTreeTabView.<OnTabItemUpdateAsync>d__25>(ref <OnTabItemUpdateAsync>d__);
		return <OnTabItemUpdateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E832 RID: 59442 RVA: 0x0043FFC0 File Offset: 0x0043E1C0
	private UniTask OnTabUpdateAsync()
	{
		MotorcycleTechTreeTabView.<OnTabUpdateAsync>d__26 <OnTabUpdateAsync>d__;
		<OnTabUpdateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnTabUpdateAsync>d__.<>4__this = this;
		<OnTabUpdateAsync>d__.<>1__state = -1;
		<OnTabUpdateAsync>d__.<>t__builder.Start<MotorcycleTechTreeTabView.<OnTabUpdateAsync>d__26>(ref <OnTabUpdateAsync>d__);
		return <OnTabUpdateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E833 RID: 59443 RVA: 0x00440003 File Offset: 0x0043E203
	private MotorcycleTechTreeNodeListItem InitListItem()
	{
		return new MotorcycleTechTreeNodeListItem
		{
			OnAfterRefreshOneNode = new Action<MotorcycleTechTreeNodeItem>(this.OnAfterRefreshOneNode)
		};
	}

	// Token: 0x0600E834 RID: 59444 RVA: 0x0044001C File Offset: 0x0043E21C
	private MotorcycleTreeTypeTabItem InitTreeTabItem([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new MotorcycleTreeTypeTabItem();
	}

	// Token: 0x0600E835 RID: 59445 RVA: 0x00440023 File Offset: 0x0043E223
	private void OnAfterRefreshOneNode(MotorcycleTechTreeNodeItem nodeItem)
	{
		if (nodeItem == null)
		{
			return;
		}
		nodeItem.OnClickToggleBack = new Action<MotorTechTreeNode, UUIExtendToggle>(this.OnClickNode);
		this.ExclusiveNodeItemList.Add(nodeItem);
	}

	// Token: 0x0600E836 RID: 59446 RVA: 0x00440048 File Offset: 0x0043E248
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

	// Token: 0x0600E837 RID: 59447 RVA: 0x004400C4 File Offset: 0x0043E2C4
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

	// Token: 0x0600E838 RID: 59448 RVA: 0x00440118 File Offset: 0x0043E318
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

	// Token: 0x0600E839 RID: 59449 RVA: 0x00440164 File Offset: 0x0043E364
	private void RefreshActivateTreeTypeBtn()
	{
		bool flag = MotorcycleDevelopModel.Instance.GetCurTreeType() == this.SelectedTreeType;
		base.GetItem(4).SetUIActive(!flag);
		base.GetItem(6).SetUIActive(flag);
	}

	// Token: 0x0600E83A RID: 59450 RVA: 0x004401A4 File Offset: 0x0043E3A4
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

	// Token: 0x0600E83B RID: 59451 RVA: 0x00440238 File Offset: 0x0043E438
	private UniTask RefreshCommonNodeList()
	{
		MotorcycleTechTreeTabView.<RefreshCommonNodeList>d__35 <RefreshCommonNodeList>d__;
		<RefreshCommonNodeList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshCommonNodeList>d__.<>4__this = this;
		<RefreshCommonNodeList>d__.<>1__state = -1;
		<RefreshCommonNodeList>d__.<>t__builder.Start<MotorcycleTechTreeTabView.<RefreshCommonNodeList>d__35>(ref <RefreshCommonNodeList>d__);
		return <RefreshCommonNodeList>d__.<>t__builder.Task;
	}

	// Token: 0x0600E83C RID: 59452 RVA: 0x0044027C File Offset: 0x0043E47C
	private UniTask RefreshAllNodes()
	{
		MotorcycleTechTreeTabView.<RefreshAllNodes>d__36 <RefreshAllNodes>d__;
		<RefreshAllNodes>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAllNodes>d__.<>4__this = this;
		<RefreshAllNodes>d__.<>1__state = -1;
		<RefreshAllNodes>d__.<>t__builder.Start<MotorcycleTechTreeTabView.<RefreshAllNodes>d__36>(ref <RefreshAllNodes>d__);
		return <RefreshAllNodes>d__.<>t__builder.Task;
	}

	// Token: 0x0600E83D RID: 59453 RVA: 0x004402C0 File Offset: 0x0043E4C0
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

	// Token: 0x0600E83E RID: 59454 RVA: 0x00440324 File Offset: 0x0043E524
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

	// Token: 0x0400844D RID: 33869
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<MotorcycleTreeTypeTabItem> TabComponent;

	// Token: 0x0400844E RID: 33870
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MotorcycleTechTreeNodeListItem, IMotorTechNodeListData> NodeLayout;

	// Token: 0x0400844F RID: 33871
	[Nullable(2)]
	private MotorcycleTechTreeComStyleItem ComStyleItem;

	// Token: 0x04008450 RID: 33872
	[Nullable(2)]
	private MotorcycleTechTreeComStyleItem2 ComStyleDoubleItem;

	// Token: 0x04008451 RID: 33873
	[Nullable(2)]
	private MotorcycleTechTreeFirstNodeItem FirstNodeItem;

	// Token: 0x04008452 RID: 33874
	private List<MotorcycleTechTreeNodeItem> ExclusiveNodeItemList = new List<MotorcycleTechTreeNodeItem>();

	// Token: 0x04008453 RID: 33875
	[Nullable(2)]
	private MotorcycleTechTreeInfoPanel InfoPanel;

	// Token: 0x04008454 RID: 33876
	[Nullable(2)]
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x04008455 RID: 33877
	[Nullable(2)]
	private MotorTechTreeNode CurrentSelectNode;

	// Token: 0x04008456 RID: 33878
	private int SelectedTreeType;

	// Token: 0x04008457 RID: 33879
	private bool IsFirstInitTab = true;

	// Token: 0x04008458 RID: 33880
	private bool CanPlayChangeTween;

	// Token: 0x02007937 RID: 31031
	[NullableContext(0)]
	private class EMotorTechTreeComponent
	{
		// Token: 0x04027497 RID: 160919
		public const int PnlSkillTip = 0;

		// Token: 0x04027498 RID: 160920
		public const int SkillFirstItem = 1;

		// Token: 0x04027499 RID: 160921
		public const int SkillSubLayout = 2;

		// Token: 0x0402749A RID: 160922
		public const int PnlSkillSubListItem = 3;

		// Token: 0x0402749B RID: 160923
		public const int NotActivatedTreeItem = 4;

		// Token: 0x0402749C RID: 160924
		public const int BtnSwitch = 5;

		// Token: 0x0402749D RID: 160925
		public const int ActivateTreeItem = 6;

		// Token: 0x0402749E RID: 160926
		public const int TabLayout = 7;

		// Token: 0x0402749F RID: 160927
		public const int TabItem = 8;

		// Token: 0x040274A0 RID: 160928
		public const int SkillCommonStyleItem = 9;

		// Token: 0x040274A1 RID: 160929
		public const int SkillCommonStyleDoubleItem = 10;
	}
}
