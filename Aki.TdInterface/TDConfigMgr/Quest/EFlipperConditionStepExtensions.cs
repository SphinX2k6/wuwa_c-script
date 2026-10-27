using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001242 RID: 4674
	public static class EFlipperConditionStepExtensions
	{
		// Token: 0x060069D0 RID: 27088 RVA: 0x000FD84C File Offset: 0x000FBA4C
		public static string ToEnumString(this EFlipperConditionStep value)
		{
			string result;
			if (value == EFlipperConditionStep.Fight)
			{
				result = "Fight";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060069D1 RID: 27089 RVA: 0x000FD874 File Offset: 0x000FBA74
		public static EFlipperConditionStep FromString(string name)
		{
			EFlipperConditionStep result;
			if (!EFlipperConditionStepExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFlipperConditionStep 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060069D2 RID: 27090 RVA: 0x000FD89D File Offset: 0x000FBA9D
		public static bool TryFromString(string name, out EFlipperConditionStep value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EFlipperConditionStep.Fight;
				return false;
			}
			if (name == "Fight")
			{
				value = EFlipperConditionStep.Fight;
				return true;
			}
			value = EFlipperConditionStep.Fight;
			return false;
		}

		// Token: 0x060069D3 RID: 27091 RVA: 0x000FD8C2 File Offset: 0x000FBAC2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Fight"
			};
		}

		// Token: 0x060069D4 RID: 27092 RVA: 0x000FD8D2 File Offset: 0x000FBAD2
		public static EFlipperConditionStep[] GetValues()
		{
			return new EFlipperConditionStep[1];
		}

		// Token: 0x060069D5 RID: 27093 RVA: 0x000FD8DA File Offset: 0x000FBADA
		public static string[] GetNames()
		{
			return new string[]
			{
				"Fight"
			};
		}
	}
}
