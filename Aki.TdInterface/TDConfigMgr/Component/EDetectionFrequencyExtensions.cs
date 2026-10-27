using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000920 RID: 2336
	public static class EDetectionFrequencyExtensions
	{
		// Token: 0x060034C1 RID: 13505 RVA: 0x00089F8C File Offset: 0x0008818C
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

		// Token: 0x060034C2 RID: 13506 RVA: 0x00089FE0 File Offset: 0x000881E0
		public static EDetectionFrequency FromString(string name)
		{
			EDetectionFrequency result;
			if (!EDetectionFrequencyExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDetectionFrequency 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060034C3 RID: 13507 RVA: 0x0008A00C File Offset: 0x0008820C
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

		// Token: 0x060034C4 RID: 13508 RVA: 0x0008A074 File Offset: 0x00088274
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

		// Token: 0x060034C5 RID: 13509 RVA: 0x0008A09C File Offset: 0x0008829C
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

		// Token: 0x060034C6 RID: 13510 RVA: 0x0008A0AF File Offset: 0x000882AF
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
