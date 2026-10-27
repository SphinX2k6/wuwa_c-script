using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A38 RID: 2616
	public static class ETimeScheduleDistributionTypeExtensions
	{
		// Token: 0x060039AD RID: 14765 RVA: 0x00094E14 File Offset: 0x00093014
		public static string ToEnumString(this ETimeScheduleDistributionType value)
		{
			string result;
			if (value == ETimeScheduleDistributionType.RandomSchedulePosition)
			{
				result = "RandomSchedulePosition";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060039AE RID: 14766 RVA: 0x00094E3C File Offset: 0x0009303C
		public static ETimeScheduleDistributionType FromString(string name)
		{
			ETimeScheduleDistributionType result;
			if (!ETimeScheduleDistributionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETimeScheduleDistributionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060039AF RID: 14767 RVA: 0x00094E65 File Offset: 0x00093065
		public static bool TryFromString(string name, out ETimeScheduleDistributionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETimeScheduleDistributionType.RandomSchedulePosition;
				return false;
			}
			if (name == "RandomSchedulePosition")
			{
				value = ETimeScheduleDistributionType.RandomSchedulePosition;
				return true;
			}
			value = ETimeScheduleDistributionType.RandomSchedulePosition;
			return false;
		}

		// Token: 0x060039B0 RID: 14768 RVA: 0x00094E8A File Offset: 0x0009308A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"RandomSchedulePosition"
			};
		}

		// Token: 0x060039B1 RID: 14769 RVA: 0x00094E9A File Offset: 0x0009309A
		public static ETimeScheduleDistributionType[] GetValues()
		{
			return new ETimeScheduleDistributionType[1];
		}

		// Token: 0x060039B2 RID: 14770 RVA: 0x00094EA2 File Offset: 0x000930A2
		public static string[] GetNames()
		{
			return new string[]
			{
				"RandomSchedulePosition"
			};
		}
	}
}
