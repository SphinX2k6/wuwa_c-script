using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A71 RID: 2673
	public static class EPasserbyNpcExitIntervalTypeExtensions
	{
		// Token: 0x06003B0F RID: 15119 RVA: 0x000987F4 File Offset: 0x000969F4
		public static string ToEnumString(this EPasserbyNpcExitIntervalType value)
		{
			string result;
			if (value == EPasserbyNpcExitIntervalType.PerNpcRandom)
			{
				result = "PerNpcRandom";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003B10 RID: 15120 RVA: 0x0009881C File Offset: 0x00096A1C
		public static EPasserbyNpcExitIntervalType FromString(string name)
		{
			EPasserbyNpcExitIntervalType result;
			if (!EPasserbyNpcExitIntervalTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPasserbyNpcExitIntervalType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003B11 RID: 15121 RVA: 0x00098845 File Offset: 0x00096A45
		public static bool TryFromString(string name, out EPasserbyNpcExitIntervalType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPasserbyNpcExitIntervalType.PerNpcRandom;
				return false;
			}
			if (name == "PerNpcRandom")
			{
				value = EPasserbyNpcExitIntervalType.PerNpcRandom;
				return true;
			}
			value = EPasserbyNpcExitIntervalType.PerNpcRandom;
			return false;
		}

		// Token: 0x06003B12 RID: 15122 RVA: 0x0009886A File Offset: 0x00096A6A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PerNpcRandom"
			};
		}

		// Token: 0x06003B13 RID: 15123 RVA: 0x0009887A File Offset: 0x00096A7A
		public static EPasserbyNpcExitIntervalType[] GetValues()
		{
			return new EPasserbyNpcExitIntervalType[1];
		}

		// Token: 0x06003B14 RID: 15124 RVA: 0x00098882 File Offset: 0x00096A82
		public static string[] GetNames()
		{
			return new string[]
			{
				"PerNpcRandom"
			};
		}
	}
}
