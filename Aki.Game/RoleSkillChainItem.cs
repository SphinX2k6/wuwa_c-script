using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020028A7 RID: 10407
[NullableContext(1)]
[Nullable(0)]
public class RoleSkillChainItem : UiPanelBase
{
	// Token: 0x0601579E RID: 87966 RVA: 0x0056A938 File Offset: 0x00568B38
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

	// Token: 0x0601579F RID: 87967 RVA: 0x0056AA2C File Offset: 0x00568C2C
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

	// Token: 0x060157A0 RID: 87968 RVA: 0x0056AAB4 File Offset: 0x00568CB4
	public void OnNodeLevelChange(int nodeId)
	{
		foreach (RoleSkillTreeSkillItemBase roleSkillTreeSkillItemBase in this.SkillNodeItemList)
		{
			roleSkillTreeSkillItemBase.OnNodeLevelChange(nodeId);
		}
		this.RefreshLine();
	}

	// Token: 0x060157A1 RID: 87969 RVA: 0x0056AB0C File Offset: 0x00568D0C
	public IReadOnlyList<RoleSkillTreeSkillItemBase> GetSkillNodeItems()
	{
		return this.SkillNodeItemList;
	}

	// Token: 0x060157A2 RID: 87970 RVA: 0x0056AB14 File Offset: 0x00568D14
	public void SetSkillBranchEnable(bool isEnable)
	{
		this.IsSkillBranchEnable = isEnable;
	}

	// Token: 0x060157A3 RID: 87971 RVA: 0x0056AB20 File Offset: 0x00568D20
	public void OnSkillBranchChanged()
	{
		foreach (RoleSkillTreeSkillItemBase roleSkillTreeSkillItemBase in this.SkillNodeItemList)
		{
			roleSkillTreeSkillItemBase.OnSkillBranchChanged();
		}
	}

	// Token: 0x060157A4 RID: 87972 RVA: 0x0056AB70 File Offset: 0x00568D70
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

	// Token: 0x0400A00E RID: 40974
	protected readonly List<RoleSkillTreeSkillItemBase> SkillNodeItemList = new List<RoleSkillTreeSkillItemBase>();

	// Token: 0x0400A00F RID: 40975
	protected readonly List<UUIItem> LineItemList = new List<UUIItem>();

	// Token: 0x0400A010 RID: 40976
	protected bool IsSkillBranchEnable;
}
