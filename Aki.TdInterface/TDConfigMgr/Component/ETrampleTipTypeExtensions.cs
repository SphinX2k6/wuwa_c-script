using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000B05 RID: 2821
	public static class ETrampleTipTypeExtensions
	{
		// Token: 0x06003DA9 RID: 15785 RVA: 0x0009DAF0 File Offset: 0x0009BCF0
		public static string ToEnumString(this ETrampleTipType value)
		{
			string result;
			if (value != ETrampleTipType.CountDownTextTip)
			{
				if (value != ETrampleTipType.MechaTrackCountDownTip)
				{
					result = value.ToString();
				}
				else
				{
					result = "MechaTrackCountDownTip";
				}
			}
			else
			{
				result = "CountDownTextTip";
			}
			return result;
		}

		// Token: 0x06003DAA RID: 15786 RVA: 0x0009DB28 File Offset: 0x0009BD28
		public static ETrampleTipType FromString(string name)
		{
			ETrampleTipType result;
			if (!ETrampleTipTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETrampleTipType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003DAB RID: 15787 RVA: 0x0009DB51 File Offset: 0x0009BD51
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
			if (!(name == "MechaTrackCountDownTip"))
			{
				value = ETrampleTipType.CountDownTextTip;
				return false;
			}
			value = ETrampleTipType.MechaTrackCountDownTip;
			return true;
		}

		// Token: 0x06003DAC RID: 15788 RVA: 0x0009DB8A File Offset: 0x0009BD8A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CountDownTextTip",
				"MechaTrackCountDownTip"
			};
		}

		// Token: 0x06003DAD RID: 15789 RVA: 0x0009DBA2 File Offset: 0x0009BDA2
		public static ETrampleTipType[] GetValues()
		{
			return new ETrampleTipType[]
			{
				ETrampleTipType.CountDownTextTip,
				ETrampleTipType.MechaTrackCountDownTip
			};
		}

		// Token: 0x06003DAE RID: 15790 RVA: 0x0009DBAE File Offset: 0x0009BDAE
		public static string[] GetNames()
		{
			return new string[]
			{
				"CountDownTextTip",
				"MechaTrackCountDownTip"
			};
		}
	}
}
