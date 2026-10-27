using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002445 RID: 9285
	public static class ESwitchSubLevelsTypeExtensions
	{
		// Token: 0x0600C9B5 RID: 51637 RVA: 0x001D8728 File Offset: 0x001D6928
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

		// Token: 0x0600C9B6 RID: 51638 RVA: 0x001D8770 File Offset: 0x001D6970
		public static ESwitchSubLevelsType FromString(string name)
		{
			ESwitchSubLevelsType result;
			if (!ESwitchSubLevelsTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESwitchSubLevelsType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C9B7 RID: 51639 RVA: 0x001D879C File Offset: 0x001D699C
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

		// Token: 0x0600C9B8 RID: 51640 RVA: 0x001D87F2 File Offset: 0x001D69F2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Directly",
				"Preload",
				"Permission"
			};
		}

		// Token: 0x0600C9B9 RID: 51641 RVA: 0x001D8812 File Offset: 0x001D6A12
		public static ESwitchSubLevelsType[] GetValues()
		{
			return new ESwitchSubLevelsType[]
			{
				ESwitchSubLevelsType.Directly,
				ESwitchSubLevelsType.Preload,
				ESwitchSubLevelsType.Permission
			};
		}

		// Token: 0x0600C9BA RID: 51642 RVA: 0x001D8822 File Offset: 0x001D6A22
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
