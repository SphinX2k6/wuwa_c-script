using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002487 RID: 9351
	public static class ETrapDefenseTipTypeExtensions
	{
		// Token: 0x0600CADE RID: 51934 RVA: 0x001DDC04 File Offset: 0x001DBE04
		public static string ToEnumString(this ETrapDefenseTipType value)
		{
			string result;
			if (value == ETrapDefenseTipType.OpenNewAreaTip)
			{
				result = "OpenNewAreaTip";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600CADF RID: 51935 RVA: 0x001DDC2C File Offset: 0x001DBE2C
		public static ETrapDefenseTipType FromString(string name)
		{
			ETrapDefenseTipType result;
			if (!ETrapDefenseTipTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETrapDefenseTipType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CAE0 RID: 51936 RVA: 0x001DDC55 File Offset: 0x001DBE55
		public static bool TryFromString(string name, out ETrapDefenseTipType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETrapDefenseTipType.OpenNewAreaTip;
				return false;
			}
			if (name == "OpenNewAreaTip")
			{
				value = ETrapDefenseTipType.OpenNewAreaTip;
				return true;
			}
			value = ETrapDefenseTipType.OpenNewAreaTip;
			return false;
		}

		// Token: 0x0600CAE1 RID: 51937 RVA: 0x001DDC7A File Offset: 0x001DBE7A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"OpenNewAreaTip"
			};
		}

		// Token: 0x0600CAE2 RID: 51938 RVA: 0x001DDC8A File Offset: 0x001DBE8A
		public static ETrapDefenseTipType[] GetValues()
		{
			return new ETrapDefenseTipType[1];
		}

		// Token: 0x0600CAE3 RID: 51939 RVA: 0x001DDC92 File Offset: 0x001DBE92
		public static string[] GetNames()
		{
			return new string[]
			{
				"OpenNewAreaTip"
			};
		}
	}
}
