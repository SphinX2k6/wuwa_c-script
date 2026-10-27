using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002319 RID: 8985
	public static class EEnableClientFunctionTypeExtensions
	{
		// Token: 0x0600C46F RID: 50287 RVA: 0x001CACB8 File Offset: 0x001C8EB8
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

		// Token: 0x0600C470 RID: 50288 RVA: 0x001CACE0 File Offset: 0x001C8EE0
		public static EEnableClientFunctionType FromString(string name)
		{
			EEnableClientFunctionType result;
			if (!EEnableClientFunctionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEnableClientFunctionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C471 RID: 50289 RVA: 0x001CAD09 File Offset: 0x001C8F09
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

		// Token: 0x0600C472 RID: 50290 RVA: 0x001CAD2E File Offset: 0x001C8F2E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"HealthBarDisplay"
			};
		}

		// Token: 0x0600C473 RID: 50291 RVA: 0x001CAD3E File Offset: 0x001C8F3E
		public static EEnableClientFunctionType[] GetValues()
		{
			return new EEnableClientFunctionType[1];
		}

		// Token: 0x0600C474 RID: 50292 RVA: 0x001CAD46 File Offset: 0x001C8F46
		public static string[] GetNames()
		{
			return new string[]
			{
				"HealthBarDisplay"
			};
		}
	}
}
