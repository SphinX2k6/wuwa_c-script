using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002349 RID: 9033
	public static class EGiantSubtitleStyleExtensions
	{
		// Token: 0x0600C547 RID: 50503 RVA: 0x001CCB5C File Offset: 0x001CAD5C
		public static string ToEnumString(this EGiantSubtitleStyle value)
		{
			string result;
			switch (value)
			{
			case EGiantSubtitleStyle.Neutral:
				result = "Neutral";
				break;
			case EGiantSubtitleStyle.Happy:
				result = "Happy";
				break;
			case EGiantSubtitleStyle.Sad:
				result = "Sad";
				break;
			case EGiantSubtitleStyle.Angry:
				result = "Angry";
				break;
			case EGiantSubtitleStyle.Curious:
				result = "Curious";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C548 RID: 50504 RVA: 0x001CCBBC File Offset: 0x001CADBC
		public static EGiantSubtitleStyle FromString(string name)
		{
			EGiantSubtitleStyle result;
			if (!EGiantSubtitleStyleExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGiantSubtitleStyle 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C549 RID: 50505 RVA: 0x001CCBE8 File Offset: 0x001CADE8
		public static bool TryFromString(string name, out EGiantSubtitleStyle value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EGiantSubtitleStyle.Neutral;
				return false;
			}
			if (name == "Neutral")
			{
				value = EGiantSubtitleStyle.Neutral;
				return true;
			}
			if (name == "Happy")
			{
				value = EGiantSubtitleStyle.Happy;
				return true;
			}
			if (name == "Sad")
			{
				value = EGiantSubtitleStyle.Sad;
				return true;
			}
			if (name == "Angry")
			{
				value = EGiantSubtitleStyle.Angry;
				return true;
			}
			if (!(name == "Curious"))
			{
				value = EGiantSubtitleStyle.Neutral;
				return false;
			}
			value = EGiantSubtitleStyle.Curious;
			return true;
		}

		// Token: 0x0600C54A RID: 50506 RVA: 0x001CCC62 File Offset: 0x001CAE62
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Neutral",
				"Happy",
				"Sad",
				"Angry",
				"Curious"
			};
		}

		// Token: 0x0600C54B RID: 50507 RVA: 0x001CCC92 File Offset: 0x001CAE92
		public static EGiantSubtitleStyle[] GetValues()
		{
			return new EGiantSubtitleStyle[]
			{
				EGiantSubtitleStyle.Neutral,
				EGiantSubtitleStyle.Happy,
				EGiantSubtitleStyle.Sad,
				EGiantSubtitleStyle.Angry,
				EGiantSubtitleStyle.Curious
			};
		}

		// Token: 0x0600C54C RID: 50508 RVA: 0x001CCCA5 File Offset: 0x001CAEA5
		public static string[] GetNames()
		{
			return new string[]
			{
				"Neutral",
				"Happy",
				"Sad",
				"Angry",
				"Curious"
			};
		}
	}
}
