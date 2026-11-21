using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200261A RID: 9754
	public static class EMotorParamsChangeTypeExtensions
	{
		// Token: 0x0600D2CF RID: 53967 RVA: 0x001EA430 File Offset: 0x001E8630
		public static string ToEnumString(this EMotorParamsChangeType value)
		{
			string result;
			if (value != EMotorParamsChangeType.SpeedUp)
			{
				if (value != EMotorParamsChangeType.SpeedDown)
				{
					result = value.ToString();
				}
				else
				{
					result = "SpeedDown";
				}
			}
			else
			{
				result = "SpeedUp";
			}
			return result;
		}

		// Token: 0x0600D2D0 RID: 53968 RVA: 0x001EA468 File Offset: 0x001E8668
		public static EMotorParamsChangeType FromString(string name)
		{
			EMotorParamsChangeType result;
			if (!EMotorParamsChangeTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMotorParamsChangeType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D2D1 RID: 53969 RVA: 0x001EA491 File Offset: 0x001E8691
		public static bool TryFromString(string name, out EMotorParamsChangeType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMotorParamsChangeType.SpeedUp;
				return false;
			}
			if (name == "SpeedUp")
			{
				value = EMotorParamsChangeType.SpeedUp;
				return true;
			}
			if (!(name == "SpeedDown"))
			{
				value = EMotorParamsChangeType.SpeedUp;
				return false;
			}
			value = EMotorParamsChangeType.SpeedDown;
			return true;
		}

		// Token: 0x0600D2D2 RID: 53970 RVA: 0x001EA4CA File Offset: 0x001E86CA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SpeedUp",
				"SpeedDown"
			};
		}

		// Token: 0x0600D2D3 RID: 53971 RVA: 0x001EA4E2 File Offset: 0x001E86E2
		public static EMotorParamsChangeType[] GetValues()
		{
			return new EMotorParamsChangeType[]
			{
				EMotorParamsChangeType.SpeedUp,
				EMotorParamsChangeType.SpeedDown
			};
		}

		// Token: 0x0600D2D4 RID: 53972 RVA: 0x001EA4EE File Offset: 0x001E86EE
		public static string[] GetNames()
		{
			return new string[]
			{
				"SpeedUp",
				"SpeedDown"
			};
		}
	}
}
