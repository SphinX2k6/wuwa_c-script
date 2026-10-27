using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Game.Ui;

// Token: 0x02002A29 RID: 10793
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class RoleSkinModel : ModelBase
{
	// Token: 0x06016715 RID: 91925 RVA: 0x005AE314 File Offset: 0x005AC514
	public void UpdateUnlockRoleSkin(List<int> itemIdList)
	{
		foreach (int itemId in itemIdList)
		{
			RoleSkinData roleSkinData = this.GetRoleSkinData(itemId);
			if (roleSkinData != null)
			{
				roleSkinData.UnlockSkin();
			}
		}
	}

	// Token: 0x06016716 RID: 91926 RVA: 0x005AE36C File Offset: 0x005AC56C
	public void UpdateUnlockRoleSkinDataFull(List<int> itemIdList)
	{
		foreach (RoleSkinData roleSkinData in this.RoleSkinMap.Values)
		{
			roleSkinData.LockSkin();
		}
		foreach (int itemId in itemIdList)
		{
			RoleSkinData roleSkinData2 = this.GetRoleSkinData(itemId);
			if (roleSkinData2 != null)
			{
				roleSkinData2.UnlockSkin();
			}
		}
	}

	// Token: 0x06016717 RID: 91927 RVA: 0x005AE408 File Offset: 0x005AC608
	public void UpdateWeaponSkinFirstWearRecord(List<int> itemIdList)
	{
		foreach (int itemId in itemIdList)
		{
			RoleSkinData roleSkinData = this.GetRoleSkinData(itemId);
			if (roleSkinData != null)
			{
				int suitWeaponSkinId = roleSkinData.GetRoleSkinConfig().SuitWeaponSkinId;
				if (suitWeaponSkinId > 0)
				{
					this.RecordSuitWeaponFirstWear(suitWeaponSkinId, true);
				}
			}
		}
	}

	// Token: 0x06016718 RID: 91928 RVA: 0x005AE478 File Offset: 0x005AC678
	public void AddRoleSkinNewFlag(List<int> itemIdList)
	{
		foreach (int num in itemIdList)
		{
			RoleSkinData roleSkinData = this.GetRoleSkinData(num);
			if (roleSkinData != null && !roleSkinData.IsOriginalSkin())
			{
				NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.RoleSkinRedDot, num);
				NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.RoleSkinRedDot);
				EventSystem.Instance.Emit<int>(EEventName.RoleSkinRedDotRefresh, roleSkinData.GetRoleId());
				EventSystem.Instance.Emit(EEventName.MainViewRoleButtonRefreshByRoleSkin);
			}
		}
	}

	// Token: 0x06016719 RID: 91929 RVA: 0x005AE514 File Offset: 0x005AC714
	[NullableContext(2)]
	public unsafe RoleSkinData GetRoleSkinData(int itemId)
	{
		RoleSkinData result;
		if (this.RoleSkinMap.TryGetValue(itemId, out result))
		{
			return result;
		}
		InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(itemId));
		if (itemDataTypeByConfigId != InventoryDefine.EItemDataType.RoleSkinItem)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RoleSkin;
			ELogAuthor author = ELogAuthor.BB;
			string message = "无效的皮肤道具id";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("itemId", itemId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("itemType", itemDataTypeByConfigId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		RoleSkinData roleSkinData = new RoleSkinData(itemId);
		this.RoleSkinMap[itemId] = roleSkinData;
		return roleSkinData;
	}

	// Token: 0x0601671A RID: 91930 RVA: 0x005AE5C0 File Offset: 0x005AC7C0
	[NullableContext(2)]
	public RoleSkinData GetRoleSkinDataByRoleId(int roleId)
	{
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
		if (roleDataById == null)
		{
			return null;
		}
		int roleSkinId = roleDataById.GetRoleSkinId();
		return this.GetRoleSkinData(roleSkinId);
	}

	// Token: 0x0601671B RID: 91931 RVA: 0x005AE5F0 File Offset: 0x005AC7F0
	[NullableContext(2)]
	public RoleSkinData GetRoleOriginalSkinData(int roleId, bool ifSelf = true)
	{
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, ifSelf);
		if (roleDataById == null)
		{
			return null;
		}
		int skinId = roleDataById.GetRoleConfig().SkinId;
		return this.GetRoleSkinData(skinId);
	}

	// Token: 0x0601671C RID: 91932 RVA: 0x005AE628 File Offset: 0x005AC828
	public int GetRoleSkinIdByRoleId(int roleId)
	{
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
		if (roleDataById == null)
		{
			return -1;
		}
		return roleDataById.GetRoleSkinId();
	}

	// Token: 0x0601671D RID: 91933 RVA: 0x005AE650 File Offset: 0x005AC850
	public bool CheckHasRoleSkin(int itemId)
	{
		RoleSkinData roleSkinData = this.GetRoleSkinData(itemId);
		return roleSkinData != null && roleSkinData.IsLocked();
	}

	// Token: 0x0601671E RID: 91934 RVA: 0x005AE670 File Offset: 0x005AC870
	public void UnlockSkin(int itemId)
	{
		RoleSkinData roleSkinData = this.GetRoleSkinData(itemId);
		if (roleSkinData == null)
		{
			return;
		}
		roleSkinData.UnlockSkin();
	}

	// Token: 0x0601671F RID: 91935 RVA: 0x005AE690 File Offset: 0x005AC890
	public int GetSkinCountById(int itemId)
	{
		RoleSkinData roleSkinData = this.GetRoleSkinData(itemId);
		if (roleSkinData == null)
		{
			return -1;
		}
		return roleSkinData.GetItemCount();
	}

	// Token: 0x06016720 RID: 91936 RVA: 0x005AE6B0 File Offset: 0x005AC8B0
	public List<UiDynamicTab> GetSkinTabList(bool isMainRole, int roleId)
	{
		List<UiDynamicTab> viewTabList = DynamicTabConfig.Instance.GetViewTabList(EUiViewName.SkinRootView);
		int count = viewTabList.Count;
		List<UiDynamicTab> list = new List<UiDynamicTab>();
		for (int i = 0; i < count; i++)
		{
			UiDynamicTab item = viewTabList[i];
			if (FunctionModel.Instance.IsOpen(item.FunctionId) && (!(item.ChildViewName == EUiTabViewName.CalabashSkinTabView) || isMainRole) && (!(item.ChildViewName == EUiTabViewName.RoleOrnamentTabView) || this.CanShowOrnamentTab(roleId)))
			{
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x06016721 RID: 91937 RVA: 0x005AE74C File Offset: 0x005AC94C
	private bool CanShowOrnamentTab(int roleId)
	{
		IReadOnlyList<RoleSkin> roleSkinConfigList = SkinConfig.Instance.GetRoleSkinConfigList(roleId);
		if (roleSkinConfigList == null)
		{
			return false;
		}
		foreach (RoleSkin roleSkin in roleSkinConfigList)
		{
			if (RoleOrnamentModel.Instance.GetSkinAllOrnaments(roleSkin.Id, null).Count > 0)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06016722 RID: 91938 RVA: 0x005AE7CC File Offset: 0x005AC9CC
	public List<RoleSkinData> GetRoleSkinDataList(int roleId)
	{
		IReadOnlyList<RoleSkin> roleSkinConfigList = SkinConfig.Instance.GetRoleSkinConfigList(roleId);
		if (roleSkinConfigList == null)
		{
			return new List<RoleSkinData>();
		}
		List<RoleSkinData> list = new List<RoleSkinData>();
		foreach (RoleSkin roleSkin in roleSkinConfigList)
		{
			RoleSkinData roleSkinData = this.GetRoleSkinData(roleSkin.Id);
			if (roleSkinData != null)
			{
				list.Add(roleSkinData);
			}
		}
		list.Sort(delegate(RoleSkinData a, RoleSkinData b)
		{
			int sortIndex = a.GetRoleSkinConfig().SortIndex;
			int sortIndex2 = b.GetRoleSkinConfig().SortIndex;
			return sortIndex - sortIndex2;
		});
		return list;
	}

	// Token: 0x06016723 RID: 91939 RVA: 0x005AE86C File Offset: 0x005ACA6C
	public bool HasRoleSkinRedDotByRoleId(int roleId)
	{
		foreach (RoleSkinData roleSkinData in this.GetRoleSkinDataList(roleId))
		{
			RoleSkinData roleSkinData2 = this.GetRoleSkinData(roleSkinData.GetItemId());
			if (roleSkinData2 != null && !roleSkinData2.IsLocked() && NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.RoleSkinRedDot, roleSkinData.GetItemId()))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06016724 RID: 91940 RVA: 0x005AE8EC File Offset: 0x005ACAEC
	public bool CheckSuitWeaponFirstWear(int weaponSkinId)
	{
		this.TryLocalOverrideToServerStorage();
		return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.SuitWeaponFirstWearRecord) as ServerStorageSet).Has(weaponSkinId);
	}

	// Token: 0x06016725 RID: 91941 RVA: 0x005AE90C File Offset: 0x005ACB0C
	private void TryLocalOverrideToServerStorage()
	{
		if (this.HasOverrideServerStorage)
		{
			return;
		}
		this.HasOverrideServerStorage = true;
		Dictionary<int, bool> player = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.SuitWeaponFirstWearRecord, null);
		if (player == null)
		{
			return;
		}
		ServerStorageSet serverStorageSet = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.SuitWeaponFirstWearRecord) as ServerStorageSet;
		foreach (KeyValuePair<int, bool> keyValuePair in player)
		{
			int num;
			bool flag;
			keyValuePair.Deconstruct(out num, out flag);
			int value = num;
			if (flag)
			{
				serverStorageSet.Add(value);
			}
		}
	}

	// Token: 0x06016726 RID: 91942 RVA: 0x005AE99C File Offset: 0x005ACB9C
	public void RecordSuitWeaponFirstWear(int weaponSkinId, bool isFirstWear)
	{
		this.TryLocalOverrideToServerStorage();
		ServerStorageSet serverStorageSet = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.SuitWeaponFirstWearRecord) as ServerStorageSet;
		if (isFirstWear)
		{
			serverStorageSet.Add(weaponSkinId);
		}
		else
		{
			serverStorageSet.Remove(weaponSkinId);
		}
		Dictionary<int, bool> dictionary = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.SuitWeaponFirstWearRecord, null) ?? new Dictionary<int, bool>();
		dictionary[weaponSkinId] = isFirstWear;
		LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.SuitWeaponFirstWearRecord, dictionary);
	}

	// Token: 0x17001DD6 RID: 7638
	// (get) Token: 0x06016727 RID: 91943 RVA: 0x005AE9F7 File Offset: 0x005ACBF7
	public static RoleSkinModel Instance
	{
		get
		{
			return RoleSkinModel._Instance;
		}
	}

	// Token: 0x06016728 RID: 91944 RVA: 0x005AE9FE File Offset: 0x005ACBFE
	public static RoleSkinModel GetOrCreateInstance()
	{
		if (RoleSkinModel._Instance == null)
		{
			RoleSkinModel.CreateInstance();
		}
		return RoleSkinModel._Instance;
	}

	// Token: 0x06016729 RID: 91945 RVA: 0x005AEA12 File Offset: 0x005ACC12
	public static bool CreateInstance()
	{
		if (RoleSkinModel._Instance != null)
		{
			return true;
		}
		RoleSkinModel._Instance = new RoleSkinModel();
		return true;
	}

	// Token: 0x0601672A RID: 91946 RVA: 0x005AEA28 File Offset: 0x005ACC28
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601672B RID: 91947 RVA: 0x005AEA2A File Offset: 0x005ACC2A
	public static void ResetStaticDefaultValue()
	{
		RoleSkinModel._Instance = null;
	}

	// Token: 0x0601672C RID: 91948 RVA: 0x005AEA32 File Offset: 0x005ACC32
	static RoleSkinModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleSkinModel.CreateStaticDefaultValue), new Action(RoleSkinModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400A6C8 RID: 42696
	private readonly Dictionary<int, RoleSkinData> RoleSkinMap = new Dictionary<int, RoleSkinData>();

	// Token: 0x0400A6C9 RID: 42697
	private bool HasOverrideServerStorage;

	// Token: 0x0400A6CA RID: 42698
	[Nullable(2)]
	private static RoleSkinModel _Instance;
}
