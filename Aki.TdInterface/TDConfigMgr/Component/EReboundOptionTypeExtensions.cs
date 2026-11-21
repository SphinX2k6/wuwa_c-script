using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AB1 RID: 2737
	public static class EReboundOptionTypeExtensions
	{
		// Token: 0x06003C2F RID: 15407 RVA: 0x0009A7F4 File Offset: 0x000989F4
		public static string ToEnumString(this EReboundOptionType value)
		{
			string result;
			if (value == EReboundOptionType.ForwardFront)
			{
				result = "ForwardFront";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003C30 RID: 15408 RVA: 0x0009A81C File Offset: 0x00098A1C
		public static EReboundOptionType FromString(string name)
		{
			EReboundOptionType result;
			if (!EReboundOptionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EReboundOptionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003C31 RID: 15409 RVA: 0x0009A845 File Offset: 0x00098A45
		public static bool TryFromString(string name, out EReboundOptionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EReboundOptionType.ForwardFront;
				return false;
			}
			if (name == "ForwardFront")
			{
				value = EReboundOptionType.ForwardFront;
				return true;
			}
			value = EReboundOptionType.ForwardFront;
			return false;
		}

		// Token: 0x06003C32 RID: 15410 RVA: 0x0009A86A File Offset: 0x00098A6A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ForwardFront"
			};
		}

		// Token: 0x06003C33 RID: 15411 RVA: 0x0009A87A File Offset: 0x00098A7A
		public static EReboundOptionType[] GetValues()
		{
			return new EReboundOptionType[1];
		}

		// Token: 0x06003C34 RID: 15412 RVA: 0x0009A882 File Offset: 0x00098A82
		public static string[] GetNames()
		{
			return new string[]
			{
				"ForwardFront"
			};
		}
	}
}
