using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000ABD RID: 2749
	public static class ERoadNetworkNavigationTypeExtensions
	{
		// Token: 0x06003C65 RID: 15461 RVA: 0x0009AFEC File Offset: 0x000991EC
		public static string ToEnumString(this ERoadNetworkNavigationType value)
		{
			string result;
			if (value == ERoadNetworkNavigationType.Traffic)
			{
				result = "Traffic";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003C66 RID: 15462 RVA: 0x0009B014 File Offset: 0x00099214
		public static ERoadNetworkNavigationType FromString(string name)
		{
			ERoadNetworkNavigationType result;
			if (!ERoadNetworkNavigationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERoadNetworkNavigationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003C67 RID: 15463 RVA: 0x0009B03D File Offset: 0x0009923D
		public static bool TryFromString(string name, out ERoadNetworkNavigationType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERoadNetworkNavigationType.Traffic;
				return false;
			}
			if (name == "Traffic")
			{
				value = ERoadNetworkNavigationType.Traffic;
				return true;
			}
			value = ERoadNetworkNavigationType.Traffic;
			return false;
		}

		// Token: 0x06003C68 RID: 15464 RVA: 0x0009B062 File Offset: 0x00099262
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Traffic"
			};
		}

		// Token: 0x06003C69 RID: 15465 RVA: 0x0009B072 File Offset: 0x00099272
		public static ERoadNetworkNavigationType[] GetValues()
		{
			return new ERoadNetworkNavigationType[1];
		}

		// Token: 0x06003C6A RID: 15466 RVA: 0x0009B07A File Offset: 0x0009927A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Traffic"
			};
		}
	}
}
