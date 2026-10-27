using System;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x02000272 RID: 626
	public static class TConfigVersionKeyExtensions
	{
		// Token: 0x06000F3E RID: 3902 RVA: 0x00059110 File Offset: 0x00057310
		public static string ToEnumString(this TConfigVersionKey value)
		{
			string result;
			switch (value)
			{
			case TConfigVersionKey.FsmVersion:
				result = "FsmVersion";
				break;
			case TConfigVersionKey.MiscVersion:
				result = "MiscVersion";
				break;
			case TConfigVersionKey.PublicJsonVersion:
				result = "PublicJsonVersion";
				break;
			case TConfigVersionKey.UniverseEditorVersion:
				result = "UniverseEditorVersion";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x00059164 File Offset: 0x00057364
		public static TConfigVersionKey FromString(string name)
		{
			TConfigVersionKey result;
			if (!TConfigVersionKeyExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 TConfigVersionKey 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x00059190 File Offset: 0x00057390
		public static bool TryFromString(string name, out TConfigVersionKey value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = TConfigVersionKey.FsmVersion;
				return false;
			}
			if (name == "FsmVersion")
			{
				value = TConfigVersionKey.FsmVersion;
				return true;
			}
			if (name == "MiscVersion")
			{
				value = TConfigVersionKey.MiscVersion;
				return true;
			}
			if (name == "PublicJsonVersion")
			{
				value = TConfigVersionKey.PublicJsonVersion;
				return true;
			}
			if (!(name == "UniverseEditorVersion"))
			{
				value = TConfigVersionKey.FsmVersion;
				return false;
			}
			value = TConfigVersionKey.UniverseEditorVersion;
			return true;
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x000591F8 File Offset: 0x000573F8
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FsmVersion",
				"MiscVersion",
				"PublicJsonVersion",
				"UniverseEditorVersion"
			};
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x00059220 File Offset: 0x00057420
		public static TConfigVersionKey[] GetValues()
		{
			return new TConfigVersionKey[]
			{
				TConfigVersionKey.FsmVersion,
				TConfigVersionKey.MiscVersion,
				TConfigVersionKey.PublicJsonVersion,
				TConfigVersionKey.UniverseEditorVersion
			};
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x00059233 File Offset: 0x00057433
		public static string[] GetNames()
		{
			return new string[]
			{
				"FsmVersion",
				"MiscVersion",
				"PublicJsonVersion",
				"UniverseEditorVersion"
			};
		}
	}
}
