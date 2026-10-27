using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200092E RID: 2350
	public static class EElementalRangeTypeExtensions
	{
		// Token: 0x06003500 RID: 13568 RVA: 0x0008A728 File Offset: 0x00088928
		public static string ToEnumString(this EElementalRangeType value)
		{
			string result;
			if (value != EElementalRangeType.BaseShape)
			{
				if (value != EElementalRangeType.TransportBox)
				{
					result = value.ToString();
				}
				else
				{
					result = "TransportBox";
				}
			}
			else
			{
				result = "BaseShape";
			}
			return result;
		}

		// Token: 0x06003501 RID: 13569 RVA: 0x0008A760 File Offset: 0x00088960
		public static EElementalRangeType FromString(string name)
		{
			EElementalRangeType result;
			if (!EElementalRangeTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EElementalRangeType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003502 RID: 13570 RVA: 0x0008A789 File Offset: 0x00088989
		public static bool TryFromString(string name, out EElementalRangeType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EElementalRangeType.BaseShape;
				return false;
			}
			if (name == "BaseShape")
			{
				value = EElementalRangeType.BaseShape;
				return true;
			}
			if (!(name == "TransportBox"))
			{
				value = EElementalRangeType.BaseShape;
				return false;
			}
			value = EElementalRangeType.TransportBox;
			return true;
		}

		// Token: 0x06003503 RID: 13571 RVA: 0x0008A7C2 File Offset: 0x000889C2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"BaseShape",
				"TransportBox"
			};
		}

		// Token: 0x06003504 RID: 13572 RVA: 0x0008A7DA File Offset: 0x000889DA
		public static EElementalRangeType[] GetValues()
		{
			return new EElementalRangeType[]
			{
				EElementalRangeType.BaseShape,
				EElementalRangeType.TransportBox
			};
		}

		// Token: 0x06003505 RID: 13573 RVA: 0x0008A7E6 File Offset: 0x000889E6
		public static string[] GetNames()
		{
			return new string[]
			{
				"BaseShape",
				"TransportBox"
			};
		}
	}
}
