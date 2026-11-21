using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E22 RID: 7714
[NullableContext(1)]
[Nullable(0)]
public class RoleSkillChainItem : UiPanelBase
{
	// Token: 0x0601319E RID: 78238 RVA: 0x00595780 File Offset: 0x00593980
	public void Update(int roleId, int startSkillNodeId)
	{
		this.SkillNodeItemList[0].Update(roleId, startSkillNodeId);
		int nodeIndex = RoleSkillConfig.Instance.GetSkillTreeNode(startSkillNodeId).Value.NodeIndex;
		RoleDataBase roleDataBase = RoleModel.Instance.GetRoleInstanceById(roleId);
		if (roleDataBase == null)
		{
			roleDataBase = RoleModel.Instance.GetRoleDataById(roleId, true);
		}
		IReadOnlyList<SkillTree> roleSkillTreeConfig = roleDataBase.GetRoleSkillTreeConfig();
		for (int i = 1; i < this.SkillNodeItemList.Count; i++)
		{
			foreach (SkillTree skillTree in roleSkillTreeConfig)
			{
				if (skillTree.ParentNodesLength == 1 && skillTree.ParentNodes(0) == nodeIndex)
				{
					this.SkillNodeItemList[i].Update(roleId, skillTree.Id);
					nodeIndex = skillTree.NodeIndex;
					break;
				}
			}
		}
		this.RefreshLine();
	}

	// Token: 0x0601319F RID: 78239 RVA: 0x00595874 File Offset: 0x00593A74
	public void RefreshLine()
	{
		for (int i = 0; i < this.LineItemList.Count; i++)
		{
			int num = i + 1;
			if (num >= this.SkillNodeItemList.Count)
			{
				return;
			}
			RoleSkillTreeSkillItemBase roleSkillTreeSkillItemBase = this.SkillNodeItemList[num];
			int skillNodeId = roleSkillTreeSkillItemBase.GetSkillNodeId();
			int roleId = roleSkillTreeSkillItemBase.GetRoleId();
			int roleSkillTreeNodeLevel = RoleModel.Instance.GetRoleSkillTreeNodeLevel(roleId, skillNodeId);
			UUIItem uuiitem = this.LineItemList[i];
			UUIItem uuiitem2 = uuiitem;
			bool bUseChangeColor = roleSkillTreeNodeLevel == 0;
			FColor? fcolor = new FColor?(uuiitem.changeColor);
			uuiitem2.SetChangeColor(bUseChangeColor, fcolor);
		}
	}

	// Token: 0x060131A0 RID: 78240 RVA: 0x005958FC File Offset: 0x00593AFC
	public void OnNodeLevelChange(int nodeId)
	{
		foreach (RoleSkillTreeSkillItemBase roleSkillTreeSkillItemBase in this.SkillNodeItemList)
		{
			roleSkillTreeSkillItemBase.OnNodeLevelChange(nodeId);
		}
		this.RefreshLine();
	}

	// Token: 0x060131A1 RID: 78241 RVA: 0x00595954 File Offset: 0x00593B54
	public IReadOnlyList<RoleSkillTreeSkillItemBase> GetSkillNodeItems()
	{
		return this.SkillNodeItemList;
	}

	// Token: 0x060131A2 RID: 78242 RVA: 0x0059595C File Offset: 0x00593B5C
	public void SetSkillBranchEnable(bool isEnable)
	{
		this.IsSkillBranchEnable = isEnable;
	}

	// Token: 0x060131A3 RID: 78243 RVA: 0x00595968 File Offset: 0x00593B68
	public void OnSkillBranchChanged()
	{
		foreach (RoleSkillTreeSkillItemBase roleSkillTreeSkillItemBase in this.SkillNodeItemList)
		{
			roleSkillTreeSkillItemBase.OnSkillBranchChanged();
		}
	}

	// Token: 0x060131A4 RID: 78244 RVA: 0x005959B8 File Offset: 0x00593BB8
	[NullableContext(2)]
	public UUIItem FindDoubleTagSkillTog()
	{
		foreach (RoleSkillTreeSkillItemBase roleSkillTreeSkillItemBase in this.SkillNodeItemList)
		{
			if (roleSkillTreeSkillItemBase != null && roleSkillTreeSkillItemBase.HasActiveBranchItem())
			{
				return roleSkillTreeSkillItemBase.GetRootItem();
			}
		}
		return null;
	}

	// Token: 0x0400A3F7 RID: 41975
	protected readonly List<RoleSkillTreeSkillItemBase> SkillNodeItemList = new List<RoleSkillTreeSkillItemBase>();

	// Token: 0x0400A3F8 RID: 41976
	protected readonly List<UUIItem> LineItemList = new List<UUIItem>();

	// Token: 0x0400A3F9 RID: 41977
	protected bool IsSkillBranchEnable;
}
