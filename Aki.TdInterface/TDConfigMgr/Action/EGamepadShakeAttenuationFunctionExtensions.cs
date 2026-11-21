using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025B6 RID: 9654
	public static class EGamepadShakeAttenuationFunctionExtensions
	{
		// Token: 0x0600D10D RID: 53517 RVA: 0x001E493C File Offset: 0x001E2B3C
		public static string ToEnumString(this EGamepadShakeAttenuationFunction value)
		{
			string result;
			switch (value)
			{
			case EGamepadShakeAttenuationFunction.Linear:
				result = "Linear";
				break;
			case EGamepadShakeAttenuationFunction.Logarithmic:
				result = "Logarithmic";
				break;
			case EGamepadShakeAttenuationFunction.Inverse:
				result = "Inverse";
				break;
			case EGamepadShakeAttenuationFunction.LogReverse:
				result = "LogReverse";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D10E RID: 53518 RVA: 0x001E4990 File Offset: 0x001E2B90
		public static EGamepadShakeAttenuationFunction FromString(string name)
		{
			EGamepadShakeAttenuationFunction result;
			if (!EGamepadShakeAttenuationFunctionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGamepadShakeAttenuationFunction 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D10F RID: 53519 RVA: 0x001E49BC File Offset: 0x001E2BBC
		public static bool TryFromString(string name, out EGamepadShakeAttenuationFunction value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EGamepadShakeAttenuationFunction.Linear;
				return false;
			}
			if (name == "Linear")
			{
				value = EGamepadShakeAttenuationFunction.Linear;
				return true;
			}
			if (name == "Logarithmic")
			{
				value = EGamepadShakeAttenuationFunction.Logarithmic;
				return true;
			}
			if (name == "Inverse")
			{
				value = EGamepadShakeAttenuationFunction.Inverse;
				return true;
			}
			if (!(name == "LogReverse"))
			{
				value = EGamepadShakeAttenuationFunction.Linear;
				return false;
			}
			value = EGamepadShakeAttenuationFunction.LogReverse;
			return true;
		}

		// Token: 0x0600D110 RID: 53520 RVA: 0x001E4A24 File Offset: 0x001E2C24
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Linear",
				"Logarithmic",
				"Inverse",
				"LogReverse"
			};
		}

		// Token: 0x0600D111 RID: 53521 RVA: 0x001E4A4C File Offset: 0x001E2C4C
		public static EGamepadShakeAttenuationFunction[] GetValues()
		{
			return new EGamepadShakeAttenuationFunction[]
			{
				EGamepadShakeAttenuationFunction.Linear,
				EGamepadShakeAttenuationFunction.Logarithmic,
				EGamepadShakeAttenuationFunction.Inverse,
				EGamepadShakeAttenuationFunction.LogReverse
			};
		}

		// Token: 0x0600D112 RID: 53522 RVA: 0x001E4A5F File Offset: 0x001E2C5F
		public static string[] GetNames()
		{
			return new string[]
			{
				"Linear",
				"Logarithmic",
				"Inverse",
				"LogReverse"
			};
		}
	}
}
