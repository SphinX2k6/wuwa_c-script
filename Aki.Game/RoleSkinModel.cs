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

// Token: 0x02001FA4 RID: 8100
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class RoleSkinModel : ModelBase
{
	// Token: 0x0601411B RID: 82203 RVA: 0x005D9324 File Offset: 0x005D7524
	public void UpdateUnlockRoleSkin(IEnumerable<int> itemIdList)
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

	// Token: 0x0601411C RID: 82204 RVA: 0x005D9378 File Offset: 0x005D7578
	public void UpdateUnlockRoleSkinDataFull(IEnumerable<int> itemIdList)
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

	// Token: 0x0601411D RID: 82205 RVA: 0x005D9410 File Offset: 0x005D7610
	public void UpdateWeaponSkinFirstWearRecord(IEnumerable<int> itemIdList)
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

	// Token: 0x0601411E RID: 82206 RVA: 0x005D9478 File Offset: 0x005D7678
	public void AddRoleSkinNewFlag(IEnumerable<int> itemIdList)
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

	// Token: 0x0601411F RID: 82207 RVA: 0x005D9510 File Offset: 0x005D7710
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

	// Token: 0x06014120 RID: 82208 RVA: 0x005D95BC File Offset: 0x005D77BC
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

	// Token: 0x06014121 RID: 82209 RVA: 0x005D95EC File Offset: 0x005D77EC
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

	// Token: 0x06014122 RID: 82210 RVA: 0x005D9624 File Offset: 0x005D7824
	public int GetRoleSkinIdByRoleId(int roleId)
	{
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
		if (roleDataById == null)
		{
			return -1;
		}
		return roleDataById.GetRoleSkinId();
	}

	// Token: 0x06014123 RID: 82211 RVA: 0x005D964C File Offset: 0x005D784C
	public bool CheckHasRoleSkin(int itemId)
	{
		RoleSkinData roleSkinData = this.GetRoleSkinData(itemId);
		return roleSkinData != null && roleSkinData.IsLocked();
	}

	// Token: 0x06014124 RID: 82212 RVA: 0x005D966C File Offset: 0x005D786C
	public void UnlockSkin(int itemId)
	{
		RoleSkinData roleSkinData = this.GetRoleSkinData(itemId);
		if (roleSkinData == null)
		{
			return;
		}
		roleSkinData.UnlockSkin();
	}

	// Token: 0x06014125 RID: 82213 RVA: 0x005D968C File Offset: 0x005D788C
	public int GetSkinCountById(int itemId)
	{
		RoleSkinData roleSkinData = this.GetRoleSkinData(itemId);
		if (roleSkinData == null)
		{
			return -1;
		}
		return roleSkinData.GetItemCount();
	}

	// Token: 0x06014126 RID: 82214 RVA: 0x005D96AC File Offset: 0x005D78AC
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

	// Token: 0x06014127 RID: 82215 RVA: 0x005D9748 File Offset: 0x005D7948
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

	// Token: 0x06014128 RID: 82216 RVA: 0x005D97C8 File Offset: 0x005D79C8
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

	// Token: 0x06014129 RID: 82217 RVA: 0x005D9868 File Offset: 0x005D7A68
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

	// Token: 0x0601412A RID: 82218 RVA: 0x005D98E8 File Offset: 0x005D7AE8
	public bool CheckSuitWeaponFirstWear(int weaponSkinId)
	{
		this.TryLocalOverrideToServerStorage();
		return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.SuitWeaponFirstWearRecord) as ServerStorageSet).Has(weaponSkinId);
	}

	// Token: 0x0601412B RID: 82219 RVA: 0x005D9908 File Offset: 0x005D7B08
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

	// Token: 0x0601412C RID: 82220 RVA: 0x005D9998 File Offset: 0x005D7B98
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

	// Token: 0x17001E2E RID: 7726
	// (get) Token: 0x0601412D RID: 82221 RVA: 0x005D99F3 File Offset: 0x005D7BF3
	public static RoleSkinModel Instance
	{
		get
		{
			return RoleSkinModel._Instance;
		}
	}

	// Token: 0x0601412E RID: 82222 RVA: 0x005D99FA File Offset: 0x005D7BFA
	public static RoleSkinModel GetOrCreateInstance()
	{
		if (RoleSkinModel._Instance == null)
		{
			RoleSkinModel.CreateInstance();
		}
		return RoleSkinModel._Instance;
	}

	// Token: 0x0601412F RID: 82223 RVA: 0x005D9A0E File Offset: 0x005D7C0E
	public static bool CreateInstance()
	{
		if (RoleSkinModel._Instance != null)
		{
			return true;
		}
		RoleSkinModel._Instance = new RoleSkinModel();
		return true;
	}

	// Token: 0x06014130 RID: 82224 RVA: 0x005D9A24 File Offset: 0x005D7C24
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014131 RID: 82225 RVA: 0x005D9A26 File Offset: 0x005D7C26
	public static void ResetStaticDefaultValue()
	{
		RoleSkinModel._Instance = null;
	}

	// Token: 0x06014132 RID: 82226 RVA: 0x005D9A2E File Offset: 0x005D7C2E
	static RoleSkinModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleSkinModel.CreateStaticDefaultValue), new Action(RoleSkinModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400AAB2 RID: 43698
	private readonly Dictionary<int, RoleSkinData> RoleSkinMap = new Dictionary<int, RoleSkinData>();

	// Token: 0x0400AAB3 RID: 43699
	private bool HasOverrideServerStorage;

	// Token: 0x0400AAB4 RID: 43700
	[Nullable(2)]
	private static RoleSkinModel _Instance;
}
