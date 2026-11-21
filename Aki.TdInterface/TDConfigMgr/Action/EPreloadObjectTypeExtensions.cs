using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002674 RID: 9844
	public static class EPreloadObjectTypeExtensions
	{
		// Token: 0x0600D464 RID: 54372 RVA: 0x001EDA00 File Offset: 0x001EBC00
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

		// Token: 0x0600D465 RID: 54373 RVA: 0x001EDA60 File Offset: 0x001EBC60
		public static EPreloadObjectType FromString(string name)
		{
			EPreloadObjectType result;
			if (!EPreloadObjectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPreloadObjectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D466 RID: 54374 RVA: 0x001EDA8C File Offset: 0x001EBC8C
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

		// Token: 0x0600D467 RID: 54375 RVA: 0x001EDB06 File Offset: 0x001EBD06
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

		// Token: 0x0600D468 RID: 54376 RVA: 0x001EDB36 File Offset: 0x001EBD36
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

		// Token: 0x0600D469 RID: 54377 RVA: 0x001EDB49 File Offset: 0x001EBD49
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
