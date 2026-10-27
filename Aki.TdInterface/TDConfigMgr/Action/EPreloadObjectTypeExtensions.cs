using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023DD RID: 9181
	public static class EPreloadObjectTypeExtensions
	{
		// Token: 0x0600C7E1 RID: 51169 RVA: 0x001D4254 File Offset: 0x001D2454
		public static string ToEnumString(this EPreloadObjectType value)
		{
			string result;
			switch (value)
			{
			case EPreloadObjectType.PreloadTrialCharacterForSkill:
				result = "PreloadTrialCharacterForSkill";
				break;
			case EPreloadObjectType.PreloadPhantomCharacterForSkill:
				result = "PreloadPhantomCharacterForSkill";
				break;
			case EPreloadObjectType.PreloadFlows:
				result = "PreloadFlows";
				break;
			case EPreloadObjectType.PreloadMp4s:
				result = "PreloadMp4s";
				break;
			case EPreloadObjectType.PreloadLinkResource:
				result = "PreloadLinkResource";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C7E2 RID: 51170 RVA: 0x001D42B4 File Offset: 0x001D24B4
		public static EPreloadObjectType FromString(string name)
		{
			EPreloadObjectType result;
			if (!EPreloadObjectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPreloadObjectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C7E3 RID: 51171 RVA: 0x001D42E0 File Offset: 0x001D24E0
		public static bool TryFromString(string name, out EPreloadObjectType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPreloadObjectType.PreloadTrialCharacterForSkill;
				return false;
			}
			if (name == "PreloadTrialCharacterForSkill")
			{
				value = EPreloadObjectType.PreloadTrialCharacterForSkill;
				return true;
			}
			if (name == "PreloadPhantomCharacterForSkill")
			{
				value = EPreloadObjectType.PreloadPhantomCharacterForSkill;
				return true;
			}
			if (name == "PreloadFlows")
			{
				value = EPreloadObjectType.PreloadFlows;
				return true;
			}
			if (name == "PreloadMp4s")
			{
				value = EPreloadObjectType.PreloadMp4s;
				return true;
			}
			if (!(name == "PreloadLinkResource"))
			{
				value = EPreloadObjectType.PreloadTrialCharacterForSkill;
				return false;
			}
			value = EPreloadObjectType.PreloadLinkResource;
			return true;
		}

		// Token: 0x0600C7E4 RID: 51172 RVA: 0x001D435A File Offset: 0x001D255A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PreloadTrialCharacterForSkill",
				"PreloadPhantomCharacterForSkill",
				"PreloadFlows",
				"PreloadMp4s",
				"PreloadLinkResource"
			};
		}

		// Token: 0x0600C7E5 RID: 51173 RVA: 0x001D438A File Offset: 0x001D258A
		public static EPreloadObjectType[] GetValues()
		{
			return new EPreloadObjectType[]
			{
				EPreloadObjectType.PreloadTrialCharacterForSkill,
				EPreloadObjectType.PreloadPhantomCharacterForSkill,
				EPreloadObjectType.PreloadFlows,
				EPreloadObjectType.PreloadMp4s,
				EPreloadObjectType.PreloadLinkResource
			};
		}

		// Token: 0x0600C7E6 RID: 51174 RVA: 0x001D439D File Offset: 0x001D259D
		public static string[] GetNames()
		{
			return new string[]
			{
				"PreloadTrialCharacterForSkill",
				"PreloadPhantomCharacterForSkill",
				"PreloadFlows",
				"PreloadMp4s",
				"PreloadLinkResource"
			};
		}
	}
}
