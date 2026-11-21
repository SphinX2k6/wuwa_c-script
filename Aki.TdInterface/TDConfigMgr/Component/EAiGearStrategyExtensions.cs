using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000993 RID: 2451
	public static class EAiGearStrategyExtensions
	{
		// Token: 0x06003728 RID: 14120 RVA: 0x0008C0B4 File Offset: 0x0008A2B4
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

		// Token: 0x06003729 RID: 14121 RVA: 0x0008C0EC File Offset: 0x0008A2EC
		public static EAiGearStrategy FromString(string name)
		{
			EAiGearStrategy result;
			if (!EAiGearStrategyExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAiGearStrategy 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600372A RID: 14122 RVA: 0x0008C115 File Offset: 0x0008A315
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

		// Token: 0x0600372B RID: 14123 RVA: 0x0008C14E File Offset: 0x0008A34E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"RenjuStrategy",
				"RaceStrategy"
			};
		}

		// Token: 0x0600372C RID: 14124 RVA: 0x0008C166 File Offset: 0x0008A366
		public static EAiGearStrategy[] GetValues()
		{
			return new EAiGearStrategy[]
			{
				EAiGearStrategy.RenjuStrategy,
				EAiGearStrategy.RaceStrategy
			};
		}

		// Token: 0x0600372D RID: 14125 RVA: 0x0008C172 File Offset: 0x0008A372
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
