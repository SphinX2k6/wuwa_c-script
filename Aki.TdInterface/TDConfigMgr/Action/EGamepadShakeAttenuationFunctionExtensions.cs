using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002343 RID: 9027
	public static class EGamepadShakeAttenuationFunctionExtensions
	{
		// Token: 0x0600C52C RID: 50476 RVA: 0x001CC770 File Offset: 0x001CA970
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

		// Token: 0x0600C52D RID: 50477 RVA: 0x001CC7C4 File Offset: 0x001CA9C4
		public static EGamepadShakeAttenuationFunction FromString(string name)
		{
			EGamepadShakeAttenuationFunction result;
			if (!EGamepadShakeAttenuationFunctionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGamepadShakeAttenuationFunction 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C52E RID: 50478 RVA: 0x001CC7F0 File Offset: 0x001CA9F0
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

		// Token: 0x0600C52F RID: 50479 RVA: 0x001CC858 File Offset: 0x001CAA58
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

		// Token: 0x0600C530 RID: 50480 RVA: 0x001CC880 File Offset: 0x001CAA80
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

		// Token: 0x0600C531 RID: 50481 RVA: 0x001CC893 File Offset: 0x001CAA93
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
