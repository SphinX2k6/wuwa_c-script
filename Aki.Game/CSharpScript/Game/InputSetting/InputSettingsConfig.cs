using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x0200616F RID: 24943
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class InputSettingsConfig : ConfigBase
	{
		// Token: 0x0603BD22 RID: 245026 RVA: 0x010FB74C File Offset: 0x010F994C
		[NullableContext(2)]
		public IReadOnlyList<ActionMapping> GetAllActionMappingConfig()
		{
			return ConfigActionMappingAll.GetConfigList(true);
		}

		// Token: 0x0603BD23 RID: 245027 RVA: 0x010FB754 File Offset: 0x010F9954
		[NullableContext(2)]
		public IReadOnlyList<ActionMapping> GetActionMappingConfigByActionType(int actionType)
		{
			return ConfigActionMappingByActionType.GetConfigList(actionType, true);
		}

		// Token: 0x0603BD24 RID: 245028 RVA: 0x010FB75D File Offset: 0x010F995D
		public ActionMapping? GetActionMappingConfigByActionName(string actionName)
		{
			return ConfigActionMappingByActionName.GetConfig(actionName, true);
		}

		// Token: 0x0603BD25 RID: 245029 RVA: 0x010FB766 File Offset: 0x010F9966
		[NullableContext(2)]
		public IReadOnlyList<AxisMapping> GetAllAxisMappingConfig()
		{
			return ConfigAxisMappingAll.GetConfigList(true);
		}

		// Token: 0x0603BD26 RID: 245030 RVA: 0x010FB76E File Offset: 0x010F996E
		[NullableContext(2)]
		public IReadOnlyList<AxisMapping> GetAxisMappingConfigByActionType(int axisType)
		{
			return ConfigAxisMappingByAxisType.GetConfigList(axisType, true);
		}

		// Token: 0x0603BD27 RID: 245031 RVA: 0x010FB777 File Offset: 0x010F9977
		public AxisMapping? GetAxisMappingConfigByAxisName(string axisName)
		{
			return ConfigAxisMappingByAxisName.GetConfig(axisName, true);
		}

		// Token: 0x0603BD28 RID: 245032 RVA: 0x010FB780 File Offset: 0x010F9980
		[NullableContext(2)]
		public IReadOnlyList<CombinationAction> GetAllCombinationActionConfig()
		{
			return ConfigCombinationActionAll.GetConfigList(true);
		}

		// Token: 0x0603BD29 RID: 245033 RVA: 0x010FB788 File Offset: 0x010F9988
		public CombinationAction? GetCombinationActionConfigByActionName(string actionName)
		{
			return ConfigCombinationActionByActionName.GetConfig(actionName, true);
		}

		// Token: 0x0603BD2A RID: 245034 RVA: 0x010FB794 File Offset: 0x010F9994
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

		// Token: 0x0603BD2B RID: 245035 RVA: 0x010FB804 File Offset: 0x010F9A04
		[NullableContext(2)]
		public IReadOnlyList<CombinationAction> GetCombinationActionConfigByActionType(int actionType)
		{
			return ConfigCombinationActionByActionType.GetConfigList(actionType, true);
		}

		// Token: 0x0603BD2C RID: 245036 RVA: 0x010FB80D File Offset: 0x010F9A0D
		[NullableContext(2)]
		public IReadOnlyList<CombinationAxis> GetAllCombinationAxisConfig()
		{
			return ConfigCombinationAxisAll.GetConfigList(true);
		}

		// Token: 0x0603BD2D RID: 245037 RVA: 0x010FB815 File Offset: 0x010F9A15
		public CombinationAxis? GetCombinationAxisConfigByAxisName(string axisName)
		{
			return ConfigCombinationAxisByAxisName.GetConfig(axisName, true);
		}

		// Token: 0x0603BD2E RID: 245038 RVA: 0x010FB81E File Offset: 0x010F9A1E
		public PcKey? GetPcKeyConfig(string keyName)
		{
			return ConfigPcKeyByKeyName.GetConfig(keyName, true);
		}

		// Token: 0x0603BD2F RID: 245039 RVA: 0x010FB827 File Offset: 0x010F9A27
		[NullableContext(2)]
		public IReadOnlyList<PcKey> GetPcKeyConfigList()
		{
			return ConfigPcKeyAll.GetConfigList(true);
		}

		// Token: 0x0603BD30 RID: 245040 RVA: 0x010FB82F File Offset: 0x010F9A2F
		public PcKey? GetPcKeyConfigById(int configId)
		{
			return ConfigPcKeyById.GetConfig(configId, true);
		}

		// Token: 0x0603BD31 RID: 245041 RVA: 0x010FB838 File Offset: 0x010F9A38
		public GamepadKey? GetGamepadKeyConfig(string keyName)
		{
			return ConfigGamepadKeyByKeyName.GetConfig(keyName, true);
		}

		// Token: 0x0603BD32 RID: 245042 RVA: 0x010FB841 File Offset: 0x010F9A41
		public GamepadKey? GetGamepadKeyConfigById(int configId)
		{
			return ConfigGamepadKeyById.GetConfig(configId, true);
		}

		// Token: 0x0603BD33 RID: 245043 RVA: 0x010FB84A File Offset: 0x010F9A4A
		public PlatformIcon? GetPlatformIconConfig(int configId)
		{
			return ConfigPlatformIconById.GetConfig(configId, true);
		}

		// Token: 0x170070D6 RID: 28886
		// (get) Token: 0x0603BD34 RID: 245044 RVA: 0x010FB853 File Offset: 0x010F9A53
		public static InputSettingsConfig Instance
		{
			get
			{
				return InputSettingsConfig._Instance;
			}
		}

		// Token: 0x0603BD35 RID: 245045 RVA: 0x010FB85A File Offset: 0x010F9A5A
		public static InputSettingsConfig GetOrCreateInstance()
		{
			if (InputSettingsConfig._Instance == null)
			{
				InputSettingsConfig.CreateInstance();
			}
			return InputSettingsConfig._Instance;
		}

		// Token: 0x0603BD36 RID: 245046 RVA: 0x010FB86E File Offset: 0x010F9A6E
		public static bool CreateInstance()
		{
			if (InputSettingsConfig._Instance != null)
			{
				return true;
			}
			InputSettingsConfig._Instance = new InputSettingsConfig();
			return true;
		}

		// Token: 0x0603BD37 RID: 245047 RVA: 0x010FB884 File Offset: 0x010F9A84
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603BD38 RID: 245048 RVA: 0x010FB886 File Offset: 0x010F9A86
		public static void ResetStaticDefaultValue()
		{
			InputSettingsConfig._Instance = null;
		}

		// Token: 0x0603BD39 RID: 245049 RVA: 0x010FB88E File Offset: 0x010F9A8E
		static InputSettingsConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputSettingsConfig.CreateStaticDefaultValue), new Action(InputSettingsConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401F893 RID: 129171
		[Nullable(2)]
		private static InputSettingsConfig _Instance;
	}
}
