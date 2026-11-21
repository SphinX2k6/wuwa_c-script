using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026EA RID: 9962
	public static class ESystemFunctionExtensions
	{
		// Token: 0x0600D677 RID: 54903 RVA: 0x001F2824 File Offset: 0x001F0A24
		public static string ToEnumString(this ESystemFunction value)
		{
			string result;
			if (value == ESystemFunction.BuyGoods)
			{
				result = "BuyGoods";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D678 RID: 54904 RVA: 0x001F284C File Offset: 0x001F0A4C
		public static ESystemFunction FromString(string name)
		{
			ESystemFunction result;
			if (!ESystemFunctionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESystemFunction 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D679 RID: 54905 RVA: 0x001F2875 File Offset: 0x001F0A75
		public static bool TryFromString(string name, out ESystemFunction value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESystemFunction.BuyGoods;
				return false;
			}
			if (name == "BuyGoods")
			{
				value = ESystemFunction.BuyGoods;
				return true;
			}
			value = ESystemFunction.BuyGoods;
			return false;
		}

		// Token: 0x0600D67A RID: 54906 RVA: 0x001F289A File Offset: 0x001F0A9A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"BuyGoods"
			};
		}

		// Token: 0x0600D67B RID: 54907 RVA: 0x001F28AA File Offset: 0x001F0AAA
		public static ESystemFunction[] GetValues()
		{
			return new ESystemFunction[1];
		}

		// Token: 0x0600D67C RID: 54908 RVA: 0x001F28B2 File Offset: 0x001F0AB2
		public static string[] GetNames()
		{
			return new string[]
			{
				"BuyGoods"
			};
		}
	}
}
