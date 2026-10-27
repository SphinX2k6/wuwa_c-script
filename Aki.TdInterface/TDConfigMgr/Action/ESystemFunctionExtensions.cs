using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002449 RID: 9289
	public static class ESystemFunctionExtensions
	{
		// Token: 0x0600C9C7 RID: 51655 RVA: 0x001D895C File Offset: 0x001D6B5C
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

		// Token: 0x0600C9C8 RID: 51656 RVA: 0x001D8984 File Offset: 0x001D6B84
		public static ESystemFunction FromString(string name)
		{
			ESystemFunction result;
			if (!ESystemFunctionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESystemFunction 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C9C9 RID: 51657 RVA: 0x001D89AD File Offset: 0x001D6BAD
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

		// Token: 0x0600C9CA RID: 51658 RVA: 0x001D89D2 File Offset: 0x001D6BD2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"BuyGoods"
			};
		}

		// Token: 0x0600C9CB RID: 51659 RVA: 0x001D89E2 File Offset: 0x001D6BE2
		public static ESystemFunction[] GetValues()
		{
			return new ESystemFunction[1];
		}

		// Token: 0x0600C9CC RID: 51660 RVA: 0x001D89EA File Offset: 0x001D6BEA
		public static string[] GetNames()
		{
			return new string[]
			{
				"BuyGoods"
			};
		}
	}
}
