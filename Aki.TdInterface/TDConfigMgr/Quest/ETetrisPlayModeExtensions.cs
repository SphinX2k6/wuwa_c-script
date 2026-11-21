using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013EA RID: 5098
	public static class ETetrisPlayModeExtensions
	{
		// Token: 0x060071F7 RID: 29175 RVA: 0x00110C28 File Offset: 0x0010EE28
		public static string ToEnumString(this ETetrisPlayMode value)
		{
			string result;
			switch (value)
			{
			case ETetrisPlayMode.Normal:
				result = "Normal";
				break;
			case ETetrisPlayMode.Endless:
				result = "Endless";
				break;
			case ETetrisPlayMode.MainLine:
				result = "MainLine";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060071F8 RID: 29176 RVA: 0x00110C70 File Offset: 0x0010EE70
		public static ETetrisPlayMode FromString(string name)
		{
			ETetrisPlayMode result;
			if (!ETetrisPlayModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETetrisPlayMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060071F9 RID: 29177 RVA: 0x00110C9C File Offset: 0x0010EE9C
		public static bool TryFromString(string name, out ETetrisPlayMode value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETetrisPlayMode.Normal;
				return false;
			}
			if (name == "Normal")
			{
				value = ETetrisPlayMode.Normal;
				return true;
			}
			if (name == "Endless")
			{
				value = ETetrisPlayMode.Endless;
				return true;
			}
			if (!(name == "MainLine"))
			{
				value = ETetrisPlayMode.Normal;
				return false;
			}
			value = ETetrisPlayMode.MainLine;
			return true;
		}

		// Token: 0x060071FA RID: 29178 RVA: 0x00110CF2 File Offset: 0x0010EEF2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Normal",
				"Endless",
				"MainLine"
			};
		}

		// Token: 0x060071FB RID: 29179 RVA: 0x00110D12 File Offset: 0x0010EF12
		public static ETetrisPlayMode[] GetValues()
		{
			return new ETetrisPlayMode[]
			{
				ETetrisPlayMode.Normal,
				ETetrisPlayMode.Endless,
				ETetrisPlayMode.MainLine
			};
		}

		// Token: 0x060071FC RID: 29180 RVA: 0x00110D22 File Offset: 0x0010EF22
		public static string[] GetNames()
		{
			return new string[]
			{
				"Normal",
				"Endless",
				"MainLine"
			};
		}
	}
}
