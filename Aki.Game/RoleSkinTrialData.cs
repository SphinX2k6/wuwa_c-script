using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x020014C9 RID: 5321
[NullableContext(1)]
[Nullable(0)]
public class RoleSkinTrialData : ActivityBaseData
{
	// Token: 0x060096FF RID: 38655 RVA: 0x00209D20 File Offset: 0x00207F20
	protected override void PhraseEx(ActivityData data)
	{
		this.RoleSkinTrailContentDataList.Clear();
		foreach (RoleSkinTrialTask data2 in data.RoleSkinTrialInfoActivity.RoleSkinTrialTask)
		{
			RoleSkinTrailContentData roleSkinTrailContentData = new RoleSkinTrailContentData();
			roleSkinTrailContentData.Phrase(data2);
			this.RoleSkinTrailContentDataList.Add(roleSkinTrailContentData);
		}
	}

	// Token: 0x06009700 RID: 38656 RVA: 0x00209D90 File Offset: 0x00207F90
	public void FinishRewardById(int roleId)
	{
		RoleSkinTrailContentData roleSkinTrailContentDataById = this.GetRoleSkinTrailContentDataById(roleId);
		if (roleSkinTrailContentDataById != null)
		{
			roleSkinTrailContentDataById.ChallengeState = ChallengeState.Finish;
		}
	}

	// Token: 0x06009701 RID: 38657 RVA: 0x00209DB0 File Offset: 0x00207FB0
	[NullableContext(2)]
	public RoleSkinTrailContentData GetRoleSkinTrailContentDataByRoleId(int roleId)
	{
		return this.RoleSkinTrailContentDataList.Find((RoleSkinTrailContentData data) => data.RoleId == roleId);
	}

	// Token: 0x06009702 RID: 38658 RVA: 0x00209DE4 File Offset: 0x00207FE4
	[NullableContext(2)]
	public RoleSkinTrailContentData GetRoleSkinTrailContentDataById(int id)
	{
		return this.RoleSkinTrailContentDataList.Find((RoleSkinTrailContentData data) => data.Id == id);
	}

	// Token: 0x06009703 RID: 38659 RVA: 0x00209E18 File Offset: 0x00208018
	public RoleSkinTrialActivity GetConfig()
	{
		return RoleSkinTrialConfig.Instance.GetRoleSkinTrialActivityByActivityId(base.Id).Value;
	}

	// Token: 0x06009704 RID: 38660 RVA: 0x00209E40 File Offset: 0x00208040
	public int GetSelectIdByIndex(int index)
	{
		List<int> roleList = this.GetRoleList();
		if (roleList.Count <= index)
		{
			return 0;
		}
		return roleList[index];
	}

	// Token: 0x06009705 RID: 38661 RVA: 0x00209E68 File Offset: 0x00208068
	public int? GetInstanceIdById(int id)
	{
		RoleSkinTrialInfo? roleSkinTrialInfoById = RoleSkinTrialConfig.Instance.GetRoleSkinTrialInfoById(id);
		if (roleSkinTrialInfoById == null)
		{
			return null;
		}
		return new int?(roleSkinTrialInfoById.GetValueOrDefault().InstanceId);
	}

	// Token: 0x06009706 RID: 38662 RVA: 0x00209EA8 File Offset: 0x002080A8
	public List<int> GetRoleList()
	{
		return this.GetConfig().GetRoleIdListArray().ToList<int>();
	}

	// Token: 0x06009707 RID: 38663 RVA: 0x00209EC8 File Offset: 0x002080C8
	public ChallengeState GetRewardStateById(int id)
	{
		RoleSkinTrailContentData roleSkinTrailContentDataById = this.GetRoleSkinTrailContentDataById(id);
		if (roleSkinTrailContentDataById != null)
		{
			return roleSkinTrailContentDataById.ChallengeState;
		}
		return ChallengeState.Running;
	}

	// Token: 0x06009708 RID: 38664 RVA: 0x00209EE8 File Offset: 0x002080E8
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public IItemGridData[] GetRewardDataById(int id)
	{
		RoleSkinTrailContentData roleSkinTrailContentDataById = this.GetRoleSkinTrailContentDataById(id);
		if (roleSkinTrailContentDataById != null)
		{
			return roleSkinTrailContentDataById.GetRewardData();
		}
		return null;
	}

	// Token: 0x06009709 RID: 38665 RVA: 0x00209F08 File Offset: 0x00208108
	public RoleSkinTrialInfo? GetInfoByRoleIdAndInstanceDungeonId(int roleId, int dungeonId)
	{
		foreach (RoleSkinTrailContentData roleSkinTrailContentData in this.RoleSkinTrailContentDataList)
		{
			if (roleSkinTrailContentData.RoleId == roleId)
			{
				RoleSkinTrialInfo roleSkinTrialInfo = roleSkinTrailContentData.GetRoleSkinTrialInfo();
				if (roleSkinTrialInfo.InstanceId == dungeonId)
				{
					return new RoleSkinTrialInfo?(roleSkinTrialInfo);
				}
			}
		}
		return null;
	}

	// Token: 0x0600970A RID: 38666 RVA: 0x00209F84 File Offset: 0x00208184
	public RoleSkinTrialUiConfig? GetRoleSkinTrialUiConfigById(int id)
	{
		RoleSkinTrailContentData roleSkinTrailContentDataById = this.GetRoleSkinTrailContentDataById(id);
		if (roleSkinTrailContentDataById != null)
		{
			return new RoleSkinTrialUiConfig?(roleSkinTrailContentDataById.GetRoleSkinTrialUiConfig());
		}
		return null;
	}

	// Token: 0x0600970B RID: 38667 RVA: 0x00209FB4 File Offset: 0x002081B4
	public int GetAccessIdById(int id)
	{
		RoleSkinTrailContentData roleSkinTrailContentDataById = this.GetRoleSkinTrailContentDataById(id);
		if (roleSkinTrailContentDataById != null)
		{
			return roleSkinTrailContentDataById.GetAccessId();
		}
		return 0;
	}

	// Token: 0x0600970C RID: 38668 RVA: 0x00209FD4 File Offset: 0x002081D4
	public override bool NeedSelfControlFirstRedPoint()
	{
		return false;
	}

	// Token: 0x0600970D RID: 38669 RVA: 0x00209FD8 File Offset: 0x002081D8
	public override bool GetExDataRedPointShowState()
	{
		using (List<RoleSkinTrailContentData>.Enumerator enumerator = this.RoleSkinTrailContentDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.ChallengeState == ChallengeState.WaitTakeReward)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600970E RID: 38670 RVA: 0x0020A034 File Offset: 0x00208234
	protected override bool GetExDataFinishShowState()
	{
		using (List<RoleSkinTrailContentData>.Enumerator enumerator = this.RoleSkinTrailContentDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.ChallengeState != ChallengeState.Finish)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0400428B RID: 17035
	public bool TrialState;

	// Token: 0x0400428C RID: 17036
	private readonly List<RoleSkinTrailContentData> RoleSkinTrailContentDataList = new List<RoleSkinTrailContentData>();
}
