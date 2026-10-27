using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009EC RID: 2540
	public static class EReboundOptionTypeExtensions
	{
		// Token: 0x06003857 RID: 14423 RVA: 0x00091F34 File Offset: 0x00090134
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

		// Token: 0x06003858 RID: 14424 RVA: 0x00091F5C File Offset: 0x0009015C
		public static EReboundOptionType FromString(string name)
		{
			EReboundOptionType result;
			if (!EReboundOptionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EReboundOptionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003859 RID: 14425 RVA: 0x00091F85 File Offset: 0x00090185
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

		// Token: 0x0600385A RID: 14426 RVA: 0x00091FAA File Offset: 0x000901AA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ForwardFront"
			};
		}

		// Token: 0x0600385B RID: 14427 RVA: 0x00091FBA File Offset: 0x000901BA
		public static EReboundOptionType[] GetValues()
		{
			return new EReboundOptionType[1];
		}

		// Token: 0x0600385C RID: 14428 RVA: 0x00091FC2 File Offset: 0x000901C2
		public static string[] GetNames()
		{
			return new string[]
			{
				"ForwardFront"
			};
		}
	}
}
