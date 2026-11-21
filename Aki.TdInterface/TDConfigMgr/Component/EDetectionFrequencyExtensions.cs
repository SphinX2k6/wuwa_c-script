using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009CD RID: 2509
	public static class EDetectionFrequencyExtensions
	{
		// Token: 0x0600382D RID: 14381 RVA: 0x00091B0C File Offset: 0x0008FD0C
		public static string ToEnumString(this EDetectionFrequency value)
		{
			string result;
			switch (value)
			{
			case EDetectionFrequency.Low:
				result = "Low";
				break;
			case EDetectionFrequency.Medium:
				result = "Medium";
				break;
			case EDetectionFrequency.High:
				result = "High";
				break;
			case EDetectionFrequency.SuperHigh:
				result = "SuperHigh";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600382E RID: 14382 RVA: 0x00091B60 File Offset: 0x0008FD60
		public static EDetectionFrequency FromString(string name)
		{
			EDetectionFrequency result;
			if (!EDetectionFrequencyExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDetectionFrequency 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600382F RID: 14383 RVA: 0x00091B8C File Offset: 0x0008FD8C
		public static bool TryFromString(string name, out EDetectionFrequency value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDetectionFrequency.Low;
				return false;
			}
			if (name == "Low")
			{
				value = EDetectionFrequency.Low;
				return true;
			}
			if (name == "Medium")
			{
				value = EDetectionFrequency.Medium;
				return true;
			}
			if (name == "High")
			{
				value = EDetectionFrequency.High;
				return true;
			}
			if (!(name == "SuperHigh"))
			{
				value = EDetectionFrequency.Low;
				return false;
			}
			value = EDetectionFrequency.SuperHigh;
			return true;
		}

		// Token: 0x06003830 RID: 14384 RVA: 0x00091BF4 File Offset: 0x0008FDF4
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Low",
				"Medium",
				"High",
				"SuperHigh"
			};
		}

		// Token: 0x06003831 RID: 14385 RVA: 0x00091C1C File Offset: 0x0008FE1C
		public static EDetectionFrequency[] GetValues()
		{
			return new EDetectionFrequency[]
			{
				EDetectionFrequency.Low,
				EDetectionFrequency.Medium,
				EDetectionFrequency.High,
				EDetectionFrequency.SuperHigh
			};
		}

		// Token: 0x06003832 RID: 14386 RVA: 0x00091C2F File Offset: 0x0008FE2F
		public static string[] GetNames()
		{
			return new string[]
			{
				"Low",
				"Medium",
				"High",
				"SuperHigh"
			};
		}
	}
}
