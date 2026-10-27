using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023B9 RID: 9145
	public static class EOptionLockTypeExtensions
	{
		// Token: 0x0600C73F RID: 51007 RVA: 0x001D2BB0 File Offset: 0x001D0DB0
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

		// Token: 0x0600C740 RID: 51008 RVA: 0x001D2BD8 File Offset: 0x001D0DD8
		public static EOptionLockType FromString(string name)
		{
			EOptionLockType result;
			if (!EOptionLockTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EOptionLockType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C741 RID: 51009 RVA: 0x001D2C01 File Offset: 0x001D0E01
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

		// Token: 0x0600C742 RID: 51010 RVA: 0x001D2C26 File Offset: 0x001D0E26
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"OnMotor"
			};
		}

		// Token: 0x0600C743 RID: 51011 RVA: 0x001D2C36 File Offset: 0x001D0E36
		public static EOptionLockType[] GetValues()
		{
			return new EOptionLockType[1];
		}

		// Token: 0x0600C744 RID: 51012 RVA: 0x001D2C3E File Offset: 0x001D0E3E
		public static string[] GetNames()
		{
			return new string[]
			{
				"OnMotor"
			};
		}
	}
}
