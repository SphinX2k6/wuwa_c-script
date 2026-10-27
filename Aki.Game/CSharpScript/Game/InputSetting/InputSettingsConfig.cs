using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006FEE RID: 28654
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class InputSettingsConfig : ConfigBase
	{
		// Token: 0x06045B71 RID: 285553 RVA: 0x011519BC File Offset: 0x0114FBBC
		[NullableContext(2)]
		public IReadOnlyList<ActionMapping> GetAllActionMappingConfig()
		{
			return ConfigActionMappingAll.GetConfigList(true);
		}

		// Token: 0x06045B72 RID: 285554 RVA: 0x011519C4 File Offset: 0x0114FBC4
		[NullableContext(2)]
		public IReadOnlyList<ActionMapping> GetActionMappingConfigByActionType(int actionType)
		{
			return ConfigActionMappingByActionType.GetConfigList(actionType, true);
		}

		// Token: 0x06045B73 RID: 285555 RVA: 0x011519CD File Offset: 0x0114FBCD
		public ActionMapping? GetActionMappingConfigByActionName(string actionName)
		{
			return ConfigActionMappingByActionName.GetConfig(actionName, true);
		}

		// Token: 0x06045B74 RID: 285556 RVA: 0x011519D6 File Offset: 0x0114FBD6
		[NullableContext(2)]
		public IReadOnlyList<AxisMapping> GetAllAxisMappingConfig()
		{
			return ConfigAxisMappingAll.GetConfigList(true);
		}

		// Token: 0x06045B75 RID: 285557 RVA: 0x011519DE File Offset: 0x0114FBDE
		[NullableContext(2)]
		public IReadOnlyList<AxisMapping> GetAxisMappingConfigByActionType(int axisType)
		{
			return ConfigAxisMappingByAxisType.GetConfigList(axisType, true);
		}

		// Token: 0x06045B76 RID: 285558 RVA: 0x011519E7 File Offset: 0x0114FBE7
		public AxisMapping? GetAxisMappingConfigByAxisName(string axisName)
		{
			return ConfigAxisMappingByAxisName.GetConfig(axisName, true);
		}

		// Token: 0x06045B77 RID: 285559 RVA: 0x011519F0 File Offset: 0x0114FBF0
		[NullableContext(2)]
		public IReadOnlyList<CombinationAction> GetAllCombinationActionConfig()
		{
			return ConfigCombinationActionAll.GetConfigList(true);
		}

		// Token: 0x06045B78 RID: 285560 RVA: 0x011519F8 File Offset: 0x0114FBF8
		public CombinationAction? GetCombinationActionConfigByActionName(string actionName)
		{
			return ConfigCombinationActionByActionName.GetConfig(actionName, true);
		}

		// Token: 0x06045B79 RID: 285561 RVA: 0x01151A04 File Offset: 0x0114FC04
		public CombinationAction? GetCombinationActionConfigByActionNameInList(string actionName)
		{
			IReadOnlyList<CombinationAction> allCombinationActionConfig = this.GetAllCombinationActionConfig();
			if (allCombinationActionConfig != null)
			{
				foreach (CombinationAction value in allCombinationActionConfig)
				{
					if (value.ActionName == actionName)
					{
						return new CombinationAction?(value);
					}
				}
			}
			return null;
		}

		// Token: 0x06045B7A RID: 285562 RVA: 0x01151A74 File Offset: 0x0114FC74
		[NullableContext(2)]
		public IReadOnlyList<CombinationAction> GetCombinationActionConfigByActionType(int actionType)
		{
			return ConfigCombinationActionByActionType.GetConfigList(actionType, true);
		}

		// Token: 0x06045B7B RID: 285563 RVA: 0x01151A7D File Offset: 0x0114FC7D
		[NullableContext(2)]
		public IReadOnlyList<CombinationAxis> GetAllCombinationAxisConfig()
		{
			return ConfigCombinationAxisAll.GetConfigList(true);
		}

		// Token: 0x06045B7C RID: 285564 RVA: 0x01151A85 File Offset: 0x0114FC85
		public CombinationAxis? GetCombinationAxisConfigByAxisName(string axisName)
		{
			return ConfigCombinationAxisByAxisName.GetConfig(axisName, true);
		}

		// Token: 0x06045B7D RID: 285565 RVA: 0x01151A8E File Offset: 0x0114FC8E
		public PcKey? GetPcKeyConfig(string keyName)
		{
			return ConfigPcKeyByKeyName.GetConfig(keyName, true);
		}

		// Token: 0x06045B7E RID: 285566 RVA: 0x01151A97 File Offset: 0x0114FC97
		[NullableContext(2)]
		public IReadOnlyList<PcKey> GetPcKeyConfigList()
		{
			return ConfigPcKeyAll.GetConfigList(true);
		}

		// Token: 0x06045B7F RID: 285567 RVA: 0x01151A9F File Offset: 0x0114FC9F
		public PcKey? GetPcKeyConfigById(int configId)
		{
			return ConfigPcKeyById.GetConfig(configId, true);
		}

		// Token: 0x06045B80 RID: 285568 RVA: 0x01151AA8 File Offset: 0x0114FCA8
		public GamepadKey? GetGamepadKeyConfig(string keyName)
		{
			return ConfigGamepadKeyByKeyName.GetConfig(keyName, true);
		}

		// Token: 0x06045B81 RID: 285569 RVA: 0x01151AB1 File Offset: 0x0114FCB1
		public GamepadKey? GetGamepadKeyConfigById(int configId)
		{
			return ConfigGamepadKeyById.GetConfig(configId, true);
		}

		// Token: 0x06045B82 RID: 285570 RVA: 0x01151ABA File Offset: 0x0114FCBA
		public PlatformIcon? GetPlatformIconConfig(int configId)
		{
			return ConfigPlatformIconById.GetConfig(configId, true);
		}

		// Token: 0x17009B96 RID: 39830
		// (get) Token: 0x06045B83 RID: 285571 RVA: 0x01151AC3 File Offset: 0x0114FCC3
		public static InputSettingsConfig Instance
		{
			get
			{
				return InputSettingsConfig._Instance;
			}
		}

		// Token: 0x06045B84 RID: 285572 RVA: 0x01151ACA File Offset: 0x0114FCCA
		public static InputSettingsConfig GetOrCreateInstance()
		{
			if (InputSettingsConfig._Instance == null)
			{
				InputSettingsConfig.CreateInstance();
			}
			return InputSettingsConfig._Instance;
		}

		// Token: 0x06045B85 RID: 285573 RVA: 0x01151ADE File Offset: 0x0114FCDE
		public static bool CreateInstance()
		{
			if (InputSettingsConfig._Instance != null)
			{
				return true;
			}
			InputSettingsConfig._Instance = new InputSettingsConfig();
			return true;
		}

		// Token: 0x06045B86 RID: 285574 RVA: 0x01151AF4 File Offset: 0x0114FCF4
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06045B87 RID: 285575 RVA: 0x01151AF6 File Offset: 0x0114FCF6
		public static void ResetStaticDefaultValue()
		{
			InputSettingsConfig._Instance = null;
		}

		// Token: 0x06045B88 RID: 285576 RVA: 0x01151AFE File Offset: 0x0114FCFE
		static InputSettingsConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputSettingsConfig.CreateStaticDefaultValue), new Action(InputSettingsConfig.ResetStaticDefaultValue));
		}

		// Token: 0x040245DE RID: 148958
		[Nullable(2)]
		private static InputSettingsConfig _Instance;
	}
}
