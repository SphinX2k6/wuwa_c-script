using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200264A RID: 9802
	public static class EOptionLockTypeExtensions
	{
		// Token: 0x0600D3A7 RID: 54183 RVA: 0x001EBFE4 File Offset: 0x001EA1E4
		public static string ToEnumString(this EOptionLockType value)
		{
			string result;
			if (value == EOptionLockType.OnMotor)
			{
				result = "OnMotor";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D3A8 RID: 54184 RVA: 0x001EC00C File Offset: 0x001EA20C
		public static EOptionLockType FromString(string name)
		{
			EOptionLockType result;
			if (!EOptionLockTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EOptionLockType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D3A9 RID: 54185 RVA: 0x001EC035 File Offset: 0x001EA235
		public static bool TryFromString(string name, out EOptionLockType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EOptionLockType.OnMotor;
				return false;
			}
			if (name == "OnMotor")
			{
				value = EOptionLockType.OnMotor;
				return true;
			}
			value = EOptionLockType.OnMotor;
			return false;
		}

		// Token: 0x0600D3AA RID: 54186 RVA: 0x001EC05A File Offset: 0x001EA25A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"OnMotor"
			};
		}

		// Token: 0x0600D3AB RID: 54187 RVA: 0x001EC06A File Offset: 0x001EA26A
		public static EOptionLockType[] GetValues()
		{
			return new EOptionLockType[1];
		}

		// Token: 0x0600D3AC RID: 54188 RVA: 0x001EC072 File Offset: 0x001EA272
		public static string[] GetNames()
		{
			return new string[]
			{
				"OnMotor"
			};
		}
	}
}
