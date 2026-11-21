using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.KeySetting;

// Token: 0x020016EB RID: 5867
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class MenuBaseConfig : ConfigBase
{
	// Token: 0x0600E3EA RID: 58346 RVA: 0x0042DEFC File Offset: 0x0042C0FC
	public IReadOnlyList<MenuConfig> GetMenuBaseConfig()
	{
		IReadOnlyList<MenuConfig> configList = ConfigMenuConfigAll.GetConfigList(true);
		if (configList != null && configList.Count > 0)
		{
			return configList;
		}
		Log.Instance.Error(ELogModule.Menu, ELogAuthor.WZ, "没有基础配置文件，请检查配置表是否缺失", default(ReadOnlySpan<ValueTuple<string, object>>));
		return null;
	}

	// Token: 0x0600E3EB RID: 58347 RVA: 0x0042DF3C File Offset: 0x0042C13C
	public Dictionary<int, MainType> GetMainConfig()
	{
		IReadOnlyList<MainType> configList = ConfigMainTypeAll.GetConfigList(true);
		if (configList != null && configList.Count > 0)
		{
			Dictionary<int, MainType> dictionary = new Dictionary<int, MainType>();
			foreach (MainType value in configList)
			{
				dictionary[value.Id] = value;
			}
			return dictionary;
		}
		Log.Instance.Error(ELogModule.Menu, ELogAuthor.WZ, "没有对应的主类型基础配置，请检查配置表是否缺失", default(ReadOnlySpan<ValueTuple<string, object>>));
		return null;
	}

	// Token: 0x0600E3EC RID: 58348 RVA: 0x0042DFC4 File Offset: 0x0042C1C4
	public MainType? GetMainTypeConfigById(int tabId)
	{
		return ConfigMainTypeById.GetConfig(tabId, true);
	}

	// Token: 0x0600E3ED RID: 58349 RVA: 0x0042DFCD File Offset: 0x0042C1CD
	public MenuConfig? GetMenuConfigByFunctionId(int functionId)
	{
		return ConfigMenuConfigByFunctionId.GetConfig(functionId, true);
	}

	// Token: 0x0600E3EE RID: 58350 RVA: 0x0042DFD6 File Offset: 0x0042C1D6
	public IReadOnlyList<MenuConfig> GetMenuConfigListByFunctionId(int functionId)
	{
		return ConfigMenuConfigByFunctionId.GetConfigList(functionId, true);
	}

	// Token: 0x0600E3EF RID: 58351 RVA: 0x0042DFDF File Offset: 0x0042C1DF
	public IReadOnlyList<KeyType> GetAllKeyTypeConfig()
	{
		return ConfigKeyTypeAll.GetConfigList(true);
	}

	// Token: 0x0600E3F0 RID: 58352 RVA: 0x0042DFE7 File Offset: 0x0042C1E7
	public IReadOnlyList<KeySetting> GetKeySettingConfigListByTypeIdAndInputControllerType(int typeId, int inputControllerTypeId)
	{
		return ConfigKeySettingByTypeIdAndInputControllerType.GetConfigList(typeId, inputControllerTypeId, true);
	}

	// Token: 0x0600E3F1 RID: 58353 RVA: 0x0042DFF1 File Offset: 0x0042C1F1
	public IReadOnlyList<AxisRevert> GetAxisRevertConfigListByRevertType(int revertType)
	{
		return ConfigAxisRevertByRevertType.GetConfigList(revertType, true);
	}

	// Token: 0x0600E3F2 RID: 58354 RVA: 0x0042DFFA File Offset: 0x0042C1FA
	public IReadOnlyList<KeySetting> GetExclusiveKeySettingConfigByTypeIdAndInputControllerType(int typeId, int inputControllerTypeId, EKeySettingExclusiveType exclusiveType)
	{
		return ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.GetConfigList(typeId, inputControllerTypeId, (int)exclusiveType, true);
	}

	// Token: 0x0600E3F3 RID: 58355 RVA: 0x0042E005 File Offset: 0x0042C205
	public KeyExclusiveType? GetExclusiveTypeConfigById(int typeId)
	{
		return ConfigKeyExclusiveTypeById.GetConfig(typeId, true);
	}

	// Token: 0x0600E3F4 RID: 58356 RVA: 0x0042E00E File Offset: 0x0042C20E
	public MenuDetailPop? GetMenuDetailPopConfigById(int configId)
	{
		return ConfigMenuDetailPopById.GetConfig(configId, true);
	}

	// Token: 0x0600E3F5 RID: 58357 RVA: 0x0042E017 File Offset: 0x0042C217
	public MenuDetailPopItem? GetMenuDetailPopItemConfigById(int configId)
	{
		return ConfigMenuDetailPopItemById.GetConfig(configId, true);
	}

	// Token: 0x0600E3F6 RID: 58358 RVA: 0x0042E020 File Offset: 0x0042C220
	public RoleVoiceLanguage? GetRoleLangCustomConfigById(int configId)
	{
		return ConfigRoleVoiceLanguageByLanguageId.GetConfig(configId, true);
	}

	// Token: 0x170015C0 RID: 5568
	// (get) Token: 0x0600E3F7 RID: 58359 RVA: 0x0042E029 File Offset: 0x0042C229
	[Nullable(1)]
	public static MenuBaseConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return MenuBaseConfig._Instance;
		}
	}

	// Token: 0x0600E3F8 RID: 58360 RVA: 0x0042E030 File Offset: 0x0042C230
	[NullableContext(1)]
	public static MenuBaseConfig GetOrCreateInstance()
	{
		if (MenuBaseConfig._Instance == null)
		{
			MenuBaseConfig.CreateInstance();
		}
		return MenuBaseConfig._Instance;
	}

	// Token: 0x0600E3F9 RID: 58361 RVA: 0x0042E044 File Offset: 0x0042C244
	public static bool CreateInstance()
	{
		if (MenuBaseConfig._Instance != null)
		{
			return true;
		}
		MenuBaseConfig._Instance = new MenuBaseConfig();
		return true;
	}

	// Token: 0x0600E3FA RID: 58362 RVA: 0x0042E05A File Offset: 0x0042C25A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E3FB RID: 58363 RVA: 0x0042E05C File Offset: 0x0042C25C
	public static void ResetStaticDefaultValue()
	{
		MenuBaseConfig._Instance = null;
	}

	// Token: 0x0600E3FC RID: 58364 RVA: 0x0042E064 File Offset: 0x0042C264
	static MenuBaseConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MenuBaseConfig.CreateStaticDefaultValue), new Action(MenuBaseConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04008233 RID: 33331
	private static MenuBaseConfig _Instance;
}
