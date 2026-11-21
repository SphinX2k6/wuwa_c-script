using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A7D RID: 2685
	public static class EPasserbyNpcSourceExtensions
	{
		// Token: 0x06003B45 RID: 15173 RVA: 0x00098D54 File Offset: 0x00096F54
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

		// Token: 0x06003B46 RID: 15174 RVA: 0x00098D7C File Offset: 0x00096F7C
		public static EPasserbyNpcSource FromString(string name)
		{
			EPasserbyNpcSource result;
			if (!EPasserbyNpcSourceExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPasserbyNpcSource 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003B47 RID: 15175 RVA: 0x00098DA5 File Offset: 0x00096FA5
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

		// Token: 0x06003B48 RID: 15176 RVA: 0x00098DCA File Offset: 0x00096FCA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Template"
			};
		}

		// Token: 0x06003B49 RID: 15177 RVA: 0x00098DDA File Offset: 0x00096FDA
		public static EPasserbyNpcSource[] GetValues()
		{
			return new EPasserbyNpcSource[1];
		}

		// Token: 0x06003B4A RID: 15178 RVA: 0x00098DE2 File Offset: 0x00096FE2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Template"
			};
		}
	}
}
