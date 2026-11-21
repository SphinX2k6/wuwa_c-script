using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x0200616C RID: 24940
	[NullableContext(1)]
	[Nullable(0)]
	public class InputKeyUtils
	{
		// Token: 0x0603BCD0 RID: 244944 RVA: 0x010F9BB8 File Offset: 0x010F7DB8
		public static string GetGamepadKeyIconPath(string keyName)
		{
			GamepadKey? gamepadKeyConfig = InputSettingsConfig.Instance.GetGamepadKeyConfig(keyName);
			if (gamepadKeyConfig == null)
			{
				return "";
			}
			GamepadKey valueOrDefault = gamepadKeyConfig.GetValueOrDefault();
			if (Info.Instance.IsPsGamepad())
			{
				return valueOrDefault.PsKeyIconPath;
			}
			if (Info.Instance.IsBackBoneGamepad())
			{
				return valueOrDefault.BackBoneKeyIconPath;
			}
			if (Info.Instance.IsNsProGamepad())
			{
				return valueOrDefault.NsKeyIconPath;
			}
			return valueOrDefault.KeyIconPath;
		}

		// Token: 0x0603BCD1 RID: 244945 RVA: 0x010F9C30 File Offset: 0x010F7E30
		public static string GetGamepadKeyIconPathByType(string keyName, EInputControllerType type)
		{
			GamepadKey? gamepadKeyConfig = InputSettingsConfig.Instance.GetGamepadKeyConfig(keyName);
			if (gamepadKeyConfig == null)
			{
				return "";
			}
			GamepadKey valueOrDefault = gamepadKeyConfig.GetValueOrDefault();
			if (type == EInputControllerType.PS4 || type == EInputControllerType.PS5)
			{
				return valueOrDefault.PsKeyIconPath;
			}
			if (type == EInputControllerType.BackBone)
			{
				return valueOrDefault.BackBoneKeyIconPath;
			}
			if (type == EInputControllerType.NsPro)
			{
				return valueOrDefault.NsKeyIconPath;
			}
			if (type == EInputControllerType.XboxOne)
			{
				return valueOrDefault.KeyIconPath;
			}
			return "";
		}

		// Token: 0x0603BCD2 RID: 244946 RVA: 0x010F9C9C File Offset: 0x010F7E9C
		[return: Nullable(2)]
		public static string GetPcKeyIconPathByCurrentPlatform(string keyName)
		{
			PcKey? pcKeyConfig = InputSettingsConfig.Instance.GetPcKeyConfig(keyName);
			if (pcKeyConfig == null)
			{
				return null;
			}
			PcKey valueOrDefault = pcKeyConfig.GetValueOrDefault();
			if (Info.Instance.PlatformType == ESourcePlatformType.Mac)
			{
				return valueOrDefault.MacKeyIconPath;
			}
			if (InputSettingsManager.Instance.CheckUseFrenchKeyboard && !StringUtils.IsBlank(valueOrDefault.FrenchKeyIconPath))
			{
				return valueOrDefault.FrenchKeyIconPath;
			}
			return LanguageKeyTransUtils.GetKeyTrans(InputSettingsManager.Instance.CurrentDeviceLang).GetPcKeyIconPath(valueOrDefault);
		}

		// Token: 0x0603BCD3 RID: 244947 RVA: 0x010F9D16 File Offset: 0x010F7F16
		public static EInputControllerType GetLastGamepadEnum()
		{
			if (Info.Instance.IsPs5Platform())
			{
				return EInputControllerType.PS5;
			}
			return LocalStorage.GetGlobal<EInputControllerType>(ELocalStorageGlobalKey.LastGamepadEnum, EInputControllerType.XboxOne);
		}

		// Token: 0x0603BCD4 RID: 244948 RVA: 0x010F9D34 File Offset: 0x010F7F34
		public static string ConvertKeyToActionOrAxis(string keyName, bool isActionOrAxis)
		{
			if (isActionOrAxis && keyName == EKey.Gamepad_LeftTriggerAxis)
			{
				return EKey.Gamepad_LeftTrigger;
			}
			if (isActionOrAxis && keyName == EKey.Gamepad_RightTriggerAxis)
			{
				return EKey.Gamepad_RightTrigger;
			}
			if (!isActionOrAxis && keyName == EKey.Gamepad_LeftTrigger)
			{
				return EKey.Gamepad_LeftTriggerAxis;
			}
			if (!isActionOrAxis && keyName == EKey.Gamepad_RightTrigger)
			{
				return EKey.Gamepad_RightTriggerAxis;
			}
			return keyName;
		}
	}
}
