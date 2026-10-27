using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleDev;
using CSharpScript.Game.Module.RoleUi.RoleSkill;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020028BC RID: 10428
[NullableContext(1)]
[Nullable(0)]
public class RoleSkillMergeView : UiViewBase
{
	// Token: 0x0601580A RID: 88074 RVA: 0x0056C597 File Offset: 0x0056A797
	public RoleSkillMergeView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601580B RID: 88075 RVA: 0x0056C5C0 File Offset: 0x0056A7C0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x0601580C RID: 88076 RVA: 0x0056C61C File Offset: 0x0056A81C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<RoleSkillTreeSkillItemBase>(EEventName.OnSkillTreeNodeToggleClick, new Action<RoleSkillTreeSkillItemBase>(this.OnNodeToggleClick));
		EventSystem.Instance.Add<int>(EEventName.SkillTreeNodeActive, new Action<int>(this.OnSkillNodeLevelUp));
		EventSystem.Instance.Add<int>(EEventName.SkillTreeNodeLevelUp, new Action<int>(this.OnSkillNodeLevelUp));
		EventSystem.Instance.Add<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		EventSystem.Instance.Add<int>(EEventName.OnRoleSkillBranchChanged, new Action<int>(this.OnRoleSkillBranchChanged));
		EventSystem.Instance.Add(EEventName.OnRoleSkillInputPanelVisible, new Action<bool>(this.OnRoleSkillInputPanelVisible));
		EventSystem.Instance.Add<bool>(EEventName.OnSkillShowTagToggleChanged, new Action<bool>(this.OnSkillShowTagToggleChanged));
	}

	// Token: 0x0601580D RID: 88077 RVA: 0x0056C70C File Offset: 0x0056A90C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<RoleSkillTreeSkillItemBase>(EEventName.OnSkillTreeNodeToggleClick, new Action<RoleSkillTreeSkillItemBase>(this.OnNodeToggleClick));
		EventSystem.Instance.Remove<int>(EEventName.SkillTreeNodeActive, new Action<int>(this.OnSkillNodeLevelUp));
		EventSystem.Instance.Remove<int>(EEventName.SkillTreeNodeLevelUp, new Action<int>(this.OnSkillNodeLevelUp));
		EventSystem.Instance.Remove<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
		EventSystem.Instance.Remove<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		EventSystem.Instance.Remove<int>(EEventName.OnRoleSkillBranchChanged, new Action<int>(this.OnRoleSkillBranchChanged));
		EventSystem.Instance.Remove(EEventName.OnRoleSkillInputPanelVisible, new Action<bool>(this.OnRoleSkillInputPanelVisible));
		EventSystem.Instance.Remove<bool>(EEventName.OnSkillShowTagToggleChanged, new Action<bool>(this.OnSkillShowTagToggleChanged));
	}

	// Token: 0x0601580E RID: 88078 RVA: 0x0056C7FC File Offset: 0x0056A9FC
	protected override UniTask OnBeforeStartAsync()
	{
		RoleSkillMergeView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleSkillMergeView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601580F RID: 88079 RVA: 0x0056C840 File Offset: 0x0056AA40
	protected override void OnBeforeShow()
	{
		this.Refresh();
		if (this.WaitToSelectNodeIndex >= 0)
		{
			this.SelectNodeByNodeIndex(this.WaitToSelectNodeIndex);
			this.WaitToSelectNodeIndex = -1;
		}
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem != null)
		{
			roleSkillTreeItem.PlayItemSequence("MoveRight");
		}
		RoleSkillTreeInfoItem roleSkillTreeInfoItem = this.RoleSkillTreeInfoItem;
		if (roleSkillTreeInfoItem == null)
		{
			return;
		}
		roleSkillTreeInfoItem.PlayItemSequence("Start");
	}

	// Token: 0x06015810 RID: 88080 RVA: 0x0056C89C File Offset: 0x0056AA9C
	private UniTask InitializeItems()
	{
		RoleSkillMergeView.<InitializeItems>d__12 <InitializeItems>d__;
		<InitializeItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeItems>d__.<>4__this = this;
		<InitializeItems>d__.<>1__state = -1;
		<InitializeItems>d__.<>t__builder.Start<RoleSkillMergeView.<InitializeItems>d__12>(ref <InitializeItems>d__);
		return <InitializeItems>d__.<>t__builder.Task;
	}

	// Token: 0x06015811 RID: 88081 RVA: 0x0056C8E0 File Offset: 0x0056AAE0
	protected override UniTask OnPlayingStartSequenceAsync()
	{
		RoleSkillMergeView.<OnPlayingStartSequenceAsync>d__13 <OnPlayingStartSequenceAsync>d__;
		<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingStartSequenceAsync>d__.<>4__this = this;
		<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
		<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<RoleSkillMergeView.<OnPlayingStartSequenceAsync>d__13>(ref <OnPlayingStartSequenceAsync>d__);
		return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015812 RID: 88082 RVA: 0x0056C924 File Offset: 0x0056AB24
	protected override UniTask OnPlayingCloseSequenceAsync()
	{
		RoleSkillMergeView.<OnPlayingCloseSequenceAsync>d__14 <OnPlayingCloseSequenceAsync>d__;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
		<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<RoleSkillMergeView.<OnPlayingCloseSequenceAsync>d__14>(ref <OnPlayingCloseSequenceAsync>d__);
		return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015813 RID: 88083 RVA: 0x0056C967 File Offset: 0x0056AB67
	private void OnBackButtonClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06015814 RID: 88084 RVA: 0x0056C970 File Offset: 0x0056AB70
	private void Init()
	{
		IRoleDevSkillMergeViewParams roleDevSkillMergeViewParams = this.OpenParam as IRoleDevSkillMergeViewParams;
		this.RoleSkillTreeItemData.RoleId = roleDevSkillMergeViewParams.RoleId;
		this.RoleSkillTreeInfoItemData.RoleId = roleDevSkillMergeViewParams.RoleId;
		this.WaitToSelectNodeIndex = roleDevSkillMergeViewParams.SkillNodeIndex;
	}

	// Token: 0x06015815 RID: 88085 RVA: 0x0056C9B8 File Offset: 0x0056ABB8
	private void SelectNodeByNodeIndex(int nodeIndex)
	{
		RoleSkillTreeSkillItemBase skillItemByIndex = this.RoleSkillTreeItem.GetSkillItemByIndex(nodeIndex);
		if (skillItemByIndex == null)
		{
			return;
		}
		this.RoleSkillTreeItem.SelectSkillItem(skillItemByIndex, true);
		this.UpdateSkillTreeInfo();
	}

	// Token: 0x06015816 RID: 88086 RVA: 0x0056C9E9 File Offset: 0x0056ABE9
	private void Refresh()
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem != null)
		{
			roleSkillTreeItem.UpdateRole(this.RoleSkillTreeItemData.RoleId);
		}
		RoleSkillTreeItem roleSkillTreeItem2 = this.RoleSkillTreeItem;
		if (roleSkillTreeItem2 != null)
		{
			roleSkillTreeItem2.SetSkillInputButtonVisible(false);
		}
		this.UpdateSkillTreeInfo();
	}

	// Token: 0x06015817 RID: 88087 RVA: 0x0056CA1F File Offset: 0x0056AC1F
	private void OnNodeToggleClick(RoleSkillTreeSkillItemBase skillItem)
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem != null)
		{
			roleSkillTreeItem.SelectSkillItem(skillItem, false);
		}
		this.UpdateSkillTreeInfo();
	}

	// Token: 0x06015818 RID: 88088 RVA: 0x0056CA3C File Offset: 0x0056AC3C
	private void UpdateSkillTreeInfo()
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		RoleSkillTreeSkillItemBase roleSkillTreeSkillItemBase = (roleSkillTreeItem != null) ? roleSkillTreeItem.GetCurrentSelectedSkillItem() : null;
		if (roleSkillTreeSkillItemBase == null)
		{
			return;
		}
		ESkillTreeNodeType value = roleSkillTreeSkillItemBase.GetType().Value;
		if (value == ESkillTreeNodeType.OuterAttribute || value == ESkillTreeNodeType.OuterPassiveSkill)
		{
			this.UpdateTreeInfoItem();
			return;
		}
		int roleId = roleSkillTreeSkillItemBase.GetRoleId();
		int upgradeSkillId = roleSkillTreeSkillItemBase.GetUpgradeSkillId();
		int skillId = (upgradeSkillId > 0) ? upgradeSkillId : roleSkillTreeSkillItemBase.GetSkillId();
		RoleController.Instance.SendRoleSkillViewRequest(roleId, skillId, new Action(this.UpdateTreeInfoItem));
	}

	// Token: 0x06015819 RID: 88089 RVA: 0x0056CAB8 File Offset: 0x0056ACB8
	private void UpdateTreeInfoItem()
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		RoleSkillTreeSkillItemBase roleSkillTreeSkillItemBase = (roleSkillTreeItem != null) ? roleSkillTreeItem.GetCurrentSelectedSkillItem() : null;
		if (roleSkillTreeSkillItemBase == null)
		{
			return;
		}
		int skillNodeId = roleSkillTreeSkillItemBase.GetSkillNodeId();
		this.RoleSkillTreeInfoItemData.SkillNodeId = skillNodeId;
		this.RoleSkillTreeInfoItem.Update(this.RoleSkillTreeInfoItemData);
		this.RoleSkillTreeInfoItem.ShowLeftPanelByTabType(this.RoleSkillTreeInfoItem.GetCurSkillTabShowType());
	}

	// Token: 0x0601581A RID: 88090 RVA: 0x0056CB16 File Offset: 0x0056AD16
	private void OnSkillNodeLevelUp(int nodeId)
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem != null)
		{
			roleSkillTreeItem.OnSkillNodeLevelUp(nodeId);
		}
		this.UpdateSkillTreeInfo();
	}

	// Token: 0x0601581B RID: 88091 RVA: 0x0056CB30 File Offset: 0x0056AD30
	private void OnAddCommonItemList(IReadOnlyList<IProto_NormalItem> _)
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem == null)
		{
			return;
		}
		roleSkillTreeItem.OnAddCommonItemList();
	}

	// Token: 0x0601581C RID: 88092 RVA: 0x0056CB42 File Offset: 0x0056AD42
	private void OnCommonItemCountAnyChange(int i, int i1)
	{
		RoleSkillTreeInfoItem roleSkillTreeInfoItem = this.RoleSkillTreeInfoItem;
		if (roleSkillTreeInfoItem == null)
		{
			return;
		}
		roleSkillTreeInfoItem.OnCommonItemCountAnyChange();
	}

	// Token: 0x0601581D RID: 88093 RVA: 0x0056CB54 File Offset: 0x0056AD54
	private void OnRoleSkillBranchChanged(int i)
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem != null)
		{
			roleSkillTreeItem.OnRoleSkillBranchChanged();
		}
		this.UpdateSkillTreeInfo();
	}

	// Token: 0x0601581E RID: 88094 RVA: 0x0056CB6D File Offset: 0x0056AD6D
	private void OnRoleSkillInputPanelVisible(bool visible)
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem == null)
		{
			return;
		}
		roleSkillTreeItem.SetSkillBranchVisible(ESkillBranchInvisibleReason.SkillInputPanel, !visible);
	}

	// Token: 0x0601581F RID: 88095 RVA: 0x0056CB84 File Offset: 0x0056AD84
	private void OnSkillShowTagToggleChanged(bool isVisible)
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem == null)
		{
			return;
		}
		roleSkillTreeItem.RefreshAllShowTags();
	}

	// Token: 0x0400A044 RID: 41028
	[Nullable(2)]
	private RoleSkillTreeItem RoleSkillTreeItem;

	// Token: 0x0400A045 RID: 41029
	[Nullable(2)]
	private RoleSkillTreeInfoItem RoleSkillTreeInfoItem;

	// Token: 0x0400A046 RID: 41030
	private readonly RoleSkillTreeItemData RoleSkillTreeItemData = new RoleSkillTreeItemData();

	// Token: 0x0400A047 RID: 41031
	private readonly IRoleSkillTreeInfoItemData RoleSkillTreeInfoItemData = new RoleSkillTreeInfoItemData();

	// Token: 0x0400A048 RID: 41032
	private int WaitToSelectNodeIndex = -1;

	// Token: 0x02008EBF RID: 36543
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402E49E RID: 189598
		RoleSkillTreeItem,
		// Token: 0x0402E49F RID: 189599
		RoleSkillTreeInfoItem,
		// Token: 0x0402E4A0 RID: 189600
		CaptionItem
	}
}
