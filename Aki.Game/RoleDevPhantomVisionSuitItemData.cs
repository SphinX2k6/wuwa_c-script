using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002808 RID: 10248
[NullableContext(1)]
[Nullable(0)]
public class RoleDevPhantomVisionSuitItemData
{
	// Token: 0x17001BC2 RID: 7106
	// (get) Token: 0x06015064 RID: 86116 RVA: 0x00552D4E File Offset: 0x00550F4E
	public int Id
	{
		get
		{
			return this.IdInternal;
		}
	}

	// Token: 0x17001BC3 RID: 7107
	// (get) Token: 0x06015065 RID: 86117 RVA: 0x00552D56 File Offset: 0x00550F56
	public string Name
	{
		get
		{
			return this.NameInternal;
		}
	}

	// Token: 0x17001BC4 RID: 7108
	// (get) Token: 0x06015066 RID: 86118 RVA: 0x00552D5E File Offset: 0x00550F5E
	public int Cost
	{
		get
		{
			return this.CostInternal;
		}
	}

	// Token: 0x17001BC5 RID: 7109
	// (get) Token: 0x06015067 RID: 86119 RVA: 0x00552D66 File Offset: 0x00550F66
	public string ButtonName
	{
		get
		{
			return this.ButtonNameInternal;
		}
	}

	// Token: 0x17001BC6 RID: 7110
	// (get) Token: 0x06015068 RID: 86120 RVA: 0x00552D6E File Offset: 0x00550F6E
	public List<IPhantomMonsterItemData> MonsterDataList
	{
		get
		{
			return this.MonsterDataListInternal;
		}
	}

	// Token: 0x17001BC7 RID: 7111
	// (get) Token: 0x06015069 RID: 86121 RVA: 0x00552D76 File Offset: 0x00550F76
	public List<IDropRewardItemData> RewardDataList
	{
		get
		{
			return this.RewardDataListInternal;
		}
	}

	// Token: 0x17001BC8 RID: 7112
	// (get) Token: 0x0601506A RID: 86122 RVA: 0x00552D7E File Offset: 0x00550F7E
	public int DungeonId
	{
		get
		{
			return this.DungeonIdInternal;
		}
	}

	// Token: 0x17001BC9 RID: 7113
	// (get) Token: 0x0601506B RID: 86123 RVA: 0x00552D86 File Offset: 0x00550F86
	public int FetterGroupId
	{
		get
		{
			return this.FetterGroupIdInternal;
		}
	}

	// Token: 0x17001BCA RID: 7114
	// (get) Token: 0x0601506C RID: 86124 RVA: 0x00552D8E File Offset: 0x00550F8E
	public int RoleId
	{
		get
		{
			return this.RoleIdInternal;
		}
	}

	// Token: 0x17001BCB RID: 7115
	// (get) Token: 0x0601506D RID: 86125 RVA: 0x00552D96 File Offset: 0x00550F96
	public List<int> RecommendGroupIds
	{
		get
		{
			return this.RecommendGroupIdsInternal;
		}
	}

	// Token: 0x17001BCC RID: 7116
	// (get) Token: 0x0601506E RID: 86126 RVA: 0x00552D9E File Offset: 0x00550F9E
	public EVisionSuitItemType ItemType
	{
		get
		{
			return this.ItemTypeInternal;
		}
	}

	// Token: 0x17001BCD RID: 7117
	// (get) Token: 0x0601506F RID: 86127 RVA: 0x00552DA6 File Offset: 0x00550FA6
	public string TypeIcon
	{
		get
		{
			return this.TypeIconInternal;
		}
	}

	// Token: 0x06015070 RID: 86128 RVA: 0x00552DAE File Offset: 0x00550FAE
	public void InitByBaseData(int id, EVisionSuitItemType itemType, string name, int cost, string buttonName, string typeIcon)
	{
		this.IdInternal = id;
		this.ItemTypeInternal = itemType;
		this.NameInternal = name;
		this.CostInternal = cost;
		this.ButtonNameInternal = buttonName;
		this.TypeIconInternal = typeIcon;
	}

	// Token: 0x06015071 RID: 86129 RVA: 0x00552DDD File Offset: 0x00550FDD
	public void SetItemType(EVisionSuitItemType itemType)
	{
		this.ItemTypeInternal = itemType;
	}

	// Token: 0x06015072 RID: 86130 RVA: 0x00552DE6 File Offset: 0x00550FE6
	public void SetMonsterDataList(List<IPhantomMonsterItemData> dataList)
	{
		this.MonsterDataListInternal = new List<IPhantomMonsterItemData>(dataList);
	}

	// Token: 0x06015073 RID: 86131 RVA: 0x00552DF4 File Offset: 0x00550FF4
	public void SetRewardDataList(List<IDropRewardItemData> dataList)
	{
		this.RewardDataListInternal = new List<IDropRewardItemData>(dataList);
	}

	// Token: 0x06015074 RID: 86132 RVA: 0x00552E02 File Offset: 0x00551002
	public void AddMonsterDataItem(IPhantomMonsterItemData dataItem)
	{
		this.MonsterDataListInternal.Add(dataItem);
	}

	// Token: 0x06015075 RID: 86133 RVA: 0x00552E10 File Offset: 0x00551010
	public void AddRewardDataItem(IDropRewardItemData dataItem)
	{
		this.RewardDataListInternal.Add(dataItem);
	}

	// Token: 0x06015076 RID: 86134 RVA: 0x00552E1E File Offset: 0x0055101E
	public void SetDungeonId(int dungeonId)
	{
		this.DungeonIdInternal = dungeonId;
	}

	// Token: 0x06015077 RID: 86135 RVA: 0x00552E27 File Offset: 0x00551027
	[NullableContext(2)]
	public void SetFetterGroupInfo(int fetterGroupId, int roleId, List<int> recommendGroupIds = null)
	{
		this.FetterGroupIdInternal = fetterGroupId;
		this.RoleIdInternal = roleId;
		this.RecommendGroupIdsInternal = (recommendGroupIds ?? new List<int>());
	}

	// Token: 0x04009E0A RID: 40458
	private int IdInternal;

	// Token: 0x04009E0B RID: 40459
	private string NameInternal = "";

	// Token: 0x04009E0C RID: 40460
	private int CostInternal;

	// Token: 0x04009E0D RID: 40461
	private string ButtonNameInternal = "";

	// Token: 0x04009E0E RID: 40462
	private List<IPhantomMonsterItemData> MonsterDataListInternal = new List<IPhantomMonsterItemData>();

	// Token: 0x04009E0F RID: 40463
	private List<IDropRewardItemData> RewardDataListInternal = new List<IDropRewardItemData>();

	// Token: 0x04009E10 RID: 40464
	private int DungeonIdInternal;

	// Token: 0x04009E11 RID: 40465
	private int FetterGroupIdInternal;

	// Token: 0x04009E12 RID: 40466
	private int RoleIdInternal;

	// Token: 0x04009E13 RID: 40467
	private List<int> RecommendGroupIdsInternal = new List<int>();

	// Token: 0x04009E14 RID: 40468
	private EVisionSuitItemType ItemTypeInternal;

	// Token: 0x04009E15 RID: 40469
	private string TypeIconInternal = "";
}
