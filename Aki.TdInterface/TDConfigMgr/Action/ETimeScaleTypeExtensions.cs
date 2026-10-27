using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002473 RID: 9331
	public static class ETimeScaleTypeExtensions
	{
		// Token: 0x0600CA84 RID: 51844 RVA: 0x001DD080 File Offset: 0x001DB280
		public static string ToEnumString(this ETimeScaleType value)
		{
			string result;
			if (value == ETimeScaleType.Global)
			{
				result = "Global";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600CA85 RID: 51845 RVA: 0x001DD0A8 File Offset: 0x001DB2A8
		public static ETimeScaleType FromString(string name)
		{
			ETimeScaleType result;
			if (!ETimeScaleTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETimeScaleType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CA86 RID: 51846 RVA: 0x001DD0D1 File Offset: 0x001DB2D1
		public static bool TryFromString(string name, out ETimeScaleType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETimeScaleType.Global;
				return false;
			}
			if (name == "Global")
			{
				value = ETimeScaleType.Global;
				return true;
			}
			value = ETimeScaleType.Global;
			return false;
		}

		// Token: 0x0600CA87 RID: 51847 RVA: 0x001DD0F6 File Offset: 0x001DB2F6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Global"
			};
		}

		// Token: 0x0600CA88 RID: 51848 RVA: 0x001DD106 File Offset: 0x001DB306
		public static ETimeScaleType[] GetValues()
		{
			return new ETimeScaleType[1];
		}

		// Token: 0x0600CA89 RID: 51849 RVA: 0x001DD10E File Offset: 0x001DB30E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Global"
			};
		}
	}
}
