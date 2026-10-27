using System;
using System.Runtime.CompilerServices;

// Token: 0x02001BCD RID: 7117
[NullableContext(2)]
[Nullable(0)]
public class FormationSkillBranchToggleHandler
{
	// Token: 0x0600D43E RID: 54334 RVA: 0x0030D7F5 File Offset: 0x0030B9F5
	public FormationSkillBranchToggleHandler([Nullable(new byte[]
	{
		1,
		2
	})] Func<CommonRoleSkillBranchSwitchItem> getToggleItem)
	{
		this.GetToggleItem = getToggleItem;
	}

	// Token: 0x0600D43F RID: 54335 RVA: 0x0030D804 File Offset: 0x0030BA04
	public void Refresh(int configId, IRoleSlotDisplayData.SkillBranchData branch)
	{
		this.CurrentConfigId = configId;
		this.LastBranchDto = branch;
		this.ApplyDto(branch);
	}

	// Token: 0x0600D440 RID: 54336 RVA: 0x0030D81B File Offset: 0x0030BA1B
	public void Clear()
	{
		this.CurrentConfigId = 0;
		this.LastBranchDto = null;
		CommonRoleSkillBranchSwitchItem commonRoleSkillBranchSwitchItem = this.GetToggleItem();
		if (commonRoleSkillBranchSwitchItem == null)
		{
			return;
		}
		commonRoleSkillBranchSwitchItem.SetUiActive(false);
	}

	// Token: 0x0600D441 RID: 54337 RVA: 0x0030D841 File Offset: 0x0030BA41
	public void ApplyLastDto()
	{
		this.ApplyDto(this.LastBranchDto);
	}

	// Token: 0x0600D442 RID: 54338 RVA: 0x0030D850 File Offset: 0x0030BA50
	public void OnRoleSkillBranchChanged(int roleId)
	{
		if (roleId != this.CurrentConfigId || this.LastBranchDto == null || (this.LastBranchDto.IsMulti && !this.LastBranchDto.IsSelf))
		{
			return;
		}
		int roleSkillBranchIndexInCurrentGamePlay = RoleModel.Instance.GetRoleSkillBranchIndexInCurrentGamePlay(roleId);
		if (roleSkillBranchIndexInCurrentGamePlay >= 0)
		{
			this.LastBranchDto.ActiveBranchIndex = roleSkillBranchIndexInCurrentGamePlay;
			this.ApplyDto(this.LastBranchDto);
			return;
		}
		CommonRoleSkillBranchSwitchItem commonRoleSkillBranchSwitchItem = this.GetToggleItem();
		if (commonRoleSkillBranchSwitchItem == null)
		{
			return;
		}
		commonRoleSkillBranchSwitchItem.SetUiActive(false);
	}

	// Token: 0x0600D443 RID: 54339 RVA: 0x0030D8C8 File Offset: 0x0030BAC8
	public void SwitchBranchHandler(int skillBranch)
	{
		if (this.CurrentConfigId <= 0)
		{
			return;
		}
		FormationNetHandler.RequestSwitchSkillBranch(this.CurrentConfigId, skillBranch, delegate(int oppositeIndex)
		{
			CommonRoleSkillBranchSwitchItem commonRoleSkillBranchSwitchItem = this.GetToggleItem();
			if (commonRoleSkillBranchSwitchItem == null)
			{
				return;
			}
			commonRoleSkillBranchSwitchItem.SetActiveBranchIndex(oppositeIndex);
		});
	}

	// Token: 0x0600D444 RID: 54340 RVA: 0x0030D8F0 File Offset: 0x0030BAF0
	private void ApplyDto(IRoleSlotDisplayData.SkillBranchData branch)
	{
		CommonRoleSkillBranchSwitchItem commonRoleSkillBranchSwitchItem = this.GetToggleItem();
		if (commonRoleSkillBranchSwitchItem == null)
		{
			return;
		}
		if (branch == null || branch.IsHiddenByInstSubType)
		{
			commonRoleSkillBranchSwitchItem.SetUiActive(false);
			return;
		}
		commonRoleSkillBranchSwitchItem.SetUiActive(true);
		commonRoleSkillBranchSwitchItem.SetToggleInteractive(!branch.IsMulti || branch.IsSelf);
		commonRoleSkillBranchSwitchItem.SetActiveBranchIndex(branch.ActiveBranchIndex);
		commonRoleSkillBranchSwitchItem.RefreshIcon(new Func<int, string>(this.OnRefreshIcon));
	}

	// Token: 0x0600D445 RID: 54341 RVA: 0x0030D95C File Offset: 0x0030BB5C
	[NullableContext(1)]
	private string OnRefreshIcon(int index)
	{
		return FormationConfig.Instance.GetSkillBranchIcon(this.CurrentConfigId, index);
	}

	// Token: 0x04006105 RID: 24837
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly Func<CommonRoleSkillBranchSwitchItem> GetToggleItem;

	// Token: 0x04006106 RID: 24838
	private int CurrentConfigId;

	// Token: 0x04006107 RID: 24839
	private IRoleSlotDisplayData.SkillBranchData LastBranchDto;
}
