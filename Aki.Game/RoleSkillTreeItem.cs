using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi.RoleSkill;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E3F RID: 7743
[NullableContext(2)]
[Nullable(0)]
public class RoleSkillTreeItem : UiPanelBase
{
	// Token: 0x06013296 RID: 78486 RVA: 0x0059B694 File Offset: 0x00599894
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnSkillInputButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06013297 RID: 78487 RVA: 0x0059B824 File Offset: 0x00599A24
	protected override UniTask OnBeforeStartAsync()
	{
		RoleSkillTreeItem.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleSkillTreeItem.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013298 RID: 78488 RVA: 0x0059B868 File Offset: 0x00599A68
	private UniTask InitChildComponents()
	{
		RoleSkillTreeItem.<InitChildComponents>d__12 <InitChildComponents>d__;
		<InitChildComponents>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitChildComponents>d__.<>4__this = this;
		<InitChildComponents>d__.<>1__state = -1;
		<InitChildComponents>d__.<>t__builder.Start<RoleSkillTreeItem.<InitChildComponents>d__12>(ref <InitChildComponents>d__);
		return <InitChildComponents>d__.<>t__builder.Task;
	}

	// Token: 0x06013299 RID: 78489 RVA: 0x0059B8AC File Offset: 0x00599AAC
	public void Refresh()
	{
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(this.RoleId, true);
		this.RefreshRole(roleDataById.GetRoleSkillTreeConfig());
		this.RefreshSkillBranch();
	}

	// Token: 0x0601329A RID: 78490 RVA: 0x0059B8E0 File Offset: 0x00599AE0
	private UniTask InitInnerSkillAndOuterAttributeItemList()
	{
		RoleSkillTreeItem.<InitInnerSkillAndOuterAttributeItemList>d__14 <InitInnerSkillAndOuterAttributeItemList>d__;
		<InitInnerSkillAndOuterAttributeItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitInnerSkillAndOuterAttributeItemList>d__.<>4__this = this;
		<InitInnerSkillAndOuterAttributeItemList>d__.<>1__state = -1;
		<InitInnerSkillAndOuterAttributeItemList>d__.<>t__builder.Start<RoleSkillTreeItem.<InitInnerSkillAndOuterAttributeItemList>d__14>(ref <InitInnerSkillAndOuterAttributeItemList>d__);
		return <InitInnerSkillAndOuterAttributeItemList>d__.<>t__builder.Task;
	}

	// Token: 0x0601329B RID: 78491 RVA: 0x0059B924 File Offset: 0x00599B24
	private UniTask InitBranchItem()
	{
		RoleSkillTreeItem.<InitBranchItem>d__15 <InitBranchItem>d__;
		<InitBranchItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitBranchItem>d__.<>4__this = this;
		<InitBranchItem>d__.<>1__state = -1;
		<InitBranchItem>d__.<>t__builder.Start<RoleSkillTreeItem.<InitBranchItem>d__15>(ref <InitBranchItem>d__);
		return <InitBranchItem>d__.<>t__builder.Task;
	}

	// Token: 0x0601329C RID: 78492 RVA: 0x0059B968 File Offset: 0x00599B68
	private void OnSkillInputButtonClick()
	{
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(this.RoleId, true);
		UiManager.Instance.OpenView(EUiViewName.RoleSkillInputView, roleDataById, null);
	}

	// Token: 0x0601329D RID: 78493 RVA: 0x0059B998 File Offset: 0x00599B98
	public void UpdateRole(int roleId)
	{
		this.RoleId = roleId;
		this.Refresh();
	}

	// Token: 0x0601329E RID: 78494 RVA: 0x0059B9A7 File Offset: 0x00599BA7
	[NullableContext(1)]
	public void SelectSkillItem(RoleSkillTreeSkillItemBase skillItem, bool bFireEvent = false)
	{
		if (skillItem == this.CurSelectedSkillItem)
		{
			this.CurSelectedSkillItem.SetToggleState(EToggleState.ETT_Checked, false);
			return;
		}
		RoleSkillTreeSkillItemBase curSelectedSkillItem = this.CurSelectedSkillItem;
		if (curSelectedSkillItem != null)
		{
			curSelectedSkillItem.SetToggleState(EToggleState.ETT_UnChecked, false);
		}
		this.CurSelectedSkillItem = skillItem;
		this.CurSelectedSkillItem.SetToggleState(EToggleState.ETT_Checked, bFireEvent);
	}

	// Token: 0x0601329F RID: 78495 RVA: 0x0059B9E7 File Offset: 0x00599BE7
	public void CancelToggleSelect()
	{
		RoleSkillTreeSkillItemBase curSelectedSkillItem = this.CurSelectedSkillItem;
		if (curSelectedSkillItem != null)
		{
			curSelectedSkillItem.SetToggleState(EToggleState.ETT_UnChecked, false);
		}
		this.CurSelectedSkillItem = null;
	}

	// Token: 0x060132A0 RID: 78496 RVA: 0x0059BA03 File Offset: 0x00599C03
	public void OnSkillNodeLevelUp(int nodeId)
	{
		this.OnNodeLevelChange(nodeId);
	}

	// Token: 0x060132A1 RID: 78497 RVA: 0x0059BA0C File Offset: 0x00599C0C
	public void OnAddCommonItemList()
	{
		this.Refresh();
	}

	// Token: 0x060132A2 RID: 78498 RVA: 0x0059BA14 File Offset: 0x00599C14
	private void OnNodeLevelChange(int nodeId)
	{
		this.InnerPassiveSkillAndOuterPassiveSkillItem.OnNodeLevelChange(nodeId);
		RoleSkillInnerSkillAndOuterAttributeItem[] innerSkillAndOuterAttributeItemList = this.InnerSkillAndOuterAttributeItemList;
		for (int i = 0; i < innerSkillAndOuterAttributeItemList.Length; i++)
		{
			innerSkillAndOuterAttributeItemList[i].OnNodeLevelChange(nodeId);
		}
		this.OuterPassiveSkillItem.OnNodeLevelChange(nodeId);
		RoleSkillOuterPassiveSkillItem weakBreakSkillItem = this.WeakBreakSkillItem;
		if (weakBreakSkillItem == null)
		{
			return;
		}
		weakBreakSkillItem.OnNodeLevelChange(nodeId);
	}

	// Token: 0x060132A3 RID: 78499 RVA: 0x0059BA68 File Offset: 0x00599C68
	public void OnAttributeNodeActive(int nodeId)
	{
		this.OnNodeLevelChange(nodeId);
	}

	// Token: 0x060132A4 RID: 78500 RVA: 0x0059BA71 File Offset: 0x00599C71
	public void SetSkillInputButtonVisible(bool bVisible)
	{
		base.GetButton(6).GetRootComponent().SetUIActive(bVisible);
	}

	// Token: 0x060132A5 RID: 78501 RVA: 0x0059BA88 File Offset: 0x00599C88
	[NullableContext(1)]
	public void RefreshRole(IReadOnlyList<SkillTree> configList)
	{
		foreach (SkillTree skillTree in configList)
		{
			switch (skillTree.NodeType)
			{
			case 1:
				this.InnerPassiveSkillAndOuterPassiveSkillItem.Update(this.RoleId, skillTree.Id);
				break;
			case 2:
				if (skillTree.Coordinate <= this.InnerSkillAndOuterAttributeItemList.Length)
				{
					RoleSkillInnerSkillAndOuterAttributeItem roleSkillInnerSkillAndOuterAttributeItem = this.InnerSkillAndOuterAttributeItemList[skillTree.Coordinate - 1];
					if (roleSkillInnerSkillAndOuterAttributeItem != null)
					{
						roleSkillInnerSkillAndOuterAttributeItem.Update(this.RoleId, skillTree.Id);
					}
				}
				break;
			case 3:
				if (skillTree.NodeIndex == 8)
				{
					RoleSkillOuterPassiveSkillItem outerPassiveSkillItem = this.OuterPassiveSkillItem;
					if (outerPassiveSkillItem != null)
					{
						outerPassiveSkillItem.Update(this.RoleId, skillTree.Id);
					}
				}
				else if (skillTree.NodeIndex == 17)
				{
					RoleSkillOuterPassiveSkillItem weakBreakSkillItem = this.WeakBreakSkillItem;
					if (weakBreakSkillItem != null)
					{
						weakBreakSkillItem.Update(this.RoleId, skillTree.Id);
					}
				}
				break;
			}
		}
	}

	// Token: 0x060132A6 RID: 78502 RVA: 0x0059BBA0 File Offset: 0x00599DA0
	[NullableContext(1)]
	public void PlayItemSequence(string seq)
	{
		this.SequencePlayer.PlayOrReplaySequenceByName(seq, false, null);
	}

	// Token: 0x060132A7 RID: 78503 RVA: 0x0059BBC4 File Offset: 0x00599DC4
	[NullableContext(1)]
	public UniTask PlayItemSequenceAsync(string seq)
	{
		RoleSkillTreeItem.<PlayItemSequenceAsync>d__27 <PlayItemSequenceAsync>d__;
		<PlayItemSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayItemSequenceAsync>d__.<>4__this = this;
		<PlayItemSequenceAsync>d__.seq = seq;
		<PlayItemSequenceAsync>d__.<>1__state = -1;
		<PlayItemSequenceAsync>d__.<>t__builder.Start<RoleSkillTreeItem.<PlayItemSequenceAsync>d__27>(ref <PlayItemSequenceAsync>d__);
		return <PlayItemSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060132A8 RID: 78504 RVA: 0x0059BC10 File Offset: 0x00599E10
	public RoleSkillTreeSkillItemBase GetSkillItemByIndex(int index)
	{
		if (this.WeakBreakSkillItem != null)
		{
			SkillTree? skillTreeNodeConfig = this.WeakBreakSkillItem.GetSkillTreeNodeConfig();
			if (skillTreeNodeConfig != null && index == skillTreeNodeConfig.Value.NodeIndex)
			{
				return this.WeakBreakSkillItem;
			}
		}
		if (this.OuterPassiveSkillItem != null)
		{
			SkillTree? skillTreeNodeConfig2 = this.OuterPassiveSkillItem.GetSkillTreeNodeConfig();
			if (skillTreeNodeConfig2 != null && index == skillTreeNodeConfig2.Value.NodeIndex)
			{
				return this.OuterPassiveSkillItem;
			}
		}
		RoleSkillInnerSkillAndOuterAttributeItem[] innerSkillAndOuterAttributeItemList = this.InnerSkillAndOuterAttributeItemList;
		for (int i = 0; i < innerSkillAndOuterAttributeItemList.Length; i++)
		{
			foreach (RoleSkillTreeSkillItemBase roleSkillTreeSkillItemBase in innerSkillAndOuterAttributeItemList[i].GetSkillNodeItems())
			{
				if (roleSkillTreeSkillItemBase != null)
				{
					SkillTree? skillTreeNodeConfig3 = roleSkillTreeSkillItemBase.GetSkillTreeNodeConfig();
					if (skillTreeNodeConfig3 != null && index == skillTreeNodeConfig3.Value.NodeIndex)
					{
						return roleSkillTreeSkillItemBase;
					}
				}
			}
		}
		foreach (RoleSkillTreeSkillItemBase roleSkillTreeSkillItemBase2 in this.InnerPassiveSkillAndOuterPassiveSkillItem.GetSkillNodeItems())
		{
			if (roleSkillTreeSkillItemBase2 != null)
			{
				SkillTree? skillTreeNodeConfig4 = roleSkillTreeSkillItemBase2.GetSkillTreeNodeConfig();
				if (skillTreeNodeConfig4 != null && index == skillTreeNodeConfig4.Value.NodeIndex)
				{
					return roleSkillTreeSkillItemBase2;
				}
			}
		}
		return null;
	}

	// Token: 0x060132A9 RID: 78505 RVA: 0x0059BD88 File Offset: 0x00599F88
	public RoleSkillTreeSkillItemBase GetCurrentSelectedSkillItem()
	{
		return this.CurSelectedSkillItem;
	}

	// Token: 0x060132AA RID: 78506 RVA: 0x0059BD90 File Offset: 0x00599F90
	private void RefreshSkillBranch()
	{
		this.RoleSkillBranchItem.Refresh(this.RoleId, this.EnableSwitchBranch);
	}

	// Token: 0x060132AB RID: 78507 RVA: 0x0059BDAC File Offset: 0x00599FAC
	public void OnRoleSkillBranchChanged()
	{
		this.RefreshSkillBranch();
		RoleSkillInnerPassiveSkillAndOuterPassiveSkillItem innerPassiveSkillAndOuterPassiveSkillItem = this.InnerPassiveSkillAndOuterPassiveSkillItem;
		if (innerPassiveSkillAndOuterPassiveSkillItem != null)
		{
			innerPassiveSkillAndOuterPassiveSkillItem.OnSkillBranchChanged();
		}
		RoleSkillOuterPassiveSkillItem outerPassiveSkillItem = this.OuterPassiveSkillItem;
		if (outerPassiveSkillItem != null)
		{
			outerPassiveSkillItem.OnSkillBranchChanged();
		}
		RoleSkillOuterPassiveSkillItem weakBreakSkillItem = this.WeakBreakSkillItem;
		if (weakBreakSkillItem != null)
		{
			weakBreakSkillItem.OnSkillBranchChanged();
		}
		if (this.InnerSkillAndOuterAttributeItemList != null)
		{
			RoleSkillInnerSkillAndOuterAttributeItem[] innerSkillAndOuterAttributeItemList = this.InnerSkillAndOuterAttributeItemList;
			for (int i = 0; i < innerSkillAndOuterAttributeItemList.Length; i++)
			{
				innerSkillAndOuterAttributeItemList[i].OnSkillBranchChanged();
			}
		}
	}

	// Token: 0x060132AC RID: 78508 RVA: 0x0059BE17 File Offset: 0x0059A017
	public void SetEnableSwitchBranch(bool isEnable)
	{
		this.EnableSwitchBranch = isEnable;
	}

	// Token: 0x060132AD RID: 78509 RVA: 0x0059BE20 File Offset: 0x0059A020
	public void RefreshAllShowTags()
	{
		foreach (RoleSkillTreeSkillItemBase roleSkillTreeSkillItemBase in this.InnerPassiveSkillAndOuterPassiveSkillItem.GetSkillNodeItems())
		{
			if (roleSkillTreeSkillItemBase != null)
			{
				roleSkillTreeSkillItemBase.RefreshShowTag();
			}
		}
		RoleSkillInnerSkillAndOuterAttributeItem[] innerSkillAndOuterAttributeItemList = this.InnerSkillAndOuterAttributeItemList;
		for (int i = 0; i < innerSkillAndOuterAttributeItemList.Length; i++)
		{
			foreach (RoleSkillTreeSkillItemBase roleSkillTreeSkillItemBase2 in innerSkillAndOuterAttributeItemList[i].GetSkillNodeItems())
			{
				if (roleSkillTreeSkillItemBase2 != null)
				{
					roleSkillTreeSkillItemBase2.RefreshShowTag();
				}
			}
		}
		RoleSkillOuterPassiveSkillItem outerPassiveSkillItem = this.OuterPassiveSkillItem;
		if (outerPassiveSkillItem != null)
		{
			outerPassiveSkillItem.RefreshShowTag();
		}
		RoleSkillOuterPassiveSkillItem weakBreakSkillItem = this.WeakBreakSkillItem;
		if (weakBreakSkillItem == null)
		{
			return;
		}
		weakBreakSkillItem.RefreshShowTag();
	}

	// Token: 0x060132AE RID: 78510 RVA: 0x0059BEEC File Offset: 0x0059A0EC
	public void SetSkillBranchVisible(ESkillBranchInvisibleReason reason, bool visible)
	{
		RoleSkillBranchItem roleSkillBranchItem = this.RoleSkillBranchItem;
		if (roleSkillBranchItem == null)
		{
			return;
		}
		roleSkillBranchItem.SetSkillBranchVisible(reason, visible);
	}

	// Token: 0x060132AF RID: 78511 RVA: 0x0059BF01 File Offset: 0x0059A101
	public void SetSkillBranchTipsVisible(bool visible)
	{
		RoleSkillBranchItem roleSkillBranchItem = this.RoleSkillBranchItem;
		if (roleSkillBranchItem == null)
		{
			return;
		}
		roleSkillBranchItem.SetSkillBranchTipsVisible(visible);
	}

	// Token: 0x060132B0 RID: 78512 RVA: 0x0059BF14 File Offset: 0x0059A114
	[NullableContext(1)]
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
		RoleSkillInnerPassiveSkillAndOuterPassiveSkillItem innerPassiveSkillAndOuterPassiveSkillItem = this.InnerPassiveSkillAndOuterPassiveSkillItem;
		UUIItem uuiitem = (innerPassiveSkillAndOuterPassiveSkillItem != null) ? innerPassiveSkillAndOuterPassiveSkillItem.FindDoubleTagSkillTog() : null;
		if (uuiitem == null)
		{
			RoleSkillInnerSkillAndOuterAttributeItem[] innerSkillAndOuterAttributeItemList = this.InnerSkillAndOuterAttributeItemList;
			for (int i = 0; i < innerSkillAndOuterAttributeItemList.Length; i++)
			{
				uuiitem = innerSkillAndOuterAttributeItemList[i].FindDoubleTagSkillTog();
				if (uuiitem != null)
				{
					break;
				}
			}
		}
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

	// Token: 0x0400A460 RID: 42080
	private int RoleId;

	// Token: 0x0400A461 RID: 42081
	private RoleSkillInnerPassiveSkillAndOuterPassiveSkillItem InnerPassiveSkillAndOuterPassiveSkillItem;

	// Token: 0x0400A462 RID: 42082
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private RoleSkillInnerSkillAndOuterAttributeItem[] InnerSkillAndOuterAttributeItemList;

	// Token: 0x0400A463 RID: 42083
	private RoleSkillOuterPassiveSkillItem OuterPassiveSkillItem;

	// Token: 0x0400A464 RID: 42084
	private RoleSkillTreeSkillItemBase CurSelectedSkillItem;

	// Token: 0x0400A465 RID: 42085
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x0400A466 RID: 42086
	private RoleSkillOuterPassiveSkillItem WeakBreakSkillItem;

	// Token: 0x0400A467 RID: 42087
	private RoleSkillBranchItem RoleSkillBranchItem;

	// Token: 0x0400A468 RID: 42088
	private bool EnableSwitchBranch;

	// Token: 0x0200811B RID: 33051
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029C1A RID: 171034
		InnerPassiveSkillAndOuterPassiveSkillItem,
		// Token: 0x04029C1B RID: 171035
		InnerSkillAndOuterAttributeItem1,
		// Token: 0x04029C1C RID: 171036
		InnerSkillAndOuterAttributeItem2,
		// Token: 0x04029C1D RID: 171037
		InnerSkillAndOuterAttributeItem3,
		// Token: 0x04029C1E RID: 171038
		InnerSkillAndOuterAttributeItem4,
		// Token: 0x04029C1F RID: 171039
		OuterPassiveSkillItem,
		// Token: 0x04029C20 RID: 171040
		SkillInputButton,
		// Token: 0x04029C21 RID: 171041
		WeakBreakSkillItem,
		// Token: 0x04029C22 RID: 171042
		BranchItem
	}
}
