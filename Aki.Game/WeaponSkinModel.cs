using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Skin;

// Token: 0x02002A62 RID: 10850
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class WeaponSkinModel : ModelBase
{
	// Token: 0x060169D3 RID: 92627 RVA: 0x005BB6B6 File Offset: 0x005B98B6
	public WeaponSkinModel()
	{
		this.UnLockSkinDataMap = new Dictionary<int, int>();
		this.RoleWeaponSkinDataMap = new Dictionary<int, int>();
	}

	// Token: 0x060169D4 RID: 92628 RVA: 0x005BB6D4 File Offset: 0x005B98D4
	protected override bool OnClear()
	{
		NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.WeaponSkinRedDot);
		return true;
	}

	// Token: 0x060169D5 RID: 92629 RVA: 0x005BB6E4 File Offset: 0x005B98E4
	private bool TryAddWeaponSkinRedDot(int configId)
	{
		if (NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.WeaponSkinRedDot, configId))
		{
			return false;
		}
		NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.WeaponSkinRedDot, configId);
		return true;
	}

	// Token: 0x060169D6 RID: 92630 RVA: 0x005BB708 File Offset: 0x005B9908
	private void NotifyFightWeaponSkinChange(int roleId, int skinId)
	{
		if (skinId == -1)
		{
			int modelId = WeaponModel.Instance.GetWeaponDataByRoleDataId(roleId, true).GetItemConfig().ModelId;
			EventSystem.Instance.Emit<int, int>(EEventName.FightWeaponSkinChange, roleId, modelId);
			return;
		}
		int modelId2 = SkinConfig.Instance.GetWeaponSkinConfig(skinId).ModelId;
		EventSystem.Instance.Emit<int, int>(EEventName.FightWeaponSkinChange, roleId, modelId2);
	}

	// Token: 0x060169D7 RID: 92631 RVA: 0x005BB76C File Offset: 0x005B996C
	private void SetWeaponSkinData(IList<RoleSkinEquipData> skinEquipDataList)
	{
		foreach (RoleSkinEquipData roleSkinEquipData in skinEquipDataList)
		{
			this.RoleWeaponSkinDataMap[roleSkinEquipData.RoleID] = roleSkinEquipData.SkinItemId;
			this.NotifyFightWeaponSkinChange(roleSkinEquipData.RoleID, roleSkinEquipData.SkinItemId);
		}
	}

	// Token: 0x060169D8 RID: 92632 RVA: 0x005BB7D8 File Offset: 0x005B99D8
	public void UpdateWeaponSkinData(int roleId, int weaponSkinId)
	{
		this.RoleWeaponSkinDataMap[roleId] = weaponSkinId;
		this.NotifyFightWeaponSkinChange(roleId, weaponSkinId);
	}

	// Token: 0x060169D9 RID: 92633 RVA: 0x005BB7EF File Offset: 0x005B99EF
	public void NotifyWeaponSkinData([Nullable(new byte[]
	{
		2,
		1
	})] IList<RoleSkinEquipData> skinEquipDataList)
	{
		if (skinEquipDataList == null)
		{
			return;
		}
		this.SetWeaponSkinData(skinEquipDataList);
	}

	// Token: 0x060169DA RID: 92634 RVA: 0x005BB7FC File Offset: 0x005B99FC
	public void EquipWeaponSkinData([Nullable(new byte[]
	{
		2,
		1
	})] IList<RoleSkinEquipData> skinEquipDataList)
	{
		if (skinEquipDataList == null)
		{
			return;
		}
		this.SetWeaponSkinData(skinEquipDataList);
		RoleSkinEquipData roleSkinEquipData = skinEquipDataList[0];
		EventSystem.Instance.Emit<int, int>(EEventName.EquipWeaponSkin, roleSkinEquipData.RoleID, roleSkinEquipData.SkinItemId);
	}

	// Token: 0x060169DB RID: 92635 RVA: 0x005BB838 File Offset: 0x005B9A38
	public void DeleteWeaponSkinData(int roleId)
	{
		this.RoleWeaponSkinDataMap.Remove(roleId);
		EventSystem.Instance.Emit<int>(EEventName.UninstallWeaponSkin, roleId);
		this.NotifyFightWeaponSkinChange(roleId, -1);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.WeaponSkin;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "武器皮肤卸载";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", roleId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x060169DC RID: 92636 RVA: 0x005BB89C File Offset: 0x005B9A9C
	public int GetSkinIdByRoleId(int roleId)
	{
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
		if (roleDataById != null && roleDataById.IsTrialRole())
		{
			WeaponTrialData weaponData = (roleDataById as RoleRobotData).GetWeaponData();
			return ((weaponData != null) ? new int?(weaponData.GetSkinId()) : null).GetValueOrDefault(-1);
		}
		int result;
		if (this.RoleWeaponSkinDataMap.TryGetValue(roleId, out result))
		{
			return result;
		}
		return -1;
	}

	// Token: 0x060169DD RID: 92637 RVA: 0x005BB904 File Offset: 0x005B9B04
	public int? GetRoleIdBySkinId(int skinId)
	{
		foreach (KeyValuePair<int, int> keyValuePair in this.RoleWeaponSkinDataMap)
		{
			if (keyValuePair.Value == skinId)
			{
				return new int?(keyValuePair.Key);
			}
		}
		return null;
	}

	// Token: 0x060169DE RID: 92638 RVA: 0x005BB974 File Offset: 0x005B9B74
	public void NotifyAllUnlockSkinData(IList<int> skinIdList)
	{
		foreach (int key in skinIdList)
		{
			this.UnLockSkinDataMap[key] = 1;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.WeaponSkin;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "武器皮肤登录推送";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("skinIdList", skinIdList);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x060169DF RID: 92639 RVA: 0x005BB9EC File Offset: 0x005B9BEC
	public void SetUnlockSkinData(IList<int> skinIdList)
	{
		foreach (int num in skinIdList)
		{
			this.UnLockSkinDataMap[num] = 1;
			this.TryAddWeaponSkinRedDot(num);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.WeaponSkin;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "武器皮肤添加";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("skinIdList", skinIdList);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x060169E0 RID: 92640 RVA: 0x005BBA6C File Offset: 0x005B9C6C
	public void RefreshUnlockSkinData(IList<int> skinIdList)
	{
		this.UnLockSkinDataMap.Clear();
		foreach (int key in skinIdList)
		{
			this.UnLockSkinDataMap[key] = 1;
		}
	}

	// Token: 0x060169E1 RID: 92641 RVA: 0x005BBAC8 File Offset: 0x005B9CC8
	public int GetSkinCountById(int skinId)
	{
		int result;
		if (this.UnLockSkinDataMap.TryGetValue(skinId, out result))
		{
			return result;
		}
		return 0;
	}

	// Token: 0x060169E2 RID: 92642 RVA: 0x005BBAE8 File Offset: 0x005B9CE8
	public bool HasWeaponSkinRedDot(int skinType)
	{
		foreach (WeaponSkin weaponSkin in SkinConfig.Instance.GetWeaponSkinConfigListByType(skinType))
		{
			if (this.UnLockSkinDataMap.ContainsKey(weaponSkin.Id) && !weaponSkin.HideInSkinView && NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.WeaponSkinRedDot, weaponSkin.Id))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060169E3 RID: 92643 RVA: 0x005BBB6C File Offset: 0x005B9D6C
	public bool RedDotWeaponSkinCondition(int roleId)
	{
		WeaponInstance weaponInstanceByRoleId = WeaponModel.Instance.GetWeaponInstanceByRoleId(roleId);
		if (weaponInstanceByRoleId == null)
		{
			return false;
		}
		int weaponType = weaponInstanceByRoleId.GetWeaponConfig().Value.WeaponType;
		return this.HasWeaponSkinRedDot(weaponType);
	}

	// Token: 0x17001E06 RID: 7686
	// (get) Token: 0x060169E4 RID: 92644 RVA: 0x005BBBA8 File Offset: 0x005B9DA8
	public static WeaponSkinModel Instance
	{
		get
		{
			return WeaponSkinModel._Instance;
		}
	}

	// Token: 0x060169E5 RID: 92645 RVA: 0x005BBBAF File Offset: 0x005B9DAF
	public static WeaponSkinModel GetOrCreateInstance()
	{
		if (WeaponSkinModel._Instance == null)
		{
			WeaponSkinModel.CreateInstance();
		}
		return WeaponSkinModel._Instance;
	}

	// Token: 0x060169E6 RID: 92646 RVA: 0x005BBBC3 File Offset: 0x005B9DC3
	public static bool CreateInstance()
	{
		if (WeaponSkinModel._Instance != null)
		{
			return true;
		}
		WeaponSkinModel._Instance = new WeaponSkinModel();
		return true;
	}

	// Token: 0x060169E7 RID: 92647 RVA: 0x005BBBD9 File Offset: 0x005B9DD9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060169E8 RID: 92648 RVA: 0x005BBBDB File Offset: 0x005B9DDB
	public static void ResetStaticDefaultValue()
	{
		WeaponSkinModel._Instance = null;
	}

	// Token: 0x060169E9 RID: 92649 RVA: 0x005BBBE3 File Offset: 0x005B9DE3
	static WeaponSkinModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WeaponSkinModel.CreateStaticDefaultValue), new Action(WeaponSkinModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400A7B9 RID: 42937
	private readonly Dictionary<int, int> UnLockSkinDataMap;

	// Token: 0x0400A7BA RID: 42938
	private readonly Dictionary<int, int> RoleWeaponSkinDataMap;

	// Token: 0x0400A7BB RID: 42939
	[Nullable(2)]
	private static WeaponSkinModel _Instance;
}
