using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001246 RID: 4678
	public static class EGradingSystemVarTypeExtensions
	{
		// Token: 0x060069E2 RID: 27106 RVA: 0x000FDA04 File Offset: 0x000FBC04
		public static string ToEnumString(this EGradingSystemVarType value)
		{
			string result;
			switch (value)
			{
			case EGradingSystemVarType.Score:
				result = "Score";
				break;
			case EGradingSystemVarType.Grade:
				result = "Grade";
				break;
			case EGradingSystemVarType.Wave:
				result = "Wave";
				break;
			case EGradingSystemVarType.CustomVar:
				result = "CustomVar";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060069E3 RID: 27107 RVA: 0x000FDA58 File Offset: 0x000FBC58
		public static EGradingSystemVarType FromString(string name)
		{
			EGradingSystemVarType result;
			if (!EGradingSystemVarTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGradingSystemVarType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060069E4 RID: 27108 RVA: 0x000FDA84 File Offset: 0x000FBC84
		public static bool TryFromString(string name, out EGradingSystemVarType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EGradingSystemVarType.Score;
				return false;
			}
			if (name == "Score")
			{
				value = EGradingSystemVarType.Score;
				return true;
			}
			if (name == "Grade")
			{
				value = EGradingSystemVarType.Grade;
				return true;
			}
			if (name == "Wave")
			{
				value = EGradingSystemVarType.Wave;
				return true;
			}
			if (!(name == "CustomVar"))
			{
				value = EGradingSystemVarType.Score;
				return false;
			}
			value = EGradingSystemVarType.CustomVar;
			return true;
		}

		// Token: 0x060069E5 RID: 27109 RVA: 0x000FDAEC File Offset: 0x000FBCEC
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Score",
				"Grade",
				"Wave",
				"CustomVar"
			};
		}

		// Token: 0x060069E6 RID: 27110 RVA: 0x000FDB14 File Offset: 0x000FBD14
		public static EGradingSystemVarType[] GetValues()
		{
			return new EGradingSystemVarType[]
			{
				EGradingSystemVarType.Score,
				EGradingSystemVarType.Grade,
				EGradingSystemVarType.Wave,
				EGradingSystemVarType.CustomVar
			};
		}

		// Token: 0x060069E7 RID: 27111 RVA: 0x000FDB27 File Offset: 0x000FBD27
		public static string[] GetNames()
		{
			return new string[]
			{
				"Score",
				"Grade",
				"Wave",
				"CustomVar"
			};
		}
	}
}
