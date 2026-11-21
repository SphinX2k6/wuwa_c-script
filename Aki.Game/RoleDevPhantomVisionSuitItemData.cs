using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001D83 RID: 7555
[NullableContext(1)]
[Nullable(0)]
public class RoleDevPhantomVisionSuitItemData
{
	// Token: 0x17001C1A RID: 7194
	// (get) Token: 0x06012A64 RID: 76388 RVA: 0x0057DB22 File Offset: 0x0057BD22
	public int Id
	{
		get
		{
			return this.IdInternal;
		}
	}

	// Token: 0x17001C1B RID: 7195
	// (get) Token: 0x06012A65 RID: 76389 RVA: 0x0057DB2A File Offset: 0x0057BD2A
	public string Name
	{
		get
		{
			return this.NameInternal;
		}
	}

	// Token: 0x17001C1C RID: 7196
	// (get) Token: 0x06012A66 RID: 76390 RVA: 0x0057DB32 File Offset: 0x0057BD32
	public int Cost
	{
		get
		{
			return this.CostInternal;
		}
	}

	// Token: 0x17001C1D RID: 7197
	// (get) Token: 0x06012A67 RID: 76391 RVA: 0x0057DB3A File Offset: 0x0057BD3A
	public string ButtonName
	{
		get
		{
			return this.ButtonNameInternal;
		}
	}

	// Token: 0x17001C1E RID: 7198
	// (get) Token: 0x06012A68 RID: 76392 RVA: 0x0057DB42 File Offset: 0x0057BD42
	public List<IPhantomMonsterItemData> MonsterDataList
	{
		get
		{
			return this.MonsterDataListInternal;
		}
	}

	// Token: 0x17001C1F RID: 7199
	// (get) Token: 0x06012A69 RID: 76393 RVA: 0x0057DB4A File Offset: 0x0057BD4A
	public List<IDropRewardItemData> RewardDataList
	{
		get
		{
			return this.RewardDataListInternal;
		}
	}

	// Token: 0x17001C20 RID: 7200
	// (get) Token: 0x06012A6A RID: 76394 RVA: 0x0057DB52 File Offset: 0x0057BD52
	public int DungeonId
	{
		get
		{
			return this.DungeonIdInternal;
		}
	}

	// Token: 0x17001C21 RID: 7201
	// (get) Token: 0x06012A6B RID: 76395 RVA: 0x0057DB5A File Offset: 0x0057BD5A
	public int FetterGroupId
	{
		get
		{
			return this.FetterGroupIdInternal;
		}
	}

	// Token: 0x17001C22 RID: 7202
	// (get) Token: 0x06012A6C RID: 76396 RVA: 0x0057DB62 File Offset: 0x0057BD62
	public int RoleId
	{
		get
		{
			return this.RoleIdInternal;
		}
	}

	// Token: 0x17001C23 RID: 7203
	// (get) Token: 0x06012A6D RID: 76397 RVA: 0x0057DB6A File Offset: 0x0057BD6A
	public List<int> RecommendGroupIds
	{
		get
		{
			return this.RecommendGroupIdsInternal;
		}
	}

	// Token: 0x17001C24 RID: 7204
	// (get) Token: 0x06012A6E RID: 76398 RVA: 0x0057DB72 File Offset: 0x0057BD72
	public EVisionSuitItemType ItemType
	{
		get
		{
			return this.ItemTypeInternal;
		}
	}

	// Token: 0x17001C25 RID: 7205
	// (get) Token: 0x06012A6F RID: 76399 RVA: 0x0057DB7A File Offset: 0x0057BD7A
	public string TypeIcon
	{
		get
		{
			return this.TypeIconInternal;
		}
	}

	// Token: 0x06012A70 RID: 76400 RVA: 0x0057DB82 File Offset: 0x0057BD82
	public void InitByBaseData(int id, EVisionSuitItemType itemType, string name, int cost, string buttonName, string typeIcon)
	{
		this.IdInternal = id;
		this.ItemTypeInternal = itemType;
		this.NameInternal = name;
		this.CostInternal = cost;
		this.ButtonNameInternal = buttonName;
		this.TypeIconInternal = typeIcon;
	}

	// Token: 0x06012A71 RID: 76401 RVA: 0x0057DBB1 File Offset: 0x0057BDB1
	public void SetItemType(EVisionSuitItemType itemType)
	{
		this.ItemTypeInternal = itemType;
	}

	// Token: 0x06012A72 RID: 76402 RVA: 0x0057DBBA File Offset: 0x0057BDBA
	public void SetMonsterDataList(List<IPhantomMonsterItemData> dataList)
	{
		this.MonsterDataListInternal = new List<IPhantomMonsterItemData>(dataList);
	}

	// Token: 0x06012A73 RID: 76403 RVA: 0x0057DBC8 File Offset: 0x0057BDC8
	public void SetRewardDataList(List<IDropRewardItemData> dataList)
	{
		this.RewardDataListInternal = new List<IDropRewardItemData>(dataList);
	}

	// Token: 0x06012A74 RID: 76404 RVA: 0x0057DBD6 File Offset: 0x0057BDD6
	public void AddMonsterDataItem(IPhantomMonsterItemData dataItem)
	{
		this.MonsterDataListInternal.Add(dataItem);
	}

	// Token: 0x06012A75 RID: 76405 RVA: 0x0057DBE4 File Offset: 0x0057BDE4
	public void AddRewardDataItem(IDropRewardItemData dataItem)
	{
		this.RewardDataListInternal.Add(dataItem);
	}

	// Token: 0x06012A76 RID: 76406 RVA: 0x0057DBF2 File Offset: 0x0057BDF2
	public void SetDungeonId(int dungeonId)
	{
		this.DungeonIdInternal = dungeonId;
	}

	// Token: 0x06012A77 RID: 76407 RVA: 0x0057DBFB File Offset: 0x0057BDFB
	[NullableContext(2)]
	public void SetFetterGroupInfo(int fetterGroupId, int roleId, List<int> recommendGroupIds = null)
	{
		this.FetterGroupIdInternal = fetterGroupId;
		this.RoleIdInternal = roleId;
		this.RecommendGroupIdsInternal = (recommendGroupIds ?? new List<int>());
	}

	// Token: 0x0400A1F3 RID: 41459
	private int IdInternal;

	// Token: 0x0400A1F4 RID: 41460
	private string NameInternal = "";

	// Token: 0x0400A1F5 RID: 41461
	private int CostInternal;

	// Token: 0x0400A1F6 RID: 41462
	private string ButtonNameInternal = "";

	// Token: 0x0400A1F7 RID: 41463
	private List<IPhantomMonsterItemData> MonsterDataListInternal = new List<IPhantomMonsterItemData>();

	// Token: 0x0400A1F8 RID: 41464
	private List<IDropRewardItemData> RewardDataListInternal = new List<IDropRewardItemData>();

	// Token: 0x0400A1F9 RID: 41465
	private int DungeonIdInternal;

	// Token: 0x0400A1FA RID: 41466
	private int FetterGroupIdInternal;

	// Token: 0x0400A1FB RID: 41467
	private int RoleIdInternal;

	// Token: 0x0400A1FC RID: 41468
	private List<int> RecommendGroupIdsInternal = new List<int>();

	// Token: 0x0400A1FD RID: 41469
	private EVisionSuitItemType ItemTypeInternal;

	// Token: 0x0400A1FE RID: 41470
	private string TypeIconInternal = "";
}
