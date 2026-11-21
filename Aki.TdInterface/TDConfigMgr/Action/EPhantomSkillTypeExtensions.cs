using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002654 RID: 9812
	public static class EPhantomSkillTypeExtensions
	{
		// Token: 0x0600D3D4 RID: 54228 RVA: 0x001EC604 File Offset: 0x001EA804
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

		// Token: 0x0600D3D5 RID: 54229 RVA: 0x001EC63C File Offset: 0x001EA83C
		public static EPhantomSkillType FromString(string name)
		{
			EPhantomSkillType result;
			if (!EPhantomSkillTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPhantomSkillType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D3D6 RID: 54230 RVA: 0x001EC665 File Offset: 0x001EA865
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

		// Token: 0x0600D3D7 RID: 54231 RVA: 0x001EC69E File Offset: 0x001EA89E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"幻象.声骸角色.通用.成功表现",
				"幻象.声骸角色.通用.失败表现"
			};
		}

		// Token: 0x0600D3D8 RID: 54232 RVA: 0x001EC6B6 File Offset: 0x001EA8B6
		public static EPhantomSkillType[] GetValues()
		{
			return new EPhantomSkillType[]
			{
				EPhantomSkillType.ChallengeSuccess,
				EPhantomSkillType.ChallengeFailed
			};
		}

		// Token: 0x0600D3D9 RID: 54233 RVA: 0x001EC6C2 File Offset: 0x001EA8C2
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
