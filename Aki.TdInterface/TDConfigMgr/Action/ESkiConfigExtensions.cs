using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002419 RID: 9241
	public static class ESkiConfigExtensions
	{
		// Token: 0x0600C8EF RID: 51439 RVA: 0x001D6DC0 File Offset: 0x001D4FC0
		public static string ToEnumString(this ESkiConfig value)
		{
			string result;
			switch (value)
			{
			case ESkiConfig.Open:
				result = "Open";
				break;
			case ESkiConfig.Close:
				result = "Close";
				break;
			case ESkiConfig.Accelerate:
				result = "Accelerate";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C8F0 RID: 51440 RVA: 0x001D6E08 File Offset: 0x001D5008
		public static ESkiConfig FromString(string name)
		{
			ESkiConfig result;
			if (!ESkiConfigExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESkiConfig 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C8F1 RID: 51441 RVA: 0x001D6E34 File Offset: 0x001D5034
		public static bool TryFromString(string name, out ESkiConfig value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESkiConfig.Open;
				return false;
			}
			if (name == "Open")
			{
				value = ESkiConfig.Open;
				return true;
			}
			if (name == "Close")
			{
				value = ESkiConfig.Close;
				return true;
			}
			if (!(name == "Accelerate"))
			{
				value = ESkiConfig.Open;
				return false;
			}
			value = ESkiConfig.Accelerate;
			return true;
		}

		// Token: 0x0600C8F2 RID: 51442 RVA: 0x001D6E8A File Offset: 0x001D508A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Open",
				"Close",
				"Accelerate"
			};
		}

		// Token: 0x0600C8F3 RID: 51443 RVA: 0x001D6EAA File Offset: 0x001D50AA
		public static ESkiConfig[] GetValues()
		{
			return new ESkiConfig[]
			{
				ESkiConfig.Open,
				ESkiConfig.Close,
				ESkiConfig.Accelerate
			};
		}

		// Token: 0x0600C8F4 RID: 51444 RVA: 0x001D6EBA File Offset: 0x001D50BA
		public static string[] GetNames()
		{
			return new string[]
			{
				"Open",
				"Close",
				"Accelerate"
			};
		}
	}
}
