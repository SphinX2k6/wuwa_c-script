using System;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x0200024D RID: 589
	public static class EResFileExtensions
	{
		// Token: 0x06000EF5 RID: 3829 RVA: 0x000592A0 File Offset: 0x000574A0
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

		// Token: 0x06000EF6 RID: 3830 RVA: 0x000592F4 File Offset: 0x000574F4
		public static EResFile FromString(string name)
		{
			EResFile result;
			if (!EResFileExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EResFile 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x00059320 File Offset: 0x00057520
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

		// Token: 0x06000EF8 RID: 3832 RVA: 0x00059388 File Offset: 0x00057588
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

		// Token: 0x06000EF9 RID: 3833 RVA: 0x000593B0 File Offset: 0x000575B0
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

		// Token: 0x06000EFA RID: 3834 RVA: 0x000593C3 File Offset: 0x000575C3
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
