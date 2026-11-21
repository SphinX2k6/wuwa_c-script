using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001382 RID: 4994
	public static class EFlipperConditionStepExtensions
	{
		// Token: 0x06007023 RID: 28707 RVA: 0x0010B478 File Offset: 0x00109678
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

		// Token: 0x06007024 RID: 28708 RVA: 0x0010B4A0 File Offset: 0x001096A0
		public static EFlipperConditionStep FromString(string name)
		{
			EFlipperConditionStep result;
			if (!EFlipperConditionStepExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFlipperConditionStep 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06007025 RID: 28709 RVA: 0x0010B4C9 File Offset: 0x001096C9
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

		// Token: 0x06007026 RID: 28710 RVA: 0x0010B4EE File Offset: 0x001096EE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Fight"
			};
		}

		// Token: 0x06007027 RID: 28711 RVA: 0x0010B4FE File Offset: 0x001096FE
		public static EFlipperConditionStep[] GetValues()
		{
			return new EFlipperConditionStep[1];
		}

		// Token: 0x06007028 RID: 28712 RVA: 0x0010B506 File Offset: 0x00109706
		public static string[] GetNames()
		{
			return new string[]
			{
				"Fight"
			};
		}
	}
}
