using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A53 RID: 2643
	public static class EMonsterCombatInteractionTypeExtensions
	{
		// Token: 0x06003A88 RID: 14984 RVA: 0x00097094 File Offset: 0x00095294
		public static string ToEnumString(this EMonsterCombatInteractionType value)
		{
			string result;
			if (value != EMonsterCombatInteractionType.WaterBoxStagnation)
			{
				if (value != EMonsterCombatInteractionType.FrequencyPaint)
				{
					result = value.ToString();
				}
				else
				{
					result = "FrequencyPaint";
				}
			}
			else
			{
				result = "WaterBoxStagnation";
			}
			return result;
		}

		// Token: 0x06003A89 RID: 14985 RVA: 0x000970CC File Offset: 0x000952CC
		public static EMonsterCombatInteractionType FromString(string name)
		{
			EMonsterCombatInteractionType result;
			if (!EMonsterCombatInteractionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMonsterCombatInteractionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003A8A RID: 14986 RVA: 0x000970F5 File Offset: 0x000952F5
		public static bool TryFromString(string name, out EMonsterCombatInteractionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMonsterCombatInteractionType.WaterBoxStagnation;
				return false;
			}
			if (name == "WaterBoxStagnation")
			{
				value = EMonsterCombatInteractionType.WaterBoxStagnation;
				return true;
			}
			if (!(name == "FrequencyPaint"))
			{
				value = EMonsterCombatInteractionType.WaterBoxStagnation;
				return false;
			}
			value = EMonsterCombatInteractionType.FrequencyPaint;
			return true;
		}

		// Token: 0x06003A8B RID: 14987 RVA: 0x0009712E File Offset: 0x0009532E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"WaterBoxStagnation",
				"FrequencyPaint"
			};
		}

		// Token: 0x06003A8C RID: 14988 RVA: 0x00097146 File Offset: 0x00095346
		public static EMonsterCombatInteractionType[] GetValues()
		{
			return new EMonsterCombatInteractionType[]
			{
				EMonsterCombatInteractionType.WaterBoxStagnation,
				EMonsterCombatInteractionType.FrequencyPaint
			};
		}

		// Token: 0x06003A8D RID: 14989 RVA: 0x00097152 File Offset: 0x00095352
		public static string[] GetNames()
		{
			return new string[]
			{
				"WaterBoxStagnation",
				"FrequencyPaint"
			};
		}
	}
}
