using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012A4 RID: 4772
	public static class ETetrisPlayModeExtensions
	{
		// Token: 0x06006B89 RID: 27529 RVA: 0x00102C60 File Offset: 0x00100E60
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

		// Token: 0x06006B8A RID: 27530 RVA: 0x00102CA8 File Offset: 0x00100EA8
		public static ETetrisPlayMode FromString(string name)
		{
			ETetrisPlayMode result;
			if (!ETetrisPlayModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETetrisPlayMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006B8B RID: 27531 RVA: 0x00102CD4 File Offset: 0x00100ED4
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

		// Token: 0x06006B8C RID: 27532 RVA: 0x00102D2A File Offset: 0x00100F2A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Normal",
				"Endless",
				"MainLine"
			};
		}

		// Token: 0x06006B8D RID: 27533 RVA: 0x00102D4A File Offset: 0x00100F4A
		public static ETetrisPlayMode[] GetValues()
		{
			return new ETetrisPlayMode[]
			{
				ETetrisPlayMode.Normal,
				ETetrisPlayMode.Endless,
				ETetrisPlayMode.MainLine
			};
		}

		// Token: 0x06006B8E RID: 27534 RVA: 0x00102D5A File Offset: 0x00100F5A
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
