using System;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A79 RID: 23161
	public static class ESolarSchoolTextPlaceholderExtensions
	{
		// Token: 0x06039177 RID: 233847 RVA: 0x00FFDADC File Offset: 0x00FFBCDC
		public static string ToEnumString(this ESolarSchoolTextPlaceholder value)
		{
			string result;
			switch (value)
			{
			case ESolarSchoolTextPlaceholder.None:
				result = "None";
				break;
			case ESolarSchoolTextPlaceholder.Rank:
				result = "Rank";
				break;
			case ESolarSchoolTextPlaceholder.Score:
				result = "Score";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06039178 RID: 233848 RVA: 0x00FFDB24 File Offset: 0x00FFBD24
		public static ESolarSchoolTextPlaceholder FromString(string name)
		{
			ESolarSchoolTextPlaceholder result;
			if (!ESolarSchoolTextPlaceholderExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESolarSchoolTextPlaceholder 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06039179 RID: 233849 RVA: 0x00FFDB50 File Offset: 0x00FFBD50
		public static bool TryFromString(string name, out ESolarSchoolTextPlaceholder value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESolarSchoolTextPlaceholder.None;
				return false;
			}
			if (name == "None")
			{
				value = ESolarSchoolTextPlaceholder.None;
				return true;
			}
			if (name == "Rank")
			{
				value = ESolarSchoolTextPlaceholder.Rank;
				return true;
			}
			if (!(name == "Score"))
			{
				value = ESolarSchoolTextPlaceholder.None;
				return false;
			}
			value = ESolarSchoolTextPlaceholder.Score;
			return true;
		}

		// Token: 0x0603917A RID: 233850 RVA: 0x00FFDBA6 File Offset: 0x00FFBDA6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"None",
				"Rank",
				"Score"
			};
		}

		// Token: 0x0603917B RID: 233851 RVA: 0x00FFDBC6 File Offset: 0x00FFBDC6
		public static ESolarSchoolTextPlaceholder[] GetValues()
		{
			return new ESolarSchoolTextPlaceholder[]
			{
				ESolarSchoolTextPlaceholder.None,
				ESolarSchoolTextPlaceholder.Rank,
				ESolarSchoolTextPlaceholder.Score
			};
		}

		// Token: 0x0603917C RID: 233852 RVA: 0x00FFDBD6 File Offset: 0x00FFBDD6
		public static string[] GetNames()
		{
			return new string[]
			{
				"None",
				"Rank",
				"Score"
			};
		}
	}
}
