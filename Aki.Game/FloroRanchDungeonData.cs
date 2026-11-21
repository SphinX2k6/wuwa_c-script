using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000FB3 RID: 4019
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchDungeonData
{
	// Token: 0x0600A0E4 RID: 41188 RVA: 0x002F74DF File Offset: 0x002F56DF
	public FloroRanchDungeonData(FloroRanchIns config)
	{
		this.Config = config;
	}

	// Token: 0x0600A0E5 RID: 41189 RVA: 0x002F74F9 File Offset: 0x002F56F9
	public void PushSubDungeonData(FloroRanchSubDungeonData subDungeonData)
	{
		this.SubDungeonDataList.Add(subDungeonData);
	}

	// Token: 0x0600A0E6 RID: 41190 RVA: 0x002F7508 File Offset: 0x002F5708
	public void UpdateUnLockState(bool isUnLock)
	{
		this.IsUnLockInternal = isUnLock;
		foreach (FloroRanchSubDungeonData floroRanchSubDungeonData in this.SubDungeonDataList)
		{
			floroRanchSubDungeonData.IsInstanceUnlock = true;
		}
	}

	// Token: 0x17001108 RID: 4360
	// (get) Token: 0x0600A0E7 RID: 41191 RVA: 0x002F7560 File Offset: 0x002F5760
	public bool IsUnLock
	{
		get
		{
			return this.IsUnLockInternal;
		}
	}

	// Token: 0x17001109 RID: 4361
	// (get) Token: 0x0600A0E9 RID: 41193 RVA: 0x002F7571 File Offset: 0x002F5771
	// (set) Token: 0x0600A0E8 RID: 41192 RVA: 0x002F7568 File Offset: 0x002F5768
	public int ConditionId
	{
		get
		{
			return this.ConditionIdInternal;
		}
		set
		{
			this.ConditionIdInternal = value;
		}
	}

	// Token: 0x1700110A RID: 4362
	// (get) Token: 0x0600A0EA RID: 41194 RVA: 0x002F757C File Offset: 0x002F577C
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x1700110B RID: 4363
	// (get) Token: 0x0600A0EB RID: 41195 RVA: 0x002F7598 File Offset: 0x002F5798
	public int SortId
	{
		get
		{
			return this.Config.SortId;
		}
	}

	// Token: 0x1700110C RID: 4364
	// (get) Token: 0x0600A0EC RID: 41196 RVA: 0x002F75B4 File Offset: 0x002F57B4
	public int DelayTime
	{
		get
		{
			return this.Config.DelayTime;
		}
	}

	// Token: 0x0600A0ED RID: 41197 RVA: 0x002F75D0 File Offset: 0x002F57D0
	public string GetDungeonName()
	{
		return this.Config.Name;
	}

	// Token: 0x0600A0EE RID: 41198 RVA: 0x002F75EB File Offset: 0x002F57EB
	public List<FloroRanchSubDungeonData> GetSubDungeonData()
	{
		return this.SubDungeonDataList;
	}

	// Token: 0x0600A0EF RID: 41199 RVA: 0x002F75F4 File Offset: 0x002F57F4
	public FloroRanchSubDungeonData GetLatestSubDungeonData()
	{
		FloroRanchSubDungeonData result = this.SubDungeonDataList[0];
		foreach (FloroRanchSubDungeonData floroRanchSubDungeonData in this.SubDungeonDataList)
		{
			if (!floroRanchSubDungeonData.IsUnLock)
			{
				return result;
			}
			result = floroRanchSubDungeonData;
		}
		return result;
	}

	// Token: 0x1700110D RID: 4365
	// (get) Token: 0x0600A0F0 RID: 41200 RVA: 0x002F7660 File Offset: 0x002F5860
	public bool IsDifficulty
	{
		get
		{
			return this.Config.Difficulty == 1;
		}
	}

	// Token: 0x1700110E RID: 4366
	// (get) Token: 0x0600A0F1 RID: 41201 RVA: 0x002F7680 File Offset: 0x002F5880
	public string RomeNumIcon
	{
		get
		{
			return this.Config.RomeIconPath;
		}
	}

	// Token: 0x1700110F RID: 4367
	// (get) Token: 0x0600A0F2 RID: 41202 RVA: 0x002F769C File Offset: 0x002F589C
	public bool HasRedDot
	{
		get
		{
			if (!this.IsUnLock)
			{
				return false;
			}
			using (List<FloroRanchSubDungeonData>.Enumerator enumerator = this.SubDungeonDataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.HasRedDot)
					{
						return true;
					}
				}
			}
			return false;
		}
	}

	// Token: 0x04005ED2 RID: 24274
	private readonly FloroRanchIns Config;

	// Token: 0x04005ED3 RID: 24275
	private readonly List<FloroRanchSubDungeonData> SubDungeonDataList = new List<FloroRanchSubDungeonData>();

	// Token: 0x04005ED4 RID: 24276
	private bool IsUnLockInternal;

	// Token: 0x04005ED5 RID: 24277
	private int ConditionIdInternal;
}
