using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012AA RID: 4778
	public static class ETrackRuleTypeExtensions
	{
		// Token: 0x06006BA4 RID: 27556 RVA: 0x00102FA8 File Offset: 0x001011A8
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

		// Token: 0x06006BA5 RID: 27557 RVA: 0x00102FE0 File Offset: 0x001011E0
		public static ETrackRuleType FromString(string name)
		{
			ETrackRuleType result;
			if (!ETrackRuleTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETrackRuleType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006BA6 RID: 27558 RVA: 0x00103009 File Offset: 0x00101209
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

		// Token: 0x06006BA7 RID: 27559 RVA: 0x00103042 File Offset: 0x00101242
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FindLastMatchState",
				"FindFirstNotMatchState"
			};
		}

		// Token: 0x06006BA8 RID: 27560 RVA: 0x0010305A File Offset: 0x0010125A
		public static ETrackRuleType[] GetValues()
		{
			return new ETrackRuleType[]
			{
				ETrackRuleType.FindLastMatchState,
				ETrackRuleType.FindFirstNotMatchState
			};
		}

		// Token: 0x06006BA9 RID: 27561 RVA: 0x00103066 File Offset: 0x00101266
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
