using System;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x02000248 RID: 584
	public static class EResFileExtensions
	{
		// Token: 0x06000EB4 RID: 3764 RVA: 0x0005675C File Offset: 0x0005495C
		public static string ToEnumString(this EResFile value)
		{
			string result;
			switch (value)
			{
			case EResFile.PAK:
				result = ".pak";
				break;
			case EResFile.SIG:
				result = ".sig";
				break;
			case EResFile.UTOC:
				result = ".utoc";
				break;
			case EResFile.UCAS:
				result = ".ucas";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x000567B0 File Offset: 0x000549B0
		public static EResFile FromString(string name)
		{
			EResFile result;
			if (!EResFileExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EResFile 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x000567DC File Offset: 0x000549DC
		public static bool TryFromString(string name, out EResFile value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EResFile.PAK;
				return false;
			}
			if (name == ".pak")
			{
				value = EResFile.PAK;
				return true;
			}
			if (name == ".sig")
			{
				value = EResFile.SIG;
				return true;
			}
			if (name == ".utoc")
			{
				value = EResFile.UTOC;
				return true;
			}
			if (!(name == ".ucas"))
			{
				value = EResFile.PAK;
				return false;
			}
			value = EResFile.UCAS;
			return true;
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x00056844 File Offset: 0x00054A44
		public static string[] GetStringValues()
		{
			return new string[]
			{
				".pak",
				".sig",
				".utoc",
				".ucas"
			};
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x0005686C File Offset: 0x00054A6C
		public static EResFile[] GetValues()
		{
			return new EResFile[]
			{
				EResFile.PAK,
				EResFile.SIG,
				EResFile.UTOC,
				EResFile.UCAS
			};
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x0005687F File Offset: 0x00054A7F
		public static string[] GetNames()
		{
			return new string[]
			{
				"PAK",
				"SIG",
				"UTOC",
				"UCAS"
			};
		}
	}
}
