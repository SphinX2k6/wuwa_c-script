using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013D0 RID: 5072
	public static class ESpecialGamePlayConfigTypeExtensions
	{
		// Token: 0x06007182 RID: 29058 RVA: 0x0010F16C File Offset: 0x0010D36C
		public static string ToEnumString(this ESpecialGamePlayConfigType value)
		{
			string result;
			switch (value)
			{
			case ESpecialGamePlayConfigType.Stalking:
				result = "Stalking";
				break;
			case ESpecialGamePlayConfigType.FreezeOnSight:
				result = "FreezeOnSight";
				break;
			case ESpecialGamePlayConfigType.FirstPersonTurret:
				result = "FirstPersonTurret";
				break;
			case ESpecialGamePlayConfigType.Eavesdrop:
				result = "Eavesdrop";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06007183 RID: 29059 RVA: 0x0010F1C0 File Offset: 0x0010D3C0
		public static ESpecialGamePlayConfigType FromString(string name)
		{
			ESpecialGamePlayConfigType result;
			if (!ESpecialGamePlayConfigTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESpecialGamePlayConfigType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06007184 RID: 29060 RVA: 0x0010F1EC File Offset: 0x0010D3EC
		public static bool TryFromString(string name, out ESpecialGamePlayConfigType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESpecialGamePlayConfigType.Stalking;
				return false;
			}
			if (name == "Stalking")
			{
				value = ESpecialGamePlayConfigType.Stalking;
				return true;
			}
			if (name == "FreezeOnSight")
			{
				value = ESpecialGamePlayConfigType.FreezeOnSight;
				return true;
			}
			if (name == "FirstPersonTurret")
			{
				value = ESpecialGamePlayConfigType.FirstPersonTurret;
				return true;
			}
			if (!(name == "Eavesdrop"))
			{
				value = ESpecialGamePlayConfigType.Stalking;
				return false;
			}
			value = ESpecialGamePlayConfigType.Eavesdrop;
			return true;
		}

		// Token: 0x06007185 RID: 29061 RVA: 0x0010F254 File Offset: 0x0010D454
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Stalking",
				"FreezeOnSight",
				"FirstPersonTurret",
				"Eavesdrop"
			};
		}

		// Token: 0x06007186 RID: 29062 RVA: 0x0010F27C File Offset: 0x0010D47C
		public static ESpecialGamePlayConfigType[] GetValues()
		{
			return new ESpecialGamePlayConfigType[]
			{
				ESpecialGamePlayConfigType.Stalking,
				ESpecialGamePlayConfigType.FreezeOnSight,
				ESpecialGamePlayConfigType.FirstPersonTurret,
				ESpecialGamePlayConfigType.Eavesdrop
			};
		}

		// Token: 0x06007187 RID: 29063 RVA: 0x0010F28F File Offset: 0x0010D48F
		public static string[] GetNames()
		{
			return new string[]
			{
				"Stalking",
				"FreezeOnSight",
				"FirstPersonTurret",
				"Eavesdrop"
			};
		}
	}
}
