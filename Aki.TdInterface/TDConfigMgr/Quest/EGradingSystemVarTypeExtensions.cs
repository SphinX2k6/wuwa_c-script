using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001386 RID: 4998
	public static class EGradingSystemVarTypeExtensions
	{
		// Token: 0x06007035 RID: 28725 RVA: 0x0010B630 File Offset: 0x00109830
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

		// Token: 0x06007036 RID: 28726 RVA: 0x0010B684 File Offset: 0x00109884
		public static EGradingSystemVarType FromString(string name)
		{
			EGradingSystemVarType result;
			if (!EGradingSystemVarTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGradingSystemVarType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06007037 RID: 28727 RVA: 0x0010B6B0 File Offset: 0x001098B0
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

		// Token: 0x06007038 RID: 28728 RVA: 0x0010B718 File Offset: 0x00109918
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

		// Token: 0x06007039 RID: 28729 RVA: 0x0010B740 File Offset: 0x00109940
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

		// Token: 0x0600703A RID: 28730 RVA: 0x0010B753 File Offset: 0x00109953
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
