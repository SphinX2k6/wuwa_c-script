using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x0200097D RID: 2429
[NullableContext(1)]
[Nullable(0)]
public class RoleSkinTrialData : ActivityBaseData
{
	// Token: 0x06006A94 RID: 27284 RVA: 0x00212C8C File Offset: 0x00210E8C
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

	// Token: 0x06006A95 RID: 27285 RVA: 0x00212CFC File Offset: 0x00210EFC
	public void FinishRewardById(int roleId)
	{
		RoleSkinTrailContentData roleSkinTrailContentDataById = this.GetRoleSkinTrailContentDataById(roleId);
		if (roleSkinTrailContentDataById != null)
		{
			roleSkinTrailContentDataById.ChallengeState = ChallengeState.Finish;
		}
	}

	// Token: 0x06006A96 RID: 27286 RVA: 0x00212D1C File Offset: 0x00210F1C
	[NullableContext(2)]
	public RoleSkinTrailContentData GetRoleSkinTrailContentDataByRoleId(int roleId)
	{
		return this.RoleSkinTrailContentDataList.Find((RoleSkinTrailContentData data) => data.RoleId == roleId);
	}

	// Token: 0x06006A97 RID: 27287 RVA: 0x00212D50 File Offset: 0x00210F50
	[NullableContext(2)]
	public RoleSkinTrailContentData GetRoleSkinTrailContentDataById(int id)
	{
		return this.RoleSkinTrailContentDataList.Find((RoleSkinTrailContentData data) => data.Id == id);
	}

	// Token: 0x06006A98 RID: 27288 RVA: 0x00212D84 File Offset: 0x00210F84
	public RoleSkinTrialActivity GetConfig()
	{
		return RoleSkinTrialConfig.Instance.GetRoleSkinTrialActivityByActivityId(base.Id).Value;
	}

	// Token: 0x06006A99 RID: 27289 RVA: 0x00212DAC File Offset: 0x00210FAC
	public int GetSelectIdByIndex(int index)
	{
		List<int> roleList = this.GetRoleList();
		if (roleList.Count <= index)
		{
			return 0;
		}
		return roleList[index];
	}

	// Token: 0x06006A9A RID: 27290 RVA: 0x00212DD4 File Offset: 0x00210FD4
	public int? GetInstanceIdById(int id)
	{
		RoleSkinTrialInfo? roleSkinTrialInfoById = RoleSkinTrialConfig.Instance.GetRoleSkinTrialInfoById(id);
		if (roleSkinTrialInfoById == null)
		{
			return null;
		}
		return new int?(roleSkinTrialInfoById.GetValueOrDefault().InstanceId);
	}

	// Token: 0x06006A9B RID: 27291 RVA: 0x00212E14 File Offset: 0x00211014
	public List<int> GetRoleList()
	{
		return new List<int>(this.GetConfig().GetRoleIdListArray());
	}

	// Token: 0x06006A9C RID: 27292 RVA: 0x00212E34 File Offset: 0x00211034
	public ChallengeState GetRewardStateById(int id)
	{
		RoleSkinTrailContentData roleSkinTrailContentDataById = this.GetRoleSkinTrailContentDataById(id);
		if (roleSkinTrailContentDataById != null)
		{
			return roleSkinTrailContentDataById.ChallengeState;
		}
		return ChallengeState.Running;
	}

	// Token: 0x06006A9D RID: 27293 RVA: 0x00212E54 File Offset: 0x00211054
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

	// Token: 0x06006A9E RID: 27294 RVA: 0x00212E74 File Offset: 0x00211074
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

	// Token: 0x06006A9F RID: 27295 RVA: 0x00212EF0 File Offset: 0x002110F0
	public RoleSkinTrialUiConfig? GetRoleSkinTrialUiConfigById(int id)
	{
		RoleSkinTrailContentData roleSkinTrailContentDataById = this.GetRoleSkinTrailContentDataById(id);
		if (roleSkinTrailContentDataById != null)
		{
			return new RoleSkinTrialUiConfig?(roleSkinTrailContentDataById.GetRoleSkinTrialUiConfig());
		}
		return null;
	}

	// Token: 0x06006AA0 RID: 27296 RVA: 0x00212F20 File Offset: 0x00211120
	public int GetAccessIdById(int id)
	{
		RoleSkinTrailContentData roleSkinTrailContentDataById = this.GetRoleSkinTrailContentDataById(id);
		if (roleSkinTrailContentDataById != null)
		{
			return roleSkinTrailContentDataById.GetAccessId();
		}
		return 0;
	}

	// Token: 0x06006AA1 RID: 27297 RVA: 0x00212F40 File Offset: 0x00211140
	public override bool NeedSelfControlFirstRedPoint()
	{
		return false;
	}

	// Token: 0x06006AA2 RID: 27298 RVA: 0x00212F44 File Offset: 0x00211144
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

	// Token: 0x06006AA3 RID: 27299 RVA: 0x00212FA0 File Offset: 0x002111A0
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

	// Token: 0x04004323 RID: 17187
	public bool TrialState;

	// Token: 0x04004324 RID: 17188
	private readonly List<RoleSkinTrailContentData> RoleSkinTrailContentDataList = new List<RoleSkinTrailContentData>();
}
