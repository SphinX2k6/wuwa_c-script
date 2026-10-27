using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002397 RID: 9111
	public static class EMotorSpeedTypeExtensions
	{
		// Token: 0x0600C6A6 RID: 50854 RVA: 0x001D17DC File Offset: 0x001CF9DC
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

		// Token: 0x0600C6A7 RID: 50855 RVA: 0x001D1804 File Offset: 0x001CFA04
		public static EMotorSpeedType FromString(string name)
		{
			EMotorSpeedType result;
			if (!EMotorSpeedTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMotorSpeedType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C6A8 RID: 50856 RVA: 0x001D182D File Offset: 0x001CFA2D
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

		// Token: 0x0600C6A9 RID: 50857 RVA: 0x001D1852 File Offset: 0x001CFA52
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"TargetSpeed"
			};
		}

		// Token: 0x0600C6AA RID: 50858 RVA: 0x001D1862 File Offset: 0x001CFA62
		public static EMotorSpeedType[] GetValues()
		{
			return new EMotorSpeedType[1];
		}

		// Token: 0x0600C6AB RID: 50859 RVA: 0x001D186A File Offset: 0x001CFA6A
		public static string[] GetNames()
		{
			return new string[]
			{
				"TargetSpeed"
			};
		}
	}
}
