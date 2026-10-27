using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009F8 RID: 2552
	public static class ERoadNetworkNavigationTypeExtensions
	{
		// Token: 0x0600388D RID: 14477 RVA: 0x000926FC File Offset: 0x000908FC
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

		// Token: 0x0600388E RID: 14478 RVA: 0x00092724 File Offset: 0x00090924
		public static ERoadNetworkNavigationType FromString(string name)
		{
			ERoadNetworkNavigationType result;
			if (!ERoadNetworkNavigationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERoadNetworkNavigationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600388F RID: 14479 RVA: 0x0009274D File Offset: 0x0009094D
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

		// Token: 0x06003890 RID: 14480 RVA: 0x00092772 File Offset: 0x00090972
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Traffic"
			};
		}

		// Token: 0x06003891 RID: 14481 RVA: 0x00092782 File Offset: 0x00090982
		public static ERoadNetworkNavigationType[] GetValues()
		{
			return new ERoadNetworkNavigationType[1];
		}

		// Token: 0x06003892 RID: 14482 RVA: 0x0009278A File Offset: 0x0009098A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Traffic"
			};
		}
	}
}
