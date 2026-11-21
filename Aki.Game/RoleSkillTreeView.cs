using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi.RoleSkill;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E43 RID: 7747
[NullableContext(1)]
[Nullable(0)]
public class RoleSkillTreeView : UiTabViewBase
{
	// Token: 0x060132E2 RID: 78562 RVA: 0x0059C6C8 File Offset: 0x0059A8C8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060132E3 RID: 78563 RVA: 0x0059C710 File Offset: 0x0059A910
	protected override UniTask OnBeforeStartAsync()
	{
		RoleSkillTreeView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleSkillTreeView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060132E4 RID: 78564 RVA: 0x0059C754 File Offset: 0x0059A954
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RoleSystemChangeRole, new Action<int>(this.OnRoleChange));
		EventSystem.Instance.Add<RoleSkillTreeSkillItemBase>(EEventName.OnSkillTreeNodeToggleClick, new Action<RoleSkillTreeSkillItemBase>(this.OnNodeToggleClick));
		EventSystem.Instance.Add(EEventName.OnRoleInternalViewQuit, new Action(this.OnRoleInternalViewQuit));
		EventSystem.Instance.Add<EUiTabViewName, int>(EEventName.SelectRoleTabOutside, new Action<EUiTabViewName, int>(this.OnSelectRoleTabOutside));
		EventSystem.Instance.Add<int>(EEventName.SkillTreeNodeActive, new Action<int>(this.OnAttributeNodeActive));
		EventSystem.Instance.Add<int>(EEventName.SkillTreeNodeLevelUp, new Action<int>(this.OnSkillNodeLevelUp));
		EventSystem.Instance.Add<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
		EventSystem.Instance.Add<int>(EEventName.OnRoleSkillBranchChanged, new Action<int>(this.OnRoleSkillBranchChanged));
		EventSystem.Instance.Add(EEventName.OnRoleSkillInputPanelVisible, new Action<bool>(this.OnRoleSkillInputPanelVisible));
		EventSystem.Instance.Add<bool>(EEventName.OnSkillShowTagToggleChanged, new Action<bool>(this.OnSkillShowTagToggleChanged));
	}

	// Token: 0x060132E5 RID: 78565 RVA: 0x0059C87C File Offset: 0x0059AA7C
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove<int>(EEventName.RoleSystemChangeRole, new Action<int>(this.OnRoleChange));
		EventSystem.Instance.Remove<RoleSkillTreeSkillItemBase>(EEventName.OnSkillTreeNodeToggleClick, new Action<RoleSkillTreeSkillItemBase>(this.OnNodeToggleClick));
		EventSystem.Instance.Remove(EEventName.OnRoleInternalViewQuit, new Action(this.OnRoleInternalViewQuit));
		EventSystem.Instance.Remove<EUiTabViewName, int>(EEventName.SelectRoleTabOutside, new Action<EUiTabViewName, int>(this.OnSelectRoleTabOutside));
		EventSystem.Instance.Remove<int>(EEventName.SkillTreeNodeActive, new Action<int>(this.OnAttributeNodeActive));
		EventSystem.Instance.Remove<int>(EEventName.SkillTreeNodeLevelUp, new Action<int>(this.OnSkillNodeLevelUp));
		EventSystem.Instance.Remove<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
		EventSystem.Instance.Remove<int>(EEventName.OnRoleSkillBranchChanged, new Action<int>(this.OnRoleSkillBranchChanged));
		EventSystem.Instance.Remove(EEventName.OnRoleSkillInputPanelVisible, new Action<bool>(this.OnRoleSkillInputPanelVisible));
		EventSystem.Instance.Remove<bool>(EEventName.OnSkillShowTagToggleChanged, new Action<bool>(this.OnSkillShowTagToggleChanged));
	}

	// Token: 0x060132E6 RID: 78566 RVA: 0x0059C9A4 File Offset: 0x0059ABA4
	protected override void OnBeforeShow()
	{
		int curSelectRoleId = this.RoleViewAgent.GetCurSelectRoleId();
		this.UpdateRole(curSelectRoleId);
		UiModelBase model = UiSceneManager.Instance.GetRoleSystemRoleActor().Model;
		UiModelLoadingIconComponent uiModelLoadingIconComponent = (model != null) ? model.CheckGetComponent<UiModelLoadingIconComponent>() : null;
		if (uiModelLoadingIconComponent == null)
		{
			return;
		}
		uiModelLoadingIconComponent.SetLoadingOpen(false);
	}

	// Token: 0x060132E7 RID: 78567 RVA: 0x0059C9EC File Offset: 0x0059ABEC
	protected override void OnBeforeHide()
	{
		if (UiSceneManager.Instance.HasRoleSystemRoleActor())
		{
			UiModelBase model = UiSceneManager.Instance.GetRoleSystemRoleActor().Model;
			UiModelLoadingIconComponent uiModelLoadingIconComponent = (model != null) ? model.CheckGetComponent<UiModelLoadingIconComponent>() : null;
			if (uiModelLoadingIconComponent != null)
			{
				uiModelLoadingIconComponent.SetLoadingOpen(true);
			}
		}
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem == null)
		{
			return;
		}
		roleSkillTreeItem.SetSkillBranchTipsVisible(false);
	}

	// Token: 0x060132E8 RID: 78568 RVA: 0x0059CA40 File Offset: 0x0059AC40
	protected override void OnAfterShow()
	{
		RoleSkillTreeLogEvent logData = new RoleSkillTreeLogEvent();
		LogReportController.Instance.LogReport(logData);
	}

	// Token: 0x060132E9 RID: 78569 RVA: 0x0059CA60 File Offset: 0x0059AC60
	protected override void OnShowUiTabViewFromToggle()
	{
		EUiTabViewName? preSelectTabName = this.RoleViewAgent.GetPreSelectTabName();
		if (((preSelectTabName != null) ? preSelectTabName.GetValueOrDefault() : null) == base.GetViewName())
		{
			RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
			if (roleSkillTreeItem == null)
			{
				return;
			}
			roleSkillTreeItem.PlayItemSequence("ChangeRole");
			return;
		}
		else
		{
			RoleSkillTreeItem roleSkillTreeItem2 = this.RoleSkillTreeItem;
			if (roleSkillTreeItem2 == null)
			{
				return;
			}
			roleSkillTreeItem2.PlayItemSequence("Sle");
			return;
		}
	}

	// Token: 0x060132EA RID: 78570 RVA: 0x0059CAC9 File Offset: 0x0059ACC9
	protected override void OnShowUiTabViewFromView()
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem == null)
		{
			return;
		}
		roleSkillTreeItem.PlayItemSequence("Start");
	}

	// Token: 0x060132EB RID: 78571 RVA: 0x0059CAE0 File Offset: 0x0059ACE0
	private void OnRoleChange(int roleId)
	{
		this.RoleSkillTreeItem.PlayItemSequence("ChangeRole");
		this.UpdateRole(roleId);
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem == null)
		{
			return;
		}
		roleSkillTreeItem.SetSkillBranchTipsVisible(false);
	}

	// Token: 0x060132EC RID: 78572 RVA: 0x0059CB0A File Offset: 0x0059AD0A
	private void OnRoleInternalViewQuit()
	{
		this.RoleSkillTreeItem.PlayItemSequence("MoveLeft");
		this.RoleSkillTreeItem.CancelToggleSelect();
		this.SetSkillInputButtonVisible(true);
		this.TreeInfoViewId = -1;
	}

	// Token: 0x060132ED RID: 78573 RVA: 0x0059CB35 File Offset: 0x0059AD35
	private void OnSelectRoleTabOutside(EUiTabViewName eUiTabViewName, int i)
	{
		this.RoleSkillTreeItem.PlayItemSequence("MoveLeft");
		this.RoleSkillTreeItem.CancelToggleSelect();
		this.SetSkillInputButtonVisible(true);
	}

	// Token: 0x060132EE RID: 78574 RVA: 0x0059CB59 File Offset: 0x0059AD59
	private void OnAttributeNodeActive(int nodeId)
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem != null)
		{
			roleSkillTreeItem.OnAttributeNodeActive(nodeId);
		}
		if (this.RoleViewAgent.RoleViewState == ERoleViewState.Internal)
		{
			this.UpdateSkillTreeInfoView();
		}
	}

	// Token: 0x060132EF RID: 78575 RVA: 0x0059CB84 File Offset: 0x0059AD84
	private void OnSkillNodeLevelUp(int nodeId)
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem != null)
		{
			roleSkillTreeItem.OnSkillNodeLevelUp(nodeId);
		}
		if (this.RoleViewAgent.RoleViewState == ERoleViewState.Internal)
		{
			int skillId = RoleSkillConfig.Instance.GetSkillTreeNode(nodeId).Value.SkillId;
			int upgradeSkillIdIfUpgraded = RoleModel.Instance.GetUpgradeSkillIdIfUpgraded(skillId, this.RoleId);
			int skillId2 = (upgradeSkillIdIfUpgraded > 0) ? upgradeSkillIdIfUpgraded : skillId;
			RoleController.Instance.SendRoleSkillViewRequest(this.RoleId, skillId2, new Action(this.UpdateSkillTreeInfoView));
		}
	}

	// Token: 0x060132F0 RID: 78576 RVA: 0x0059CC06 File Offset: 0x0059AE06
	private void OnNodeToggleClick(RoleSkillTreeSkillItemBase skillItem)
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem != null)
		{
			roleSkillTreeItem.SelectSkillItem(skillItem, false);
		}
		this.ShowSkillTreeInfo();
	}

	// Token: 0x060132F1 RID: 78577 RVA: 0x0059CC21 File Offset: 0x0059AE21
	private void OnAddCommonItemList(IReadOnlyList<IProto_NormalItem> _)
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem == null)
		{
			return;
		}
		roleSkillTreeItem.OnAddCommonItemList();
	}

	// Token: 0x060132F2 RID: 78578 RVA: 0x0059CC33 File Offset: 0x0059AE33
	private void UpdateRole(int roleId)
	{
		this.RoleId = roleId;
		this.Refresh();
	}

	// Token: 0x060132F3 RID: 78579 RVA: 0x0059CC42 File Offset: 0x0059AE42
	public void Refresh()
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem == null)
		{
			return;
		}
		roleSkillTreeItem.UpdateRole(this.RoleId);
	}

	// Token: 0x060132F4 RID: 78580 RVA: 0x0059CC5C File Offset: 0x0059AE5C
	private void ShowSkillTreeInfo()
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		RoleSkillTreeSkillItemBase roleSkillTreeSkillItemBase = (roleSkillTreeItem != null) ? roleSkillTreeItem.GetCurrentSelectedSkillItem() : null;
		if (roleSkillTreeSkillItemBase == null)
		{
			return;
		}
		int roleId = roleSkillTreeSkillItemBase.GetRoleId();
		int roleViewState = (int)this.RoleViewAgent.RoleViewState;
		ESkillTreeNodeType? type = roleSkillTreeSkillItemBase.GetType();
		Action action;
		if (roleViewState == 1)
		{
			action = new Action(this.UpdateSkillTreeInfoView);
		}
		else
		{
			action = new Action(this.OpenSkillTreeInfoView);
		}
		if (type.GetValueOrDefault() == ESkillTreeNodeType.OuterAttribute || type.GetValueOrDefault() == ESkillTreeNodeType.OuterPassiveSkill)
		{
			action();
			return;
		}
		int upgradeSkillId = roleSkillTreeSkillItemBase.GetUpgradeSkillId();
		int skillId = (upgradeSkillId > 0) ? upgradeSkillId : roleSkillTreeSkillItemBase.GetSkillId();
		RoleController.Instance.SendRoleSkillViewRequest(roleId, skillId, action);
	}

	// Token: 0x060132F5 RID: 78581 RVA: 0x0059CCFC File Offset: 0x0059AEFC
	private void UpdateSkillTreeInfoView()
	{
		this.UpdateSkillTreeInfoViewData();
		if (this.RoleViewAgent.RoleViewState == ERoleViewState.External)
		{
			return;
		}
		if (this.TreeInfoViewId != -1)
		{
			RoleSkillTreeInfoView roleSkillTreeInfoView = UiManager.Instance.GetView(this.TreeInfoViewId) as RoleSkillTreeInfoView;
			if (roleSkillTreeInfoView == null)
			{
				return;
			}
			roleSkillTreeInfoView.Refresh();
		}
	}

	// Token: 0x060132F6 RID: 78582 RVA: 0x0059CD3C File Offset: 0x0059AF3C
	private void OpenSkillTreeInfoView()
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (((roleSkillTreeItem != null) ? roleSkillTreeItem.GetCurrentSelectedSkillItem() : null) == null)
		{
			return;
		}
		this.UpdateSkillTreeInfoViewData();
		UiManager.Instance.OpenView(EUiViewName.RoleSkillTreeInfoView, this.TreeInfoViewData, delegate(bool success, int viewId)
		{
			this.TreeInfoViewId = viewId;
		});
		this.SetSkillInputButtonVisible(false);
		this.RoleSkillTreeItem.PlayItemSequence("MoveRight");
		EventSystem.Instance.Emit(EEventName.OnRoleInternalViewEnter);
	}

	// Token: 0x060132F7 RID: 78583 RVA: 0x0059CDAC File Offset: 0x0059AFAC
	private void UpdateSkillTreeInfoViewData()
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		RoleSkillTreeSkillItemBase roleSkillTreeSkillItemBase = (roleSkillTreeItem != null) ? roleSkillTreeItem.GetCurrentSelectedSkillItem() : null;
		if (roleSkillTreeSkillItemBase == null)
		{
			return;
		}
		int skillNodeId = roleSkillTreeSkillItemBase.GetSkillNodeId();
		this.TreeInfoViewData.RoleId = this.RoleId;
		this.TreeInfoViewData.SkillNodeId = skillNodeId;
		this.TreeInfoViewData.RoleViewAgent = this.RoleViewAgent;
	}

	// Token: 0x060132F8 RID: 78584 RVA: 0x0059CE05 File Offset: 0x0059B005
	private void SetSkillInputButtonVisible(bool bVisible)
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem == null)
		{
			return;
		}
		roleSkillTreeItem.SetSkillInputButtonVisible(bVisible);
	}

	// Token: 0x060132F9 RID: 78585 RVA: 0x0059CE18 File Offset: 0x0059B018
	private void OnRoleSkillBranchChanged(int i)
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem == null)
		{
			return;
		}
		roleSkillTreeItem.OnRoleSkillBranchChanged();
	}

	// Token: 0x060132FA RID: 78586 RVA: 0x0059CE2A File Offset: 0x0059B02A
	private void OnRoleSkillInputPanelVisible(bool visible)
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem == null)
		{
			return;
		}
		roleSkillTreeItem.SetSkillBranchVisible(ESkillBranchInvisibleReason.SkillInputPanel, !visible);
	}

	// Token: 0x060132FB RID: 78587 RVA: 0x0059CE41 File Offset: 0x0059B041
	private void OnSkillShowTagToggleChanged(bool isVisible)
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem == null)
		{
			return;
		}
		roleSkillTreeItem.RefreshAllShowTags();
	}

	// Token: 0x060132FC RID: 78588 RVA: 0x0059CE53 File Offset: 0x0059B053
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (!(configParams[0] == "FirstDoubleTag"))
		{
			return null;
		}
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem == null)
		{
			return null;
		}
		return roleSkillTreeItem.GetGuideUiItemAndUiItemForShowEx(configParams);
	}

	// Token: 0x0400A46F RID: 42095
	[Nullable(2)]
	private RoleViewAgent RoleViewAgent;

	// Token: 0x0400A470 RID: 42096
	[Nullable(2)]
	private RoleSkillTreeItem RoleSkillTreeItem;

	// Token: 0x0400A471 RID: 42097
	private int RoleId;

	// Token: 0x0400A472 RID: 42098
	private readonly RoleSkillTreeInfoViewData TreeInfoViewData = new RoleSkillTreeInfoViewData();

	// Token: 0x0400A473 RID: 42099
	private int TreeInfoViewId = -1;

	// Token: 0x02008122 RID: 33058
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029C3B RID: 171067
		RoleSkillTreeItem
	}
}
