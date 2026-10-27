using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001290 RID: 4752
	public static class ESpecialGamePlayConfigTypeExtensions
	{
		// Token: 0x06006B2F RID: 27439 RVA: 0x00101470 File Offset: 0x000FF670
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

		// Token: 0x06006B30 RID: 27440 RVA: 0x001014C4 File Offset: 0x000FF6C4
		public static ESpecialGamePlayConfigType FromString(string name)
		{
			ESpecialGamePlayConfigType result;
			if (!ESpecialGamePlayConfigTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESpecialGamePlayConfigType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006B31 RID: 27441 RVA: 0x001014F0 File Offset: 0x000FF6F0
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

		// Token: 0x06006B32 RID: 27442 RVA: 0x00101558 File Offset: 0x000FF758
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

		// Token: 0x06006B33 RID: 27443 RVA: 0x00101580 File Offset: 0x000FF780
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

		// Token: 0x06006B34 RID: 27444 RVA: 0x00101593 File Offset: 0x000FF793
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
