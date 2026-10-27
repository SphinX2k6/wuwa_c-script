using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023BF RID: 9151
	public static class EPhantomSkillTypeExtensions
	{
		// Token: 0x0600C75A RID: 51034 RVA: 0x001D2F6C File Offset: 0x001D116C
		public static string ToEnumString(this EPhantomSkillType value)
		{
			string result;
			if (value != EPhantomSkillType.ChallengeSuccess)
			{
				if (value != EPhantomSkillType.ChallengeFailed)
				{
					result = value.ToString();
				}
				else
				{
					result = "幻象.声骸角色.通用.失败表现";
				}
			}
			else
			{
				result = "幻象.声骸角色.通用.成功表现";
			}
			return result;
		}

		// Token: 0x0600C75B RID: 51035 RVA: 0x001D2FA4 File Offset: 0x001D11A4
		public static EPhantomSkillType FromString(string name)
		{
			EPhantomSkillType result;
			if (!EPhantomSkillTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPhantomSkillType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C75C RID: 51036 RVA: 0x001D2FCD File Offset: 0x001D11CD
		public static bool TryFromString(string name, out EPhantomSkillType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPhantomSkillType.ChallengeSuccess;
				return false;
			}
			if (name == "幻象.声骸角色.通用.成功表现")
			{
				value = EPhantomSkillType.ChallengeSuccess;
				return true;
			}
			if (!(name == "幻象.声骸角色.通用.失败表现"))
			{
				value = EPhantomSkillType.ChallengeSuccess;
				return false;
			}
			value = EPhantomSkillType.ChallengeFailed;
			return true;
		}

		// Token: 0x0600C75D RID: 51037 RVA: 0x001D3006 File Offset: 0x001D1206
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"幻象.声骸角色.通用.成功表现",
				"幻象.声骸角色.通用.失败表现"
			};
		}

		// Token: 0x0600C75E RID: 51038 RVA: 0x001D301E File Offset: 0x001D121E
		public static EPhantomSkillType[] GetValues()
		{
			return new EPhantomSkillType[]
			{
				EPhantomSkillType.ChallengeSuccess,
				EPhantomSkillType.ChallengeFailed
			};
		}

		// Token: 0x0600C75F RID: 51039 RVA: 0x001D302A File Offset: 0x001D122A
		public static string[] GetNames()
		{
			return new string[]
			{
				"ChallengeSuccess",
				"ChallengeFailed"
			};
		}
	}
}
