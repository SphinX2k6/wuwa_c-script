using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.HonamiStory.Data;

// Token: 0x02001335 RID: 4917
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryPlayerBackpackData
{
	// Token: 0x0600C19C RID: 49564 RVA: 0x00394B10 File Offset: 0x00392D10
	public void Init(HonamiStoryPlayerBagInfo bagInfo)
	{
		if (bagInfo.EquipRack == null)
		{
			Log.Instance.Error(ELogModule.HonamiStory, ELogAuthor.BB, "Proto_EquipRack is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.Config = HonamiStoryConfig.Instance.GetHonamiStoryBackPack(bagInfo.EquipRack.BagConfigId);
		this.InitRoleEquipDataList();
		this.RefreshEquipInfo(bagInfo.HonamiStoryRackInfos);
		this.RefreshGridItemInfo(bagInfo.EquipRack.HonamiStoryBagItemInfos);
	}

	// Token: 0x0600C19D RID: 49565 RVA: 0x00394B84 File Offset: 0x00392D84
	private void InitRoleEquipDataList()
	{
		this.RoleEquipDataList.Clear();
		for (int i = 0; i < 3; i++)
		{
			this.RoleEquipDataList.Add(new HonamiStoryRoleEquipData(i));
		}
	}

	// Token: 0x0600C19E RID: 49566 RVA: 0x00394BBC File Offset: 0x00392DBC
	public void RefreshEquipInfo(IReadOnlyList<HonamiStoryRackInfo> roleInfo)
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

	// Token: 0x0600C19F RID: 49567 RVA: 0x00394C38 File Offset: 0x00392E38
	public void RefreshRoleInfo(IReadOnlyList<int> roleInfo)
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

	// Token: 0x0600C1A0 RID: 49568 RVA: 0x00394CA0 File Offset: 0x00392EA0
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

	// Token: 0x0600C1A1 RID: 49569 RVA: 0x00394D08 File Offset: 0x00392F08
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

	// Token: 0x0600C1A2 RID: 49570 RVA: 0x00394D60 File Offset: 0x00392F60
	public unsafe void RefreshGridItemInfo(IEnumerable<HonamiStoryBagItemInfo> itemInfoList)
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

	// Token: 0x0600C1A3 RID: 49571 RVA: 0x00394F84 File Offset: 0x00393184
	public void UpdateByContext(IEnumerable<HonamiStoryBagUpdateInfo> updateInfoList)
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

	// Token: 0x0600C1A4 RID: 49572 RVA: 0x0039501C File Offset: 0x0039321C
	private void AddItemData(HonamiStoryBagUpdateInfo updateInfo)
	{
		HonamiStoryEquipItemData honamiStoryEquipItemData = HonamiStoryModel.Instance.GetItemData(updateInfo.ItemIncrId) as HonamiStoryEquipItemData;
		honamiStoryEquipItemData.UpdatePositionInfo(updateInfo.HonamiStoryPosInfo);
		this.GridItemMap[honamiStoryEquipItemData.GetPosition()] = honamiStoryEquipItemData;
		this.SetRoleItemData(honamiStoryEquipItemData);
	}

	// Token: 0x0600C1A5 RID: 49573 RVA: 0x00395064 File Offset: 0x00393264
	private void RemoveItemData(HonamiStoryBagUpdateInfo updateInfo)
	{
		int position = updateInfo.OriHonamiStoryPosInfo.Position;
		this.GridItemMap.Remove(position);
		this.RemoveRoleItemData(position);
	}

	// Token: 0x0600C1A6 RID: 49574 RVA: 0x00395094 File Offset: 0x00393294
	public void SetRoleItemData(HonamiStoryEquipItemData itemData)
	{
		int position = itemData.GetPosition();
		this.GetRoleItemDataByPosition(position).SetItemData(position, itemData);
	}

	// Token: 0x0600C1A7 RID: 49575 RVA: 0x003950B6 File Offset: 0x003932B6
	public void RemoveRoleItemData(int position)
	{
		this.GetRoleItemDataByPosition(position).RemoveItemData(position);
	}

	// Token: 0x170012E7 RID: 4839
	// (get) Token: 0x0600C1A8 RID: 49576 RVA: 0x003950C8 File Offset: 0x003932C8
	public int BackpackId
	{
		get
		{
			return this.Config.Value.Id;
		}
	}

	// Token: 0x0600C1A9 RID: 49577 RVA: 0x003950E8 File Offset: 0x003932E8
	public EHonamiStoryBackpackType GetBackpackType()
	{
		return (EHonamiStoryBackpackType)this.Config.Value.Type;
	}

	// Token: 0x0600C1AA RID: 49578 RVA: 0x00395108 File Offset: 0x00393308
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

	// Token: 0x0600C1AB RID: 49579 RVA: 0x003951B0 File Offset: 0x003933B0
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

	// Token: 0x0600C1AC RID: 49580 RVA: 0x00395224 File Offset: 0x00393424
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

	// Token: 0x0600C1AD RID: 49581 RVA: 0x00395280 File Offset: 0x00393480
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

	// Token: 0x0600C1AE RID: 49582 RVA: 0x003952DC File Offset: 0x003934DC
	public int GetPowerLevel(bool isForShow)
	{
		int num = 0;
		foreach (HonamiStoryRoleEquipData honamiStoryRoleEquipData in this.RoleEquipDataList)
		{
			num += honamiStoryRoleEquipData.GetCurPowerLevel(isForShow);
		}
		return num;
	}

	// Token: 0x0600C1AF RID: 49583 RVA: 0x00395338 File Offset: 0x00393538
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

	// Token: 0x0600C1B0 RID: 49584 RVA: 0x0039537D File Offset: 0x0039357D
	public int GetCellWidth()
	{
		if (HonamiStoryUtil.IsMobileView())
		{
			return 134;
		}
		return 86;
	}

	// Token: 0x0600C1B1 RID: 49585 RVA: 0x0039538E File Offset: 0x0039358E
	public int GetCellHeight()
	{
		if (HonamiStoryUtil.IsMobileView())
		{
			return 134;
		}
		return 86;
	}

	// Token: 0x0600C1B2 RID: 49586 RVA: 0x0039539F File Offset: 0x0039359F
	public int GetCellHorizontalInterval()
	{
		return 2;
	}

	// Token: 0x0600C1B3 RID: 49587 RVA: 0x003953A2 File Offset: 0x003935A2
	public int GetCellVerticalInterval()
	{
		return 2;
	}

	// Token: 0x0600C1B4 RID: 49588 RVA: 0x003953A8 File Offset: 0x003935A8
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

	// Token: 0x04006F1D RID: 28445
	private readonly List<HonamiStoryRoleEquipData> RoleEquipDataList = new List<HonamiStoryRoleEquipData>();

	// Token: 0x04006F1E RID: 28446
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly Dictionary<int, HonamiStoryEquipItemData> GridItemMap = new Dictionary<int, HonamiStoryEquipItemData>();

	// Token: 0x04006F1F RID: 28447
	protected HonamiStoryBackPack? Config;
}
