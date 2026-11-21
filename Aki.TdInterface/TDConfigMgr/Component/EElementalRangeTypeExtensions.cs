using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009DB RID: 2523
	public static class EElementalRangeTypeExtensions
	{
		// Token: 0x0600386C RID: 14444 RVA: 0x000922A8 File Offset: 0x000904A8
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

		// Token: 0x0600386D RID: 14445 RVA: 0x000922E0 File Offset: 0x000904E0
		public static EElementalRangeType FromString(string name)
		{
			EElementalRangeType result;
			if (!EElementalRangeTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EElementalRangeType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600386E RID: 14446 RVA: 0x00092309 File Offset: 0x00090509
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

		// Token: 0x0600386F RID: 14447 RVA: 0x00092342 File Offset: 0x00090542
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"BaseShape",
				"TransportBox"
			};
		}

		// Token: 0x06003870 RID: 14448 RVA: 0x0009235A File Offset: 0x0009055A
		public static EElementalRangeType[] GetValues()
		{
			return new EElementalRangeType[]
			{
				EElementalRangeType.BaseShape,
				EElementalRangeType.TransportBox
			};
		}

		// Token: 0x06003871 RID: 14449 RVA: 0x00092366 File Offset: 0x00090566
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
