using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Reward;

// Token: 0x0200097C RID: 2428
[NullableContext(1)]
[Nullable(0)]
public class RoleSkinTrailContentData
{
	// Token: 0x06006A8D RID: 27277 RVA: 0x00212AE8 File Offset: 0x00210CE8
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

	// Token: 0x06006A8E RID: 27278 RVA: 0x00212BA8 File Offset: 0x00210DA8
	public RoleSkinTrialInfo GetRoleSkinTrialInfo()
	{
		return RoleSkinTrialConfig.Instance.GetRoleSkinTrialInfoByRoleId(this.RoleId).Value;
	}

	// Token: 0x06006A8F RID: 27279 RVA: 0x00212BD0 File Offset: 0x00210DD0
	public int GetInstanceDungeonId()
	{
		return this.GetRoleSkinTrialInfo().InstanceId;
	}

	// Token: 0x06006A90 RID: 27280 RVA: 0x00212BEC File Offset: 0x00210DEC
	public int GetAccessId()
	{
		return this.GetRoleSkinTrialInfo().AccessId;
	}

	// Token: 0x06006A91 RID: 27281 RVA: 0x00212C08 File Offset: 0x00210E08
	public RoleSkinTrialUiConfig GetRoleSkinTrialUiConfig()
	{
		return RoleSkinTrialConfig.Instance.GetRoleSkinTrialUiConfigById(this.GetRoleSkinTrialInfo().UiConfigId).Value;
	}

	// Token: 0x06006A92 RID: 27282 RVA: 0x00212C38 File Offset: 0x00210E38
	public void Phrase(RoleSkinTrialTask data)
	{
		this.Id = data.RoleSkinTrialInfoId;
		this.RoleId = RoleSkinTrialConfig.Instance.GetRoleSkinTrialInfoById(this.Id).Value.RoleId;
		this.ChallengeState = data.ChallengeState;
	}

	// Token: 0x04004320 RID: 17184
	public int RoleId;

	// Token: 0x04004321 RID: 17185
	public int Id;

	// Token: 0x04004322 RID: 17186
	public ChallengeState ChallengeState;
}
