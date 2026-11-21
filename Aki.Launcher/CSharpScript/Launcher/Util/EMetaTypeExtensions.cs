using System;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x0200007F RID: 127
	public static class EMetaTypeExtensions
	{
		// Token: 0x06000354 RID: 852 RVA: 0x00012650 File Offset: 0x00010850
		public static string ToEnumString(this EMetaType value)
		{
			string result;
			if (value != EMetaType.Map)
			{
				if (value != EMetaType.Set)
				{
					result = value.ToString();
				}
				else
				{
					result = "___Set___";
				}
			}
			else
			{
				result = "___Map___";
			}
			return result;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00012688 File Offset: 0x00010888
		public static EMetaType FromString(string name)
		{
			EMetaType result;
			if (!EMetaTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMetaType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x000126B1 File Offset: 0x000108B1
		public static bool TryFromString(string name, out EMetaType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMetaType.Map;
				return false;
			}
			if (name == "___Map___")
			{
				value = EMetaType.Map;
				return true;
			}
			if (!(name == "___Set___"))
			{
				value = EMetaType.Map;
				return false;
			}
			value = EMetaType.Set;
			return true;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x000126EA File Offset: 0x000108EA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"___Map___",
				"___Set___"
			};
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00012702 File Offset: 0x00010902
		public static EMetaType[] GetValues()
		{
			return new EMetaType[]
			{
				EMetaType.Map,
				EMetaType.Set
			};
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0001270E File Offset: 0x0001090E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Map",
				"Set"
			};
		}
	}
}
