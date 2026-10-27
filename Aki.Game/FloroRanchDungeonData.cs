using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001AF4 RID: 6900
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchDungeonData
{
	// Token: 0x0600CCD3 RID: 52435 RVA: 0x002EC3F3 File Offset: 0x002EA5F3
	public FloroRanchDungeonData(FloroRanchIns config)
	{
		this.Config = config;
	}

	// Token: 0x0600CCD4 RID: 52436 RVA: 0x002EC40D File Offset: 0x002EA60D
	public void PushSubDungeonData(FloroRanchSubDungeonData subDungeonData)
	{
		this.SubDungeonDataList.Add(subDungeonData);
	}

	// Token: 0x0600CCD5 RID: 52437 RVA: 0x002EC41C File Offset: 0x002EA61C
	public void UpdateUnLockState(bool isUnLock)
	{
		this.IsUnLockInternal = isUnLock;
		foreach (FloroRanchSubDungeonData floroRanchSubDungeonData in this.SubDungeonDataList)
		{
			floroRanchSubDungeonData.IsInstanceUnlock = true;
		}
	}

	// Token: 0x170010E3 RID: 4323
	// (get) Token: 0x0600CCD6 RID: 52438 RVA: 0x002EC474 File Offset: 0x002EA674
	public bool IsUnLock
	{
		get
		{
			return this.IsUnLockInternal;
		}
	}

	// Token: 0x170010E4 RID: 4324
	// (get) Token: 0x0600CCD8 RID: 52440 RVA: 0x002EC485 File Offset: 0x002EA685
	// (set) Token: 0x0600CCD7 RID: 52439 RVA: 0x002EC47C File Offset: 0x002EA67C
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

	// Token: 0x170010E5 RID: 4325
	// (get) Token: 0x0600CCD9 RID: 52441 RVA: 0x002EC490 File Offset: 0x002EA690
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x170010E6 RID: 4326
	// (get) Token: 0x0600CCDA RID: 52442 RVA: 0x002EC4AC File Offset: 0x002EA6AC
	public int SortId
	{
		get
		{
			return this.Config.SortId;
		}
	}

	// Token: 0x170010E7 RID: 4327
	// (get) Token: 0x0600CCDB RID: 52443 RVA: 0x002EC4C8 File Offset: 0x002EA6C8
	public int DelayTime
	{
		get
		{
			return this.Config.DelayTime;
		}
	}

	// Token: 0x0600CCDC RID: 52444 RVA: 0x002EC4E4 File Offset: 0x002EA6E4
	public string GetDungeonName()
	{
		return this.Config.Name;
	}

	// Token: 0x0600CCDD RID: 52445 RVA: 0x002EC4FF File Offset: 0x002EA6FF
	public List<FloroRanchSubDungeonData> GetSubDungeonData()
	{
		return this.SubDungeonDataList;
	}

	// Token: 0x0600CCDE RID: 52446 RVA: 0x002EC508 File Offset: 0x002EA708
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

	// Token: 0x170010E8 RID: 4328
	// (get) Token: 0x0600CCDF RID: 52447 RVA: 0x002EC574 File Offset: 0x002EA774
	public bool IsDifficulty
	{
		get
		{
			return this.Config.Difficulty == 1;
		}
	}

	// Token: 0x170010E9 RID: 4329
	// (get) Token: 0x0600CCE0 RID: 52448 RVA: 0x002EC594 File Offset: 0x002EA794
	public string RomeNumIcon
	{
		get
		{
			return this.Config.RomeIconPath;
		}
	}

	// Token: 0x170010EA RID: 4330
	// (get) Token: 0x0600CCE1 RID: 52449 RVA: 0x002EC5B0 File Offset: 0x002EA7B0
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

	// Token: 0x04005E03 RID: 24067
	private readonly FloroRanchIns Config;

	// Token: 0x04005E04 RID: 24068
	private readonly List<FloroRanchSubDungeonData> SubDungeonDataList = new List<FloroRanchSubDungeonData>();

	// Token: 0x04005E05 RID: 24069
	private bool IsUnLockInternal;

	// Token: 0x04005E06 RID: 24070
	private int ConditionIdInternal;
}
