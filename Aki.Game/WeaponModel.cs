using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleUi;
using Google.Protobuf.Collections;
using UnrealEngine;

// Token: 0x02002275 RID: 8821
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class WeaponModel : ModelBase
{
	// Token: 0x06015CE5 RID: 89317 RVA: 0x00652768 File Offset: 0x00650968
	public unsafe void AddWeaponData(WeaponItem weaponItem)
	{
		WeaponInstance weaponInstance = this.CreateWeaponInstance(weaponItem);
		int? incId = weaponInstance.GetIncId();
		this.WeaponDataMap[incId.Value] = weaponInstance;
		if (weaponInstance.HasRole())
		{
			int roleId = weaponInstance.GetRoleId();
			this.RoleWeaponDataMap[roleId] = incId.Value;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "武器设置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("roleId", roleId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("incId", incId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
	}

	// Token: 0x06015CE6 RID: 89318 RVA: 0x00652818 File Offset: 0x00650A18
	public void RemoveWeaponData(int incId)
	{
		WeaponInstance weaponInstance;
		if (!this.WeaponDataMap.TryGetValue(incId, out weaponInstance))
		{
			return;
		}
		if (weaponInstance.HasRole())
		{
			int roleId = weaponInstance.GetRoleId();
			this.RoleWeaponDataMap.Remove(roleId);
		}
		this.WeaponDataMap.Remove(incId);
	}

	// Token: 0x06015CE7 RID: 89319 RVA: 0x0065285F File Offset: 0x00650A5F
	protected WeaponInstance CreateWeaponInstance(WeaponItem weaponItem)
	{
		WeaponInstance weaponInstance = new WeaponInstance();
		weaponInstance.SetWeaponItem(weaponItem);
		return weaponInstance;
	}

	// Token: 0x06015CE8 RID: 89320 RVA: 0x00652870 File Offset: 0x00650A70
	public void SetWeaponLevelData(int incId, int exp, int level)
	{
		WeaponInstance weaponInstance;
		if (this.WeaponDataMap.TryGetValue(incId, out weaponInstance))
		{
			weaponInstance.SetExp(exp);
			weaponInstance.SetLevel(level);
		}
	}

	// Token: 0x06015CE9 RID: 89321 RVA: 0x0065289C File Offset: 0x00650A9C
	public void SetWeaponBreachData(int incId, int breach)
	{
		WeaponInstance weaponInstance;
		if (this.WeaponDataMap.TryGetValue(incId, out weaponInstance))
		{
			weaponInstance.SetBreachLevel(breach);
		}
	}

	// Token: 0x06015CEA RID: 89322 RVA: 0x006528C0 File Offset: 0x00650AC0
	public void SetWeaponResonanceData(int incId, int resonanceLevel)
	{
		WeaponInstance weaponInstance;
		if (this.WeaponDataMap.TryGetValue(incId, out weaponInstance))
		{
			weaponInstance.SetResonanceLevel(resonanceLevel);
		}
	}

	// Token: 0x06015CEB RID: 89323 RVA: 0x006528E4 File Offset: 0x00650AE4
	public int GetWeaponLevelById(int incId)
	{
		WeaponInstance weaponInstance;
		if (this.WeaponDataMap.TryGetValue(incId, out weaponInstance))
		{
			return weaponInstance.GetLevel();
		}
		return 0;
	}

	// Token: 0x06015CEC RID: 89324 RVA: 0x0065290C File Offset: 0x00650B0C
	public WeaponDataBase GetWeaponDataByRoleDataId(int roleDataId, bool isSelf = true)
	{
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleDataId, isSelf);
		if (roleDataById.IsTrialRole())
		{
			return (roleDataById as RoleRobotData).GetWeaponData();
		}
		if (roleDataById.IsOnlineRole())
		{
			return (roleDataById as RoleOnlineInstanceData).GetWeaponData();
		}
		WeaponInstance weaponInstanceByRoleId = this.GetWeaponInstanceByRoleId(roleDataId);
		if (weaponInstanceByRoleId != null)
		{
			return weaponInstanceByRoleId;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Role;
		ELogAuthor author = ELogAuthor.BB;
		string message = "获取不到武器数据";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleDataId", roleDataId);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x06015CED RID: 89325 RVA: 0x00652988 File Offset: 0x00650B88
	public int? GetWeaponIdByRoleDataId(int roleDataId)
	{
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleDataId, true);
		if (roleDataById == null)
		{
			return new int?(RoleConfig.Instance.GetRoleConfig(roleDataId).Value.InitWeaponItemId);
		}
		if (roleDataById.IsTrialRole())
		{
			return new int?((roleDataById as RoleRobotData).GetWeaponData().GetItemId());
		}
		WeaponInstance weaponInstanceByRoleId = this.GetWeaponInstanceByRoleId(roleDataId);
		if (weaponInstanceByRoleId != null)
		{
			return new int?(weaponInstanceByRoleId.GetItemId());
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Role;
		ELogAuthor author = ELogAuthor.BB;
		string message = "获取不到武器数据";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleDataId", roleDataId);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x06015CEE RID: 89326 RVA: 0x00652A34 File Offset: 0x00650C34
	public WeaponInstance GetWeaponInstanceByRoleId(int roleId)
	{
		int key;
		WeaponInstance result;
		if (this.RoleWeaponDataMap.TryGetValue(roleId, out key) && this.WeaponDataMap.TryGetValue(key, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06015CEF RID: 89327 RVA: 0x00652A64 File Offset: 0x00650C64
	public WeaponInstance GetWeaponDataByIncId(int incId)
	{
		WeaponInstance result;
		if (this.WeaponDataMap.TryGetValue(incId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06015CF0 RID: 89328 RVA: 0x00652A84 File Offset: 0x00650C84
	public void WeaponRoleLoadEquip(RepeatedField<RoleLoadEquipData> weaponEquipDataList)
	{
		if (weaponEquipDataList == null)
		{
			return;
		}
		foreach (RoleLoadEquipData roleLoadEquipData in weaponEquipDataList)
		{
			int roleID = roleLoadEquipData.RoleID;
			int equipIncID = roleLoadEquipData.EquipIncID;
			this.ChangeWeaponEquip(equipIncID, roleID);
		}
		EventSystem.Instance.Emit(EEventName.EquipWeapon);
		foreach (RoleLoadEquipData roleLoadEquipData2 in weaponEquipDataList)
		{
			if (roleLoadEquipData2.RoleID > 0)
			{
				EventSystem.Instance.Emit<int>(EEventName.WeaponRoleEquipChanged, roleLoadEquipData2.RoleID);
			}
		}
	}

	// Token: 0x06015CF1 RID: 89329 RVA: 0x00652B3C File Offset: 0x00650D3C
	public void WeaponLevelUpResponse(WeaponLevelUpResponse response)
	{
		this.SetWeaponLevelData(response.IncId, response.WeaponExp, response.WeaponLevel);
		EventSystem.Instance.Emit(EEventName.WeaponLevelUp);
		WeaponInstance weaponInstance;
		if (this.WeaponDataMap.TryGetValue(response.IncId, out weaponInstance) && weaponInstance.HasRole())
		{
			EventSystem.Instance.Emit<int>(EEventName.WeaponRoleLevelUp, weaponInstance.GetRoleId());
		}
		this.WeaponLevelUpReceiveItem(response.ItemMap);
	}

	// Token: 0x06015CF2 RID: 89330 RVA: 0x00652BB0 File Offset: 0x00650DB0
	private void WeaponLevelUpReceiveItem(MapField<int, int> itemMap)
	{
		List<TItem> list = new List<TItem>();
		foreach (KeyValuePair<int, int> keyValuePair in itemMap)
		{
			TItem item = new TItem(new InventoryDefine.GetItemData(keyValuePair.Key, 0), keyValuePair.Value);
			list.Add(item);
		}
		EventSystem.Instance.Emit<IReadOnlyList<TItem>>(EEventName.WeaponLevelUpReceiveItem, list);
	}

	// Token: 0x06015CF3 RID: 89331 RVA: 0x00652C2C File Offset: 0x00650E2C
	public unsafe void ChangeWeaponEquip(int incId, int roleId)
	{
		WeaponInstance weaponInstance;
		if (!this.WeaponDataMap.TryGetValue(incId, out weaponInstance))
		{
			return;
		}
		int roleId2 = weaponInstance.GetRoleId();
		if (roleId2 > 0)
		{
			this.RoleWeaponDataMap[roleId2] = 0;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "武器设置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("lastRoleId", roleId2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("incId", 0);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		weaponInstance.SetRoleId(roleId);
		if (roleId > 0)
		{
			this.RoleWeaponDataMap[roleId] = incId;
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Role;
			ELogAuthor author2 = ELogAuthor.LZK;
			string message2 = "武器设置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("roleId", roleId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("incId", incId);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		}
	}

	// Token: 0x06015CF4 RID: 89332 RVA: 0x00652D34 File Offset: 0x00650F34
	public float GetCurveValue(int curveId, float baseValue, int level, int breach)
	{
		WeaponPropertyGrowth? weaponPropertyGrowthConfig = WeaponConfig.Instance.GetWeaponPropertyGrowthConfig(curveId, level, breach);
		return baseValue * ((float)((weaponPropertyGrowthConfig != null) ? weaponPropertyGrowthConfig.GetValueOrDefault().CurveValue : 0) / 10000f);
	}

	// Token: 0x06015CF5 RID: 89333 RVA: 0x00652D74 File Offset: 0x00650F74
	public List<WeaponItemData> GetWeaponListFromReplace(int weaponType)
	{
		List<WeaponItemData> list = new List<WeaponItemData>();
		foreach (WeaponItemData weaponItemData in InventoryModel.Instance.GetWeaponItemDataList())
		{
			if (this.GetWeaponDataByIncId(weaponItemData.GetUniqueId()).GetWeaponConfig().Value.WeaponType == weaponType)
			{
				list.Add(weaponItemData);
			}
		}
		return list;
	}

	// Token: 0x06015CF6 RID: 89334 RVA: 0x00652DF8 File Offset: 0x00650FF8
	public List<ItemDataBase> GetResonanceMaterialList(int incId)
	{
		InventoryModel instance = InventoryModel.Instance;
		WeaponInstance weaponDataByIncId = this.GetWeaponDataByIncId(incId);
		int itemId = weaponDataByIncId.GetItemId();
		HashSet<ItemDataBase> itemDataBaseByMainType = instance.GetItemDataBaseByMainType(InventoryDefine.EItemMainTypeId.Weapon);
		List<ItemDataBase> list = new List<ItemDataBase>();
		foreach (ItemDataBase itemDataBase in itemDataBaseByMainType)
		{
			if (itemDataBase.GetConfigId() == itemId && itemDataBase.GetUniqueId() != incId && !this.GetWeaponDataByIncId(itemDataBase.GetUniqueId()).HasRole())
			{
				list.Add(itemDataBase);
			}
		}
		int[] array = weaponDataByIncId.GetResonanceConfig().Value.AlternativeConsume();
		if (array != null && array.Length != 0)
		{
			foreach (int configId in array)
			{
				foreach (ItemDataBase item in instance.GetItemDataBaseByConfigId(configId))
				{
					list.Add(item);
				}
			}
		}
		return list;
	}

	// Token: 0x06015CF7 RID: 89335 RVA: 0x00652F1C File Offset: 0x0065111C
	public List<ItemInfo> GetWeaponExpMaterialList()
	{
		List<ItemInfo> list = new List<ItemInfo>();
		foreach (ItemDataBase itemDataBase in InventoryModel.Instance.GetItemDataBaseByMainType(InventoryDefine.EItemMainTypeId.Weapon))
		{
			if (itemDataBase.GetType().GetValueOrDefault() == InventoryDefine.EItemType.WeaponMaterial)
			{
				ItemInfo? config = CSharpScript.Game.Module.Item.ItemConfig.Instance.GetConfig(itemDataBase.GetConfigId());
				if (config != null)
				{
					list.Add(config.Value);
				}
			}
		}
		list.Sort((ItemInfo a, ItemInfo b) => b.QualityId - a.QualityId);
		return list;
	}

	// Token: 0x06015CF8 RID: 89336 RVA: 0x00652FD4 File Offset: 0x006511D4
	public Dictionary<int, int> GetCanChangeMaterialList(int overExp)
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		List<ItemInfo> list = ConfigCommon.ToList<ItemInfo>(CSharpScript.Game.Module.Item.ItemConfig.Instance.GetConfigListByItemType(4));
		list.Sort(new Comparison<ItemInfo>(this.ExpItemDataListSort));
		int num = overExp;
		foreach (ItemInfo itemInfo in list)
		{
			WeaponExpItem? weaponExpItemConfig = WeaponConfig.Instance.GetWeaponExpItemConfig(itemInfo.Id);
			if (num >= weaponExpItemConfig.Value.BasicExp)
			{
				double num2 = Math.Floor((double)((float)num / (float)weaponExpItemConfig.Value.BasicExp));
				dictionary[itemInfo.Id] = (int)num2;
				num %= weaponExpItemConfig.Value.BasicExp;
			}
		}
		return dictionary;
	}

	// Token: 0x06015CF9 RID: 89337 RVA: 0x006530AC File Offset: 0x006512AC
	private int ExpItemDataListSort(ItemInfo a, ItemInfo b)
	{
		return b.QualityId - a.QualityId;
	}

	// Token: 0x06015CFA RID: 89338 RVA: 0x006530C0 File Offset: 0x006512C0
	public int GetResonanceNeedMoney(int resonanceId, int startLevel, int endLevel)
	{
		int num = 0;
		for (int i = startLevel; i < endLevel; i++)
		{
			num += WeaponConfig.Instance.GetWeaponResonanceConfig(resonanceId, i).Value.GoldConsume;
		}
		return num;
	}

	// Token: 0x06015CFB RID: 89339 RVA: 0x006530FC File Offset: 0x006512FC
	public int GetWeaponBreachMaxLevel(int breachId)
	{
		IReadOnlyList<WeaponBreach> weaponBreachList = WeaponConfig.Instance.GetWeaponBreachList(breachId);
		int count = weaponBreachList.Count;
		int num = 0;
		for (int i = 0; i < count; i++)
		{
			WeaponBreach weaponBreach = weaponBreachList[i];
			if (weaponBreach.Level > num)
			{
				num = weaponBreach.Level;
			}
		}
		return num;
	}

	// Token: 0x06015CFC RID: 89340 RVA: 0x00653148 File Offset: 0x00651348
	public int GetWeaponItemBaseExp(ItemDataBase itemData)
	{
		if (itemData.GetType().GetValueOrDefault() == InventoryDefine.EItemType.WeaponMaterial)
		{
			return WeaponConfig.Instance.GetWeaponExpItemConfig(itemData.GetConfigId()).Value.BasicExp;
		}
		return WeaponConfig.Instance.GetWeaponQualityInfo(itemData.GetQuality()).Value.BasicExp;
	}

	// Token: 0x06015CFD RID: 89341 RVA: 0x006531A8 File Offset: 0x006513A8
	public string[] GetWeaponConfigDescParams(WeaponConf weaponConfig, int resonanceLevel)
	{
		List<string> list = new List<string>();
		foreach (StringArray stringArray in weaponConfig.DescParams())
		{
			if (stringArray.ToString() != "")
			{
				int num = (resonanceLevel >= stringArray.ArrayStringLength) ? stringArray.ArrayStringLength : resonanceLevel;
				string item = stringArray.ArrayString(num - 1);
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	// Token: 0x06015CFE RID: 89342 RVA: 0x00653223 File Offset: 0x00651423
	public EWeaponViewName GetCurSelectViewName()
	{
		return this.CurSelectViewName;
	}

	// Token: 0x06015CFF RID: 89343 RVA: 0x0065322B File Offset: 0x0065142B
	public void SetCurSelectViewName(EWeaponViewName name)
	{
		this.CurSelectViewName = name;
	}

	// Token: 0x06015D00 RID: 89344 RVA: 0x00653234 File Offset: 0x00651434
	public void SetWeaponBreachLevelForMesh(USkeletalMeshComponent meshComp, int breachLevel)
	{
		this.WeaponBreachLevelMap.AddOrUpdate(meshComp, breachLevel);
	}

	// Token: 0x06015D01 RID: 89345 RVA: 0x00653248 File Offset: 0x00651448
	[NullableContext(2)]
	public int GetWeaponBreachLevelForMesh(USkeletalMeshComponent meshComp)
	{
		object obj;
		if (meshComp != null && this.WeaponBreachLevelMap.TryGetValue(meshComp, out obj) && obj is int)
		{
			return (int)obj;
		}
		return 0;
	}

	// Token: 0x06015D02 RID: 89346 RVA: 0x0065327C File Offset: 0x0065147C
	public bool IsWeaponUsedByUncommonRole(int incId)
	{
		WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(incId);
		if (weaponDataByIncId != null)
		{
			RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(weaponDataByIncId.GetRoleId());
			if (roleInstanceById != null && roleInstanceById.GetRoleConfig().RoleType != 1)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06015D03 RID: 89347 RVA: 0x006532C0 File Offset: 0x006514C0
	public bool CanItemUseAsExpItem(ItemDataBase itemData)
	{
		if (itemData.GetType().GetValueOrDefault() == InventoryDefine.EItemType.Weapon && itemData.GetUniqueId() > 0)
		{
			WeaponInstance weaponDataByIncId = this.GetWeaponDataByIncId(itemData.GetUniqueId());
			if (weaponDataByIncId.HasRole() || weaponDataByIncId.GetItemConfig().QualityId >= 5)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06015D04 RID: 89348 RVA: 0x00653310 File Offset: 0x00651510
	public bool IsWeaponHighQuality(WeaponInstance weaponInstance)
	{
		int weaponQualityCheck = WeaponConfig.Instance.GetWeaponQualityCheck();
		return weaponInstance.GetItemConfig().QualityId > weaponQualityCheck;
	}

	// Token: 0x06015D05 RID: 89349 RVA: 0x0065333C File Offset: 0x0065153C
	public bool IsWeaponHighLevel(WeaponInstance weaponInstance)
	{
		int weaponLevelCheck = WeaponConfig.Instance.GetWeaponLevelCheck();
		return weaponInstance.GetLevel() > weaponLevelCheck;
	}

	// Token: 0x06015D06 RID: 89350 RVA: 0x00653360 File Offset: 0x00651560
	public bool IsWeaponHighResonanceLevel(WeaponInstance weaponInstance)
	{
		int weaponResonanceCheck = WeaponConfig.Instance.GetWeaponResonanceCheck();
		return weaponInstance.GetResonanceLevel() > weaponResonanceCheck;
	}

	// Token: 0x06015D07 RID: 89351 RVA: 0x00653381 File Offset: 0x00651581
	public bool HasWeaponResonance(WeaponInstance weaponInstance)
	{
		return weaponInstance.GetResonanceLevel() > 1;
	}

	// Token: 0x06015D08 RID: 89352 RVA: 0x0065338C File Offset: 0x0065158C
	public int GetWeaponItemExp(int incId, int configId)
	{
		if (incId > 0)
		{
			WeaponInstance weaponDataByIncId = this.GetWeaponDataByIncId(incId);
			if (weaponDataByIncId != null)
			{
				return weaponDataByIncId.GetMaterialExp();
			}
		}
		return WeaponConfig.Instance.GetWeaponExpItemConfig(configId).Value.BasicExp;
	}

	// Token: 0x06015D09 RID: 89353 RVA: 0x006533CC File Offset: 0x006515CC
	public int GetWeaponItemExpCost(int incId, int configId)
	{
		if (incId > 0)
		{
			WeaponInstance weaponDataByIncId = this.GetWeaponDataByIncId(incId);
			if (weaponDataByIncId != null)
			{
				return weaponDataByIncId.GetMaterialCost();
			}
		}
		return WeaponConfig.Instance.GetWeaponExpItemConfig(configId).Value.Cost;
	}

	// Token: 0x06015D0A RID: 89354 RVA: 0x0065340C File Offset: 0x0065160C
	public int GetWeaponExpItemListCost(TCommonMultipleConsumeData[] itemList)
	{
		int num = 0;
		foreach (TCommonMultipleConsumeData tcommonMultipleConsumeData in itemList)
		{
			if (tcommonMultipleConsumeData.ItemData.ItemId == 0)
			{
				break;
			}
			int weaponItemExpCost = this.GetWeaponItemExpCost(tcommonMultipleConsumeData.ItemData.IncId, tcommonMultipleConsumeData.ItemData.ItemId);
			num += weaponItemExpCost * tcommonMultipleConsumeData.Count;
		}
		return num;
	}

	// Token: 0x06015D0B RID: 89355 RVA: 0x00653470 File Offset: 0x00651670
	public List<ItemDataBase> GetWeaponExpItemList(int? incId)
	{
		List<ItemDataBase> list = new List<ItemDataBase>();
		foreach (ItemDataBase itemDataBase in InventoryModel.Instance.GetItemDataBaseByMainType(InventoryDefine.EItemMainTypeId.Weapon))
		{
			if (this.CanItemUseAsExpItem(itemDataBase))
			{
				int? num = incId;
				int uniqueId = itemDataBase.GetUniqueId();
				if (!(num.GetValueOrDefault() == uniqueId & num != null))
				{
					list.Add(itemDataBase);
				}
			}
		}
		return list;
	}

	// Token: 0x06015D0C RID: 89356 RVA: 0x006534F8 File Offset: 0x006516F8
	public List<ItemDataBase> GetWeaponExpItemListUseToAuto(int? incId)
	{
		List<ItemDataBase> list = new List<ItemDataBase>();
		foreach (ItemDataBase itemDataBase in this.GetWeaponExpItemList(incId))
		{
			if (!itemDataBase.GetIsLock())
			{
				if (itemDataBase.GetType().GetValueOrDefault() == InventoryDefine.EItemType.Weapon)
				{
					WeaponInstance weaponDataByIncId = this.GetWeaponDataByIncId(itemDataBase.GetUniqueId());
					if (this.IsWeaponHighResonanceLevel(weaponDataByIncId) || this.IsWeaponHighLevel(weaponDataByIncId))
					{
						continue;
					}
				}
				list.Add(itemDataBase);
			}
		}
		this.GetWeaponExpItemListWithSort(list);
		return list;
	}

	// Token: 0x06015D0D RID: 89357 RVA: 0x00653598 File Offset: 0x00651798
	public List<ItemDataBase> GetWeaponExpItemListWithSort(List<ItemDataBase> dataList)
	{
		HashSet<int> hashSet = new HashSet<int>();
		hashSet.Add(2);
		hashSet.Add(10);
		hashSet.Add(8);
		SortModel.Instance.SortDataByData<ItemDataBase>(dataList, ESortDataType.Weapon, hashSet, true);
		return dataList;
	}

	// Token: 0x06015D0E RID: 89358 RVA: 0x006535D4 File Offset: 0x006517D4
	public List<ISelectedData> AutoAddExpItem(int needExp, int maxCount, ISelectedData[] sourceList, Func<ISelectedData, int> getExp)
	{
		int num = needExp;
		List<ISelectedData> list = new List<ISelectedData>();
		foreach (ISelectedData selectedData in sourceList)
		{
			if (list.Count >= maxCount || num <= 0)
			{
				break;
			}
			int num2 = getExp(selectedData);
			int val = (int)Math.Ceiling((double)((float)num / (float)num2));
			int val2 = selectedData.Count - selectedData.SelectedCount;
			int num3 = selectedData.SelectedCount + Math.Min(val, val2);
			if (num3 > 0)
			{
				SelectedData item = new SelectedData
				{
					IncId = selectedData.IncId,
					ItemId = selectedData.ItemId,
					Count = selectedData.Count,
					SelectedCount = num3
				};
				list.Add(item);
				num -= num3 * num2;
			}
		}
		return list;
	}

	// Token: 0x06015D0F RID: 89359 RVA: 0x006536A4 File Offset: 0x006518A4
	public bool CheckSatisfyExp(int needExp, int maxCount, ISelectedData[] sourceList, Func<ISelectedData, int> getExp)
	{
		int num = needExp;
		int num2 = 0;
		foreach (ISelectedData selectedData in sourceList)
		{
			if (num2 >= maxCount || num <= 0)
			{
				break;
			}
			int num3 = getExp(selectedData);
			int val = (int)Math.Ceiling((double)((float)num / (float)num3));
			int val2 = selectedData.Count - selectedData.SelectedCount;
			int num4 = selectedData.SelectedCount + Math.Min(val, val2);
			if (num4 > 0)
			{
				num2++;
				num -= num4 * num3;
			}
		}
		return num <= 0;
	}

	// Token: 0x06015D10 RID: 89360 RVA: 0x00653728 File Offset: 0x00651928
	public void AutoAddExpItemEx(int needExp, ISelectedData[] sourceList, Func<ISelectedData, int> getExp)
	{
		int num = needExp;
		foreach (ISelectedData selectedData in sourceList)
		{
			if (num <= 0)
			{
				break;
			}
			int num2 = getExp(selectedData);
			int val = (int)Math.Ceiling((double)((float)num / (float)num2));
			int val2 = selectedData.Count - selectedData.SelectedCount;
			int num3 = selectedData.SelectedCount + Math.Min(val, val2);
			selectedData.SelectedCount = num3;
			num -= num3 * num2;
		}
	}

	// Token: 0x06015D11 RID: 89361 RVA: 0x00653798 File Offset: 0x00651998
	public IWeaponAttributeParam[] GetWeaponAttributeParamList(WeaponConf weaponConfig)
	{
		return new IWeaponAttributeParam[]
		{
			new WeaponAttributeParam
			{
				PropId = weaponConfig.FirstPropId.Value,
				CurveId = weaponConfig.FirstCurve
			},
			new WeaponAttributeParam
			{
				PropId = weaponConfig.SecondPropId.Value,
				CurveId = weaponConfig.SecondCurve
			}
		};
	}

	// Token: 0x06015D12 RID: 89362 RVA: 0x00653800 File Offset: 0x00651A00
	public EWeaponBreachState GetWeaponBreachState(int incId)
	{
		WeaponInstance weaponDataByIncId = this.GetWeaponDataByIncId(incId);
		WeaponBreach? breachConfig = weaponDataByIncId.GetBreachConfig();
		if (!LevelGeneralController.Instance.CheckCondition(breachConfig.Value.ConditionId.ToString(), null, true, Array.Empty<object>()))
		{
			return EWeaponBreachState.NoEnoughCondition;
		}
		WeaponBreach? breachConsume = weaponDataByIncId.GetBreachConsume();
		for (int i = 0; i < breachConsume.Value.ConsumeLength; i++)
		{
			DicIntInt? dicIntInt = breachConsume.Value.Consume(i);
			int key = dicIntInt.Value.Key;
			int value = dicIntInt.Value.Value;
			if (InventoryModel.Instance.GetItemCountByConfigId(key, 0) < value)
			{
				return EWeaponBreachState.NoEnoughMaterial;
			}
		}
		int goldConsume = breachConfig.Value.GoldConsume;
		if (InventoryModel.Instance.GetItemCountByConfigId(2, 0) < goldConsume)
		{
			return EWeaponBreachState.NoEnoughMoney;
		}
		return EWeaponBreachState.CanBreach;
	}

	// Token: 0x06015D13 RID: 89363 RVA: 0x006538E0 File Offset: 0x00651AE0
	public bool RedDotWeaponBreachCondition(int roleId)
	{
		WeaponInstance weaponInstanceByRoleId = this.GetWeaponInstanceByRoleId(roleId);
		return weaponInstanceByRoleId != null && weaponInstanceByRoleId.CanGoBreach() && this.GetWeaponBreachState(weaponInstanceByRoleId.GetIncId().Value) == EWeaponBreachState.CanBreach;
	}

	// Token: 0x06015D14 RID: 89364 RVA: 0x0065391C File Offset: 0x00651B1C
	public bool RedDotWeaponResonanceCondition(int weaponIncId)
	{
		WeaponInstance weaponDataByIncId = this.GetWeaponDataByIncId(weaponIncId);
		if (weaponDataByIncId == null)
		{
			return false;
		}
		int resonanceLevel = weaponDataByIncId.GetResonanceLevel();
		int resonLevelLimit = weaponDataByIncId.GetWeaponConfig().Value.ResonLevelLimit;
		if (resonanceLevel >= resonLevelLimit)
		{
			return false;
		}
		WeaponReson? resonanceConfig = weaponDataByIncId.GetResonanceConfig();
		return resonanceConfig != null && resonanceConfig.Value.MaterialPlaceType == 1 && resonanceConfig.Value.AlternativeConsume().Length != 0 && InventoryModel.Instance.GetCommonItemCount(resonanceConfig.Value.AlternativeConsume()[0], 0) > 0 && InventoryModel.Instance.GetItemCountByConfigId(2, 0) >= resonanceConfig.Value.GoldConsume;
	}

	// Token: 0x06015D15 RID: 89365 RVA: 0x006539DC File Offset: 0x00651BDC
	public bool RedDotWeaponResonanceConditionByRole(int roleId)
	{
		WeaponInstance weaponInstanceByRoleId = this.GetWeaponInstanceByRoleId(roleId);
		int? num = (weaponInstanceByRoleId != null) ? weaponInstanceByRoleId.GetIncId() : null;
		if (num != null)
		{
			int? num2 = num;
			int num3 = 0;
			if (!(num2.GetValueOrDefault() == num3 & num2 != null))
			{
				return this.RedDotWeaponResonanceCondition(num.Value);
			}
		}
		return false;
	}

	// Token: 0x06015D16 RID: 89366 RVA: 0x00653A38 File Offset: 0x00651C38
	public List<ISelectedData> GetExpItemInInventory()
	{
		List<ISelectedData> list = new List<ISelectedData>();
		foreach (ItemInfo itemInfo in this.GetWeaponExpItemConfigList())
		{
			SelectedData item = new SelectedData
			{
				IncId = 0,
				ItemId = itemInfo.Id,
				Count = InventoryModel.Instance.GetCommonItemCount(itemInfo.Id, 0),
				SelectedCount = 0
			};
			list.Add(item);
		}
		return list;
	}

	// Token: 0x06015D17 RID: 89367 RVA: 0x00653ACC File Offset: 0x00651CCC
	public List<ItemInfo> GetWeaponExpItemConfigList()
	{
		List<ItemInfo> list = new List<ItemInfo>();
		List<WeaponExpItem> weaponExpItemList = WeaponConfig.Instance.GetWeaponExpItemList();
		if (weaponExpItemList != null)
		{
			foreach (WeaponExpItem weaponExpItem in weaponExpItemList)
			{
				ItemInfo? config = CSharpScript.Game.Module.Item.ItemConfig.Instance.GetConfig(weaponExpItem.Id);
				if (config != null)
				{
					list.Add(config.Value);
				}
			}
		}
		return list;
	}

	// Token: 0x1700211A RID: 8474
	// (get) Token: 0x06015D18 RID: 89368 RVA: 0x00653B54 File Offset: 0x00651D54
	public static WeaponModel Instance
	{
		get
		{
			return WeaponModel._Instance;
		}
	}

	// Token: 0x06015D19 RID: 89369 RVA: 0x00653B5B File Offset: 0x00651D5B
	public static WeaponModel GetOrCreateInstance()
	{
		if (WeaponModel._Instance == null)
		{
			WeaponModel.CreateInstance();
		}
		return WeaponModel._Instance;
	}

	// Token: 0x06015D1A RID: 89370 RVA: 0x00653B6F File Offset: 0x00651D6F
	public static bool CreateInstance()
	{
		if (WeaponModel._Instance != null)
		{
			return true;
		}
		WeaponModel._Instance = new WeaponModel();
		return true;
	}

	// Token: 0x06015D1B RID: 89371 RVA: 0x00653B85 File Offset: 0x00651D85
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015D1C RID: 89372 RVA: 0x00653B87 File Offset: 0x00651D87
	public static void ResetStaticDefaultValue()
	{
		WeaponModel._Instance = null;
	}

	// Token: 0x06015D1D RID: 89373 RVA: 0x00653B8F File Offset: 0x00651D8F
	static WeaponModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WeaponModel.CreateStaticDefaultValue), new Action(WeaponModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400B7B1 RID: 47025
	private readonly Dictionary<int, WeaponInstance> WeaponDataMap = new Dictionary<int, WeaponInstance>();

	// Token: 0x0400B7B2 RID: 47026
	private readonly Dictionary<int, int> RoleWeaponDataMap = new Dictionary<int, int>();

	// Token: 0x0400B7B3 RID: 47027
	private EWeaponViewName CurSelectViewName;

	// Token: 0x0400B7B4 RID: 47028
	private readonly ConditionalWeakTable<USkeletalMeshComponent, object> WeaponBreachLevelMap = new ConditionalWeakTable<USkeletalMeshComponent, object>();

	// Token: 0x0400B7B5 RID: 47029
	public int BlueprintWeaponEquippedRoleId;

	// Token: 0x0400B7B6 RID: 47030
	public bool LevelUpConfirmTipsNotShow;

	// Token: 0x0400B7B7 RID: 47031
	[Nullable(2)]
	private static WeaponModel _Instance;
}
