using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026E6 RID: 9958
	public static class ESwitchSubLevelsTypeExtensions
	{
		// Token: 0x0600D665 RID: 54885 RVA: 0x001F25F0 File Offset: 0x001F07F0
		public static string ToEnumString(this ESwitchSubLevelsType value)
		{
			string result;
			switch (value)
			{
			case ESwitchSubLevelsType.Directly:
				result = "Directly";
				break;
			case ESwitchSubLevelsType.Preload:
				result = "Preload";
				break;
			case ESwitchSubLevelsType.Permission:
				result = "Permission";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D666 RID: 54886 RVA: 0x001F2638 File Offset: 0x001F0838
		public static ESwitchSubLevelsType FromString(string name)
		{
			ESwitchSubLevelsType result;
			if (!ESwitchSubLevelsTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESwitchSubLevelsType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D667 RID: 54887 RVA: 0x001F2664 File Offset: 0x001F0864
		public static bool TryFromString(string name, out ESwitchSubLevelsType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESwitchSubLevelsType.Directly;
				return false;
			}
			if (name == "Directly")
			{
				value = ESwitchSubLevelsType.Directly;
				return true;
			}
			if (name == "Preload")
			{
				value = ESwitchSubLevelsType.Preload;
				return true;
			}
			if (!(name == "Permission"))
			{
				value = ESwitchSubLevelsType.Directly;
				return false;
			}
			value = ESwitchSubLevelsType.Permission;
			return true;
		}

		// Token: 0x0600D668 RID: 54888 RVA: 0x001F26BA File Offset: 0x001F08BA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Directly",
				"Preload",
				"Permission"
			};
		}

		// Token: 0x0600D669 RID: 54889 RVA: 0x001F26DA File Offset: 0x001F08DA
		public static ESwitchSubLevelsType[] GetValues()
		{
			return new ESwitchSubLevelsType[]
			{
				ESwitchSubLevelsType.Directly,
				ESwitchSubLevelsType.Preload,
				ESwitchSubLevelsType.Permission
			};
		}

		// Token: 0x0600D66A RID: 54890 RVA: 0x001F26EA File Offset: 0x001F08EA
		public static string[] GetNames()
		{
			return new string[]
			{
				"Directly",
				"Preload",
				"Permission"
			};
		}
	}
}
