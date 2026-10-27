using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02001527 RID: 5415
[NullableContext(1)]
[Nullable(0)]
public class ActivityTowerGuideData : ActivityBaseData
{
	// Token: 0x06009A84 RID: 39556 RVA: 0x00216FF8 File Offset: 0x002151F8
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

	// Token: 0x06009A85 RID: 39557 RVA: 0x00217084 File Offset: 0x00215284
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

	// Token: 0x06009A86 RID: 39558 RVA: 0x002170B8 File Offset: 0x002152B8
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

	// Token: 0x06009A87 RID: 39559 RVA: 0x002170EC File Offset: 0x002152EC
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

	// Token: 0x06009A88 RID: 39560 RVA: 0x00217133 File Offset: 0x00215333
	public void SetRewardClaimed(int id, bool isClaimed)
	{
		this.TowerRewardClaimed[id] = isClaimed;
		this.RefreshRewardState((ETowerDifficultId)id);
	}

	// Token: 0x06009A89 RID: 39561 RVA: 0x0021714C File Offset: 0x0021534C
	public void RefreshRewardState(ETowerDifficultId id)
	{
		ETowerProgressState rewardState = this.GetRewardState(id);
		this.TowerRewardMap[(int)id] = rewardState;
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06009A8A RID: 39562 RVA: 0x00217184 File Offset: 0x00215384
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

	// Token: 0x06009A8B RID: 39563 RVA: 0x002171BF File Offset: 0x002153BF
	[NullableContext(0)]
	public ValueTuple<int, int> GetTowerProgress(ETowerDifficultId id)
	{
		return TowerModel.Instance.GetDifficultyProgress((int)id);
	}

	// Token: 0x06009A8C RID: 39564 RVA: 0x002171CC File Offset: 0x002153CC
	public ETowerProgressState GetTowerProgressState(int id)
	{
		ETowerProgressState result;
		if (!this.TowerRewardMap.TryGetValue(id, out result))
		{
			return ETowerProgressState.InActive;
		}
		return result;
	}

	// Token: 0x06009A8D RID: 39565 RVA: 0x002171EC File Offset: 0x002153EC
	[NullableContext(2)]
	public RoleDataBase GetTrialRoleData()
	{
		return RoleModel.Instance.GetRoleDataById(this.TrialRoleId, true);
	}

	// Token: 0x040043F6 RID: 17398
	public int[] TowerDifficultIdList = new int[]
	{
		1,
		2
	};

	// Token: 0x040043F7 RID: 17399
	private readonly Dictionary<int, ETowerProgressState> TowerRewardMap = new Dictionary<int, ETowerProgressState>();

	// Token: 0x040043F8 RID: 17400
	private readonly Dictionary<int, bool> TowerRewardClaimed = new Dictionary<int, bool>();

	// Token: 0x040043F9 RID: 17401
	public int TrialRoleId;

	// Token: 0x040043FA RID: 17402
	public int MapMarkId;
}
