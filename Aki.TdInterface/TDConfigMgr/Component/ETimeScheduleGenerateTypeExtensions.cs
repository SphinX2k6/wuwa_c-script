using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AFD RID: 2813
	public static class ETimeScheduleGenerateTypeExtensions
	{
		// Token: 0x06003D85 RID: 15749 RVA: 0x0009D748 File Offset: 0x0009B948
		public static string ToEnumString(this ETimeScheduleGenerateType value)
		{
			string result;
			if (value == ETimeScheduleGenerateType.FixedIntervalRefresh)
			{
				result = "FixedIntervalRefresh";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003D86 RID: 15750 RVA: 0x0009D770 File Offset: 0x0009B970
		public static ETimeScheduleGenerateType FromString(string name)
		{
			ETimeScheduleGenerateType result;
			if (!ETimeScheduleGenerateTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETimeScheduleGenerateType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003D87 RID: 15751 RVA: 0x0009D799 File Offset: 0x0009B999
		public static bool TryFromString(string name, out ETimeScheduleGenerateType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETimeScheduleGenerateType.FixedIntervalRefresh;
				return false;
			}
			if (name == "FixedIntervalRefresh")
			{
				value = ETimeScheduleGenerateType.FixedIntervalRefresh;
				return true;
			}
			value = ETimeScheduleGenerateType.FixedIntervalRefresh;
			return false;
		}

		// Token: 0x06003D88 RID: 15752 RVA: 0x0009D7BE File Offset: 0x0009B9BE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FixedIntervalRefresh"
			};
		}

		// Token: 0x06003D89 RID: 15753 RVA: 0x0009D7CE File Offset: 0x0009B9CE
		public static ETimeScheduleGenerateType[] GetValues()
		{
			return new ETimeScheduleGenerateType[1];
		}

		// Token: 0x06003D8A RID: 15754 RVA: 0x0009D7D6 File Offset: 0x0009B9D6
		public static string[] GetNames()
		{
			return new string[]
			{
				"FixedIntervalRefresh"
			};
		}
	}
}
