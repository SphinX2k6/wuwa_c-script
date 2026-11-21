using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002622 RID: 9762
	public static class EMotorSpeedTypeExtensions
	{
		// Token: 0x0600D2F3 RID: 54003 RVA: 0x001EA97C File Offset: 0x001E8B7C
		public static string ToEnumString(this EMotorSpeedType value)
		{
			string result;
			if (value == EMotorSpeedType.TargetSpeed)
			{
				result = "TargetSpeed";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D2F4 RID: 54004 RVA: 0x001EA9A4 File Offset: 0x001E8BA4
		public static EMotorSpeedType FromString(string name)
		{
			EMotorSpeedType result;
			if (!EMotorSpeedTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMotorSpeedType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D2F5 RID: 54005 RVA: 0x001EA9CD File Offset: 0x001E8BCD
		public static bool TryFromString(string name, out EMotorSpeedType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMotorSpeedType.TargetSpeed;
				return false;
			}
			if (name == "TargetSpeed")
			{
				value = EMotorSpeedType.TargetSpeed;
				return true;
			}
			value = EMotorSpeedType.TargetSpeed;
			return false;
		}

		// Token: 0x0600D2F6 RID: 54006 RVA: 0x001EA9F2 File Offset: 0x001E8BF2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"TargetSpeed"
			};
		}

		// Token: 0x0600D2F7 RID: 54007 RVA: 0x001EAA02 File Offset: 0x001E8C02
		public static EMotorSpeedType[] GetValues()
		{
			return new EMotorSpeedType[1];
		}

		// Token: 0x0600D2F8 RID: 54008 RVA: 0x001EAA0A File Offset: 0x001E8C0A
		public static string[] GetNames()
		{
			return new string[]
			{
				"TargetSpeed"
			};
		}
	}
}
