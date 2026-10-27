using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001252 RID: 4690
	public static class ELevelPlayTrackSwitchRuleExtensions
	{
		// Token: 0x06006A18 RID: 27160 RVA: 0x000FE634 File Offset: 0x000FC834
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

		// Token: 0x06006A19 RID: 27161 RVA: 0x000FE66C File Offset: 0x000FC86C
		public static ELevelPlayTrackSwitchRule FromString(string name)
		{
			ELevelPlayTrackSwitchRule result;
			if (!ELevelPlayTrackSwitchRuleExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELevelPlayTrackSwitchRule 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006A1A RID: 27162 RVA: 0x000FE695 File Offset: 0x000FC895
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

		// Token: 0x06006A1B RID: 27163 RVA: 0x000FE6CE File Offset: 0x000FC8CE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SwitchByLevelPlayTrack",
				"SwitchByLevelPlayRange"
			};
		}

		// Token: 0x06006A1C RID: 27164 RVA: 0x000FE6E6 File Offset: 0x000FC8E6
		public static ELevelPlayTrackSwitchRule[] GetValues()
		{
			return new ELevelPlayTrackSwitchRule[]
			{
				ELevelPlayTrackSwitchRule.SwitchByLevelPlayTrack,
				ELevelPlayTrackSwitchRule.SwitchByLevelPlayRange
			};
		}

		// Token: 0x06006A1D RID: 27165 RVA: 0x000FE6F2 File Offset: 0x000FC8F2
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
