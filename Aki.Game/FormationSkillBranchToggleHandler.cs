using System;
using System.Runtime.CompilerServices;

// Token: 0x0200108C RID: 4236
[NullableContext(2)]
[Nullable(0)]
public class FormationSkillBranchToggleHandler
{
	// Token: 0x0600A850 RID: 43088 RVA: 0x00318969 File Offset: 0x00316B69
	public FormationSkillBranchToggleHandler([Nullable(new byte[]
	{
		1,
		2
	})] Func<CommonRoleSkillBranchSwitchItem> getToggleItem)
	{
		this.GetToggleItem = getToggleItem;
	}

	// Token: 0x0600A851 RID: 43089 RVA: 0x00318978 File Offset: 0x00316B78
	public void Refresh(int configId, IRoleSlotDisplayData.SkillBranchData branch)
	{
		this.CurrentConfigId = configId;
		this.LastBranchDto = branch;
		this.ApplyDto(branch);
	}

	// Token: 0x0600A852 RID: 43090 RVA: 0x0031898F File Offset: 0x00316B8F
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

	// Token: 0x0600A853 RID: 43091 RVA: 0x003189B5 File Offset: 0x00316BB5
	public void ApplyLastDto()
	{
		this.ApplyDto(this.LastBranchDto);
	}

	// Token: 0x0600A854 RID: 43092 RVA: 0x003189C4 File Offset: 0x00316BC4
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

	// Token: 0x0600A855 RID: 43093 RVA: 0x00318A3C File Offset: 0x00316C3C
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

	// Token: 0x0600A856 RID: 43094 RVA: 0x00318A64 File Offset: 0x00316C64
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

	// Token: 0x0600A857 RID: 43095 RVA: 0x00318AD0 File Offset: 0x00316CD0
	[NullableContext(1)]
	private string OnRefreshIcon(int index)
	{
		return FormationConfig.Instance.GetSkillBranchIcon(this.CurrentConfigId, index);
	}

	// Token: 0x040061D4 RID: 25044
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly Func<CommonRoleSkillBranchSwitchItem> GetToggleItem;

	// Token: 0x040061D5 RID: 25045
	private int CurrentConfigId;

	// Token: 0x040061D6 RID: 25046
	private IRoleSlotDisplayData.SkillBranchData LastBranchDto;
}
