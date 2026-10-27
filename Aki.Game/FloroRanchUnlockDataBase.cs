using System;

// Token: 0x02001B0D RID: 6925
public abstract class FloroRanchUnlockDataBase
{
	// Token: 0x0600CD8E RID: 52622 RVA: 0x002ED311 File Offset: 0x002EB511
	public FloroRanchUnlockDataBase(int id, bool isUnLock, int conditionId, EFloroRanchCardType type)
	{
		this.Id = id;
		this.IsUnLock = isUnLock;
		this.ConditionId = conditionId;
		this.Type = type;
	}

	// Token: 0x0600CD8F RID: 52623 RVA: 0x002ED336 File Offset: 0x002EB536
	public void UpdateInfo(bool isUnLock, int conditionId)
	{
		this.IsUnLock = isUnLock;
		this.ConditionId = conditionId;
	}

	// Token: 0x17001134 RID: 4404
	// (get) Token: 0x0600CD90 RID: 52624 RVA: 0x002ED346 File Offset: 0x002EB546
	public bool IsDefaultUnlock
	{
		get
		{
			return this.ConditionId == 0;
		}
	}

	// Token: 0x04005E46 RID: 24134
	public int Id;

	// Token: 0x04005E47 RID: 24135
	public EFloroRanchCardType Type;

	// Token: 0x04005E48 RID: 24136
	public bool IsUnLock;

	// Token: 0x04005E49 RID: 24137
	public int ConditionId;
}
