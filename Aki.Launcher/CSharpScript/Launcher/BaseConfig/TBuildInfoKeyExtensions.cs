using System;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x0200027B RID: 635
	public static class TBuildInfoKeyExtensions
	{
		// Token: 0x06000F92 RID: 3986 RVA: 0x0005C23C File Offset: 0x0005A43C
		public static string ToEnumString(this TBuildInfoKey value)
		{
			string result;
			switch (value)
			{
			case TBuildInfoKey.BuildId:
				result = "BuildId";
				break;
			case TBuildInfoKey.Changelist:
				result = "Changelist";
				break;
			case TBuildInfoKey.JSDebugId:
				result = "JSDebugId";
				break;
			case TBuildInfoKey.PatchVersion:
				result = "PatchVersion";
				break;
			case TBuildInfoKey.Stream:
				result = "Stream";
				break;
			case TBuildInfoKey.WaterMask:
				result = "WaterMask";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x0005C2A8 File Offset: 0x0005A4A8
		public static TBuildInfoKey FromString(string name)
		{
			TBuildInfoKey result;
			if (!TBuildInfoKeyExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 TBuildInfoKey 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x0005C2D4 File Offset: 0x0005A4D4
		public static bool TryFromString(string name, out TBuildInfoKey value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = TBuildInfoKey.BuildId;
				return false;
			}
			if (name == "BuildId")
			{
				value = TBuildInfoKey.BuildId;
				return true;
			}
			if (name == "Changelist")
			{
				value = TBuildInfoKey.Changelist;
				return true;
			}
			if (name == "JSDebugId")
			{
				value = TBuildInfoKey.JSDebugId;
				return true;
			}
			if (name == "PatchVersion")
			{
				value = TBuildInfoKey.PatchVersion;
				return true;
			}
			if (name == "Stream")
			{
				value = TBuildInfoKey.Stream;
				return true;
			}
			if (!(name == "WaterMask"))
			{
				value = TBuildInfoKey.BuildId;
				return false;
			}
			value = TBuildInfoKey.WaterMask;
			return true;
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x0005C360 File Offset: 0x0005A560
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"BuildId",
				"Changelist",
				"JSDebugId",
				"PatchVersion",
				"Stream",
				"WaterMask"
			};
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x0005C398 File Offset: 0x0005A598
		public static TBuildInfoKey[] GetValues()
		{
			return new TBuildInfoKey[]
			{
				TBuildInfoKey.BuildId,
				TBuildInfoKey.Changelist,
				TBuildInfoKey.JSDebugId,
				TBuildInfoKey.PatchVersion,
				TBuildInfoKey.Stream,
				TBuildInfoKey.WaterMask
			};
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x0005C3AB File Offset: 0x0005A5AB
		public static string[] GetNames()
		{
			return new string[]
			{
				"BuildId",
				"Changelist",
				"JSDebugId",
				"PatchVersion",
				"Stream",
				"WaterMask"
			};
		}
	}
}
