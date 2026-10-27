using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023E9 RID: 9193
	public static class ERemovePreloadResourceObjectTypeExtensions
	{
		// Token: 0x0600C817 RID: 51223 RVA: 0x001D4AA8 File Offset: 0x001D2CA8
		public static string ToEnumString(this ERemovePreloadResourceObjectType value)
		{
			string result;
			switch (value)
			{
			case ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter:
				result = "RemovePreloadResourceTrialCharacter";
				break;
			case ERemovePreloadResourceObjectType.RemovePreloadResourcePhantomCharacter:
				result = "RemovePreloadResourcePhantomCharacter";
				break;
			case ERemovePreloadResourceObjectType.RemovePreloadLinkResource:
				result = "RemovePreloadLinkResource";
				break;
			case ERemovePreloadResourceObjectType.RemovePreloadFlows:
				result = "RemovePreloadFlows";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C818 RID: 51224 RVA: 0x001D4AFC File Offset: 0x001D2CFC
		public static ERemovePreloadResourceObjectType FromString(string name)
		{
			ERemovePreloadResourceObjectType result;
			if (!ERemovePreloadResourceObjectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERemovePreloadResourceObjectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C819 RID: 51225 RVA: 0x001D4B28 File Offset: 0x001D2D28
		public static bool TryFromString(string name, out ERemovePreloadResourceObjectType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter;
				return false;
			}
			if (name == "RemovePreloadResourceTrialCharacter")
			{
				value = ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter;
				return true;
			}
			if (name == "RemovePreloadResourcePhantomCharacter")
			{
				value = ERemovePreloadResourceObjectType.RemovePreloadResourcePhantomCharacter;
				return true;
			}
			if (name == "RemovePreloadLinkResource")
			{
				value = ERemovePreloadResourceObjectType.RemovePreloadLinkResource;
				return true;
			}
			if (!(name == "RemovePreloadFlows"))
			{
				value = ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter;
				return false;
			}
			value = ERemovePreloadResourceObjectType.RemovePreloadFlows;
			return true;
		}

		// Token: 0x0600C81A RID: 51226 RVA: 0x001D4B90 File Offset: 0x001D2D90
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"RemovePreloadResourceTrialCharacter",
				"RemovePreloadResourcePhantomCharacter",
				"RemovePreloadLinkResource",
				"RemovePreloadFlows"
			};
		}

		// Token: 0x0600C81B RID: 51227 RVA: 0x001D4BB8 File Offset: 0x001D2DB8
		public static ERemovePreloadResourceObjectType[] GetValues()
		{
			return new ERemovePreloadResourceObjectType[]
			{
				ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter,
				ERemovePreloadResourceObjectType.RemovePreloadResourcePhantomCharacter,
				ERemovePreloadResourceObjectType.RemovePreloadLinkResource,
				ERemovePreloadResourceObjectType.RemovePreloadFlows
			};
		}

		// Token: 0x0600C81C RID: 51228 RVA: 0x001D4BCB File Offset: 0x001D2DCB
		public static string[] GetNames()
		{
			return new string[]
			{
				"RemovePreloadResourceTrialCharacter",
				"RemovePreloadResourcePhantomCharacter",
				"RemovePreloadLinkResource",
				"RemovePreloadFlows"
			};
		}
	}
}
