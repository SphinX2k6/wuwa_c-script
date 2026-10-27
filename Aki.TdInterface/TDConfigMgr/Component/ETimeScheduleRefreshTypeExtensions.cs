using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A3C RID: 2620
	public static class ETimeScheduleRefreshTypeExtensions
	{
		// Token: 0x060039BF RID: 14783 RVA: 0x00094FCC File Offset: 0x000931CC
		public static string ToEnumString(this ETimeScheduleRefreshType value)
		{
			string result;
			if (value == ETimeScheduleRefreshType.GameDaily)
			{
				result = "GameDaily";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060039C0 RID: 14784 RVA: 0x00094FF4 File Offset: 0x000931F4
		public static ETimeScheduleRefreshType FromString(string name)
		{
			ETimeScheduleRefreshType result;
			if (!ETimeScheduleRefreshTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETimeScheduleRefreshType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060039C1 RID: 14785 RVA: 0x0009501D File Offset: 0x0009321D
		public static bool TryFromString(string name, out ETimeScheduleRefreshType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETimeScheduleRefreshType.GameDaily;
				return false;
			}
			if (name == "GameDaily")
			{
				value = ETimeScheduleRefreshType.GameDaily;
				return true;
			}
			value = ETimeScheduleRefreshType.GameDaily;
			return false;
		}

		// Token: 0x060039C2 RID: 14786 RVA: 0x00095042 File Offset: 0x00093242
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"GameDaily"
			};
		}

		// Token: 0x060039C3 RID: 14787 RVA: 0x00095052 File Offset: 0x00093252
		public static ETimeScheduleRefreshType[] GetValues()
		{
			return new ETimeScheduleRefreshType[1];
		}

		// Token: 0x060039C4 RID: 14788 RVA: 0x0009505A File Offset: 0x0009325A
		public static string[] GetNames()
		{
			return new string[]
			{
				"GameDaily"
			};
		}
	}
}
