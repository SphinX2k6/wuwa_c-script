using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.HonamiStory.Data;

// Token: 0x02001E73 RID: 7795
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryPlayerBackpackData
{
	// Token: 0x0600ED7D RID: 60797 RVA: 0x00388F04 File Offset: 0x00387104
	public void Init(HonamiStoryPlayerBagInfo bagInfo)
	{
		if (bagInfo.EquipRack == null)
		{
			Log.Instance.Error(ELogModule.HonamiStory, ELogAuthor.BB, "Proto_EquipRack is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.Config = HonamiStoryConfig.Instance.GetHonamiStoryBackPack(bagInfo.EquipRack.BagConfigId);
		this.InitRoleEquipDataList();
		this.RefreshEquipInfo(bagInfo.HonamiStoryRackInfos.ToList<HonamiStoryRackInfo>());
		this.RefreshGridItemInfo(bagInfo.EquipRack.HonamiStoryBagItemInfos.ToList<HonamiStoryBagItemInfo>());
	}

	// Token: 0x0600ED7E RID: 60798 RVA: 0x00388F84 File Offset: 0x00387184
	private void InitRoleEquipDataList()
	{
		this.RoleEquipDataList.Clear();
		for (int i = 0; i < 3; i++)
		{
			this.RoleEquipDataList.Add(new HonamiStoryRoleEquipData(i));
		}
	}

	// Token: 0x0600ED7F RID: 60799 RVA: 0x00388FBC File Offset: 0x003871BC
	public void RefreshEquipInfo(List<HonamiStoryRackInfo> roleInfo)
	{
		for (int i = 0; i < roleInfo.Count; i++)
		{
			this.RoleEquipDataList[i].SetEquipData(roleInfo[i]);
		}
		if (roleInfo.Count < this.RoleEquipDataList.Count)
		{
			for (int j = roleInfo.Count; j < this.RoleEquipDataList.Count; j++)
			{
				this.RoleEquipDataList[j].SetEquipData(null);
			}
		}
		this.UpdateAllRoleSlots();
	}

	// Token: 0x0600ED80 RID: 60800 RVA: 0x00389038 File Offset: 0x00387238
	public void RefreshRoleInfo(List<int> roleInfo)
	{
		for (int i = 0; i < roleInfo.Count; i++)
		{
			this.RefreshRoleInfoByPosition(roleInfo[i], i);
		}
		if (roleInfo.Count < this.RoleEquipDataList.Count)
		{
			for (int j = roleInfo.Count; j < this.RoleEquipDataList.Count; j++)
			{
				this.RefreshRoleInfoByPosition(0, j);
			}
		}
		this.UpdateAllRoleSlots();
	}

	// Token: 0x0600ED81 RID: 60801 RVA: 0x003890A0 File Offset: 0x003872A0
	public void RefreshRoleInfoByPosition(int roleId, int position)
	{
		if (position < 0 || position >= this.RoleEquipDataList.Count)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "RefreshRoleInfoByPosition 无效position";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("position", position);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.RoleEquipDataList[position].SetRoleInfo(roleId);
		this.UpdateAllRoleSlots();
	}

	// Token: 0x0600ED82 RID: 60802 RVA: 0x00389108 File Offset: 0x00387308
	public void RefreshWeaponInfoByPosition(int weaponId, int position)
	{
		HonamiStoryRoleEquipData roleEquipDataByPosition = this.GetRoleEquipDataByPosition(position);
		if (roleEquipDataByPosition == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "RefreshWeaponInfoByPosition 无效position";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("position", position);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		roleEquipDataByPosition.SetWeaponInfo(weaponId);
		this.UpdateAllRoleSlots();
	}

	// Token: 0x0600ED83 RID: 60803 RVA: 0x00389160 File Offset: 0x00387360
	public unsafe void RefreshGridItemInfo(List<HonamiStoryBagItemInfo> itemInfoList)
	{
		HashSet<int> hashSet = new HashSet<int>();
		foreach (HonamiStoryBagItemInfo honamiStoryBagItemInfo in itemInfoList)
		{
			HonamiStoryEquipItemData honamiStoryEquipItemData = HonamiStoryModel.Instance.CreateHonamiStoryItemData(honamiStoryBagItemInfo.HonamiStoryItemInfo, honamiStoryBagItemInfo.HonamiStoryPosInfo) as HonamiStoryEquipItemData;
			if (honamiStoryEquipItemData == null || honamiStoryEquipItemData.GetItemType() == EHonamiStoryItemType.Normal)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.HonamiStory;
				ELogAuthor author = ELogAuthor.BB;
				string message = "Invalid EquipItemType";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("itemId", (honamiStoryEquipItemData != null) ? honamiStoryEquipItemData.GetItemId() : 0);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("itemType", (honamiStoryEquipItemData != null) ? honamiStoryEquipItemData.GetItemType() : EHonamiStoryItemType.Normal);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			else
			{
				hashSet.Add(honamiStoryEquipItemData.GetPosition());
				HonamiStoryEquipItemData honamiStoryEquipItemData2;
				if (!this.GridItemMap.TryGetValue(honamiStoryEquipItemData.GetPosition(), out honamiStoryEquipItemData2) || honamiStoryEquipItemData2 == null || honamiStoryEquipItemData2.GetIncId() != honamiStoryEquipItemData.GetIncId())
				{
					this.SetRoleItemData(honamiStoryEquipItemData);
					this.GridItemMap[honamiStoryEquipItemData.GetPosition()] = honamiStoryEquipItemData;
				}
			}
		}
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, HonamiStoryEquipItemData> keyValuePair in this.GridItemMap)
		{
			if (!hashSet.Contains(keyValuePair.Key))
			{
				list.Add(keyValuePair.Key);
			}
		}
		foreach (int num in list)
		{
			this.GridItemMap.Remove(num);
			this.RemoveRoleItemData(num);
		}
		this.UpdateAllRoleSlots();
	}

	// Token: 0x0600ED84 RID: 60804 RVA: 0x00389388 File Offset: 0x00387588
	public void UpdateByContext(List<HonamiStoryBagUpdateInfo> updateInfoList)
	{
		foreach (HonamiStoryBagUpdateInfo honamiStoryBagUpdateInfo in updateInfoList)
		{
			if (honamiStoryBagUpdateInfo.Type != 0)
			{
				this.RemoveItemData(honamiStoryBagUpdateInfo);
			}
		}
		foreach (HonamiStoryBagUpdateInfo honamiStoryBagUpdateInfo2 in updateInfoList)
		{
			if (honamiStoryBagUpdateInfo2.Type != 2)
			{
				this.AddItemData(honamiStoryBagUpdateInfo2);
			}
		}
		this.UpdateAllRoleSlots();
	}

	// Token: 0x0600ED85 RID: 60805 RVA: 0x0038942C File Offset: 0x0038762C
	private void AddItemData(HonamiStoryBagUpdateInfo updateInfo)
	{
		HonamiStoryEquipItemData honamiStoryEquipItemData = HonamiStoryModel.Instance.GetItemData(updateInfo.ItemIncrId) as HonamiStoryEquipItemData;
		honamiStoryEquipItemData.UpdatePositionInfo(updateInfo.HonamiStoryPosInfo);
		this.GridItemMap[honamiStoryEquipItemData.GetPosition()] = honamiStoryEquipItemData;
		this.SetRoleItemData(honamiStoryEquipItemData);
	}

	// Token: 0x0600ED86 RID: 60806 RVA: 0x00389474 File Offset: 0x00387674
	private void RemoveItemData(HonamiStoryBagUpdateInfo updateInfo)
	{
		int position = updateInfo.OriHonamiStoryPosInfo.Position;
		this.GridItemMap.Remove(position);
		this.RemoveRoleItemData(position);
	}

	// Token: 0x0600ED87 RID: 60807 RVA: 0x003894A4 File Offset: 0x003876A4
	public void SetRoleItemData(HonamiStoryEquipItemData itemData)
	{
		int position = itemData.GetPosition();
		this.GetRoleItemDataByPosition(position).SetItemData(position, itemData);
	}

	// Token: 0x0600ED88 RID: 60808 RVA: 0x003894C6 File Offset: 0x003876C6
	public void RemoveRoleItemData(int position)
	{
		this.GetRoleItemDataByPosition(position).RemoveItemData(position);
	}

	// Token: 0x170012BD RID: 4797
	// (get) Token: 0x0600ED89 RID: 60809 RVA: 0x003894D8 File Offset: 0x003876D8
	public int BackpackId
	{
		get
		{
			return this.Config.Value.Id;
		}
	}

	// Token: 0x0600ED8A RID: 60810 RVA: 0x003894F8 File Offset: 0x003876F8
	public EHonamiStoryBackpackType GetBackpackType()
	{
		return (EHonamiStoryBackpackType)this.Config.Value.Type;
	}

	// Token: 0x0600ED8B RID: 60811 RVA: 0x00389518 File Offset: 0x00387718
	public List<HonamiStoryRoleEquipData> GetRoleEquipDataList(bool needUnlock = true)
	{
		List<HonamiStoryRoleEquipData> list = new List<HonamiStoryRoleEquipData>();
		int activityId = HonamiStoryModel.Instance.ActivityId;
		HonamiStoryActivity? honamiStoryActivityConfig = HonamiStoryConfig.Instance.GetHonamiStoryActivityConfig(activityId);
		bool flag = FunctionModel.Instance.IsOpen(honamiStoryActivityConfig.Value.EquipRoleFuncId);
		if (!needUnlock || flag)
		{
			return this.RoleEquipDataList;
		}
		foreach (HonamiStoryRoleEquipData honamiStoryRoleEquipData in this.RoleEquipDataList)
		{
			if (honamiStoryRoleEquipData.GetRoleId() != 0)
			{
				list.Add(honamiStoryRoleEquipData);
			}
		}
		return list;
	}

	// Token: 0x0600ED8C RID: 60812 RVA: 0x003895C0 File Offset: 0x003877C0
	[NullableContext(2)]
	public HonamiStoryRoleEquipData GetRoleItemDataByPosition(int position)
	{
		int num = (int)Math.Floor((double)position / 100.0) - 1;
		if (num < 0 || num >= this.RoleEquipDataList.Count)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.BB;
			string message = "HonamiStoryPlayerBackpackData Invalid position";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("position", position);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return this.RoleEquipDataList[num];
	}

	// Token: 0x0600ED8D RID: 60813 RVA: 0x00389634 File Offset: 0x00387834
	[NullableContext(2)]
	public HonamiStoryRoleEquipData GetRoleEquipDataByPosition(int position)
	{
		foreach (HonamiStoryRoleEquipData honamiStoryRoleEquipData in this.RoleEquipDataList)
		{
			if (honamiStoryRoleEquipData.GetPosition() == position)
			{
				return honamiStoryRoleEquipData;
			}
		}
		return null;
	}

	// Token: 0x0600ED8E RID: 60814 RVA: 0x00389690 File Offset: 0x00387890
	[NullableContext(2)]
	public HonamiStoryRoleEquipData GetRoleEquipDataByRoleId(int roleId)
	{
		foreach (HonamiStoryRoleEquipData honamiStoryRoleEquipData in this.RoleEquipDataList)
		{
			if (honamiStoryRoleEquipData.GetRoleId() == roleId)
			{
				return honamiStoryRoleEquipData;
			}
		}
		return null;
	}

	// Token: 0x0600ED8F RID: 60815 RVA: 0x003896EC File Offset: 0x003878EC
	public int GetPowerLevel(bool isForShow)
	{
		int num = 0;
		foreach (HonamiStoryRoleEquipData honamiStoryRoleEquipData in this.RoleEquipDataList)
		{
			num += honamiStoryRoleEquipData.GetCurPowerLevel(isForShow);
		}
		return num;
	}

	// Token: 0x0600ED90 RID: 60816 RVA: 0x00389748 File Offset: 0x00387948
	public void UpdateAllRoleSlots()
	{
		HonamiStoryPlayerData playerData = HonamiStoryModel.Instance.GetPlayerData();
		int powerLevel = playerData.PowerLevel;
		playerData.UpdatePowerLevel();
		if (powerLevel != playerData.PowerLevel)
		{
			EventSystem.Instance.Emit<int, int>(EEventName.OnHonamiStoryPowerLevelUpdate, powerLevel, playerData.PowerLevel);
		}
	}

	// Token: 0x0600ED91 RID: 60817 RVA: 0x0038978D File Offset: 0x0038798D
	public int GetCellWidth()
	{
		if (HonamiStoryUtil.IsMobileView())
		{
			return 134;
		}
		return 86;
	}

	// Token: 0x0600ED92 RID: 60818 RVA: 0x0038979E File Offset: 0x0038799E
	public int GetCellHeight()
	{
		if (HonamiStoryUtil.IsMobileView())
		{
			return 134;
		}
		return 86;
	}

	// Token: 0x0600ED93 RID: 60819 RVA: 0x003897AF File Offset: 0x003879AF
	public int GetCellHorizontalInterval()
	{
		return 2;
	}

	// Token: 0x0600ED94 RID: 60820 RVA: 0x003897B2 File Offset: 0x003879B2
	public int GetCellVerticalInterval()
	{
		return 2;
	}

	// Token: 0x0600ED95 RID: 60821 RVA: 0x003897B8 File Offset: 0x003879B8
	public bool CheckItemByIncId(int incId)
	{
		foreach (HonamiStoryRoleEquipData honamiStoryRoleEquipData in this.RoleEquipDataList)
		{
			foreach (HonamiStoryEquipItemData honamiStoryEquipItemData in honamiStoryRoleEquipData.GetEquipItemDataList())
			{
				if (incId == honamiStoryEquipItemData.GetIncId())
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x04006E3C RID: 28220
	private readonly List<HonamiStoryRoleEquipData> RoleEquipDataList = new List<HonamiStoryRoleEquipData>();

	// Token: 0x04006E3D RID: 28221
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly Dictionary<int, HonamiStoryEquipItemData> GridItemMap = new Dictionary<int, HonamiStoryEquipItemData>();

	// Token: 0x04006E3E RID: 28222
	protected HonamiStoryBackPack? Config;
}
