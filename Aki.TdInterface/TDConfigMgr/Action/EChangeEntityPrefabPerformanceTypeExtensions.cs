using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002542 RID: 9538
	public static class EChangeEntityPrefabPerformanceTypeExtensions
	{
		// Token: 0x0600CF03 RID: 52995 RVA: 0x001E0478 File Offset: 0x001DE678
		public static string ToEnumString(this EChangeEntityPrefabPerformanceType value)
		{
			string result;
			if (value != EChangeEntityPrefabPerformanceType.Target)
			{
				if (value != EChangeEntityPrefabPerformanceType.Self)
				{
					result = value.ToString();
				}
				else
				{
					result = "Self";
				}
			}
			else
			{
				result = "Target";
			}
			return result;
		}

		// Token: 0x0600CF04 RID: 52996 RVA: 0x001E04B0 File Offset: 0x001DE6B0
		public static EChangeEntityPrefabPerformanceType FromString(string name)
		{
			EChangeEntityPrefabPerformanceType result;
			if (!EChangeEntityPrefabPerformanceTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EChangeEntityPrefabPerformanceType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CF05 RID: 52997 RVA: 0x001E04D9 File Offset: 0x001DE6D9
		public static bool TryFromString(string name, out EChangeEntityPrefabPerformanceType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EChangeEntityPrefabPerformanceType.Target;
				return false;
			}
			if (name == "Target")
			{
				value = EChangeEntityPrefabPerformanceType.Target;
				return true;
			}
			if (!(name == "Self"))
			{
				value = EChangeEntityPrefabPerformanceType.Target;
				return false;
			}
			value = EChangeEntityPrefabPerformanceType.Self;
			return true;
		}

		// Token: 0x0600CF06 RID: 52998 RVA: 0x001E0512 File Offset: 0x001DE712
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Target",
				"Self"
			};
		}

		// Token: 0x0600CF07 RID: 52999 RVA: 0x001E052A File Offset: 0x001DE72A
		public static EChangeEntityPrefabPerformanceType[] GetValues()
		{
			return new EChangeEntityPrefabPerformanceType[]
			{
				EChangeEntityPrefabPerformanceType.Target,
				EChangeEntityPrefabPerformanceType.Self
			};
		}

		// Token: 0x0600CF08 RID: 53000 RVA: 0x001E0536 File Offset: 0x001DE736
		public static string[] GetNames()
		{
			return new string[]
			{
				"Target",
				"Self"
			};
		}
	}
}
