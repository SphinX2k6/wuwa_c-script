using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020009DF RID: 2527
[NullableContext(1)]
[Nullable(0)]
public class ActivityTowerGuideData : ActivityBaseData
{
	// Token: 0x06006E62 RID: 28258 RVA: 0x00220D94 File Offset: 0x0021EF94
	protected override void PhraseEx(ActivityData data)
	{
		ActivityTowerGuideController.Instance.SetCurrentActivityId(base.Id);
		for (int i = 0; i < this.TowerDifficultIdList.Length; i++)
		{
			this.SetRewardClaimed(this.TowerDifficultIdList[i], false);
		}
		ActivityTowerGuideController.Instance.RequestTowerRewardInfo();
		TowerGuide? towerGuideById = ActivityTowerGuideConfig.Instance.GetTowerGuideById(1);
		if (towerGuideById == null)
		{
			return;
		}
		this.TrialRoleId = towerGuideById.Value.TrialRoleId;
		this.MapMarkId = towerGuideById.Value.MapMark;
	}

	// Token: 0x06006E63 RID: 28259 RVA: 0x00220E20 File Offset: 0x0021F020
	public override bool GetExDataRedPointShowState()
	{
		for (int i = 0; i < this.TowerDifficultIdList.Length; i++)
		{
			if (this.GetTowerProgressState(this.TowerDifficultIdList[i]) == ETowerProgressState.FinishedAndUnClaimed)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06006E64 RID: 28260 RVA: 0x00220E54 File Offset: 0x0021F054
	protected override bool GetExDataFinishShowState()
	{
		for (int i = 0; i < this.TowerDifficultIdList.Length; i++)
		{
			if (this.GetTowerProgressState(this.TowerDifficultIdList[i]) != ETowerProgressState.FinishedAndClaimed)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06006E65 RID: 28261 RVA: 0x00220E88 File Offset: 0x0021F088
	public ETowerGuideViewState GetViewState()
	{
		if (!base.IsUnLock())
		{
			return ETowerGuideViewState.InActive;
		}
		bool flag = true;
		for (int i = 0; i < this.TowerDifficultIdList.Length; i++)
		{
			if (this.GetTowerProgressState(this.TowerDifficultIdList[i]) != ETowerProgressState.FinishedAndClaimed)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			return ETowerGuideViewState.Active;
		}
		return ETowerGuideViewState.Finished;
	}

	// Token: 0x06006E66 RID: 28262 RVA: 0x00220ECF File Offset: 0x0021F0CF
	public void SetRewardClaimed(int id, bool isClaimed)
	{
		this.TowerRewardClaimed[id] = isClaimed;
		this.RefreshRewardState((ETowerDifficultId)id);
	}

	// Token: 0x06006E67 RID: 28263 RVA: 0x00220EE8 File Offset: 0x0021F0E8
	public void RefreshRewardState(ETowerDifficultId id)
	{
		ETowerProgressState rewardState = this.GetRewardState(id);
		this.TowerRewardMap[(int)id] = rewardState;
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06006E68 RID: 28264 RVA: 0x00220F20 File Offset: 0x0021F120
	private ETowerProgressState GetRewardState(ETowerDifficultId id)
	{
		if (!base.IsUnLock())
		{
			return ETowerProgressState.InActive;
		}
		if (!TowerModel.Instance.GetDifficultyIsClear((int)id))
		{
			return ETowerProgressState.Active;
		}
		bool flag;
		if (this.TowerRewardClaimed.TryGetValue((int)id, out flag) && flag)
		{
			return ETowerProgressState.FinishedAndClaimed;
		}
		return ETowerProgressState.FinishedAndUnClaimed;
	}

	// Token: 0x06006E69 RID: 28265 RVA: 0x00220F5B File Offset: 0x0021F15B
	[NullableContext(0)]
	public ValueTuple<int, int> GetTowerProgress(ETowerDifficultId id)
	{
		return TowerModel.Instance.GetDifficultyProgress((int)id);
	}

	// Token: 0x06006E6A RID: 28266 RVA: 0x00220F68 File Offset: 0x0021F168
	public ETowerProgressState GetTowerProgressState(int id)
	{
		ETowerProgressState result;
		if (!this.TowerRewardMap.TryGetValue(id, out result))
		{
			return ETowerProgressState.InActive;
		}
		return result;
	}

	// Token: 0x06006E6B RID: 28267 RVA: 0x00220F88 File Offset: 0x0021F188
	[NullableContext(2)]
	public RoleDataBase GetTrialRoleData()
	{
		return RoleModel.Instance.GetRoleDataById(this.TrialRoleId, true);
	}

	// Token: 0x0400449C RID: 17564
	public int[] TowerDifficultIdList = new int[]
	{
		1,
		2
	};

	// Token: 0x0400449D RID: 17565
	private readonly Dictionary<int, ETowerProgressState> TowerRewardMap = new Dictionary<int, ETowerProgressState>();

	// Token: 0x0400449E RID: 17566
	private readonly Dictionary<int, bool> TowerRewardClaimed = new Dictionary<int, bool>();

	// Token: 0x0400449F RID: 17567
	public int TrialRoleId;

	// Token: 0x040044A0 RID: 17568
	public int MapMarkId;
}
