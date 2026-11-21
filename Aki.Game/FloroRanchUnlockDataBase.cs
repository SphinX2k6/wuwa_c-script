using System;

// Token: 0x02000FCC RID: 4044
public abstract class FloroRanchUnlockDataBase
{
	// Token: 0x0600A19F RID: 41375 RVA: 0x002F83FD File Offset: 0x002F65FD
	public FloroRanchUnlockDataBase(int id, bool isUnLock, int conditionId, EFloroRanchCardType type)
	{
		this.Id = id;
		this.IsUnLock = isUnLock;
		this.ConditionId = conditionId;
		this.Type = type;
	}

	// Token: 0x0600A1A0 RID: 41376 RVA: 0x002F8422 File Offset: 0x002F6622
	public void UpdateInfo(bool isUnLock, int conditionId)
	{
		this.IsUnLock = isUnLock;
		this.ConditionId = conditionId;
	}

	// Token: 0x17001159 RID: 4441
	// (get) Token: 0x0600A1A1 RID: 41377 RVA: 0x002F8432 File Offset: 0x002F6632
	public bool IsDefaultUnlock
	{
		get
		{
			return this.ConditionId == 0;
		}
	}

	// Token: 0x04005F15 RID: 24341
	public int Id;

	// Token: 0x04005F16 RID: 24342
	public EFloroRanchCardType Type;

	// Token: 0x04005F17 RID: 24343
	public bool IsUnLock;

	// Token: 0x04005F18 RID: 24344
	public int ConditionId;
}
