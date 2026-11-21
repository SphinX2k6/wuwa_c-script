using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Skin;

// Token: 0x02001FDD RID: 8157
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class WeaponSkinModel : ModelBase
{
	// Token: 0x060143F4 RID: 82932 RVA: 0x005E783E File Offset: 0x005E5A3E
	public WeaponSkinModel()
	{
		this.UnLockSkinDataMap = new Dictionary<int, int>();
		this.RoleWeaponSkinDataMap = new Dictionary<int, int>();
	}

	// Token: 0x060143F5 RID: 82933 RVA: 0x005E785C File Offset: 0x005E5A5C
	protected override bool OnClear()
	{
		NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.WeaponSkinRedDot);
		return true;
	}

	// Token: 0x060143F6 RID: 82934 RVA: 0x005E786C File Offset: 0x005E5A6C
	private bool TryAddWeaponSkinRedDot(int configId)
	{
		if (NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.WeaponSkinRedDot, configId))
		{
			return false;
		}
		NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.WeaponSkinRedDot, configId);
		return true;
	}

	// Token: 0x060143F7 RID: 82935 RVA: 0x005E7890 File Offset: 0x005E5A90
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

	// Token: 0x060143F8 RID: 82936 RVA: 0x005E78F4 File Offset: 0x005E5AF4
	private void SetWeaponSkinData(IList<RoleSkinEquipData> skinEquipDataList)
	{
		foreach (RoleSkinEquipData roleSkinEquipData in skinEquipDataList)
		{
			this.RoleWeaponSkinDataMap[roleSkinEquipData.RoleID] = roleSkinEquipData.SkinItemId;
			this.NotifyFightWeaponSkinChange(roleSkinEquipData.RoleID, roleSkinEquipData.SkinItemId);
		}
	}

	// Token: 0x060143F9 RID: 82937 RVA: 0x005E7960 File Offset: 0x005E5B60
	public void UpdateWeaponSkinData(int roleId, int weaponSkinId)
	{
		this.RoleWeaponSkinDataMap[roleId] = weaponSkinId;
		this.NotifyFightWeaponSkinChange(roleId, weaponSkinId);
	}

	// Token: 0x060143FA RID: 82938 RVA: 0x005E7977 File Offset: 0x005E5B77
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

	// Token: 0x060143FB RID: 82939 RVA: 0x005E7984 File Offset: 0x005E5B84
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

	// Token: 0x060143FC RID: 82940 RVA: 0x005E79C0 File Offset: 0x005E5BC0
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

	// Token: 0x060143FD RID: 82941 RVA: 0x005E7A24 File Offset: 0x005E5C24
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

	// Token: 0x060143FE RID: 82942 RVA: 0x005E7A8C File Offset: 0x005E5C8C
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

	// Token: 0x060143FF RID: 82943 RVA: 0x005E7AFC File Offset: 0x005E5CFC
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

	// Token: 0x06014400 RID: 82944 RVA: 0x005E7B74 File Offset: 0x005E5D74
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

	// Token: 0x06014401 RID: 82945 RVA: 0x005E7BF4 File Offset: 0x005E5DF4
	public void RefreshUnlockSkinData(IList<int> skinIdList)
	{
		this.UnLockSkinDataMap.Clear();
		foreach (int key in skinIdList)
		{
			this.UnLockSkinDataMap[key] = 1;
		}
	}

	// Token: 0x06014402 RID: 82946 RVA: 0x005E7C50 File Offset: 0x005E5E50
	public int GetSkinCountById(int skinId)
	{
		int result;
		if (this.UnLockSkinDataMap.TryGetValue(skinId, out result))
		{
			return result;
		}
		return 0;
	}

	// Token: 0x06014403 RID: 82947 RVA: 0x005E7C70 File Offset: 0x005E5E70
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

	// Token: 0x06014404 RID: 82948 RVA: 0x005E7CF4 File Offset: 0x005E5EF4
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

	// Token: 0x17001E5E RID: 7774
	// (get) Token: 0x06014405 RID: 82949 RVA: 0x005E7D30 File Offset: 0x005E5F30
	public static WeaponSkinModel Instance
	{
		get
		{
			return WeaponSkinModel._Instance;
		}
	}

	// Token: 0x06014406 RID: 82950 RVA: 0x005E7D37 File Offset: 0x005E5F37
	public static WeaponSkinModel GetOrCreateInstance()
	{
		if (WeaponSkinModel._Instance == null)
		{
			WeaponSkinModel.CreateInstance();
		}
		return WeaponSkinModel._Instance;
	}

	// Token: 0x06014407 RID: 82951 RVA: 0x005E7D4B File Offset: 0x005E5F4B
	public static bool CreateInstance()
	{
		if (WeaponSkinModel._Instance != null)
		{
			return true;
		}
		WeaponSkinModel._Instance = new WeaponSkinModel();
		return true;
	}

	// Token: 0x06014408 RID: 82952 RVA: 0x005E7D61 File Offset: 0x005E5F61
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014409 RID: 82953 RVA: 0x005E7D63 File Offset: 0x005E5F63
	public static void ResetStaticDefaultValue()
	{
		WeaponSkinModel._Instance = null;
	}

	// Token: 0x0601440A RID: 82954 RVA: 0x005E7D6B File Offset: 0x005E5F6B
	static WeaponSkinModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WeaponSkinModel.CreateStaticDefaultValue), new Action(WeaponSkinModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400ABBD RID: 43965
	private readonly Dictionary<int, int> UnLockSkinDataMap;

	// Token: 0x0400ABBE RID: 43966
	private readonly Dictionary<int, int> RoleWeaponSkinDataMap;

	// Token: 0x0400ABBF RID: 43967
	[Nullable(2)]
	private static WeaponSkinModel _Instance;
}
