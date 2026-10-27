using System;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x02000274 RID: 628
	public static class TBuildInfoKeyExtensions
	{
		// Token: 0x06000F47 RID: 3911 RVA: 0x00059298 File Offset: 0x00057498
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

		// Token: 0x06000F48 RID: 3912 RVA: 0x00059304 File Offset: 0x00057504
		public static TBuildInfoKey FromString(string name)
		{
			TBuildInfoKey result;
			if (!TBuildInfoKeyExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 TBuildInfoKey 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x00059330 File Offset: 0x00057530
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

		// Token: 0x06000F4A RID: 3914 RVA: 0x000593BC File Offset: 0x000575BC
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

		// Token: 0x06000F4B RID: 3915 RVA: 0x000593F4 File Offset: 0x000575F4
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

		// Token: 0x06000F4C RID: 3916 RVA: 0x00059407 File Offset: 0x00057607
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
