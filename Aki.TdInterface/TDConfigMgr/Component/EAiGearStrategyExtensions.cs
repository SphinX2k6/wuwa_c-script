using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008EE RID: 2286
	public static class EAiGearStrategyExtensions
	{
		// Token: 0x060033E0 RID: 13280 RVA: 0x00084A78 File Offset: 0x00082C78
		public static string ToEnumString(this EAiGearStrategy value)
		{
			string result;
			if (value != EAiGearStrategy.RenjuStrategy)
			{
				if (value != EAiGearStrategy.RaceStrategy)
				{
					result = value.ToString();
				}
				else
				{
					result = "RaceStrategy";
				}
			}
			else
			{
				result = "RenjuStrategy";
			}
			return result;
		}

		// Token: 0x060033E1 RID: 13281 RVA: 0x00084AB0 File Offset: 0x00082CB0
		public static EAiGearStrategy FromString(string name)
		{
			EAiGearStrategy result;
			if (!EAiGearStrategyExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAiGearStrategy 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060033E2 RID: 13282 RVA: 0x00084AD9 File Offset: 0x00082CD9
		public static bool TryFromString(string name, out EAiGearStrategy value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAiGearStrategy.RenjuStrategy;
				return false;
			}
			if (name == "RenjuStrategy")
			{
				value = EAiGearStrategy.RenjuStrategy;
				return true;
			}
			if (!(name == "RaceStrategy"))
			{
				value = EAiGearStrategy.RenjuStrategy;
				return false;
			}
			value = EAiGearStrategy.RaceStrategy;
			return true;
		}

		// Token: 0x060033E3 RID: 13283 RVA: 0x00084B12 File Offset: 0x00082D12
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"RenjuStrategy",
				"RaceStrategy"
			};
		}

		// Token: 0x060033E4 RID: 13284 RVA: 0x00084B2A File Offset: 0x00082D2A
		public static EAiGearStrategy[] GetValues()
		{
			return new EAiGearStrategy[]
			{
				EAiGearStrategy.RenjuStrategy,
				EAiGearStrategy.RaceStrategy
			};
		}

		// Token: 0x060033E5 RID: 13285 RVA: 0x00084B36 File Offset: 0x00082D36
		public static string[] GetNames()
		{
			return new string[]
			{
				"RenjuStrategy",
				"RaceStrategy"
			};
		}
	}
}
