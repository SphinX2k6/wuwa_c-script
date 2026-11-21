using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002680 RID: 9856
	public static class ERemovePreloadResourceObjectTypeExtensions
	{
		// Token: 0x0600D49A RID: 54426 RVA: 0x001EE254 File Offset: 0x001EC454
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

		// Token: 0x0600D49B RID: 54427 RVA: 0x001EE2A8 File Offset: 0x001EC4A8
		public static ERemovePreloadResourceObjectType FromString(string name)
		{
			ERemovePreloadResourceObjectType result;
			if (!ERemovePreloadResourceObjectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERemovePreloadResourceObjectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D49C RID: 54428 RVA: 0x001EE2D4 File Offset: 0x001EC4D4
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

		// Token: 0x0600D49D RID: 54429 RVA: 0x001EE33C File Offset: 0x001EC53C
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

		// Token: 0x0600D49E RID: 54430 RVA: 0x001EE364 File Offset: 0x001EC564
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

		// Token: 0x0600D49F RID: 54431 RVA: 0x001EE377 File Offset: 0x001EC577
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
