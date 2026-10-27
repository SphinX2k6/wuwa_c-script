using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.KeySetting;

// Token: 0x02002207 RID: 8711
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class MenuBaseConfig : ConfigBase
{
	// Token: 0x06010F57 RID: 69463 RVA: 0x00421558 File Offset: 0x0041F758
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

	// Token: 0x06010F58 RID: 69464 RVA: 0x00421598 File Offset: 0x0041F798
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

	// Token: 0x06010F59 RID: 69465 RVA: 0x00421620 File Offset: 0x0041F820
	public MainType? GetMainTypeConfigById(int tabId)
	{
		return ConfigMainTypeById.GetConfig(tabId, true);
	}

	// Token: 0x06010F5A RID: 69466 RVA: 0x00421629 File Offset: 0x0041F829
	public MenuConfig? GetMenuConfigByFunctionId(int functionId)
	{
		return ConfigMenuConfigByFunctionId.GetConfig(functionId, true);
	}

	// Token: 0x06010F5B RID: 69467 RVA: 0x00421632 File Offset: 0x0041F832
	public IReadOnlyList<MenuConfig> GetMenuConfigListByFunctionId(int functionId)
	{
		return ConfigMenuConfigByFunctionId.GetConfigList(functionId, true);
	}

	// Token: 0x06010F5C RID: 69468 RVA: 0x0042163B File Offset: 0x0041F83B
	public IReadOnlyList<KeyType> GetAllKeyTypeConfig()
	{
		return ConfigKeyTypeAll.GetConfigList(true);
	}

	// Token: 0x06010F5D RID: 69469 RVA: 0x00421643 File Offset: 0x0041F843
	public IReadOnlyList<KeySetting> GetKeySettingConfigListByTypeIdAndInputControllerType(int typeId, int inputControllerTypeId)
	{
		return ConfigKeySettingByTypeIdAndInputControllerType.GetConfigList(typeId, inputControllerTypeId, true);
	}

	// Token: 0x06010F5E RID: 69470 RVA: 0x0042164D File Offset: 0x0041F84D
	public IReadOnlyList<AxisRevert> GetAxisRevertConfigListByRevertType(int revertType)
	{
		return ConfigAxisRevertByRevertType.GetConfigList(revertType, true);
	}

	// Token: 0x06010F5F RID: 69471 RVA: 0x00421656 File Offset: 0x0041F856
	public IReadOnlyList<KeySetting> GetExclusiveKeySettingConfigByTypeIdAndInputControllerType(int typeId, int inputControllerTypeId, EKeySettingExclusiveType exclusiveType)
	{
		return ConfigKeySettingByTypeIdAndInputControllerTypeExclusive.GetConfigList(typeId, inputControllerTypeId, (int)exclusiveType, true);
	}

	// Token: 0x06010F60 RID: 69472 RVA: 0x00421661 File Offset: 0x0041F861
	public KeyExclusiveType? GetExclusiveTypeConfigById(int typeId)
	{
		return ConfigKeyExclusiveTypeById.GetConfig(typeId, true);
	}

	// Token: 0x06010F61 RID: 69473 RVA: 0x0042166A File Offset: 0x0041F86A
	public MenuDetailPop? GetMenuDetailPopConfigById(int configId)
	{
		return ConfigMenuDetailPopById.GetConfig(configId, true);
	}

	// Token: 0x06010F62 RID: 69474 RVA: 0x00421673 File Offset: 0x0041F873
	public MenuDetailPopItem? GetMenuDetailPopItemConfigById(int configId)
	{
		return ConfigMenuDetailPopItemById.GetConfig(configId, true);
	}

	// Token: 0x06010F63 RID: 69475 RVA: 0x0042167C File Offset: 0x0041F87C
	public RoleVoiceLanguage? GetRoleLangCustomConfigById(int configId)
	{
		return ConfigRoleVoiceLanguageByLanguageId.GetConfig(configId, true);
	}

	// Token: 0x17001589 RID: 5513
	// (get) Token: 0x06010F64 RID: 69476 RVA: 0x00421685 File Offset: 0x0041F885
	[Nullable(1)]
	public static MenuBaseConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return MenuBaseConfig._Instance;
		}
	}

	// Token: 0x06010F65 RID: 69477 RVA: 0x0042168C File Offset: 0x0041F88C
	[NullableContext(1)]
	public static MenuBaseConfig GetOrCreateInstance()
	{
		if (MenuBaseConfig._Instance == null)
		{
			MenuBaseConfig.CreateInstance();
		}
		return MenuBaseConfig._Instance;
	}

	// Token: 0x06010F66 RID: 69478 RVA: 0x004216A0 File Offset: 0x0041F8A0
	public static bool CreateInstance()
	{
		if (MenuBaseConfig._Instance != null)
		{
			return true;
		}
		MenuBaseConfig._Instance = new MenuBaseConfig();
		return true;
	}

	// Token: 0x06010F67 RID: 69479 RVA: 0x004216B6 File Offset: 0x0041F8B6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010F68 RID: 69480 RVA: 0x004216B8 File Offset: 0x0041F8B8
	public static void ResetStaticDefaultValue()
	{
		MenuBaseConfig._Instance = null;
	}

	// Token: 0x06010F69 RID: 69481 RVA: 0x004216C0 File Offset: 0x0041F8C0
	static MenuBaseConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MenuBaseConfig.CreateStaticDefaultValue), new Action(MenuBaseConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040080F5 RID: 33013
	private static MenuBaseConfig _Instance;
}
