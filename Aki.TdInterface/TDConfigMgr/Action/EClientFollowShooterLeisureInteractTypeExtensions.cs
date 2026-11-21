using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002554 RID: 9556
	public static class EClientFollowShooterLeisureInteractTypeExtensions
	{
		// Token: 0x0600CF54 RID: 53076 RVA: 0x001E0E44 File Offset: 0x001DF044
		public static string ToEnumString(this EClientFollowShooterLeisureInteractType value)
		{
			string result;
			switch (value)
			{
			case EClientFollowShooterLeisureInteractType.PlayAnimation:
				result = "PlayAnimation";
				break;
			case EClientFollowShooterLeisureInteractType.ResetToPlayer:
				result = "ResetToPlayer";
				break;
			case EClientFollowShooterLeisureInteractType.PlaySkill:
				result = "PlaySkill";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600CF55 RID: 53077 RVA: 0x001E0E8C File Offset: 0x001DF08C
		public static EClientFollowShooterLeisureInteractType FromString(string name)
		{
			EClientFollowShooterLeisureInteractType result;
			if (!EClientFollowShooterLeisureInteractTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EClientFollowShooterLeisureInteractType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CF56 RID: 53078 RVA: 0x001E0EB8 File Offset: 0x001DF0B8
		public static bool TryFromString(string name, out EClientFollowShooterLeisureInteractType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EClientFollowShooterLeisureInteractType.PlayAnimation;
				return false;
			}
			if (name == "PlayAnimation")
			{
				value = EClientFollowShooterLeisureInteractType.PlayAnimation;
				return true;
			}
			if (name == "ResetToPlayer")
			{
				value = EClientFollowShooterLeisureInteractType.ResetToPlayer;
				return true;
			}
			if (!(name == "PlaySkill"))
			{
				value = EClientFollowShooterLeisureInteractType.PlayAnimation;
				return false;
			}
			value = EClientFollowShooterLeisureInteractType.PlaySkill;
			return true;
		}

		// Token: 0x0600CF57 RID: 53079 RVA: 0x001E0F0E File Offset: 0x001DF10E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PlayAnimation",
				"ResetToPlayer",
				"PlaySkill"
			};
		}

		// Token: 0x0600CF58 RID: 53080 RVA: 0x001E0F2E File Offset: 0x001DF12E
		public static EClientFollowShooterLeisureInteractType[] GetValues()
		{
			return new EClientFollowShooterLeisureInteractType[]
			{
				EClientFollowShooterLeisureInteractType.PlayAnimation,
				EClientFollowShooterLeisureInteractType.ResetToPlayer,
				EClientFollowShooterLeisureInteractType.PlaySkill
			};
		}

		// Token: 0x0600CF59 RID: 53081 RVA: 0x001E0F3E File Offset: 0x001DF13E
		public static string[] GetNames()
		{
			return new string[]
			{
				"PlayAnimation",
				"ResetToPlayer",
				"PlaySkill"
			};
		}
	}
}
