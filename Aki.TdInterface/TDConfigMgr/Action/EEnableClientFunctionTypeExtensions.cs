using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002588 RID: 9608
	public static class EEnableClientFunctionTypeExtensions
	{
		// Token: 0x0600D03E RID: 53310 RVA: 0x001E2B80 File Offset: 0x001E0D80
		public static string ToEnumString(this EEnableClientFunctionType value)
		{
			string result;
			if (value == EEnableClientFunctionType.HealthBarDisplay)
			{
				result = "HealthBarDisplay";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D03F RID: 53311 RVA: 0x001E2BA8 File Offset: 0x001E0DA8
		public static EEnableClientFunctionType FromString(string name)
		{
			EEnableClientFunctionType result;
			if (!EEnableClientFunctionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEnableClientFunctionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D040 RID: 53312 RVA: 0x001E2BD1 File Offset: 0x001E0DD1
		public static bool TryFromString(string name, out EEnableClientFunctionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EEnableClientFunctionType.HealthBarDisplay;
				return false;
			}
			if (name == "HealthBarDisplay")
			{
				value = EEnableClientFunctionType.HealthBarDisplay;
				return true;
			}
			value = EEnableClientFunctionType.HealthBarDisplay;
			return false;
		}

		// Token: 0x0600D041 RID: 53313 RVA: 0x001E2BF6 File Offset: 0x001E0DF6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"HealthBarDisplay"
			};
		}

		// Token: 0x0600D042 RID: 53314 RVA: 0x001E2C06 File Offset: 0x001E0E06
		public static EEnableClientFunctionType[] GetValues()
		{
			return new EEnableClientFunctionType[1];
		}

		// Token: 0x0600D043 RID: 53315 RVA: 0x001E2C0E File Offset: 0x001E0E0E
		public static string[] GetNames()
		{
			return new string[]
			{
				"HealthBarDisplay"
			};
		}
	}
}
