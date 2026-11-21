using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002558 RID: 9560
	public static class EClientSetSeasonStateTypeExtensions
	{
		// Token: 0x0600CF66 RID: 53094 RVA: 0x001E10B0 File Offset: 0x001DF2B0
		public static string ToEnumString(this EClientSetSeasonStateType value)
		{
			string result;
			if (value != EClientSetSeasonStateType.SwitchSeason)
			{
				if (value != EClientSetSeasonStateType.LoopSeasonChange)
				{
					result = value.ToString();
				}
				else
				{
					result = "LoopSeasonChange";
				}
			}
			else
			{
				result = "SwitchSeason";
			}
			return result;
		}

		// Token: 0x0600CF67 RID: 53095 RVA: 0x001E10E8 File Offset: 0x001DF2E8
		public static EClientSetSeasonStateType FromString(string name)
		{
			EClientSetSeasonStateType result;
			if (!EClientSetSeasonStateTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EClientSetSeasonStateType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CF68 RID: 53096 RVA: 0x001E1111 File Offset: 0x001DF311
		public static bool TryFromString(string name, out EClientSetSeasonStateType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EClientSetSeasonStateType.SwitchSeason;
				return false;
			}
			if (name == "SwitchSeason")
			{
				value = EClientSetSeasonStateType.SwitchSeason;
				return true;
			}
			if (!(name == "LoopSeasonChange"))
			{
				value = EClientSetSeasonStateType.SwitchSeason;
				return false;
			}
			value = EClientSetSeasonStateType.LoopSeasonChange;
			return true;
		}

		// Token: 0x0600CF69 RID: 53097 RVA: 0x001E114A File Offset: 0x001DF34A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SwitchSeason",
				"LoopSeasonChange"
			};
		}

		// Token: 0x0600CF6A RID: 53098 RVA: 0x001E1162 File Offset: 0x001DF362
		public static EClientSetSeasonStateType[] GetValues()
		{
			return new EClientSetSeasonStateType[]
			{
				EClientSetSeasonStateType.SwitchSeason,
				EClientSetSeasonStateType.LoopSeasonChange
			};
		}

		// Token: 0x0600CF6B RID: 53099 RVA: 0x001E116E File Offset: 0x001DF36E
		public static string[] GetNames()
		{
			return new string[]
			{
				"SwitchSeason",
				"LoopSeasonChange"
			};
		}
	}
}
