using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000B0D RID: 2829
	public static class EViewDistanceTypeExtensions
	{
		// Token: 0x06003DCD RID: 15821 RVA: 0x0009DFC0 File Offset: 0x0009C1C0
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

		// Token: 0x06003DCE RID: 15822 RVA: 0x0009E014 File Offset: 0x0009C214
		public static EViewDistanceType FromString(string name)
		{
			EViewDistanceType result;
			if (!EViewDistanceTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EViewDistanceType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003DCF RID: 15823 RVA: 0x0009E040 File Offset: 0x0009C240
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

		// Token: 0x06003DD0 RID: 15824 RVA: 0x0009E0A8 File Offset: 0x0009C2A8
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

		// Token: 0x06003DD1 RID: 15825 RVA: 0x0009E0D0 File Offset: 0x0009C2D0
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

		// Token: 0x06003DD2 RID: 15826 RVA: 0x0009E0E3 File Offset: 0x0009C2E3
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
