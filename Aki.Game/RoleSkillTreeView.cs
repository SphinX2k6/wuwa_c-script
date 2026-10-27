using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi.RoleSkill;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020028C8 RID: 10440
[NullableContext(1)]
[Nullable(0)]
public class RoleSkillTreeView : UiTabViewBase
{
	// Token: 0x060158E2 RID: 88290 RVA: 0x00571804 File Offset: 0x0056FA04
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

	// Token: 0x060158E3 RID: 88291 RVA: 0x0057184C File Offset: 0x0056FA4C
	protected override UniTask OnBeforeStartAsync()
	{
		RoleSkillTreeView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleSkillTreeView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060158E4 RID: 88292 RVA: 0x00571890 File Offset: 0x0056FA90
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

	// Token: 0x060158E5 RID: 88293 RVA: 0x005719B8 File Offset: 0x0056FBB8
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

	// Token: 0x060158E6 RID: 88294 RVA: 0x00571AE0 File Offset: 0x0056FCE0
	protected override void OnBeforeShow()
	{
		RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Skill, false, false, false);
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

	// Token: 0x060158E7 RID: 88295 RVA: 0x00571B34 File Offset: 0x0056FD34
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

	// Token: 0x060158E8 RID: 88296 RVA: 0x00571B88 File Offset: 0x0056FD88
	protected override void OnAfterShow()
	{
		RoleSkillTreeLogEvent logData = new RoleSkillTreeLogEvent();
		LogReportController.Instance.LogReport(logData);
	}

	// Token: 0x060158E9 RID: 88297 RVA: 0x00571BA8 File Offset: 0x0056FDA8
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

	// Token: 0x060158EA RID: 88298 RVA: 0x00571C11 File Offset: 0x0056FE11
	protected override void OnShowUiTabViewFromView()
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem == null)
		{
			return;
		}
		roleSkillTreeItem.PlayItemSequence("Start");
	}

	// Token: 0x060158EB RID: 88299 RVA: 0x00571C28 File Offset: 0x0056FE28
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

	// Token: 0x060158EC RID: 88300 RVA: 0x00571C52 File Offset: 0x0056FE52
	private void OnRoleInternalViewQuit()
	{
		this.RoleSkillTreeItem.PlayItemSequence("MoveLeft");
		this.RoleSkillTreeItem.CancelToggleSelect();
		this.SetSkillInputButtonVisible(true);
		this.TreeInfoViewId = -1;
	}

	// Token: 0x060158ED RID: 88301 RVA: 0x00571C7D File Offset: 0x0056FE7D
	private void OnSelectRoleTabOutside(EUiTabViewName eUiTabViewName, int i)
	{
		this.RoleSkillTreeItem.PlayItemSequence("MoveLeft");
		this.RoleSkillTreeItem.CancelToggleSelect();
		this.SetSkillInputButtonVisible(true);
	}

	// Token: 0x060158EE RID: 88302 RVA: 0x00571CA1 File Offset: 0x0056FEA1
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

	// Token: 0x060158EF RID: 88303 RVA: 0x00571CCC File Offset: 0x0056FECC
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

	// Token: 0x060158F0 RID: 88304 RVA: 0x00571D4E File Offset: 0x0056FF4E
	private void OnNodeToggleClick(RoleSkillTreeSkillItemBase skillItem)
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem != null)
		{
			roleSkillTreeItem.SelectSkillItem(skillItem, false);
		}
		this.ShowSkillTreeInfo();
	}

	// Token: 0x060158F1 RID: 88305 RVA: 0x00571D69 File Offset: 0x0056FF69
	private void OnAddCommonItemList(IReadOnlyList<IProto_NormalItem> _)
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem == null)
		{
			return;
		}
		roleSkillTreeItem.OnAddCommonItemList();
	}

	// Token: 0x060158F2 RID: 88306 RVA: 0x00571D7B File Offset: 0x0056FF7B
	private void UpdateRole(int roleId)
	{
		this.RoleId = roleId;
		this.Refresh();
	}

	// Token: 0x060158F3 RID: 88307 RVA: 0x00571D8A File Offset: 0x0056FF8A
	public void Refresh()
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem == null)
		{
			return;
		}
		roleSkillTreeItem.UpdateRole(this.RoleId);
	}

	// Token: 0x060158F4 RID: 88308 RVA: 0x00571DA4 File Offset: 0x0056FFA4
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

	// Token: 0x060158F5 RID: 88309 RVA: 0x00571E44 File Offset: 0x00570044
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

	// Token: 0x060158F6 RID: 88310 RVA: 0x00571E84 File Offset: 0x00570084
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

	// Token: 0x060158F7 RID: 88311 RVA: 0x00571EF4 File Offset: 0x005700F4
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

	// Token: 0x060158F8 RID: 88312 RVA: 0x00571F4D File Offset: 0x0057014D
	private void SetSkillInputButtonVisible(bool bVisible)
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem == null)
		{
			return;
		}
		roleSkillTreeItem.SetSkillInputButtonVisible(bVisible);
	}

	// Token: 0x060158F9 RID: 88313 RVA: 0x00571F60 File Offset: 0x00570160
	private void OnRoleSkillBranchChanged(int i)
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem == null)
		{
			return;
		}
		roleSkillTreeItem.OnRoleSkillBranchChanged();
	}

	// Token: 0x060158FA RID: 88314 RVA: 0x00571F72 File Offset: 0x00570172
	private void OnRoleSkillInputPanelVisible(bool visible)
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem == null)
		{
			return;
		}
		roleSkillTreeItem.SetSkillBranchVisible(ESkillBranchInvisibleReason.SkillInputPanel, !visible);
	}

	// Token: 0x060158FB RID: 88315 RVA: 0x00571F89 File Offset: 0x00570189
	private void OnSkillShowTagToggleChanged(bool isVisible)
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem == null)
		{
			return;
		}
		roleSkillTreeItem.RefreshAllShowTags();
	}

	// Token: 0x060158FC RID: 88316 RVA: 0x00571F9B File Offset: 0x0057019B
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

	// Token: 0x0400A086 RID: 41094
	[Nullable(2)]
	private RoleViewAgent RoleViewAgent;

	// Token: 0x0400A087 RID: 41095
	[Nullable(2)]
	private RoleSkillTreeItem RoleSkillTreeItem;

	// Token: 0x0400A088 RID: 41096
	private int RoleId;

	// Token: 0x0400A089 RID: 41097
	private readonly RoleSkillTreeInfoViewData TreeInfoViewData = new RoleSkillTreeInfoViewData();

	// Token: 0x0400A08A RID: 41098
	private int TreeInfoViewId = -1;

	// Token: 0x02008EDA RID: 36570
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402E540 RID: 189760
		RoleSkillTreeItem
	}
}
