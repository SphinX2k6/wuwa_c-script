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

// Token: 0x020028C4 RID: 10436
[NullableContext(2)]
[Nullable(0)]
public class RoleSkillTreeItem : UiPanelBase
{
	// Token: 0x06015896 RID: 88214 RVA: 0x005707D0 File Offset: 0x0056E9D0
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

	// Token: 0x06015897 RID: 88215 RVA: 0x00570960 File Offset: 0x0056EB60
	protected override UniTask OnBeforeStartAsync()
	{
		RoleSkillTreeItem.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleSkillTreeItem.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015898 RID: 88216 RVA: 0x005709A4 File Offset: 0x0056EBA4
	private UniTask InitChildComponents()
	{
		RoleSkillTreeItem.<InitChildComponents>d__12 <InitChildComponents>d__;
		<InitChildComponents>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitChildComponents>d__.<>4__this = this;
		<InitChildComponents>d__.<>1__state = -1;
		<InitChildComponents>d__.<>t__builder.Start<RoleSkillTreeItem.<InitChildComponents>d__12>(ref <InitChildComponents>d__);
		return <InitChildComponents>d__.<>t__builder.Task;
	}

	// Token: 0x06015899 RID: 88217 RVA: 0x005709E8 File Offset: 0x0056EBE8
	public void Refresh()
	{
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(this.RoleId, true);
		this.RefreshRole(roleDataById.GetRoleSkillTreeConfig());
		this.RefreshSkillBranch();
	}

	// Token: 0x0601589A RID: 88218 RVA: 0x00570A1C File Offset: 0x0056EC1C
	private UniTask InitInnerSkillAndOuterAttributeItemList()
	{
		RoleSkillTreeItem.<InitInnerSkillAndOuterAttributeItemList>d__14 <InitInnerSkillAndOuterAttributeItemList>d__;
		<InitInnerSkillAndOuterAttributeItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitInnerSkillAndOuterAttributeItemList>d__.<>4__this = this;
		<InitInnerSkillAndOuterAttributeItemList>d__.<>1__state = -1;
		<InitInnerSkillAndOuterAttributeItemList>d__.<>t__builder.Start<RoleSkillTreeItem.<InitInnerSkillAndOuterAttributeItemList>d__14>(ref <InitInnerSkillAndOuterAttributeItemList>d__);
		return <InitInnerSkillAndOuterAttributeItemList>d__.<>t__builder.Task;
	}

	// Token: 0x0601589B RID: 88219 RVA: 0x00570A60 File Offset: 0x0056EC60
	private UniTask InitBranchItem()
	{
		RoleSkillTreeItem.<InitBranchItem>d__15 <InitBranchItem>d__;
		<InitBranchItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitBranchItem>d__.<>4__this = this;
		<InitBranchItem>d__.<>1__state = -1;
		<InitBranchItem>d__.<>t__builder.Start<RoleSkillTreeItem.<InitBranchItem>d__15>(ref <InitBranchItem>d__);
		return <InitBranchItem>d__.<>t__builder.Task;
	}

	// Token: 0x0601589C RID: 88220 RVA: 0x00570AA4 File Offset: 0x0056ECA4
	private void OnSkillInputButtonClick()
	{
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(this.RoleId, true);
		UiManager.Instance.OpenView(EUiViewName.RoleSkillInputView, roleDataById, null);
	}

	// Token: 0x0601589D RID: 88221 RVA: 0x00570AD4 File Offset: 0x0056ECD4
	public void UpdateRole(int roleId)
	{
		this.RoleId = roleId;
		this.Refresh();
	}

	// Token: 0x0601589E RID: 88222 RVA: 0x00570AE3 File Offset: 0x0056ECE3
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

	// Token: 0x0601589F RID: 88223 RVA: 0x00570B23 File Offset: 0x0056ED23
	public void CancelToggleSelect()
	{
		RoleSkillTreeSkillItemBase curSelectedSkillItem = this.CurSelectedSkillItem;
		if (curSelectedSkillItem != null)
		{
			curSelectedSkillItem.SetToggleState(EToggleState.ETT_UnChecked, false);
		}
		this.CurSelectedSkillItem = null;
	}

	// Token: 0x060158A0 RID: 88224 RVA: 0x00570B3F File Offset: 0x0056ED3F
	public void OnSkillNodeLevelUp(int nodeId)
	{
		this.OnNodeLevelChange(nodeId);
	}

	// Token: 0x060158A1 RID: 88225 RVA: 0x00570B48 File Offset: 0x0056ED48
	public void OnAddCommonItemList()
	{
		this.Refresh();
	}

	// Token: 0x060158A2 RID: 88226 RVA: 0x00570B50 File Offset: 0x0056ED50
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

	// Token: 0x060158A3 RID: 88227 RVA: 0x00570BA4 File Offset: 0x0056EDA4
	public void OnAttributeNodeActive(int nodeId)
	{
		this.OnNodeLevelChange(nodeId);
	}

	// Token: 0x060158A4 RID: 88228 RVA: 0x00570BAD File Offset: 0x0056EDAD
	public void SetSkillInputButtonVisible(bool bVisible)
	{
		base.GetButton(6).GetRootComponent().SetUIActive(bVisible);
	}

	// Token: 0x060158A5 RID: 88229 RVA: 0x00570BC4 File Offset: 0x0056EDC4
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

	// Token: 0x060158A6 RID: 88230 RVA: 0x00570CDC File Offset: 0x0056EEDC
	[NullableContext(1)]
	public void PlayItemSequence(string seq)
	{
		this.SequencePlayer.PlayOrReplaySequenceByName(seq, false, null);
	}

	// Token: 0x060158A7 RID: 88231 RVA: 0x00570D00 File Offset: 0x0056EF00
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

	// Token: 0x060158A8 RID: 88232 RVA: 0x00570D4C File Offset: 0x0056EF4C
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

	// Token: 0x060158A9 RID: 88233 RVA: 0x00570EC4 File Offset: 0x0056F0C4
	public RoleSkillTreeSkillItemBase GetCurrentSelectedSkillItem()
	{
		return this.CurSelectedSkillItem;
	}

	// Token: 0x060158AA RID: 88234 RVA: 0x00570ECC File Offset: 0x0056F0CC
	private void RefreshSkillBranch()
	{
		this.RoleSkillBranchItem.Refresh(this.RoleId, this.EnableSwitchBranch);
	}

	// Token: 0x060158AB RID: 88235 RVA: 0x00570EE8 File Offset: 0x0056F0E8
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

	// Token: 0x060158AC RID: 88236 RVA: 0x00570F53 File Offset: 0x0056F153
	public void SetEnableSwitchBranch(bool isEnable)
	{
		this.EnableSwitchBranch = isEnable;
	}

	// Token: 0x060158AD RID: 88237 RVA: 0x00570F5C File Offset: 0x0056F15C
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

	// Token: 0x060158AE RID: 88238 RVA: 0x00571028 File Offset: 0x0056F228
	public void SetSkillBranchVisible(ESkillBranchInvisibleReason reason, bool visible)
	{
		RoleSkillBranchItem roleSkillBranchItem = this.RoleSkillBranchItem;
		if (roleSkillBranchItem == null)
		{
			return;
		}
		roleSkillBranchItem.SetSkillBranchVisible(reason, visible);
	}

	// Token: 0x060158AF RID: 88239 RVA: 0x0057103D File Offset: 0x0056F23D
	public void SetSkillBranchTipsVisible(bool visible)
	{
		RoleSkillBranchItem roleSkillBranchItem = this.RoleSkillBranchItem;
		if (roleSkillBranchItem == null)
		{
			return;
		}
		roleSkillBranchItem.SetSkillBranchTipsVisible(visible);
	}

	// Token: 0x060158B0 RID: 88240 RVA: 0x00571050 File Offset: 0x0056F250
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

	// Token: 0x0400A077 RID: 41079
	private int RoleId;

	// Token: 0x0400A078 RID: 41080
	private RoleSkillInnerPassiveSkillAndOuterPassiveSkillItem InnerPassiveSkillAndOuterPassiveSkillItem;

	// Token: 0x0400A079 RID: 41081
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private RoleSkillInnerSkillAndOuterAttributeItem[] InnerSkillAndOuterAttributeItemList;

	// Token: 0x0400A07A RID: 41082
	private RoleSkillOuterPassiveSkillItem OuterPassiveSkillItem;

	// Token: 0x0400A07B RID: 41083
	private RoleSkillTreeSkillItemBase CurSelectedSkillItem;

	// Token: 0x0400A07C RID: 41084
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x0400A07D RID: 41085
	private RoleSkillOuterPassiveSkillItem WeakBreakSkillItem;

	// Token: 0x0400A07E RID: 41086
	private RoleSkillBranchItem RoleSkillBranchItem;

	// Token: 0x0400A07F RID: 41087
	private bool EnableSwitchBranch;

	// Token: 0x02008ED3 RID: 36563
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402E51F RID: 189727
		InnerPassiveSkillAndOuterPassiveSkillItem,
		// Token: 0x0402E520 RID: 189728
		InnerSkillAndOuterAttributeItem1,
		// Token: 0x0402E521 RID: 189729
		InnerSkillAndOuterAttributeItem2,
		// Token: 0x0402E522 RID: 189730
		InnerSkillAndOuterAttributeItem3,
		// Token: 0x0402E523 RID: 189731
		InnerSkillAndOuterAttributeItem4,
		// Token: 0x0402E524 RID: 189732
		OuterPassiveSkillItem,
		// Token: 0x0402E525 RID: 189733
		SkillInputButton,
		// Token: 0x0402E526 RID: 189734
		WeakBreakSkillItem,
		// Token: 0x0402E527 RID: 189735
		BranchItem
	}
}
