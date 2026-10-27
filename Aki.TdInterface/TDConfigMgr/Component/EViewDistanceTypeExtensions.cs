using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A44 RID: 2628
	public static class EViewDistanceTypeExtensions
	{
		// Token: 0x060039E3 RID: 14819 RVA: 0x000953F0 File Offset: 0x000935F0
		public static string ToEnumString(this EViewDistanceType value)
		{
			string result;
			switch (value)
			{
			case EViewDistanceType.Low:
				result = "Low";
				break;
			case EViewDistanceType.Mid:
				result = "Mid";
				break;
			case EViewDistanceType.High:
				result = "High";
				break;
			case EViewDistanceType.Custom:
				result = "Custom";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060039E4 RID: 14820 RVA: 0x00095444 File Offset: 0x00093644
		public static EViewDistanceType FromString(string name)
		{
			EViewDistanceType result;
			if (!EViewDistanceTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EViewDistanceType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060039E5 RID: 14821 RVA: 0x00095470 File Offset: 0x00093670
		public static bool TryFromString(string name, out EViewDistanceType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EViewDistanceType.Low;
				return false;
			}
			if (name == "Low")
			{
				value = EViewDistanceType.Low;
				return true;
			}
			if (name == "Mid")
			{
				value = EViewDistanceType.Mid;
				return true;
			}
			if (name == "High")
			{
				value = EViewDistanceType.High;
				return true;
			}
			if (!(name == "Custom"))
			{
				value = EViewDistanceType.Low;
				return false;
			}
			value = EViewDistanceType.Custom;
			return true;
		}

		// Token: 0x060039E6 RID: 14822 RVA: 0x000954D8 File Offset: 0x000936D8
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Low",
				"Mid",
				"High",
				"Custom"
			};
		}

		// Token: 0x060039E7 RID: 14823 RVA: 0x00095500 File Offset: 0x00093700
		public static EViewDistanceType[] GetValues()
		{
			return new EViewDistanceType[]
			{
				EViewDistanceType.Low,
				EViewDistanceType.Mid,
				EViewDistanceType.High,
				EViewDistanceType.Custom
			};
		}

		// Token: 0x060039E8 RID: 14824 RVA: 0x00095513 File Offset: 0x00093713
		public static string[] GetNames()
		{
			return new string[]
			{
				"Low",
				"Mid",
				"High",
				"Custom"
			};
		}
	}
}
