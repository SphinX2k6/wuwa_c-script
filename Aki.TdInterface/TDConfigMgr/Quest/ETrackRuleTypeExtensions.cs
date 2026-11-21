using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013F0 RID: 5104
	public static class ETrackRuleTypeExtensions
	{
		// Token: 0x06007212 RID: 29202 RVA: 0x00110F70 File Offset: 0x0010F170
		public static string ToEnumString(this ETrackRuleType value)
		{
			string result;
			if (value != ETrackRuleType.FindLastMatchState)
			{
				if (value != ETrackRuleType.FindFirstNotMatchState)
				{
					result = value.ToString();
				}
				else
				{
					result = "FindFirstNotMatchState";
				}
			}
			else
			{
				result = "FindLastMatchState";
			}
			return result;
		}

		// Token: 0x06007213 RID: 29203 RVA: 0x00110FA8 File Offset: 0x0010F1A8
		public static ETrackRuleType FromString(string name)
		{
			ETrackRuleType result;
			if (!ETrackRuleTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETrackRuleType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06007214 RID: 29204 RVA: 0x00110FD1 File Offset: 0x0010F1D1
		public static bool TryFromString(string name, out ETrackRuleType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETrackRuleType.FindLastMatchState;
				return false;
			}
			if (name == "FindLastMatchState")
			{
				value = ETrackRuleType.FindLastMatchState;
				return true;
			}
			if (!(name == "FindFirstNotMatchState"))
			{
				value = ETrackRuleType.FindLastMatchState;
				return false;
			}
			value = ETrackRuleType.FindFirstNotMatchState;
			return true;
		}

		// Token: 0x06007215 RID: 29205 RVA: 0x0011100A File Offset: 0x0010F20A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FindLastMatchState",
				"FindFirstNotMatchState"
			};
		}

		// Token: 0x06007216 RID: 29206 RVA: 0x00111022 File Offset: 0x0010F222
		public static ETrackRuleType[] GetValues()
		{
			return new ETrackRuleType[]
			{
				ETrackRuleType.FindLastMatchState,
				ETrackRuleType.FindFirstNotMatchState
			};
		}

		// Token: 0x06007217 RID: 29207 RVA: 0x0011102E File Offset: 0x0010F22E
		public static string[] GetNames()
		{
			return new string[]
			{
				"FindLastMatchState",
				"FindFirstNotMatchState"
			};
		}
	}
}
