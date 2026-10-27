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

// Token: 0x02002D1B RID: 11547
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class WeaponModel : ModelBase
{
	// Token: 0x06018444 RID: 99396 RVA: 0x0062C774 File Offset: 0x0062A974
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

	// Token: 0x06018445 RID: 99397 RVA: 0x0062C824 File Offset: 0x0062AA24
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

	// Token: 0x06018446 RID: 99398 RVA: 0x0062C86B File Offset: 0x0062AA6B
	protected WeaponInstance CreateWeaponInstance(WeaponItem weaponItem)
	{
		WeaponInstance weaponInstance = new WeaponInstance();
		weaponInstance.SetWeaponItem(weaponItem);
		return weaponInstance;
	}

	// Token: 0x06018447 RID: 99399 RVA: 0x0062C87C File Offset: 0x0062AA7C
	public void SetWeaponLevelData(int incId, int exp, int level)
	{
		WeaponInstance weaponInstance;
		if (this.WeaponDataMap.TryGetValue(incId, out weaponInstance))
		{
			weaponInstance.SetExp(exp);
			weaponInstance.SetLevel(level);
		}
	}

	// Token: 0x06018448 RID: 99400 RVA: 0x0062C8A8 File Offset: 0x0062AAA8
	public void SetWeaponBreachData(int incId, int breach)
	{
		WeaponInstance weaponInstance;
		if (this.WeaponDataMap.TryGetValue(incId, out weaponInstance))
		{
			weaponInstance.SetBreachLevel(breach);
		}
	}

	// Token: 0x06018449 RID: 99401 RVA: 0x0062C8CC File Offset: 0x0062AACC
	public void SetWeaponResonanceData(int incId, int resonanceLevel)
	{
		WeaponInstance weaponInstance;
		if (this.WeaponDataMap.TryGetValue(incId, out weaponInstance))
		{
			weaponInstance.SetResonanceLevel(resonanceLevel);
		}
	}

	// Token: 0x0601844A RID: 99402 RVA: 0x0062C8F0 File Offset: 0x0062AAF0
	public int GetWeaponLevelById(int incId)
	{
		WeaponInstance weaponInstance;
		if (this.WeaponDataMap.TryGetValue(incId, out weaponInstance))
		{
			return weaponInstance.GetLevel();
		}
		return 0;
	}

	// Token: 0x0601844B RID: 99403 RVA: 0x0062C918 File Offset: 0x0062AB18
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

	// Token: 0x0601844C RID: 99404 RVA: 0x0062C994 File Offset: 0x0062AB94
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

	// Token: 0x0601844D RID: 99405 RVA: 0x0062CA40 File Offset: 0x0062AC40
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

	// Token: 0x0601844E RID: 99406 RVA: 0x0062CA70 File Offset: 0x0062AC70
	public WeaponInstance GetWeaponDataByIncId(int incId)
	{
		WeaponInstance result;
		if (this.WeaponDataMap.TryGetValue(incId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0601844F RID: 99407 RVA: 0x0062CA90 File Offset: 0x0062AC90
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

	// Token: 0x06018450 RID: 99408 RVA: 0x0062CB48 File Offset: 0x0062AD48
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

	// Token: 0x06018451 RID: 99409 RVA: 0x0062CBBC File Offset: 0x0062ADBC
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

	// Token: 0x06018452 RID: 99410 RVA: 0x0062CC38 File Offset: 0x0062AE38
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

	// Token: 0x06018453 RID: 99411 RVA: 0x0062CD40 File Offset: 0x0062AF40
	public float GetCurveValue(int curveId, float baseValue, int level, int breach)
	{
		WeaponPropertyGrowth? weaponPropertyGrowthConfig = WeaponConfig.Instance.GetWeaponPropertyGrowthConfig(curveId, level, breach);
		return baseValue * ((float)((weaponPropertyGrowthConfig != null) ? weaponPropertyGrowthConfig.GetValueOrDefault().CurveValue : 0) / 10000f);
	}

	// Token: 0x06018454 RID: 99412 RVA: 0x0062CD80 File Offset: 0x0062AF80
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

	// Token: 0x06018455 RID: 99413 RVA: 0x0062CE04 File Offset: 0x0062B004
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

	// Token: 0x06018456 RID: 99414 RVA: 0x0062CF28 File Offset: 0x0062B128
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

	// Token: 0x06018457 RID: 99415 RVA: 0x0062CFE0 File Offset: 0x0062B1E0
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

	// Token: 0x06018458 RID: 99416 RVA: 0x0062D0B8 File Offset: 0x0062B2B8
	private int ExpItemDataListSort(ItemInfo a, ItemInfo b)
	{
		return b.QualityId - a.QualityId;
	}

	// Token: 0x06018459 RID: 99417 RVA: 0x0062D0CC File Offset: 0x0062B2CC
	public int GetResonanceNeedMoney(int resonanceId, int startLevel, int endLevel)
	{
		int num = 0;
		for (int i = startLevel; i < endLevel; i++)
		{
			num += WeaponConfig.Instance.GetWeaponResonanceConfig(resonanceId, i).Value.GoldConsume;
		}
		return num;
	}

	// Token: 0x0601845A RID: 99418 RVA: 0x0062D108 File Offset: 0x0062B308
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

	// Token: 0x0601845B RID: 99419 RVA: 0x0062D154 File Offset: 0x0062B354
	public int GetWeaponItemBaseExp(ItemDataBase itemData)
	{
		if (itemData.GetType().GetValueOrDefault() == InventoryDefine.EItemType.WeaponMaterial)
		{
			return WeaponConfig.Instance.GetWeaponExpItemConfig(itemData.GetConfigId()).Value.BasicExp;
		}
		return WeaponConfig.Instance.GetWeaponQualityInfo(itemData.GetQuality()).Value.BasicExp;
	}

	// Token: 0x0601845C RID: 99420 RVA: 0x0062D1B4 File Offset: 0x0062B3B4
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

	// Token: 0x0601845D RID: 99421 RVA: 0x0062D22F File Offset: 0x0062B42F
	public EWeaponViewName GetCurSelectViewName()
	{
		return this.CurSelectViewName;
	}

	// Token: 0x0601845E RID: 99422 RVA: 0x0062D237 File Offset: 0x0062B437
	public void SetCurSelectViewName(EWeaponViewName name)
	{
		this.CurSelectViewName = name;
	}

	// Token: 0x0601845F RID: 99423 RVA: 0x0062D240 File Offset: 0x0062B440
	public void SetWeaponBreachLevelForMesh(USkeletalMeshComponent meshComp, int breachLevel)
	{
		this.WeaponBreachLevelMap.AddOrUpdate(meshComp, breachLevel);
	}

	// Token: 0x06018460 RID: 99424 RVA: 0x0062D254 File Offset: 0x0062B454
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

	// Token: 0x06018461 RID: 99425 RVA: 0x0062D288 File Offset: 0x0062B488
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

	// Token: 0x06018462 RID: 99426 RVA: 0x0062D2CC File Offset: 0x0062B4CC
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

	// Token: 0x06018463 RID: 99427 RVA: 0x0062D31C File Offset: 0x0062B51C
	public bool IsWeaponHighQuality(WeaponInstance weaponInstance)
	{
		int weaponQualityCheck = WeaponConfig.Instance.GetWeaponQualityCheck();
		return weaponInstance.GetItemConfig().QualityId > weaponQualityCheck;
	}

	// Token: 0x06018464 RID: 99428 RVA: 0x0062D348 File Offset: 0x0062B548
	public bool IsWeaponHighLevel(WeaponInstance weaponInstance)
	{
		int weaponLevelCheck = WeaponConfig.Instance.GetWeaponLevelCheck();
		return weaponInstance.GetLevel() > weaponLevelCheck;
	}

	// Token: 0x06018465 RID: 99429 RVA: 0x0062D36C File Offset: 0x0062B56C
	public bool IsWeaponHighResonanceLevel(WeaponInstance weaponInstance)
	{
		int weaponResonanceCheck = WeaponConfig.Instance.GetWeaponResonanceCheck();
		return weaponInstance.GetResonanceLevel() > weaponResonanceCheck;
	}

	// Token: 0x06018466 RID: 99430 RVA: 0x0062D38D File Offset: 0x0062B58D
	public bool HasWeaponResonance(WeaponInstance weaponInstance)
	{
		return weaponInstance.GetResonanceLevel() > 1;
	}

	// Token: 0x06018467 RID: 99431 RVA: 0x0062D398 File Offset: 0x0062B598
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

	// Token: 0x06018468 RID: 99432 RVA: 0x0062D3D8 File Offset: 0x0062B5D8
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

	// Token: 0x06018469 RID: 99433 RVA: 0x0062D418 File Offset: 0x0062B618
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

	// Token: 0x0601846A RID: 99434 RVA: 0x0062D47C File Offset: 0x0062B67C
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

	// Token: 0x0601846B RID: 99435 RVA: 0x0062D504 File Offset: 0x0062B704
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

	// Token: 0x0601846C RID: 99436 RVA: 0x0062D5A4 File Offset: 0x0062B7A4
	public List<ItemDataBase> GetWeaponExpItemListWithSort(List<ItemDataBase> dataList)
	{
		HashSet<int> hashSet = new HashSet<int>();
		hashSet.Add(2);
		hashSet.Add(10);
		hashSet.Add(8);
		SortModel.Instance.SortDataByData<ItemDataBase>(dataList, ESortDataType.Weapon, hashSet, true);
		return dataList;
	}

	// Token: 0x0601846D RID: 99437 RVA: 0x0062D5E0 File Offset: 0x0062B7E0
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

	// Token: 0x0601846E RID: 99438 RVA: 0x0062D6B0 File Offset: 0x0062B8B0
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

	// Token: 0x0601846F RID: 99439 RVA: 0x0062D734 File Offset: 0x0062B934
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

	// Token: 0x06018470 RID: 99440 RVA: 0x0062D7A4 File Offset: 0x0062B9A4
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

	// Token: 0x06018471 RID: 99441 RVA: 0x0062D80C File Offset: 0x0062BA0C
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

	// Token: 0x06018472 RID: 99442 RVA: 0x0062D8EC File Offset: 0x0062BAEC
	public bool RedDotWeaponBreachCondition(int roleId)
	{
		WeaponInstance weaponInstanceByRoleId = this.GetWeaponInstanceByRoleId(roleId);
		return weaponInstanceByRoleId != null && weaponInstanceByRoleId.CanGoBreach() && this.GetWeaponBreachState(weaponInstanceByRoleId.GetIncId().Value) == EWeaponBreachState.CanBreach;
	}

	// Token: 0x06018473 RID: 99443 RVA: 0x0062D928 File Offset: 0x0062BB28
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

	// Token: 0x06018474 RID: 99444 RVA: 0x0062D9E8 File Offset: 0x0062BBE8
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

	// Token: 0x06018475 RID: 99445 RVA: 0x0062DA44 File Offset: 0x0062BC44
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

	// Token: 0x06018476 RID: 99446 RVA: 0x0062DAD8 File Offset: 0x0062BCD8
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

	// Token: 0x170020BF RID: 8383
	// (get) Token: 0x06018477 RID: 99447 RVA: 0x0062DB60 File Offset: 0x0062BD60
	public static WeaponModel Instance
	{
		get
		{
			return WeaponModel._Instance;
		}
	}

	// Token: 0x06018478 RID: 99448 RVA: 0x0062DB67 File Offset: 0x0062BD67
	public static WeaponModel GetOrCreateInstance()
	{
		if (WeaponModel._Instance == null)
		{
			WeaponModel.CreateInstance();
		}
		return WeaponModel._Instance;
	}

	// Token: 0x06018479 RID: 99449 RVA: 0x0062DB7B File Offset: 0x0062BD7B
	public static bool CreateInstance()
	{
		if (WeaponModel._Instance != null)
		{
			return true;
		}
		WeaponModel._Instance = new WeaponModel();
		return true;
	}

	// Token: 0x0601847A RID: 99450 RVA: 0x0062DB91 File Offset: 0x0062BD91
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601847B RID: 99451 RVA: 0x0062DB93 File Offset: 0x0062BD93
	public static void ResetStaticDefaultValue()
	{
		WeaponModel._Instance = null;
	}

	// Token: 0x0601847C RID: 99452 RVA: 0x0062DB9B File Offset: 0x0062BD9B
	static WeaponModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WeaponModel.CreateStaticDefaultValue), new Action(WeaponModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400B43C RID: 46140
	private readonly Dictionary<int, WeaponInstance> WeaponDataMap = new Dictionary<int, WeaponInstance>();

	// Token: 0x0400B43D RID: 46141
	private readonly Dictionary<int, int> RoleWeaponDataMap = new Dictionary<int, int>();

	// Token: 0x0400B43E RID: 46142
	private EWeaponViewName CurSelectViewName;

	// Token: 0x0400B43F RID: 46143
	private readonly ConditionalWeakTable<USkeletalMeshComponent, object> WeaponBreachLevelMap = new ConditionalWeakTable<USkeletalMeshComponent, object>();

	// Token: 0x0400B440 RID: 46144
	public int BlueprintWeaponEquippedRoleId;

	// Token: 0x0400B441 RID: 46145
	public bool LevelUpConfirmTipsNotShow;

	// Token: 0x0400B442 RID: 46146
	[Nullable(2)]
	private static WeaponModel _Instance;
}
