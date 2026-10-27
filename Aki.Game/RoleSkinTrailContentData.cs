using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Reward;

// Token: 0x020014C8 RID: 5320
[NullableContext(1)]
[Nullable(0)]
public class RoleSkinTrailContentData
{
	// Token: 0x060096F8 RID: 38648 RVA: 0x00209B7C File Offset: 0x00207D7C
	public IItemGridData[] GetRewardData()
	{
		RoleSkinTrialInfo? roleSkinTrialInfoByRoleId = RoleSkinTrialConfig.Instance.GetRoleSkinTrialInfoByRoleId(this.RoleId);
		if (roleSkinTrialInfoByRoleId == null || roleSkinTrialInfoByRoleId.Value.DropId == 0)
		{
			return null;
		}
		List<IItemGridData> list = new List<IItemGridData>();
		foreach (TItem item in CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(roleSkinTrialInfoByRoleId.Value.DropId))
		{
			ItemGridData item2 = new ItemGridData
			{
				Item = item,
				HasClaimed = (this.ChallengeState == ChallengeState.Finish)
			};
			list.Add(item2);
		}
		return list.ToArray();
	}

	// Token: 0x060096F9 RID: 38649 RVA: 0x00209C3C File Offset: 0x00207E3C
	public RoleSkinTrialInfo GetRoleSkinTrialInfo()
	{
		return RoleSkinTrialConfig.Instance.GetRoleSkinTrialInfoByRoleId(this.RoleId).Value;
	}

	// Token: 0x060096FA RID: 38650 RVA: 0x00209C64 File Offset: 0x00207E64
	public int GetInstanceDungeonId()
	{
		return this.GetRoleSkinTrialInfo().InstanceId;
	}

	// Token: 0x060096FB RID: 38651 RVA: 0x00209C80 File Offset: 0x00207E80
	public int GetAccessId()
	{
		return this.GetRoleSkinTrialInfo().AccessId;
	}

	// Token: 0x060096FC RID: 38652 RVA: 0x00209C9C File Offset: 0x00207E9C
	public RoleSkinTrialUiConfig GetRoleSkinTrialUiConfig()
	{
		return RoleSkinTrialConfig.Instance.GetRoleSkinTrialUiConfigById(this.GetRoleSkinTrialInfo().UiConfigId).Value;
	}

	// Token: 0x060096FD RID: 38653 RVA: 0x00209CCC File Offset: 0x00207ECC
	public void Phrase(RoleSkinTrialTask data)
	{
		this.Id = data.RoleSkinTrialInfoId;
		this.RoleId = RoleSkinTrialConfig.Instance.GetRoleSkinTrialInfoById(this.Id).Value.RoleId;
		this.ChallengeState = data.ChallengeState;
	}

	// Token: 0x04004288 RID: 17032
	public int RoleId;

	// Token: 0x04004289 RID: 17033
	public int Id;

	// Token: 0x0400428A RID: 17034
	public ChallengeState ChallengeState;
}
