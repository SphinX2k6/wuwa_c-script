using System;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x0200007C RID: 124
	public static class EMetaTypeExtensions
	{
		// Token: 0x06000344 RID: 836 RVA: 0x000117CC File Offset: 0x0000F9CC
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

		// Token: 0x06000345 RID: 837 RVA: 0x00011804 File Offset: 0x0000FA04
		public static EMetaType FromString(string name)
		{
			EMetaType result;
			if (!EMetaTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMetaType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0001182D File Offset: 0x0000FA2D
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

		// Token: 0x06000347 RID: 839 RVA: 0x00011866 File Offset: 0x0000FA66
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"___Map___",
				"___Set___"
			};
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0001187E File Offset: 0x0000FA7E
		public static EMetaType[] GetValues()
		{
			return new EMetaType[]
			{
				EMetaType.Map,
				EMetaType.Set
			};
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0001188A File Offset: 0x0000FA8A
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
