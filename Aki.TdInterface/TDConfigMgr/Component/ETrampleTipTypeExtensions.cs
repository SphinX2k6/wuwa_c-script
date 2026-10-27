using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A40 RID: 2624
	public static class ETrampleTipTypeExtensions
	{
		// Token: 0x060039D1 RID: 14801 RVA: 0x000951BC File Offset: 0x000933BC
		public static string ToEnumString(this ETrampleTipType value)
		{
			string result;
			if (value == ETrampleTipType.CountDownTextTip)
			{
				result = "CountDownTextTip";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060039D2 RID: 14802 RVA: 0x000951E4 File Offset: 0x000933E4
		public static ETrampleTipType FromString(string name)
		{
			ETrampleTipType result;
			if (!ETrampleTipTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETrampleTipType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060039D3 RID: 14803 RVA: 0x0009520D File Offset: 0x0009340D
		public static bool TryFromString(string name, out ETrampleTipType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETrampleTipType.CountDownTextTip;
				return false;
			}
			if (name == "CountDownTextTip")
			{
				value = ETrampleTipType.CountDownTextTip;
				return true;
			}
			value = ETrampleTipType.CountDownTextTip;
			return false;
		}

		// Token: 0x060039D4 RID: 14804 RVA: 0x00095232 File Offset: 0x00093432
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CountDownTextTip"
			};
		}

		// Token: 0x060039D5 RID: 14805 RVA: 0x00095242 File Offset: 0x00093442
		public static ETrampleTipType[] GetValues()
		{
			return new ETrampleTipType[1];
		}

		// Token: 0x060039D6 RID: 14806 RVA: 0x0009524A File Offset: 0x0009344A
		public static string[] GetNames()
		{
			return new string[]
			{
				"CountDownTextTip"
			};
		}
	}
}
