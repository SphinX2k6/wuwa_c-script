using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012B4 RID: 4788
	public static class EUseSkillCheckTypeExtensions
	{
		// Token: 0x06006BD1 RID: 27601 RVA: 0x00103830 File Offset: 0x00101A30
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

		// Token: 0x06006BD2 RID: 27602 RVA: 0x00103890 File Offset: 0x00101A90
		public static EUseSkillCheckType FromString(string name)
		{
			EUseSkillCheckType result;
			if (!EUseSkillCheckTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EUseSkillCheckType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006BD3 RID: 27603 RVA: 0x001038BC File Offset: 0x00101ABC
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

		// Token: 0x06006BD4 RID: 27604 RVA: 0x00103936 File Offset: 0x00101B36
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

		// Token: 0x06006BD5 RID: 27605 RVA: 0x00103966 File Offset: 0x00101B66
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

		// Token: 0x06006BD6 RID: 27606 RVA: 0x00103979 File Offset: 0x00101B79
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
