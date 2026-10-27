using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000926 RID: 2342
	public static class EDragHintTypeExtensions
	{
		// Token: 0x060034DC RID: 13532 RVA: 0x0008A304 File Offset: 0x00088504
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

		// Token: 0x060034DD RID: 13533 RVA: 0x0008A34C File Offset: 0x0008854C
		public static EDragHintType FromString(string name)
		{
			EDragHintType result;
			if (!EDragHintTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDragHintType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060034DE RID: 13534 RVA: 0x0008A378 File Offset: 0x00088578
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

		// Token: 0x060034DF RID: 13535 RVA: 0x0008A3CE File Offset: 0x000885CE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Horizontal",
				"Vertical",
				"FourWay"
			};
		}

		// Token: 0x060034E0 RID: 13536 RVA: 0x0008A3EE File Offset: 0x000885EE
		public static EDragHintType[] GetValues()
		{
			return new EDragHintType[]
			{
				EDragHintType.Horizontal,
				EDragHintType.Vertical,
				EDragHintType.FourWay
			};
		}

		// Token: 0x060034E1 RID: 13537 RVA: 0x0008A3FE File Offset: 0x000885FE
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
