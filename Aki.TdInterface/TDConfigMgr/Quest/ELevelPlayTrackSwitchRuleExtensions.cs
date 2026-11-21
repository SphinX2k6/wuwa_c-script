using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001392 RID: 5010
	public static class ELevelPlayTrackSwitchRuleExtensions
	{
		// Token: 0x0600706B RID: 28779 RVA: 0x0010C260 File Offset: 0x0010A460
		public static string ToEnumString(this ELevelPlayTrackSwitchRule value)
		{
			string result;
			if (value != ELevelPlayTrackSwitchRule.SwitchByLevelPlayTrack)
			{
				if (value != ELevelPlayTrackSwitchRule.SwitchByLevelPlayRange)
				{
					result = value.ToString();
				}
				else
				{
					result = "SwitchByLevelPlayRange";
				}
			}
			else
			{
				result = "SwitchByLevelPlayTrack";
			}
			return result;
		}

		// Token: 0x0600706C RID: 28780 RVA: 0x0010C298 File Offset: 0x0010A498
		public static ELevelPlayTrackSwitchRule FromString(string name)
		{
			ELevelPlayTrackSwitchRule result;
			if (!ELevelPlayTrackSwitchRuleExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELevelPlayTrackSwitchRule 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600706D RID: 28781 RVA: 0x0010C2C1 File Offset: 0x0010A4C1
		public static bool TryFromString(string name, out ELevelPlayTrackSwitchRule value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELevelPlayTrackSwitchRule.SwitchByLevelPlayTrack;
				return false;
			}
			if (name == "SwitchByLevelPlayTrack")
			{
				value = ELevelPlayTrackSwitchRule.SwitchByLevelPlayTrack;
				return true;
			}
			if (!(name == "SwitchByLevelPlayRange"))
			{
				value = ELevelPlayTrackSwitchRule.SwitchByLevelPlayTrack;
				return false;
			}
			value = ELevelPlayTrackSwitchRule.SwitchByLevelPlayRange;
			return true;
		}

		// Token: 0x0600706E RID: 28782 RVA: 0x0010C2FA File Offset: 0x0010A4FA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SwitchByLevelPlayTrack",
				"SwitchByLevelPlayRange"
			};
		}

		// Token: 0x0600706F RID: 28783 RVA: 0x0010C312 File Offset: 0x0010A512
		public static ELevelPlayTrackSwitchRule[] GetValues()
		{
			return new ELevelPlayTrackSwitchRule[]
			{
				ELevelPlayTrackSwitchRule.SwitchByLevelPlayTrack,
				ELevelPlayTrackSwitchRule.SwitchByLevelPlayRange
			};
		}

		// Token: 0x06007070 RID: 28784 RVA: 0x0010C31E File Offset: 0x0010A51E
		public static string[] GetNames()
		{
			return new string[]
			{
				"SwitchByLevelPlayTrack",
				"SwitchByLevelPlayRange"
			};
		}
	}
}
