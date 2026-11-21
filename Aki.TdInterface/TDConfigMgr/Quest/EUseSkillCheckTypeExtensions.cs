using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013FA RID: 5114
	public static class EUseSkillCheckTypeExtensions
	{
		// Token: 0x0600723F RID: 29247 RVA: 0x001117F8 File Offset: 0x0010F9F8
		public static string ToEnumString(this EUseSkillCheckType value)
		{
			string result;
			switch (value)
			{
			case EUseSkillCheckType.CheckSkillGenre:
				result = "CheckBySkillGenre";
				break;
			case EUseSkillCheckType.CheckSkillId:
				result = "CheckBySkillId";
				break;
			case EUseSkillCheckType.CheckVisionSummonId:
				result = "CheckVisionSummonId";
				break;
			case EUseSkillCheckType.CheckVisionShowId:
				result = "CheckVisionShowId";
				break;
			case EUseSkillCheckType.CheckFollowShooterSkillId:
				result = "CheckFollowShooterSkillId";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06007240 RID: 29248 RVA: 0x00111858 File Offset: 0x0010FA58
		public static EUseSkillCheckType FromString(string name)
		{
			EUseSkillCheckType result;
			if (!EUseSkillCheckTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EUseSkillCheckType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06007241 RID: 29249 RVA: 0x00111884 File Offset: 0x0010FA84
		public static bool TryFromString(string name, out EUseSkillCheckType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EUseSkillCheckType.CheckSkillGenre;
				return false;
			}
			if (name == "CheckBySkillGenre")
			{
				value = EUseSkillCheckType.CheckSkillGenre;
				return true;
			}
			if (name == "CheckBySkillId")
			{
				value = EUseSkillCheckType.CheckSkillId;
				return true;
			}
			if (name == "CheckVisionSummonId")
			{
				value = EUseSkillCheckType.CheckVisionSummonId;
				return true;
			}
			if (name == "CheckVisionShowId")
			{
				value = EUseSkillCheckType.CheckVisionShowId;
				return true;
			}
			if (!(name == "CheckFollowShooterSkillId"))
			{
				value = EUseSkillCheckType.CheckSkillGenre;
				return false;
			}
			value = EUseSkillCheckType.CheckFollowShooterSkillId;
			return true;
		}

		// Token: 0x06007242 RID: 29250 RVA: 0x001118FE File Offset: 0x0010FAFE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CheckBySkillGenre",
				"CheckBySkillId",
				"CheckVisionSummonId",
				"CheckVisionShowId",
				"CheckFollowShooterSkillId"
			};
		}

		// Token: 0x06007243 RID: 29251 RVA: 0x0011192E File Offset: 0x0010FB2E
		public static EUseSkillCheckType[] GetValues()
		{
			return new EUseSkillCheckType[]
			{
				EUseSkillCheckType.CheckSkillGenre,
				EUseSkillCheckType.CheckSkillId,
				EUseSkillCheckType.CheckVisionSummonId,
				EUseSkillCheckType.CheckVisionShowId,
				EUseSkillCheckType.CheckFollowShooterSkillId
			};
		}

		// Token: 0x06007244 RID: 29252 RVA: 0x00111941 File Offset: 0x0010FB41
		public static string[] GetNames()
		{
			return new string[]
			{
				"CheckSkillGenre",
				"CheckSkillId",
				"CheckVisionSummonId",
				"CheckVisionShowId",
				"CheckFollowShooterSkillId"
			};
		}
	}
}
