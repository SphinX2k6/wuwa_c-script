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

// Token: 0x02001E37 RID: 7735
[NullableContext(1)]
[Nullable(0)]
public class RoleSkillMergeView : UiViewBase
{
	// Token: 0x0601320A RID: 78346 RVA: 0x005973DF File Offset: 0x005955DF
	public RoleSkillMergeView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601320B RID: 78347 RVA: 0x00597408 File Offset: 0x00595608
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x0601320C RID: 78348 RVA: 0x00597464 File Offset: 0x00595664
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

	// Token: 0x0601320D RID: 78349 RVA: 0x00597554 File Offset: 0x00595754
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

	// Token: 0x0601320E RID: 78350 RVA: 0x00597644 File Offset: 0x00595844
	protected override UniTask OnBeforeStartAsync()
	{
		RoleSkillMergeView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleSkillMergeView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601320F RID: 78351 RVA: 0x00597688 File Offset: 0x00595888
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

	// Token: 0x06013210 RID: 78352 RVA: 0x005976E4 File Offset: 0x005958E4
	private UniTask InitializeItems()
	{
		RoleSkillMergeView.<InitializeItems>d__12 <InitializeItems>d__;
		<InitializeItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeItems>d__.<>4__this = this;
		<InitializeItems>d__.<>1__state = -1;
		<InitializeItems>d__.<>t__builder.Start<RoleSkillMergeView.<InitializeItems>d__12>(ref <InitializeItems>d__);
		return <InitializeItems>d__.<>t__builder.Task;
	}

	// Token: 0x06013211 RID: 78353 RVA: 0x00597728 File Offset: 0x00595928
	protected override UniTask OnPlayingStartSequenceAsync()
	{
		RoleSkillMergeView.<OnPlayingStartSequenceAsync>d__13 <OnPlayingStartSequenceAsync>d__;
		<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingStartSequenceAsync>d__.<>4__this = this;
		<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
		<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<RoleSkillMergeView.<OnPlayingStartSequenceAsync>d__13>(ref <OnPlayingStartSequenceAsync>d__);
		return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013212 RID: 78354 RVA: 0x0059776C File Offset: 0x0059596C
	protected override UniTask OnPlayingCloseSequenceAsync()
	{
		RoleSkillMergeView.<OnPlayingCloseSequenceAsync>d__14 <OnPlayingCloseSequenceAsync>d__;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
		<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<RoleSkillMergeView.<OnPlayingCloseSequenceAsync>d__14>(ref <OnPlayingCloseSequenceAsync>d__);
		return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013213 RID: 78355 RVA: 0x005977AF File Offset: 0x005959AF
	private void OnBackButtonClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06013214 RID: 78356 RVA: 0x005977B8 File Offset: 0x005959B8
	private void Init()
	{
		IRoleDevSkillMergeViewParams roleDevSkillMergeViewParams = this.OpenParam as IRoleDevSkillMergeViewParams;
		this.RoleSkillTreeItemData.RoleId = roleDevSkillMergeViewParams.RoleId;
		this.RoleSkillTreeInfoItemData.RoleId = roleDevSkillMergeViewParams.RoleId;
		this.WaitToSelectNodeIndex = roleDevSkillMergeViewParams.SkillNodeIndex;
	}

	// Token: 0x06013215 RID: 78357 RVA: 0x00597800 File Offset: 0x00595A00
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

	// Token: 0x06013216 RID: 78358 RVA: 0x00597831 File Offset: 0x00595A31
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

	// Token: 0x06013217 RID: 78359 RVA: 0x00597867 File Offset: 0x00595A67
	private void OnNodeToggleClick(RoleSkillTreeSkillItemBase skillItem)
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem != null)
		{
			roleSkillTreeItem.SelectSkillItem(skillItem, false);
		}
		this.UpdateSkillTreeInfo();
	}

	// Token: 0x06013218 RID: 78360 RVA: 0x00597884 File Offset: 0x00595A84
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

	// Token: 0x06013219 RID: 78361 RVA: 0x00597900 File Offset: 0x00595B00
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

	// Token: 0x0601321A RID: 78362 RVA: 0x0059795E File Offset: 0x00595B5E
	private void OnSkillNodeLevelUp(int nodeId)
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem != null)
		{
			roleSkillTreeItem.OnSkillNodeLevelUp(nodeId);
		}
		this.UpdateSkillTreeInfo();
	}

	// Token: 0x0601321B RID: 78363 RVA: 0x00597978 File Offset: 0x00595B78
	private void OnAddCommonItemList(IReadOnlyList<IProto_NormalItem> _)
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem == null)
		{
			return;
		}
		roleSkillTreeItem.OnAddCommonItemList();
	}

	// Token: 0x0601321C RID: 78364 RVA: 0x0059798A File Offset: 0x00595B8A
	private void OnCommonItemCountAnyChange(int i, int i1)
	{
		RoleSkillTreeInfoItem roleSkillTreeInfoItem = this.RoleSkillTreeInfoItem;
		if (roleSkillTreeInfoItem == null)
		{
			return;
		}
		roleSkillTreeInfoItem.OnCommonItemCountAnyChange();
	}

	// Token: 0x0601321D RID: 78365 RVA: 0x0059799C File Offset: 0x00595B9C
	private void OnRoleSkillBranchChanged(int i)
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem != null)
		{
			roleSkillTreeItem.OnRoleSkillBranchChanged();
		}
		this.UpdateSkillTreeInfo();
	}

	// Token: 0x0601321E RID: 78366 RVA: 0x005979B5 File Offset: 0x00595BB5
	private void OnRoleSkillInputPanelVisible(bool visible)
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem == null)
		{
			return;
		}
		roleSkillTreeItem.SetSkillBranchVisible(ESkillBranchInvisibleReason.SkillInputPanel, !visible);
	}

	// Token: 0x0601321F RID: 78367 RVA: 0x005979CC File Offset: 0x00595BCC
	private void OnSkillShowTagToggleChanged(bool isVisible)
	{
		RoleSkillTreeItem roleSkillTreeItem = this.RoleSkillTreeItem;
		if (roleSkillTreeItem == null)
		{
			return;
		}
		roleSkillTreeItem.RefreshAllShowTags();
	}

	// Token: 0x0400A42D RID: 42029
	[Nullable(2)]
	private RoleSkillTreeItem RoleSkillTreeItem;

	// Token: 0x0400A42E RID: 42030
	[Nullable(2)]
	private RoleSkillTreeInfoItem RoleSkillTreeInfoItem;

	// Token: 0x0400A42F RID: 42031
	private readonly RoleSkillTreeItemData RoleSkillTreeItemData = new RoleSkillTreeItemData();

	// Token: 0x0400A430 RID: 42032
	private readonly IRoleSkillTreeInfoItemData RoleSkillTreeInfoItemData = new RoleSkillTreeInfoItemData();

	// Token: 0x0400A431 RID: 42033
	private int WaitToSelectNodeIndex = -1;

	// Token: 0x02008106 RID: 33030
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029B9B RID: 170907
		RoleSkillTreeItem,
		// Token: 0x04029B9C RID: 170908
		RoleSkillTreeInfoItem,
		// Token: 0x04029B9D RID: 170909
		CaptionItem
	}
}
