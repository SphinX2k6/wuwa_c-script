using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x0200097F RID: 2431
[NullableContext(1)]
[Nullable(0)]
public class ActivityRoleTowerData : ActivityBaseData
{
	// Token: 0x06006ABA RID: 27322 RVA: 0x0021339D File Offset: 0x0021159D
	protected override void OnInit(ActivityData data)
	{
		RoleTowerModel.Instance.SetActivityId(data.Id);
	}

	// Token: 0x06006ABB RID: 27323 RVA: 0x002133AF File Offset: 0x002115AF
	protected override void PhraseEx(ActivityData data)
	{
		if (((data != null) ? data.RoleTowerActivityData : null) != null)
		{
			RoleTowerModel.Instance.OnActivityData(data.RoleTowerActivityData);
			this.EnsureUnlockReadInitialized();
		}
	}

	// Token: 0x06006ABC RID: 27324 RVA: 0x002133D5 File Offset: 0x002115D5
	public bool HasFirstOpenPageRedDot()
	{
		return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 0, 0, 0) == 0;
	}

	// Token: 0x06006ABD RID: 27325 RVA: 0x002133EE File Offset: 0x002115EE
	public void ReadFirstOpenPageRedDot()
	{
		ActivityController.Instance.RequestReadActivity(this);
		this.ReadNewLevelRedDot(ActivityRoleTowerData.ENewLevelRedDotDepth.EnterButton);
		if (!this.HasFirstOpenPageRedDot())
		{
			return;
		}
		ActivityModel.Instance.SaveActivityData(base.Id, 0, 0, 0, 1);
		ActivityRoleTowerController.RefreshActivityRedDot();
	}

	// Token: 0x06006ABE RID: 27326 RVA: 0x00213424 File Offset: 0x00211624
	public bool HasTeachRedDot()
	{
		return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 1, 0, 0) == 0;
	}

	// Token: 0x06006ABF RID: 27327 RVA: 0x0021343D File Offset: 0x0021163D
	public void ClearTeachRedDot()
	{
		if (!this.HasTeachRedDot())
		{
			return;
		}
		ActivityModel.Instance.SaveActivityData(base.Id, 1, 0, 0, 1);
		ActivityRoleTowerController.RefreshActivityRedDot();
	}

	// Token: 0x06006AC0 RID: 27328 RVA: 0x00213461 File Offset: 0x00211661
	private bool IsUnlockReadInitialized()
	{
		return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 3, 0, 0) == 1;
	}

	// Token: 0x06006AC1 RID: 27329 RVA: 0x0021347A File Offset: 0x0021167A
	private bool IsNewLevelUnread(int levelId)
	{
		return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 2, 0, levelId) == 0;
	}

	// Token: 0x06006AC2 RID: 27330 RVA: 0x00213493 File Offset: 0x00211693
	private void SaveNewLevelRead(int levelId)
	{
		ActivityModel.Instance.SaveActivityData(base.Id, 2, 0, levelId, 1);
	}

	// Token: 0x06006AC3 RID: 27331 RVA: 0x002134A9 File Offset: 0x002116A9
	private void SaveNewLevelUnread(int levelId)
	{
		ActivityModel.Instance.SaveActivityData(base.Id, 2, 0, levelId, 0);
		ActivityModel.Instance.SaveActivityData(base.Id, 6, 0, levelId, 0);
	}

	// Token: 0x06006AC4 RID: 27332 RVA: 0x002134D3 File Offset: 0x002116D3
	private int GetNewLevelOuterReadDepth(int levelId)
	{
		return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 6, 0, levelId);
	}

	// Token: 0x06006AC5 RID: 27333 RVA: 0x002134EC File Offset: 0x002116EC
	public void EnsureUnlockReadInitialized()
	{
		if (this.IsUnlockReadInitialized())
		{
			return;
		}
		foreach (RoleTowerLevelGroup roleTowerLevelGroup in RoleTowerModel.Instance.GetGroupCfgList())
		{
			if (roleTowerLevelGroup.Type == 2)
			{
				foreach (RoleTowerLevel roleTowerLevel in RoleTowerModel.Instance.GetLevelCfgListByGroup(roleTowerLevelGroup.Id))
				{
					RoleTowerLevelData levelState = RoleTowerModel.Instance.GetLevelState(roleTowerLevel.Id);
					if (levelState != null && levelState.IsUnlock && !levelState.IsAllPass)
					{
						this.SaveNewLevelRead(roleTowerLevel.Id);
					}
				}
			}
		}
		ActivityModel.Instance.SaveActivityData(base.Id, 3, 0, 0, 1);
	}

	// Token: 0x06006AC6 RID: 27334 RVA: 0x002135D8 File Offset: 0x002117D8
	public void OnNewLevelsUnlocked(IReadOnlyList<int> newLevelIds)
	{
		this.EnsureUnlockReadInitialized();
		foreach (int levelId in newLevelIds)
		{
			this.SaveNewLevelUnread(levelId);
		}
		ActivityRoleTowerController.RefreshActivityRedDot();
	}

	// Token: 0x06006AC7 RID: 27335 RVA: 0x0021362C File Offset: 0x0021182C
	public bool HasNewLevelRedDot()
	{
		return this.HasNewLevelRedDotByDepth(null);
	}

	// Token: 0x06006AC8 RID: 27336 RVA: 0x00213648 File Offset: 0x00211848
	public bool HasNewLevelRedDot(ActivityRoleTowerData.ENewLevelRedDotDepth depth)
	{
		return this.HasNewLevelRedDotByDepth(new int?((int)depth));
	}

	// Token: 0x06006AC9 RID: 27337 RVA: 0x00213658 File Offset: 0x00211858
	public void ReadNewLevelRedDot(ActivityRoleTowerData.ENewLevelRedDotDepth depth)
	{
		bool flag = false;
		foreach (int num in this.GetRoleLevelIds())
		{
			if (this.HasNewLevelRedDot(num) && this.GetNewLevelOuterReadDepth(num) < (int)depth)
			{
				ActivityModel.Instance.SaveActivityData(base.Id, 6, 0, num, (int)depth);
				flag = true;
			}
		}
		if (flag)
		{
			ActivityRoleTowerController.RefreshActivityRedDot();
		}
	}

	// Token: 0x06006ACA RID: 27338 RVA: 0x002136D4 File Offset: 0x002118D4
	private bool HasNewLevelRedDotByDepth(int? depth)
	{
		foreach (int levelId in this.GetRoleLevelIds())
		{
			if (this.HasNewLevelRedDot(levelId) && (depth == null || this.GetNewLevelOuterReadDepth(levelId) < depth.Value))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06006ACB RID: 27339 RVA: 0x00213744 File Offset: 0x00211944
	private IEnumerable<int> GetRoleLevelIds()
	{
		return new ActivityRoleTowerData.<GetRoleLevelIds>d__21(-2);
	}

	// Token: 0x06006ACC RID: 27340 RVA: 0x00213750 File Offset: 0x00211950
	public bool HasNewLevelRedDot(int levelId)
	{
		RoleTowerLevelData levelState = RoleTowerModel.Instance.GetLevelState(levelId);
		return levelState != null && levelState.IsUnlock && !levelState.IsAllPass && this.IsNewLevelUnread(levelId);
	}

	// Token: 0x06006ACD RID: 27341 RVA: 0x00213785 File Offset: 0x00211985
	public void MarkNewLevelRead(int levelId)
	{
		if (!this.HasNewLevelRedDot(levelId))
		{
			return;
		}
		this.SaveNewLevelRead(levelId);
		ActivityRoleTowerController.RefreshActivityRedDot();
	}

	// Token: 0x06006ACE RID: 27342 RVA: 0x0021379D File Offset: 0x0021199D
	private bool IsNewRecordUnread(int levelId)
	{
		return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 4, 0, levelId) == 2;
	}

	// Token: 0x06006ACF RID: 27343 RVA: 0x002137B6 File Offset: 0x002119B6
	public void OnNewRecord(int levelId)
	{
		if (levelId <= 0)
		{
			return;
		}
		ActivityModel.Instance.SaveActivityData(base.Id, 4, 0, levelId, 2);
		ActivityRoleTowerController.RefreshActivityRedDot();
	}

	// Token: 0x06006AD0 RID: 27344 RVA: 0x002137D6 File Offset: 0x002119D6
	public void MarkNewRecordRead(int levelId)
	{
		if (!this.HasNewRecordRedDot(levelId))
		{
			return;
		}
		ActivityModel.Instance.SaveActivityData(base.Id, 4, 0, levelId, 1);
		ActivityRoleTowerController.RefreshActivityRedDot();
	}

	// Token: 0x06006AD1 RID: 27345 RVA: 0x002137FB File Offset: 0x002119FB
	public bool HasNewRecordRedDot(int levelId)
	{
		return this.IsNewRecordUnread(levelId);
	}

	// Token: 0x06006AD2 RID: 27346 RVA: 0x00213804 File Offset: 0x00211A04
	public bool HasAnyNewRecordRedDot()
	{
		foreach (int levelId in this.GetRoleLevelIds())
		{
			if (this.IsNewRecordUnread(levelId))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06006AD3 RID: 27347 RVA: 0x0021385C File Offset: 0x00211A5C
	public override bool GetExDataRedPointShowState()
	{
		return this.HasNewLevelRedDot(ActivityRoleTowerData.ENewLevelRedDotDepth.ActivityTab) || RoleTowerModel.Instance.HasAnyRedDot();
	}

	// Token: 0x06006AD4 RID: 27348 RVA: 0x00213873 File Offset: 0x00211A73
	protected override bool GetExDataFinishShowState()
	{
		return RoleTowerModel.Instance.IsAllRewardReceived();
	}

	// Token: 0x0400432B RID: 17195
	private const int CacheUnread = 0;

	// Token: 0x0400432C RID: 17196
	private const int CacheRead = 1;

	// Token: 0x0400432D RID: 17197
	private const int CacheNewRecordUnread = 2;

	// Token: 0x02006C86 RID: 27782
	[NullableContext(0)]
	private enum ERoleTowerStorageKey
	{
		// Token: 0x04023A6E RID: 146030
		FirstOpenPage,
		// Token: 0x04023A6F RID: 146031
		FirstClickTeach,
		// Token: 0x04023A70 RID: 146032
		NewLevelRead,
		// Token: 0x04023A71 RID: 146033
		UnlockReadInitialized,
		// Token: 0x04023A72 RID: 146034
		NewRecordRead,
		// Token: 0x04023A73 RID: 146035
		NewRecordReadInitialized,
		// Token: 0x04023A74 RID: 146036
		NewLevelOuterRead
	}

	// Token: 0x02006C87 RID: 27783
	[NullableContext(0)]
	public enum ENewLevelRedDotDepth
	{
		// Token: 0x04023A76 RID: 146038
		ActivityTab = 1,
		// Token: 0x04023A77 RID: 146039
		EnterButton,
		// Token: 0x04023A78 RID: 146040
		RoleGroupButton
	}
}
