using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200263C RID: 9788
	public static class ENpcGroupPerformNpcTypeExtensions
	{
		// Token: 0x0600D368 RID: 54120 RVA: 0x001EB810 File Offset: 0x001E9A10
		public static string ToEnumString(this ENpcGroupPerformNpcType value)
		{
			string result;
			switch (value)
			{
			case ENpcGroupPerformNpcType.LevelBCommonMale:
				result = "LevelBCommonMale";
				break;
			case ENpcGroupPerformNpcType.LevelBCommonFemale:
				result = "LevelBCommonFemale";
				break;
			case ENpcGroupPerformNpcType.EcologyBear:
				result = "EcologyBear";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D369 RID: 54121 RVA: 0x001EB858 File Offset: 0x001E9A58
		public static ENpcGroupPerformNpcType FromString(string name)
		{
			ENpcGroupPerformNpcType result;
			if (!ENpcGroupPerformNpcTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENpcGroupPerformNpcType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D36A RID: 54122 RVA: 0x001EB884 File Offset: 0x001E9A84
		public static bool TryFromString(string name, out ENpcGroupPerformNpcType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ENpcGroupPerformNpcType.LevelBCommonMale;
				return false;
			}
			if (name == "LevelBCommonMale")
			{
				value = ENpcGroupPerformNpcType.LevelBCommonMale;
				return true;
			}
			if (name == "LevelBCommonFemale")
			{
				value = ENpcGroupPerformNpcType.LevelBCommonFemale;
				return true;
			}
			if (!(name == "EcologyBear"))
			{
				value = ENpcGroupPerformNpcType.LevelBCommonMale;
				return false;
			}
			value = ENpcGroupPerformNpcType.EcologyBear;
			return true;
		}

		// Token: 0x0600D36B RID: 54123 RVA: 0x001EB8DA File Offset: 0x001E9ADA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LevelBCommonMale",
				"LevelBCommonFemale",
				"EcologyBear"
			};
		}

		// Token: 0x0600D36C RID: 54124 RVA: 0x001EB8FA File Offset: 0x001E9AFA
		public static ENpcGroupPerformNpcType[] GetValues()
		{
			return new ENpcGroupPerformNpcType[]
			{
				ENpcGroupPerformNpcType.LevelBCommonMale,
				ENpcGroupPerformNpcType.LevelBCommonFemale,
				ENpcGroupPerformNpcType.EcologyBear
			};
		}

		// Token: 0x0600D36D RID: 54125 RVA: 0x001EB90A File Offset: 0x001E9B0A
		public static string[] GetNames()
		{
			return new string[]
			{
				"LevelBCommonMale",
				"LevelBCommonFemale",
				"EcologyBear"
			};
		}
	}
}
