using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000B01 RID: 2817
	public static class ETimeScheduleRefreshPositionTypeExtensions
	{
		// Token: 0x06003D97 RID: 15767 RVA: 0x0009D900 File Offset: 0x0009BB00
		public static string ToEnumString(this ETimeScheduleRefreshPositionType value)
		{
			string result;
			if (value == ETimeScheduleRefreshPositionType.FixedPositions)
			{
				result = "FixedPositions";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003D98 RID: 15768 RVA: 0x0009D928 File Offset: 0x0009BB28
		public static ETimeScheduleRefreshPositionType FromString(string name)
		{
			ETimeScheduleRefreshPositionType result;
			if (!ETimeScheduleRefreshPositionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETimeScheduleRefreshPositionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003D99 RID: 15769 RVA: 0x0009D951 File Offset: 0x0009BB51
		public static bool TryFromString(string name, out ETimeScheduleRefreshPositionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETimeScheduleRefreshPositionType.FixedPositions;
				return false;
			}
			if (name == "FixedPositions")
			{
				value = ETimeScheduleRefreshPositionType.FixedPositions;
				return true;
			}
			value = ETimeScheduleRefreshPositionType.FixedPositions;
			return false;
		}

		// Token: 0x06003D9A RID: 15770 RVA: 0x0009D976 File Offset: 0x0009BB76
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FixedPositions"
			};
		}

		// Token: 0x06003D9B RID: 15771 RVA: 0x0009D986 File Offset: 0x0009BB86
		public static ETimeScheduleRefreshPositionType[] GetValues()
		{
			return new ETimeScheduleRefreshPositionType[1];
		}

		// Token: 0x06003D9C RID: 15772 RVA: 0x0009D98E File Offset: 0x0009BB8E
		public static string[] GetNames()
		{
			return new string[]
			{
				"FixedPositions"
			};
		}
	}
}
