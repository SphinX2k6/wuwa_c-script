using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009BE RID: 2494
	public static class EPasserbyNpcSourceExtensions
	{
		// Token: 0x06003788 RID: 14216 RVA: 0x00090798 File Offset: 0x0008E998
		public static string ToEnumString(this EPasserbyNpcSource value)
		{
			string result;
			if (value == EPasserbyNpcSource.Template)
			{
				result = "Template";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003789 RID: 14217 RVA: 0x000907C0 File Offset: 0x0008E9C0
		public static EPasserbyNpcSource FromString(string name)
		{
			EPasserbyNpcSource result;
			if (!EPasserbyNpcSourceExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPasserbyNpcSource 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600378A RID: 14218 RVA: 0x000907E9 File Offset: 0x0008E9E9
		public static bool TryFromString(string name, out EPasserbyNpcSource value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPasserbyNpcSource.Template;
				return false;
			}
			if (name == "Template")
			{
				value = EPasserbyNpcSource.Template;
				return true;
			}
			value = EPasserbyNpcSource.Template;
			return false;
		}

		// Token: 0x0600378B RID: 14219 RVA: 0x0009080E File Offset: 0x0008EA0E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Template"
			};
		}

		// Token: 0x0600378C RID: 14220 RVA: 0x0009081E File Offset: 0x0008EA1E
		public static EPasserbyNpcSource[] GetValues()
		{
			return new EPasserbyNpcSource[1];
		}

		// Token: 0x0600378D RID: 14221 RVA: 0x00090826 File Offset: 0x0008EA26
		public static string[] GetNames()
		{
			return new string[]
			{
				"Template"
			};
		}
	}
}
