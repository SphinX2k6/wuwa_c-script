using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009E4 RID: 2532
	public static class EPullingFoundationExtensions
	{
		// Token: 0x06003833 RID: 14387 RVA: 0x00091B8C File Offset: 0x0008FD8C
		public static string ToEnumString(this EPullingFoundation value)
		{
			string result;
			if (value == EPullingFoundation.CategoryMatching)
			{
				result = "CategoryMatching";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003834 RID: 14388 RVA: 0x00091BB4 File Offset: 0x0008FDB4
		public static EPullingFoundation FromString(string name)
		{
			EPullingFoundation result;
			if (!EPullingFoundationExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPullingFoundation 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003835 RID: 14389 RVA: 0x00091BDD File Offset: 0x0008FDDD
		public static bool TryFromString(string name, out EPullingFoundation value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPullingFoundation.CategoryMatching;
				return false;
			}
			if (name == "CategoryMatching")
			{
				value = EPullingFoundation.CategoryMatching;
				return true;
			}
			value = EPullingFoundation.CategoryMatching;
			return false;
		}

		// Token: 0x06003836 RID: 14390 RVA: 0x00091C02 File Offset: 0x0008FE02
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CategoryMatching"
			};
		}

		// Token: 0x06003837 RID: 14391 RVA: 0x00091C12 File Offset: 0x0008FE12
		public static EPullingFoundation[] GetValues()
		{
			return new EPullingFoundation[1];
		}

		// Token: 0x06003838 RID: 14392 RVA: 0x00091C1A File Offset: 0x0008FE1A
		public static string[] GetNames()
		{
			return new string[]
			{
				"CategoryMatching"
			};
		}
	}
}
