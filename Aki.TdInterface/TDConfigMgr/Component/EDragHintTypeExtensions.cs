using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009D3 RID: 2515
	public static class EDragHintTypeExtensions
	{
		// Token: 0x06003848 RID: 14408 RVA: 0x00091E84 File Offset: 0x00090084
		public static string ToEnumString(this EDragHintType value)
		{
			string result;
			switch (value)
			{
			case EDragHintType.Horizontal:
				result = "Horizontal";
				break;
			case EDragHintType.Vertical:
				result = "Vertical";
				break;
			case EDragHintType.FourWay:
				result = "FourWay";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003849 RID: 14409 RVA: 0x00091ECC File Offset: 0x000900CC
		public static EDragHintType FromString(string name)
		{
			EDragHintType result;
			if (!EDragHintTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDragHintType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600384A RID: 14410 RVA: 0x00091EF8 File Offset: 0x000900F8
		public static bool TryFromString(string name, out EDragHintType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDragHintType.Horizontal;
				return false;
			}
			if (name == "Horizontal")
			{
				value = EDragHintType.Horizontal;
				return true;
			}
			if (name == "Vertical")
			{
				value = EDragHintType.Vertical;
				return true;
			}
			if (!(name == "FourWay"))
			{
				value = EDragHintType.Horizontal;
				return false;
			}
			value = EDragHintType.FourWay;
			return true;
		}

		// Token: 0x0600384B RID: 14411 RVA: 0x00091F4E File Offset: 0x0009014E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Horizontal",
				"Vertical",
				"FourWay"
			};
		}

		// Token: 0x0600384C RID: 14412 RVA: 0x00091F6E File Offset: 0x0009016E
		public static EDragHintType[] GetValues()
		{
			return new EDragHintType[]
			{
				EDragHintType.Horizontal,
				EDragHintType.Vertical,
				EDragHintType.FourWay
			};
		}

		// Token: 0x0600384D RID: 14413 RVA: 0x00091F7E File Offset: 0x0009017E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Horizontal",
				"Vertical",
				"FourWay"
			};
		}
	}
}
