using System;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x02000279 RID: 633
	public static class TConfigVersionKeyExtensions
	{
		// Token: 0x06000F89 RID: 3977 RVA: 0x0005C0B4 File Offset: 0x0005A2B4
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

		// Token: 0x06000F8A RID: 3978 RVA: 0x0005C108 File Offset: 0x0005A308
		public static TConfigVersionKey FromString(string name)
		{
			TConfigVersionKey result;
			if (!TConfigVersionKeyExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 TConfigVersionKey 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x0005C134 File Offset: 0x0005A334
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

		// Token: 0x06000F8C RID: 3980 RVA: 0x0005C19C File Offset: 0x0005A39C
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

		// Token: 0x06000F8D RID: 3981 RVA: 0x0005C1C4 File Offset: 0x0005A3C4
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

		// Token: 0x06000F8E RID: 3982 RVA: 0x0005C1D7 File Offset: 0x0005A3D7
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
